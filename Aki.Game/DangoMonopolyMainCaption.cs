using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020006F0 RID: 1776
[NullableContext(1)]
[Nullable(0)]
public class DangoMonopolyMainCaption : UiPanelBase
{
	// Token: 0x060051E0 RID: 20960 RVA: 0x001B4680 File Offset: 0x001B2880
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

	// Token: 0x060051E1 RID: 20961 RVA: 0x001B46CC File Offset: 0x001B28CC
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

	// Token: 0x060051E2 RID: 20962 RVA: 0x001B4761 File Offset: 0x001B2961
	private void OnClickCloseBtn()
	{
		Action onCloseCallback = this.OnCloseCallback;
		if (onCloseCallback == null)
		{
			return;
		}
		onCloseCallback();
	}

	// Token: 0x060051E3 RID: 20963 RVA: 0x001B4773 File Offset: 0x001B2973
	private void OnClickHelpBtn()
	{
		Action onHelpCallback = this.OnHelpCallback;
		if (onHelpCallback == null)
		{
			return;
		}
		onHelpCallback();
	}

	// Token: 0x060051E4 RID: 20964 RVA: 0x001B4785 File Offset: 0x001B2985
	private UUIButtonComponent GetBtnClose()
	{
		return base.GetButton(0);
	}

	// Token: 0x060051E5 RID: 20965 RVA: 0x001B478E File Offset: 0x001B298E
	private UUIButtonComponent GetBtnHelp()
	{
		return base.GetButton(1);
	}

	// Token: 0x060051E6 RID: 20966 RVA: 0x001B4797 File Offset: 0x001B2997
	public UUIItem GetCostContent()
	{
		return base.GetItem(2);
	}

	// Token: 0x060051E7 RID: 20967 RVA: 0x001B47A0 File Offset: 0x001B29A0
	public void SetBtnHelpVisible(bool state)
	{
		this.GetBtnHelp().RootUIComp.Get().SetUIActive(state);
	}

	// Token: 0x060051E8 RID: 20968 RVA: 0x001B47C8 File Offset: 0x001B29C8
	public void SetBtnCloseVisible(bool state)
	{
		this.GetBtnClose().RootUIComp.Get().SetUIActive(state);
	}

	// Token: 0x060051E9 RID: 20969 RVA: 0x001B47EE File Offset: 0x001B29EE
	public void SetCurrencyVisible(bool bVisible)
	{
		this.GetCostContent().SetUIActive(bVisible);
	}

	// Token: 0x060051EA RID: 20970 RVA: 0x001B47FC File Offset: 0x001B29FC
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

	// Token: 0x060051EB RID: 20971 RVA: 0x001B4847 File Offset: 0x001B2A47
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

	// Token: 0x060051EC RID: 20972 RVA: 0x001B485C File Offset: 0x001B2A5C
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

	// Token: 0x04003A29 RID: 14889
	[Nullable(2)]
	private CommonCurrencyItemListComponent CurrencyItemListComponent;

	// Token: 0x04003A2A RID: 14890
	[Nullable(2)]
	public Action OnCloseCallback;

	// Token: 0x04003A2B RID: 14891
	[Nullable(2)]
	public Action OnHelpCallback;

	// Token: 0x020069B7 RID: 27063
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04022CDB RID: 142555
		BtnClose,
		// Token: 0x04022CDC RID: 142556
		BtnHelp,
		// Token: 0x04022CDD RID: 142557
		CostContent
	}
}
