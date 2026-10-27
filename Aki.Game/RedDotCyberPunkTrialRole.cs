using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk;

// Token: 0x02003335 RID: 13109
public class RedDotCyberPunkTrialRole : RedDotBase
{
	// Token: 0x0601C941 RID: 117057 RVA: 0x00804007 File Offset: 0x00802207
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnTrialRoleDataChanged, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601C942 RID: 117058 RVA: 0x00804041 File Offset: 0x00802241
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnTrialRoleDataChanged, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601C943 RID: 117059 RVA: 0x0080407B File Offset: 0x0080227B
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.CommonActivityPage);
	}

	// Token: 0x0601C944 RID: 117060 RVA: 0x00804084 File Offset: 0x00802284
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601C945 RID: 117061 RVA: 0x00804087 File Offset: 0x00802287
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601C946 RID: 117062 RVA: 0x0080408C File Offset: 0x0080228C
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
