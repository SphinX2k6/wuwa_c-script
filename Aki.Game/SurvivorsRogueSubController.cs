using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.KuroSimpleCombat;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x02000ECD RID: 3789
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueSubController : KscSubControllerBase
{
	// Token: 0x06005E22 RID: 24098 RVA: 0x00115B4D File Offset: 0x00113D4D
	protected override void CreateModel()
	{
		this.SubModel = new SurvivorsRogueSubModel();
	}

	// Token: 0x06005E23 RID: 24099 RVA: 0x00115B5A File Offset: 0x00113D5A
	public SurvivorsRogueSubModel GetModel()
	{
		return (SurvivorsRogueSubModel)this.SubModel;
	}

	// Token: 0x06005E24 RID: 24100 RVA: 0x00115B67 File Offset: 0x00113D67
	public override bool IsTargetMap(int instSubType)
	{
		return instSubType == 41;
	}

	// Token: 0x06005E25 RID: 24101 RVA: 0x00115B70 File Offset: 0x00113D70
	protected override void OnInitMap()
	{
		FDamageConfig fdamageConfig = new FDamageConfig();
		fdamageConfig.PcFontSizeScale = 0.6f;
		fdamageConfig.MobileFontSizeScale = 0.9f;
		fdamageConfig.MaxDamagePerFrame = 1;
		DamageUiController.Instance.SetUeDamageConfig(fdamageConfig, true);
	}

	// Token: 0x06005E26 RID: 24102 RVA: 0x00115BAC File Offset: 0x00113DAC
	protected override void OnMapLoaded()
	{
		this.InitBulletWorld();
		UDataTable udataTable = ResourceSystem.Instance.Load<UDataTable>(SurvivorsRogueSubModel.BulletDtPath, "js_undefined");
		if (udataTable != null && udataTable.IsValid())
		{
			this.GetModel().BulletDataTable = udataTable;
		}
		else
		{
			Log.Instance.Error(ELogModule.SurvivorsRogue, ELogAuthor.CFT, "加载子弹DT失败", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		UBulletWorld kuroBulletWorld = BulletModel.Instance.GetKuroBulletWorld();
		if (kuroBulletWorld != null && udataTable != null)
		{
			kuroBulletWorld.AddCommonBulletDataTable(udataTable);
		}
		this.AddTreeListener();
	}

	// Token: 0x06005E27 RID: 24103 RVA: 0x00115C2C File Offset: 0x00113E2C
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
		this.PlayerHpHandle.Init(null, null, null, null);
		KscHeadStateData kscPlayerHeadStateData = this.GetModel().KscPlayerHeadStateData;
		if (kscPlayerHeadStateData != null)
		{
			this.PlayerHpHandle.OnPlayerHpChange(kscPlayerHeadStateData);
		}
	}

	// Token: 0x06005E28 RID: 24104 RVA: 0x00115D16 File Offset: 0x00113F16
	protected override void OnWorldReset()
	{
		this.ClearBulletWorld();
		this.PlayerEntityHandle = null;
		this.SkillCdComp = null;
		this.RemoveTreeListener();
		this.PlayerHpHandle.Clear();
	}

	// Token: 0x06005E29 RID: 24105 RVA: 0x00115D40 File Offset: 0x00113F40
	public unsafe override void OnEntityRemoved(KscRemoveContext context, Dictionary<long, SimpleCombatEntityDieContext> protoContexts)
	{
		int? logicProxy = base.Model.GetLogicProxy(context.CreatureDataId);
		List<AKSC_Entity> weaponKscEntities = this.GetModel().WeaponKscEntities;
		for (int i = 0; i < weaponKscEntities.Count; i++)
		{
			int entityId_ = weaponKscEntities[i].EntityId_;
			int? num = logicProxy;
			if (entityId_ == num.GetValueOrDefault() & num != null)
			{
				weaponKscEntities.RemoveAt(i);
				break;
			}
		}
		ISurvivorsRogueCombatInfo entity = this.GetModel().GetEntity(context.CreatureDataId);
		if (entity == null)
		{
			return;
		}
		if (entity.EntityType == ESurvivorsRogueEntityType.Monster && SurvivorsRogueConfig.Instance.IsBoss(entity.TemplateId))
		{
			EventSystem.Instance.Emit<int, bool>(EEventName.SurvivorsRogueBossTrackedMarkerUpdate, logicProxy.Value, false);
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
			if (entity.EntityType == ESurvivorsRogueEntityType.PlayerCharacter)
			{
				SurvivorsRoleKilledCtxPb survivorsRoleKilledCtx = SurvivorsRoleKilledCtxPb.Create();
				simpleCombatEntityDieContext.SurvivorsRoleKilledCtx = survivorsRoleKilledCtx;
				this.RemoveAllMonsterNextFrame();
			}
			else
			{
				SurvivorsMonsterKilledCtxPb survivorsMonsterKilledCtxPb = SurvivorsMonsterKilledCtxPb.Create();
				survivorsMonsterKilledCtxPb.EntityId = context.KillerId;
				simpleCombatEntityDieContext.SurvivorsMonsterKilledCtx = survivorsMonsterKilledCtxPb;
			}
		}
		else
		{
			if (!(dynamicFName == KscEntityRemoveReason.Coin))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.TowerDefenseEvent;
				ELogAuthor author = ELogAuthor.XY;
				string message = "移除幸存者实体失败: 未处理移除原因";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("creatureDataId", context.CreatureDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("reasonName", context.ReasonName);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			SurvivorsGoldenCoinAbosorbedCtxPb survivorsGoldenCoinAbosorbedCtx = SurvivorsGoldenCoinAbosorbedCtxPb.Create();
			simpleCombatEntityDieContext.SurvivorsGoldenCoinAbosorbedCtx = survivorsGoldenCoinAbosorbedCtx;
		}
		protoContexts[context.CreatureDataId] = simpleCombatEntityDieContext;
	}

	// Token: 0x06005E2A RID: 24106 RVA: 0x00115F77 File Offset: 0x00114177
	private void RemoveAllMonsterNextFrame()
	{
		TimerSystem.Instance.Next(delegate(float _)
		{
			List<ISurvivorsRogueCombatInfo> list = new List<ISurvivorsRogueCombatInfo>();
			this.GetModel().GetAllEntities(list);
			foreach (ISurvivorsRogueCombatInfo survivorsRogueCombatInfo in list)
			{
				if (survivorsRogueCombatInfo.EntityType == ESurvivorsRogueEntityType.Monster)
				{
					KuroSimpleCombatController.Instance.RemoveEntityByReasonType((long)survivorsRogueCombatInfo.Uid, EKscEntityRemoveReasonType.Dead);
				}
				else if (survivorsRogueCombatInfo.EntityType == ESurvivorsRogueEntityType.GoldenCoin)
				{
					KuroSimpleCombatController.Instance.RemoveEntityByReasonType((long)survivorsRogueCombatInfo.Uid, EKscEntityRemoveReasonType.Destroy);
				}
				else if (survivorsRogueCombatInfo.EntityType == ESurvivorsRogueEntityType.Weapon)
				{
					KuroSimpleCombatController.Instance.RemoveEntityByReasonType((long)survivorsRogueCombatInfo.Uid, EKscEntityRemoveReasonType.Destroy);
				}
			}
		}, null, null);
	}

	// Token: 0x06005E2B RID: 24107 RVA: 0x00115F92 File Offset: 0x00114192
	protected override void CreateEntityFilter()
	{
		this.RedirectFilter = this.EntityRedirectFilter;
	}

	// Token: 0x06005E2C RID: 24108 RVA: 0x00115FA0 File Offset: 0x001141A0
	[NullableContext(2)]
	protected override EntityHandle GetPossessedPlayerEntity()
	{
		return this.PlayerEntityHandle;
	}

	// Token: 0x06005E2D RID: 24109 RVA: 0x00115FA8 File Offset: 0x001141A8
	protected override bool AddInputLayer()
	{
		SurvivorsRogueInputLayer survivorsRogueInputLayer = this.GetInputLayer();
		if (survivorsRogueInputLayer != null)
		{
			this.RemoveInputLayer();
		}
		survivorsRogueInputLayer = (InputController.Instance.CreateInputLayer(EInputLayer.SurvivorsRogue) as SurvivorsRogueInputLayer);
		if (survivorsRogueInputLayer != null)
		{
			EntityHandle possessedPlayerEntity = this.GetPossessedPlayerEntity();
			if (possessedPlayerEntity != null)
			{
				InputController.Instance.AddInputLayer(possessedPlayerEntity.Id, survivorsRogueInputLayer);
			}
			else
			{
				KscLog.Error(KscLog.EModule.Input, ELogAuthor.HXY, KscEnv.Instance.KscWorld, "幸存者肉鸽输入层加入异常,无法绑定实体", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return true;
		}
		KscLog.Error(KscLog.EModule.Input, ELogAuthor.HXY, KscEnv.Instance.KscWorld, "幸存者肉鸽输入层加入异常", default(ReadOnlySpan<ValueTuple<string, object>>));
		return false;
	}

	// Token: 0x06005E2E RID: 24110 RVA: 0x0011603C File Offset: 0x0011423C
	protected override bool RemoveInputLayer()
	{
		SurvivorsRogueInputLayer inputLayer = this.GetInputLayer();
		if (inputLayer != null)
		{
			InputController.Instance.RemoveInputLayer(inputLayer);
			inputLayer.Clear();
			return true;
		}
		KscLog.Error(KscLog.EModule.Input, ELogAuthor.HXY, KscEnv.Instance.KscWorld, "幸存者肉鸽输入层移除异常", default(ReadOnlySpan<ValueTuple<string, object>>));
		return false;
	}

	// Token: 0x06005E2F RID: 24111 RVA: 0x00116088 File Offset: 0x00114288
	[NullableContext(2)]
	private SurvivorsRogueInputLayer GetInputLayer()
	{
		EntityHandle possessedPlayerEntity = this.GetPossessedPlayerEntity();
		if (possessedPlayerEntity != null)
		{
			return InputController.Instance.GetInputLayer(possessedPlayerEntity.Id, EInputLayer.SurvivorsRogue) as SurvivorsRogueInputLayer;
		}
		return null;
	}

	// Token: 0x06005E30 RID: 24112 RVA: 0x001160B8 File Offset: 0x001142B8
	protected override void AddKscPlayerEntity()
	{
		this.AddInputLayer();
	}

	// Token: 0x06005E31 RID: 24113 RVA: 0x001160C4 File Offset: 0x001142C4
	public override void OnPlayerEntityCreated()
	{
		base.OnPlayerEntityCreated();
		SurvivorsRogueSubModel model = this.GetModel();
		KscSubModelBase kscSubModelBase = model;
		AKSC_Entity kscPlayerEntity = model.KscPlayerEntity;
		kscSubModelBase.KscPlayerEntityId = ((kscPlayerEntity != null) ? kscPlayerEntity.EntityId_ : 0);
		int killComboStage = model.KillComboStage;
		if (killComboStage <= 0)
		{
			return;
		}
		SurvivorsCombo? curComboConfig = SurvivorsRogueModel.Instance.CurComboConfig;
		if (curComboConfig == null)
		{
			return;
		}
		int num = curComboConfig.Value.GetPlayerBuffIdsArray()[killComboStage - 1];
		if (num != 0 && model.KscPlayerEntity != null)
		{
			KuroSimpleCombatController.Instance.ModifyBuffAsync(model.KscPlayerEntity.EntityId_, true, num);
		}
	}

	// Token: 0x06005E32 RID: 24114 RVA: 0x00116150 File Offset: 0x00114350
	protected override void SyncPlayerTransform()
	{
		if (this.GetModel().KscPlayerEntity == null && this.GetModel().WeaponKscEntities.Count <= 0)
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
		if (kscPlayerEntity != null)
		{
			kscPlayerEntity.SetTransformByWorld(ftransformDouble);
		}
		foreach (AKSC_Entity aksc_Entity in this.GetModel().WeaponKscEntities)
		{
			aksc_Entity.SetTransformByWorld(ftransformDouble);
		}
	}

	// Token: 0x06005E33 RID: 24115 RVA: 0x00116214 File Offset: 0x00114414
	public void OnWeaponCreated(AKSC_Entity kscEntity)
	{
		SurvivorsRogueSubModel model = this.GetModel();
		model.WeaponKscEntities.Add(kscEntity);
		int killComboStage = model.KillComboStage;
		if (killComboStage <= 0)
		{
			return;
		}
		SurvivorsCombo? curComboConfig = SurvivorsRogueModel.Instance.CurComboConfig;
		if (curComboConfig == null)
		{
			return;
		}
		int num = curComboConfig.Value.GetWeaponBuffIdsArray()[killComboStage - 1];
		if (num != 0)
		{
			KuroSimpleCombatController.Instance.ModifyBuffAsync(kscEntity.EntityId_, true, num);
		}
	}

	// Token: 0x06005E34 RID: 24116 RVA: 0x0011627C File Offset: 0x0011447C
	public void ExecSkillAction()
	{
		AKSC_Entity kscPlayerEntity = this.SubModel.KscPlayerEntity;
		if (kscPlayerEntity == null)
		{
			return;
		}
		int num = 0;
		UKSC_SkillComp skillComp = kscPlayerEntity.GetSkillComp();
		TArray<UKSC_Skill> tarray = (skillComp != null) ? skillComp.Skills_ : null;
		if (tarray == null)
		{
			return;
		}
		if (tarray.Num() <= num)
		{
			return;
		}
		if (this.SkillCdComp == null)
		{
			return;
		}
		int skillId = 220003;
		if (this.SkillCdComp.IsSkillInCd(skillId, true))
		{
			return;
		}
		UKSC_Skill uksc_Skill = tarray.Get(num);
		if (uksc_Skill.GetSkillCoolDownRemain() > 0f)
		{
			return;
		}
		kscPlayerEntity.TryActiveSKill(num);
		float skillCoolDownMax = uksc_Skill.GetSkillCoolDownMax();
		this.SkillCdComp.ModifyCdInfo(skillId, skillCoolDownMax);
		this.SkillCdComp.StartCd(skillId, new ESkillGenre[]
		{
			ESkillGenre.破弱技能13
		});
		if (this.SkillComp != null)
		{
			SurvivorsRoleGainData roleGainData = SurvivorsRogueModel.Instance.GainData.GetRoleGainData();
			int? num2 = (roleGainData != null) ? new int?(roleGainData.GetCurrentEvolveId()) : null;
			if (num2 != null)
			{
				Aki.Config.SurvivorsRoleEvolve? survivorsRoleEvolve;
				int? num3 = (SurvivorsRogueConfig.Instance.GetSurvivorsRoleEvolve(num2.Value) != null) ? new int?(survivorsRoleEvolve.GetValueOrDefault().SkillId) : null;
				if (num3 != null)
				{
					this.SkillComp.BeginSkillAsync(num3.Value, null);
				}
			}
		}
	}

	// Token: 0x06005E35 RID: 24117 RVA: 0x001163C8 File Offset: 0x001145C8
	private void AddTreeListener()
	{
		BehaviorTreeUpdateDelegateProxy behaviorDelegate = SurvivorsRogueModel.Instance.BattleData.BehaviorDelegate;
		this.AddTreeVarUpdateDelegate(behaviorDelegate, ESurvivorsRougeSystemVarType.Gold.ToEnumString(), new TTreeVarUpdateDelegate(this.OnSurvivorsCurrencyUpdate));
		this.AddTreeVarUpdateDelegate(behaviorDelegate, ESurvivorsRougeSystemVarType.ConsecutiveKillCount.ToEnumString(), new TTreeVarUpdateDelegate(this.OnSurvivorsComboUpdate));
	}

	// Token: 0x06005E36 RID: 24118 RVA: 0x00116418 File Offset: 0x00114618
	private void AddTreeVarUpdateDelegate(BehaviorTreeUpdateDelegateProxy behaviorDelegate, string key, TTreeVarUpdateDelegate delegate_)
	{
		behaviorDelegate.AddTreeVarUpdateDelegate(key, delegate_);
		VarDefinePb behaviorTreeVar = behaviorDelegate.GetBehaviorTreeVar(key);
		if (behaviorTreeVar != null)
		{
			delegate_(null, behaviorTreeVar);
		}
	}

	// Token: 0x06005E37 RID: 24119 RVA: 0x00116440 File Offset: 0x00114640
	private void RemoveTreeListener()
	{
		BehaviorTreeUpdateDelegateProxy behaviorDelegate = SurvivorsRogueModel.Instance.BattleData.BehaviorDelegate;
		behaviorDelegate.RemoveTreeVarUpdateDelegate(ESurvivorsRougeSystemVarType.Gold.ToEnumString(), new TTreeVarUpdateDelegate(this.OnSurvivorsCurrencyUpdate));
		behaviorDelegate.RemoveTreeVarUpdateDelegate(ESurvivorsRougeSystemVarType.ConsecutiveKillCount.ToEnumString(), new TTreeVarUpdateDelegate(this.OnSurvivorsComboUpdate));
	}

	// Token: 0x06005E38 RID: 24120 RVA: 0x00116480 File Offset: 0x00114680
	private void OnSurvivorsCurrencyUpdate([Nullable(2)] VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
	{
		int num = (int)MathUtils.Instance.LongToNumber(newVarDefine.Int);
		if (this.GetModel().GoldNum != num)
		{
			this.GetModel().GoldNum = num;
			UKSC_World kscWorld = KscEnv.Instance.KscWorld;
			if (kscWorld == null)
			{
				return;
			}
			kscWorld.SetWorldAttr(EKSC_WorldAttrType.Gold, num);
		}
	}

	// Token: 0x06005E39 RID: 24121 RVA: 0x001164D0 File Offset: 0x001146D0
	private void OnSurvivorsComboUpdate([Nullable(2)] VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
	{
		int newCombo = (int)MathUtils.Instance.LongToNumber(newVarDefine.Int);
		this.RefreshCombo(newCombo);
	}

	// Token: 0x06005E3A RID: 24122 RVA: 0x001164F8 File Offset: 0x001146F8
	private void RefreshCombo(int newCombo)
	{
		SurvivorsCombo? curComboConfig = SurvivorsRogueModel.Instance.CurComboConfig;
		if (curComboConfig == null)
		{
			KscLog.Error(KscLog.EModule.Common, ELogAuthor.CFT, KscEnv.Instance.KscWorld, "幸存者获取连杀配置失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		int num = 0;
		int[] comboNumArray = curComboConfig.Value.GetComboNumArray();
		if (comboNumArray != null)
		{
			for (int i = 0; i <= comboNumArray.Length; i++)
			{
				if (newCombo < comboNumArray[i])
				{
					num = i;
					break;
				}
			}
		}
		SurvivorsRogueSubModel model = this.GetModel();
		int killComboStage = model.KillComboStage;
		if (killComboStage == num)
		{
			return;
		}
		if (killComboStage > 0)
		{
			int num2 = curComboConfig.Value.GetPlayerBuffIdsArray()[killComboStage - 1];
			if (num2 != 0 && model.KscPlayerEntity != null)
			{
				KuroSimpleCombatController.Instance.ModifyBuffAsync(model.KscPlayerEntity.EntityId_, false, num2);
			}
			int num3 = curComboConfig.Value.GetWeaponBuffIdsArray()[killComboStage - 1];
			if (num3 != 0)
			{
				foreach (AKSC_Entity aksc_Entity in model.WeaponKscEntities)
				{
					KuroSimpleCombatController.Instance.ModifyBuffAsync(aksc_Entity.EntityId_, false, num3);
				}
			}
		}
		if (num > 0)
		{
			int num4 = curComboConfig.Value.GetPlayerBuffIdsArray()[num - 1];
			if (num4 != 0 && model.KscPlayerEntity != null)
			{
				KuroSimpleCombatController.Instance.ModifyBuffAsync(model.KscPlayerEntity.EntityId_, true, num4);
			}
			int num5 = curComboConfig.Value.GetWeaponBuffIdsArray()[num - 1];
			if (num5 != 0)
			{
				foreach (AKSC_Entity aksc_Entity2 in model.WeaponKscEntities)
				{
					KuroSimpleCombatController.Instance.ModifyBuffAsync(aksc_Entity2.EntityId_, true, num5);
				}
			}
		}
		model.KillComboStage = num;
	}

	// Token: 0x06005E3B RID: 24123 RVA: 0x001166EC File Offset: 0x001148EC
	protected override void OnHandlePlayerHeadHpInfo(KscHeadStateData kscPlayerHeadStateData, FKSC_HeadHpContext headInfo)
	{
		base.OnHandlePlayerHeadHpInfo(kscPlayerHeadStateData, headInfo);
		this.PlayerHpHandle.OnPlayerHpChange(kscPlayerHeadStateData);
	}

	// Token: 0x06005E3C RID: 24124 RVA: 0x00116704 File Offset: 0x00114904
	public override void GmPrintInfo()
	{
		SurvivorsRogueSubModel model = this.GetModel();
		List<string> list = new List<string>
		{
			"[ksc]幸存者玩法"
		};
		List<string> list2 = list;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
		defaultInterpolatedStringHandler.AppendLiteral("玩家 EntityId:");
		defaultInterpolatedStringHandler.AppendFormatted<int>(model.KscPlayerEntityId);
		defaultInterpolatedStringHandler.AppendLiteral(", 服务端Id:");
		defaultInterpolatedStringHandler.AppendFormatted<long>(model.KscPlayerCreatureDataId);
		list2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
		foreach (AKSC_Entity aksc_Entity in model.WeaponKscEntities)
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

	// Token: 0x04002AD4 RID: 10964
	[Nullable(2)]
	private EntityHandle PlayerEntityHandle;

	// Token: 0x04002AD5 RID: 10965
	[Nullable(2)]
	private CharacterSkillCdComponent SkillCdComp;

	// Token: 0x04002AD6 RID: 10966
	[Nullable(2)]
	private CharacterSkillComponent SkillComp;

	// Token: 0x04002AD7 RID: 10967
	private readonly SurvivorsRogueEntityRedirectFilter EntityRedirectFilter = new SurvivorsRogueEntityRedirectFilter();

	// Token: 0x04002AD8 RID: 10968
	private readonly ActivityPlayerHpHandle PlayerHpHandle = new ActivityPlayerHpHandle();
}
