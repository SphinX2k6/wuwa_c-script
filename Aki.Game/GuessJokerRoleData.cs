using System;

// Token: 0x020004E5 RID: 1253
public class GuessJokerRoleData
{
	// Token: 0x06003E08 RID: 15880 RVA: 0x0015E64B File Offset: 0x0015C84B
	public GuessJokerRoleData(EGuessJokerPlayerType playerType, int maxHp)
	{
		this.PlayerTypeInternal = playerType;
		this.HpInternal = maxHp;
		this.MaxHpInternal = maxHp;
	}

	// Token: 0x06003E09 RID: 15881 RVA: 0x0015E668 File Offset: 0x0015C868
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

	// Token: 0x06003E0A RID: 15882 RVA: 0x0015E69C File Offset: 0x0015C89C
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

	// Token: 0x06003E0B RID: 15883 RVA: 0x0015E6C8 File Offset: 0x0015C8C8
	public int GetHp()
	{
		return this.HpInternal;
	}

	// Token: 0x06003E0C RID: 15884 RVA: 0x0015E6D0 File Offset: 0x0015C8D0
	public int GetMaxHp()
	{
		return this.MaxHpInternal;
	}

	// Token: 0x06003E0D RID: 15885 RVA: 0x0015E6D8 File Offset: 0x0015C8D8
	public EGuessJokerPlayerType GetPlayerType()
	{
		return this.PlayerTypeInternal;
	}

	// Token: 0x040031A8 RID: 12712
	private readonly EGuessJokerPlayerType PlayerTypeInternal;

	// Token: 0x040031A9 RID: 12713
	private int HpInternal;

	// Token: 0x040031AA RID: 12714
	private readonly int MaxHpInternal;
}
