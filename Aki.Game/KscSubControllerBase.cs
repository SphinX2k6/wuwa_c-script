using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.KuroSimpleCombat;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x02000E88 RID: 3720
[NullableContext(1)]
[Nullable(0)]
public class KscSubControllerBase
{
	// Token: 0x170006A7 RID: 1703
	// (get) Token: 0x06005AD8 RID: 23256 RVA: 0x00108D74 File Offset: 0x00106F74
	[Nullable(2)]
	public KscSubModelBase Model
	{
		[NullableContext(2)]
		get
		{
			return this.SubModel;
		}
	}

	// Token: 0x06005AD9 RID: 23257 RVA: 0x00108D7C File Offset: 0x00106F7C
	public void Init(EKscGameplayType kscGameplayType)
	{
		this.CreateModel();
		this.Model.KscGameplayType = kscGameplayType;
		this.OnInit();
	}

	// Token: 0x06005ADA RID: 23258 RVA: 0x00108D96 File Offset: 0x00106F96
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

	// Token: 0x06005ADB RID: 23259 RVA: 0x00108DD4 File Offset: 0x00106FD4
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

	// Token: 0x06005ADC RID: 23260 RVA: 0x00108E30 File Offset: 0x00107030
	public virtual UniTask PreloadAsync()
	{
		KscSubControllerBase.<PreloadAsync>d__11 <PreloadAsync>d__;
		<PreloadAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PreloadAsync>d__.<>4__this = this;
		<PreloadAsync>d__.<>1__state = -1;
		<PreloadAsync>d__.<>t__builder.Start<KscSubControllerBase.<PreloadAsync>d__11>(ref <PreloadAsync>d__);
		return <PreloadAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005ADD RID: 23261 RVA: 0x00108E73 File Offset: 0x00107073
	public void MapLoaded()
	{
		this.Model.KscInitState = EKscInitState.MapLoad;
		this.StartEngine();
		this.LastTimeDilation = 1f;
		this.InitDamageConfigs();
		this.OnMapLoaded();
	}

	// Token: 0x06005ADE RID: 23262 RVA: 0x00108E9E File Offset: 0x0010709E
	public void WorldDone()
	{
		this.Model.KscInitState = EKscInitState.WorldDone;
		this.OnWorldDone();
		this.InitHeadStateManagerRes();
		this.AddKscPlayerEntity();
	}

	// Token: 0x06005ADF RID: 23263 RVA: 0x00108EC0 File Offset: 0x001070C0
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

	// Token: 0x06005AE0 RID: 23264 RVA: 0x00108F46 File Offset: 0x00107146
	public void ClearMap()
	{
		this.RemoveEvents();
		this.ResetEntityFilter();
		this.OnClearMap();
		this.ClearHeadState();
		this.Model.Clear();
	}

	// Token: 0x06005AE1 RID: 23265 RVA: 0x00108F6C File Offset: 0x0010716C
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

	// Token: 0x06005AE2 RID: 23266 RVA: 0x00108FD6 File Offset: 0x001071D6
	public void Clear()
	{
		this.OnClear();
	}

	// Token: 0x06005AE3 RID: 23267 RVA: 0x00108FDE File Offset: 0x001071DE
	public virtual bool IsTargetMap(int instSubType)
	{
		return false;
	}

	// Token: 0x06005AE4 RID: 23268 RVA: 0x00108FE1 File Offset: 0x001071E1
	protected virtual void CreateModel()
	{
	}

	// Token: 0x06005AE5 RID: 23269 RVA: 0x00108FE3 File Offset: 0x001071E3
	protected virtual void ClearModel()
	{
	}

	// Token: 0x06005AE6 RID: 23270 RVA: 0x00108FE5 File Offset: 0x001071E5
	protected virtual void OnInit()
	{
	}

	// Token: 0x06005AE7 RID: 23271 RVA: 0x00108FE7 File Offset: 0x001071E7
	protected virtual void OnInitMap()
	{
	}

	// Token: 0x06005AE8 RID: 23272 RVA: 0x00108FE9 File Offset: 0x001071E9
	protected virtual void OnMapLoaded()
	{
	}

	// Token: 0x06005AE9 RID: 23273 RVA: 0x00108FEB File Offset: 0x001071EB
	protected virtual void OnWorldDone()
	{
	}

	// Token: 0x06005AEA RID: 23274 RVA: 0x00108FED File Offset: 0x001071ED
	protected virtual void OnWorldReset()
	{
	}

	// Token: 0x06005AEB RID: 23275 RVA: 0x00108FEF File Offset: 0x001071EF
	protected virtual void OnClearMap()
	{
	}

	// Token: 0x06005AEC RID: 23276 RVA: 0x00108FF1 File Offset: 0x001071F1
	protected virtual void OnTick(float delta)
	{
	}

	// Token: 0x06005AED RID: 23277 RVA: 0x00108FF3 File Offset: 0x001071F3
	protected virtual void OnClear()
	{
	}

	// Token: 0x06005AEE RID: 23278 RVA: 0x00108FF5 File Offset: 0x001071F5
	public virtual void OnSystemInfoNotify()
	{
	}

	// Token: 0x06005AEF RID: 23279 RVA: 0x00108FF7 File Offset: 0x001071F7
	protected virtual void AddEvents()
	{
	}

	// Token: 0x06005AF0 RID: 23280 RVA: 0x00108FF9 File Offset: 0x001071F9
	protected virtual void RemoveEvents()
	{
	}

	// Token: 0x06005AF1 RID: 23281 RVA: 0x00108FFB File Offset: 0x001071FB
	[NullableContext(2)]
	protected virtual UClass GetKscWorldClass()
	{
		return null;
	}

	// Token: 0x06005AF2 RID: 23282 RVA: 0x00109000 File Offset: 0x00107200
	protected virtual void UnregisterCollisionAlgorithm()
	{
		if (this.GetCollisionAlgorithmConfig() != null)
		{
			KuroFastCollisionController.Instance.DestroyAlgorithm(this.Model.KfcAlgorithm);
		}
	}

	// Token: 0x06005AF3 RID: 23283 RVA: 0x00109034 File Offset: 0x00107234
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

	// Token: 0x06005AF4 RID: 23284 RVA: 0x001090BC File Offset: 0x001072BC
	protected virtual KscCollisionAlgorithmConfig? GetCollisionAlgorithmConfig()
	{
		return new KscCollisionAlgorithmConfig?(new KscCollisionAlgorithmConfig
		{
			AlgorithmClass = UKuroFastCollisionAlgorithm_Grid.StaticClass().ToWeakClass(),
			TickEnabled = true
		});
	}

	// Token: 0x06005AF5 RID: 23285 RVA: 0x001090F8 File Offset: 0x001072F8
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

	// Token: 0x06005AF6 RID: 23286 RVA: 0x00109145 File Offset: 0x00107345
	protected virtual void ClearBulletWorld()
	{
		BulletModel.Instance.StopKuroBulletWorld();
		BulletModel.Instance.StopKscBullet();
	}

	// Token: 0x06005AF7 RID: 23287 RVA: 0x0010915B File Offset: 0x0010735B
	private void StartEngine()
	{
		this.RegisterCollisionAlgorithm();
		KscEnv.Instance.Start(this.GetKscWorldClass());
		KuroSimpleCombatController.Instance.StartKscHeadStateManager();
	}

	// Token: 0x06005AF8 RID: 23288 RVA: 0x0010917D File Offset: 0x0010737D
	private void StopEngine()
	{
		this.UnregisterCollisionAlgorithm();
		KuroSimpleCombatController.Instance.StopKscHeadStateManager();
		KscEnv.Instance.Stop();
	}

	// Token: 0x06005AF9 RID: 23289 RVA: 0x00109199 File Offset: 0x00107399
	public virtual void OnEntityRemoved(KscRemoveContext context, Dictionary<long, SimpleCombatEntityDieContext> protoContexts)
	{
	}

	// Token: 0x06005AFA RID: 23290 RVA: 0x0010919B File Offset: 0x0010739B
	protected virtual void InitConstVar()
	{
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "ksc.damage.defense.const 1520.0", null);
	}

	// Token: 0x06005AFB RID: 23291 RVA: 0x001091B0 File Offset: 0x001073B0
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

	// Token: 0x06005AFC RID: 23292 RVA: 0x00109228 File Offset: 0x00107428
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
		bool isBuildDevelopmentOrDebug = Info.Instance.IsBuildDevelopmentOrDebug;
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

	// Token: 0x06005AFD RID: 23293 RVA: 0x00109404 File Offset: 0x00107604
	public virtual Dictionary<EKSC_AttrType, float> GetAttrsDefault(int propertyId)
	{
		KSCBaseProperty config;
		if (this.Model.PropertyConfigs.TryGetValue(propertyId, out config))
		{
			return KscUtil.GetAttrsDataByPropertyConfig(config);
		}
		return new Dictionary<EKSC_AttrType, float>();
	}

	// Token: 0x06005AFE RID: 23294 RVA: 0x00109434 File Offset: 0x00107634
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

	// Token: 0x06005AFF RID: 23295 RVA: 0x00109598 File Offset: 0x00107798
	protected virtual void InitEntityAndSkillDt()
	{
		KscUtil.LoadDt<FKSCEntityTableRow>(KscEnv.Instance.KscWorld, this.Model.GetEntityDtPath(), this.Model.EntityDataDt);
		KscUtil.LoadDt<FKSCSkillTableRow>(KscEnv.Instance.KscWorld, this.Model.GetSkillDtPath(), this.Model.SkillDataDt);
	}

	// Token: 0x06005B00 RID: 23296 RVA: 0x001095EF File Offset: 0x001077EF
	protected void InitEntityFilter()
	{
		this.CreateEntityFilter();
		CreatureController.Instance.RegisterCreateEntityFilter(this.RedirectFilter);
	}

	// Token: 0x06005B01 RID: 23297 RVA: 0x00109607 File Offset: 0x00107807
	protected virtual void CreateEntityFilter()
	{
		this.RedirectFilter = new KscEntityRedirectFilter();
	}

	// Token: 0x06005B02 RID: 23298 RVA: 0x00109614 File Offset: 0x00107814
	protected void ResetEntityFilter()
	{
		this.RedirectFilter.Reset();
		CreatureController.Instance.UnregisterCreateEntityFilter(this.RedirectFilter);
	}

	// Token: 0x06005B03 RID: 23299 RVA: 0x00109634 File Offset: 0x00107834
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

	// Token: 0x06005B04 RID: 23300 RVA: 0x00109760 File Offset: 0x00107960
	private void FinishPlayerEntityCreated(AKSC_Entity kscEntity, long creatureDataId)
	{
		this.Model.SetKscPlayerEntity(kscEntity, creatureDataId);
		this.OnPlayerEntityCreated();
		this.AddInputLayer();
		EventSystem.Instance.Emit(EEventName.OnKscPlayerCreate);
	}

	// Token: 0x06005B05 RID: 23301 RVA: 0x0010978C File Offset: 0x0010798C
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

	// Token: 0x06005B06 RID: 23302 RVA: 0x00109A26 File Offset: 0x00107C26
	public virtual void OnPlayerEntityCreated()
	{
		this.SyncPlayerTransform();
		this.ApplyPlayerTurnRate();
	}

	// Token: 0x06005B07 RID: 23303 RVA: 0x00109A34 File Offset: 0x00107C34
	protected virtual bool AddInputLayer()
	{
		return false;
	}

	// Token: 0x06005B08 RID: 23304 RVA: 0x00109A37 File Offset: 0x00107C37
	protected virtual bool RemoveInputLayer()
	{
		return false;
	}

	// Token: 0x06005B09 RID: 23305 RVA: 0x00109A3A File Offset: 0x00107C3A
	protected virtual void SyncPlayerTransform()
	{
		KscEntityHandle possessedPlayer = this.GetPossessedPlayer();
		if (possessedPlayer == null)
		{
			return;
		}
		possessedPlayer.SyncEntityLocation();
	}

	// Token: 0x06005B0A RID: 23306 RVA: 0x00109A4C File Offset: 0x00107C4C
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

	// Token: 0x06005B0B RID: 23307 RVA: 0x00109AE4 File Offset: 0x00107CE4
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

	// Token: 0x06005B0C RID: 23308 RVA: 0x00109B5C File Offset: 0x00107D5C
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

	// Token: 0x06005B0D RID: 23309 RVA: 0x00109C3F File Offset: 0x00107E3F
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

	// Token: 0x06005B0E RID: 23310 RVA: 0x00109C74 File Offset: 0x00107E74
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

	// Token: 0x06005B0F RID: 23311 RVA: 0x00109CC0 File Offset: 0x00107EC0
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

	// Token: 0x06005B10 RID: 23312 RVA: 0x00109D1C File Offset: 0x00107F1C
	protected UniTask PreloadHeadStateRes()
	{
		KscSubControllerBase.<PreloadHeadStateRes>d__67 <PreloadHeadStateRes>d__;
		<PreloadHeadStateRes>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PreloadHeadStateRes>d__.<>4__this = this;
		<PreloadHeadStateRes>d__.<>1__state = -1;
		<PreloadHeadStateRes>d__.<>t__builder.Start<KscSubControllerBase.<PreloadHeadStateRes>d__67>(ref <PreloadHeadStateRes>d__);
		return <PreloadHeadStateRes>d__.<>t__builder.Task;
	}

	// Token: 0x06005B11 RID: 23313 RVA: 0x00109D60 File Offset: 0x00107F60
	protected virtual UniTask LoadHeadStateCurve()
	{
		KscSubControllerBase.<LoadHeadStateCurve>d__68 <LoadHeadStateCurve>d__;
		<LoadHeadStateCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadHeadStateCurve>d__.<>4__this = this;
		<LoadHeadStateCurve>d__.<>1__state = -1;
		<LoadHeadStateCurve>d__.<>t__builder.Start<KscSubControllerBase.<LoadHeadStateCurve>d__68>(ref <LoadHeadStateCurve>d__);
		return <LoadHeadStateCurve>d__.<>t__builder.Task;
	}

	// Token: 0x06005B12 RID: 23314 RVA: 0x00109DA4 File Offset: 0x00107FA4
	protected virtual UniTask LoadHeadStateDynamicBatchActor()
	{
		KscSubControllerBase.<LoadHeadStateDynamicBatchActor>d__69 <LoadHeadStateDynamicBatchActor>d__;
		<LoadHeadStateDynamicBatchActor>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadHeadStateDynamicBatchActor>d__.<>4__this = this;
		<LoadHeadStateDynamicBatchActor>d__.<>1__state = -1;
		<LoadHeadStateDynamicBatchActor>d__.<>t__builder.Start<KscSubControllerBase.<LoadHeadStateDynamicBatchActor>d__69>(ref <LoadHeadStateDynamicBatchActor>d__);
		return <LoadHeadStateDynamicBatchActor>d__.<>t__builder.Task;
	}

	// Token: 0x06005B13 RID: 23315 RVA: 0x00109DE8 File Offset: 0x00107FE8
	protected virtual UniTask LoadHeadStateViewActor()
	{
		KscSubControllerBase.<LoadHeadStateViewActor>d__70 <LoadHeadStateViewActor>d__;
		<LoadHeadStateViewActor>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadHeadStateViewActor>d__.<>4__this = this;
		<LoadHeadStateViewActor>d__.<>1__state = -1;
		<LoadHeadStateViewActor>d__.<>t__builder.Start<KscSubControllerBase.<LoadHeadStateViewActor>d__70>(ref <LoadHeadStateViewActor>d__);
		return <LoadHeadStateViewActor>d__.<>t__builder.Task;
	}

	// Token: 0x06005B14 RID: 23316 RVA: 0x00109E2C File Offset: 0x0010802C
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

	// Token: 0x06005B15 RID: 23317 RVA: 0x00109E84 File Offset: 0x00108084
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

	// Token: 0x06005B16 RID: 23318 RVA: 0x00109F8C File Offset: 0x0010818C
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

	// Token: 0x06005B17 RID: 23319 RVA: 0x0010A038 File Offset: 0x00108238
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

	// Token: 0x06005B18 RID: 23320 RVA: 0x0010A08C File Offset: 0x0010828C
	protected virtual void OnHandleHeadHpInfo(FKSC_HeadHpContext headInfo)
	{
		KscLog.Warn(KscLog.EModule.Common, ELogAuthor.CFT, KscEnv.Instance.KscWorld, "推送的血条数据没有处理", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06005B19 RID: 23321 RVA: 0x0010A0BC File Offset: 0x001082BC
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

	// Token: 0x06005B1A RID: 23322 RVA: 0x0010A140 File Offset: 0x00108340
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

	// Token: 0x06005B1B RID: 23323 RVA: 0x0010A37C File Offset: 0x0010857C
	public virtual void GmPrintInfo()
	{
	}

	// Token: 0x04002987 RID: 10631
	private float LastTimeDilation = 1f;

	// Token: 0x04002988 RID: 10632
	[Nullable(2)]
	protected KscSubModelBase SubModel;

	// Token: 0x04002989 RID: 10633
	protected bool EnableSyncEntityTimeScaleToPlayer;

	// Token: 0x0400298A RID: 10634
	private int? KscEntitySyncTimeScaleId;

	// Token: 0x0400298B RID: 10635
	private float LastKscEntitySyncTimeScale = 1f;

	// Token: 0x0400298C RID: 10636
	[Nullable(2)]
	public KscEntityRedirectFilter RedirectFilter;

	// Token: 0x0400298D RID: 10637
	protected TArray<FKSC_HeadHpContext> HeadInfos = new TArray<FKSC_HeadHpContext>();

	// Token: 0x0400298E RID: 10638
	[Nullable(2)]
	protected UCurveFloat HeadStateScaleCurve;

	// Token: 0x0400298F RID: 10639
	[Nullable(2)]
	protected AUIBaseActor HeadStateDynamicBatchActor;

	// Token: 0x04002990 RID: 10640
	[Nullable(2)]
	protected AUIBaseActor HeadStateViewActor;
}
