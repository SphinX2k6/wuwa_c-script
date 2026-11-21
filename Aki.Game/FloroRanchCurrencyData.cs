using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.FloroRanch;

// Token: 0x02000FB2 RID: 4018
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchCurrencyData
{
	// Token: 0x0600A0DD RID: 41181 RVA: 0x002F7487 File Offset: 0x002F5687
	public FloroRanchCurrencyData(ECurrencyType currencyType)
	{
		this.ConfigData = FloroRanchModel.Instance.GetFloroRanchCurrencyConfig(currencyType);
	}

	// Token: 0x0600A0DE RID: 41182 RVA: 0x002F74A0 File Offset: 0x002F56A0
	public void ChangeAmount(long amount)
	{
		this.Amount += amount;
	}

	// Token: 0x0600A0DF RID: 41183 RVA: 0x002F74B0 File Offset: 0x002F56B0
	public void SetAmount(long amount)
	{
		this.Amount = amount;
	}

	// Token: 0x0600A0E0 RID: 41184 RVA: 0x002F74B9 File Offset: 0x002F56B9
	public void SetTotal(long amount)
	{
		this.TotalAmount = amount;
	}

	// Token: 0x0600A0E1 RID: 41185 RVA: 0x002F74C2 File Offset: 0x002F56C2
	public long GetAmount()
	{
		return this.Amount;
	}

	// Token: 0x0600A0E2 RID: 41186 RVA: 0x002F74CA File Offset: 0x002F56CA
	public long GetTotalAmount()
	{
		return this.TotalAmount;
	}

	// Token: 0x0600A0E3 RID: 41187 RVA: 0x002F74D2 File Offset: 0x002F56D2
	public string GetIconPath()
	{
		return this.ConfigData.GetSmallIcon();
	}

	// Token: 0x04005ECF RID: 24271
	private long Amount;

	// Token: 0x04005ED0 RID: 24272
	private long TotalAmount;

	// Token: 0x04005ED1 RID: 24273
	public FloroRanchCurrencyConfigData ConfigData;
}
