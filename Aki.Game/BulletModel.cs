using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Core.Fight;
using AkiClient.Game.Aki.Core.Fight.Bullet;
using AkiClient.Game.Aki.Data.Fight;
using CSharpScript.Core.Common;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.CombatMessage;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x02002E15 RID: 11797
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class BulletModel : ModelBase
{
	// Token: 0x06018CFC RID: 101628 RVA: 0x0065C270 File Offset: 0x0065A470
	public OrderedDictionary<int, BulletEntity> GetBulletEntityMap()
	{
		return this.BulletEntityMap;
	}

	// Token: 0x06018CFD RID: 101629 RVA: 0x0065C278 File Offset: 0x0065A478
	[NullableContext(2)]
	public BulletEntity GetBulletEntityById(int id)
	{
		BulletEntity result;
		this.BulletEntityMap.TryGetValue(id, out result);
		return result;
	}

	// Token: 0x06018CFE RID: 101630 RVA: 0x0065C298 File Offset: 0x0065A498
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

	// Token: 0x06018CFF RID: 101631 RVA: 0x0065C2B5 File Offset: 0x0065A4B5
	public IEnumerable<OrderedSet<BulletEntity>> GetAttackerBulletIterator()
	{
		return this.AttackerBullet.Values;
	}

	// Token: 0x06018D00 RID: 101632 RVA: 0x0065C2C2 File Offset: 0x0065A4C2
	public IEnumerable<int> GetAttackers()
	{
		return this.AttackerBullet.Keys;
	}

	// Token: 0x1700226E RID: 8814
	// (get) Token: 0x06018D01 RID: 101633 RVA: 0x0065C2CF File Offset: 0x0065A4CF
	public int OnHitMaterialMsDelay
	{
		get
		{
			return this.OnHitMaterialDelayMsInternal;
		}
	}

	// Token: 0x1700226F RID: 8815
	// (get) Token: 0x06018D02 RID: 101634 RVA: 0x0065C2D7 File Offset: 0x0065A4D7
	// (set) Token: 0x06018D03 RID: 101635 RVA: 0x0065C2E0 File Offset: 0x0065A4E0
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

	// Token: 0x06018D04 RID: 101636 RVA: 0x0065C320 File Offset: 0x0065A520
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
		if (Info.Instance.IsBuildDevelopmentOrDebug)
		{
			EventSystem.Instance.Add<global::HitInformation, IAttributeSet>(EEventName.BulletHit, new Action<global::HitInformation, IAttributeSet>(this.OnBulletHit));
		}
		this.InitBulletVictimPerformData();
		this.SummonerSummonedCreatureDataIds = new Dictionary<int, HashSet<long>>();
		this.SummonedCreatureDataIdToSummoner = new Dictionary<long, int>();
		return true;
	}

	// Token: 0x06018D05 RID: 101637 RVA: 0x0065C425 File Offset: 0x0065A625
	private void OnWorldDone()
	{
		BulletActorPool.Preload();
		BulletConfig.Instance.PreloadCommonWhitelist();
	}

	// Token: 0x06018D06 RID: 101638 RVA: 0x0065C438 File Offset: 0x0065A638
	public bool IsBulletHit(int entityId)
	{
		bool flag;
		return this.MapBulletHit.TryGetValue(entityId, out flag) && flag;
	}

	// Token: 0x06018D07 RID: 101639 RVA: 0x0065C455 File Offset: 0x0065A655
	private void OnBulletHit(global::HitInformation hitData, [Nullable(2)] IAttributeSet attackerAttribute)
	{
		this.MapBulletHit[hitData.BulletEntityId] = true;
	}

	// Token: 0x06018D08 RID: 101640 RVA: 0x0065C46C File Offset: 0x0065A66C
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

	// Token: 0x06018D09 RID: 101641 RVA: 0x0065C540 File Offset: 0x0065A740
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

	// Token: 0x06018D0A RID: 101642 RVA: 0x0065C590 File Offset: 0x0065A790
	protected override bool OnChangeMode()
	{
		this.ClearBulletEntities();
		return true;
	}

	// Token: 0x06018D0B RID: 101643 RVA: 0x0065C59C File Offset: 0x0065A79C
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Remove(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnPlotStart));
		EventSystem.Instance.Remove(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.OnPlotEnd));
		EventSystem.Instance.Remove(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		if (Info.Instance.IsBuildDevelopmentOrDebug)
		{
			EventSystem.Instance.Remove(EEventName.BulletHit, new Action<global::HitInformation, IAttributeSet>(this.OnBulletHit));
		}
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

	// Token: 0x06018D0C RID: 101644 RVA: 0x0065C6E0 File Offset: 0x0065A8E0
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

	// Token: 0x06018D0D RID: 101645 RVA: 0x0065CB7C File Offset: 0x0065AD7C
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

	// Token: 0x06018D0E RID: 101646 RVA: 0x0065CD60 File Offset: 0x0065AF60
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

	// Token: 0x06018D0F RID: 101647 RVA: 0x0065CE5C File Offset: 0x0065B05C
	public void DestroyAllBullet(bool summonChild = false)
	{
		foreach (int id in this.BulletEntityMap.Keys)
		{
			this.DestroyBullet(id, summonChild, EBulletDestroyReason.Normal, false);
		}
	}

	// Token: 0x06018D10 RID: 101648 RVA: 0x0065CEB8 File Offset: 0x0065B0B8
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

	// Token: 0x06018D11 RID: 101649 RVA: 0x0065D0E8 File Offset: 0x0065B2E8
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

	// Token: 0x17002270 RID: 8816
	// (get) Token: 0x06018D12 RID: 101650 RVA: 0x0065D1FF File Offset: 0x0065B3FF
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

	// Token: 0x17002271 RID: 8817
	// (get) Token: 0x06018D13 RID: 101651 RVA: 0x0065D20C File Offset: 0x0065B40C
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

	// Token: 0x17002272 RID: 8818
	// (get) Token: 0x06018D14 RID: 101652 RVA: 0x0065D219 File Offset: 0x0065B419
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

	// Token: 0x06018D15 RID: 101653 RVA: 0x0065D228 File Offset: 0x0065B428
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

	// Token: 0x06018D16 RID: 101654 RVA: 0x0065D288 File Offset: 0x0065B488
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

	// Token: 0x06018D17 RID: 101655 RVA: 0x0065D308 File Offset: 0x0065B508
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

	// Token: 0x06018D18 RID: 101656 RVA: 0x0065D348 File Offset: 0x0065B548
	[NullableContext(2)]
	public ActiveBulletHandle GetBulletHandleById(int bulletEntityId)
	{
		ActiveBulletHandle result;
		this.EntityIdToHandleDict.TryGetValue(bulletEntityId, out result);
		return result;
	}

	// Token: 0x06018D19 RID: 101657 RVA: 0x0065D368 File Offset: 0x0065B568
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

	// Token: 0x06018D1A RID: 101658 RVA: 0x0065D3C8 File Offset: 0x0065B5C8
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

	// Token: 0x06018D1B RID: 101659 RVA: 0x0065D414 File Offset: 0x0065B614
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

	// Token: 0x06018D1C RID: 101660 RVA: 0x0065D490 File Offset: 0x0065B690
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

	// Token: 0x06018D1D RID: 101661 RVA: 0x0065D530 File Offset: 0x0065B730
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

	// Token: 0x06018D1E RID: 101662 RVA: 0x0065D5B4 File Offset: 0x0065B7B4
	public int? GetCustomBulletAttacker(string customKey)
	{
		int value;
		if (this.CustomBulletAttacker.TryGetValue(customKey, out value))
		{
			return new int?(value);
		}
		return null;
	}

	// Token: 0x06018D1F RID: 101663 RVA: 0x0065D5E1 File Offset: 0x0065B7E1
	public void SetCustomBulletAttacker(string customKey, int attackerId)
	{
		this.CustomBulletAttacker[customKey] = attackerId;
	}

	// Token: 0x06018D20 RID: 101664 RVA: 0x0065D5F0 File Offset: 0x0065B7F0
	public bool RemoveCustomBulletAttacker(string customKey)
	{
		return this.CustomBulletAttacker.Remove(customKey);
	}

	// Token: 0x06018D21 RID: 101665 RVA: 0x0065D600 File Offset: 0x0065B800
	public bool ShowBulletCollision(int entityId = 0)
	{
		bool flag;
		return this.MapAttackerDrawCollision.ContainsKey(entityId) && (this.MapAttackerDrawCollision.TryGetValue(entityId, out flag) && flag);
	}

	// Token: 0x06018D22 RID: 101666 RVA: 0x0065D630 File Offset: 0x0065B830
	public bool ShowBulletTrace(int entityId = 0)
	{
		bool flag;
		return this.MapAttackerDrawTrace.ContainsKey(entityId) && (this.MapAttackerDrawTrace.TryGetValue(entityId, out flag) && flag);
	}

	// Token: 0x06018D23 RID: 101667 RVA: 0x0065D65D File Offset: 0x0065B85D
	public void SetBulletCollisionDraw(int entityId, bool enable)
	{
		this.MapAttackerDrawCollision[entityId] = enable;
	}

	// Token: 0x06018D24 RID: 101668 RVA: 0x0065D66C File Offset: 0x0065B86C
	public void SetBulletTraceDraw(int entityId, bool enable)
	{
		this.MapAttackerDrawTrace[entityId] = enable;
	}

	// Token: 0x06018D25 RID: 101669 RVA: 0x0065D67C File Offset: 0x0065B87C
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

	// Token: 0x06018D26 RID: 101670 RVA: 0x0065D732 File Offset: 0x0065B932
	private void ClearBulletVictimPerformData()
	{
		this.SelfAdaptBeHitAnim = null;
		this.HeavyHitAnim = null;
		this.Index2LightHitAnimMap = null;
		this.Index2HeavyHitAnimMap = null;
	}

	// Token: 0x06018D27 RID: 101671 RVA: 0x0065D750 File Offset: 0x0065B950
	private bool IsBulletDestroyWhenPlot(string bulletRowName)
	{
		return bulletRowName == "310000001";
	}

	// Token: 0x06018D28 RID: 101672 RVA: 0x0065D760 File Offset: 0x0065B960
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

	// Token: 0x06018D29 RID: 101673 RVA: 0x0065D7EC File Offset: 0x0065B9EC
	private void OnPlotEnd(PlotResultInfo plotResultInfo)
	{
		if (!this.PlotPlaying)
		{
			return;
		}
		this.SetAllBulletEffectHidden(false);
		this.PlotPlaying = false;
	}

	// Token: 0x06018D2A RID: 101674 RVA: 0x0065D808 File Offset: 0x0065BA08
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

	// Token: 0x06018D2B RID: 101675 RVA: 0x0065D938 File Offset: 0x0065BB38
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

	// Token: 0x06018D2C RID: 101676 RVA: 0x0065D9B0 File Offset: 0x0065BBB0
	private void ClearPersistentTimeScale()
	{
		this.PersistentTimeScaleId = 0;
		this.PersistentTimeScaleMap.Clear();
	}

	// Token: 0x17002273 RID: 8819
	// (get) Token: 0x06018D2D RID: 101677 RVA: 0x0065D9C4 File Offset: 0x0065BBC4
	// (set) Token: 0x06018D2E RID: 101678 RVA: 0x0065D9CC File Offset: 0x0065BBCC
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

	// Token: 0x06018D2F RID: 101679 RVA: 0x0065D9D8 File Offset: 0x0065BBD8
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

	// Token: 0x06018D30 RID: 101680 RVA: 0x0065DA97 File Offset: 0x0065BC97
	private void ClearWaitSceneBulletOwnerTask()
	{
		this.IsSceneBulletOwnerCreated = false;
		if (this.WaitSceneBulletOwnerTask != null)
		{
			this.WaitSceneBulletOwnerTask.Cancel();
			this.WaitSceneBulletOwnerTask = null;
		}
	}

	// Token: 0x06018D31 RID: 101681 RVA: 0x0065DABC File Offset: 0x0065BCBC
	private void SetAllBulletEffectHidden(bool hidden)
	{
		foreach (BulletEntity bulletEntity in this.BulletEntityMap.Values)
		{
			this.SetBulletEffectHidden(bulletEntity, hidden);
		}
	}

	// Token: 0x06018D32 RID: 101682 RVA: 0x0065DB18 File Offset: 0x0065BD18
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

	// Token: 0x06018D33 RID: 101683 RVA: 0x0065DB5C File Offset: 0x0065BD5C
	public void SummonerSummon(int summonerId, long creatureDataId)
	{
		if (!this.SummonerSummonedCreatureDataIds.ContainsKey(summonerId))
		{
			this.SummonerSummonedCreatureDataIds[summonerId] = new HashSet<long>();
		}
		this.SummonerSummonedCreatureDataIds[summonerId].Add(creatureDataId);
		this.SummonedCreatureDataIdToSummoner[creatureDataId] = summonerId;
	}

	// Token: 0x06018D34 RID: 101684 RVA: 0x0065DBA8 File Offset: 0x0065BDA8
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

	// Token: 0x06018D35 RID: 101685 RVA: 0x0065DC58 File Offset: 0x0065BE58
	private void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
	{
		int id = handle.Id;
		if (id != 0)
		{
			OrderedSet<BulletEntity> orderedSet;
			if (this.AttackerBullet.TryGetValue(id, out orderedSet) && orderedSet.Count > 0)
			{
				foreach (BulletEntity bulletEntity in orderedSet)
				{
					BulletController.Instance.DestroyBullet(bulletEntity.Id, false, EBulletDestroyReason.Normal, false);
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

	// Token: 0x06018D36 RID: 101686 RVA: 0x0065DD4C File Offset: 0x0065BF4C
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

	// Token: 0x06018D37 RID: 101687 RVA: 0x0065DF40 File Offset: 0x0065C140
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

	// Token: 0x06018D38 RID: 101688 RVA: 0x0065DFA8 File Offset: 0x0065C1A8
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

	// Token: 0x06018D39 RID: 101689 RVA: 0x0065E020 File Offset: 0x0065C220
	[NullableContext(2)]
	public UBulletWorld GetKuroBulletWorld()
	{
		return this.KuroBulletWorldInternal;
	}

	// Token: 0x06018D3A RID: 101690 RVA: 0x0065E028 File Offset: 0x0065C228
	[NullableContext(2)]
	public UBulletHitWorldEntityManager GetBulletHitWorldEntityManager()
	{
		return this.BulletHitWorldEntityManager;
	}

	// Token: 0x06018D3B RID: 101691 RVA: 0x0065E030 File Offset: 0x0065C230
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

	// Token: 0x06018D3C RID: 101692 RVA: 0x0065E19C File Offset: 0x0065C39C
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

	// Token: 0x06018D3D RID: 101693 RVA: 0x0065E23A File Offset: 0x0065C43A
	private void OnBulletModifyBuff(int entityId, long buffId, bool isAdd)
	{
		KuroSimpleCombatController.Instance.ModifyBuffAsync(entityId, isAdd, (int)buffId);
	}

	// Token: 0x06018D3E RID: 101694 RVA: 0x0065E24A File Offset: 0x0065C44A
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
			CameraController.Instance.PlayWorldCameraShake(shakeType, new FVectorDouble?(value), 0f, 100f, 1f, false, "MainCamera");
		}, 100, "js_undefined");
	}

	// Token: 0x06018D3F RID: 101695 RVA: 0x0065E288 File Offset: 0x0065C488
	private void ForceDestroyKuroBulletWorld()
	{
		this.StopKuroBulletWorld();
		Log.Instance.Info(ELogModule.Bullet, ELogAuthor.HXY, "KuroBulletWorld强制销毁完成", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06018D40 RID: 101696 RVA: 0x0065E2B7 File Offset: 0x0065C4B7
	public void StartKscBullet()
	{
		if (this.KscBulletManager != null)
		{
			return;
		}
		this.KscBulletManager = UKscBulletManager.CreateInstance(GlobalData.World);
	}

	// Token: 0x06018D41 RID: 101697 RVA: 0x0065E2D2 File Offset: 0x0065C4D2
	public void StopKscBullet()
	{
		if (this.KscBulletManager == null)
		{
			return;
		}
		UKscBulletManager.DestroyInstance();
		this.KscBulletManager = null;
	}

	// Token: 0x06018D42 RID: 101698 RVA: 0x0065E2EC File Offset: 0x0065C4EC
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

	// Token: 0x06018D43 RID: 101699 RVA: 0x0065E340 File Offset: 0x0065C540
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

	// Token: 0x06018D44 RID: 101700 RVA: 0x0065E3AC File Offset: 0x0065C5AC
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

	// Token: 0x06018D45 RID: 101701 RVA: 0x0065E3FC File Offset: 0x0065C5FC
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

	// Token: 0x06018D46 RID: 101702 RVA: 0x0065E4B8 File Offset: 0x0065C6B8
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

	// Token: 0x06018D47 RID: 101703 RVA: 0x0065E510 File Offset: 0x0065C710
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

	// Token: 0x06018D48 RID: 101704 RVA: 0x0065E638 File Offset: 0x0065C838
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

	// Token: 0x06018D49 RID: 101705 RVA: 0x0065E728 File Offset: 0x0065C928
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

	// Token: 0x17002274 RID: 8820
	// (get) Token: 0x06018D4A RID: 101706 RVA: 0x0065E7F2 File Offset: 0x0065C9F2
	public static BulletModel Instance
	{
		get
		{
			return BulletModel._Instance;
		}
	}

	// Token: 0x06018D4B RID: 101707 RVA: 0x0065E7F9 File Offset: 0x0065C9F9
	public static BulletModel GetOrCreateInstance()
	{
		if (BulletModel._Instance == null)
		{
			BulletModel.CreateInstance();
		}
		return BulletModel._Instance;
	}

	// Token: 0x06018D4C RID: 101708 RVA: 0x0065E80D File Offset: 0x0065CA0D
	public static bool CreateInstance()
	{
		if (BulletModel._Instance != null)
		{
			return true;
		}
		BulletModel._Instance = new BulletModel();
		return true;
	}

	// Token: 0x06018D4D RID: 101709 RVA: 0x0065E823 File Offset: 0x0065CA23
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06018D4E RID: 101710 RVA: 0x0065E825 File Offset: 0x0065CA25
	public static void ResetStaticDefaultValue()
	{
		BulletModel._Instance = null;
	}

	// Token: 0x06018D4F RID: 101711 RVA: 0x0065E830 File Offset: 0x0065CA30
	static BulletModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BulletModel.CreateStaticDefaultValue), new Action(BulletModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400B9FD RID: 47613
	private readonly OrderedDictionary<int, BulletEntity> BulletEntityMap = new OrderedDictionary<int, BulletEntity>();

	// Token: 0x0400B9FE RID: 47614
	[StaticVariableRuleIgnore]
	private static readonly int MaxBulletEntitySetCacheCount = 20;

	// Token: 0x0400B9FF RID: 47615
	private readonly List<OrderedSet<BulletEntity>> BulletEntitySets = new List<OrderedSet<BulletEntity>>();

	// Token: 0x0400BA00 RID: 47616
	private readonly Dictionary<int, OrderedSet<BulletEntity>> AttackerBullet = new Dictionary<int, OrderedSet<BulletEntity>>();

	// Token: 0x0400BA01 RID: 47617
	private readonly HashSet<int> NeedDestroyBullets = new HashSet<int>();

	// Token: 0x0400BA02 RID: 47618
	[Nullable(2)]
	private BulletCommonDataAsset_C CommonConfig;

	// Token: 0x0400BA03 RID: 47619
	[Nullable(2)]
	public DefaultBulletSceneInteraction_C DefaultBulletSceneInteraction;

	// Token: 0x0400BA04 RID: 47620
	public int PatternHandleIdGen;

	// Token: 0x0400BA05 RID: 47621
	private int OnHitMaterialDelayMsInternal;

	// Token: 0x0400BA06 RID: 47622
	private bool OpenHitMaterialInternal = true;

	// Token: 0x0400BA07 RID: 47623
	[StaticVariableRuleIgnore]
	private static readonly Stat BulletPreloadStat = Stat.Create("BulletPreload", "", "");

	// Token: 0x0400BA08 RID: 47624
	private readonly Dictionary<int, bool> MapBulletHit = new Dictionary<int, bool>();

	// Token: 0x0400BA09 RID: 47625
	[StaticVariableRuleIgnore]
	private static readonly Stat BulletCreateEntityStat = Stat.Create("BulletCreateEntity", "", "");

	// Token: 0x0400BA0A RID: 47626
	[StaticVariableRuleIgnore]
	private static readonly Stat BulletClearDestroyedStat = Stat.Create("BulletClearDestroyed", "", "");

	// Token: 0x0400BA0B RID: 47627
	[StaticVariableRuleIgnore]
	private static readonly Stat BulletRecycleBulletEntityStat = Stat.Create("BulletRecycleBulletEntity", "", "");

	// Token: 0x0400BA0C RID: 47628
	private readonly Dictionary<int, Dictionary<int, int>> HandleToEntityIdDict = new Dictionary<int, Dictionary<int, int>>();

	// Token: 0x0400BA0D RID: 47629
	private readonly Dictionary<int, ActiveBulletHandle> EntityIdToHandleDict = new Dictionary<int, ActiveBulletHandle>();

	// Token: 0x0400BA0E RID: 47630
	private readonly Dictionary<string, int> MapCustomKey = new Dictionary<string, int>();

	// Token: 0x0400BA0F RID: 47631
	private readonly Dictionary<string, int> CustomBulletAttacker = new Dictionary<string, int>();

	// Token: 0x0400BA10 RID: 47632
	private readonly HashSet<int> PatternOwnerEntityIds = new HashSet<int>();

	// Token: 0x0400BA11 RID: 47633
	private readonly Dictionary<int, bool> MapAttackerDrawCollision = new Dictionary<int, bool>();

	// Token: 0x0400BA12 RID: 47634
	private readonly Dictionary<int, bool> MapAttackerDrawTrace = new Dictionary<int, bool>();

	// Token: 0x0400BA13 RID: 47635
	[Nullable(2)]
	public HashSet<EHitAnim> SelfAdaptBeHitAnim;

	// Token: 0x0400BA14 RID: 47636
	[Nullable(2)]
	public HashSet<EHitAnim> HeavyHitAnim;

	// Token: 0x0400BA15 RID: 47637
	[Nullable(2)]
	public EHitAnim[] Index2LightHitAnimMap;

	// Token: 0x0400BA16 RID: 47638
	[Nullable(2)]
	public EHitAnim[] Index2HeavyHitAnimMap;

	// Token: 0x0400BA17 RID: 47639
	private readonly HashSet<int> BulletEntityDestroyWhenPlot = new HashSet<int>();

	// Token: 0x0400BA18 RID: 47640
	private bool PlotPlaying;

	// Token: 0x0400BA19 RID: 47641
	public Dictionary<int, BulletPersistentTimeScale> PersistentTimeScaleMap = new Dictionary<int, BulletPersistentTimeScale>();

	// Token: 0x0400BA1A RID: 47642
	public int PersistentTimeScaleId;

	// Token: 0x0400BA1B RID: 47643
	private long SceneBulletOwnerIdInternal;

	// Token: 0x0400BA1C RID: 47644
	public bool IsSceneBulletOwnerCreated;

	// Token: 0x0400BA1D RID: 47645
	[Nullable(2)]
	private WaitEntityTask WaitSceneBulletOwnerTask;

	// Token: 0x0400BA1E RID: 47646
	[Nullable(2)]
	private CustomPromise<bool> PreloadPromise;

	// Token: 0x0400BA1F RID: 47647
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, HashSet<long>> SummonerSummonedCreatureDataIds;

	// Token: 0x0400BA20 RID: 47648
	[Nullable(2)]
	private Dictionary<long, int> SummonedCreatureDataIdToSummoner;

	// Token: 0x0400BA21 RID: 47649
	[Nullable(2)]
	private UBulletWorld KuroBulletWorldInternal;

	// Token: 0x0400BA22 RID: 47650
	[Nullable(2)]
	private UKscBulletManager KscBulletManager;

	// Token: 0x0400BA23 RID: 47651
	[Nullable(2)]
	private UBulletHitWorldEntityManager BulletHitWorldEntityManager;

	// Token: 0x0400BA24 RID: 47652
	[Nullable(2)]
	private UBulletHitWorldEntityBridge BulletHitWorldEntityBridge;

	// Token: 0x0400BA25 RID: 47653
	private readonly TimeLimit TimeLimit = new TimeLimit(new long?(1000L));

	// Token: 0x0400BA26 RID: 47654
	private TArray<FBulletHitWorldEntityOperation> OperationList = new TArray<FBulletHitWorldEntityOperation>();

	// Token: 0x0400BA27 RID: 47655
	private readonly Queue<FBulletHitWorldEntityOperation> PendingOperationQueue = new Queue<FBulletHitWorldEntityOperation>(4);

	// Token: 0x0400BA28 RID: 47656
	[Nullable(2)]
	private static BulletModel _Instance;
}
