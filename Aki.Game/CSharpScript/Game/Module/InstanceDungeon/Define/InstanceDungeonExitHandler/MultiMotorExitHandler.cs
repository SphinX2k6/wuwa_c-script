using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020048CE RID: 18638
	public class MultiMotorExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x0602EC4F RID: 191567 RVA: 0x00D0AFE8 File Offset: 0x00D091E8
		public override bool Checker()
		{
			MultiMotorController instance = MultiMotorController.Instance;
			return instance != null && instance.CheckInMultiMotorParkourDungeon();
		}

		// Token: 0x0602EC50 RID: 191568 RVA: 0x00D0B004 File Offset: 0x00D09204
		[NullableContext(2)]
		public override void HandleExit(InstanceDungeonExitHandlerData data)
		{
			if (!GameModeModel.Instance.IsMulti)
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.BattleViewLeaveInstance);
				confirmBoxDataNew.IsEscViewTriggerCallBack = false;
				confirmBoxDataNew.FunctionMap[2] = delegate()
				{
					InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon();
				};
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			if (OnlineModel.Instance.GetIsMyTeam())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("MultiMotorHostCannotExit", Array.Empty<object>());
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew2 = new ConfirmBoxDataNew(EConfirmBoxConfigId.BattleViewLeaveInstance);
			confirmBoxDataNew2.IsEscViewTriggerCallBack = false;
			confirmBoxDataNew2.FunctionMap[2] = delegate()
			{
				OnlineController.Instance.LeaveWorldTeamRequest(PlayerInfoModel.Instance.GetId().GetValueOrDefault(), null);
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew2);
		}
	}
}
