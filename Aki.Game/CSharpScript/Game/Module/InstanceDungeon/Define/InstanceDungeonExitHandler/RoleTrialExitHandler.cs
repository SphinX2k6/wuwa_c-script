using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020058F9 RID: 22777
	public class RoleTrialExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x06039D38 RID: 236856 RVA: 0x00DBC318 File Offset: 0x00DBA518
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

		// Token: 0x06039D39 RID: 236857 RVA: 0x00DBC36C File Offset: 0x00DBA56C
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

		// Token: 0x06039D3A RID: 236858 RVA: 0x00DBC404 File Offset: 0x00DBA604
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
