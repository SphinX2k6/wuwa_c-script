using System;

// Token: 0x02002781 RID: 10113
public class NpcRedDotFlowLogic
{
	// Token: 0x060195EF RID: 103919 RVA: 0x007C1B09 File Offset: 0x007BFD09
	public bool GetRedDotActive()
	{
		if (!this.ManualControl)
		{
			this.CheckRedDotCondition();
		}
		return this.RedDotActive;
	}

	// Token: 0x060195F0 RID: 103920 RVA: 0x007C1B1F File Offset: 0x007BFD1F
	private void CheckRedDotCondition()
	{
		this.RedDotActive = false;
	}

	// Token: 0x060195F1 RID: 103921 RVA: 0x007C1B28 File Offset: 0x007BFD28
	public void ManualControlRedDotActive(bool manualControl, bool redDotActive)
	{
		this.ManualControl = manualControl;
		if (this.ManualControl)
		{
			this.RedDotActive = redDotActive;
			return;
		}
		this.RedDotActive = false;
	}

	// Token: 0x060195F2 RID: 103922 RVA: 0x007C1B48 File Offset: 0x007BFD48
	public void Clear()
	{
		this.RedDotActive = false;
		this.ManualControl = false;
	}

	// Token: 0x0400DE12 RID: 56850
	private bool RedDotActive;

	// Token: 0x0400DE13 RID: 56851
	private bool ManualControl;
}
