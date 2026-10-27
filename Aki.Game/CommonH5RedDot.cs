using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.CommonH5;

// Token: 0x02003376 RID: 13174
public class CommonH5RedDot : RedDotBase
{
	// Token: 0x0601CA5F RID: 117343 RVA: 0x00806084 File Offset: 0x00804284
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RefreshCommonH5ActivityRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CA60 RID: 117344 RVA: 0x008060A2 File Offset: 0x008042A2
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonH5ActivityRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CA61 RID: 117345 RVA: 0x008060C0 File Offset: 0x008042C0
	protected override bool OnCheck(int uId = 0)
	{
		return CommonH5Model.Instance.GetRedDotState();
	}
}
