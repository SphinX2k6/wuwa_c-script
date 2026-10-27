using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

// Token: 0x02001FEE RID: 8174
[NullableContext(1)]
[Nullable(0)]
public class CommonExchangeData : UiPopViewData, IViewOpenParamMultipleView
{
	// Token: 0x17001367 RID: 4967
	// (get) Token: 0x06010031 RID: 65585 RVA: 0x003E6D9B File Offset: 0x003E4F9B
	// (set) Token: 0x06010032 RID: 65586 RVA: 0x003E6DA3 File Offset: 0x003E4FA3
	public bool IsMultipleView { get; set; } = true;

	// Token: 0x06010033 RID: 65587 RVA: 0x003E6DAC File Offset: 0x003E4FAC
	public void InitBySrcAndDestItemId(int srcItemId, int destItemId, int? srcItemCount = null, int? destItemCount = null)
	{
		this.SrcExchangeUnitData.SetDataByItemId(srcItemId, srcItemCount);
		this.DestExchangeUnitData.SetDataByItemId(destItemId, destItemCount);
	}

	// Token: 0x06010034 RID: 65588 RVA: 0x003E6DCC File Offset: 0x003E4FCC
	public void InitByItemId(int itemId)
	{
		ItemExchangeContent value = ItemExchangeConfig.Instance.GetFirstExChangeConfigList(itemId).Value;
		if (itemId == 3)
		{
			this.ShowPayGold = true;
		}
		if (value.Consume().Count > 1)
		{
			Log.Instance.Error(ELogModule.ItemExchange, ELogAuthor.ZJC, "暂不支持消耗数量为1以上的道具兑换, 需要扩展!", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		if (value.Consume().Count > 0)
		{
			using (Dictionary<int, int>.Enumerator enumerator = value.Consume().GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					KeyValuePair<int, int> keyValuePair = enumerator.Current;
					this.SrcExchangeUnitData.SetDataByItemId(keyValuePair.Key, null);
				}
			}
		}
		this.DestExchangeUnitData.SetDataByItemId(value.ItemId, null);
	}

	// Token: 0x06010035 RID: 65589 RVA: 0x003E6EB0 File Offset: 0x003E50B0
	public string GetSrcName()
	{
		return this.SrcExchangeUnitData.Name;
	}

	// Token: 0x06010036 RID: 65590 RVA: 0x003E6EBD File Offset: 0x003E50BD
	public int GetSrcItemId()
	{
		return this.SrcExchangeUnitData.ItemId;
	}

	// Token: 0x06010037 RID: 65591 RVA: 0x003E6ECA File Offset: 0x003E50CA
	public int GetSrcTotalCount()
	{
		return this.SrcExchangeUnitData.TotalCount;
	}

	// Token: 0x06010038 RID: 65592 RVA: 0x003E6ED7 File Offset: 0x003E50D7
	public string GetDestName()
	{
		return this.DestExchangeUnitData.Name;
	}

	// Token: 0x06010039 RID: 65593 RVA: 0x003E6EE4 File Offset: 0x003E50E4
	public int GetDestItemId()
	{
		return this.DestExchangeUnitData.ItemId;
	}

	// Token: 0x0400768B RID: 30347
	private readonly ExchangeUnitData SrcExchangeUnitData = new ExchangeUnitData();

	// Token: 0x0400768C RID: 30348
	private readonly ExchangeUnitData DestExchangeUnitData = new ExchangeUnitData();

	// Token: 0x0400768D RID: 30349
	[Nullable(2)]
	public Action CancelCallBack;

	// Token: 0x0400768E RID: 30350
	public bool ConfirmNoClose;

	// Token: 0x0400768F RID: 30351
	public bool ShowPayGold;

	// Token: 0x04007690 RID: 30352
	[Nullable(2)]
	public Action<int, int> ConfirmCallBack;
}
