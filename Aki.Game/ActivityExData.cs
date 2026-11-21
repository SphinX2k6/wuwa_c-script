using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02000B2E RID: 2862
public class ActivityExData
{
	// Token: 0x0600766F RID: 30319 RVA: 0x00247A9E File Offset: 0x00245C9E
	public ActivityExData(int id)
	{
		this.ActivityId = id;
	}

	// Token: 0x06007670 RID: 30320 RVA: 0x00247AAD File Offset: 0x00245CAD
	public int GetActivityId()
	{
		return this.ActivityId;
	}

	// Token: 0x06007671 RID: 30321 RVA: 0x00247AB5 File Offset: 0x00245CB5
	protected void RefreshActivityRedPoint()
	{
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
	}

	// Token: 0x04004A94 RID: 19092
	protected int ActivityId;
}
