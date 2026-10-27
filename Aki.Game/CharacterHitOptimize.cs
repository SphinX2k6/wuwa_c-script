using System;

// Token: 0x02003063 RID: 12387
public class CharacterHitOptimize
{
	// Token: 0x0601A627 RID: 108071 RVA: 0x00707F48 File Offset: 0x00706148
	public bool IsInCooling()
	{
		return Time.Instance.WorldTime - this.LastHitTime < 1000.0;
	}

	// Token: 0x0601A628 RID: 108072 RVA: 0x00707F66 File Offset: 0x00706166
	public void UpdateLastHitTime()
	{
		this.LastHitTime = Time.Instance.WorldTime;
	}

	// Token: 0x0400CA00 RID: 51712
	private const float COOLDOWN_TIME_MS = 1000f;

	// Token: 0x0400CA01 RID: 51713
	private double LastHitTime;
}
