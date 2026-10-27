using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Manufacture.Compose;

// Token: 0x0200187B RID: 6267
[NullableContext(1)]
[Nullable(0)]
public class ComposeExchangeSort : CommonSort<EComposeExchangeSortWayType>
{
	// Token: 0x0600B7D1 RID: 47057 RVA: 0x00299988 File Offset: 0x00297B88
	private int SortQuality(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		IExchangeData exchangeData = a as IExchangeData;
		if (exchangeData == null)
		{
			return 0;
		}
		IExchangeData exchangeData2 = b as IExchangeData;
		if (exchangeData2 == null)
		{
			return 0;
		}
		if (exchangeData2.IsUnlock != exchangeData.IsUnlock)
		{
			int num = exchangeData2.IsUnlock - exchangeData.IsUnlock;
			if (!isAscending)
			{
				return -num;
			}
			return num;
		}
		else
		{
			if (exchangeData.Quality != exchangeData2.Quality)
			{
				return (exchangeData2.Quality - exchangeData.Quality) * (isAscending ? -1 : 1);
			}
			return exchangeData.ConfigId - exchangeData2.ConfigId;
		}
	}

	// Token: 0x0600B7D2 RID: 47058 RVA: 0x00299A04 File Offset: 0x00297C04
	private int SortMake(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		IExchangeData exchangeData = a as IExchangeData;
		if (exchangeData == null)
		{
			return 0;
		}
		IExchangeData exchangeData2 = b as IExchangeData;
		if (exchangeData2 == null)
		{
			return 0;
		}
		if (exchangeData2.IsUnlock != exchangeData.IsUnlock)
		{
			int num = exchangeData2.IsUnlock - exchangeData.IsUnlock;
			if (!isAscending)
			{
				return -num;
			}
			return num;
		}
		else
		{
			int num2 = (!ComposeModel.Instance.CheckCanExchange(exchangeData.ConfigId)) ? 1 : 0;
			int num3 = (!ComposeModel.Instance.CheckCanExchange(exchangeData2.ConfigId)) ? 1 : 0;
			if (num2 != num3)
			{
				return num2 - num3;
			}
			return 0;
		}
	}

	// Token: 0x0600B7D3 RID: 47059 RVA: 0x00299A81 File Offset: 0x00297C81
	protected override void OnInitSortMap()
	{
		this.SortMap.Add(EComposeExchangeSortWayType.Quality, new TSortResult(this.SortQuality));
		this.SortMap.Add(EComposeExchangeSortWayType.Make, new TSortResult(this.SortMake));
	}
}
