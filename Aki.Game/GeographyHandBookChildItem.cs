using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200129D RID: 4765
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class GeographyHandBookChildItem : GridProxyAbstract<HandBookCommonItemData>
{
	// Token: 0x0600BCC5 RID: 48325 RVA: 0x0037D30E File Offset: 0x0037B50E
	public GeographyHandBookChildItem(UUIItem uiItem = null)
	{
		if (uiItem != null)
		{
			this.CreateThenShowByActor(uiItem.GetOwner());
		}
	}

	// Token: 0x0600BCC6 RID: 48326 RVA: 0x0037D328 File Offset: 0x0037B528
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

	// Token: 0x0600BCC7 RID: 48327 RVA: 0x0037D3AE File Offset: 0x0037B5AE
	protected override void OnStart()
	{
		this.GetTog().SetToggleStateForce(EToggleState.ETT_UnChecked, false, true, false);
	}

	// Token: 0x0600BCC8 RID: 48328 RVA: 0x0037D3C0 File Offset: 0x0037B5C0
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

	// Token: 0x0600BCC9 RID: 48329 RVA: 0x0037D46E File Offset: 0x0037B66E
	private void OnTextureToggleClick(EToggleState state)
	{
		this.ToggleClick();
	}

	// Token: 0x0600BCCA RID: 48330 RVA: 0x0037D478 File Offset: 0x0037B678
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

	// Token: 0x0600BCCB RID: 48331 RVA: 0x0037D65B File Offset: 0x0037B85B
	public HandBookCommonItemData GetData()
	{
		return this.HandBookCommonItemData;
	}

	// Token: 0x0600BCCC RID: 48332 RVA: 0x0037D663 File Offset: 0x0037B863
	public void SetNewState(bool isNew)
	{
		base.GetItem(2).SetUIActive(isNew);
	}

	// Token: 0x0600BCCD RID: 48333 RVA: 0x0037D672 File Offset: 0x0037B872
	public void SetToggleState(EToggleState state)
	{
		base.GetExtendToggle(4).SetToggleStateForce(state, false, true, false);
		if (state == EToggleState.ETT_Checked)
		{
			this.ReadHandBook();
		}
	}

	// Token: 0x0600BCCE RID: 48334 RVA: 0x0037D690 File Offset: 0x0037B890
	private void ReadHandBook()
	{
		if (this.HandBookCommonItemData.IsNew)
		{
			GeographyHandBook geographyHandBook = (GeographyHandBook)this.HandBookCommonItemData.Config;
			HandBookController.Instance.SendIllustratedReadRequest(EHandBookTabType.Geography, geographyHandBook.Id);
		}
	}

	// Token: 0x0600BCCF RID: 48335 RVA: 0x0037D6CD File Offset: 0x0037B8CD
	private int SortIndex(GeographyHandBook a, GeographyHandBook b)
	{
		if (a.Type == b.Type)
		{
			return a.Id - b.Id;
		}
		return a.Type - b.Type;
	}

	// Token: 0x0600BCD0 RID: 48336 RVA: 0x0037D6FE File Offset: 0x0037B8FE
	protected override void OnBeforeDestroy()
	{
		this.HandBookCommonItemData = null;
	}

	// Token: 0x0600BCD1 RID: 48337 RVA: 0x0037D707 File Offset: 0x0037B907
	public UUIExtendToggle GetTog()
	{
		return base.GetExtendToggle(4);
	}

	// Token: 0x0600BCD2 RID: 48338 RVA: 0x0037D710 File Offset: 0x0037B910
	public bool GetIsUnlock()
	{
		return this.HandBookCommonItemData != null && !this.HandBookCommonItemData.IsLock;
	}

	// Token: 0x0600BCD3 RID: 48339 RVA: 0x0037D72A File Offset: 0x0037B92A
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

	// Token: 0x0600BCD4 RID: 48340 RVA: 0x0037D752 File Offset: 0x0037B952
	private void AddToggleEvent()
	{
		UUIExtendToggle tog = this.GetTog();
		if (tog == null)
		{
			return;
		}
		tog.OnStateChange.Add(new Action<EToggleState>(this.OnTextureToggleClick));
	}

	// Token: 0x04006CA4 RID: 27812
	private HandBookCommonItemData HandBookCommonItemData;
}
