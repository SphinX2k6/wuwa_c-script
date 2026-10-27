using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200123C RID: 4668
[NullableContext(1)]
[Nullable(0)]
public class DangoMonopolyMainCaption : UiPanelBase
{
	// Token: 0x06007E49 RID: 32329 RVA: 0x001AB9C0 File Offset: 0x001A9BC0
	public UniTask Init(UUIItem item)
	{
		DangoMonopolyMainCaption.<Init>d__4 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.item = item;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<DangoMonopolyMainCaption.<Init>d__4>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06007E4A RID: 32330 RVA: 0x001ABA0C File Offset: 0x001A9C0C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickCloseBtn)),
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickHelpBtn))
		};
	}

	// Token: 0x06007E4B RID: 32331 RVA: 0x001ABAA1 File Offset: 0x001A9CA1
	private void OnClickCloseBtn()
	{
		Action onCloseCallback = this.OnCloseCallback;
		if (onCloseCallback == null)
		{
			return;
		}
		onCloseCallback();
	}

	// Token: 0x06007E4C RID: 32332 RVA: 0x001ABAB3 File Offset: 0x001A9CB3
	private void OnClickHelpBtn()
	{
		Action onHelpCallback = this.OnHelpCallback;
		if (onHelpCallback == null)
		{
			return;
		}
		onHelpCallback();
	}

	// Token: 0x06007E4D RID: 32333 RVA: 0x001ABAC5 File Offset: 0x001A9CC5
	private UUIButtonComponent GetBtnClose()
	{
		return base.GetButton(0);
	}

	// Token: 0x06007E4E RID: 32334 RVA: 0x001ABACE File Offset: 0x001A9CCE
	private UUIButtonComponent GetBtnHelp()
	{
		return base.GetButton(1);
	}

	// Token: 0x06007E4F RID: 32335 RVA: 0x001ABAD7 File Offset: 0x001A9CD7
	public UUIItem GetCostContent()
	{
		return base.GetItem(2);
	}

	// Token: 0x06007E50 RID: 32336 RVA: 0x001ABAE0 File Offset: 0x001A9CE0
	public void SetBtnHelpVisible(bool state)
	{
		this.GetBtnHelp().RootUIComp.Get().SetUIActive(state);
	}

	// Token: 0x06007E51 RID: 32337 RVA: 0x001ABB08 File Offset: 0x001A9D08
	public void SetBtnCloseVisible(bool state)
	{
		this.GetBtnClose().RootUIComp.Get().SetUIActive(state);
	}

	// Token: 0x06007E52 RID: 32338 RVA: 0x001ABB2E File Offset: 0x001A9D2E
	public void SetCurrencyVisible(bool bVisible)
	{
		this.GetCostContent().SetUIActive(bVisible);
	}

	// Token: 0x06007E53 RID: 32339 RVA: 0x001ABB3C File Offset: 0x001A9D3C
	public UniTask SetCurrencyItemList(int[] itemIdList)
	{
		DangoMonopolyMainCaption.<SetCurrencyItemList>d__14 <SetCurrencyItemList>d__;
		<SetCurrencyItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SetCurrencyItemList>d__.<>4__this = this;
		<SetCurrencyItemList>d__.itemIdList = itemIdList;
		<SetCurrencyItemList>d__.<>1__state = -1;
		<SetCurrencyItemList>d__.<>t__builder.Start<DangoMonopolyMainCaption.<SetCurrencyItemList>d__14>(ref <SetCurrencyItemList>d__);
		return <SetCurrencyItemList>d__.<>t__builder.Task;
	}

	// Token: 0x06007E54 RID: 32340 RVA: 0x001ABB87 File Offset: 0x001A9D87
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<CommonCurrencyItem> GetCurrencyItemList()
	{
		CommonCurrencyItemListComponent currencyItemListComponent = this.CurrencyItemListComponent;
		if (currencyItemListComponent == null)
		{
			return null;
		}
		return currencyItemListComponent.GetCurrencyItemList();
	}

	// Token: 0x06007E55 RID: 32341 RVA: 0x001ABB9C File Offset: 0x001A9D9C
	public void SetCurrencyItemBtnFunction(int itemId, Action<int> callBack)
	{
		CommonCurrencyItemListComponent currencyItemListComponent = this.CurrencyItemListComponent;
		List<CommonCurrencyItem> list = (currencyItemListComponent != null) ? currencyItemListComponent.GetCurrencyItemList() : null;
		if (list != null)
		{
			foreach (CommonCurrencyItem commonCurrencyItem in list)
			{
				if (commonCurrencyItem.ItemId == itemId)
				{
					commonCurrencyItem.SetButtonFunction(callBack);
					break;
				}
			}
		}
	}

	// Token: 0x04003991 RID: 14737
	[Nullable(2)]
	private CommonCurrencyItemListComponent CurrencyItemListComponent;

	// Token: 0x04003992 RID: 14738
	[Nullable(2)]
	public Action OnCloseCallback;

	// Token: 0x04003993 RID: 14739
	[Nullable(2)]
	public Action OnHelpCallback;

	// Token: 0x0200782C RID: 30764
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x040279AA RID: 162218
		BtnClose,
		// Token: 0x040279AB RID: 162219
		BtnHelp,
		// Token: 0x040279AC RID: 162220
		CostContent
	}
}
