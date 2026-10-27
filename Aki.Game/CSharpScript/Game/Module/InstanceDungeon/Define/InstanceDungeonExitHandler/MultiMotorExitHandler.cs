using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020058F6 RID: 22774
	public class MultiMotorExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x06039D2C RID: 236844 RVA: 0x00DBC084 File Offset: 0x00DBA284
		public override bool Checker()
		{
			MultiMotorController instance = MultiMotorController.Instance;
			return instance != null && instance.CheckInMultiMotorParkourDungeon();
		}

		// Token: 0x06039D2D RID: 236845 RVA: 0x00DBC0A0 File Offset: 0x00DBA2A0
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
