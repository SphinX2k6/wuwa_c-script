using System;

// Token: 0x02003212 RID: 12818
public class NpcRedDotFlowLogic
{
	// Token: 0x0601BA6A RID: 113258 RVA: 0x0079936D File Offset: 0x0079756D
	public bool GetRedDotActive()
	{
		if (!this.ManualControl)
		{
			this.CheckRedDotCondition();
		}
		return this.RedDotActive;
	}

	// Token: 0x0601BA6B RID: 113259 RVA: 0x00799383 File Offset: 0x00797583
	private void CheckRedDotCondition()
	{
		this.RedDotActive = false;
	}

	// Token: 0x0601BA6C RID: 113260 RVA: 0x0079938C File Offset: 0x0079758C
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

	// Token: 0x0601BA6D RID: 113261 RVA: 0x007993AC File Offset: 0x007975AC
	public void Clear()
	{
		this.RedDotActive = false;
		this.ManualControl = false;
	}

	// Token: 0x0400D973 RID: 55667
	private bool RedDotActive;

	// Token: 0x0400D974 RID: 55668
	private bool ManualControl;
}
