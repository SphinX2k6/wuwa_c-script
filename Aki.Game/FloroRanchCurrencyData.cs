using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.FloroRanch;

// Token: 0x02001AF3 RID: 6899
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchCurrencyData
{
	// Token: 0x0600CCCC RID: 52428 RVA: 0x002EC39B File Offset: 0x002EA59B
	public FloroRanchCurrencyData(ECurrencyType currencyType)
	{
		this.ConfigData = FloroRanchModel.Instance.GetFloroRanchCurrencyConfig(currencyType);
	}

	// Token: 0x0600CCCD RID: 52429 RVA: 0x002EC3B4 File Offset: 0x002EA5B4
	public void ChangeAmount(long amount)
	{
		this.Amount += amount;
	}

	// Token: 0x0600CCCE RID: 52430 RVA: 0x002EC3C4 File Offset: 0x002EA5C4
	public void SetAmount(long amount)
	{
		this.Amount = amount;
	}

	// Token: 0x0600CCCF RID: 52431 RVA: 0x002EC3CD File Offset: 0x002EA5CD
	public void SetTotal(long amount)
	{
		this.TotalAmount = amount;
	}

	// Token: 0x0600CCD0 RID: 52432 RVA: 0x002EC3D6 File Offset: 0x002EA5D6
	public long GetAmount()
	{
		return this.Amount;
	}

	// Token: 0x0600CCD1 RID: 52433 RVA: 0x002EC3DE File Offset: 0x002EA5DE
	public long GetTotalAmount()
	{
		return this.TotalAmount;
	}

	// Token: 0x0600CCD2 RID: 52434 RVA: 0x002EC3E6 File Offset: 0x002EA5E6
	public string GetIconPath()
	{
		return this.ConfigData.GetSmallIcon();
	}

	// Token: 0x04005E00 RID: 24064
	private long Amount;

	// Token: 0x04005E01 RID: 24065
	private long TotalAmount;

	// Token: 0x04005E02 RID: 24066
	public FloroRanchCurrencyConfigData ConfigData;
}
