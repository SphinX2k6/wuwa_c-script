using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E41 RID: 7745
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PlotHandBookChildItem : GridProxyAbstract<HandBookCommonItemData>
{
	// Token: 0x0600EB89 RID: 60297 RVA: 0x0037E2E1 File Offset: 0x0037C4E1
	public PlotHandBookChildItem(UUIItem uiItem = null)
	{
		if (uiItem != null)
		{
			this.CreateThenShowByActor(uiItem.GetOwner());
		}
	}

	// Token: 0x0600EB8A RID: 60298 RVA: 0x0037E2F8 File Offset: 0x0037C4F8
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
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.OnClickTextureToggle))
		};
		EventSystem.Instance.Add(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
	}

	// Token: 0x0600EB8B RID: 60299 RVA: 0x0037E3C0 File Offset: 0x0037C5C0
	[NullableContext(1)]
	public override void Refresh(HandBookCommonItemData data, bool isSelected, int gridIndex)
	{
		this.HandBookCommonItemData = data;
		this.GirdIndex = gridIndex;
		PhotographHandBook photographHandBook = (PhotographHandBook)this.HandBookCommonItemData.Config;
		bool isNew = data.IsNew;
		bool isLock = data.IsLock;
		EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
		base.SetTextureByPath((playerGender == EPlayerGender.Male) ? photographHandBook.MaleTexture : photographHandBook.FemaleTexture, base.GetTexture(0), null, null);
		base.GetText(1).ShowTextNew(photographHandBook.Name);
		base.GetItem(2).SetUIActive(isNew);
		base.GetItem(3).SetUIActive(isLock);
		base.GetTexture(0).SetUIActive(!isLock);
		UUIExtendToggle tog = this.GetTog();
		if (tog == null)
		{
			return;
		}
		tog.SetEnable(!isLock);
	}

	// Token: 0x0600EB8C RID: 60300 RVA: 0x0037E484 File Offset: 0x0037C684
	private void OnClickTextureToggle(EToggleState state)
	{
		PhotographHandBook photographHandBook = (PhotographHandBook)this.HandBookCommonItemData.Config;
		if (!this.HandBookCommonItemData.IsLock)
		{
			if (this.HandBookCommonItemData.IsNew)
			{
				HandBookController.Instance.SendIllustratedReadRequest(EHandBookTabType.Quest, photographHandBook.Id);
			}
			int type = photographHandBook.Type;
			List<PhotographHandBook> list = ConfigCommon.ToList<PhotographHandBook>(HandBookConfig.Instance.GetPlotHandBookConfigByType(type));
			list.Sort(new Comparison<PhotographHandBook>(this.SortIndex));
			PlotType? plotTypeConfig = HandBookConfig.Instance.GetPlotTypeConfig(type);
			int count = list.Count;
			List<string> list2 = new List<string>();
			List<string> list3 = new List<string>();
			List<string> list4 = new List<string>();
			List<string> list5 = new List<string>();
			List<string> list6 = new List<string>();
			List<int> list7 = new List<int>();
			for (int i = 0; i < count; i++)
			{
				PhotographHandBook photographHandBook2 = list[i];
				HandBookEntry handBookInfo = HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Quest, photographHandBook2.Id);
				if (handBookInfo != null)
				{
					EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
					list2.Add((playerGender == EPlayerGender.Male) ? photographHandBook2.MaleTexture : photographHandBook2.FemaleTexture);
					list6.Add(handBookInfo.CreateTime);
					string localTextNew = ConfigMultiTextLang.GetLocalTextNew(photographHandBook2.Descrtption, null);
					if (localTextNew != null)
					{
						list3.Add(localTextNew);
					}
					string localTextNew2 = ConfigMultiTextLang.GetLocalTextNew(photographHandBook2.Name, null);
					if (localTextNew2 != null)
					{
						list4.Add(localTextNew2);
					}
					if (plotTypeConfig != null)
					{
						string localTextNew3 = ConfigMultiTextLang.GetLocalTextNew(plotTypeConfig.Value.TypeDescription, null);
						if (localTextNew3 != null)
						{
							list5.Add(localTextNew3);
						}
					}
					list7.Add(photographHandBook2.Id);
				}
			}
			HandBookPhotoData handBookPhotoData = new HandBookPhotoData();
			handBookPhotoData.DescrtptionText = list3;
			handBookPhotoData.TypeText = list5;
			handBookPhotoData.NameText = list4;
			handBookPhotoData.HandBookType = EHandBookTabType.Quest;
			handBookPhotoData.Index = this.GirdIndex;
			handBookPhotoData.TextureList = list2;
			handBookPhotoData.DateText = list6;
			handBookPhotoData.ConfigId = list7.ToArray();
			UiManager.Instance.OpenView(EUiViewName.HandBookPhotoView, handBookPhotoData, null);
			return;
		}
		ScrollingTipsController.Instance.ShowTipsById("CurPlotHandBookLock", Array.Empty<object>());
		UUIExtendToggle tog = this.GetTog();
		if (tog == null)
		{
			return;
		}
		tog.SetToggleStateForce(EToggleState.ETT_UnChecked, false, true, false);
	}

	// Token: 0x0600EB8D RID: 60301 RVA: 0x0037E6B0 File Offset: 0x0037C8B0
	protected void OnHandBookRead(EHandBookTabType type, int id)
	{
		if (type != EHandBookTabType.Quest)
		{
			return;
		}
		HandBookCommonItemData handBookCommonItemData = this.HandBookCommonItemData;
		PhotographHandBook? photographHandBook = ((handBookCommonItemData != null) ? handBookCommonItemData.Config : null) as PhotographHandBook?;
		int? num = (photographHandBook != null) ? new int?(photographHandBook.GetValueOrDefault().Id) : null;
		if (!(id == num.GetValueOrDefault() & num != null))
		{
			return;
		}
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x0600EB8E RID: 60302 RVA: 0x0037E72F File Offset: 0x0037C92F
	private int SortIndex(PhotographHandBook a, PhotographHandBook b)
	{
		return a.Id - b.Id;
	}

	// Token: 0x0600EB8F RID: 60303 RVA: 0x0037E740 File Offset: 0x0037C940
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
		this.HandBookCommonItemData = null;
		this.GirdIndex = 0;
	}

	// Token: 0x0600EB90 RID: 60304 RVA: 0x0037E76C File Offset: 0x0037C96C
	public UUIExtendToggle GetTog()
	{
		return base.GetExtendToggle(4);
	}

	// Token: 0x0600EB91 RID: 60305 RVA: 0x0037E775 File Offset: 0x0037C975
	public HandBookCommonItemData GetData()
	{
		return this.HandBookCommonItemData;
	}

	// Token: 0x0600EB92 RID: 60306 RVA: 0x0037E77D File Offset: 0x0037C97D
	public bool GetIsUnlock()
	{
		return this.HandBookCommonItemData != null && !this.HandBookCommonItemData.IsLock;
	}

	// Token: 0x04006D47 RID: 27975
	private HandBookCommonItemData HandBookCommonItemData;

	// Token: 0x04006D48 RID: 27976
	private int GirdIndex;

	// Token: 0x020083F2 RID: 33778
	[NullableContext(0)]
	private class EGeographyHandBookChildItemDefine
	{
		// Token: 0x0402AF45 RID: 175941
		public const int Texture = 0;

		// Token: 0x0402AF46 RID: 175942
		public const int NameText = 1;

		// Token: 0x0402AF47 RID: 175943
		public const int NewItem = 2;

		// Token: 0x0402AF48 RID: 175944
		public const int GrayItem = 3;

		// Token: 0x0402AF49 RID: 175945
		public const int TextureToggle = 4;
	}
}
