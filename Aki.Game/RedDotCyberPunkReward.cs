using System;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk;

// Token: 0x02003332 RID: 13106
public class RedDotCyberPunkReward : RedDotBase
{
	// Token: 0x0601C931 RID: 117041 RVA: 0x00803DCD File Offset: 0x00801FCD
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add(EEventName.OnCyberPunkTaskRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601C932 RID: 117042 RVA: 0x00803E07 File Offset: 0x00802007
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove(EEventName.OnCyberPunkTaskRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601C933 RID: 117043 RVA: 0x00803E44 File Offset: 0x00802044
	protected override bool OnCheck(int uId = 0)
	{
		CyberPunkController instance = CyberPunkController.Instance;
		CyberPunkData cyberPunkData = (instance != null) ? instance.GetCurrentActivityData() : null;
		return cyberPunkData != null && cyberPunkData.GetCyberPunkTaskSliderData().Status == ConditionTaskState.ConditionTaskFinish;
	}
}
