using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020012FE RID: 4862
[NullableContext(2)]
[Nullable(0)]
internal class HandBookNounToggleItem : UiPanelBase
{
	// Token: 0x0600BF61 RID: 48993 RVA: 0x00388134 File Offset: 0x00386334
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

	// Token: 0x0600BF62 RID: 48994 RVA: 0x00388209 File Offset: 0x00386409
	protected override void OnStart()
	{
		this.ItemGrid = new SmallItemGrid();
		this.ItemGrid.Initialize(base.GetItem(0).GetOwner());
	}

	// Token: 0x0600BF63 RID: 48995 RVA: 0x00388230 File Offset: 0x00386430
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

	// Token: 0x0600BF64 RID: 48996 RVA: 0x0038835C File Offset: 0x0038655C
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

	// Token: 0x0600BF65 RID: 48997 RVA: 0x003883B4 File Offset: 0x003865B4
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

	// Token: 0x0600BF66 RID: 48998 RVA: 0x0038841C File Offset: 0x0038661C
	public void RefreshNewState()
	{
		if (this.HandBookCommonItemData == null)
		{
			return;
		}
		bool uiactive = this.CheckNewState(((NounType)this.HandBookCommonItemData.Config).Id);
		base.GetItem(3).SetUIActive(uiactive);
	}

	// Token: 0x0600BF67 RID: 48999 RVA: 0x00388460 File Offset: 0x00386660
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

	// Token: 0x0600BF68 RID: 49000 RVA: 0x003884DE File Offset: 0x003866DE
	[NullableContext(1)]
	public void BindToggleCallback(TNounToggleFunction toggleFunction)
	{
		this.OnToggleCallback = toggleFunction;
	}

	// Token: 0x04006E0A RID: 28170
	private TNounToggleFunction OnToggleCallback;

	// Token: 0x04006E0B RID: 28171
	private SmallItemGrid ItemGrid;

	// Token: 0x04006E0C RID: 28172
	private HandBookCommonItemData HandBookCommonItemData;
}
