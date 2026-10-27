using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001DDB RID: 7643
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class GeographyHandBookChildItem : GridProxyAbstract<HandBookCommonItemData>
{
	// Token: 0x0600E8A6 RID: 59558 RVA: 0x00371622 File Offset: 0x0036F822
	public GeographyHandBookChildItem(UUIItem uiItem = null)
	{
		if (uiItem != null)
		{
			this.CreateThenShowByActor(uiItem.GetOwner());
		}
	}

	// Token: 0x0600E8A7 RID: 59559 RVA: 0x0037163C File Offset: 0x0036F83C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIExtendToggle))
		};
	}

	// Token: 0x0600E8A8 RID: 59560 RVA: 0x003716C2 File Offset: 0x0036F8C2
	protected override void OnStart()
	{
		this.GetTog().SetToggleStateForce(EToggleState.ETT_UnChecked, false, true, false);
	}

	// Token: 0x0600E8A9 RID: 59561 RVA: 0x003716D4 File Offset: 0x0036F8D4
	[NullableContext(1)]
	public override void Refresh(HandBookCommonItemData data, bool isSelected, int gridIndex)
	{
		this.HandBookCommonItemData = data;
		GeographyHandBook geographyHandBook = (GeographyHandBook)this.HandBookCommonItemData.Config;
		bool isNew = data.IsNew;
		bool isLock = data.IsLock;
		base.SetTextureByPath(geographyHandBook.Texture, base.GetTexture(0), null, null);
		base.GetText(1).ShowTextNew(geographyHandBook.Name);
		base.GetItem(2).SetUIActive(isNew);
		base.GetTexture(0).SetUIActive(!isLock);
		base.GetItem(3).SetUIActive(isLock);
		this.ClearToggleEvent();
		this.AddToggleEvent();
		UUIExtendToggle tog = this.GetTog();
		if (tog == null)
		{
			return;
		}
		tog.SetEnable(!isLock);
	}

	// Token: 0x0600E8AA RID: 59562 RVA: 0x00371782 File Offset: 0x0036F982
	private void OnTextureToggleClick(EToggleState state)
	{
		this.ToggleClick();
	}

	// Token: 0x0600E8AB RID: 59563 RVA: 0x0037178C File Offset: 0x0036F98C
	public void ToggleClick()
	{
		GeographyHandBook geographyHandBook = (GeographyHandBook)this.HandBookCommonItemData.Config;
		if (this.HandBookCommonItemData.IsLock)
		{
			ScrollingTipsController.Instance.ShowTipsById("CurGeographyHandBookLock", Array.Empty<object>());
			this.SetToggleState(EToggleState.ETT_UnChecked);
			return;
		}
		this.ReadHandBook();
		List<GeographyHandBook> list = ConfigCommon.ToList<GeographyHandBook>(HandBookConfig.Instance.GetGeographyHandBookConfigByTabType(geographyHandBook.GeographyTabType));
		list.Sort(new Comparison<GeographyHandBook>(this.SortIndex));
		int count = list.Count;
		List<string> list2 = new List<string>();
		List<string> list3 = new List<string>();
		List<string> list4 = new List<string>();
		List<string> list5 = new List<string>();
		List<string> list6 = new List<string>();
		List<int> list7 = new List<int>();
		int index = 0;
		for (int i = 0; i < count; i++)
		{
			GeographyHandBook geographyHandBook2 = list[i];
			HandBookEntry handBookInfo = HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Geography, geographyHandBook2.Id);
			if (handBookInfo != null)
			{
				list2.Add(geographyHandBook2.Texture);
				list6.Add(handBookInfo.CreateTime);
				list3.Add(ConfigMultiTextLang.GetLocalTextNew(geographyHandBook2.Descrtption, null));
				list4.Add(ConfigMultiTextLang.GetLocalTextNew(geographyHandBook2.Name, null));
				list5.Add(ConfigMultiTextLang.GetLocalTextNew(HandBookConfig.Instance.GetGeographyTypeConfig(geographyHandBook2.Type).Value.TypeDescription, null));
				list7.Add(geographyHandBook2.Id);
				if (geographyHandBook2.Id == geographyHandBook.Id)
				{
					index = list2.Count - 1;
				}
			}
		}
		HandBookPhotoData handBookPhotoData = new HandBookPhotoData();
		handBookPhotoData.DescrtptionText = list3;
		handBookPhotoData.TypeText = list5;
		handBookPhotoData.NameText = list4;
		handBookPhotoData.HandBookType = EHandBookTabType.Geography;
		handBookPhotoData.Index = index;
		handBookPhotoData.TextureList = list2;
		handBookPhotoData.DateText = list6;
		handBookPhotoData.ConfigId = list7.ToArray();
		UiManager.Instance.OpenView(EUiViewName.HandBookPhotoView, handBookPhotoData, null);
	}

	// Token: 0x0600E8AC RID: 59564 RVA: 0x0037196F File Offset: 0x0036FB6F
	public HandBookCommonItemData GetData()
	{
		return this.HandBookCommonItemData;
	}

	// Token: 0x0600E8AD RID: 59565 RVA: 0x00371977 File Offset: 0x0036FB77
	public void SetNewState(bool isNew)
	{
		base.GetItem(2).SetUIActive(isNew);
	}

	// Token: 0x0600E8AE RID: 59566 RVA: 0x00371986 File Offset: 0x0036FB86
	public void SetToggleState(EToggleState state)
	{
		base.GetExtendToggle(4).SetToggleStateForce(state, false, true, false);
		if (state == EToggleState.ETT_Checked)
		{
			this.ReadHandBook();
		}
	}

	// Token: 0x0600E8AF RID: 59567 RVA: 0x003719A4 File Offset: 0x0036FBA4
	private void ReadHandBook()
	{
		if (this.HandBookCommonItemData.IsNew)
		{
			GeographyHandBook geographyHandBook = (GeographyHandBook)this.HandBookCommonItemData.Config;
			HandBookController.Instance.SendIllustratedReadRequest(EHandBookTabType.Geography, geographyHandBook.Id);
		}
	}

	// Token: 0x0600E8B0 RID: 59568 RVA: 0x003719E1 File Offset: 0x0036FBE1
	private int SortIndex(GeographyHandBook a, GeographyHandBook b)
	{
		if (a.Type == b.Type)
		{
			return a.Id - b.Id;
		}
		return a.Type - b.Type;
	}

	// Token: 0x0600E8B1 RID: 59569 RVA: 0x00371A12 File Offset: 0x0036FC12
	protected override void OnBeforeDestroy()
	{
		this.HandBookCommonItemData = null;
	}

	// Token: 0x0600E8B2 RID: 59570 RVA: 0x00371A1B File Offset: 0x0036FC1B
	public UUIExtendToggle GetTog()
	{
		return base.GetExtendToggle(4);
	}

	// Token: 0x0600E8B3 RID: 59571 RVA: 0x00371A24 File Offset: 0x0036FC24
	public bool GetIsUnlock()
	{
		return this.HandBookCommonItemData != null && !this.HandBookCommonItemData.IsLock;
	}

	// Token: 0x0600E8B4 RID: 59572 RVA: 0x00371A3E File Offset: 0x0036FC3E
	private void ClearToggleEvent()
	{
		UUIExtendToggle tog = this.GetTog();
		if (tog != null)
		{
			tog.OnStateChange.Clear();
		}
		if (tog == null)
		{
			return;
		}
		tog.CanExecuteChange.Unbind();
	}

	// Token: 0x0600E8B5 RID: 59573 RVA: 0x00371A66 File Offset: 0x0036FC66
	private void AddToggleEvent()
	{
		UUIExtendToggle tog = this.GetTog();
		if (tog == null)
		{
			return;
		}
		tog.OnStateChange.Add(new Action<EToggleState>(this.OnTextureToggleClick));
	}

	// Token: 0x04006BC3 RID: 27587
	private HandBookCommonItemData HandBookCommonItemData;
}
