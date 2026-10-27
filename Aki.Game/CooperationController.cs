using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.DeadRevive;

// Token: 0x020016FD RID: 5885
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class CooperationController : ControllerBase
{
	// Token: 0x0600A8CB RID: 43211 RVA: 0x0025FB94 File Offset: 0x0025DD94
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

	// Token: 0x0600A8CC RID: 43212 RVA: 0x0025FC34 File Offset: 0x0025DE34
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

	// Token: 0x0600A8CD RID: 43213 RVA: 0x0025FF5C File Offset: 0x0025E15C
	private void CooperateAction(SceneTeamItem goDownRole, SceneTeamItem goBattleRole)
	{
		ICooperationHandler[] handlers = CooperationModel.Instance.GetHandlers();
		int num = 0;
		while (num < handlers.Length && !handlers[num].Trigger(goDownRole, goBattleRole))
		{
			num++;
		}
	}

	// Token: 0x17000DFB RID: 3579
	// (get) Token: 0x0600A8CE RID: 43214 RVA: 0x0025FF8E File Offset: 0x0025E18E
	public static CooperationController Instance
	{
		get
		{
			return CooperationController._Instance;
		}
	}

	// Token: 0x0600A8CF RID: 43215 RVA: 0x0025FF95 File Offset: 0x0025E195
	public static CooperationController GetOrCreateInstance()
	{
		if (CooperationController._Instance == null)
		{
			CooperationController.CreateInstance();
		}
		return CooperationController._Instance;
	}

	// Token: 0x0600A8D0 RID: 43216 RVA: 0x0025FFA9 File Offset: 0x0025E1A9
	public static bool CreateInstance()
	{
		if (CooperationController._Instance != null)
		{
			return true;
		}
		CooperationController._Instance = new CooperationController();
		return true;
	}

	// Token: 0x0600A8D1 RID: 43217 RVA: 0x0025FFBF File Offset: 0x0025E1BF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600A8D2 RID: 43218 RVA: 0x0025FFC1 File Offset: 0x0025E1C1
	public static void ResetStaticDefaultValue()
	{
		CooperationController._Instance = null;
	}

	// Token: 0x0600A8D3 RID: 43219 RVA: 0x0025FFC9 File Offset: 0x0025E1C9
	static CooperationController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CooperationController.CreateStaticDefaultValue), new Action(CooperationController.ResetStaticDefaultValue));
	}

	// Token: 0x04004D09 RID: 19721
	[Nullable(2)]
	private static CooperationController _Instance;
}
