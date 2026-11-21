using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk;

// Token: 0x020028A5 RID: 10405
public class RedDotCyberPunkTask : RedDotBase
{
	// Token: 0x0601A62D RID: 108077 RVA: 0x0082A442 File Offset: 0x00828642
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add(EEventName.OnCyberPunkTaskRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601A62E RID: 108078 RVA: 0x0082A47C File Offset: 0x0082867C
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove(EEventName.OnCyberPunkTaskRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601A62F RID: 108079 RVA: 0x0082A4B6 File Offset: 0x008286B6
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.CommonActivityPage);
	}

	// Token: 0x0601A630 RID: 108080 RVA: 0x0082A4BF File Offset: 0x008286BF
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A631 RID: 108081 RVA: 0x0082A4C4 File Offset: 0x008286C4
	protected override bool OnCheck(int uId = 0)
	{
		CyberPunkController instance = CyberPunkController.Instance;
		CyberPunkData cyberPunkData = (instance != null) ? instance.GetCurrentActivityData() : null;
		if (cyberPunkData == null)
		{
			return false;
		}
		if (uId > 0)
		{
			CyberPunkTaskData taskDataById = cyberPunkData.GetTaskDataById(uId);
			return taskDataById != null && taskDataById.IsFinished();
		}
		return cyberPunkData.GetClaimableTaskIds().Count > 0;
	}
}
