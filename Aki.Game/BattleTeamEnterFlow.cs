using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Module.InstanceDungeon;

// Token: 0x020010BA RID: 4282
[NullableContext(1)]
[Nullable(0)]
public class BattleTeamEnterFlow
{
	// Token: 0x0600A9C8 RID: 43464 RVA: 0x003202FC File Offset: 0x0031E4FC
	public static void Execute(IBattleTeamEnterContext ctx)
	{
		BattleTeamModel instance = BattleTeamModel.Instance;
		int ownRoleCountInRoleSlot = instance.OwnRoleCountInRoleSlot;
		if (ownRoleCountInRoleSlot == 0)
		{
			ScrollingTipsController.Instance.ShowTipsById("NoRole", Array.Empty<object>());
			return;
		}
		if (!instance.Context.IsInLimitRoleCount(ownRoleCountInRoleSlot))
		{
			ScrollingTipsController.Instance.ShowTipsById("LimitCount", Array.Empty<object>());
			return;
		}
		if (instance.Context.IsMultiInstanceDungeon)
		{
			if (instance.IsLeaderSelf)
			{
				BattleTeamEnterFlow.EnterAsLeader(ctx);
				return;
			}
			BattleTeamEnterFlow.EnterAsMember();
			return;
		}
		else
		{
			if (TowerModel.Instance.IsOpenFloorFormation())
			{
				BattleTeamEnterFlow.EnterAsTower();
				return;
			}
			BattleTeamEnterFlow.EnterAsSolo(ctx);
			return;
		}
	}

	// Token: 0x0600A9C9 RID: 43465 RVA: 0x0032038C File Offset: 0x0031E58C
	private static void EnterAsLeader(IBattleTeamEnterContext ctx)
	{
		BattleTeamModel instance = BattleTeamModel.Instance;
		if (InstanceDungeonEntranceModel.Instance.EditBattleTeamMatching)
		{
			InstanceDungeonEntranceModel.Instance.SetEditBattleTeamMatching(false);
			ctx.RefreshConfirm();
			InstanceDungeonEntranceController.Instance.SetMatchTeamMatchFlagRequest(InstanceDungeonEntranceModel.Instance.EditBattleTeamMatching);
			return;
		}
		if (!instance.IsAllReady)
		{
			ScrollingTipsController.Instance.ShowTipsById("NoReady", Array.Empty<object>());
			return;
		}
		if (instance.HasSameRole && !TowerDefenseController.Instance.CheckInUiFlow() && !DangoAbyssModel.Instance.CheckInAbyssEditFormationState() && !MultiMotorModel.Instance.CheckInMultiMotorEditFormationState())
		{
			ScrollingTipsController.Instance.ShowTipsById("SameRole", Array.Empty<object>());
			return;
		}
		if (!instance.GetAllRoleCanAddToTeam().Item1)
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(instance.Context.GetFightFormation().Value.Content, null);
			ScrollingTipsController.Instance.ShowTipsByText(localTextNew);
			return;
		}
		if (instance.IsAllRoleDie)
		{
			ScrollingTipsController.Instance.ShowTipsById("AllRoleDie", Array.Empty<object>());
			return;
		}
		if (InstanceDungeonModel.Instance.MatchingPlayerCount() > 2)
		{
			BattleTeamEnterFlow.TeamLeaderEnterMatchInstRequest();
			return;
		}
		if (instance.Context.IsMatchingTeamLackConfirmBoxCanEnterInstance())
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.MatchingTeamLack);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				BattleTeamEnterFlow.TeamLeaderEnterMatchInstRequest();
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		ConfirmBoxController.Instance.ShowConfirmBoxNew(new ConfirmBoxDataNew(EConfirmBoxConfigId.MatchingTeamLackButNoEnter));
	}

	// Token: 0x0600A9CA RID: 43466 RVA: 0x00320508 File Offset: 0x0031E708
	private unsafe static void EnterAsMember()
	{
		BattleTeamModel instance = BattleTeamModel.Instance;
		bool isSelfReady = instance.IsSelfReady;
		int? id = PlayerInfoModel.Instance.GetId();
		if (!isSelfReady && instance.HasSameRole && !TowerDefenseController.Instance.CheckInUiFlow() && !DangoAbyssModel.Instance.CheckInAbyssEditFormationState() && !MultiMotorModel.Instance.CheckInMultiMotorEditFormationState())
		{
			ScrollingTipsController.Instance.ShowTipsById("SameRole", Array.Empty<object>());
			return;
		}
		Log instance2 = Log.Instance;
		ELogModule module = ELogModule.Formation;
		ELogAuthor author = ELogAuthor.SYB;
		string message = "[BattleTeam2D]玩家{PlayerId} 请求准备游戏,是否准备:{SelfIsReady}";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("{PlayerId}", id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("{SelfIsReady}", !isSelfReady);
		instance2.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		InstanceDungeonEntranceController.Instance.MatchChangeReadyRequest(!isSelfReady);
	}

	// Token: 0x0600A9CB RID: 43467 RVA: 0x003205E0 File Offset: 0x0031E7E0
	private static void EnterAsSolo(IBattleTeamEnterContext ctx)
	{
		BattleTeamModel instance = BattleTeamModel.Instance;
		if (!instance.IsAllReady)
		{
			ScrollingTipsController.Instance.ShowTipsById("NoReady", Array.Empty<object>());
			return;
		}
		if (instance.HasSameRole)
		{
			ScrollingTipsController.Instance.ShowTipsById("SameRole", Array.Empty<object>());
			return;
		}
		if (!LordGymController.Instance.IsInLordGymDungeon() && !TowerModel.Instance.IsOpenFloorFormation() && instance.IsAllRoleDie)
		{
			ScrollingTipsController.Instance.ShowTipsById("AllRoleDie", Array.Empty<object>());
			return;
		}
		if (!instance.GetAllRoleCanAddToTeam().Item1)
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(instance.Context.GetFightFormation().Value.Content, null);
			ScrollingTipsController.Instance.ShowTipsByText(localTextNew);
			return;
		}
		if (WeeklyRogueModel.Instance.IsWeeklyRogueOpen())
		{
			WeeklyRogueController weeklyRogueController = ActivityManager.GetActivityController(ActivityType.RogueWeekly) as WeeklyRogueController;
			List<int> item = instance.OwnRoleConfigIdList.Item1;
			if (weeklyRogueController == null)
			{
				return;
			}
			weeklyRogueController.RogueWeeklyStartRequest(item);
			return;
		}
		else
		{
			if (!ctx.CanUseSpecialTrialRole && instance.HasSpecialTrialRole)
			{
				ScrollingTipsController.Instance.ShowTipsById("EditBattleTeamForbidTrialRole", Array.Empty<object>());
				return;
			}
			BattleTeamEnterFlow.EnterButtonSoloBegin();
			return;
		}
	}

	// Token: 0x0600A9CC RID: 43468 RVA: 0x003206FC File Offset: 0x0031E8FC
	private static void EnterAsTower()
	{
		BattleTeamModel instance = BattleTeamModel.Instance;
		if (!instance.IsAllReady)
		{
			ScrollingTipsController.Instance.ShowTipsById("NoReady", Array.Empty<object>());
			return;
		}
		if (instance.HasSameRole)
		{
			ScrollingTipsController.Instance.ShowTipsById("SameRole", Array.Empty<object>());
			return;
		}
		if (!instance.GetAllRoleCanAddToTeam().Item1)
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(instance.Context.GetFightFormation().Value.Content, null);
			ScrollingTipsController.Instance.ShowTipsByText(localTextNew);
			return;
		}
		TowerController.Instance.TowerStartRequest(TowerModel.Instance.CurrentSelectFloor, instance.OwnRoleConfigIdList.Item1, true);
	}

	// Token: 0x0600A9CD RID: 43469 RVA: 0x003207A8 File Offset: 0x0031E9A8
	private static void EnterButtonSoloBegin()
	{
		BattleTeamModel instance = BattleTeamModel.Instance;
		if (instance.NeedEntrance)
		{
			InstanceDungeonEntranceController.Instance.ContinueEntranceFlow();
			return;
		}
		instance.NeedEntrance = true;
		List<int> item = instance.OwnRoleConfigIdList.Item1;
		if (instance.IsFormTeleportAction)
		{
			instance.IsFormTeleportAction = false;
			InstanceDungeonController.Instance.TeleportDungeonRequest(item, true);
			return;
		}
		IFastReturnDungeonContext fastReturnDungeonContext = instance.FastReturnDungeonContext;
		if (fastReturnDungeonContext != null)
		{
			instance.FastReturnDungeonContext = null;
			GeneralLogicTreeController.Instance.RequestFastReturnDungeon(fastReturnDungeonContext.TreeIncId, fastReturnDungeonContext.NodeId, fastReturnDungeonContext.IsContinue, item, delegate(bool _)
			{
			});
			return;
		}
		InstanceDungeonController.Instance.PrewarTeamFightRequest(InstanceDungeonEntranceModel.Instance.InstanceId, item, InstanceDungeonEntranceModel.Instance.EntranceId, 0, InstanceDungeonEntranceModel.Instance.TransitionOption, TowerDefenseModel.Instance.GetProtocolPhantomIdList(item));
	}

	// Token: 0x0600A9CE RID: 43470 RVA: 0x00320884 File Offset: 0x0031EA84
	private static void TeamLeaderEnterMatchInstRequest()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Formation;
		ELogAuthor author = ELogAuthor.SYB;
		string message = "[BattleTeam2D]队长{PlayerId} 请求进入副本";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("{PlayerId}", PlayerInfoModel.Instance.GetId());
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		InstanceDungeonEntranceController.Instance.EnterMatchInstRequest().Then(delegate(bool bSuccess)
		{
			if (bSuccess)
			{
				FormationController.Instance.CloseBattleTeamView();
			}
		});
	}
}
