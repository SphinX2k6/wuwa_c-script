using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02001676 RID: 5750
public class ActivityExData
{
	// Token: 0x0600A291 RID: 41617 RVA: 0x0023DC0E File Offset: 0x0023BE0E
	public ActivityExData(int id)
	{
		this.ActivityId = id;
	}

	// Token: 0x0600A292 RID: 41618 RVA: 0x0023DC1D File Offset: 0x0023BE1D
	public int GetActivityId()
	{
		return this.ActivityId;
	}

	// Token: 0x0600A293 RID: 41619 RVA: 0x0023DC25 File Offset: 0x0023BE25
	protected void RefreshActivityRedPoint()
	{
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
	}

	// Token: 0x040049EE RID: 18926
	protected int ActivityId;
}
