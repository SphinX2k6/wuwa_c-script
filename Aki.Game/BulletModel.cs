using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Core.Fight;
using AkiClient.Game.Aki.Core.Fight.Bullet;
using AkiClient.Game.Aki.Data.Fight;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.CombatMessage;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x02002371 RID: 9073
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class BulletModel : ModelBase
{
	// Token: 0x060165BD RID: 91581 RVA: 0x006823D0 File Offset: 0x006805D0
	public OrderedDictionary<int, BulletEntity> GetBulletEntityMap()
	{
		return this.BulletEntityMap;
	}

	// Token: 0x060165BE RID: 91582 RVA: 0x006823D8 File Offset: 0x006805D8
	[NullableContext(2)]
	public BulletEntity GetBulletEntityById(int id)
	{
		BulletEntity result;
		this.BulletEntityMap.TryGetValue(id, out result);
		return result;
	}

	// Token: 0x060165BF RID: 91583 RVA: 0x006823F8 File Offset: 0x006805F8
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public IReadOnlyCollection<BulletEntity> GetBulletSetByAttacker(int attackerEntityId)
	{
		OrderedSet<BulletEntity> result;
		this.AttackerBullet.TryGetValue(attackerEntityId, out result);
		return result;
	}

	// Token: 0x060165C0 RID: 91584 RVA: 0x00682415 File Offset: 0x00680615
	public IEnumerable<OrderedSet<BulletEntity>> GetAttackerBulletIterator()
	{
		return this.AttackerBullet.Values;
	}

	// Token: 0x060165C1 RID: 91585 RVA: 0x00682422 File Offset: 0x00680622
	public IEnumerable<int> GetAttackers()
	{
		return this.AttackerBullet.Keys;
	}

	// Token: 0x170022D6 RID: 8918
	// (get) Token: 0x060165C2 RID: 91586 RVA: 0x0068242F File Offset: 0x0068062F
	public int OnHitMaterialMsDelay
	{
		get
		{
			return this.OnHitMaterialDelayMsInternal;
		}
	}

	// Token: 0x170022D7 RID: 8919
	// (get) Token: 0x060165C3 RID: 91587 RVA: 0x00682437 File Offset: 0x00680637
	// (set) Token: 0x060165C4 RID: 91588 RVA: 0x00682440 File Offset: 0x00680640
	public bool OpenHitMaterial
	{
		get
		{
			return this.OpenHitMaterialInternal;
		}
		set
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Bullet;
			ELogAuthor author = ELogAuthor.HCW;
			string message = "Set Bullet Func OpenHitMaterial";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("val", value);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.OpenHitMaterialInternal = value;
		}
	}

	// Token: 0x060165C5 RID: 91589 RVA: 0x00682480 File Offset: 0x00680680
	protected override bool OnInit()
	{
		ResourceSystem.Instance.LoadAsync<BulletCommonDataAsset_C>("/Game/Aki/Data/Fight/BulletDataAsset/DA_CommonBullet.DA_CommonBullet", delegate([Nullable(2)] BulletCommonDataAsset_C result, string path)
		{
			this.CommonConfig = result;
			this.OnHitMaterialDelayMsInternal = (int)(result.OnHitMaterialDelay * 1000f);
		}, 100, "js_undefined");
		for (int i = 0; i < BulletModel.MaxBulletEntitySetCacheCount; i++)
		{
			this.BulletEntitySets.Add(new OrderedSet<BulletEntity>());
		}
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Add<PlotInfo>(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnPlotStart));
		EventSystem.Instance.Add<PlotResultInfo>(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.OnPlotEnd));
		EventSystem.Instance.Add<ERemoveEntityType, EntityHandle>(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		this.InitBulletVictimPerformData();
		this.SummonerSummonedCreatureDataIds = new Dictionary<int, HashSet<long>>();
		this.SummonedCreatureDataIdToSummoner = new Dictionary<long, int>();
		return true;
	}

	// Token: 0x060165C6 RID: 91590 RVA: 0x0068255D File Offset: 0x0068075D
	private void OnWorldDone()
	{
		BulletActorPool.Preload();
		BulletConfig.Instance.PreloadCommonWhitelist();
	}

	// Token: 0x060165C7 RID: 91591 RVA: 0x00682570 File Offset: 0x00680770
	public bool IsBulletHit(int entityId)
	{
		bool flag;
		return this.MapBulletHit.TryGetValue(entityId, out flag) && flag;
	}

	// Token: 0x060165C8 RID: 91592 RVA: 0x0068258D File Offset: 0x0068078D
	private void OnBulletHit(global::HitInformation hitData, [Nullable(2)] IAttributeSet attackerAttribute)
	{
		this.MapBulletHit[hitData.BulletEntityId] = true;
	}

	// Token: 0x060165C9 RID: 91593 RVA: 0x006825A4 File Offset: 0x006807A4
	private void ClearBulletEntities()
	{
		foreach (BulletEntity obj in this.BulletEntityMap.Values)
		{
			BulletPool.RecycleBulletEntity(obj);
		}
		this.BulletEntityMap.Clear();
		foreach (OrderedSet<BulletEntity> orderedSet in this.AttackerBullet.Values)
		{
			orderedSet.Clear();
			this.BulletEntitySets.Add(orderedSet);
		}
		this.AttackerBullet.Clear();
		this.HandleToEntityIdDict.Clear();
		this.EntityIdToHandleDict.Clear();
	}

	// Token: 0x060165CA RID: 91594 RVA: 0x00682678 File Offset: 0x00680878
	protected override bool OnLeaveLevel()
	{
		this.ClearBulletEntities();
		BulletActorPool.Clear();
		BulletTraceElementPool.Clear();
		BulletMoveInfo.StickGroundLineTrace = null;
		BulletMoveInfo.StickWaterLineTrace = null;
		BulletMoveInfo.StickWaterSphereTrace = null;
		this.ClearPersistentTimeScale();
		this.SceneBulletOwnerId = 0L;
		this.ClearWaitSceneBulletOwnerTask();
		this.ForceDestroyKuroBulletWorld();
		this.StopKscBullet();
		return true;
	}

	// Token: 0x060165CB RID: 91595 RVA: 0x006826C8 File Offset: 0x006808C8
	protected override bool OnChangeMode()
	{
		this.ClearBulletEntities();
		return true;
	}

	// Token: 0x060165CC RID: 91596 RVA: 0x006826D4 File Offset: 0x006808D4
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Remove(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnPlotStart));
		EventSystem.Instance.Remove(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.OnPlotEnd));
		EventSystem.Instance.Remove(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		this.DefaultBulletSceneInteraction = null;
		this.CommonConfig = null;
		BulletActorPool.Clear();
		BulletTraceElementPool.Clear();
		this.MapCustomKey.Clear();
		this.CustomBulletAttacker.Clear();
		this.PatternOwnerEntityIds.Clear();
		this.BulletEntitySets.Clear();
		this.ClearBulletVictimPerformData();
		this.SceneBulletOwnerId = 0L;
		this.ClearWaitSceneBulletOwnerTask();
		Dictionary<int, HashSet<long>> summonerSummonedCreatureDataIds = this.SummonerSummonedCreatureDataIds;
		if (summonerSummonedCreatureDataIds != null)
		{
			summonerSummonedCreatureDataIds.Clear();
		}
		this.SummonerSummonedCreatureDataIds = null;
		Dictionary<long, int> summonedCreatureDataIdToSummoner = this.SummonedCreatureDataIdToSummoner;
		if (summonedCreatureDataIdToSummoner != null)
		{
			summonedCreatureDataIdToSummoner.Clear();
		}
		this.SummonedCreatureDataIdToSummoner = null;
		this.PatternHandleIdGen = 0;
		this.ForceDestroyKuroBulletWorld();
		this.StopKscBullet();
		return true;
	}

	// Token: 0x060165CD RID: 91597 RVA: 0x006827F0 File Offset: 0x006809F0
	[NullableContext(2)]
	public unsafe BulletEntity CreateBullet([Nullable(1)] Entity owner, [Nullable(1)] string bulletRowName, FTransformDouble? initialTransform, FVectorDouble? initTargetLocation, int skillId = 0, int? parentId = null, bool fromRemote = false, int targetId = 0, int? baseTransformId = null, int? baseVelocityId = null, global::Vector size = null, BulletDataMain bulletData = null, global::EBulletSyncType syncType = global::EBulletSyncType.Local, long? contextId = null, long? skillContextId = null, Aki.Protocol.EBulletCreateSource source = Aki.Protocol.EBulletCreateSource.NormalSource, FVector? locationOffset = null, FRotator? beginRotatorOffset = null, IVector randomPosOffset = null, IVector randomInitSpeedOffset = null, ISkillBattleContext battleContext = null, [Nullable(new byte[]
	{
		2,
		1
	})] HashSet<string> parentIds = null, global::EBulletCreateSource createSource = global::EBulletCreateSource.Others)
	{
		bool flag = this.IsBulletDestroyWhenPlot(bulletRowName);
		if (this.PlotPlaying && flag)
		{
			return null;
		}
		if (owner == null || !owner.Valid)
		{
			if (BulletConstant.Instance.OpenCreateLog)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Bullet;
				ELogAuthor author = ELogAuthor.LJQ;
				string message = "BulletModel.InitBullet 中止，攻击者已不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("子弹名称:", bulletRowName);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return null;
		}
		BulletDataMain bulletDataMain = bulletData ?? BulletConfig.Instance.GetBulletData(owner, bulletRowName, true);
		if (bulletDataMain == null)
		{
			return null;
		}
		if (!fromRemote)
		{
			BaseTagComponent component = owner.GetComponent<BaseTagComponent>();
			int[] bornForbidTagIds = bulletDataMain.Base.BornForbidTagIds;
			if (bornForbidTagIds != null)
			{
				foreach (int tagId in bornForbidTagIds)
				{
					if (component.HasTag(tagId))
					{
						if (BulletConstant.Instance.OpenCreateLog)
						{
							bool gasDebug = true;
							ELogAuthor author2 = ELogAuthor.HCW;
							string message2 = "BulletModel.InitBullet中止 攻击者存在该子弹禁止生成Tag ";
							BulletInfo bulletInfo = null;
							ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("子弹名称:", bulletRowName);
							BulletLog.Debug(gasDebug, author2, owner, message2, bulletInfo, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
						}
						return null;
					}
				}
			}
			int[] bornRequireTagIds = bulletDataMain.Base.BornRequireTagIds;
			if (bornRequireTagIds != null)
			{
				foreach (int tagId2 in bornRequireTagIds)
				{
					if (!component.HasTag(tagId2))
					{
						if (BulletConstant.Instance.OpenCreateLog)
						{
							bool gasDebug2 = true;
							ELogAuthor author3 = ELogAuthor.HCW;
							string message3 = "BulletModel.InitBullet中止 攻击者不存在该子弹生成所需Tag";
							BulletInfo bulletInfo2 = null;
							ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("子弹名称:", bulletRowName);
							BulletLog.Debug(gasDebug2, author3, owner, message3, bulletInfo2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
						}
						return null;
					}
				}
			}
		}
		BulletInitParams initParams = new BulletInitParams(owner, bulletRowName, initialTransform, initTargetLocation, skillId, parentId.GetValueOrDefault(), targetId, (bulletDataMain.Base.BornPositionStandard != EPositionStandard.父子弹或外部位置 && bulletDataMain.Base.BornPositionStandard != EPositionStandard.世界位置) ? baseTransformId.GetValueOrDefault() : 0, baseVelocityId.GetValueOrDefault(), size, fromRemote, syncType, contextId, skillContextId, source, locationOffset, beginRotatorOffset, battleContext, createSource);
		BulletEntity bulletEntity = BulletPool.CreateBulletEntity();
		if (bulletEntity == null || !bulletEntity.Valid)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Bullet;
			ELogAuthor author4 = ELogAuthor.LJQ;
			string message4 = "BulletModel.InitBullet error, 子弹创建 失败!";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "子弹创建者:";
			BaseActorComponent component2 = owner.GetComponent<BaseActorComponent>();
			ptr = new ValueTuple<string, object>(item, (component2 != null) ? component2.Owner : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("子弹名称:", bulletRowName);
			instance2.Error(module2, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		BulletInfo bulletInfo3 = bulletEntity.GetBulletInfo();
		if (parentIds != null)
		{
			bool openCreateLog = BulletConstant.Instance.OpenCreateLog;
			if (parentIds.Contains(bulletRowName))
			{
				CombatLog instance3 = CombatLog.Instance;
				CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.Bullet;
				string message5 = "父子弹链中存在当前子弹ID";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("父子弹链", string.Join(",", parentIds));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("当前子弹", bulletRowName);
				instance3.Error(flag2, owner, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return null;
			}
			if (bulletInfo3.ParentIds != null)
			{
				using (HashSet<string>.Enumerator enumerator = parentIds.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						string item2 = enumerator.Current;
						bulletInfo3.ParentIds.Add(item2);
					}
					goto IL_2FB;
				}
			}
			bulletInfo3.ParentIds = parentIds;
		}
		IL_2FB:
		if (fromRemote)
		{
			if (randomPosOffset != null)
			{
				bulletInfo3.RandomPosOffset.FromUeVector(randomPosOffset);
			}
			if (randomInitSpeedOffset != null)
			{
				bulletInfo3.RandomInitSpeedOffset.FromUeVector(randomInitSpeedOffset);
			}
		}
		bulletInfo3.Init(initParams, bulletDataMain);
		bulletInfo3.InitEntity(bulletEntity);
		bulletInfo3.ActionCenter = ((bulletDataMain.SpecialActionOverrides != null) ? BulletController.Instance.GetActionCenter().GetVariant(bulletDataMain.SpecialActionOverrides) : BulletController.Instance.GetActionCenter());
		this.BulletEntityMap[bulletEntity.Id] = bulletEntity;
		if (BulletConstant.Instance.OpenCreateLog)
		{
			BulletLog.Debug(false, ELogAuthor.CFT, null, "创建子弹", bulletInfo3, default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		int attackerId = bulletInfo3.AttackerId;
		OrderedSet<BulletEntity> orderedSet;
		if (this.AttackerBullet.TryGetValue(attackerId, out orderedSet))
		{
			orderedSet.Add(bulletEntity);
		}
		else
		{
			OrderedSet<BulletEntity> orderedSet2 = (this.BulletEntitySets.Count > 0) ? this.BulletEntitySets[this.BulletEntitySets.Count - 1] : new OrderedSet<BulletEntity>();
			if (this.BulletEntitySets.Count > 0)
			{
				this.BulletEntitySets.RemoveAt(this.BulletEntitySets.Count - 1);
			}
			this.AttackerBullet[attackerId] = orderedSet2;
			orderedSet2.Add(bulletEntity);
		}
		this.InitAddition(owner, bulletRowName, bulletInfo3);
		EntitySystem.Instance.Start(bulletEntity);
		EntitySystem.Instance.Activate(bulletEntity);
		EntitySystem.Instance.PostActive(bulletEntity);
		BulletController.Instance.AddSimpleAction(bulletInfo3, EBulletAction.InitBullet);
		if (flag)
		{
			this.BulletEntityDestroyWhenPlot.Add(bulletEntity.Id);
		}
		return bulletEntity;
	}

	// Token: 0x060165CE RID: 91598 RVA: 0x00682C8C File Offset: 0x00680E8C
	private void InitAddition(Entity owner, string bulletRowName, BulletInfo bulletInfo)
	{
		CharacterBuffComponent component = owner.GetComponent<CharacterBuffComponent>();
		ExtraEffectManager extraEffectManager = (component != null) ? component.BuffEffectManager : null;
		if (extraEffectManager != null)
		{
			IEnumerable<AdditionBulletSize> enumerable = extraEffectManager.FilterById<AdditionBulletSize>(EExtraEffectId.AdditionBulletSize, null);
			float num = 0f;
			float num2 = 0f;
			float num3 = 0f;
			foreach (AdditionBulletSize additionBulletSize in enumerable)
			{
				ValueTuple<float, float, float>? bulletSizeScale = additionBulletSize.GetBulletSizeScale(bulletRowName);
				if (bulletSizeScale != null)
				{
					num += bulletSizeScale.Value.Item1;
					num2 += bulletSizeScale.Value.Item2;
					num3 += bulletSizeScale.Value.Item3;
				}
			}
			IEnumerable<AdditionBulletDuration> enumerable2 = extraEffectManager.FilterById<AdditionBulletDuration>(EExtraEffectId.AdditionBulletDuration, null);
			float num4 = 0f;
			foreach (AdditionBulletDuration additionBulletDuration in enumerable2)
			{
				num4 += additionBulletDuration.GetBulletDuration(bulletRowName);
			}
			IEnumerable<AdditionBulletInterval> enumerable3 = extraEffectManager.FilterById<AdditionBulletInterval>(EExtraEffectId.AdditionBulletInterval, null);
			float num5 = 0f;
			foreach (AdditionBulletInterval additionBulletInterval in enumerable3)
			{
				num5 += additionBulletInterval.GetBulletInterval(bulletRowName);
			}
			bool flag = num == 0f && num2 == 0f && num3 == 0f;
			if (!flag || num4 != 0f || num5 != 0f)
			{
				BulletAdditionInfo bulletAdditionInfo = new BulletAdditionInfo();
				bulletAdditionInfo.Init();
				if (!flag)
				{
					bulletAdditionInfo.SizeScale.Set((double)num, (double)num2, (double)num3);
					bulletAdditionInfo.SizeScale.AdditionEqual(global::Vector.OneVectorProxy);
				}
				bulletAdditionInfo.DurationAddition = num4;
				bulletAdditionInfo.IntervalScale = 1f + num5;
				bulletInfo.AdditionInfo = bulletAdditionInfo;
			}
		}
	}

	// Token: 0x060165CF RID: 91599 RVA: 0x00682E70 File Offset: 0x00681070
	public void DestroyBullet(int id, bool summonChild, EBulletDestroyReason destroyReason = EBulletDestroyReason.Normal, bool destroyEffectImmediately = false)
	{
		BulletEntity bulletEntity;
		if (!this.BulletEntityMap.TryGetValue(id, out bulletEntity))
		{
			return;
		}
		BulletInfo bulletInfo = bulletEntity.GetBulletInfo();
		CombatMessageModel.Instance.OnBulletRemoved(bulletInfo.BulletInitParams.SkillContextId, bulletInfo.ContextIdRaw);
		if (bulletInfo.NeedDestroy)
		{
			return;
		}
		bulletInfo.NeedDestroy = true;
		if (BulletConstant.Instance.OpenDestroyLog)
		{
			BulletLog.Error(true, ELogAuthor.HCW, bulletInfo.Attacker, "销毁子弹开始", bulletInfo, default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		else if (BulletConstant.Instance.OpenCreateLog)
		{
			BulletLog.Debug(true, ELogAuthor.HCW, bulletInfo.Attacker, "销毁子弹开始", bulletInfo, default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		string bulletRowName = bulletInfo.BulletRowName;
		BulletActionInfoDestroyBullet bulletActionInfoDestroyBullet = BulletController.Instance.GetActionCenter().CreateBulletActionInfo(EBulletAction.DestroyBullet) as BulletActionInfoDestroyBullet;
		bulletActionInfoDestroyBullet.SummonChild = summonChild;
		bulletActionInfoDestroyBullet.DestroyReason = new EBulletDestroyReason?(destroyReason);
		bulletActionInfoDestroyBullet.DestroyEffectImmediately = destroyEffectImmediately;
		this.NeedDestroyBullets.Add(id);
		BulletController.Instance.GetActionRunner().AddAction(bulletInfo, bulletActionInfoDestroyBullet);
	}

	// Token: 0x060165D0 RID: 91600 RVA: 0x00682F6C File Offset: 0x0068116C
	public void DestroyAllBullet(bool summonChild = false)
	{
		foreach (int id in this.BulletEntityMap.Keys)
		{
			this.DestroyBullet(id, summonChild, EBulletDestroyReason.Normal, false);
		}
	}

	// Token: 0x060165D1 RID: 91601 RVA: 0x00682FC8 File Offset: 0x006811C8
	public unsafe void ClearDestroyedBullets()
	{
		foreach (int num in this.NeedDestroyBullets)
		{
			BulletEntity bulletEntity;
			if (this.BulletEntityMap.TryGetValue(num, out bulletEntity))
			{
				BulletInfo bulletInfo = bulletEntity.GetBulletInfo();
				int attackerId = bulletInfo.AttackerId;
				OrderedSet<BulletEntity> orderedSet;
				if (!this.AttackerBullet.TryGetValue(attackerId, out orderedSet))
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Bullet;
					ELogAuthor author = ELogAuthor.LJQ;
					string message = "BulletModel.DestroyBullet Warn, 获取被销毁子弹所在集合 失败！ ";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("子弹创建者Id:", attackerId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("子弹:", bulletEntity);
					instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				else
				{
					orderedSet.Remove(bulletEntity);
					if (orderedSet.Count == 0)
					{
						this.AttackerBullet.Remove(attackerId);
						this.BulletEntitySets.Add(orderedSet);
					}
				}
				ActiveBulletHandle bulletHandleById = this.GetBulletHandleById(num);
				if (bulletHandleById != null)
				{
					DestroyBulletPush destroyBulletPush = DestroyBulletPush.Create();
					destroyBulletPush.Handle = bulletHandleById;
					CombatNet.Instance.Send(EPushMessageId.DestroyBulletPush, bulletInfo.Attacker, destroyBulletPush, null, null, null);
					if (BulletConstant.Instance.OpenCreateLog)
					{
						BulletLog.Debug(false, ELogAuthor.HCW, null, "销毁子弹 发送协议", bulletInfo, default(ReadOnlySpan<ValueTuple<string, object>>));
					}
					this.DeregisterBullet(bulletHandleById);
				}
				if (BulletConstant.Instance.OpenCreateLog)
				{
					bool gasDebug = true;
					ELogAuthor author2 = ELogAuthor.HCW;
					Entity attacker = bulletInfo.Attacker;
					string message2 = "销毁子弹完成";
					BulletInfo bulletInfo2 = null;
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("BulletId", bulletInfo.BulletRowName);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("EntityId", bulletInfo.BulletEntityId);
					BulletLog.Debug(gasDebug, author2, attacker, message2, bulletInfo2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				}
				this.BulletEntityMap.Remove(num);
				BulletPool.RecycleBulletEntity(bulletEntity);
			}
		}
		this.NeedDestroyBullets.Clear();
	}

	// Token: 0x060165D2 RID: 91602 RVA: 0x006831F8 File Offset: 0x006813F8
	[return: Nullable(new byte[]
	{
		2,
		0
	})]
	public unsafe TArray<TEnumAsByte<EObjectTypeQuery>> GetFastMoveTrace(string profileName, string bulletRowName)
	{
		if (profileName == "Bullet_Type1")
		{
			return this.CommonConfig.FastMoveTraceBullet_Type1;
		}
		if (!(profileName == "Bullet_Type2"))
		{
			if (!(profileName == "Bullet_Type3"))
			{
				if (!(profileName == "Bullet_Type1_Special"))
				{
					if (!(profileName == "Bullet_Type2_Special"))
					{
						if (!(profileName == "Bullet_OnlyBullet"))
						{
							Log instance = Log.Instance;
							ELogModule module = ELogModule.Bullet;
							ELogAuthor author = ELogAuthor.HCW;
							string message = "找不到快速移动对应的检测类型配置";
							<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("bulletRowName", bulletRowName);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("profileName", profileName);
							instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
							return null;
						}
						BulletCommonDataAsset_C commonConfig = this.CommonConfig;
						if (commonConfig == null)
						{
							return null;
						}
						return commonConfig.FastMoveTraceBullet_Only_Bullet;
					}
					else
					{
						BulletCommonDataAsset_C commonConfig2 = this.CommonConfig;
						if (commonConfig2 == null)
						{
							return null;
						}
						return commonConfig2.FastMoveTraceBullet_Type2_Special;
					}
				}
				else
				{
					BulletCommonDataAsset_C commonConfig3 = this.CommonConfig;
					if (commonConfig3 == null)
					{
						return null;
					}
					return commonConfig3.FastMoveTraceBullet_Type1_Special;
				}
			}
			else
			{
				BulletCommonDataAsset_C commonConfig4 = this.CommonConfig;
				if (commonConfig4 == null)
				{
					return null;
				}
				return commonConfig4.FastMoveTraceBullet_Type3;
			}
		}
		else
		{
			BulletCommonDataAsset_C commonConfig5 = this.CommonConfig;
			if (commonConfig5 == null)
			{
				return null;
			}
			return commonConfig5.FastMoveTraceBullet_Type2;
		}
	}

	// Token: 0x170022D8 RID: 8920
	// (get) Token: 0x060165D3 RID: 91603 RVA: 0x0068330F File Offset: 0x0068150F
	[Nullable(new byte[]
	{
		1,
		0
	})]
	public TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypeTakeAim
	{
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		get
		{
			return this.CommonConfig.TakeAim;
		}
	}

	// Token: 0x170022D9 RID: 8921
	// (get) Token: 0x060165D4 RID: 91604 RVA: 0x0068331C File Offset: 0x0068151C
	[Nullable(new byte[]
	{
		1,
		0
	})]
	public TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypeObstacles
	{
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		get
		{
			return this.CommonConfig.Obstacles;
		}
	}

	// Token: 0x170022DA RID: 8922
	// (get) Token: 0x060165D5 RID: 91605 RVA: 0x00683329 File Offset: 0x00681529
	[Nullable(new byte[]
	{
		1,
		0
	})]
	public TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypeHitPoint
	{
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		get
		{
			return this.CommonConfig.HitPoint;
		}
	}

	// Token: 0x060165D6 RID: 91606 RVA: 0x00683338 File Offset: 0x00681538
	[NullableContext(2)]
	public void RegisterBullet(ActiveBulletHandle handle, int bulletEntityId)
	{
		if (handle == null)
		{
			return;
		}
		int playerId = handle.PlayerId;
		int handleId = handle.HandleId;
		this.EntityIdToHandleDict[bulletEntityId] = handle;
		if (!this.HandleToEntityIdDict.ContainsKey(playerId))
		{
			this.HandleToEntityIdDict[playerId] = new Dictionary<int, int>();
		}
		this.HandleToEntityIdDict[playerId][handleId] = bulletEntityId;
	}

	// Token: 0x060165D7 RID: 91607 RVA: 0x00683398 File Offset: 0x00681598
	[NullableContext(2)]
	public void DeregisterBullet(ActiveBulletHandle handle)
	{
		if (handle == null)
		{
			return;
		}
		int idByBulletHandle = this.GetIdByBulletHandle(handle);
		if (this.EntityIdToHandleDict.ContainsKey(idByBulletHandle))
		{
			this.EntityIdToHandleDict.Remove(idByBulletHandle);
		}
		if (this.HandleToEntityIdDict.ContainsKey(handle.PlayerId))
		{
			int playerId = handle.PlayerId;
			int handleId = handle.HandleId;
			Dictionary<int, int> dictionary = this.HandleToEntityIdDict[playerId];
			dictionary.Remove(handleId);
			if (dictionary.Count <= 0)
			{
				this.HandleToEntityIdDict.Remove(playerId);
			}
		}
	}

	// Token: 0x060165D8 RID: 91608 RVA: 0x00683418 File Offset: 0x00681618
	[NullableContext(2)]
	public int GetIdByBulletHandle(ActiveBulletHandle handle)
	{
		if (handle == null)
		{
			return 0;
		}
		int playerId = handle.PlayerId;
		int handleId = handle.HandleId;
		Dictionary<int, int> dictionary;
		int result;
		if (this.HandleToEntityIdDict.TryGetValue(playerId, out dictionary) && dictionary.TryGetValue(handleId, out result))
		{
			return result;
		}
		return 0;
	}

	// Token: 0x060165D9 RID: 91609 RVA: 0x00683458 File Offset: 0x00681658
	[NullableContext(2)]
	public ActiveBulletHandle GetBulletHandleById(int bulletEntityId)
	{
		ActiveBulletHandle result;
		this.EntityIdToHandleDict.TryGetValue(bulletEntityId, out result);
		return result;
	}

	// Token: 0x060165DA RID: 91610 RVA: 0x00683478 File Offset: 0x00681678
	public void SendDodgeInfoPush(Entity dodgeEntity, long bulletOwnerCreatureDataId, long bulletId, long? preMessageId = null)
	{
		if (!dodgeEntity.Valid || bulletOwnerCreatureDataId <= 0L)
		{
			return;
		}
		DodgeInfoPush dodgeInfoPush = DodgeInfoPush.Create();
		dodgeInfoPush.BulletOwnerId = MathUtils.Instance.NumberToLong(bulletOwnerCreatureDataId);
		dodgeInfoPush.BulletId = bulletId;
		CombatNet.Instance.Send(EPushMessageId.DodgeInfoPush, dodgeEntity, dodgeInfoPush, preMessageId, null, null);
	}

	// Token: 0x060165DB RID: 91611 RVA: 0x006834D8 File Offset: 0x006816D8
	[NullableContext(2)]
	public void DestroyBulletRemote(ActiveBulletHandle handle, bool summonChild)
	{
		if (handle == null || !this.HandleToEntityIdDict.ContainsKey(handle.PlayerId))
		{
			return;
		}
		int idByBulletHandle = this.GetIdByBulletHandle(handle);
		if (idByBulletHandle != 0)
		{
			bool openDestroyLog = BulletConstant.Instance.OpenDestroyLog;
			this.DeregisterBullet(handle);
			this.DestroyBullet(idByBulletHandle, summonChild, EBulletDestroyReason.FromRemote, false);
		}
	}

	// Token: 0x060165DC RID: 91612 RVA: 0x00683524 File Offset: 0x00681724
	public T NewTraceElement<[Nullable(0)] T>([Nullable(new byte[]
	{
		1,
		0
	})] TArray<TEnumAsByte<EObjectTypeQuery>> traceObjectType, [Nullable(2)] HashSet<EObjectTypeQuery> ignoreObjectType = null, bool bIsSingle = false) where T : UTraceBaseElement, new()
	{
		T t = Activator.CreateInstance<T>();
		t.WorldContextObject = GlobalData.World;
		if (traceObjectType != null)
		{
			for (int i = 0; i < traceObjectType.Num(); i++)
			{
				TEnumAsByte<EObjectTypeQuery> value = traceObjectType.Get(i);
				if (ignoreObjectType == null || !ignoreObjectType.Contains(value))
				{
					t.AddObjectTypeQuery(value);
				}
			}
		}
		t.bTraceComplex = false;
		t.bIgnoreSelf = true;
		return t;
	}

	// Token: 0x060165DD RID: 91613 RVA: 0x006835A0 File Offset: 0x006817A0
	public unsafe int GetEntityIdByCustomKey(int attackerId, string key, string bulletRowName)
	{
		string text = key + attackerId.ToString();
		int num;
		if (!this.MapCustomKey.TryGetValue(text, out num))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Bullet;
			ELogAuthor author = ELogAuthor.HCW;
			string message = "获取自定义目标失败";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Bullet", bulletRowName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Key", text);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Entity", num);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return 0;
		}
		return num;
	}

	// Token: 0x060165DE RID: 91614 RVA: 0x00683640 File Offset: 0x00681840
	public unsafe void SetEntityIdByCustomKey(int attackerId, string customKey, int targetId)
	{
		string text = customKey + attackerId.ToString();
		this.MapCustomKey[text] = targetId;
		if (targetId == 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Bullet;
			ELogAuthor author = ELogAuthor.HCW;
			string message = "设置自定义目标失败";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Key", text);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Entity", targetId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
	}

	// Token: 0x060165DF RID: 91615 RVA: 0x006836C4 File Offset: 0x006818C4
	public int? GetCustomBulletAttacker(string customKey)
	{
		int value;
		if (this.CustomBulletAttacker.TryGetValue(customKey, out value))
		{
			return new int?(value);
		}
		return null;
	}

	// Token: 0x060165E0 RID: 91616 RVA: 0x006836F1 File Offset: 0x006818F1
	public void SetCustomBulletAttacker(string customKey, int attackerId)
	{
		this.CustomBulletAttacker[customKey] = attackerId;
	}

	// Token: 0x060165E1 RID: 91617 RVA: 0x00683700 File Offset: 0x00681900
	public bool RemoveCustomBulletAttacker(string customKey)
	{
		return this.CustomBulletAttacker.Remove(customKey);
	}

	// Token: 0x060165E2 RID: 91618 RVA: 0x00683710 File Offset: 0x00681910
	public bool ShowBulletCollision(int entityId = 0)
	{
		bool flag;
		return this.MapAttackerDrawCollision.ContainsKey(entityId) && (this.MapAttackerDrawCollision.TryGetValue(entityId, out flag) && flag);
	}

	// Token: 0x060165E3 RID: 91619 RVA: 0x00683740 File Offset: 0x00681940
	public bool ShowBulletTrace(int entityId = 0)
	{
		bool flag;
		return this.MapAttackerDrawTrace.ContainsKey(entityId) && (this.MapAttackerDrawTrace.TryGetValue(entityId, out flag) && flag);
	}

	// Token: 0x060165E4 RID: 91620 RVA: 0x0068376D File Offset: 0x0068196D
	public void SetBulletCollisionDraw(int entityId, bool enable)
	{
		this.MapAttackerDrawCollision[entityId] = enable;
	}

	// Token: 0x060165E5 RID: 91621 RVA: 0x0068377C File Offset: 0x0068197C
	public void SetBulletTraceDraw(int entityId, bool enable)
	{
		this.MapAttackerDrawTrace[entityId] = enable;
	}

	// Token: 0x060165E6 RID: 91622 RVA: 0x0068378C File Offset: 0x0068198C
	private void InitBulletVictimPerformData()
	{
		this.SelfAdaptBeHitAnim = new HashSet<EHitAnim>
		{
			EHitAnim.轻左,
			EHitAnim.轻右,
			EHitAnim.重左,
			EHitAnim.重右,
			EHitAnim.轻前,
			EHitAnim.轻后,
			EHitAnim.重前,
			EHitAnim.重后
		};
		this.HeavyHitAnim = new HashSet<EHitAnim>
		{
			EHitAnim.重左,
			EHitAnim.重右,
			EHitAnim.重前,
			EHitAnim.重后
		};
		this.Index2LightHitAnimMap = new EHitAnim[]
		{
			EHitAnim.轻前,
			EHitAnim.轻右,
			EHitAnim.轻后,
			EHitAnim.轻左
		};
		this.Index2HeavyHitAnimMap = new EHitAnim[]
		{
			EHitAnim.重前,
			EHitAnim.重右,
			EHitAnim.重后,
			EHitAnim.重左
		};
	}

	// Token: 0x060165E7 RID: 91623 RVA: 0x00683842 File Offset: 0x00681A42
	private void ClearBulletVictimPerformData()
	{
		this.SelfAdaptBeHitAnim = null;
		this.HeavyHitAnim = null;
		this.Index2LightHitAnimMap = null;
		this.Index2HeavyHitAnimMap = null;
	}

	// Token: 0x060165E8 RID: 91624 RVA: 0x00683860 File Offset: 0x00681A60
	private bool IsBulletDestroyWhenPlot(string bulletRowName)
	{
		return bulletRowName == "310000001";
	}

	// Token: 0x060165E9 RID: 91625 RVA: 0x00683870 File Offset: 0x00681A70
	private void OnPlotStart(PlotInfo plotInfo)
	{
		if (plotInfo.PlotLevel != EPlotLevel.LevelA && plotInfo.PlotLevel != EPlotLevel.LevelB && plotInfo.PlotLevel != EPlotLevel.LevelC)
		{
			return;
		}
		this.PlotPlaying = true;
		foreach (int id in this.BulletEntityDestroyWhenPlot)
		{
			this.DestroyBullet(id, false, EBulletDestroyReason.Normal, false);
		}
		this.BulletEntityDestroyWhenPlot.Clear();
		this.SetAllBulletEffectHidden(true);
	}

	// Token: 0x060165EA RID: 91626 RVA: 0x006838FC File Offset: 0x00681AFC
	private void OnPlotEnd(PlotResultInfo plotResultInfo)
	{
		if (!this.PlotPlaying)
		{
			return;
		}
		this.SetAllBulletEffectHidden(false);
		this.PlotPlaying = false;
	}

	// Token: 0x060165EB RID: 91627 RVA: 0x00683918 File Offset: 0x00681B18
	[NullableContext(2)]
	public int SetAllBulletTimeScale(global::Vector centerLocation, float radius, int priority, float timeDilation, UCurveFloat curve, float duration, bool isPersistent)
	{
		this.PersistentTimeScaleId--;
		int persistentTimeScaleId = this.PersistentTimeScaleId;
		foreach (BulletEntity bulletEntity in this.GetBulletEntityMap().Values)
		{
			BulletInfo bulletInfo = bulletEntity.GetBulletInfo();
			if (bulletInfo.IsInit && !bulletInfo.NeedDestroy && !bulletInfo.BulletDataMain.TimeScale.TimeScaleWithAttacker)
			{
				if (centerLocation != null)
				{
					global::Vector lastFramePosition = bulletInfo.CollisionInfo.LastFramePosition;
					if (lastFramePosition == null || MathF.Abs((float)(lastFramePosition.X - centerLocation.X)) > radius || MathF.Abs((float)(lastFramePosition.Y - centerLocation.Y)) > radius || MathF.Abs((float)(lastFramePosition.Z - centerLocation.Z)) > radius)
					{
						continue;
					}
				}
				BulletUtil.SetTimeScale(bulletInfo, priority, timeDilation, curve, duration, ETimeScaleSourceType.BattleSettlement, 0.0, persistentTimeScaleId);
			}
		}
		if (isPersistent)
		{
			this.PersistentTimeScaleMap[persistentTimeScaleId] = new BulletPersistentTimeScale(centerLocation, radius, (float)Time.Instance.WorldTimeSeconds, priority, timeDilation, curve, duration, ETimeScaleSourceType.BattleSettlement, persistentTimeScaleId);
		}
		return persistentTimeScaleId;
	}

	// Token: 0x060165EC RID: 91628 RVA: 0x00683A48 File Offset: 0x00681C48
	public void RemoveAllBulletTimeScale(int timeScaleId, bool isPersistent)
	{
		foreach (BulletEntity bulletEntity in this.GetBulletEntityMap().Values)
		{
			BulletInfo bulletInfo = bulletEntity.GetBulletInfo();
			if (bulletInfo.IsInit)
			{
				BulletUtil.RemoveTimeScale(bulletInfo, timeScaleId);
			}
		}
		if (isPersistent)
		{
			this.PersistentTimeScaleMap.Remove(timeScaleId);
		}
	}

	// Token: 0x060165ED RID: 91629 RVA: 0x00683AC0 File Offset: 0x00681CC0
	private void ClearPersistentTimeScale()
	{
		this.PersistentTimeScaleId = 0;
		this.PersistentTimeScaleMap.Clear();
	}

	// Token: 0x170022DB RID: 8923
	// (get) Token: 0x060165EE RID: 91630 RVA: 0x00683AD4 File Offset: 0x00681CD4
	// (set) Token: 0x060165EF RID: 91631 RVA: 0x00683ADC File Offset: 0x00681CDC
	public long SceneBulletOwnerId
	{
		get
		{
			return this.SceneBulletOwnerIdInternal;
		}
		set
		{
			this.SceneBulletOwnerIdInternal = value;
		}
	}

	// Token: 0x060165F0 RID: 91632 RVA: 0x00683AE8 File Offset: 0x00681CE8
	[NullableContext(2)]
	public CustomPromise<bool> WaitSceneBulletOwnerInit()
	{
		long creatureDataId = this.SceneBulletOwnerId;
		if (creatureDataId == 0L)
		{
			Log.Instance.Error(ELogModule.Bullet, ELogAuthor.CFT, "等待场景子弹owner创建失败, creatureDataId为0", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		if (this.PreloadPromise != null)
		{
			Log.Instance.Error(ELogModule.Bullet, ELogAuthor.CFT, "重复调用WaitSceneBulletOwnerInit", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		this.PreloadPromise = new CustomPromise<bool>();
		this.ClearWaitSceneBulletOwnerTask();
		this.WaitSceneBulletOwnerTask = WaitEntityTask.Create("BulletModel.WaitSceneBulletOwnerInit", creatureDataId, delegate(bool? result)
		{
			if (!result.GetValueOrDefault())
			{
				Log.Instance.Warn(ELogModule.Bullet, ELogAuthor.CFT, "等待场景子弹owner创建失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				CustomPromise<bool> preloadPromise = this.PreloadPromise;
				if (preloadPromise == null)
				{
					return;
				}
				preloadPromise.SetResult(false);
				return;
			}
			else
			{
				if (this.SceneBulletOwnerId == creatureDataId)
				{
					this.WaitSceneBulletOwnerTask = null;
					this.IsSceneBulletOwnerCreated = true;
					CustomPromise<bool> preloadPromise2 = this.PreloadPromise;
					if (preloadPromise2 != null)
					{
						preloadPromise2.SetResult(true);
					}
					this.PreloadPromise = null;
					EventSystem.Instance.Emit(EEventName.SceneBulletOwnerCreated);
					return;
				}
				Log.Instance.Warn(ELogModule.Bullet, ELogAuthor.CFT, "等待场景子弹owner创建返回时，creatureDataId已改变", default(ReadOnlySpan<ValueTuple<string, object>>));
				CustomPromise<bool> preloadPromise3 = this.PreloadPromise;
				if (preloadPromise3 == null)
				{
					return;
				}
				preloadPromise3.SetResult(false);
				return;
			}
		}, -1, true, false);
		if (this.IsSceneBulletOwnerCreated)
		{
			this.WaitSceneBulletOwnerTask = null;
			return null;
		}
		return this.PreloadPromise;
	}

	// Token: 0x060165F1 RID: 91633 RVA: 0x00683BA7 File Offset: 0x00681DA7
	private void ClearWaitSceneBulletOwnerTask()
	{
		this.IsSceneBulletOwnerCreated = false;
		if (this.WaitSceneBulletOwnerTask != null)
		{
			this.WaitSceneBulletOwnerTask.Cancel();
			this.WaitSceneBulletOwnerTask = null;
		}
	}

	// Token: 0x060165F2 RID: 91634 RVA: 0x00683BCC File Offset: 0x00681DCC
	private void SetAllBulletEffectHidden(bool hidden)
	{
		foreach (BulletEntity bulletEntity in this.BulletEntityMap.Values)
		{
			this.SetBulletEffectHidden(bulletEntity, hidden);
		}
	}

	// Token: 0x060165F3 RID: 91635 RVA: 0x00683C28 File Offset: 0x00681E28
	[NullableContext(2)]
	private void SetBulletEffectHidden(BulletEntity bulletEntity, bool hidden)
	{
		if (bulletEntity == null || !bulletEntity.Valid)
		{
			return;
		}
		BulletInfo bulletInfo = bulletEntity.GetBulletInfo();
		EffectSystem.Instance.SetEffectHidden(bulletInfo.EffectInfo.Effect, hidden, "演出子弹特效清场", false);
	}

	// Token: 0x060165F4 RID: 91636 RVA: 0x00683C6C File Offset: 0x00681E6C
	public void SummonerSummon(int summonerId, long creatureDataId)
	{
		if (!this.SummonerSummonedCreatureDataIds.ContainsKey(summonerId))
		{
			this.SummonerSummonedCreatureDataIds[summonerId] = new HashSet<long>();
		}
		this.SummonerSummonedCreatureDataIds[summonerId].Add(creatureDataId);
		this.SummonedCreatureDataIdToSummoner[creatureDataId] = summonerId;
	}

	// Token: 0x060165F5 RID: 91637 RVA: 0x00683CB8 File Offset: 0x00681EB8
	public List<int> GetSummonEntityIds(int summonerId)
	{
		List<int> list = new List<int>();
		if (this.SummonerSummonedCreatureDataIds.ContainsKey(summonerId))
		{
			foreach (long num in this.SummonerSummonedCreatureDataIds[summonerId])
			{
				int entityId = CreatureModel.Instance.GetEntityId(num);
				if (entityId != 0)
				{
					list.Add(entityId);
				}
				else
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Bullet;
					ELogAuthor author = ELogAuthor.XDW;
					string message = "[BulletModel] 不存在实体Id";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CreatureDataId", num);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
			}
		}
		return list;
	}

	// Token: 0x060165F6 RID: 91638 RVA: 0x00683D68 File Offset: 0x00681F68
	private void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
	{
		int id = handle.Id;
		if (id != 0)
		{
			this.DestroyBulletsByAttacker(id);
			WorldEntity entity = handle.Entity;
			List<int> list;
			if (entity == null)
			{
				list = null;
			}
			else
			{
				CharacterFollowComponent component = entity.GetComponent<CharacterFollowComponent>();
				list = ((component != null) ? component.AttributeSharerIds : null);
			}
			List<int> list2 = list;
			if (list2 != null)
			{
				foreach (int attackerId in list2)
				{
					this.DestroyBulletsByAttacker(attackerId);
				}
			}
			if (this.PatternOwnerEntityIds.Contains(id))
			{
				this.DestroyPatternsByOwner(handle);
			}
		}
		long creatureDataId = CreatureModel.Instance.GetCreatureDataId(handle.Id);
		if (this.SummonedCreatureDataIdToSummoner.ContainsKey(creatureDataId))
		{
			int key = this.SummonedCreatureDataIdToSummoner[creatureDataId];
			this.SummonedCreatureDataIdToSummoner.Remove(creatureDataId);
			if (this.SummonerSummonedCreatureDataIds.ContainsKey(key))
			{
				this.SummonerSummonedCreatureDataIds[key].Remove(creatureDataId);
			}
		}
	}

	// Token: 0x060165F7 RID: 91639 RVA: 0x00683E60 File Offset: 0x00682060
	private void DestroyBulletsByAttacker(int attackerId)
	{
		OrderedSet<BulletEntity> orderedSet;
		if (this.AttackerBullet.TryGetValue(attackerId, out orderedSet) && orderedSet.Count > 0)
		{
			foreach (BulletEntity bulletEntity in orderedSet)
			{
				BulletController.Instance.DestroyBullet(bulletEntity.Id, false, EBulletDestroyReason.Normal, false);
			}
		}
	}

	// Token: 0x060165F8 RID: 91640 RVA: 0x00683ED4 File Offset: 0x006820D4
	public unsafe int SpawnPattern(Entity ownerEntity, UKuroBulletPatternDataAsset patternData, FWorldEntityBulletParam extraParam)
	{
		if (ownerEntity == null || !ownerEntity.Valid)
		{
			return 0;
		}
		if (patternData == null || !patternData.IsValid())
		{
			return 0;
		}
		BaseActorComponent component = ownerEntity.GetComponent<BaseActorComponent>();
		AActor aactor = (component != null) ? component.Owner : null;
		CreatureDataComponent component2 = ownerEntity.GetComponent<CreatureDataComponent>();
		BaseSkillComponent component3 = ownerEntity.GetComponent<BaseSkillComponent>();
		if (aactor == null || component2 == null || component3 == null)
		{
			return 0;
		}
		BulletPatternComponent component4 = ownerEntity.GetComponent<BulletPatternComponent>();
		if (component4 == null || !component4.HasBulletPatternSkill)
		{
			CombatLog.Instance.Error(CombatLog.EDebugModule.Bullet, ownerEntity, "SpawnPattern失败，该实体没有弹幕子弹能力", default(ReadOnlySpan<ValueTuple<string, object>>));
			return 0;
		}
		UWorldEntityBulletContext uworldEntityBulletContext = UE.NewObject<UWorldEntityBulletContext>(GlobalData.World, null, EObjectFlags.RF_NoFlags);
		uworldEntityBulletContext.ExtraParam = extraParam;
		uworldEntityBulletContext.OwnerActor = aactor;
		uworldEntityBulletContext.OwnerEntityId = ownerEntity.Id;
		uworldEntityBulletContext.BulletDataTable = component3.DtKuroBulletInfo;
		uworldEntityBulletContext.Camp = (int)component2.GetEntityCamp();
		EntityHandle skillTarget = component3.SkillTarget;
		if (skillTarget != null && skillTarget.Valid)
		{
			WorldEntity entity = skillTarget.Entity;
			BaseActorComponent baseActorComponent = (entity != null) ? entity.GetComponent<BaseActorComponent>() : null;
			uworldEntityBulletContext.TargetActor = ((baseActorComponent != null) ? baseActorComponent.Owner : null);
			string skillTargetSocket = component3.SkillTargetSocket;
			if (!string.IsNullOrEmpty(skillTargetSocket))
			{
				FName? dynamicFName = FNameUtil.GetDynamicFName(skillTargetSocket);
				if (dynamicFName != null)
				{
					uworldEntityBulletContext.TargetSocket = dynamicFName.Value;
				}
			}
		}
		int num = UKuroBulletFunctionLibrary.SpawnPattern(uworldEntityBulletContext, patternData);
		if (num > 0)
		{
			this.PatternOwnerEntityIds.Add(ownerEntity.Id);
		}
		if (BulletConstant.Instance.OpenCreateLog && num <= 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Bullet;
			ELogAuthor author = ELogAuthor.HXY;
			string message = "创建弹幕失败";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("弹幕DA", patternData);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("拥有者实体ID", ownerEntity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("拥有者名称", aactor.GetName());
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
		return num;
	}

	// Token: 0x060165F9 RID: 91641 RVA: 0x006840C8 File Offset: 0x006822C8
	public void DestroyPatternById(int patternId)
	{
		if (patternId <= 0)
		{
			return;
		}
		if (BulletConstant.Instance.OpenDestroyLog)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Bullet;
			ELogAuthor author = ELogAuthor.HXY;
			string message = "销毁弹幕开始";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("弹幕Id", patternId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		else
		{
			bool openCreateLog = BulletConstant.Instance.OpenCreateLog;
		}
		UKuroBulletFunctionLibrary.DestroyPattern(patternId);
		bool openCreateLog2 = BulletConstant.Instance.OpenCreateLog;
	}

	// Token: 0x060165FA RID: 91642 RVA: 0x00684130 File Offset: 0x00682330
	public void DestroyPatternsByOwner(object owner)
	{
		if (owner == null)
		{
			return;
		}
		AActor aactor = null;
		int num = 0;
		EntityHandle entityHandle = owner as EntityHandle;
		if (entityHandle != null)
		{
			num = entityHandle.Id;
			WorldEntity entity = entityHandle.Entity;
			AActor aactor2;
			if (entity == null)
			{
				aactor2 = null;
			}
			else
			{
				BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
				aactor2 = ((component != null) ? component.Owner : null);
			}
			aactor = aactor2;
		}
		else
		{
			AActor aactor3 = owner as AActor;
			if (aactor3 != null)
			{
				aactor = aactor3;
			}
		}
		if (aactor == null)
		{
			return;
		}
		UKuroBulletFunctionLibrary.DestroyPatternsByOwner(aactor);
		if (num != 0)
		{
			this.PatternOwnerEntityIds.Remove(num);
		}
		bool openCreateLog = BulletConstant.Instance.OpenCreateLog;
	}

	// Token: 0x060165FB RID: 91643 RVA: 0x006841A8 File Offset: 0x006823A8
	[NullableContext(2)]
	public UBulletWorld GetKuroBulletWorld()
	{
		return this.KuroBulletWorldInternal;
	}

	// Token: 0x060165FC RID: 91644 RVA: 0x006841B0 File Offset: 0x006823B0
	[NullableContext(2)]
	public UBulletHitWorldEntityManager GetBulletHitWorldEntityManager()
	{
		return this.BulletHitWorldEntityManager;
	}

	// Token: 0x060165FD RID: 91645 RVA: 0x006841B8 File Offset: 0x006823B8
	public void StartKuroBulletWorld(UKuroFastCollisionAlgorithm algorithm, bool needHitWorldEntity = false)
	{
		UKuroBulletCoreSubsystem ukuroBulletCoreSubsystem = USubsystemBlueprintLibrary.GetGameInstanceSubsystem(GlobalData.GameInstance, UKuroBulletCoreSubsystem.StaticClass()) as UKuroBulletCoreSubsystem;
		this.KuroBulletWorldInternal = ukuroBulletCoreSubsystem.GetBulletWorld();
		if (this.KuroBulletWorldInternal == null)
		{
			this.KuroBulletWorldInternal = ukuroBulletCoreSubsystem.CreateWorld();
		}
		if (this.KuroBulletWorldInternal != null)
		{
			this.KuroBulletWorldInternal.ForceUpdateOverlap = true;
			this.KuroBulletWorldInternal.OnBulletModifyBuff.Add(new Action<int, long, bool>(this.OnBulletModifyBuff));
			this.KuroBulletWorldInternal.OnBulletCameraShake.Add(new Action<string>(this.OnBulletCameraShake));
			this.KuroBulletWorldInternal.SetKFCAlgorithm(algorithm);
			this.KuroBulletWorldInternal.RegisterBulletActionClassByTag(GameplayTagUtils.GetGameplayTagById(GameplayTagDefine.EGameplayTagId["子弹.KuroBullet.碰撞平地"]).Value, UActionFlatGroundCollision.StaticClass());
			Log.Instance.Info(ELogModule.Bullet, ELogAuthor.HXY, "KuroBulletWorld创建成功", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		else
		{
			Log.Instance.Error(ELogModule.Bullet, ELogAuthor.HXY, "KuroBulletWorld创建失败", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		if (needHitWorldEntity)
		{
			if (this.BulletHitWorldEntityManager != null)
			{
				return;
			}
			this.BulletHitWorldEntityManager = UBulletHitWorldEntityManager.CreateInstance(GlobalData.World);
			this.BulletHitWorldEntityBridge = UE.NewObject<BP_BulletHitWorldEntityBridge_C>(GlobalData.GameInstance, null, EObjectFlags.RF_NoFlags);
			this.BulletHitWorldEntityManager.SetBulletHitWorldEntityBridge(this.BulletHitWorldEntityBridge);
			UHitEffectManager hitEffectManager = this.BulletHitWorldEntityManager.HitEffectManager;
			if (hitEffectManager != null)
			{
				hitEffectManager.MaxEffectCountPerFrame = 20;
				hitEffectManager.MaxEffectCountPerPath = 20;
			}
		}
	}

	// Token: 0x060165FE RID: 91646 RVA: 0x00684324 File Offset: 0x00682524
	public void StopKuroBulletWorld()
	{
		this.BulletHitWorldEntityBridge = null;
		if (this.BulletHitWorldEntityManager != null)
		{
			UBulletHitWorldEntityManager.DestroyInstance();
			this.BulletHitWorldEntityManager = null;
			this.OperationList.Empty(true);
		}
		if (this.KuroBulletWorldInternal == null)
		{
			return;
		}
		this.KuroBulletWorldInternal.OnBulletModifyBuff.Clear();
		this.KuroBulletWorldInternal.OnBulletCameraShake.Clear();
		(USubsystemBlueprintLibrary.GetGameInstanceSubsystem(GlobalData.GameInstance, UKuroBulletCoreSubsystem.StaticClass()) as UKuroBulletCoreSubsystem).DestroyWorld();
		this.KuroBulletWorldInternal = null;
		Log.Instance.Info(ELogModule.Bullet, ELogAuthor.HXY, "KuroBulletWorld销毁成功", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x060165FF RID: 91647 RVA: 0x006843C2 File Offset: 0x006825C2
	private void OnBulletModifyBuff(int entityId, long buffId, bool isAdd)
	{
		KuroSimpleCombatController.Instance.ModifyBuffAsync(entityId, isAdd, (int)buffId);
	}

	// Token: 0x06016600 RID: 91648 RVA: 0x006843D2 File Offset: 0x006825D2
	private void OnBulletCameraShake(string shakePath)
	{
		if (string.IsNullOrEmpty(shakePath))
		{
			return;
		}
		ResourceSystem.Instance.LoadAsync<UClass>(shakePath, delegate([Nullable(2)] UClass shakeType, string _)
		{
			APlayerCameraManager characterCameraManager = Global.CharacterCameraManager;
			if (characterCameraManager == null || !characterCameraManager.IsValid())
			{
				return;
			}
			FVectorDouble value = characterCameraManager.D_GetCameraLocation();
			CameraController.Instance.PlayWorldCameraShake(new TSubclassOf<UCameraShakeBase>?(shakeType), new FVectorDouble?(value), 0f, 100f, 1f, false, "MainCamera");
		}, 100, "js_undefined");
	}

	// Token: 0x06016601 RID: 91649 RVA: 0x00684410 File Offset: 0x00682610
	private void ForceDestroyKuroBulletWorld()
	{
		this.StopKuroBulletWorld();
		Log.Instance.Info(ELogModule.Bullet, ELogAuthor.HXY, "KuroBulletWorld强制销毁完成", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06016602 RID: 91650 RVA: 0x0068443F File Offset: 0x0068263F
	public void StartKscBullet()
	{
		if (this.KscBulletManager != null)
		{
			return;
		}
		this.KscBulletManager = UKscBulletManager.CreateInstance(GlobalData.World);
	}

	// Token: 0x06016603 RID: 91651 RVA: 0x0068445A File Offset: 0x0068265A
	public void StopKscBullet()
	{
		if (this.KscBulletManager == null)
		{
			return;
		}
		UKscBulletManager.DestroyInstance();
		this.KscBulletManager = null;
	}

	// Token: 0x06016604 RID: 91652 RVA: 0x00684474 File Offset: 0x00682674
	public void ProcessKuroBulletOperationList()
	{
		if (this.BulletHitWorldEntityManager == null)
		{
			return;
		}
		this.BulletHitWorldEntityManager.GetOperationList(ref this.OperationList);
		TArray<FBulletHitWorldEntityOperation> operationList = this.OperationList;
		int num = operationList.Num();
		for (int i = 0; i < num; i++)
		{
			this.PendingOperationQueue.Push(operationList.Get(i));
		}
	}

	// Token: 0x06016605 RID: 91653 RVA: 0x006844C8 File Offset: 0x006826C8
	public void ProcessKuroBulletPendingOperation()
	{
		this.TimeLimit.ResetCost();
		while (!this.PendingOperationQueue.Empty)
		{
			double microseconds = KuroTime.GetMicroseconds64();
			FBulletHitWorldEntityOperation fbulletHitWorldEntityOperation = this.PendingOperationQueue.Pop();
			if (fbulletHitWorldEntityOperation == null)
			{
				break;
			}
			this.ProcessKuroBulletOperation(fbulletHitWorldEntityOperation);
			double microseconds2 = KuroTime.GetMicroseconds64();
			this.TimeLimit.AddCost(microseconds2 - microseconds);
			if (this.TimeLimit.IsTimeLimitExceeded())
			{
				break;
			}
		}
	}

	// Token: 0x06016606 RID: 91654 RVA: 0x00684534 File Offset: 0x00682734
	public void ProcessKuroBulletOperation(FBulletHitWorldEntityOperation operation)
	{
		int operationType = (int)operation.OperationType;
		if (operationType == 0)
		{
			this.KuroBulletAddBuff(operation);
			return;
		}
		if (operationType == 1)
		{
			this.KuroBulletHit(operation);
			return;
		}
		if (operationType == 2)
		{
			this.KuroBulletDodge(operation);
			return;
		}
		if (operationType == 3)
		{
			this.KuroBulletAddBuffWithRef(operation);
			return;
		}
		if (operationType == 4)
		{
			this.KuroBulletRemoveBuffWithRef(operation);
		}
	}

	// Token: 0x06016607 RID: 91655 RVA: 0x00684584 File Offset: 0x00682784
	private void KuroBulletAddBuff(FBulletHitWorldEntityOperation operation)
	{
		EntityHandle handle = CharacterModel.Instance.GetHandle(operation.CasterEntityId);
		if (handle == null || !handle.Valid)
		{
			return;
		}
		CreatureDataComponent component = handle.Entity.GetComponent<CreatureDataComponent>();
		if (component == null)
		{
			return;
		}
		EntityHandle handle2 = CharacterModel.Instance.GetHandle(operation.EntityId);
		if (handle2 == null || !handle2.Valid)
		{
			return;
		}
		BaseBuffComponent component2 = handle2.Entity.GetComponent<BaseBuffComponent>();
		if (component2 == null)
		{
			return;
		}
		component2.AddBuff(operation.LongParam1, new AddBuffParam
		{
			InstigatorId = component.GetCreatureDataId(),
			PreMessageId = new long?(operation.ExtraParam.MessageId),
			Reason = "KuroBullet命中",
			BulletMessageId = new long?(operation.ExtraParam.MessageId)
		});
	}

	// Token: 0x06016608 RID: 91656 RVA: 0x00684640 File Offset: 0x00682840
	private void KuroBulletHit(FBulletHitWorldEntityOperation operation)
	{
		EntityHandle handle = CharacterModel.Instance.GetHandle(operation.EntityId);
		if (handle == null || !handle.Valid)
		{
			return;
		}
		CharacterHitComponent component = handle.Entity.GetComponent<CharacterHitComponent>();
		if (component == null)
		{
			return;
		}
		component.OnHitByKuroBullet(operation.CasterEntityId, operation.LongParam1, operation.Location, operation.ExtraParam);
	}

	// Token: 0x06016609 RID: 91657 RVA: 0x00684698 File Offset: 0x00682898
	private void KuroBulletDodge(FBulletHitWorldEntityOperation operation)
	{
		EntityHandle handle = CharacterModel.Instance.GetHandle(operation.EntityId);
		if (handle == null || !handle.Valid)
		{
			return;
		}
		RoleKuroFastCollisionComponent component = handle.Entity.GetComponent<RoleKuroFastCollisionComponent>();
		if (component == null)
		{
			return;
		}
		if (!component.CanDodge())
		{
			return;
		}
		CharacterActorComponent component2 = handle.Entity.GetComponent<CharacterActorComponent>();
		if (component2 == null)
		{
			return;
		}
		UAbilitySystemBlueprintLibrary.SendGameplayEventToActor(component2.Actor, GameplayTagUtils.GetGameplayTagById(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.触发极限闪避"]).Value, new FGameplayEventData());
		EntityHandle handle2 = CharacterModel.Instance.GetHandle(operation.CasterEntityId);
		if (handle2 == null || !handle2.Valid)
		{
			return;
		}
		CreatureDataComponent component3 = handle2.Entity.GetComponent<CreatureDataComponent>();
		long? num = (component3 != null) ? new long?(component3.GetCreatureDataId()) : null;
		if (num != null)
		{
			this.SendDodgeInfoPush(handle.Entity, num.Value, operation.LongParam1, new long?(operation.ExtraParam.MessageId));
		}
		SceneTeamController.Instance.EmitEvent<Entity, Entity, int, long>(handle.Entity, EEventName.CharLimitDodge, handle2.Entity, handle.Entity, operation.ExtraParam.SkillId, operation.LongParam1);
	}

	// Token: 0x0601660A RID: 91658 RVA: 0x006847C0 File Offset: 0x006829C0
	private void KuroBulletAddBuffWithRef(FBulletHitWorldEntityOperation operation)
	{
		EntityHandle handle = CharacterModel.Instance.GetHandle(operation.CasterEntityId);
		if (handle == null || !handle.Valid)
		{
			return;
		}
		CreatureDataComponent component = handle.Entity.GetComponent<CreatureDataComponent>();
		if (component == null)
		{
			return;
		}
		EntityHandle handle2 = CharacterModel.Instance.GetHandle(operation.EntityId);
		if (handle2 == null || !handle2.Valid)
		{
			return;
		}
		BaseBuffComponent component2 = handle2.Entity.GetComponent<BaseBuffComponent>();
		if (component2 == null)
		{
			return;
		}
		long longParam = operation.LongParam1;
		long creatureDataId = component.GetCreatureDataId();
		BaseBuffComponent buffApplyTarget = component2.GetBuffApplyTarget(longParam, creatureDataId);
		if (buffApplyTarget != null)
		{
			buffApplyTarget.AddBuffRefEntityId(longParam, operation.EntityId);
			if (buffApplyTarget.HasBuff(longParam, false))
			{
				return;
			}
		}
		component2.AddBuff(longParam, new AddBuffParam
		{
			InstigatorId = creatureDataId,
			PreMessageId = new long?(operation.ExtraParam.MessageId),
			Reason = "KuroBullet进入范围",
			BulletMessageId = new long?(operation.ExtraParam.MessageId)
		});
	}

	// Token: 0x0601660B RID: 91659 RVA: 0x006848B0 File Offset: 0x00682AB0
	private void KuroBulletRemoveBuffWithRef(FBulletHitWorldEntityOperation operation)
	{
		EntityHandle handle = CharacterModel.Instance.GetHandle(operation.CasterEntityId);
		if (handle == null || !handle.Valid)
		{
			return;
		}
		CreatureDataComponent component = handle.Entity.GetComponent<CreatureDataComponent>();
		if (component == null)
		{
			return;
		}
		EntityHandle handle2 = CharacterModel.Instance.GetHandle(operation.EntityId);
		if (handle2 == null || !handle2.Valid)
		{
			return;
		}
		BaseBuffComponent component2 = handle2.Entity.GetComponent<BaseBuffComponent>();
		if (component2 == null)
		{
			return;
		}
		long longParam = operation.LongParam1;
		BaseBuffComponent buffApplyTarget = component2.GetBuffApplyTarget(longParam, component.GetCreatureDataId());
		if (buffApplyTarget != null)
		{
			buffApplyTarget.RemoveBuffRefEntityId(longParam, operation.EntityId);
			if (buffApplyTarget.HasBuffRefEntityId(longParam))
			{
				return;
			}
		}
		component2.RemoveBuff(longParam, -1, "KuroBullet离开范围", null, null, null);
	}

	// Token: 0x170022DC RID: 8924
	// (get) Token: 0x0601660C RID: 91660 RVA: 0x0068497A File Offset: 0x00682B7A
	public static BulletModel Instance
	{
		get
		{
			return BulletModel._Instance;
		}
	}

	// Token: 0x0601660D RID: 91661 RVA: 0x00684981 File Offset: 0x00682B81
	public static BulletModel GetOrCreateInstance()
	{
		if (BulletModel._Instance == null)
		{
			BulletModel.CreateInstance();
		}
		return BulletModel._Instance;
	}

	// Token: 0x0601660E RID: 91662 RVA: 0x00684995 File Offset: 0x00682B95
	public static bool CreateInstance()
	{
		if (BulletModel._Instance != null)
		{
			return true;
		}
		BulletModel._Instance = new BulletModel();
		return true;
	}

	// Token: 0x0601660F RID: 91663 RVA: 0x006849AB File Offset: 0x00682BAB
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06016610 RID: 91664 RVA: 0x006849AD File Offset: 0x00682BAD
	public static void ResetStaticDefaultValue()
	{
		BulletModel._Instance = null;
	}

	// Token: 0x06016611 RID: 91665 RVA: 0x006849B8 File Offset: 0x00682BB8
	static BulletModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BulletModel.CreateStaticDefaultValue), new Action(BulletModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400BD8B RID: 48523
	private readonly OrderedDictionary<int, BulletEntity> BulletEntityMap = new OrderedDictionary<int, BulletEntity>();

	// Token: 0x0400BD8C RID: 48524
	[StaticVariableRuleIgnore]
	private static readonly int MaxBulletEntitySetCacheCount = 20;

	// Token: 0x0400BD8D RID: 48525
	private readonly List<OrderedSet<BulletEntity>> BulletEntitySets = new List<OrderedSet<BulletEntity>>();

	// Token: 0x0400BD8E RID: 48526
	private readonly Dictionary<int, OrderedSet<BulletEntity>> AttackerBullet = new Dictionary<int, OrderedSet<BulletEntity>>();

	// Token: 0x0400BD8F RID: 48527
	private readonly HashSet<int> NeedDestroyBullets = new HashSet<int>();

	// Token: 0x0400BD90 RID: 48528
	[Nullable(2)]
	private BulletCommonDataAsset_C CommonConfig;

	// Token: 0x0400BD91 RID: 48529
	[Nullable(2)]
	public DefaultBulletSceneInteraction_C DefaultBulletSceneInteraction;

	// Token: 0x0400BD92 RID: 48530
	public int PatternHandleIdGen;

	// Token: 0x0400BD93 RID: 48531
	private int OnHitMaterialDelayMsInternal;

	// Token: 0x0400BD94 RID: 48532
	private bool OpenHitMaterialInternal = true;

	// Token: 0x0400BD95 RID: 48533
	[StaticVariableRuleIgnore]
	private static readonly Stat BulletPreloadStat = Stat.Create("BulletPreload", "", "");

	// Token: 0x0400BD96 RID: 48534
	private readonly Dictionary<int, bool> MapBulletHit = new Dictionary<int, bool>();

	// Token: 0x0400BD97 RID: 48535
	[StaticVariableRuleIgnore]
	private static readonly Stat BulletCreateEntityStat = Stat.Create("BulletCreateEntity", "", "");

	// Token: 0x0400BD98 RID: 48536
	[StaticVariableRuleIgnore]
	private static readonly Stat BulletClearDestroyedStat = Stat.Create("BulletClearDestroyed", "", "");

	// Token: 0x0400BD99 RID: 48537
	[StaticVariableRuleIgnore]
	private static readonly Stat BulletRecycleBulletEntityStat = Stat.Create("BulletRecycleBulletEntity", "", "");

	// Token: 0x0400BD9A RID: 48538
	private readonly Dictionary<int, Dictionary<int, int>> HandleToEntityIdDict = new Dictionary<int, Dictionary<int, int>>();

	// Token: 0x0400BD9B RID: 48539
	private readonly Dictionary<int, ActiveBulletHandle> EntityIdToHandleDict = new Dictionary<int, ActiveBulletHandle>();

	// Token: 0x0400BD9C RID: 48540
	private readonly Dictionary<string, int> MapCustomKey = new Dictionary<string, int>();

	// Token: 0x0400BD9D RID: 48541
	private readonly Dictionary<string, int> CustomBulletAttacker = new Dictionary<string, int>();

	// Token: 0x0400BD9E RID: 48542
	private readonly HashSet<int> PatternOwnerEntityIds = new HashSet<int>();

	// Token: 0x0400BD9F RID: 48543
	private readonly Dictionary<int, bool> MapAttackerDrawCollision = new Dictionary<int, bool>();

	// Token: 0x0400BDA0 RID: 48544
	private readonly Dictionary<int, bool> MapAttackerDrawTrace = new Dictionary<int, bool>();

	// Token: 0x0400BDA1 RID: 48545
	[Nullable(2)]
	public HashSet<EHitAnim> SelfAdaptBeHitAnim;

	// Token: 0x0400BDA2 RID: 48546
	[Nullable(2)]
	public HashSet<EHitAnim> HeavyHitAnim;

	// Token: 0x0400BDA3 RID: 48547
	[Nullable(2)]
	public EHitAnim[] Index2LightHitAnimMap;

	// Token: 0x0400BDA4 RID: 48548
	[Nullable(2)]
	public EHitAnim[] Index2HeavyHitAnimMap;

	// Token: 0x0400BDA5 RID: 48549
	private readonly HashSet<int> BulletEntityDestroyWhenPlot = new HashSet<int>();

	// Token: 0x0400BDA6 RID: 48550
	private bool PlotPlaying;

	// Token: 0x0400BDA7 RID: 48551
	public Dictionary<int, BulletPersistentTimeScale> PersistentTimeScaleMap = new Dictionary<int, BulletPersistentTimeScale>();

	// Token: 0x0400BDA8 RID: 48552
	public int PersistentTimeScaleId;

	// Token: 0x0400BDA9 RID: 48553
	private long SceneBulletOwnerIdInternal;

	// Token: 0x0400BDAA RID: 48554
	public bool IsSceneBulletOwnerCreated;

	// Token: 0x0400BDAB RID: 48555
	[Nullable(2)]
	private WaitEntityTask WaitSceneBulletOwnerTask;

	// Token: 0x0400BDAC RID: 48556
	[Nullable(2)]
	private CustomPromise<bool> PreloadPromise;

	// Token: 0x0400BDAD RID: 48557
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, HashSet<long>> SummonerSummonedCreatureDataIds;

	// Token: 0x0400BDAE RID: 48558
	[Nullable(2)]
	private Dictionary<long, int> SummonedCreatureDataIdToSummoner;

	// Token: 0x0400BDAF RID: 48559
	[Nullable(2)]
	private UBulletWorld KuroBulletWorldInternal;

	// Token: 0x0400BDB0 RID: 48560
	[Nullable(2)]
	private UKscBulletManager KscBulletManager;

	// Token: 0x0400BDB1 RID: 48561
	[Nullable(2)]
	private UBulletHitWorldEntityManager BulletHitWorldEntityManager;

	// Token: 0x0400BDB2 RID: 48562
	[Nullable(2)]
	private UBulletHitWorldEntityBridge BulletHitWorldEntityBridge;

	// Token: 0x0400BDB3 RID: 48563
	private readonly TimeLimit TimeLimit = new TimeLimit(new long?(1000L));

	// Token: 0x0400BDB4 RID: 48564
	private TArray<FBulletHitWorldEntityOperation> OperationList = new TArray<FBulletHitWorldEntityOperation>();

	// Token: 0x0400BDB5 RID: 48565
	private readonly Queue<FBulletHitWorldEntityOperation> PendingOperationQueue = new Queue<FBulletHitWorldEntityOperation>(4);

	// Token: 0x0400BDB6 RID: 48566
	[Nullable(2)]
	private static BulletModel _Instance;
}
