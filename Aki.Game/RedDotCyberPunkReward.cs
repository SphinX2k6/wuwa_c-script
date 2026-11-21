using System;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk;

// Token: 0x020028A4 RID: 10404
public class RedDotCyberPunkReward : RedDotBase
{
	// Token: 0x0601A629 RID: 108073 RVA: 0x0082A391 File Offset: 0x00828591
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add(EEventName.OnCyberPunkTaskRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601A62A RID: 108074 RVA: 0x0082A3CB File Offset: 0x008285CB
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove(EEventName.OnCyberPunkTaskRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601A62B RID: 108075 RVA: 0x0082A408 File Offset: 0x00828608
	protected override bool OnCheck(int uId = 0)
	{
		CyberPunkController instance = CyberPunkController.Instance;
		CyberPunkData cyberPunkData = (instance != null) ? instance.GetCurrentActivityData() : null;
		return cyberPunkData != null && cyberPunkData.GetCyberPunkTaskSliderData().Status == ConditionTaskState.ConditionTaskFinish;
	}
}
