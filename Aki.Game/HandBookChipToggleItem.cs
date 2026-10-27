using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001DD5 RID: 7637
[NullableContext(2)]
[Nullable(0)]
public class HandBookChipToggleItem : UiPanelBase
{
	// Token: 0x0600E875 RID: 59509 RVA: 0x0036FEF8 File Offset: 0x0036E0F8
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

	// Token: 0x0600E876 RID: 59510 RVA: 0x0036FFCD File Offset: 0x0036E1CD
	protected override void OnStart()
	{
		this.ItemGrid = new SmallItemGrid();
		this.ItemGrid.Initialize(base.GetItem(0).GetOwner());
	}

	// Token: 0x0600E877 RID: 59511 RVA: 0x0036FFF4 File Offset: 0x0036E1F4
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

	// Token: 0x0600E878 RID: 59512 RVA: 0x00370114 File Offset: 0x0036E314
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

	// Token: 0x0600E879 RID: 59513 RVA: 0x0037016C File Offset: 0x0036E36C
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

	// Token: 0x0600E87A RID: 59514 RVA: 0x003701D4 File Offset: 0x0036E3D4
	public void RefreshNewState()
	{
		if (this.HandBookCommonItemData == null)
		{
			return;
		}
		bool uiactive = this.CheckNewState(((ChipHandBook)this.HandBookCommonItemData.Config).Id);
		base.GetItem(3).SetUIActive(uiactive);
	}

	// Token: 0x0600E87B RID: 59515 RVA: 0x00370218 File Offset: 0x0036E418
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

	// Token: 0x0600E87C RID: 59516 RVA: 0x00370296 File Offset: 0x0036E496
	[NullableContext(1)]
	public void BindToggleCallback(TChipToggleFunction toggleFunction)
	{
		this.OnToggleCallback = toggleFunction;
	}

	// Token: 0x04006B86 RID: 27526
	private TChipToggleFunction OnToggleCallback;

	// Token: 0x04006B87 RID: 27527
	private SmallItemGrid ItemGrid;

	// Token: 0x04006B88 RID: 27528
	private HandBookCommonItemData HandBookCommonItemData;
}
