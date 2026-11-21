using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.DeadRevive;

// Token: 0x02000BB5 RID: 2997
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class CooperationController : ControllerBase
{
	// Token: 0x06007CAB RID: 31915 RVA: 0x00269FB0 File Offset: 0x002681B0
	public void FormationInputHandler(string actionName)
	{
		int num = -1;
		if (!(actionName == "切换角色1"))
		{
			if (!(actionName == "切换角色2"))
			{
				if (!(actionName == "切换角色3"))
				{
					if (actionName == "切换角色4")
					{
						num = 4;
					}
				}
				else
				{
					num = 3;
				}
			}
			else
			{
				num = 2;
			}
		}
		else
		{
			num = 1;
		}
		if (num < 0)
		{
			return;
		}
		BattleUiFormationPanelData formationPanelData = BattleUiModel.Instance.FormationPanelData;
		long? num2;
		if (formationPanelData == null)
		{
			num2 = null;
		}
		else
		{
			FormationItemData itemData = formationPanelData.GetItemData(num);
			num2 = ((itemData != null) ? new long?(itemData.CreatureDataId) : null);
		}
		long? num3 = num2;
		long valueOrDefault = num3.GetValueOrDefault();
		this.TryCooperate(valueOrDefault);
	}

	// Token: 0x06007CAC RID: 31916 RVA: 0x0026A050 File Offset: 0x00268250
	public unsafe void TryCooperate(long creatureDataId)
	{
		if (SceneTeamModel.Instance.ChangingRole)
		{
			Log.Instance.Info(ELogModule.SceneTeam, ELogAuthor.LYY, "在换人请求返回前尝试换人", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		SceneTeamModel instance = SceneTeamModel.Instance;
		SceneTeamItem getCurrentTeamItem = instance.GetCurrentTeamItem;
		EntityHandle entityHandle = (getCurrentTeamItem != null) ? getCurrentTeamItem.EntityHandle : null;
		if (entityHandle == null || getCurrentTeamItem.GetCreatureDataId() == creatureDataId)
		{
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.SceneTeam;
			ELogAuthor author = ELogAuthor.LYY;
			string message = "下场角色实体不存在或相同";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CreatureDataId", creatureDataId);
			instance2.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		BaseTagComponent baseTagComponent = entityHandle.Entity.CheckGetComponent<BaseTagComponent>();
		CharacterActionComponent component = entityHandle.Entity.GetComponent<CharacterActionComponent>();
		bool flag = component != null && component.IsSummonSitDownLocked;
		SceneTeamItem teamItem = instance.GetTeamItem(creatureDataId, new GetTeamItemOptions
		{
			ParamType = ETeamParamType.CreatureDataId
		});
		if (((teamItem != null) ? teamItem.EntityHandle : null) == null)
		{
			Log instance3 = Log.Instance;
			ELogModule module2 = ELogModule.SceneTeam;
			ELogAuthor author2 = ELogAuthor.LYY;
			string message2 = "上场角色实体不存在";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("CreatureDataId", creatureDataId);
			instance3.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		if (!teamItem.IsMyRole())
		{
			Log instance4 = Log.Instance;
			ELogModule module3 = ELogModule.SceneTeam;
			ELogAuthor author3 = ELogAuthor.LYY;
			string message3 = "上场角色为其他玩家的角色";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("CreatureDataId", creatureDataId);
			instance4.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			if (teamItem.IsDead())
			{
				DeadReviveController.Instance.CheckOtherPlayerReviveCooldown(teamItem.GetPlayerId(), teamItem.GetCreatureDataId());
				return;
			}
			if (!flag && !baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.BUFF通用标识.不能切人"]))
			{
				this.CooperateAction(getCurrentTeamItem, teamItem);
			}
			return;
		}
		else
		{
			if (baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.濒死"]))
			{
				if (teamItem.IsDead())
				{
					DeadReviveController.Instance.TryReviveRoleWhenCurrentRoleDead(teamItem.GetCreatureDataId(), teamItem.GetConfigId);
				}
				return;
			}
			if (baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.溺水"]))
			{
				return;
			}
			bool flag2 = TowerModel.Instance.CheckInTower();
			bool flag3 = ShipTowerModel.Instance.CheckInBattleShipTower();
			bool flag4 = flag2 || flag3;
			if (flag || baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.BUFF通用标识.不能切人"]))
			{
				if (flag4 && !FormationDataController.Instance.GlobalIsInFight)
				{
					ScrollingTipsController.Instance.ShowTipsById("CannotChangeRoleBeforeStartBattle", Array.Empty<object>());
				}
				return;
			}
			if (instance.CurrentGroupType.GetValueOrDefault() != ETeamGroupType.Battle)
			{
				Log.Instance.Info(ELogModule.SceneTeam, ELogAuthor.LYY, "当前正在非战斗编队组，不能切角色", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (teamItem.IsDead())
			{
				if (SceneTeamModel.Instance.IsAllDid() || flag2)
				{
					if (flag2)
					{
						ScrollingTipsController.Instance.ShowTipsById("InstanceDungeonShieldViewCantOpen", Array.Empty<object>());
					}
					return;
				}
				DeadReviveController.Instance.TryReviveRole(teamItem.GetCreatureDataId(), teamItem.GetConfigId, false);
				return;
			}
			else
			{
				EGoBattleResultType egoBattleResultType = teamItem.CanGoBattle();
				if (egoBattleResultType != EGoBattleResultType.Success)
				{
					Log instance5 = Log.Instance;
					ELogModule module4 = ELogModule.SceneTeam;
					ELogAuthor author4 = ELogAuthor.LYY;
					string message4 = "上场角色无法换人";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Result", egoBattleResultType);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("roleId", teamItem.GetConfigId);
					instance5.Info(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return;
				}
				this.CooperateAction(getCurrentTeamItem, teamItem);
				return;
			}
		}
	}

	// Token: 0x06007CAD RID: 31917 RVA: 0x0026A378 File Offset: 0x00268578
	private void CooperateAction(SceneTeamItem goDownRole, SceneTeamItem goBattleRole)
	{
		ICooperationHandler[] handlers = CooperationModel.Instance.GetHandlers();
		int num = 0;
		while (num < handlers.Length && !handlers[num].Trigger(goDownRole, goBattleRole))
		{
			num++;
		}
	}

	// Token: 0x17000E1C RID: 3612
	// (get) Token: 0x06007CAE RID: 31918 RVA: 0x0026A3AA File Offset: 0x002685AA
	public static CooperationController Instance
	{
		get
		{
			return CooperationController._Instance;
		}
	}

	// Token: 0x06007CAF RID: 31919 RVA: 0x0026A3B1 File Offset: 0x002685B1
	public static CooperationController GetOrCreateInstance()
	{
		if (CooperationController._Instance == null)
		{
			CooperationController.CreateInstance();
		}
		return CooperationController._Instance;
	}

	// Token: 0x06007CB0 RID: 31920 RVA: 0x0026A3C5 File Offset: 0x002685C5
	public static bool CreateInstance()
	{
		if (CooperationController._Instance != null)
		{
			return true;
		}
		CooperationController._Instance = new CooperationController();
		return true;
	}

	// Token: 0x06007CB1 RID: 31921 RVA: 0x0026A3DB File Offset: 0x002685DB
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007CB2 RID: 31922 RVA: 0x0026A3DD File Offset: 0x002685DD
	public static void ResetStaticDefaultValue()
	{
		CooperationController._Instance = null;
	}

	// Token: 0x06007CB3 RID: 31923 RVA: 0x0026A3E5 File Offset: 0x002685E5
	static CooperationController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CooperationController.CreateStaticDefaultValue), new Action(CooperationController.ResetStaticDefaultValue));
	}

	// Token: 0x04004DB0 RID: 19888
	[Nullable(2)]
	private static CooperationController _Instance;
}
