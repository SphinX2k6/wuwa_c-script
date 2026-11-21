using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk;

// Token: 0x020028A7 RID: 10407
public class RedDotCyberPunkTrialRole : RedDotBase
{
	// Token: 0x0601A639 RID: 108089 RVA: 0x0082A5CB File Offset: 0x008287CB
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnTrialRoleDataChanged, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A63A RID: 108090 RVA: 0x0082A605 File Offset: 0x00828805
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnTrialRoleDataChanged, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A63B RID: 108091 RVA: 0x0082A63F File Offset: 0x0082883F
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.CommonActivityPage);
	}

	// Token: 0x0601A63C RID: 108092 RVA: 0x0082A648 File Offset: 0x00828848
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A63D RID: 108093 RVA: 0x0082A64B File Offset: 0x0082884B
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601A63E RID: 108094 RVA: 0x0082A650 File Offset: 0x00828850
	protected override bool OnCheck(int uId = 0)
	{
		CyberPunkController instance = CyberPunkController.Instance;
		CyberPunkData cyberPunkData = (instance != null) ? instance.GetCurrentActivityData() : null;
		if (cyberPunkData == null)
		{
			return false;
		}
		IReadOnlyList<EdgeRunnerTrial> configList = ConfigEdgeRunnerTrialByCyberPunkActivityId.GetConfigList(cyberPunkData.Id, true);
		if (configList == null || configList.Count == 0)
		{
			return false;
		}
		foreach (EdgeRunnerTrial edgeRunnerTrial in configList)
		{
			ActivityRoleTrialData activityRoleTrialData = ActivityModel.Instance.GetActivityById(edgeRunnerTrial.ActivityId) as ActivityRoleTrialData;
			if (activityRoleTrialData != null && activityRoleTrialData.GetRewardStateByRoleId(edgeRunnerTrial.Id) == ERoleTrialRewardState.FinishedAndUnClaimed)
			{
				return true;
			}
		}
		return false;
	}
}
