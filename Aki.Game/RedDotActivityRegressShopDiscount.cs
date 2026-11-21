using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028BF RID: 10431
public class RedDotActivityRegressShopDiscount : RedDotBase
{
	// Token: 0x0601A6A0 RID: 108192 RVA: 0x0082B005 File Offset: 0x00829205
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A6A1 RID: 108193 RVA: 0x0082B023 File Offset: 0x00829223
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A6A2 RID: 108194 RVA: 0x0082B041 File Offset: 0x00829241
	protected override bool OnCheck(int uId = 0)
	{
		ActivityRegressData activityData = ActivityRegressModel.Instance.ActivityData;
		return activityData != null && activityData.CheckShopRedDot();
	}
}
