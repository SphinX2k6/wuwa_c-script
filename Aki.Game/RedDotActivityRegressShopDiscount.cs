using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200334D RID: 13133
public class RedDotActivityRegressShopDiscount : RedDotBase
{
	// Token: 0x0601C9A8 RID: 117160 RVA: 0x00804A41 File Offset: 0x00802C41
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601C9A9 RID: 117161 RVA: 0x00804A5F File Offset: 0x00802C5F
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601C9AA RID: 117162 RVA: 0x00804A7D File Offset: 0x00802C7D
	protected override bool OnCheck(int uId = 0)
	{
		ActivityRegressData activityData = ActivityRegressModel.Instance.ActivityData;
		return activityData != null && activityData.CheckShopRedDot();
	}
}
