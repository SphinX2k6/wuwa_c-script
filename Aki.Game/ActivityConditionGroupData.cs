using System;
using CSharpScript.Game.Ui;

// Token: 0x0200056E RID: 1390
public class ActivityConditionGroupData : UiPopViewData
{
	// Token: 0x06004309 RID: 17161 RVA: 0x00174203 File Offset: 0x00172403
	public ActivityConditionGroupData(int activityId)
	{
		this.ActivityId = activityId;
	}

	// Token: 0x17000987 RID: 2439
	// (get) Token: 0x0600430A RID: 17162 RVA: 0x00174212 File Offset: 0x00172412
	public int ActivityId { get; }
}
