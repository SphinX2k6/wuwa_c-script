using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E3C RID: 7740
[NullableContext(2)]
[Nullable(0)]
internal class HandBookNounToggleItem : UiPanelBase
{
	// Token: 0x0600EB42 RID: 60226 RVA: 0x0037C494 File Offset: 0x0037A694
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

	// Token: 0x0600EB43 RID: 60227 RVA: 0x0037C569 File Offset: 0x0037A769
	protected override void OnStart()
	{
		this.ItemGrid = new SmallItemGrid();
		this.ItemGrid.Initialize(base.GetItem(0).GetOwner());
	}

	// Token: 0x0600EB44 RID: 60228 RVA: 0x0037C590 File Offset: 0x0037A790
	[NullableContext(1)]
	public void Refresh(HandBookCommonItemData data, bool isSelect)
	{
		this.HandBookCommonItemData = data;
		NounType nounType = (NounType)data.Config;
		PropSmallItemGrid parameters = new PropSmallItemGrid
		{
			Data = data,
			IconPath = data.Icon,
			QualityId = new int?(data.QualityId)
		};
		this.ItemGrid.Apply<PropSmallItemGrid>(parameters);
		this.ItemGrid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
		bool flag = this.CheckIsCanShowChildList(nounType.Id);
		string newText = flag ? this.HandBookCommonItemData.Title : (ConfigMultiTextLang.GetLocalTextNew("Text_Unknown_Text", null) ?? "");
		base.GetText(2).SetText(newText, true);
		base.GetItem(4).SetUIActive(!flag);
		base.GetItem(1).SetUIActive(flag && isSelect);
		base.GetItem(6).SetUIActive(flag && !isSelect);
		bool uiactive = this.CheckNewState(nounType.Id);
		base.GetItem(3).SetUIActive(uiactive);
		base.GetExtendToggle(5).SetToggleState(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600EB45 RID: 60229 RVA: 0x0037C6BC File Offset: 0x0037A8BC
	public bool CheckIsCanShowChildList(int type)
	{
		IReadOnlyList<NounHandBook> nounHandBookConfigList = HandBookConfig.Instance.GetNounHandBookConfigList(type);
		int num = (nounHandBookConfigList != null) ? nounHandBookConfigList.Count : 0;
		bool result = false;
		for (int i = 0; i < num; i++)
		{
			NounHandBook nounHandBook = nounHandBookConfigList[i];
			if (HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Noun, nounHandBook.Id) != null)
			{
				result = true;
				break;
			}
		}
		return result;
	}

	// Token: 0x0600EB46 RID: 60230 RVA: 0x0037C714 File Offset: 0x0037A914
	public bool CheckNewState(int type)
	{
		IReadOnlyList<NounHandBook> nounHandBookConfigList = HandBookConfig.Instance.GetNounHandBookConfigList(type);
		int num = (nounHandBookConfigList != null) ? nounHandBookConfigList.Count : 0;
		bool result = false;
		for (int i = 0; i < num; i++)
		{
			NounHandBook nounHandBook = nounHandBookConfigList[i];
			HandBookEntry handBookInfo = HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Noun, nounHandBook.Id);
			if (handBookInfo != null && !handBookInfo.IsRead)
			{
				result = true;
				break;
			}
		}
		return result;
	}

	// Token: 0x0600EB47 RID: 60231 RVA: 0x0037C77C File Offset: 0x0037A97C
	public void RefreshNewState()
	{
		if (this.HandBookCommonItemData == null)
		{
			return;
		}
		bool uiactive = this.CheckNewState(((NounType)this.HandBookCommonItemData.Config).Id);
		base.GetItem(3).SetUIActive(uiactive);
	}

	// Token: 0x0600EB48 RID: 60232 RVA: 0x0037C7C0 File Offset: 0x0037A9C0
	private void OnToggleClicked(EToggleState state)
	{
		bool flag = state == EToggleState.ETT_Checked;
		if (!flag)
		{
			return;
		}
		NounType nounType = (NounType)this.HandBookCommonItemData.Config;
		bool flag2 = this.CheckIsCanShowChildList(nounType.Id);
		base.GetItem(1).SetUIActive(flag2);
		base.GetItem(6).SetUIActive(false);
		base.GetItem(4).SetUIActive(!flag2);
		if (this.OnToggleCallback != null && flag)
		{
			this.OnToggleCallback(nounType.Id);
		}
	}

	// Token: 0x0600EB49 RID: 60233 RVA: 0x0037C83E File Offset: 0x0037AA3E
	[NullableContext(1)]
	public void BindToggleCallback(TNounToggleFunction toggleFunction)
	{
		this.OnToggleCallback = toggleFunction;
	}

	// Token: 0x04006D29 RID: 27945
	private TNounToggleFunction OnToggleCallback;

	// Token: 0x04006D2A RID: 27946
	private SmallItemGrid ItemGrid;

	// Token: 0x04006D2B RID: 27947
	private HandBookCommonItemData HandBookCommonItemData;
}
