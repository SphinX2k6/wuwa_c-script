using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Common.NumberSelect;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020019B2 RID: 6578
[NullableContext(1)]
[Nullable(0)]
internal class VisionIdentifyCostItem : UiPanelBase
{
	// Token: 0x0601036F RID: 66415 RVA: 0x004BB65D File Offset: 0x004B985D
	public VisionIdentifyCostItem(UUIItem uiItem)
	{
		this.SourceItem = uiItem;
	}

	// Token: 0x06010370 RID: 66416 RVA: 0x004BB66C File Offset: 0x004B986C
	public void Init()
	{
		base.SetRootActor(this.SourceItem.GetOwner(), true);
	}

	// Token: 0x06010371 RID: 66417 RVA: 0x004BB680 File Offset: 0x004B9880
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUITexture)),
			new ValueTuple<int, Type>(10, typeof(UUIText)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIText))
		};
	}

	// Token: 0x06010372 RID: 66418 RVA: 0x004BB7D4 File Offset: 0x004B99D4
	protected override void OnStart()
	{
		this.NumberSelect = new NumberSelectComponent(base.GetItem(8));
		this.StrengthItem = new ButtonItem(base.GetItem(11));
		this.StrengthItem.SetFunction(new Action<int>(this.OnClickStrengthButton));
		this.ItemGridVariantSelect = new MediumItemGrid();
		this.ItemGridVariantSelect.Initialize(base.GetItem(12).GetOwner());
		this.ItemGridVariantSelect.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnClickedRewardItem));
	}

	// Token: 0x06010373 RID: 66419 RVA: 0x004BB858 File Offset: 0x004B9A58
	private void OnClickedRewardItem(MediumItemGridExtendCallback callbackParameter)
	{
		MediumItemGrid itemGridVariantSelect = this.ItemGridVariantSelect;
		if (itemGridVariantSelect != null)
		{
			itemGridVariantSelect.SetSelected(false, true);
		}
		int currentIdentifyCostId = this.Data.GetCurrentIdentifyCostId();
		List<ItemDataBase> itemDataBaseByConfigId = InventoryModel.Instance.GetItemDataBaseByConfigId(currentIdentifyCostId);
		int num = 0;
		if (itemDataBaseByConfigId.Count > 0)
		{
			num = itemDataBaseByConfigId[0].GetUniqueId();
		}
		if (num != 0 && num > 0)
		{
			ItemController.Instance.OpenItemTipsByItemUid(num, currentIdentifyCostId, true, null);
			return;
		}
		ItemController.Instance.OpenItemTipsByItemId(currentIdentifyCostId, true, null, false);
	}

	// Token: 0x06010374 RID: 66420 RVA: 0x004BB8CC File Offset: 0x004B9ACC
	private void OnClickStrengthButton(int _)
	{
		if (!this.GetRedItemEnoughItemState(this.Data))
		{
			GenericPromptController.Instance.ShowPromptByCode("LevelUpMaterialShort", Array.Empty<object>());
			return;
		}
		if (!this.Data.GetIfHaveEnoughIdentifyGold(this.CurrentConsumeSelectNum()))
		{
			GenericPromptController.Instance.ShowPromptByCode("IdentifyNotEnoughMoney", Array.Empty<object>());
			return;
		}
		this.RequestIdentify().Forget();
	}

	// Token: 0x06010375 RID: 66421 RVA: 0x004BB930 File Offset: 0x004B9B30
	private UniTask RequestIdentify()
	{
		VisionIdentifyCostItem.<RequestIdentify>d__13 <RequestIdentify>d__;
		<RequestIdentify>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestIdentify>d__.<>4__this = this;
		<RequestIdentify>d__.<>1__state = -1;
		<RequestIdentify>d__.<>t__builder.Start<VisionIdentifyCostItem.<RequestIdentify>d__13>(ref <RequestIdentify>d__);
		return <RequestIdentify>d__.<>t__builder.Task;
	}

	// Token: 0x06010376 RID: 66422 RVA: 0x004BB973 File Offset: 0x004B9B73
	private TableTextArgNew GetExchangeTableText(int selectValue)
	{
		return new TableTextArgNew(TextConfig.Instance.GetTextContentIdById("IdentifyCount"), new <>z__ReadOnlySingleElementList<object>(selectValue));
	}

	// Token: 0x06010377 RID: 66423 RVA: 0x004BB994 File Offset: 0x004B9B94
	private void RefreshStrengthButton()
	{
	}

	// Token: 0x06010378 RID: 66424 RVA: 0x004BB996 File Offset: 0x004B9B96
	private void ValueChangeFunction(int selectValue)
	{
		this.RefreshView();
		Action onChangeValueCall = this.OnChangeValueCall;
		if (onChangeValueCall == null)
		{
			return;
		}
		onChangeValueCall();
	}

	// Token: 0x06010379 RID: 66425 RVA: 0x004BB9B0 File Offset: 0x004B9BB0
	private void RefreshItemShow(PhantomDataBase data)
	{
		int currentIdentifyCostId = data.GetCurrentIdentifyCostId();
		ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(currentIdentifyCostId);
		if (itemConfig == null)
		{
			return;
		}
		PropMediumItemGrid propMediumItemGrid = new PropMediumItemGrid
		{
			ItemConfigId = new int?(currentIdentifyCostId),
			StarLevel = new int?(itemConfig.Value.QualityId)
		};
		int currentIdentifyCostValue = data.GetCurrentIdentifyCostValue();
		List<ItemDataBase> itemDataBaseByConfigId = InventoryModel.Instance.GetItemDataBaseByConfigId(currentIdentifyCostId);
		int num = 0;
		if (itemDataBaseByConfigId.Count > 0)
		{
			num = itemDataBaseByConfigId[0].GetCount();
		}
		int num2 = 0;
		if (this.CurrentConsumeSelectNum() > 0)
		{
			num2 = currentIdentifyCostValue * this.CurrentConsumeSelectNum();
		}
		if (num >= currentIdentifyCostValue)
		{
			propMediumItemGrid.BottomText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("Text_CollectProgress_Text", null), new string[]
			{
				num.ToString(),
				num2.ToString()
			});
		}
		else
		{
			propMediumItemGrid.BottomText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("Text_ItemCostNotEnough_Text", null), new string[]
			{
				num.ToString(),
				num2.ToString()
			});
		}
		this.ItemGridVariantSelect.Apply<PropMediumItemGrid>(propMediumItemGrid);
	}

	// Token: 0x0601037A RID: 66426 RVA: 0x004BBAC0 File Offset: 0x004B9CC0
	private void RefreshNumSelectComponent(PhantomDataBase data)
	{
		int currentCanIdentifyCount = data.GetCurrentCanIdentifyCount();
		INumberSelectData data2 = new INumberSelectData
		{
			MaxNumber = currentCanIdentifyCount,
			GetExchangeTableText = new Func<int, TableTextArgNew>(this.GetExchangeTableText),
			ValueChangeFunction = new Action<int>(this.ValueChangeFunction)
		};
		this.NumberSelect.SetMinValue(0);
		this.NumberSelect.Init(data2);
		this.NumberSelect.SetAddReduceButtonActive(true);
		this.NumberSelect.SetMinTextShowState(true);
		this.NumberSelect.SetAddReduceButtonInteractive(currentCanIdentifyCount > 1);
		this.NumberSelect.SetReduceButtonInteractive(this.CurrentConsumeSelectNum() > 1);
	}

	// Token: 0x0601037B RID: 66427 RVA: 0x004BBB58 File Offset: 0x004B9D58
	private void RefreshConsume(PhantomDataBase data)
	{
		int identifyCostItemId = data.GetIdentifyCostItemId();
		base.SetItemIcon(base.GetTexture(9), identifyCostItemId, null, null);
		UUIText text = base.GetText(10);
		if (text == null)
		{
			return;
		}
		text.SetText((data.GetIdentifyCostItemValue() * this.CurrentConsumeSelectNum()).ToString(), true);
		UUIItem uuiitem = text;
		bool bUseChangeColor = !data.GetIfHaveEnoughIdentifyGold(this.CurrentConsumeSelectNum());
		FColor? fcolor = new FColor?(text.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
	}

	// Token: 0x0601037C RID: 66428 RVA: 0x004BBBD4 File Offset: 0x004B9DD4
	private void RefreshGreenItem(PhantomDataBase data)
	{
		bool ifNeedShowGreenItem = this.GetIfNeedShowGreenItem(data);
		base.GetItem(3).SetUIActive(ifNeedShowGreenItem);
	}

	// Token: 0x0601037D RID: 66429 RVA: 0x004BBBF8 File Offset: 0x004B9DF8
	private bool GetIfNeedShowGreenItem(PhantomDataBase data)
	{
		List<VisionSubPropData> levelSubPropData = data.GetLevelSubPropData(data.GetPhantomLevel());
		bool result = true;
		using (List<VisionSubPropData>.Enumerator enumerator = levelSubPropData.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.SlotState != EVisionSlotState.UnlockAndHaveProp)
				{
					result = false;
					break;
				}
			}
		}
		return result;
	}

	// Token: 0x0601037E RID: 66430 RVA: 0x004BBC58 File Offset: 0x004B9E58
	private void RefreshRedItem(PhantomDataBase data)
	{
		bool redItemShowState = this.GetRedItemShowState(data);
		base.GetItem(4).SetUIActive(redItemShowState);
		if (redItemShowState)
		{
			if (!data.GetIfHaveEnoughIdentifyConsumeItem(this.CurrentConsumeSelectNum()))
			{
				base.GetText(5).SetText(ConfigMultiTextLang.GetLocalTextNew("IdentifyNotEnough", null), true);
				return;
			}
			LguiUtil.Instance.SetLocalText(base.GetText(5), "IdentifyNeedLevelText", new <>z__ReadOnlySingleElementList<object>(data.GetNextIdentifyLevel()));
		}
	}

	// Token: 0x0601037F RID: 66431 RVA: 0x004BBCCA File Offset: 0x004B9ECA
	private bool GetRedItemEnoughItemState(PhantomDataBase data)
	{
		return data.GetIfHaveEnoughIdentifyConsumeItem(this.CurrentConsumeSelectNum());
	}

	// Token: 0x06010380 RID: 66432 RVA: 0x004BBCD8 File Offset: 0x004B9ED8
	private bool GetRedItemShowState(PhantomDataBase data)
	{
		bool ifHaveEnoughIdentifyConsumeItem = data.GetIfHaveEnoughIdentifyConsumeItem(this.CurrentConsumeSelectNum());
		bool ifHaveUnIdentifySubProp = data.GetIfHaveUnIdentifySubProp();
		return !this.GetIfNeedShowGreenItem(data) && (!ifHaveUnIdentifySubProp || !ifHaveEnoughIdentifyConsumeItem);
	}

	// Token: 0x06010381 RID: 66433 RVA: 0x004BBD10 File Offset: 0x004B9F10
	private void RefreshItemShowState(PhantomDataBase data)
	{
		bool ifNeedShowGreenItem = this.GetIfNeedShowGreenItem(data);
		bool redItemShowState = this.GetRedItemShowState(data);
		bool flag = ifNeedShowGreenItem || redItemShowState;
		base.GetItem(7).SetUIActive(!flag);
		base.GetItem(11).SetUIActive(!flag);
		if (redItemShowState)
		{
			bool ifHaveEnoughIdentifyConsumeItem = data.GetIfHaveEnoughIdentifyConsumeItem(this.CurrentConsumeSelectNum());
			base.GetItem(2).SetUIActive(!ifHaveEnoughIdentifyConsumeItem);
		}
		if (ifNeedShowGreenItem)
		{
			base.GetItem(2).SetUIActive(false);
		}
		if (!redItemShowState && !ifNeedShowGreenItem)
		{
			base.GetItem(2).SetUIActive(true);
		}
	}

	// Token: 0x06010382 RID: 66434 RVA: 0x004BBD95 File Offset: 0x004B9F95
	public int CurrentConsumeSelectNum()
	{
		return this.NumberSelect.GetSelectNumber();
	}

	// Token: 0x06010383 RID: 66435 RVA: 0x004BBDA2 File Offset: 0x004B9FA2
	public void Update(PhantomDataBase data)
	{
		this.Data = data;
		this.RefreshNumSelectComponent(this.Data);
		this.RefreshView();
	}

	// Token: 0x06010384 RID: 66436 RVA: 0x004BBDBD File Offset: 0x004B9FBD
	public void SetOnChangeValueCallBack(Action call)
	{
		this.OnChangeValueCall = call;
	}

	// Token: 0x06010385 RID: 66437 RVA: 0x004BBDC8 File Offset: 0x004B9FC8
	private void RefreshNumberSelectIdentifyText(PhantomDataBase data)
	{
		if (!data.GetIfHaveEnoughIdentifyConsumeItem(this.CurrentConsumeSelectNum()) && this.CurrentConsumeSelectNum() == 1)
		{
			string numberSelectTipsText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew(TextConfig.Instance.GetTextContentIdById("IdentifyCount"), null), new string[]
			{
				"0"
			});
			this.NumberSelect.SetNumberSelectTipsText(numberSelectTipsText);
		}
	}

	// Token: 0x06010386 RID: 66438 RVA: 0x004BBE24 File Offset: 0x004BA024
	private void RefreshView()
	{
		this.RefreshConsume(this.Data);
		this.RefreshRedItem(this.Data);
		this.RefreshGreenItem(this.Data);
		this.RefreshItemShowState(this.Data);
		this.RefreshItemShow(this.Data);
		this.RefreshStrengthButton();
		this.RefreshNumberSelectIdentifyText(this.Data);
	}

	// Token: 0x04008FDB RID: 36827
	[Nullable(2)]
	private readonly UUIItem SourceItem;

	// Token: 0x04008FDC RID: 36828
	[Nullable(2)]
	private NumberSelectComponent NumberSelect;

	// Token: 0x04008FDD RID: 36829
	[Nullable(2)]
	private PhantomDataBase Data;

	// Token: 0x04008FDE RID: 36830
	[Nullable(2)]
	private ButtonItem StrengthItem;

	// Token: 0x04008FDF RID: 36831
	[Nullable(2)]
	private Action OnChangeValueCall;

	// Token: 0x04008FE0 RID: 36832
	[Nullable(2)]
	private MediumItemGrid ItemGridVariantSelect;

	// Token: 0x02007BDE RID: 31710
	[NullableContext(0)]
	private enum EVisionIdentifyCostItemEnum
	{
		// Token: 0x040281C3 RID: 164291
		TitleText,
		// Token: 0x040281C4 RID: 164292
		MoneyItem,
		// Token: 0x040281C5 RID: 164293
		ConsumeItemParent,
		// Token: 0x040281C6 RID: 164294
		GreenItem,
		// Token: 0x040281C7 RID: 164295
		RedItem,
		// Token: 0x040281C8 RID: 164296
		RedText,
		// Token: 0x040281C9 RID: 164297
		GreenText,
		// Token: 0x040281CA RID: 164298
		IdentifyTitleItem,
		// Token: 0x040281CB RID: 164299
		NumSelectComponent,
		// Token: 0x040281CC RID: 164300
		ConsumeTexture,
		// Token: 0x040281CD RID: 164301
		ConsumeText,
		// Token: 0x040281CE RID: 164302
		ConfirmButtonItem,
		// Token: 0x040281CF RID: 164303
		ItemBase,
		// Token: 0x040281D0 RID: 164304
		ItemDownText
	}
}
