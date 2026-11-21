using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk;

// Token: 0x020028A6 RID: 10406
public class RedDotCyberPunkTaskTab : RedDotBase
{
	// Token: 0x0601A633 RID: 108083 RVA: 0x0082A515 File Offset: 0x00828715
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add(EEventName.OnCyberPunkTaskRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601A634 RID: 108084 RVA: 0x0082A54F File Offset: 0x0082874F
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove(EEventName.OnCyberPunkTaskRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601A635 RID: 108085 RVA: 0x0082A589 File Offset: 0x00828789
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.CommonActivityPage);
	}

	// Token: 0x0601A636 RID: 108086 RVA: 0x0082A592 File Offset: 0x00828792
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A637 RID: 108087 RVA: 0x0082A598 File Offset: 0x00828798
	protected override bool OnCheck(int tabIndex)
	{
		CyberPunkController instance = CyberPunkController.Instance;
		CyberPunkData cyberPunkData = (instance != null) ? instance.GetCurrentActivityData() : null;
		return cyberPunkData != null && cyberPunkData.HasCyberPunkTaskRedDot(tabIndex);
	}
}
