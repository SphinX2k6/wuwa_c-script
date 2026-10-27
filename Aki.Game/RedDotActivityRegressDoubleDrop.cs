using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003349 RID: 13129
public class RedDotActivityRegressDoubleDrop : RedDotBase
{
	// Token: 0x0601C998 RID: 117144 RVA: 0x008048DB File Offset: 0x00802ADB
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601C999 RID: 117145 RVA: 0x008048F9 File Offset: 0x00802AF9
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601C99A RID: 117146 RVA: 0x00804917 File Offset: 0x00802B17
	protected override bool OnCheck(int uId = 0)
	{
		return ActivityRegressModel.Instance.ActivityData.CheckDoubleDropRedDot();
	}
}
