using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk;

// Token: 0x02003334 RID: 13108
public class RedDotCyberPunkTaskTab : RedDotBase
{
	// Token: 0x0601C93B RID: 117051 RVA: 0x00803F51 File Offset: 0x00802151
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add(EEventName.OnCyberPunkTaskRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601C93C RID: 117052 RVA: 0x00803F8B File Offset: 0x0080218B
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove(EEventName.OnCyberPunkTaskRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601C93D RID: 117053 RVA: 0x00803FC5 File Offset: 0x008021C5
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.CommonActivityPage);
	}

	// Token: 0x0601C93E RID: 117054 RVA: 0x00803FCE File Offset: 0x008021CE
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601C93F RID: 117055 RVA: 0x00803FD4 File Offset: 0x008021D4
	protected override bool OnCheck(int tabIndex)
	{
		CyberPunkController instance = CyberPunkController.Instance;
		CyberPunkData cyberPunkData = (instance != null) ? instance.GetCurrentActivityData() : null;
		return cyberPunkData != null && cyberPunkData.HasCyberPunkTaskRedDot(tabIndex);
	}
}
