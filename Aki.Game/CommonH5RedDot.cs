using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.CommonH5;

// Token: 0x020028E8 RID: 10472
public class CommonH5RedDot : RedDotBase
{
	// Token: 0x0601A757 RID: 108375 RVA: 0x0082C648 File Offset: 0x0082A848
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RefreshCommonH5ActivityRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A758 RID: 108376 RVA: 0x0082C666 File Offset: 0x0082A866
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonH5ActivityRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A759 RID: 108377 RVA: 0x0082C684 File Offset: 0x0082A884
	protected override bool OnCheck(int uId = 0)
	{
		return CommonH5Model.Instance.GetRedDotState();
	}
}
