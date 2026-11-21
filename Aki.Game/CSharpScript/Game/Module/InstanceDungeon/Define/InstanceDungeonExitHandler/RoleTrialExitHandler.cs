using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020048D2 RID: 18642
	public class RoleTrialExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x0602EC5E RID: 191582 RVA: 0x00D0B2E4 File Offset: 0x00D094E4
		public override bool Checker()
		{
			if (!GameModeController.Instance.IsInInstance())
			{
				return false;
			}
			int instanceId = CreatureModel.Instance.GetInstanceId();
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			return config != null && config.Value.InstSubType == 40;
		}

		// Token: 0x0602EC5F RID: 191583 RVA: 0x00D0B338 File Offset: 0x00D09538
		[NullableContext(2)]
		public override void HandleExit(InstanceDungeonExitHandlerData data)
		{
			RoleTrialExitHandler.<>c__DisplayClass1_0 CS$<>8__locals1 = new RoleTrialExitHandler.<>c__DisplayClass1_0();
			CS$<>8__locals1.data = data;
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(this.IsCyberPunkRoleTrialInstance() ? EConfirmBoxConfigId.CyberPunkRoleTrialExitConfirm : EConfirmBoxConfigId.RoleTrialLeaveInstanceConfirm);
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			Dictionary<int, Action> functionMap = confirmBoxDataNew.FunctionMap;
			int key = 0;
			InstanceDungeonExitHandlerData data2 = CS$<>8__locals1.data;
			functionMap[key] = ((data2 != null) ? data2.CancelBack : null);
			confirmBoxDataNew.FunctionMap[1] = new Action(CS$<>8__locals1.<HandleExit>g__ReChallenge|1);
			confirmBoxDataNew.FunctionMap[2] = new Action(CS$<>8__locals1.<HandleExit>g__Leave|0);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0602EC60 RID: 191584 RVA: 0x00D0B3D0 File Offset: 0x00D095D0
		private bool IsCyberPunkRoleTrialInstance()
		{
			foreach (ActivityBaseData activityBaseData in ActivityModel.Instance.GetCurrentActivitiesByType(8))
			{
				ActivityRoleTrialData activityRoleTrialData = activityBaseData as ActivityRoleTrialData;
				if (activityRoleTrialData != null && activityRoleTrialData.IsRoleInstanceOn())
				{
					CyberPunkConfig instance = CyberPunkConfig.Instance;
					IReadOnlyList<EdgeRunnerTrial> readOnlyList = (instance != null) ? instance.GetTrialRoleListByTrialActivityId(activityRoleTrialData.Id) : null;
					if (readOnlyList != null && readOnlyList.Count > 0)
					{
						return true;
					}
				}
			}
			return false;
		}
	}
}
