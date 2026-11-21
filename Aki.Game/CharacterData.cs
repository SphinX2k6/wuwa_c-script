using System;

// Token: 0x020007D0 RID: 2000
public class CharacterData
{
	// Token: 0x17000BAB RID: 2987
	// (get) Token: 0x06005B5A RID: 23386 RVA: 0x001D87C3 File Offset: 0x001D69C3
	public int Id { get; }

	// Token: 0x06005B5B RID: 23387 RVA: 0x001D87CB File Offset: 0x001D69CB
	public CharacterData(int id)
	{
		this.Id = id;
		this.MaxValueInternal = BusinessConfig.Instance.GetRoleCharacterMax();
	}

	// Token: 0x06005B5C RID: 23388 RVA: 0x001D87EA File Offset: 0x001D69EA
	public void SetCurrentValue(int value)
	{
		this.ValueInterval = value - this.CurrentValueInternal;
		this.CurrentValueInternal = value;
	}

	// Token: 0x17000BAC RID: 2988
	// (get) Token: 0x06005B5D RID: 23389 RVA: 0x001D8801 File Offset: 0x001D6A01
	public int CurrentValue
	{
		get
		{
			return this.CurrentValueInternal;
		}
	}

	// Token: 0x06005B5E RID: 23390 RVA: 0x001D8809 File Offset: 0x001D6A09
	public void SetMaxValue(int value)
	{
		this.MaxValueInternal = value;
	}

	// Token: 0x17000BAD RID: 2989
	// (get) Token: 0x06005B5F RID: 23391 RVA: 0x001D8812 File Offset: 0x001D6A12
	public int MaxValue
	{
		get
		{
			return this.MaxValueInternal;
		}
	}

	// Token: 0x06005B60 RID: 23392 RVA: 0x001D881A File Offset: 0x001D6A1A
	public void SetUseScoreName(bool value)
	{
		this.UseScoreNameInternal = value;
	}

	// Token: 0x17000BAE RID: 2990
	// (get) Token: 0x06005B61 RID: 23393 RVA: 0x001D8823 File Offset: 0x001D6A23
	public bool UseScoreName
	{
		get
		{
			return this.UseScoreNameInternal;
		}
	}

	// Token: 0x04003D1E RID: 15646
	private int CurrentValueInternal;

	// Token: 0x04003D1F RID: 15647
	private int MaxValueInternal;

	// Token: 0x04003D20 RID: 15648
	public int ValueInterval;

	// Token: 0x04003D21 RID: 15649
	private bool UseScoreNameInternal;
}
