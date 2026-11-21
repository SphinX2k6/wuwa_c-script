using System;

// Token: 0x020025B9 RID: 9657
public class CharacterHitOptimize
{
	// Token: 0x06017FDB RID: 98267 RVA: 0x0072E884 File Offset: 0x0072CA84
	public bool IsInCooling()
	{
		return Time.Instance.WorldTime - this.LastHitTime < 1000.0;
	}

	// Token: 0x06017FDC RID: 98268 RVA: 0x0072E8A2 File Offset: 0x0072CAA2
	public void UpdateLastHitTime()
	{
		this.LastHitTime = Time.Instance.WorldTime;
	}

	// Token: 0x0400CDDA RID: 52698
	private const float COOLDOWN_TIME_MS = 1000f;

	// Token: 0x0400CDDB RID: 52699
	private double LastHitTime;
}
