using System;
using CSharpScript.Game.Ui;

// Token: 0x020010BA RID: 4282
public class ActivityConditionGroupData : UiPopViewData
{
	// Token: 0x06006F73 RID: 28531 RVA: 0x0016B88B File Offset: 0x00169A8B
	public ActivityConditionGroupData(int activityId)
	{
		this.ActivityId = activityId;
	}

	// Token: 0x17000967 RID: 2407
	// (get) Token: 0x06006F74 RID: 28532 RVA: 0x0016B89A File Offset: 0x00169A9A
	public int ActivityId { get; }
}
