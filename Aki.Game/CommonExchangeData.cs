using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

// Token: 0x020014C1 RID: 5313
[NullableContext(1)]
[Nullable(0)]
public class CommonExchangeData : UiPopViewData, IViewOpenParamMultipleView
{
	// Token: 0x17001394 RID: 5012
	// (get) Token: 0x0600D499 RID: 54425 RVA: 0x003F3393 File Offset: 0x003F1593
	// (set) Token: 0x0600D49A RID: 54426 RVA: 0x003F339B File Offset: 0x003F159B
	public bool IsMultipleView { get; set; } = true;

	// Token: 0x0600D49B RID: 54427 RVA: 0x003F33A4 File Offset: 0x003F15A4
	public void InitBySrcAndDestItemId(int srcItemId, int destItemId, int? srcItemCount = null, int? destItemCount = null)
	{
		this.SrcExchangeUnitData.SetDataByItemId(srcItemId, srcItemCount);
		this.DestExchangeUnitData.SetDataByItemId(destItemId, destItemCount);
	}

	// Token: 0x0600D49C RID: 54428 RVA: 0x003F33C4 File Offset: 0x003F15C4
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

	// Token: 0x0600D49D RID: 54429 RVA: 0x003F34A8 File Offset: 0x003F16A8
	public string GetSrcName()
	{
		return this.SrcExchangeUnitData.Name;
	}

	// Token: 0x0600D49E RID: 54430 RVA: 0x003F34B5 File Offset: 0x003F16B5
	public int GetSrcItemId()
	{
		return this.SrcExchangeUnitData.ItemId;
	}

	// Token: 0x0600D49F RID: 54431 RVA: 0x003F34C2 File Offset: 0x003F16C2
	public int GetSrcTotalCount()
	{
		return this.SrcExchangeUnitData.TotalCount;
	}

	// Token: 0x0600D4A0 RID: 54432 RVA: 0x003F34CF File Offset: 0x003F16CF
	public string GetDestName()
	{
		return this.DestExchangeUnitData.Name;
	}

	// Token: 0x0600D4A1 RID: 54433 RVA: 0x003F34DC File Offset: 0x003F16DC
	public int GetDestItemId()
	{
		return this.DestExchangeUnitData.ItemId;
	}

	// Token: 0x04007774 RID: 30580
	private readonly ExchangeUnitData SrcExchangeUnitData = new ExchangeUnitData();

	// Token: 0x04007775 RID: 30581
	private readonly ExchangeUnitData DestExchangeUnitData = new ExchangeUnitData();

	// Token: 0x04007776 RID: 30582
	[Nullable(2)]
	public Action CancelCallBack;

	// Token: 0x04007777 RID: 30583
	public bool ConfirmNoClose;

	// Token: 0x04007778 RID: 30584
	public bool ShowPayGold;

	// Token: 0x04007779 RID: 30585
	[Nullable(2)]
	public Action<int, int> ConfirmCallBack;
}
