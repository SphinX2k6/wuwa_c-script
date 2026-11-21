using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001297 RID: 4759
[NullableContext(2)]
[Nullable(0)]
public class HandBookChipToggleItem : UiPanelBase
{
	// Token: 0x0600BC94 RID: 48276 RVA: 0x0037BBE4 File Offset: 0x00379DE4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(5, new Action<EToggleState>(this.OnToggleClicked))
		};
	}

	// Token: 0x0600BC95 RID: 48277 RVA: 0x0037BCB9 File Offset: 0x00379EB9
	protected override void OnStart()
	{
		this.ItemGrid = new SmallItemGrid();
		this.ItemGrid.Initialize(base.GetItem(0).GetOwner());
	}

	// Token: 0x0600BC96 RID: 48278 RVA: 0x0037BCE0 File Offset: 0x00379EE0
	[NullableContext(1)]
	public void Refresh(HandBookCommonItemData data, bool isSelect)
	{
		this.HandBookCommonItemData = data;
		ChipHandBook chipHandBook = (ChipHandBook)data.Config;
		PropSmallItemGrid parameters = new PropSmallItemGrid
		{
			Data = data,
			IconPath = data.Icon,
			QualityId = new int?(data.QualityId)
		};
		this.ItemGrid.Apply<PropSmallItemGrid>(parameters);
		this.ItemGrid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
		bool flag = this.CheckIsCanShowChildList(chipHandBook.Id);
		base.GetText(2).SetText(flag ? this.HandBookCommonItemData.Title : ConfigMultiTextLang.GetLocalTextNew("Text_Unknown_Text", null), true);
		base.GetItem(4).SetUIActive(!flag);
		base.GetItem(1).SetUIActive(flag && isSelect);
		base.GetItem(6).SetUIActive(flag && !isSelect);
		bool uiactive = this.CheckNewState(chipHandBook.Id);
		base.GetItem(3).SetUIActive(uiactive);
		base.GetExtendToggle(5).SetToggleState(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600BC97 RID: 48279 RVA: 0x0037BE00 File Offset: 0x0037A000
	public bool CheckIsCanShowChildList(int type)
	{
		IReadOnlyList<ChipHandBook> chipHandBookConfigList = HandBookConfig.Instance.GetChipHandBookConfigList(type);
		int num = (chipHandBookConfigList != null) ? chipHandBookConfigList.Count : 0;
		bool result = false;
		for (int i = 0; i < num; i++)
		{
			ChipHandBook chipHandBook = chipHandBookConfigList[i];
			if (HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Chip, chipHandBook.Id) != null)
			{
				result = true;
				break;
			}
		}
		return result;
	}

	// Token: 0x0600BC98 RID: 48280 RVA: 0x0037BE58 File Offset: 0x0037A058
	public bool CheckNewState(int type)
	{
		IReadOnlyList<ChipHandBook> chipHandBookConfigList = HandBookConfig.Instance.GetChipHandBookConfigList(type);
		int num = (chipHandBookConfigList != null) ? chipHandBookConfigList.Count : 0;
		bool result = false;
		for (int i = 0; i < num; i++)
		{
			ChipHandBook chipHandBook = chipHandBookConfigList[i];
			HandBookEntry handBookInfo = HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Chip, chipHandBook.Id);
			if (handBookInfo != null && !handBookInfo.IsRead)
			{
				result = true;
				break;
			}
		}
		return result;
	}

	// Token: 0x0600BC99 RID: 48281 RVA: 0x0037BEC0 File Offset: 0x0037A0C0
	public void RefreshNewState()
	{
		if (this.HandBookCommonItemData == null)
		{
			return;
		}
		bool uiactive = this.CheckNewState(((ChipHandBook)this.HandBookCommonItemData.Config).Id);
		base.GetItem(3).SetUIActive(uiactive);
	}

	// Token: 0x0600BC9A RID: 48282 RVA: 0x0037BF04 File Offset: 0x0037A104
	private void OnToggleClicked(EToggleState state)
	{
		bool flag = state == EToggleState.ETT_Checked;
		if (!flag)
		{
			return;
		}
		ChipHandBook chipHandBook = (ChipHandBook)this.HandBookCommonItemData.Config;
		bool flag2 = this.CheckIsCanShowChildList(chipHandBook.Id);
		base.GetItem(1).SetUIActive(flag2);
		base.GetItem(6).SetUIActive(false);
		base.GetItem(4).SetUIActive(!flag2);
		if (this.OnToggleCallback != null && flag)
		{
			this.OnToggleCallback(chipHandBook.Id);
		}
	}

	// Token: 0x0600BC9B RID: 48283 RVA: 0x0037BF82 File Offset: 0x0037A182
	[NullableContext(1)]
	public void BindToggleCallback(TChipToggleFunction toggleFunction)
	{
		this.OnToggleCallback = toggleFunction;
	}

	// Token: 0x04006C67 RID: 27751
	private TChipToggleFunction OnToggleCallback;

	// Token: 0x04006C68 RID: 27752
	private SmallItemGrid ItemGrid;

	// Token: 0x04006C69 RID: 27753
	private HandBookCommonItemData HandBookCommonItemData;
}
