using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk;

// Token: 0x02003333 RID: 13107
public class RedDotCyberPunkTask : RedDotBase
{
	// Token: 0x0601C935 RID: 117045 RVA: 0x00803E7E File Offset: 0x0080207E
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add(EEventName.OnCyberPunkTaskRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601C936 RID: 117046 RVA: 0x00803EB8 File Offset: 0x008020B8
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove(EEventName.OnCyberPunkTaskRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601C937 RID: 117047 RVA: 0x00803EF2 File Offset: 0x008020F2
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.CommonActivityPage);
	}

	// Token: 0x0601C938 RID: 117048 RVA: 0x00803EFB File Offset: 0x008020FB
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601C939 RID: 117049 RVA: 0x00803F00 File Offset: 0x00802100
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
