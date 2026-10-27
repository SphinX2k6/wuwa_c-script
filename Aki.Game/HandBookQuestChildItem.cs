using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E10 RID: 7696
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class HandBookQuestChildItem : GridProxyAbstract<HandBookCommonItemData>
{
	// Token: 0x0600EA10 RID: 59920 RVA: 0x00376454 File Offset: 0x00374654
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

	// Token: 0x0600EA11 RID: 59921 RVA: 0x00376540 File Offset: 0x00374740
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

	// Token: 0x0600EA12 RID: 59922 RVA: 0x003766DC File Offset: 0x003748DC
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

	// Token: 0x0600EA13 RID: 59923 RVA: 0x00376747 File Offset: 0x00374947
	public HandBookCommonItemData GetData()
	{
		return this.HandBookCommonItemData;
	}

	// Token: 0x0600EA14 RID: 59924 RVA: 0x0037674F File Offset: 0x0037494F
	public void SetNewState(bool isNew)
	{
		base.GetItem(2).SetUIActive(isNew);
	}

	// Token: 0x0600EA15 RID: 59925 RVA: 0x0037675E File Offset: 0x0037495E
	public void SetToggleState(EToggleState state)
	{
		base.GetExtendToggle(3).SetToggleStateForce(state, false, true, false);
		if (state == EToggleState.ETT_Checked)
		{
			this.ReadHandBook();
		}
	}

	// Token: 0x0600EA16 RID: 59926 RVA: 0x0037677C File Offset: 0x0037497C
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

	// Token: 0x0600EA17 RID: 59927 RVA: 0x00376807 File Offset: 0x00374A07
	protected override void OnBeforeDestroy()
	{
		this.HandBookCommonItemData = null;
	}

	// Token: 0x0600EA18 RID: 59928 RVA: 0x00376810 File Offset: 0x00374A10
	public UUIExtendToggle GetTog()
	{
		return base.GetExtendToggle(3);
	}

	// Token: 0x0600EA19 RID: 59929 RVA: 0x00376819 File Offset: 0x00374A19
	public bool GetIsUnlock()
	{
		return this.HandBookCommonItemData != null && !this.HandBookCommonItemData.IsLock;
	}

	// Token: 0x0600EA1A RID: 59930 RVA: 0x00376834 File Offset: 0x00374A34
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

	// Token: 0x0600EA1B RID: 59931 RVA: 0x003769E4 File Offset: 0x00374BE4
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

	// Token: 0x0600EA1C RID: 59932 RVA: 0x00376B46 File Offset: 0x00374D46
	private int SortIndex(PhotographHandBook a, PhotographHandBook b)
	{
		return a.Id - b.Id;
	}

	// Token: 0x04006CA2 RID: 27810
	private HandBookCommonItemData HandBookCommonItemData;

	// Token: 0x04006CA3 RID: 27811
	private int GirdIndex;
}
