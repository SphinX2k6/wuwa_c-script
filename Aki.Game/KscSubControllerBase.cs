using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.KuroSimpleCombat;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x0200033D RID: 829
[NullableContext(1)]
[Nullable(0)]
public class KscSubControllerBase
{
	// Token: 0x170006CB RID: 1739
	// (get) Token: 0x06002E6F RID: 11887 RVA: 0x00110A18 File Offset: 0x0010EC18
	[Nullable(2)]
	public KscSubModelBase Model
	{
		[NullableContext(2)]
		get
		{
			return this.SubModel;
		}
	}

	// Token: 0x06002E70 RID: 11888 RVA: 0x00110A20 File Offset: 0x0010EC20
	public void Init(EKscGameplayType kscGameplayType)
	{
		this.CreateModel();
		this.Model.KscGameplayType = kscGameplayType;
		this.OnInit();
	}

	// Token: 0x06002E71 RID: 11889 RVA: 0x00110A3A File Offset: 0x0010EC3A
	public void InitMap()
	{
		this.Model.Init();
		this.Model.KscInitState = EKscInitState.InitMap;
		this.InitConstVar();
		this.InitPropertyConfigs();
		this.InitEntityAndSkillDt();
		this.InitEntityFilter();
		this.OnInitMap();
		this.AddEvents();
	}

	// Token: 0x06002E72 RID: 11890 RVA: 0x00110A78 File Offset: 0x0010EC78
	[return: TupleElementNames(new string[]
	{
		"Name",
		"Promise"
	})]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public virtual ValueTuple<string, CustomPromise<bool>>? OnPreload()
	{
		CustomPromise<bool> promise = new CustomPromise<bool>();
		this.PreloadAsync().ContinueWith(delegate()
		{
			promise.SetResult(true);
		}).Forget(delegate(Exception error)
		{
			if (error != null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.CombatInfo;
				ELogAuthor author = ELogAuthor.CFT;
				string message = "Preload异常";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("error", error.Message);
				instance.ErrorWithStack(module, author, message, error, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.CombatInfo;
				ELogAuthor author2 = ELogAuthor.CFT;
				string message2 = "Preload异常";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("error", error);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
			promise.SetResult(false);
		}, true);
		return new ValueTuple<string, CustomPromise<bool>>?(new ValueTuple<string, CustomPromise<bool>>("KSC Preload", promise));
	}

	// Token: 0x06002E73 RID: 11891 RVA: 0x00110AD4 File Offset: 0x0010ECD4
	public virtual UniTask PreloadAsync()
	{
		KscSubControllerBase.<PreloadAsync>d__11 <PreloadAsync>d__;
		<PreloadAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PreloadAsync>d__.<>4__this = this;
		<PreloadAsync>d__.<>1__state = -1;
		<PreloadAsync>d__.<>t__builder.Start<KscSubControllerBase.<PreloadAsync>d__11>(ref <PreloadAsync>d__);
		return <PreloadAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06002E74 RID: 11892 RVA: 0x00110B17 File Offset: 0x0010ED17
	public void MapLoaded()
	{
		this.Model.KscInitState = EKscInitState.MapLoad;
		this.StartEngine();
		this.LastTimeDilation = 1f;
		this.InitDamageConfigs();
		this.OnMapLoaded();
	}

	// Token: 0x06002E75 RID: 11893 RVA: 0x00110B42 File Offset: 0x0010ED42
	public void WorldDone()
	{
		this.Model.KscInitState = EKscInitState.WorldDone;
		this.OnWorldDone();
		this.InitHeadStateManagerRes();
		this.AddKscPlayerEntity();
	}

	// Token: 0x06002E76 RID: 11894 RVA: 0x00110B64 File Offset: 0x0010ED64
	public void WorldReset()
	{
		this.ResetPlayerTurnRate();
		this.RemoveInputLayer();
		if (this.KscEntitySyncTimeScaleId != null)
		{
			EntityHandle possessedPlayerEntity = this.GetPossessedPlayerEntity();
			object obj;
			if (possessedPlayerEntity == null)
			{
				obj = null;
			}
			else
			{
				WorldEntity entity = possessedPlayerEntity.Entity;
				obj = ((entity != null) ? entity.GetComponent<PawnTimeScaleComponent>() : null);
			}
			object obj2 = obj;
			if (obj2 != null)
			{
				obj2.RemoveForeverTimeScale(this.KscEntitySyncTimeScaleId.Value, false);
			}
		}
		this.EnableSyncEntityTimeScaleToPlayer = false;
		this.KscEntitySyncTimeScaleId = null;
		this.LastKscEntitySyncTimeScale = 1f;
		this.OnWorldReset();
		this.StopEngine();
	}

	// Token: 0x06002E77 RID: 11895 RVA: 0x00110BEA File Offset: 0x0010EDEA
	public void ClearMap()
	{
		this.RemoveEvents();
		this.ResetEntityFilter();
		this.OnClearMap();
		this.ClearHeadState();
		this.Model.Clear();
	}

	// Token: 0x06002E78 RID: 11896 RVA: 0x00110C10 File Offset: 0x0010EE10
	public void Tick(float delta)
	{
		if (Time.Instance.TimeDilation != this.LastTimeDilation)
		{
			this.LastTimeDilation = Time.Instance.TimeDilation;
			UKSC_World kscWorld = KscEnv.Instance.KscWorld;
			if (kscWorld != null)
			{
				kscWorld.SetWorldTimeDilation(this.LastTimeDilation);
			}
		}
		this.SyncPlayerTransform();
		this.SyncPlayerTimeScale();
		this.HandleHeadHpInfos(delta);
		this.PushPlayerHp();
		this.OnTick(delta);
	}

	// Token: 0x06002E79 RID: 11897 RVA: 0x00110C7A File Offset: 0x0010EE7A
	public void Clear()
	{
		this.OnClear();
	}

	// Token: 0x06002E7A RID: 11898 RVA: 0x00110C82 File Offset: 0x0010EE82
	public virtual bool IsTargetMap(int instSubType)
	{
		return false;
	}

	// Token: 0x06002E7B RID: 11899 RVA: 0x00110C85 File Offset: 0x0010EE85
	protected virtual void CreateModel()
	{
	}

	// Token: 0x06002E7C RID: 11900 RVA: 0x00110C87 File Offset: 0x0010EE87
	protected virtual void ClearModel()
	{
	}

	// Token: 0x06002E7D RID: 11901 RVA: 0x00110C89 File Offset: 0x0010EE89
	protected virtual void OnInit()
	{
	}

	// Token: 0x06002E7E RID: 11902 RVA: 0x00110C8B File Offset: 0x0010EE8B
	protected virtual void OnInitMap()
	{
	}

	// Token: 0x06002E7F RID: 11903 RVA: 0x00110C8D File Offset: 0x0010EE8D
	protected virtual void OnMapLoaded()
	{
	}

	// Token: 0x06002E80 RID: 11904 RVA: 0x00110C8F File Offset: 0x0010EE8F
	protected virtual void OnWorldDone()
	{
	}

	// Token: 0x06002E81 RID: 11905 RVA: 0x00110C91 File Offset: 0x0010EE91
	protected virtual void OnWorldReset()
	{
	}

	// Token: 0x06002E82 RID: 11906 RVA: 0x00110C93 File Offset: 0x0010EE93
	protected virtual void OnClearMap()
	{
	}

	// Token: 0x06002E83 RID: 11907 RVA: 0x00110C95 File Offset: 0x0010EE95
	protected virtual void OnTick(float delta)
	{
	}

	// Token: 0x06002E84 RID: 11908 RVA: 0x00110C97 File Offset: 0x0010EE97
	protected virtual void OnClear()
	{
	}

	// Token: 0x06002E85 RID: 11909 RVA: 0x00110C99 File Offset: 0x0010EE99
	public virtual void OnSystemInfoNotify()
	{
	}

	// Token: 0x06002E86 RID: 11910 RVA: 0x00110C9B File Offset: 0x0010EE9B
	protected virtual void AddEvents()
	{
	}

	// Token: 0x06002E87 RID: 11911 RVA: 0x00110C9D File Offset: 0x0010EE9D
	protected virtual void RemoveEvents()
	{
	}

	// Token: 0x06002E88 RID: 11912 RVA: 0x00110C9F File Offset: 0x0010EE9F
	[NullableContext(2)]
	protected virtual UClass GetKscWorldClass()
	{
		return null;
	}

	// Token: 0x06002E89 RID: 11913 RVA: 0x00110CA4 File Offset: 0x0010EEA4
	protected virtual void UnregisterCollisionAlgorithm()
	{
		if (this.GetCollisionAlgorithmConfig() != null)
		{
			KuroFastCollisionController.Instance.DestroyAlgorithm(this.Model.KfcAlgorithm);
		}
	}

	// Token: 0x06002E8A RID: 11914 RVA: 0x00110CD8 File Offset: 0x0010EED8
	protected virtual void RegisterCollisionAlgorithm()
	{
		KscCollisionAlgorithmConfig? collisionAlgorithmConfig = this.GetCollisionAlgorithmConfig();
		if (collisionAlgorithmConfig == null)
		{
			KscLog.EModule flag = KscLog.EModule.Common;
			ELogAuthor author = ELogAuthor.HXY;
			UObject kscWorld = KscEnv.Instance.KscWorld;
			string log = "玩法不使用KFC碰撞系统，跳过注册";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("gameplayType", this.Model.GameplayType);
			KscLog.Info(flag, author, kscWorld, log, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.Model.KfcAlgorithm = KuroFastCollisionController.Instance.CreateAlgorithm(collisionAlgorithmConfig.Value.AlgorithmClass, collisionAlgorithmConfig.Value.TickEnabled);
	}

	// Token: 0x06002E8B RID: 11915 RVA: 0x00110D60 File Offset: 0x0010EF60
	protected virtual KscCollisionAlgorithmConfig? GetCollisionAlgorithmConfig()
	{
		return new KscCollisionAlgorithmConfig?(new KscCollisionAlgorithmConfig
		{
			AlgorithmClass = UKuroFastCollisionAlgorithm_Grid.StaticClass().ToWeakClass(),
			TickEnabled = true
		});
	}

	// Token: 0x06002E8C RID: 11916 RVA: 0x00110D9C File Offset: 0x0010EF9C
	protected virtual void InitBulletWorld()
	{
		UKSC_World kscWorld = KscEnv.Instance.KscWorld;
		if (kscWorld != null)
		{
			kscWorld.SetKFCAlgorithm(this.Model.KfcAlgorithm);
		}
		BulletModel.Instance.StartKuroBulletWorld(this.Model.KfcAlgorithm, false);
		BulletModel.Instance.StartKscBullet();
	}

	// Token: 0x06002E8D RID: 11917 RVA: 0x00110DE9 File Offset: 0x0010EFE9
	protected virtual void ClearBulletWorld()
	{
		BulletModel.Instance.StopKuroBulletWorld();
		BulletModel.Instance.StopKscBullet();
	}

	// Token: 0x06002E8E RID: 11918 RVA: 0x00110DFF File Offset: 0x0010EFFF
	private void StartEngine()
	{
		this.RegisterCollisionAlgorithm();
		KscEnv.Instance.Start(this.GetKscWorldClass());
		KuroSimpleCombatController.Instance.StartKscHeadStateManager();
	}

	// Token: 0x06002E8F RID: 11919 RVA: 0x00110E21 File Offset: 0x0010F021
	private void StopEngine()
	{
		this.UnregisterCollisionAlgorithm();
		KuroSimpleCombatController.Instance.StopKscHeadStateManager();
		KscEnv.Instance.Stop();
	}

	// Token: 0x06002E90 RID: 11920 RVA: 0x00110E3D File Offset: 0x0010F03D
	public virtual void OnEntityRemoved(KscRemoveContext context, Dictionary<long, SimpleCombatEntityDieContext> protoContexts)
	{
	}

	// Token: 0x06002E91 RID: 11921 RVA: 0x00110E3F File Offset: 0x0010F03F
	protected virtual void InitConstVar()
	{
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "ksc.damage.defense.const 1520.0", null);
	}

	// Token: 0x06002E92 RID: 11922 RVA: 0x00110E54 File Offset: 0x0010F054
	public virtual void InitPropertyConfigs()
	{
		if (this.Model == null)
		{
			return;
		}
		IReadOnlyList<KSCBaseProperty> configList = ConfigKSCBasePropertyByKscGameplayType.GetConfigList((int)this.Model.GameplayType, true);
		if (configList != null)
		{
			foreach (KSCBaseProperty value in configList)
			{
				this.Model.PropertyConfigs[value.Id] = value;
			}
		}
	}

	// Token: 0x06002E93 RID: 11923 RVA: 0x00110ECC File Offset: 0x0010F0CC
	public unsafe virtual void SetAttrs(AKSC_Entity entity, int propertyId, [Nullable(2)] Dictionary<int, int> attributeMap = null)
	{
		if (propertyId == 0)
		{
			return;
		}
		if (entity == null)
		{
			KscLog.EModule flag = KscLog.EModule.Attr;
			ELogAuthor author = ELogAuthor.CFT;
			UObject kscWorld = KscEnv.Instance.KscWorld;
			string log = "塔防属性设置失败:异常Entity";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("propertyId", propertyId);
			KscLog.Warn(flag, author, kscWorld, log, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		Dictionary<EKSC_AttrType, float> attrsDefault = this.GetAttrsDefault(propertyId);
		if (attrsDefault == null || attrsDefault.Count <= 0)
		{
			KscLog.EModule flag2 = KscLog.EModule.Attr;
			ELogAuthor author2 = ELogAuthor.CFT;
			UObject kscWorld2 = KscEnv.Instance.KscWorld;
			string log2 = "塔防属性设置失败:异常配置";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("entityId", entity.EntityId_);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("propertyId", propertyId);
			KscLog.Warn(flag2, author2, kscWorld2, log2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		if (attributeMap != null)
		{
			using (Dictionary<EKSC_AttrType, float>.Enumerator enumerator = attrsDefault.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<EKSC_AttrType, float> keyValuePair = enumerator.Current;
					int key = (int)keyValuePair.Key;
					float value = keyValuePair.Value;
					int num2;
					float num = attributeMap.TryGetValue(key, out num2) ? ((float)num2) : value;
					if (key == 3)
					{
						int num4;
						float num5;
						float num3 = attributeMap.TryGetValue(2, out num4) ? ((float)num4) : (attrsDefault.TryGetValue(EKSC_AttrType.LifeMax, out num5) ? num5 : 0f);
						if (num3 > 0f && num3 < num)
						{
							entity.SetAttr((EKSC_AttrType)key, (int)num3);
							continue;
						}
					}
					entity.SetAttr((EKSC_AttrType)key, (int)num);
				}
				return;
			}
		}
		foreach (KeyValuePair<EKSC_AttrType, float> keyValuePair2 in attrsDefault)
		{
			entity.SetAttr(keyValuePair2.Key, (int)keyValuePair2.Value);
		}
	}

	// Token: 0x06002E94 RID: 11924 RVA: 0x0011109C File Offset: 0x0010F29C
	public virtual Dictionary<EKSC_AttrType, float> GetAttrsDefault(int propertyId)
	{
		KSCBaseProperty config;
		if (this.Model.PropertyConfigs.TryGetValue(propertyId, out config))
		{
			return KscUtil.GetAttrsDataByPropertyConfig(config);
		}
		return new Dictionary<EKSC_AttrType, float>();
	}

	// Token: 0x06002E95 RID: 11925 RVA: 0x001110CC File Offset: 0x0010F2CC
	public virtual void InitDamageConfigs()
	{
		UKSC_World kscWorld = KscEnv.Instance.KscWorld;
		if (kscWorld == null)
		{
			KscLog.Error(KscLog.EModule.Load, ELogAuthor.TZQ, KscEnv.Instance.KscWorld, "塔防InitDamageIdConfig failed", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		UKSC_DamageId damageData = kscWorld.DamageData;
		if (damageData == null || !damageData.IsValid())
		{
			KscLog.Error(KscLog.EModule.Load, ELogAuthor.TZQ, KscEnv.Instance.KscWorld, "塔防InitDamageIdConfig failed", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		Dictionary<int, FKSCDamage> damageIds = this.Model.DamageIds;
		IReadOnlyList<KSCDamage> configList = ConfigKSCDamageByKscGameplayType.GetConfigList((int)this.Model.GameplayType, true);
		if (configList != null)
		{
			foreach (KSCDamage kscdamage in configList)
			{
				int num = (int)kscdamage.Id;
				FKSCDamage fkscdamage = new FKSCDamage();
				fkscdamage.DamageID = num;
				fkscdamage.CalculateType = (EKSC_CalculateType)kscdamage.CalculateType;
				fkscdamage.Element = (EKSC_Element)kscdamage.Element;
				fkscdamage.Amplify = (float)kscdamage.Amplify * 0.0001f;
				fkscdamage.RelatedProperty = (EKSC_AttrType)kscdamage.RelatedProperty;
				fkscdamage.CritAttrType = (EKSC_AttrType)kscdamage.CritAttrType;
				fkscdamage.Knocked = kscdamage.Knocked;
				damageIds[num] = fkscdamage;
				damageData.AddDamageData(num, fkscdamage);
			}
		}
	}

	// Token: 0x06002E96 RID: 11926 RVA: 0x00111230 File Offset: 0x0010F430
	protected virtual void InitEntityAndSkillDt()
	{
		KscUtil.LoadDt<FKSCEntityTableRow>(KscEnv.Instance.KscWorld, this.Model.GetEntityDtPath(), this.Model.EntityDataDt);
		KscUtil.LoadDt<FKSCSkillTableRow>(KscEnv.Instance.KscWorld, this.Model.GetSkillDtPath(), this.Model.SkillDataDt);
	}

	// Token: 0x06002E97 RID: 11927 RVA: 0x00111287 File Offset: 0x0010F487
	protected void InitEntityFilter()
	{
		this.CreateEntityFilter();
		CreatureController.Instance.RegisterCreateEntityFilter(this.RedirectFilter);
	}

	// Token: 0x06002E98 RID: 11928 RVA: 0x0011129F File Offset: 0x0010F49F
	protected virtual void CreateEntityFilter()
	{
		this.RedirectFilter = new KscEntityRedirectFilter();
	}

	// Token: 0x06002E99 RID: 11929 RVA: 0x001112AC File Offset: 0x0010F4AC
	protected void ResetEntityFilter()
	{
		this.RedirectFilter.Reset();
		CreatureController.Instance.UnregisterCreateEntityFilter(this.RedirectFilter);
	}

	// Token: 0x06002E9A RID: 11930 RVA: 0x001112CC File Offset: 0x0010F4CC
	protected virtual void AddKscPlayerEntity()
	{
		KscSubControllerBase.<>c__DisplayClass50_0 CS$<>8__locals1 = new KscSubControllerBase.<>c__DisplayClass50_0();
		CS$<>8__locals1.<>4__this = this;
		if (KscEnv.Instance.KscWorld == null)
		{
			KscLog.Warn(KscLog.EModule.Common, ELogAuthor.CFT, KscEnv.Instance.KscWorld, "Ksc尝试添加玩家角色,世界非法", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		KscSubControllerBase.<>c__DisplayClass50_0 CS$<>8__locals2 = CS$<>8__locals1;
		SceneTeamModel instance = SceneTeamModel.Instance;
		CS$<>8__locals2.entityHandle = ((instance != null) ? instance.GetCurrentEntity : null);
		EntityHandle entityHandle = CS$<>8__locals1.entityHandle;
		if (entityHandle == null || !entityHandle.Valid)
		{
			KscLog.Warn(KscLog.EModule.Common, ELogAuthor.CFT, KscEnv.Instance.KscWorld, "Ksc尝试添加玩家角色,entity非法", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		KscLog.EModule flag = KscLog.EModule.Common;
		ELogAuthor author = ELogAuthor.CFT;
		UObject kscWorld = KscEnv.Instance.KscWorld;
		string log = "Ksc尝试添加玩家角色";
		string item = "Player";
		EntityHandle entityHandle2 = CS$<>8__locals1.entityHandle;
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (entityHandle2 != null) ? new int?(entityHandle2.Id) : null);
		KscLog.Info(flag, author, kscWorld, log, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		FTransformDouble actorTransform = CS$<>8__locals1.entityHandle.Entity.GetComponent<CharacterActorComponent>().ActorTransform;
		KuroSimpleCombatController.Instance.AddEntityDt(CS$<>8__locals1.entityHandle.CreatureDataId, 1001, null, actorTransform, delegate(AKSC_Entity kscEntity)
		{
			CS$<>8__locals1.<>4__this.FinishPlayerEntityCreated(kscEntity, CS$<>8__locals1.entityHandle.CreatureDataId);
		});
	}

	// Token: 0x06002E9B RID: 11931 RVA: 0x001113F8 File Offset: 0x0010F5F8
	private void FinishPlayerEntityCreated(AKSC_Entity kscEntity, long creatureDataId)
	{
		this.Model.SetKscPlayerEntity(kscEntity, creatureDataId);
		this.OnPlayerEntityCreated();
		this.AddInputLayer();
		EventSystem.Instance.Emit(EEventName.OnKscPlayerCreate);
	}

	// Token: 0x06002E9C RID: 11932 RVA: 0x00111424 File Offset: 0x0010F624
	private unsafe bool TryAddGmPlayerEntityByConfig(EntityHandle entityHandle, IKscGmPlayerEntityParam param)
	{
		SimpleCombatDetailConfig? config = ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId.GetConfig(param.SimpleCombatId, param.SubTypeId, true);
		if (config == null)
		{
			KscLog.EModule flag = KscLog.EModule.Common;
			ELogAuthor author = ELogAuthor.CFT;
			UObject kscWorld = KscEnv.Instance.KscWorld;
			string log = "Ksc添加玩家角色失败,SimpleCombatDetailConfig不存在";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("SimpleCombatId", param.SimpleCombatId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SubTypeId", param.SubTypeId);
			KscLog.Warn(flag, author, kscWorld, log, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		string daPath = config.Value.DaPath;
		if (string.IsNullOrEmpty(daPath))
		{
			KscLog.EModule flag2 = KscLog.EModule.Common;
			ELogAuthor author2 = ELogAuthor.CFT;
			UObject kscWorld2 = KscEnv.Instance.KscWorld;
			string log2 = "Ksc添加玩家角色失败,配置DaPath非法";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("SimpleCombatId", param.SimpleCombatId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("SubTypeId", param.SubTypeId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("PrefabPath", config.Value.PrefabPath);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("DaPath", daPath);
			KscLog.Warn(flag2, author2, kscWorld2, log2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
			return false;
		}
		KscLog.EModule flag3 = KscLog.EModule.Common;
		ELogAuthor author3 = ELogAuthor.CFT;
		UObject kscWorld3 = KscEnv.Instance.KscWorld;
		string log3 = "Ksc添加玩家角色使用SimpleCombatDetailConfig";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("SimpleCombatId", param.SimpleCombatId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("SubTypeId", param.SubTypeId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("PropertyId", config.Value.PropertyId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("DaPath", daPath);
		KscLog.Info(flag3, author3, kscWorld3, log3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 4));
		FTransformDouble actorTransform = entityHandle.Entity.GetComponent<CharacterActorComponent>().ActorTransform;
		KuroSimpleCombatController.Instance.AsyncAddEntity(new KscEntityParam
		{
			CreatureId = entityHandle.CreatureDataId,
			SimpleCombatId = param.SimpleCombatId,
			AssetPath = daPath,
			PropertyId = config.Value.PropertyId,
			Transform = actorTransform,
			FinishCallback = delegate(AKSC_Entity kscEntity)
			{
				this.FinishPlayerEntityCreated(kscEntity, entityHandle.CreatureDataId);
			}
		});
		return true;
	}

	// Token: 0x06002E9D RID: 11933 RVA: 0x001116BE File Offset: 0x0010F8BE
	public virtual void OnPlayerEntityCreated()
	{
		this.SyncPlayerTransform();
		this.ApplyPlayerTurnRate();
	}

	// Token: 0x06002E9E RID: 11934 RVA: 0x001116CC File Offset: 0x0010F8CC
	protected virtual bool AddInputLayer()
	{
		return false;
	}

	// Token: 0x06002E9F RID: 11935 RVA: 0x001116CF File Offset: 0x0010F8CF
	protected virtual bool RemoveInputLayer()
	{
		return false;
	}

	// Token: 0x06002EA0 RID: 11936 RVA: 0x001116D2 File Offset: 0x0010F8D2
	protected virtual void SyncPlayerTransform()
	{
		KscEntityHandle possessedPlayer = this.GetPossessedPlayer();
		if (possessedPlayer == null)
		{
			return;
		}
		possessedPlayer.SyncEntityLocation();
	}

	// Token: 0x06002EA1 RID: 11937 RVA: 0x001116E4 File Offset: 0x0010F8E4
	protected virtual void SyncPlayerTimeScale()
	{
		if (!this.EnableSyncEntityTimeScaleToPlayer)
		{
			return;
		}
		KscSubModelBase model = this.Model;
		AKSC_Entity aksc_Entity = (model != null) ? model.KscPlayerEntity : null;
		if (aksc_Entity == null || !aksc_Entity.IsValid())
		{
			return;
		}
		float timeScale = aksc_Entity.GetTimeScale();
		if (MathUtils.Instance.IsNearlyEqual((double)timeScale, (double)this.LastKscEntitySyncTimeScale, null))
		{
			return;
		}
		EntityHandle possessedPlayerEntity = this.GetPossessedPlayerEntity();
		if (((possessedPlayerEntity != null) ? possessedPlayerEntity.Entity : null) == null)
		{
			return;
		}
		PawnTimeScaleComponent component = possessedPlayerEntity.Entity.GetComponent<PawnTimeScaleComponent>();
		if (component == null)
		{
			return;
		}
		this.ApplyKscTimeScaleToTs(component, timeScale);
		this.LastKscEntitySyncTimeScale = timeScale;
	}

	// Token: 0x06002EA2 RID: 11938 RVA: 0x0011177C File Offset: 0x0010F97C
	private void ApplyKscTimeScaleToTs(PawnTimeScaleComponent tsComp, float newScale)
	{
		if (newScale < 1f)
		{
			if (this.KscEntitySyncTimeScaleId != null)
			{
				tsComp.RemoveForeverTimeScale(this.KscEntitySyncTimeScaleId.Value, false);
			}
			this.KscEntitySyncTimeScaleId = new int?(tsComp.SetForeverTimeScale(ETimeScaleSourceType.WithKscEntityUpdate, newScale, 100, false));
			return;
		}
		if (this.KscEntitySyncTimeScaleId != null)
		{
			tsComp.RemoveForeverTimeScale(this.KscEntitySyncTimeScaleId.Value, false);
			this.KscEntitySyncTimeScaleId = null;
		}
	}

	// Token: 0x06002EA3 RID: 11939 RVA: 0x001117F4 File Offset: 0x0010F9F4
	private void ApplyPlayerTurnRate()
	{
		KscSubModelBase model = this.Model;
		object obj;
		if (model == null)
		{
			obj = null;
		}
		else
		{
			AKSC_Entity kscPlayerEntity = model.KscPlayerEntity;
			obj = ((kscPlayerEntity != null) ? kscPlayerEntity.DaEntity_ : null);
		}
		UKSC_DA_Entity_Player uksc_DA_Entity_Player = obj as UKSC_DA_Entity_Player;
		if (uksc_DA_Entity_Player == null)
		{
			return;
		}
		float turnRateScale = uksc_DA_Entity_Player.TurnRateScale;
		if (!float.IsFinite(turnRateScale) || turnRateScale <= 0f)
		{
			KscLog.EModule flag = KscLog.EModule.Common;
			ELogAuthor author = ELogAuthor.HCW;
			UObject obj2 = null;
			string log = "ApplyPlayerTurnRate: TurnRateScale非法";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("turnRate", turnRateScale);
			KscLog.Error(flag, author, obj2, log, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (MathUtils.Instance.IsNearlyEqual(1.0, (double)turnRateScale, null))
		{
			return;
		}
		SceneTeamModel instance = SceneTeamModel.Instance;
		EntityHandle entityHandle = (instance != null) ? instance.GetCurrentEntity : null;
		BaseMoveComponent baseMoveComponent;
		if (entityHandle == null)
		{
			baseMoveComponent = null;
		}
		else
		{
			WorldEntity entity = entityHandle.Entity;
			baseMoveComponent = ((entity != null) ? entity.GetComponent<BaseMoveComponent>() : null);
		}
		BaseMoveComponent baseMoveComponent2 = baseMoveComponent;
		if (baseMoveComponent2 == null)
		{
			KscLog.Error(KscLog.EModule.Common, ELogAuthor.HCW, null, "ApplyPlayerTurnRate: 获取MoveComp失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		baseMoveComponent2.SetTurnRate(turnRateScale);
	}

	// Token: 0x06002EA4 RID: 11940 RVA: 0x001118D7 File Offset: 0x0010FAD7
	private void ResetPlayerTurnRate()
	{
		SceneTeamModel instance = SceneTeamModel.Instance;
		EntityHandle entityHandle = (instance != null) ? instance.GetCurrentEntity : null;
		object obj;
		if (entityHandle == null)
		{
			obj = null;
		}
		else
		{
			WorldEntity entity = entityHandle.Entity;
			obj = ((entity != null) ? entity.GetComponent<BaseMoveComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 == null)
		{
			return;
		}
		obj2.ResetTurnRate();
	}

	// Token: 0x06002EA5 RID: 11941 RVA: 0x0011190C File Offset: 0x0010FB0C
	[NullableContext(2)]
	private KscEntityHandle GetPossessedPlayer()
	{
		KscSubModelBase model = this.Model;
		AKSC_Entity aksc_Entity = (model != null) ? model.KscPlayerEntity : null;
		if (aksc_Entity == null)
		{
			return null;
		}
		KscSubModelBase model2 = this.Model;
		KscEntityHandle result;
		if (model2 == null || !model2.KscEntities.TryGetValue(aksc_Entity.EntityId_, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x06002EA6 RID: 11942 RVA: 0x00111958 File Offset: 0x0010FB58
	[NullableContext(2)]
	protected virtual EntityHandle GetPossessedPlayerEntity()
	{
		KscEntityHandle possessedPlayer = this.GetPossessedPlayer();
		long? num = (possessedPlayer != null) ? new long?(possessedPlayer.CreatureDataId) : null;
		if (num != null && num.GetValueOrDefault() != 0L && possessedPlayer.Valid)
		{
			return CreatureModel.Instance.GetEntity(num.Value);
		}
		return null;
	}

	// Token: 0x06002EA7 RID: 11943 RVA: 0x001119B4 File Offset: 0x0010FBB4
	protected UniTask PreloadHeadStateRes()
	{
		KscSubControllerBase.<PreloadHeadStateRes>d__67 <PreloadHeadStateRes>d__;
		<PreloadHeadStateRes>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PreloadHeadStateRes>d__.<>4__this = this;
		<PreloadHeadStateRes>d__.<>1__state = -1;
		<PreloadHeadStateRes>d__.<>t__builder.Start<KscSubControllerBase.<PreloadHeadStateRes>d__67>(ref <PreloadHeadStateRes>d__);
		return <PreloadHeadStateRes>d__.<>t__builder.Task;
	}

	// Token: 0x06002EA8 RID: 11944 RVA: 0x001119F8 File Offset: 0x0010FBF8
	protected virtual UniTask LoadHeadStateCurve()
	{
		KscSubControllerBase.<LoadHeadStateCurve>d__68 <LoadHeadStateCurve>d__;
		<LoadHeadStateCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadHeadStateCurve>d__.<>4__this = this;
		<LoadHeadStateCurve>d__.<>1__state = -1;
		<LoadHeadStateCurve>d__.<>t__builder.Start<KscSubControllerBase.<LoadHeadStateCurve>d__68>(ref <LoadHeadStateCurve>d__);
		return <LoadHeadStateCurve>d__.<>t__builder.Task;
	}

	// Token: 0x06002EA9 RID: 11945 RVA: 0x00111A3C File Offset: 0x0010FC3C
	protected virtual UniTask LoadHeadStateDynamicBatchActor()
	{
		KscSubControllerBase.<LoadHeadStateDynamicBatchActor>d__69 <LoadHeadStateDynamicBatchActor>d__;
		<LoadHeadStateDynamicBatchActor>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadHeadStateDynamicBatchActor>d__.<>4__this = this;
		<LoadHeadStateDynamicBatchActor>d__.<>1__state = -1;
		<LoadHeadStateDynamicBatchActor>d__.<>t__builder.Start<KscSubControllerBase.<LoadHeadStateDynamicBatchActor>d__69>(ref <LoadHeadStateDynamicBatchActor>d__);
		return <LoadHeadStateDynamicBatchActor>d__.<>t__builder.Task;
	}

	// Token: 0x06002EAA RID: 11946 RVA: 0x00111A80 File Offset: 0x0010FC80
	protected virtual UniTask LoadHeadStateViewActor()
	{
		KscSubControllerBase.<LoadHeadStateViewActor>d__70 <LoadHeadStateViewActor>d__;
		<LoadHeadStateViewActor>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadHeadStateViewActor>d__.<>4__this = this;
		<LoadHeadStateViewActor>d__.<>1__state = -1;
		<LoadHeadStateViewActor>d__.<>t__builder.Start<KscSubControllerBase.<LoadHeadStateViewActor>d__70>(ref <LoadHeadStateViewActor>d__);
		return <LoadHeadStateViewActor>d__.<>t__builder.Task;
	}

	// Token: 0x06002EAB RID: 11947 RVA: 0x00111AC4 File Offset: 0x0010FCC4
	protected void InitHeadStateManagerRes()
	{
		if (this.HeadStateScaleCurve != null && this.HeadStateViewActor != null && this.HeadStateDynamicBatchActor != null)
		{
			UKSC_HeadStateManager kscHeadStateManager = KuroSimpleCombatController.Instance.KscHeadStateManager;
			if (kscHeadStateManager == null)
			{
				return;
			}
			kscHeadStateManager.InitAllRes(UiLayer.Instance.WorldSpaceUiRootItem, this.HeadStateDynamicBatchActor, this.HeadStateViewActor, this.HeadStateScaleCurve);
		}
	}

	// Token: 0x06002EAC RID: 11948 RVA: 0x00111B1C File Offset: 0x0010FD1C
	protected void HandleHeadHpInfos(float delta)
	{
		if (KuroSimpleCombatController.Instance.KscHeadStateManager != null)
		{
			global::Vector cameraLocation = CameraController.Instance.MainModel.CameraLocation;
			UKSC_HeadStateManager kscHeadStateManager = KuroSimpleCombatController.Instance.KscHeadStateManager;
			float num = delta * (float)TimeUtil.Instance.Millisecond;
			FVectorDouble fvectorDouble = cameraLocation.ToUeVector(false);
			kscHeadStateManager.Update(num, fvectorDouble);
		}
		UKSC_World kscWorld = KscEnv.Instance.KscWorld;
		if (kscWorld == null)
		{
			return;
		}
		kscWorld.GetHeadHpInfos(ref this.HeadInfos);
		int num2 = this.HeadInfos.Num();
		KscSubModelBase model = this.Model;
		KscHeadStateData kscHeadStateData = (model != null) ? model.KscPlayerHeadStateData : null;
		if (kscHeadStateData == null)
		{
			for (int i = 0; i < num2; i++)
			{
				FKSC_HeadHpContext headInfo = this.HeadInfos.Get(i);
				this.OnHandleHeadHpInfo(headInfo);
			}
			return;
		}
		for (int j = 0; j < num2; j++)
		{
			FKSC_HeadHpContext fksc_HeadHpContext = this.HeadInfos.Get(j);
			if (fksc_HeadHpContext.EntityId == kscHeadStateData.EntityId)
			{
				this.SubModel.IsHpModify = true;
				this.OnHandlePlayerHeadHpInfo(kscHeadStateData, fksc_HeadHpContext);
			}
			else
			{
				this.OnHandleHeadHpInfo(fksc_HeadHpContext);
			}
		}
	}

	// Token: 0x06002EAD RID: 11949 RVA: 0x00111C24 File Offset: 0x0010FE24
	protected virtual void PushPlayerHp()
	{
		KscSubModelBase model = this.Model;
		if (model == null || !model.IsHpModify)
		{
			return;
		}
		if ((double)this.Model.NextPlayerHpSyncTime > Time.Instance.FlowTime)
		{
			return;
		}
		if (this.Model.KscPlayerCreatureDataId == 0L)
		{
			return;
		}
		KuroSimpleCombatController.Instance.PushSimpleCombatEntityHp(this.Model.KscPlayerCreatureDataId, (float)this.Model.KscPlayerHeadStateData.Hp, (float)this.Model.KscPlayerHeadStateData.MaxHp);
		this.SubModel.IsHpModify = false;
		this.Model.NextPlayerHpSyncTime = (float)Time.Instance.FlowTime + 1000f;
	}

	// Token: 0x06002EAE RID: 11950 RVA: 0x00111CD0 File Offset: 0x0010FED0
	protected virtual void OnHandlePlayerHeadHpInfo(KscHeadStateData kscPlayerHeadStateData, FKSC_HeadHpContext headInfo)
	{
		if (headInfo.ActionType == EKSC_HeadHpContextType.Add || headInfo.ActionType == EKSC_HeadHpContextType.Update)
		{
			kscPlayerHeadStateData.MaxHp = headInfo.MaxHp;
			kscPlayerHeadStateData.Hp = headInfo.CurHp;
			kscPlayerHeadStateData.Shield = headInfo.Shield;
		}
		EventSystem.Instance.Emit(EEventName.OnKscPlayerHpChanged);
	}

	// Token: 0x06002EAF RID: 11951 RVA: 0x00111D24 File Offset: 0x0010FF24
	protected virtual void OnHandleHeadHpInfo(FKSC_HeadHpContext headInfo)
	{
		KscLog.Warn(KscLog.EModule.Common, ELogAuthor.CFT, KscEnv.Instance.KscWorld, "推送的血条数据没有处理", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06002EB0 RID: 11952 RVA: 0x00111D54 File Offset: 0x0010FF54
	protected void ClearHeadState()
	{
		this.HeadStateScaleCurve = null;
		AUIBaseActor headStateDynamicBatchActor = this.HeadStateDynamicBatchActor;
		if (headStateDynamicBatchActor != null && headStateDynamicBatchActor.IsValid())
		{
			ActorSystem.Instance.Put("Ksc.ClearHeadState", this.HeadStateDynamicBatchActor, null);
			this.HeadStateDynamicBatchActor = null;
		}
		AUIBaseActor headStateViewActor = this.HeadStateViewActor;
		if (headStateViewActor != null && headStateViewActor.IsValid())
		{
			ActorSystem.Instance.Put("Ksc.ClearHeadState", this.HeadStateViewActor, null);
			this.HeadStateViewActor = null;
		}
		this.HeadInfos.Empty(true);
	}

	// Token: 0x06002EB1 RID: 11953 RVA: 0x00111DD8 File Offset: 0x0010FFD8
	public unsafe void GmAddPlayerEntity(IKscGmPlayerEntityParam param)
	{
		if (param.SimpleCombatId < 0 || param.SubTypeId < 0)
		{
			KscLog.EModule flag = KscLog.EModule.Common;
			ELogAuthor author = ELogAuthor.CFT;
			UObject kscWorld = KscEnv.Instance.KscWorld;
			string log = "Ksc尝试添加玩家角色,参数非法";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("SimpleCombatId", param.SimpleCombatId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SubTypeId", param.SubTypeId);
			KscLog.Warn(flag, author, kscWorld, log, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		if (KscEnv.Instance.KscWorld == null)
		{
			KscLog.EModule flag2 = KscLog.EModule.Common;
			ELogAuthor author2 = ELogAuthor.CFT;
			UObject kscWorld2 = KscEnv.Instance.KscWorld;
			string log2 = "Ksc尝试添加玩家角色,世界非法";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("SimpleCombatId", param.SimpleCombatId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("SubTypeId", param.SubTypeId);
			KscLog.Warn(flag2, author2, kscWorld2, log2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return;
		}
		SceneTeamModel instance = SceneTeamModel.Instance;
		EntityHandle entityHandle = (instance != null) ? instance.GetCurrentEntity : null;
		if (entityHandle == null || !entityHandle.Valid)
		{
			KscLog.EModule flag3 = KscLog.EModule.Common;
			ELogAuthor author3 = ELogAuthor.CFT;
			UObject kscWorld3 = KscEnv.Instance.KscWorld;
			string log3 = "Ksc尝试添加玩家角色,entity非法";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("SimpleCombatId", param.SimpleCombatId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("SubTypeId", param.SubTypeId);
			KscLog.Warn(flag3, author3, kscWorld3, log3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
			return;
		}
		KscLog.EModule flag4 = KscLog.EModule.Common;
		ELogAuthor author4 = ELogAuthor.CFT;
		UObject kscWorld4 = KscEnv.Instance.KscWorld;
		string log4 = "Ksc尝试添加玩家角色";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("Player", (entityHandle != null) ? new int?(entityHandle.Id) : null);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("SimpleCombatId", param.SimpleCombatId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("SubTypeId", param.SubTypeId);
		KscLog.Info(flag4, author4, kscWorld4, log4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 3));
		this.TryAddGmPlayerEntityByConfig(entityHandle, param);
	}

	// Token: 0x06002EB2 RID: 11954 RVA: 0x00112014 File Offset: 0x00110214
	public virtual void GmPrintInfo()
	{
	}

	// Token: 0x04002A22 RID: 10786
	private float LastTimeDilation = 1f;

	// Token: 0x04002A23 RID: 10787
	[Nullable(2)]
	protected KscSubModelBase SubModel;

	// Token: 0x04002A24 RID: 10788
	protected bool EnableSyncEntityTimeScaleToPlayer;

	// Token: 0x04002A25 RID: 10789
	private int? KscEntitySyncTimeScaleId;

	// Token: 0x04002A26 RID: 10790
	private float LastKscEntitySyncTimeScale = 1f;

	// Token: 0x04002A27 RID: 10791
	[Nullable(2)]
	public KscEntityRedirectFilter RedirectFilter;

	// Token: 0x04002A28 RID: 10792
	protected TArray<FKSC_HeadHpContext> HeadInfos = new TArray<FKSC_HeadHpContext>();

	// Token: 0x04002A29 RID: 10793
	[Nullable(2)]
	protected UCurveFloat HeadStateScaleCurve;

	// Token: 0x04002A2A RID: 10794
	[Nullable(2)]
	protected AUIBaseActor HeadStateDynamicBatchActor;

	// Token: 0x04002A2B RID: 10795
	[Nullable(2)]
	protected AUIBaseActor HeadStateViewActor;
}
