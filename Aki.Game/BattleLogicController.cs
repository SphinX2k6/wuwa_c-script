using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.UI.Manager;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002A49 RID: 10825
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class BattleLogicController : ControllerBase
{
	// Token: 0x0601B5D1 RID: 112081 RVA: 0x00866638 File Offset: 0x00864838
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
			return;
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
		case LivingStatus.Dying:
		{
			BaseDeathComponent component3 = entity.GetComponent<BaseDeathComponent>();
			if (component3 == null)
			{
				return;
			}
			component3.ExecuteDying(new long?(value));
			break;
		}
		default:
			return;
		}
	}

	// Token: 0x0601B5D2 RID: 112082 RVA: 0x008667D0 File Offset: 0x008649D0
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

	// Token: 0x0601B5D3 RID: 112083 RVA: 0x0086684C File Offset: 0x00864A4C
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

	// Token: 0x0601B5D4 RID: 112084 RVA: 0x008668A4 File Offset: 0x00864AA4
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

	// Token: 0x17002C75 RID: 11381
	// (get) Token: 0x0601B5D5 RID: 112085 RVA: 0x008668E8 File Offset: 0x00864AE8
	public static BattleLogicController Instance
	{
		get
		{
			return BattleLogicController._Instance;
		}
	}

	// Token: 0x0601B5D6 RID: 112086 RVA: 0x008668EF File Offset: 0x00864AEF
	public static BattleLogicController GetOrCreateInstance()
	{
		if (BattleLogicController._Instance == null)
		{
			BattleLogicController.CreateInstance();
		}
		return BattleLogicController._Instance;
	}

	// Token: 0x0601B5D7 RID: 112087 RVA: 0x00866903 File Offset: 0x00864B03
	public static bool CreateInstance()
	{
		if (BattleLogicController._Instance != null)
		{
			return true;
		}
		BattleLogicController._Instance = new BattleLogicController();
		return true;
	}

	// Token: 0x0601B5D8 RID: 112088 RVA: 0x00866919 File Offset: 0x00864B19
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601B5D9 RID: 112089 RVA: 0x0086691B File Offset: 0x00864B1B
	public static void ResetStaticDefaultValue()
	{
		BattleLogicController._Instance = null;
	}

	// Token: 0x0601B5DA RID: 112090 RVA: 0x00866924 File Offset: 0x00864B24
	static BattleLogicController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BattleLogicController.CreateStaticDefaultValue), new Action(BattleLogicController.ResetStaticDefaultValue));
	}

	// Token: 0x0400ECDE RID: 60638
	[StaticVariableRuleIgnore]
	private static readonly Stat BroadcastDeadStat = Stat.Create("BattleLogicController.BroadcastDeadStat", "", "STATGROUP_KuroBattle");

	// Token: 0x0400ECDF RID: 60639
	[StaticVariableRuleIgnore]
	private static readonly Stat DisableEntityStat = Stat.Create("BattleLogicController.DisableEntityStat", "", "STATGROUP_KuroBattle");

	// Token: 0x0400ECE0 RID: 60640
	[StaticVariableRuleIgnore]
	private static readonly Stat ExecuteDeadLogicStat = Stat.Create("BattleLogicController.ExecuteDeadLogicStat", "", "STATGROUP_KuroBattle");

	// Token: 0x0400ECE1 RID: 60641
	[StaticVariableRuleIgnore]
	private static readonly Stat ExecuteReviveLogicStat = Stat.Create("BattleLogicController.ExecuteReviveLogicStat", "", "STATGROUP_KuroBattle");

	// Token: 0x0400ECE2 RID: 60642
	[StaticVariableRuleIgnore]
	private static readonly Stat ExecuteDyingStat = Stat.Create("BattleLogicController.ExecuteDyingStat", "", "STATGROUP_KuroBattle");

	// Token: 0x0400ECE3 RID: 60643
	[Nullable(2)]
	private static BattleLogicController _Instance;
}
