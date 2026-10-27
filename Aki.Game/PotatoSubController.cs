using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.KuroSimpleCombat;
using CSharpScript.Game.Module.Gamepad;
using CSharpScript.Game.Module.Kurotato;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x02000EBA RID: 3770
[NullableContext(1)]
[Nullable(0)]
public class PotatoSubController : KscSubControllerBase
{
	// Token: 0x06005D54 RID: 23892 RVA: 0x00112D25 File Offset: 0x00110F25
	protected override void OnInit()
	{
		base.OnInit();
		this.EnableSyncEntityTimeScaleToPlayer = true;
	}

	// Token: 0x06005D55 RID: 23893 RVA: 0x00112D34 File Offset: 0x00110F34
	protected override void CreateModel()
	{
		this.SubModel = new PotatoSubModel();
	}

	// Token: 0x06005D56 RID: 23894 RVA: 0x00112D41 File Offset: 0x00110F41
	public PotatoSubModel GetModel()
	{
		return (PotatoSubModel)this.SubModel;
	}

	// Token: 0x06005D57 RID: 23895 RVA: 0x00112D4E File Offset: 0x00110F4E
	public override bool IsTargetMap(int instSubType)
	{
		return instSubType == 51;
	}

	// Token: 0x06005D58 RID: 23896 RVA: 0x00112D58 File Offset: 0x00110F58
	public override void InitPropertyConfigs()
	{
		base.InitPropertyConfigs();
		PotatoSubModel model = this.GetModel();
		foreach (KurotatoProperty kurotatoProperty in KurotatoConfig.Instance.GetAllProperty())
		{
			if (kurotatoProperty.Min > -2147483648)
			{
				model.PropertyLowerBoundMap[kurotatoProperty.Id] = kurotatoProperty.Min;
			}
			if (kurotatoProperty.Max < 2147483647)
			{
				model.PropertyUpperBoundMap[kurotatoProperty.Id] = kurotatoProperty.Max;
			}
		}
	}

	// Token: 0x06005D59 RID: 23897 RVA: 0x00112E00 File Offset: 0x00111000
	protected override void InitConstVar()
	{
		base.InitConstVar();
		int activityId = KurotatoModel.Instance.GetActivityId();
		KurotatoActivityConfig? kurotatoActivityConfig;
		float? num = (KurotatoConfig.Instance.GetActivityConfig(activityId) != null) ? new float?(kurotatoActivityConfig.GetValueOrDefault().DamageDefenseConst) : null;
		string command = StringUtils.Format("ksc.damage.defense.const {0}", new string[]
		{
			((num != null) ? num.GetValueOrDefault().ToString() : null) ?? "20"
		});
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, command, null);
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "fx.Niagara.SystemSimulation.AllowASync 0", null);
	}

	// Token: 0x06005D5A RID: 23898 RVA: 0x00112EAC File Offset: 0x001110AC
	protected override void OnInitMap()
	{
		this.EnableSyncEntityTimeScaleToPlayer = true;
		FDamageConfig fdamageConfig = new FDamageConfig();
		fdamageConfig.PcFontSizeScale = 0.6f;
		fdamageConfig.MobileFontSizeScale = 0.9f;
		fdamageConfig.MaxDamagePerFrame = 1;
		DamageUiController.Instance.SetUeDamageConfig(fdamageConfig, true);
	}

	// Token: 0x06005D5B RID: 23899 RVA: 0x00112EF0 File Offset: 0x001110F0
	protected override void OnMapLoaded()
	{
		this.PreloadDodgeBuffAsync().Forget();
		this.InitBulletWorld();
		UBulletWorld kuroBulletWorld = BulletModel.Instance.GetKuroBulletWorld();
		if (kuroBulletWorld != null)
		{
			KurotatoActivityConfig? activityConfig = KurotatoModel.Instance.GetActivityConfig();
			if (activityConfig != null)
			{
				for (int i = 0; i < activityConfig.Value.BulletCountMaxLength; i++)
				{
					DicIntInt? dicIntInt = activityConfig.Value.BulletCountMax(i);
					if (dicIntInt != null)
					{
						kuroBulletWorld.SetBulletGroupMaxCountSingle(dicIntInt.Value.Key, dicIntInt.Value.Value);
					}
				}
				for (int j = 0; j < activityConfig.Value.CameraShakeLength; j++)
				{
					DicIntString? dicIntString = activityConfig.Value.CameraShake(j);
					if (dicIntString != null)
					{
						kuroBulletWorld.RegisterCameraShakeConfig(dicIntString.Value.Key, dicIntString.Value.Value);
					}
				}
				kuroBulletWorld.SetCameraShakeCooldown((double)activityConfig.Value.CameraShakeCd);
			}
			kuroBulletWorld.RegisterBulletActionClassByTag(GameplayTagUtils.GetGameplayTagById(GameplayTagDefine.EGameplayTagId["系统.活动.土豆.爆炸子弹"]).Value, UActionInitExplosionBulletPTT.StaticClass());
		}
		UDataTable udataTable = ResourceSystem.Instance.Load<UDataTable>(PotatoSubModel.BulletDtPath, "js_undefined");
		if (udataTable != null && udataTable.IsValid())
		{
			this.GetModel().BulletDataTable = udataTable;
		}
		else
		{
			Log.Instance.Error(ELogModule.SurvivorsRogue, ELogAuthor.HCW, "加载子弹DT失败", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		UBulletWorld kuroBulletWorld2 = BulletModel.Instance.GetKuroBulletWorld();
		if (kuroBulletWorld2 != null && udataTable != null)
		{
			kuroBulletWorld2.AddCommonBulletDataTable(udataTable);
		}
		UKSC_World kscWorld = KscEnv.Instance.KscWorld;
		UDataAsset udataAsset = ResourceSystem.Instance.Load<UDataAsset>(PotatoSubModel.HitContextTextDaPath, "js_undefined");
		if (kscWorld != null && udataAsset != null)
		{
			kscWorld.SetHitContextTextData(udataAsset as UKSC_DA_HitContextText);
		}
	}

	// Token: 0x06005D5C RID: 23900 RVA: 0x001130DC File Offset: 0x001112DC
	protected override void OnWorldDone()
	{
		UBulletWorld kuroBulletWorld = BulletModel.Instance.GetKuroBulletWorld();
		SceneTeamModel instance = SceneTeamModel.Instance;
		EntityHandle entityHandle = (instance != null) ? instance.GetCurrentEntity : null;
		if (entityHandle != null && entityHandle.Valid)
		{
			FVectorDouble actorLocation = entityHandle.Entity.GetComponent<CharacterActorComponent>().ActorLocation;
			if (kuroBulletWorld != null)
			{
				kuroBulletWorld.EnableFlatGroundByAbovePoint(actorLocation);
			}
			this.PlayerEntityHandle = entityHandle;
			this.SkillCdComp = entityHandle.Entity.GetComponent<CharacterSkillCdComponent>();
			this.SkillComp = entityHandle.Entity.GetComponent<CharacterSkillComponent>();
		}
		else
		{
			KscLog.Warn(KscLog.EModule.Common, ELogAuthor.CFT, KscEnv.Instance.KscWorld, "Ksc找不到玩家角色,未设置地面坐标", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		this.Timer = TimerSystem.Instance.Forever(delegate(float delta)
		{
			this.SyncWeaponDamage();
			this.SyncGoldGrowth();
		}, 1000f, 1f, null, null, true);
	}

	// Token: 0x06005D5D RID: 23901 RVA: 0x001131A0 File Offset: 0x001113A0
	protected override void OnWorldReset()
	{
		if (this.Timer != null)
		{
			TimerSystem.Instance.Remove(this.Timer);
			this.Timer = null;
		}
		this.ClearBulletWorld();
		this.DodgeBuffDa = null;
		this.PlayerEntityHandle = null;
		this.SkillCdComp = null;
		this.SkillComp = null;
		this.WaveNum = 0;
	}

	// Token: 0x06005D5E RID: 23902 RVA: 0x001131F6 File Offset: 0x001113F6
	protected override void OnClearMap()
	{
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "ksc.damage.defense.const 1520.0", null);
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "fx.Niagara.SystemSimulation.AllowASync 1", null);
	}

	// Token: 0x06005D5F RID: 23903 RVA: 0x00113218 File Offset: 0x00111418
	protected override void AddEvents()
	{
		base.AddEvents();
		EventSystem.Instance.Add(EEventName.KurotatoOnWeaponUpdate, new Action(this.OnUpdateWeapon));
		EventSystem.Instance.Add<EKurotatoStep>(EEventName.KurotatoOnStepChanged, new Action<EKurotatoStep>(this.OnStepChanged));
	}

	// Token: 0x06005D60 RID: 23904 RVA: 0x00113258 File Offset: 0x00111458
	protected override void RemoveEvents()
	{
		base.RemoveEvents();
		EventSystem.Instance.Remove(EEventName.KurotatoOnWeaponUpdate, new Action(this.OnUpdateWeapon));
		EventSystem.Instance.Remove<EKurotatoStep>(EEventName.KurotatoOnStepChanged, new Action<EKurotatoStep>(this.OnStepChanged));
	}

	// Token: 0x06005D61 RID: 23905 RVA: 0x00113298 File Offset: 0x00111498
	public override void OnSystemInfoNotify()
	{
		KurotatoLevel? levelConfig = KurotatoConfig.Instance.GetLevelConfig(KurotatoModel.Instance.GetCurLevelId());
		if (levelConfig != null)
		{
			UKSC_DA_WorldBoundsRound uksc_DA_WorldBoundsRound = UE.NewObject<UKSC_DA_WorldBoundsRound>(GlobalData.World, null, EObjectFlags.RF_NoFlags);
			uksc_DA_WorldBoundsRound.WorldRadius = levelConfig.Value.BoundRadius;
			float num = levelConfig.Value.BoundCenter(2);
			uksc_DA_WorldBoundsRound.WorldCenterOffset = new FVectorDouble((double)levelConfig.Value.BoundCenter(0), (double)levelConfig.Value.BoundCenter(1), (double)num);
			uksc_DA_WorldBoundsRound.GroundPositionZ = num;
			UKSC_World kscWorld = KscEnv.Instance.KscWorld;
			if (kscWorld == null)
			{
				return;
			}
			kscWorld.SetWorldBounds(uksc_DA_WorldBoundsRound);
		}
	}

	// Token: 0x06005D62 RID: 23906 RVA: 0x00113341 File Offset: 0x00111541
	private void OnUpdateWeapon()
	{
		this.RefreshWeaponIndexInfo();
	}

	// Token: 0x06005D63 RID: 23907 RVA: 0x0011334C File Offset: 0x0011154C
	private void OnStepChanged(EKurotatoStep step)
	{
		if (step == EKurotatoStep.WaveUpdate)
		{
			this.WaveNum++;
			UKSC_World kscWorld = KscEnv.Instance.KscWorld;
			if (kscWorld != null)
			{
				kscWorld.SetWorldAttr(EKSC_WorldAttrType.Wave, this.WaveNum);
			}
			this.ClearWeaponDamage();
			this.NeedBroadcastPlayerOneHp = KurotatoModel.Instance.GetIsSpecialWave();
			bool needBroadcastPlayerOneHp = this.NeedBroadcastPlayerOneHp;
		}
	}

	// Token: 0x06005D64 RID: 23908 RVA: 0x001133A4 File Offset: 0x001115A4
	public unsafe override void OnEntityRemoved(KscRemoveContext context, Dictionary<long, SimpleCombatEntityDieContext> protoContexts)
	{
		int? logicProxy = base.Model.GetLogicProxy(context.CreatureDataId);
		foreach (KeyValuePair<int, AKSC_Entity> keyValuePair in this.GetModel().WeaponKscEntityMap)
		{
			int entityId_ = keyValuePair.Value.EntityId_;
			int? num = logicProxy;
			if (entityId_ == num.GetValueOrDefault() & num != null)
			{
				this.GetModel().WeaponKscEntityMap.Remove(keyValuePair.Key);
				break;
			}
		}
		this.GetModel().DamageMap.Remove(context.CreatureDataId);
		IPotatoCombatInfo entity = this.GetModel().GetEntity(context.CreatureDataId);
		if (entity == null)
		{
			return;
		}
		if (entity.EntityType == EPotatoEntityType.Monster)
		{
			IPotatoActivityEntityInfo potatoActivityEntityInfo = (IPotatoActivityEntityInfo)entity;
			this.NotifyMonsterUpdate(potatoActivityEntityInfo.ConfigId, logicProxy.Value, false);
		}
		else if (entity.EntityType == EPotatoEntityType.Structure)
		{
			IPotatoActivityEntityInfo potatoActivityEntityInfo2 = (IPotatoActivityEntityInfo)entity;
			this.NotifyStructureUpdate(potatoActivityEntityInfo2.ConfigId, logicProxy.Value, false);
		}
		SimpleCombatEntityDieContext simpleCombatEntityDieContext = SimpleCombatEntityDieContext.Create();
		Aki.Protocol.Vector vector = Aki.Protocol.Vector.Create();
		vector.X = (float)context.Location.X;
		vector.Y = (float)context.Location.Y;
		vector.Z = (float)context.Location.Z;
		simpleCombatEntityDieContext.DiePos = vector;
		FName? dynamicFName = FNameUtil.GetDynamicFName(context.ReasonName.ToString());
		if (dynamicFName == KscEntityRemoveReason.Dead)
		{
			if (entity.EntityType == EPotatoEntityType.PlayerCharacter)
			{
				KurotatoRoleKilledCtxPb kurotatoRoleKilledCtxPb = KurotatoRoleKilledCtxPb.Create();
				simpleCombatEntityDieContext.KurotatoRoleKilledCtxPb = kurotatoRoleKilledCtxPb;
				this.PlayPlayerDeathForceFeedback();
				this.RemoveAllMonsterNextFrame();
			}
			else if (entity.EntityType == EPotatoEntityType.Structure)
			{
				KurotatoStructureKilledCtxPb kurotatoStructureKilledCtxPb = KurotatoStructureKilledCtxPb.Create();
				simpleCombatEntityDieContext.KurotatoStructureKilledCtxPb = kurotatoStructureKilledCtxPb;
			}
			else
			{
				KurotatoMonsterKilledCtxPb kurotatoMonsterKilledCtxPb = KurotatoMonsterKilledCtxPb.Create();
				kurotatoMonsterKilledCtxPb.EntityId = context.KillerId;
				simpleCombatEntityDieContext.KurotatoMonsterKilledCtxPb = kurotatoMonsterKilledCtxPb;
			}
		}
		else
		{
			if (!(dynamicFName == KscEntityRemoveReason.Coin))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.TowerDefenseEvent;
				ELogAuthor author = ELogAuthor.HCW;
				string message = "移除Potato实体失败: 未处理移除原因";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("creatureDataId", context.CreatureDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("reasonName", context.ReasonName);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			KurotatoDropAbsorbedCtxPb kurotatoDropAbsorbedCtxPb = KurotatoDropAbsorbedCtxPb.Create();
			simpleCombatEntityDieContext.KurotatoDropAbsorbedCtxPb = kurotatoDropAbsorbedCtxPb;
		}
		protoContexts[context.CreatureDataId] = simpleCombatEntityDieContext;
	}

	// Token: 0x06005D65 RID: 23909 RVA: 0x00113660 File Offset: 0x00111860
	private void RemoveAllMonsterNextFrame()
	{
		TimerSystem.Instance.Next(delegate(float _)
		{
			List<IPotatoCombatInfo> list = new List<IPotatoCombatInfo>();
			this.GetModel().GetAllEntities(list);
			foreach (IPotatoCombatInfo potatoCombatInfo in list)
			{
				if (potatoCombatInfo.EntityType == EPotatoEntityType.Monster)
				{
					KuroSimpleCombatController.Instance.RemoveEntityByReasonType((long)potatoCombatInfo.Uid, EKscEntityRemoveReasonType.Dead);
				}
				else if (potatoCombatInfo.EntityType == EPotatoEntityType.GoldenCoin || potatoCombatInfo.EntityType == EPotatoEntityType.Weapon || potatoCombatInfo.EntityType == EPotatoEntityType.Structure)
				{
					KuroSimpleCombatController.Instance.RemoveEntityByReasonType((long)potatoCombatInfo.Uid, EKscEntityRemoveReasonType.Destroy);
				}
			}
		}, null, null);
	}

	// Token: 0x06005D66 RID: 23910 RVA: 0x0011367C File Offset: 0x0011187C
	private void PlayPlayerDeathForceFeedback()
	{
		if (!Info.Instance.IsInGamepad())
		{
			return;
		}
		ResourceSystem.Instance.LoadAsync<UKuroForceFeedbackEffect>("/Game/Aki/Data/SimpleCombat/3_4Potato/Player/PlayerDeath_ForceFeedback.PlayerDeath_ForceFeedback", delegate([Nullable(2)] UKuroForceFeedbackEffect effect, string loadPath)
		{
			if (effect != null)
			{
				GamepadController.Instance.PlayKuroForceFeedback(effect, null, false, false, false, "PotatoPlayerDeath");
			}
		}, 100, "js_undefined");
	}

	// Token: 0x06005D67 RID: 23911 RVA: 0x001136CC File Offset: 0x001118CC
	protected override void CreateEntityFilter()
	{
		this.RedirectFilter = this.EntityRedirectFilter;
	}

	// Token: 0x06005D68 RID: 23912 RVA: 0x001136DA File Offset: 0x001118DA
	[NullableContext(2)]
	protected override EntityHandle GetPossessedPlayerEntity()
	{
		return this.PlayerEntityHandle;
	}

	// Token: 0x06005D69 RID: 23913 RVA: 0x001136E4 File Offset: 0x001118E4
	protected override bool AddInputLayer()
	{
		PotatoInputLayer potatoInputLayer = this.GetInputLayer();
		if (potatoInputLayer != null)
		{
			this.RemoveInputLayer();
		}
		potatoInputLayer = (InputController.Instance.CreateInputLayer(EInputLayer.Potato) as PotatoInputLayer);
		if (potatoInputLayer != null)
		{
			EntityHandle possessedPlayerEntity = this.GetPossessedPlayerEntity();
			if (possessedPlayerEntity != null)
			{
				InputController.Instance.AddInputLayer(possessedPlayerEntity.Id, potatoInputLayer);
			}
			else
			{
				KscLog.Error(KscLog.EModule.Input, ELogAuthor.HCW, KscEnv.Instance.KscWorld, "Potato输入层加入异常,无法绑定实体", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return true;
		}
		KscLog.Error(KscLog.EModule.Input, ELogAuthor.HCW, KscEnv.Instance.KscWorld, "Potato输入层加入异常", default(ReadOnlySpan<ValueTuple<string, object>>));
		return false;
	}

	// Token: 0x06005D6A RID: 23914 RVA: 0x00113778 File Offset: 0x00111978
	protected override bool RemoveInputLayer()
	{
		PotatoInputLayer inputLayer = this.GetInputLayer();
		if (inputLayer != null)
		{
			InputController.Instance.RemoveInputLayer(inputLayer);
			inputLayer.Clear();
			return true;
		}
		KscLog.Error(KscLog.EModule.Input, ELogAuthor.HCW, KscEnv.Instance.KscWorld, "Potato输入层移除异常", default(ReadOnlySpan<ValueTuple<string, object>>));
		return false;
	}

	// Token: 0x06005D6B RID: 23915 RVA: 0x001137C4 File Offset: 0x001119C4
	[NullableContext(2)]
	private PotatoInputLayer GetInputLayer()
	{
		EntityHandle possessedPlayerEntity = this.GetPossessedPlayerEntity();
		if (possessedPlayerEntity != null)
		{
			return InputController.Instance.GetInputLayer(possessedPlayerEntity.Id, EInputLayer.Potato) as PotatoInputLayer;
		}
		return null;
	}

	// Token: 0x06005D6C RID: 23916 RVA: 0x001137F4 File Offset: 0x001119F4
	protected override void AddKscPlayerEntity()
	{
		this.AddInputLayer();
	}

	// Token: 0x06005D6D RID: 23917 RVA: 0x001137FD File Offset: 0x001119FD
	public override void OnPlayerEntityCreated()
	{
		base.OnPlayerEntityCreated();
		PotatoSubModel model = this.GetModel();
		AKSC_Entity kscPlayerEntity = model.KscPlayerEntity;
		model.KscPlayerEntityId = ((kscPlayerEntity != null) ? kscPlayerEntity.EntityId_ : 0);
	}

	// Token: 0x06005D6E RID: 23918 RVA: 0x00113824 File Offset: 0x00111A24
	protected override void SyncPlayerTransform()
	{
		if (this.GetModel().KscPlayerEntity == null)
		{
			return;
		}
		EntityHandle playerEntityHandle = this.PlayerEntityHandle;
		if (playerEntityHandle == null || !playerEntityHandle.Valid)
		{
			return;
		}
		FTransformDouble ftransformDouble = this.PlayerEntityHandle.Entity.GetComponent<CharacterActorComponent>().Actor.D_GetTransform();
		AKSC_Entity kscPlayerEntity = this.GetModel().KscPlayerEntity;
		if (kscPlayerEntity == null)
		{
			return;
		}
		kscPlayerEntity.SetTransformByWorld(ftransformDouble);
	}

	// Token: 0x06005D6F RID: 23919 RVA: 0x00113889 File Offset: 0x00111A89
	public void OnWeaponCreated(AKSC_Entity kscEntity, int incId)
	{
		this.GetModel().WeaponKscEntityMap[incId] = kscEntity;
		this.OnSummonedCreated(kscEntity, true);
	}

	// Token: 0x06005D70 RID: 23920 RVA: 0x001138A8 File Offset: 0x00111AA8
	public void OnSummonedCreated(AKSC_Entity kscEntity, bool isWeapon = false)
	{
		PotatoSubModel model = this.GetModel();
		if (model.KscPlayerEntity == null)
		{
			KscLog.Error(KscLog.EModule.Load, ELogAuthor.CFT, kscEntity, "设置武器主人时玩家还未创建", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		UKSC_Move_Around uksc_Move_Around = kscEntity.GetMoveComponent() as UKSC_Move_Around;
		if (uksc_Move_Around != null)
		{
			uksc_Move_Around.SetAroundTarget(model.KscPlayerEntity);
		}
		if (isWeapon)
		{
			this.RefreshWeaponIndexInfo();
		}
	}

	// Token: 0x06005D71 RID: 23921 RVA: 0x00113900 File Offset: 0x00111B00
	private void RefreshWeaponIndexInfo()
	{
		PotatoSubModel model = this.GetModel();
		List<IKurotatoWeaponData> holdWeaponData = KurotatoModel.Instance.GetHoldWeaponData();
		List<AKSC_Entity> list = new List<AKSC_Entity>();
		foreach (IKurotatoWeaponData kurotatoWeaponData in holdWeaponData)
		{
			AKSC_Entity item;
			if (model.WeaponKscEntityMap.TryGetValue(kurotatoWeaponData.IncId, out item))
			{
				list.Add(item);
			}
		}
		int count = list.Count;
		if (count <= 0)
		{
			return;
		}
		for (int i = 0; i < count; i++)
		{
			UKSC_Move_Around uksc_Move_Around = list[i].GetMoveComponent() as UKSC_Move_Around;
			if (uksc_Move_Around != null)
			{
				uksc_Move_Around.SetIndexInfo(count, i);
			}
		}
	}

	// Token: 0x06005D72 RID: 23922 RVA: 0x001139BC File Offset: 0x00111BBC
	protected override void OnHandlePlayerHeadHpInfo(KscHeadStateData kscPlayerHeadStateData, FKSC_HeadHpContext headInfo)
	{
		base.OnHandlePlayerHeadHpInfo(kscPlayerHeadStateData, headInfo);
		if (this.NeedBroadcastPlayerOneHp && kscPlayerHeadStateData.Hp <= 1)
		{
			this.NeedBroadcastPlayerOneHp = false;
			EventSystem.Instance.Emit(EEventName.KurotatoPlayerOneHpLeft);
		}
	}

	// Token: 0x06005D73 RID: 23923 RVA: 0x001139F0 File Offset: 0x00111BF0
	public override void GmPrintInfo()
	{
		PotatoSubModel model = this.GetModel();
		List<string> list = new List<string>
		{
			"[ksc]Potato玩法"
		};
		List<string> list2 = list;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
		defaultInterpolatedStringHandler.AppendLiteral("玩家 EntityId:");
		defaultInterpolatedStringHandler.AppendFormatted<int>(model.KscPlayerEntityId);
		defaultInterpolatedStringHandler.AppendLiteral(", 服务端Id:");
		defaultInterpolatedStringHandler.AppendFormatted<long>(model.KscPlayerCreatureDataId);
		list2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
		foreach (AKSC_Entity aksc_Entity in model.WeaponKscEntityMap.Values)
		{
			int entityId_ = aksc_Entity.EntityId_;
			List<string> list3 = list;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
			defaultInterpolatedStringHandler.AppendLiteral("武器 EntityId:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(entityId_);
			defaultInterpolatedStringHandler.AppendLiteral(", 服务端Id:");
			defaultInterpolatedStringHandler.AppendFormatted<long>(model.GetEntityCreatureId(entityId_));
			list3.Add(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		list.Add("-------------------");
		string inString = string.Join("\n", list);
		if (!UKuroStaticLibrary.IsEditor(GlobalData.World))
		{
			return;
		}
		UWorld world = GlobalData.World.GetWorld();
		if (world != null)
		{
			UKismetSystemLibrary.PrintString(world, inString, true, false, new FLinearColor?(new FLinearColor(0f, 0.66f, 1f, 1f)), 10f);
		}
	}

	// Token: 0x06005D74 RID: 23924 RVA: 0x00113B50 File Offset: 0x00111D50
	public override void InitDamageConfigs()
	{
		UKSC_World kscWorld = KscEnv.Instance.KscWorld;
		if (kscWorld == null)
		{
			KscLog.Error(KscLog.EModule.Load, ELogAuthor.HCW, KscEnv.Instance.KscWorld, "Potato InitDamageIdConfig failed", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		UKSC_DamageId damageData = kscWorld.DamageData;
		if (damageData == null || !damageData.IsValid())
		{
			KscLog.Error(KscLog.EModule.Load, ELogAuthor.HCW, KscEnv.Instance.KscWorld, "Potato InitDamageIdConfig failed", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		IReadOnlyList<KSCDamage> configList = ConfigKSCDamageByKscGameplayType.GetConfigList((int)base.Model.GameplayType, true);
		if (configList == null)
		{
			return;
		}
		foreach (KSCDamage kscdamage in configList)
		{
			if (kscdamage.CalculateType == 6)
			{
				FKSCDamage fkscdamage = new FKSCDamage();
				fkscdamage.DamageID = (int)kscdamage.Id;
				fkscdamage.Knocked = kscdamage.Knocked;
				fkscdamage.CalculateType = (EKSC_CalculateType)kscdamage.CalculateType;
				fkscdamage.Element = (EKSC_Element)kscdamage.Element;
				fkscdamage.CritAttrType = (EKSC_AttrType)kscdamage.CritAttrType;
				if (kscdamage.Amplify > 0)
				{
					fkscdamage.RelatedInfos.Add(new FKSCDamageRelated((float)kscdamage.Amplify * 0.0001f, (EKSC_AttrType)kscdamage.RelatedProperty, (EKSC_AttrType)kscdamage.MainDamageType, (EKSC_AttrType)kscdamage.SubDamageType));
				}
				if (kscdamage.Amplify1 > 0)
				{
					fkscdamage.RelatedInfos.Add(new FKSCDamageRelated((float)kscdamage.Amplify1 * 0.0001f, (EKSC_AttrType)kscdamage.RelatedProperty1, (EKSC_AttrType)kscdamage.MainDamageType1, (EKSC_AttrType)kscdamage.SubDamageType1));
				}
				if (kscdamage.Amplify2 > 0)
				{
					fkscdamage.RelatedInfos.Add(new FKSCDamageRelated((float)kscdamage.Amplify2 * 0.0001f, (EKSC_AttrType)kscdamage.RelatedProperty2, (EKSC_AttrType)kscdamage.MainDamageType2, (EKSC_AttrType)kscdamage.SubDamageType2));
				}
				if (kscdamage.Amplify3 > 0)
				{
					fkscdamage.RelatedInfos.Add(new FKSCDamageRelated((float)kscdamage.Amplify3 * 0.0001f, (EKSC_AttrType)kscdamage.RelatedProperty3, (EKSC_AttrType)kscdamage.MainDamageType3, (EKSC_AttrType)kscdamage.SubDamageType3));
				}
				damageData.AddDamageData((int)kscdamage.Id, fkscdamage);
			}
			else
			{
				FKSCDamage fkscdamage2 = new FKSCDamage();
				fkscdamage2.DamageID = (int)kscdamage.Id;
				fkscdamage2.CalculateType = (EKSC_CalculateType)kscdamage.CalculateType;
				fkscdamage2.Element = (EKSC_Element)kscdamage.Element;
				fkscdamage2.Amplify = (float)kscdamage.Amplify * 0.0001f;
				fkscdamage2.RelatedProperty = (EKSC_AttrType)kscdamage.RelatedProperty;
				if (kscdamage.CalculateType == 8)
				{
					fkscdamage2.RelatedInfos.Add(new FKSCDamageRelated(0f, EKSC_AttrType.EAttributeType_None, (EKSC_AttrType)kscdamage.MainDamageType, EKSC_AttrType.EAttributeType_None));
				}
				fkscdamage2.CritAttrType = (EKSC_AttrType)kscdamage.CritAttrType;
				damageData.AddDamageData((int)kscdamage.Id, fkscdamage2);
			}
		}
	}

	// Token: 0x06005D75 RID: 23925 RVA: 0x00113E3C File Offset: 0x0011203C
	public override void SetAttrs(AKSC_Entity entity, int propertyId, [Nullable(2)] Dictionary<int, int> attributeMap = null)
	{
		if (entity == null)
		{
			KscLog.EModule flag = KscLog.EModule.Attr;
			ELogAuthor author = ELogAuthor.CFT;
			UObject kscWorld = KscEnv.Instance.KscWorld;
			string log = "Potato属性设置失败:异常Entity";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("propertyId", propertyId);
			KscLog.Warn(flag, author, kscWorld, log, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		bool isBuildDevelopmentOrDebug = Info.Instance.IsBuildDevelopmentOrDebug;
		KscSubModelBase subModel = this.SubModel;
		KscEntityHandle kscEntityHandle2;
		KscEntityHandle kscEntityHandle = (subModel != null && subModel.KscEntities.TryGetValue(entity.EntityId_, out kscEntityHandle2)) ? kscEntityHandle2 : null;
		if (attributeMap == null || kscEntityHandle == null)
		{
			KscLog.EModule flag2 = KscLog.EModule.Attr;
			ELogAuthor author2 = ELogAuthor.HCW;
			UObject kscWorld2 = KscEnv.Instance.KscWorld;
			string log2 = "属性没有下发";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("entityId", entity.EntityId_);
			KscLog.Error(flag2, author2, kscWorld2, log2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		int num2;
		int num = Math.Max(1, attributeMap.TryGetValue(2, out num2) ? num2 : 0);
		UKSC_SkillComp skillComp = entity.GetSkillComp();
		UKSC_AttrSet uksc_AttrSet = (skillComp != null) ? skillComp.AttrSet_ : null;
		if (uksc_AttrSet != null)
		{
			TMap<EKSC_AttrType, int> attrs_ = uksc_AttrSet.Attrs_;
			if (attrs_ != null)
			{
				attrs_.Empty(0);
			}
			TMap<EKSC_AttrType, int> sourceAttrs_ = uksc_AttrSet.SourceAttrs_;
			if (sourceAttrs_ != null)
			{
				sourceAttrs_.Empty(0);
			}
			PotatoSubModel model = this.GetModel();
			foreach (KeyValuePair<int, int> keyValuePair in model.PropertyUpperBoundMap)
			{
				uksc_AttrSet.AddUpperBoundLocker((EKSC_AttrType)keyValuePair.Key, keyValuePair.Value);
			}
			foreach (KeyValuePair<int, int> keyValuePair2 in model.PropertyLowerBoundMap)
			{
				uksc_AttrSet.AddLowerBoundLocker((EKSC_AttrType)keyValuePair2.Key, keyValuePair2.Value);
			}
		}
		foreach (KeyValuePair<int, int> keyValuePair3 in attributeMap)
		{
			EKSC_AttrType eksc_AttrType = (EKSC_AttrType)keyValuePair3.Key;
			int num3 = keyValuePair3.Value;
			if (eksc_AttrType == EKSC_AttrType.LifeMax)
			{
				num3 = num;
				kscEntityHandle.SetAttr(eksc_AttrType, num3);
			}
			else if (eksc_AttrType == EKSC_AttrType.Life)
			{
				num3 = Math.Min(num, num3);
			}
			else
			{
				kscEntityHandle.SetAttr(eksc_AttrType, num3);
			}
			entity.SetAttr(eksc_AttrType, num3);
		}
	}

	// Token: 0x06005D76 RID: 23926 RVA: 0x0011407C File Offset: 0x0011227C
	private void ClearWeaponDamage()
	{
		foreach (AKSC_Entity aksc_Entity in this.GetModel().WeaponKscEntityMap.Values)
		{
			aksc_Entity.SetAttr(EKSC_AttrType.AccumulatedDamage, 0);
		}
	}

	// Token: 0x06005D77 RID: 23927 RVA: 0x001140DC File Offset: 0x001122DC
	private void SyncWeaponDamage()
	{
		Dictionary<long, int> dictionary = new Dictionary<long, int>();
		bool flag = false;
		foreach (KeyValuePair<long, int> keyValuePair in this.GetModel().DamageMap)
		{
			long key = keyValuePair.Key;
			int value = keyValuePair.Value;
			KscEntityHandle kscEntityHandle = this.GetModel().GetKscEntityHandle(key);
			if (kscEntityHandle != null && kscEntityHandle.Valid)
			{
				AKSC_Entity kscEntity = kscEntityHandle.KscEntity;
				TMap<EKSC_AttrType, int> tmap;
				if (kscEntity == null)
				{
					tmap = null;
				}
				else
				{
					UKSC_SkillComp skillComp = kscEntity.GetSkillComp();
					if (skillComp == null)
					{
						tmap = null;
					}
					else
					{
						UKSC_AttrSet attrSet_ = skillComp.AttrSet_;
						tmap = ((attrSet_ != null) ? attrSet_.Attrs_ : null);
					}
				}
				TMap<EKSC_AttrType, int> tmap2 = tmap;
				if (tmap2 != null)
				{
					int valueOrDefault = tmap2.GetValueOrDefault(EKSC_AttrType.AccumulatedDamage, 0);
					if (valueOrDefault != value)
					{
						this.GetModel().DamageMap[key] = valueOrDefault;
						dictionary[key] = valueOrDefault;
						flag = true;
					}
				}
			}
		}
		if (flag)
		{
			KurotatoSyncEntityDealDamagePush kurotatoSyncEntityDealDamagePush = KurotatoSyncEntityDealDamagePush.Create();
			foreach (KeyValuePair<long, int> keyValuePair2 in dictionary)
			{
				kurotatoSyncEntityDealDamagePush.EntityDealDamages.Add(keyValuePair2.Key, keyValuePair2.Value);
			}
			Net.Instance.Send(EPushMessageId.KurotatoSyncEntityDealDamagePush, kurotatoSyncEntityDealDamagePush);
		}
	}

	// Token: 0x06005D78 RID: 23928 RVA: 0x00114244 File Offset: 0x00112444
	private void SyncGoldGrowth()
	{
		UKSC_World kscWorld = KscEnv.Instance.KscWorld;
		int num = (kscWorld != null) ? kscWorld.GetWorldAttr(EKSC_WorldAttrType.GoldGrowth) : 0;
		if (num > 0)
		{
			UKSC_World kscWorld2 = KscEnv.Instance.KscWorld;
			if (kscWorld2 != null)
			{
				kscWorld2.SetWorldAttr(EKSC_WorldAttrType.GoldGrowth, 0);
			}
			KurotatoController.Instance.RequestKurotatoGoldAdd(num).Forget<bool>();
		}
	}

	// Token: 0x06005D79 RID: 23929 RVA: 0x00114296 File Offset: 0x00112496
	protected override void PushPlayerHp()
	{
	}

	// Token: 0x06005D7A RID: 23930 RVA: 0x00114298 File Offset: 0x00112498
	public void NotifyMonsterUpdate(int configId, int kscEntityId, bool isAdd)
	{
		if (KurotatoConfig.Instance.GetMonsterRiskType(configId) == 3)
		{
			EventSystem.Instance.Emit<int, bool>(EEventName.KurotatoBossTrackedMarkerUpdate, kscEntityId, isAdd);
		}
	}

	// Token: 0x06005D7B RID: 23931 RVA: 0x001142BC File Offset: 0x001124BC
	public void NotifyStructureUpdate(int configId, int kscEntityId, bool isAdd)
	{
		KurotatoStructure? structureConfigById = KurotatoConfig.Instance.GetStructureConfigById(configId);
		if (structureConfigById == null)
		{
			return;
		}
		if (structureConfigById.Value.Type == "Tree")
		{
			EventSystem.Instance.Emit<int, bool>(EEventName.KurotatoTreasureBoxTrackedMarkerUpdate, kscEntityId, isAdd);
		}
	}

	// Token: 0x06005D7C RID: 23932 RVA: 0x0011430C File Offset: 0x0011250C
	public void ExecSkillDodge()
	{
		AKSC_Entity kscPlayerEntity = this.SubModel.KscPlayerEntity;
		if (kscPlayerEntity == null)
		{
			return;
		}
		if (this.SkillCdComp == null || this.SkillComp == null)
		{
			return;
		}
		if (this.DodgeBuffDa == null)
		{
			KscLog.Error(KscLog.EModule.Common, ELogAuthor.HCW, null, "ExecSkillDodge: DodgeBuffDa未预加载", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		int skillId = 700105;
		if (this.SkillCdComp.IsSkillInCd(skillId, true))
		{
			return;
		}
		this.SkillComp.BeginSkillAsync(skillId, null).Forget<bool>();
		kscPlayerEntity.ApplyBuffSelf(this.DodgeBuffDa);
	}

	// Token: 0x06005D7D RID: 23933 RVA: 0x00114390 File Offset: 0x00112590
	private UniTask PreloadDodgeBuffAsync()
	{
		PotatoSubController.<PreloadDodgeBuffAsync>d__54 <PreloadDodgeBuffAsync>d__;
		<PreloadDodgeBuffAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PreloadDodgeBuffAsync>d__.<>4__this = this;
		<PreloadDodgeBuffAsync>d__.<>1__state = -1;
		<PreloadDodgeBuffAsync>d__.<>t__builder.Start<PotatoSubController.<PreloadDodgeBuffAsync>d__54>(ref <PreloadDodgeBuffAsync>d__);
		return <PreloadDodgeBuffAsync>d__.<>t__builder.Task;
	}

	// Token: 0x04002A85 RID: 10885
	public const int MULTI_RELATED_DAMAGE = 6;

	// Token: 0x04002A86 RID: 10886
	public const int ITEM_HEAL = 8;

	// Token: 0x04002A87 RID: 10887
	private const int PROPERTY_MIN = -2147483648;

	// Token: 0x04002A88 RID: 10888
	private const int PROPERTY_MAX = 2147483647;

	// Token: 0x04002A89 RID: 10889
	private const string PLAYER_DEATH_FORCE_FEEDBACK_PATH = "/Game/Aki/Data/SimpleCombat/3_4Potato/Player/PlayerDeath_ForceFeedback.PlayerDeath_ForceFeedback";

	// Token: 0x04002A8A RID: 10890
	[Nullable(2)]
	private EntityHandle PlayerEntityHandle;

	// Token: 0x04002A8B RID: 10891
	private int WaveNum;

	// Token: 0x04002A8C RID: 10892
	private readonly PotatoEntityRedirectFilter EntityRedirectFilter = new PotatoEntityRedirectFilter();

	// Token: 0x04002A8D RID: 10893
	[Nullable(2)]
	private TimerHandle Timer;

	// Token: 0x04002A8E RID: 10894
	private bool NeedBroadcastPlayerOneHp;

	// Token: 0x04002A8F RID: 10895
	[Nullable(2)]
	private CharacterSkillCdComponent SkillCdComp;

	// Token: 0x04002A90 RID: 10896
	[Nullable(2)]
	private CharacterSkillComponent SkillComp;

	// Token: 0x04002A91 RID: 10897
	[Nullable(2)]
	private UKSC_DA_Buff DodgeBuffDa;
}
