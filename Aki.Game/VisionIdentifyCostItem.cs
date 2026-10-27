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

// Token: 0x020024CB RID: 9419
[NullableContext(1)]
[Nullable(0)]
internal class VisionIdentifyCostItem : UiPanelBase
{
	// Token: 0x06012EB0 RID: 77488 RVA: 0x004ADA5D File Offset: 0x004ABC5D
	public VisionIdentifyCostItem(UUIItem uiItem)
	{
		this.SourceItem = uiItem;
	}

	// Token: 0x06012EB1 RID: 77489 RVA: 0x004ADA6C File Offset: 0x004ABC6C
	public void Init()
	{
		base.SetRootActor(this.SourceItem.GetOwner(), true);
	}

	// Token: 0x06012EB2 RID: 77490 RVA: 0x004ADA80 File Offset: 0x004ABC80
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

	// Token: 0x06012EB3 RID: 77491 RVA: 0x004ADBD4 File Offset: 0x004ABDD4
	protected override void OnStart()
	{
		this.NumberSelect = new NumberSelectComponent(base.GetItem(8));
		this.StrengthItem = new ButtonItem(base.GetItem(11));
		this.StrengthItem.SetFunction(new Action<int>(this.OnClickStrengthButton));
		this.ItemGridVariantSelect = new MediumItemGrid();
		this.ItemGridVariantSelect.Initialize(base.GetItem(12).GetOwner());
		this.ItemGridVariantSelect.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnClickedRewardItem));
	}

	// Token: 0x06012EB4 RID: 77492 RVA: 0x004ADC58 File Offset: 0x004ABE58
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
		ItemController.Instance.OpenItemTipsByItemId(currentIdentifyCostId, true, null);
	}

	// Token: 0x06012EB5 RID: 77493 RVA: 0x004ADCCC File Offset: 0x004ABECC
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

	// Token: 0x06012EB6 RID: 77494 RVA: 0x004ADD30 File Offset: 0x004ABF30
	private UniTask RequestIdentify()
	{
		VisionIdentifyCostItem.<RequestIdentify>d__13 <RequestIdentify>d__;
		<RequestIdentify>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestIdentify>d__.<>4__this = this;
		<RequestIdentify>d__.<>1__state = -1;
		<RequestIdentify>d__.<>t__builder.Start<VisionIdentifyCostItem.<RequestIdentify>d__13>(ref <RequestIdentify>d__);
		return <RequestIdentify>d__.<>t__builder.Task;
	}

	// Token: 0x06012EB7 RID: 77495 RVA: 0x004ADD73 File Offset: 0x004ABF73
	private TableTextArgNew GetExchangeTableText(int selectValue)
	{
		return new TableTextArgNew(TextConfig.Instance.GetTextContentIdById("IdentifyCount"), new <>z__ReadOnlySingleElementList<object>(selectValue));
	}

	// Token: 0x06012EB8 RID: 77496 RVA: 0x004ADD94 File Offset: 0x004ABF94
	private void RefreshStrengthButton()
	{
	}

	// Token: 0x06012EB9 RID: 77497 RVA: 0x004ADD96 File Offset: 0x004ABF96
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

	// Token: 0x06012EBA RID: 77498 RVA: 0x004ADDB0 File Offset: 0x004ABFB0
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

	// Token: 0x06012EBB RID: 77499 RVA: 0x004ADEC0 File Offset: 0x004AC0C0
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

	// Token: 0x06012EBC RID: 77500 RVA: 0x004ADF58 File Offset: 0x004AC158
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

	// Token: 0x06012EBD RID: 77501 RVA: 0x004ADFD4 File Offset: 0x004AC1D4
	private void RefreshGreenItem(PhantomDataBase data)
	{
		bool ifNeedShowGreenItem = this.GetIfNeedShowGreenItem(data);
		base.GetItem(3).SetUIActive(ifNeedShowGreenItem);
	}

	// Token: 0x06012EBE RID: 77502 RVA: 0x004ADFF8 File Offset: 0x004AC1F8
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

	// Token: 0x06012EBF RID: 77503 RVA: 0x004AE058 File Offset: 0x004AC258
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

	// Token: 0x06012EC0 RID: 77504 RVA: 0x004AE0CA File Offset: 0x004AC2CA
	private bool GetRedItemEnoughItemState(PhantomDataBase data)
	{
		return data.GetIfHaveEnoughIdentifyConsumeItem(this.CurrentConsumeSelectNum());
	}

	// Token: 0x06012EC1 RID: 77505 RVA: 0x004AE0D8 File Offset: 0x004AC2D8
	private bool GetRedItemShowState(PhantomDataBase data)
	{
		bool ifHaveEnoughIdentifyConsumeItem = data.GetIfHaveEnoughIdentifyConsumeItem(this.CurrentConsumeSelectNum());
		bool ifHaveUnIdentifySubProp = data.GetIfHaveUnIdentifySubProp();
		return !this.GetIfNeedShowGreenItem(data) && (!ifHaveUnIdentifySubProp || !ifHaveEnoughIdentifyConsumeItem);
	}

	// Token: 0x06012EC2 RID: 77506 RVA: 0x004AE110 File Offset: 0x004AC310
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

	// Token: 0x06012EC3 RID: 77507 RVA: 0x004AE195 File Offset: 0x004AC395
	public int CurrentConsumeSelectNum()
	{
		return this.NumberSelect.GetSelectNumber();
	}

	// Token: 0x06012EC4 RID: 77508 RVA: 0x004AE1A2 File Offset: 0x004AC3A2
	public void Update(PhantomDataBase data)
	{
		this.Data = data;
		this.RefreshNumSelectComponent(this.Data);
		this.RefreshView();
	}

	// Token: 0x06012EC5 RID: 77509 RVA: 0x004AE1BD File Offset: 0x004AC3BD
	public void SetOnChangeValueCallBack(Action call)
	{
		this.OnChangeValueCall = call;
	}

	// Token: 0x06012EC6 RID: 77510 RVA: 0x004AE1C8 File Offset: 0x004AC3C8
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

	// Token: 0x06012EC7 RID: 77511 RVA: 0x004AE224 File Offset: 0x004AC424
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

	// Token: 0x04008E91 RID: 36497
	[Nullable(2)]
	private readonly UUIItem SourceItem;

	// Token: 0x04008E92 RID: 36498
	[Nullable(2)]
	private NumberSelectComponent NumberSelect;

	// Token: 0x04008E93 RID: 36499
	[Nullable(2)]
	private PhantomDataBase Data;

	// Token: 0x04008E94 RID: 36500
	[Nullable(2)]
	private ButtonItem StrengthItem;

	// Token: 0x04008E95 RID: 36501
	[Nullable(2)]
	private Action OnChangeValueCall;

	// Token: 0x04008E96 RID: 36502
	[Nullable(2)]
	private MediumItemGrid ItemGridVariantSelect;

	// Token: 0x02008A55 RID: 35413
	[NullableContext(0)]
	private enum EVisionIdentifyCostItemEnum
	{
		// Token: 0x0402CEA5 RID: 183973
		TitleText,
		// Token: 0x0402CEA6 RID: 183974
		MoneyItem,
		// Token: 0x0402CEA7 RID: 183975
		ConsumeItemParent,
		// Token: 0x0402CEA8 RID: 183976
		GreenItem,
		// Token: 0x0402CEA9 RID: 183977
		RedItem,
		// Token: 0x0402CEAA RID: 183978
		RedText,
		// Token: 0x0402CEAB RID: 183979
		GreenText,
		// Token: 0x0402CEAC RID: 183980
		IdentifyTitleItem,
		// Token: 0x0402CEAD RID: 183981
		NumSelectComponent,
		// Token: 0x0402CEAE RID: 183982
		ConsumeTexture,
		// Token: 0x0402CEAF RID: 183983
		ConsumeText,
		// Token: 0x0402CEB0 RID: 183984
		ConfirmButtonItem,
		// Token: 0x0402CEB1 RID: 183985
		ItemBase,
		// Token: 0x0402CEB2 RID: 183986
		ItemDownText
	}
}
