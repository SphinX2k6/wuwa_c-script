using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020012D2 RID: 4818
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class HandBookQuestChildItem : GridProxyAbstract<HandBookCommonItemData>
{
	// Token: 0x0600BE2F RID: 48687 RVA: 0x0038215C File Offset: 0x0038035C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUISprite)),
			new ValueTuple<int, Type>(7, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIExtendToggle))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.OnTextureToggleClick))
		};
	}

	// Token: 0x0600BE30 RID: 48688 RVA: 0x00382248 File Offset: 0x00380448
	[NullableContext(1)]
	public override void Refresh(HandBookCommonItemData data, bool isSelected, int gridIndex)
	{
		base.SetUiActive(false);
		this.HandBookCommonItemData = data;
		this.GirdIndex = gridIndex;
		PhotographHandBook photographHandBook = (PhotographHandBook)this.HandBookCommonItemData.Config;
		bool isNew = data.IsNew;
		bool isLock = data.IsLock;
		EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
		base.SetTextureByPath((playerGender == EPlayerGender.Male) ? photographHandBook.MaleTexture : photographHandBook.FemaleTexture, base.GetTexture(0), null, delegate(bool success)
		{
			base.SetUiActive(true);
		});
		base.GetText(1).ShowTextNew(photographHandBook.Name);
		base.GetItem(2).SetUIActive(isNew);
		base.GetTexture(0).SetUIActive(!isLock);
		UUIExtendToggle tog = this.GetTog();
		if (tog != null)
		{
			tog.SetEnable(!isLock);
		}
		if (string.IsNullOrEmpty(photographHandBook.AreaIcon) && string.IsNullOrEmpty(photographHandBook.AreaNumber))
		{
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(false);
			}
		}
		else
		{
			UUIItem item2 = base.GetItem(4);
			if (item2 != null)
			{
				item2.SetUIActive(true);
			}
			this.SetSpriteByPath(photographHandBook.AreaIcon, base.GetSprite(6), false, null, null);
			base.SetTextureByPath(photographHandBook.AreaNumber, base.GetTexture(7), null, null);
		}
		if (!string.IsNullOrEmpty(photographHandBook.RoleName))
		{
			UUIText text = base.GetText(5);
			if (text != null)
			{
				text.SetUIActive(true);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), photographHandBook.RoleName, Array.Empty<object>());
			return;
		}
		UUIText text2 = base.GetText(5);
		if (text2 == null)
		{
			return;
		}
		text2.SetUIActive(false);
	}

	// Token: 0x0600BE31 RID: 48689 RVA: 0x003823E4 File Offset: 0x003805E4
	private void OnTextureToggleClick(EToggleState toggleState)
	{
		HandBookCommonItemData handBookCommonItemData = this.HandBookCommonItemData;
		PhotographHandBook? photographHandBook = (PhotographHandBook?)((handBookCommonItemData != null) ? handBookCommonItemData.Config : null);
		if (photographHandBook == null)
		{
			return;
		}
		if (photographHandBook.Value.QuestId != 0)
		{
			this.OnPressQuest(photographHandBook.Value.Type);
			return;
		}
		this.OnPressPhoto(photographHandBook.Value.Type);
	}

	// Token: 0x0600BE32 RID: 48690 RVA: 0x0038244F File Offset: 0x0038064F
	public HandBookCommonItemData GetData()
	{
		return this.HandBookCommonItemData;
	}

	// Token: 0x0600BE33 RID: 48691 RVA: 0x00382457 File Offset: 0x00380657
	public void SetNewState(bool isNew)
	{
		base.GetItem(2).SetUIActive(isNew);
	}

	// Token: 0x0600BE34 RID: 48692 RVA: 0x00382466 File Offset: 0x00380666
	public void SetToggleState(EToggleState state)
	{
		base.GetExtendToggle(3).SetToggleStateForce(state, false, true, false);
		if (state == EToggleState.ETT_Checked)
		{
			this.ReadHandBook();
		}
	}

	// Token: 0x0600BE35 RID: 48693 RVA: 0x00382484 File Offset: 0x00380684
	private void ReadHandBook()
	{
		if (this.HandBookCommonItemData.IsNew)
		{
			PhotographHandBook photographHandBook = (PhotographHandBook)this.HandBookCommonItemData.Config;
			int type = photographHandBook.Type;
			PlotType? plotType;
			int? num = (HandBookConfig.Instance.GetPlotTypeConfig(type) != null) ? new int?(plotType.GetValueOrDefault().Type) : null;
			if (num != null)
			{
				HandBookController.Instance.SendIllustratedReadRequest((EHandBookTabType)num.Value, photographHandBook.Id);
			}
		}
	}

	// Token: 0x0600BE36 RID: 48694 RVA: 0x0038250F File Offset: 0x0038070F
	protected override void OnBeforeDestroy()
	{
		this.HandBookCommonItemData = null;
	}

	// Token: 0x0600BE37 RID: 48695 RVA: 0x00382518 File Offset: 0x00380718
	public UUIExtendToggle GetTog()
	{
		return base.GetExtendToggle(3);
	}

	// Token: 0x0600BE38 RID: 48696 RVA: 0x00382521 File Offset: 0x00380721
	public bool GetIsUnlock()
	{
		return this.HandBookCommonItemData != null && !this.HandBookCommonItemData.IsLock;
	}

	// Token: 0x0600BE39 RID: 48697 RVA: 0x0038253C File Offset: 0x0038073C
	private void OnPressPhoto(int subType)
	{
		this.ReadHandBook();
		List<PhotographHandBook> list = ConfigCommon.ToList<PhotographHandBook>(HandBookConfig.Instance.GetPlotHandBookConfigByType(subType));
		if (list != null)
		{
			list.Sort(new Comparison<PhotographHandBook>(this.SortIndex));
		}
		PlotType? plotTypeConfig = HandBookConfig.Instance.GetPlotTypeConfig(subType);
		if (plotTypeConfig == null)
		{
			return;
		}
		int num = (list != null) ? list.Count : 0;
		List<string> list2 = new List<string>();
		List<string> list3 = new List<string>();
		List<string> list4 = new List<string>();
		List<string> list5 = new List<string>();
		List<string> list6 = new List<string>();
		List<int> list7 = new List<int>();
		for (int i = 0; i < num; i++)
		{
			PhotographHandBook photographHandBook = list[i];
			HandBookEntry handBookInfo = HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Quest, photographHandBook.Id);
			if (handBookInfo != null)
			{
				EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
				list2.Add((playerGender == EPlayerGender.Male) ? photographHandBook.MaleTexture : photographHandBook.FemaleTexture);
				list6.Add(handBookInfo.CreateTime);
				list3.Add(ConfigMultiTextLang.GetLocalTextNew(photographHandBook.Descrtption, null));
				list4.Add(ConfigMultiTextLang.GetLocalTextNew(photographHandBook.Name, null));
				list5.Add(ConfigMultiTextLang.GetLocalTextNew(plotTypeConfig.Value.TypeDescription, null));
				list7.Add(photographHandBook.Id);
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
	}

	// Token: 0x0600BE3A RID: 48698 RVA: 0x003826EC File Offset: 0x003808EC
	private void OnPressQuest(int subType)
	{
		this.ReadHandBook();
		HandBookCommonItemData handBookCommonItemData = this.HandBookCommonItemData;
		PhotographHandBook? photographHandBook;
		int? num = ((PhotographHandBook?)((handBookCommonItemData != null) ? handBookCommonItemData.Config : null) != null) ? new int?(photographHandBook.GetValueOrDefault().QuestId) : null;
		List<PhotographHandBook> list = ConfigCommon.ToList<PhotographHandBook>(HandBookConfig.Instance.GetPlotHandBookConfigByType(subType));
		if (list != null)
		{
			list.Sort((PhotographHandBook a, PhotographHandBook b) => a.Id - b.Id);
		}
		PlotType? plotTypeConfig = HandBookConfig.Instance.GetPlotTypeConfig(subType);
		if (plotTypeConfig == null)
		{
			return;
		}
		int num2 = (list != null) ? list.Count : 0;
		List<int> list2 = new List<int>();
		HandBookQuestViewOpenParam handBookQuestViewOpenParam = new HandBookQuestViewOpenParam();
		for (int i = 0; i < num2; i++)
		{
			PhotographHandBook photographHandBook2 = list[i];
			if (HandBookModel.Instance.GetHandBookInfo((EHandBookTabType)plotTypeConfig.Value.Type, photographHandBook2.Id) != null)
			{
				list2.Add(photographHandBook2.Id);
				int? num3 = num;
				int questId = photographHandBook2.QuestId;
				if (num3.GetValueOrDefault() == questId & num3 != null)
				{
					handBookQuestViewOpenParam.Index = list2.IndexOf(photographHandBook2.Id);
				}
			}
		}
		handBookQuestViewOpenParam.ConfigIdList = list2.ToArray();
		UiManager.Instance.OpenView(EUiViewName.HandBookQuestPlotView, handBookQuestViewOpenParam, null);
	}

	// Token: 0x0600BE3B RID: 48699 RVA: 0x0038284E File Offset: 0x00380A4E
	private int SortIndex(PhotographHandBook a, PhotographHandBook b)
	{
		return a.Id - b.Id;
	}

	// Token: 0x04006D83 RID: 28035
	private HandBookCommonItemData HandBookCommonItemData;

	// Token: 0x04006D84 RID: 28036
	private int GirdIndex;
}
