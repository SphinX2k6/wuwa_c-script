using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.UI.Manager;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020034D5 RID: 13525
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class BattleLogicController : ControllerBase
{
	// Token: 0x0601D8D2 RID: 121042 RVA: 0x0083F0C8 File Offset: 0x0083D2C8
	[CombatListen(ENotifyMessageId.EntityLivingStatusNotify, true, false)]
	public static void ExecuteEntityLivingStatus(Entity entity, EntityLivingStatusNotify notify, [Nullable(2)] CombatCommon combatCommon = null)
	{
		EntityHandle entityById = CreatureModel.Instance.GetEntityById(entity.Id);
		if (entityById == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.ZQR;
			string message = "[CreatureController.EntityLivingStatusNotify] EntityLivingStatusNotify失败, Entity无效或不存在。";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CreatureDataId", notify.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		long value = MathUtils.Instance.LongToBigInt((combatCommon != null) ? combatCommon.MessageId : 0L);
		MathUtils.Instance.LongToBigInt((combatCommon != null) ? combatCommon.PreMessageId : 0L);
		switch (notify.LivingStatus)
		{
		case LivingStatus.Alive:
			BattleLogicController.ExecuteReviveLogic(entityById);
			break;
		case LivingStatus.Dead:
		{
			BattleLogicController.BroadcastDead(entityById);
			bool flag = false;
			for (int i = 0; i < notify.DropVisionItem.Count; i++)
			{
				DropVisionItemResult dropVisionItemResult = notify.DropVisionItem[i];
				if (dropVisionItemResult.Drop)
				{
					int playerId = dropVisionItemResult.PlayerId;
					int? id = PlayerInfoModel.Instance.GetId();
					if (playerId == id.GetValueOrDefault() & id != null)
					{
						CharacterAttachComponent component = entity.GetComponent<CharacterAttachComponent>();
						if (component != null)
						{
							component.DetachFromHost(true, false, false, null);
						}
						entity.Disable("[BattleLogicController.BattleLogicController] 被收服的Entity先隐藏");
						flag = true;
						EventSystem.Instance.Emit<int>(EEventName.CharOnRoleDead, entity.Id);
						EventSystem.Instance.EmitWithTarget(entity, EEventName.CharOnRoleDeadTargetSelf);
					}
				}
			}
			if (!flag)
			{
				BaseDeathComponent component2 = entity.GetComponent<BaseDeathComponent>();
				if (component2 == null)
				{
					return;
				}
				component2.ExecuteDeath(new long?(value));
				return;
			}
			break;
		}
		case LivingStatus.Init:
			break;
		default:
			return;
		}
	}

	// Token: 0x0601D8D3 RID: 121043 RVA: 0x0083F244 File Offset: 0x0083D444
	public static void OnEntityLivingStatusNotify(EntityLivingStatusNotify notify)
	{
		EntityHandle entity = CreatureModel.Instance.GetEntity(MathUtils.Instance.LongToNumber(notify.Id));
		if (entity == null || !entity.Valid || entity.Entity == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.ZQR;
			string message = "[CreatureController.EntityLivingStatusNotify] EntityLivingStatusNotify失败, Entity无效或不存在。";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CreatureDataId", notify.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		BattleLogicController.ExecuteEntityLivingStatus(entity.Entity, notify, null);
	}

	// Token: 0x0601D8D4 RID: 121044 RVA: 0x0083F2C0 File Offset: 0x0083D4C0
	private static void ExecuteReviveLogic(EntityHandle handle)
	{
		if (!handle.Valid)
		{
			return;
		}
		if (!handle.IsInit)
		{
			WorldEntity entity = handle.Entity;
			CreatureDataComponent creatureDataComponent = (entity != null) ? entity.GetComponent<CreatureDataComponent>() : null;
			if (creatureDataComponent == null)
			{
				return;
			}
			creatureDataComponent.SetLivingStatus(LivingStatus.Alive);
			return;
		}
		else
		{
			WorldEntity entity2 = handle.Entity;
			if (entity2 == null)
			{
				return;
			}
			RoleDeathComponent component = entity2.GetComponent<RoleDeathComponent>();
			if (component == null)
			{
				return;
			}
			component.ExecuteRevive();
			return;
		}
	}

	// Token: 0x0601D8D5 RID: 121045 RVA: 0x0083F318 File Offset: 0x0083D518
	private static void BroadcastDead(EntityHandle handle)
	{
		BaseActorComponent component = handle.Entity.GetComponent<BaseActorComponent>();
		AActor aactor = (component != null) ? component.Owner : null;
		BP_EventManager_C bpEventManager = GlobalData.BpEventManager;
		if (bpEventManager == null)
		{
			return;
		}
		当有角色死亡时 当有角色死亡时 = bpEventManager.当有角色死亡时;
		if (当有角色死亡时 == null)
		{
			return;
		}
		当有角色死亡时.Broadcast(aactor as TsBaseCharacter);
	}

	// Token: 0x170028DD RID: 10461
	// (get) Token: 0x0601D8D6 RID: 121046 RVA: 0x0083F35C File Offset: 0x0083D55C
	public static BattleLogicController Instance
	{
		get
		{
			return BattleLogicController._Instance;
		}
	}

	// Token: 0x0601D8D7 RID: 121047 RVA: 0x0083F363 File Offset: 0x0083D563
	public static BattleLogicController GetOrCreateInstance()
	{
		if (BattleLogicController._Instance == null)
		{
			BattleLogicController.CreateInstance();
		}
		return BattleLogicController._Instance;
	}

	// Token: 0x0601D8D8 RID: 121048 RVA: 0x0083F377 File Offset: 0x0083D577
	public static bool CreateInstance()
	{
		if (BattleLogicController._Instance != null)
		{
			return true;
		}
		BattleLogicController._Instance = new BattleLogicController();
		return true;
	}

	// Token: 0x0601D8D9 RID: 121049 RVA: 0x0083F38D File Offset: 0x0083D58D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601D8DA RID: 121050 RVA: 0x0083F38F File Offset: 0x0083D58F
	public static void ResetStaticDefaultValue()
	{
		BattleLogicController._Instance = null;
	}

	// Token: 0x0601D8DB RID: 121051 RVA: 0x0083F398 File Offset: 0x0083D598
	static BattleLogicController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BattleLogicController.CreateStaticDefaultValue), new Action(BattleLogicController.ResetStaticDefaultValue));
	}

	// Token: 0x0400E82A RID: 59434
	[StaticVariableRuleIgnore]
	private static readonly Stat BroadcastDeadStat = Stat.Create("BattleLogicController.BroadcastDeadStat", "", "STATGROUP_KuroBattle");

	// Token: 0x0400E82B RID: 59435
	[StaticVariableRuleIgnore]
	private static readonly Stat DisableEntityStat = Stat.Create("BattleLogicController.DisableEntityStat", "", "STATGROUP_KuroBattle");

	// Token: 0x0400E82C RID: 59436
	[StaticVariableRuleIgnore]
	private static readonly Stat ExecuteDeadLogicStat = Stat.Create("BattleLogicController.ExecuteDeadLogicStat", "", "STATGROUP_KuroBattle");

	// Token: 0x0400E82D RID: 59437
	[StaticVariableRuleIgnore]
	private static readonly Stat ExecuteReviveLogicStat = Stat.Create("BattleLogicController.ExecuteReviveLogicStat", "", "STATGROUP_KuroBattle");

	// Token: 0x0400E82E RID: 59438
	[Nullable(2)]
	private static BattleLogicController _Instance;
}
