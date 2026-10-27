using System;

// Token: 0x02001031 RID: 4145
public class GuessJokerRoleData
{
	// Token: 0x06006A73 RID: 27251 RVA: 0x00155D23 File Offset: 0x00153F23
	public GuessJokerRoleData(EGuessJokerPlayerType playerType, int maxHp)
	{
		this.PlayerTypeInternal = playerType;
		this.HpInternal = maxHp;
		this.MaxHpInternal = maxHp;
	}

	// Token: 0x06006A74 RID: 27252 RVA: 0x00155D40 File Offset: 0x00153F40
	public void RemoveHp(int value)
	{
		int num = this.HpInternal - value;
		if (num < 0)
		{
			num = 0;
		}
		if (num > this.MaxHpInternal)
		{
			num = this.MaxHpInternal;
		}
		this.HpInternal = num;
	}

	// Token: 0x06006A75 RID: 27253 RVA: 0x00155D74 File Offset: 0x00153F74
	public void SetHp(int value)
	{
		int hpInternal = value;
		if (value < 0)
		{
			hpInternal = 0;
		}
		if (value > this.MaxHpInternal)
		{
			hpInternal = this.MaxHpInternal;
		}
		this.HpInternal = hpInternal;
	}

	// Token: 0x06006A76 RID: 27254 RVA: 0x00155DA0 File Offset: 0x00153FA0
	public int GetHp()
	{
		return this.HpInternal;
	}

	// Token: 0x06006A77 RID: 27255 RVA: 0x00155DA8 File Offset: 0x00153FA8
	public int GetMaxHp()
	{
		return this.MaxHpInternal;
	}

	// Token: 0x06006A78 RID: 27256 RVA: 0x00155DB0 File Offset: 0x00153FB0
	public EGuessJokerPlayerType GetPlayerType()
	{
		return this.PlayerTypeInternal;
	}

	// Token: 0x0400310F RID: 12559
	private readonly EGuessJokerPlayerType PlayerTypeInternal;

	// Token: 0x04003110 RID: 12560
	private int HpInternal;

	// Token: 0x04003111 RID: 12561
	private readonly int MaxHpInternal;
}
