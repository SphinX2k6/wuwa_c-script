using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x0200198A RID: 6538
public class VisionEquipmentDropDownItem : DropDownItemBase<int>
{
	// Token: 0x06010206 RID: 66054 RVA: 0x004B387A File Offset: 0x004B1A7A
	[NullableContext(1)]
	public VisionEquipmentDropDownItem(UUIItem uiItem) : base(uiItem)
	{
	}

	// Token: 0x06010207 RID: 66055 RVA: 0x004B3884 File Offset: 0x004B1A84
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
	}

	// Token: 0x06010208 RID: 66056 RVA: 0x004B3915 File Offset: 0x004B1B15
	[NullableContext(2)]
	protected override UUIExtendToggle GetDropDownToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x06010209 RID: 66057 RVA: 0x004B391E File Offset: 0x004B1B1E
	public void SetRoleId(int id)
	{
		this.CurrentRoleId = id;
	}

	// Token: 0x0601020A RID: 66058 RVA: 0x004B3928 File Offset: 0x004B1B28
	protected override void OnShowDropDownItemBase(int data)
	{
		List<VisionFetterRecommendInfo> roleFetterRecommendInfo = VisionRecommendModel.Instance.GetRoleFetterRecommendInfo(this.CurrentRoleId);
		bool uiactive = false;
		if (roleFetterRecommendInfo != null && roleFetterRecommendInfo.Count > 0)
		{
			uiactive = (roleFetterRecommendInfo.Find((VisionFetterRecommendInfo item) => item.GetRecommendFetterGroupId() == data) != null);
		}
		base.GetItem(4).SetUIActive(uiactive);
		this.VisionFetterSuitItem = new VisionFetterSuitItem(base.GetItem(2));
		this.VisionFetterSuitItem.Init();
		int data2 = data;
		List<IPhantomItemData> list;
		string newText;
		if (data > 0)
		{
			list = new List<IPhantomItemData>(PhantomBattleModel.Instance.GetVisionSortUseDataList(data, 0));
			newText = (ConfigMultiTextLang.GetLocalTextNew(PhantomBattleConfig.Instance.GetFetterGroupById(data).FetterGroupName, null) ?? "");
		}
		else
		{
			list = new List<IPhantomItemData>(PhantomBattleModel.Instance.GetVisionSortUseDataList(0, 0));
			newText = (ConfigMultiTextLang.GetLocalTextNew("Text_FilterTextAllVisionFetter_Text", null) ?? "");
		}
		base.GetText(3).SetText(list.Count.ToString(), true);
		base.GetText(1).SetText(newText, true);
		bool flag = true;
		if (flag)
		{
			PhantomFetterGroup? fetterGroupData = (data2 > 0) ? new PhantomFetterGroup?(PhantomBattleConfig.Instance.GetFetterGroupById(data2)) : null;
			this.VisionFetterSuitItem.Update(fetterGroupData);
		}
		this.VisionFetterSuitItem.SetActive(flag);
	}

	// Token: 0x0601020B RID: 66059 RVA: 0x004B3A8E File Offset: 0x004B1C8E
	protected override void OnBeforeDestroy()
	{
		VisionFetterSuitItem visionFetterSuitItem = this.VisionFetterSuitItem;
		if (visionFetterSuitItem == null)
		{
			return;
		}
		visionFetterSuitItem.Destroy(null);
	}

	// Token: 0x04008F1B RID: 36635
	private int CurrentRoleId;

	// Token: 0x04008F1C RID: 36636
	[Nullable(2)]
	private VisionFetterSuitItem VisionFetterSuitItem;

	// Token: 0x02007BB1 RID: 31665
	private enum EComponent
	{
		// Token: 0x040280E3 RID: 164067
		TogOption,
		// Token: 0x040280E4 RID: 164068
		TxtOption,
		// Token: 0x040280E5 RID: 164069
		SuitElementItem,
		// Token: 0x040280E6 RID: 164070
		CurrentNumText,
		// Token: 0x040280E7 RID: 164071
		LikeItem
	}
}
