using System;

// Token: 0x0200131C RID: 4892
public class CharacterData
{
	// Token: 0x17000B8B RID: 2955
	// (get) Token: 0x060087BF RID: 34751 RVA: 0x001CF957 File Offset: 0x001CDB57
	public int Id { get; }

	// Token: 0x060087C0 RID: 34752 RVA: 0x001CF95F File Offset: 0x001CDB5F
	public CharacterData(int id)
	{
		this.Id = id;
		this.MaxValueInternal = BusinessConfig.Instance.GetRoleCharacterMax();
	}

	// Token: 0x060087C1 RID: 34753 RVA: 0x001CF97E File Offset: 0x001CDB7E
	public void SetCurrentValue(int value)
	{
		this.ValueInterval = value - this.CurrentValueInternal;
		this.CurrentValueInternal = value;
	}

	// Token: 0x17000B8C RID: 2956
	// (get) Token: 0x060087C2 RID: 34754 RVA: 0x001CF995 File Offset: 0x001CDB95
	public int CurrentValue
	{
		get
		{
			return this.CurrentValueInternal;
		}
	}

	// Token: 0x060087C3 RID: 34755 RVA: 0x001CF99D File Offset: 0x001CDB9D
	public void SetMaxValue(int value)
	{
		this.MaxValueInternal = value;
	}

	// Token: 0x17000B8D RID: 2957
	// (get) Token: 0x060087C4 RID: 34756 RVA: 0x001CF9A6 File Offset: 0x001CDBA6
	public int MaxValue
	{
		get
		{
			return this.MaxValueInternal;
		}
	}

	// Token: 0x060087C5 RID: 34757 RVA: 0x001CF9AE File Offset: 0x001CDBAE
	public void SetUseScoreName(bool value)
	{
		this.UseScoreNameInternal = value;
	}

	// Token: 0x17000B8E RID: 2958
	// (get) Token: 0x060087C6 RID: 34758 RVA: 0x001CF9B7 File Offset: 0x001CDBB7
	public bool UseScoreName
	{
		get
		{
			return this.UseScoreNameInternal;
		}
	}

	// Token: 0x04003C86 RID: 15494
	private int CurrentValueInternal;

	// Token: 0x04003C87 RID: 15495
	private int MaxValueInternal;

	// Token: 0x04003C88 RID: 15496
	public int ValueInterval;

	// Token: 0x04003C89 RID: 15497
	private bool UseScoreNameInternal;
}
