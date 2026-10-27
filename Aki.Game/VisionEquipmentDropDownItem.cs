using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x020024A3 RID: 9379
public class VisionEquipmentDropDownItem : DropDownItemBase<int>
{
	// Token: 0x06012D45 RID: 77125 RVA: 0x004A5DA2 File Offset: 0x004A3FA2
	[NullableContext(1)]
	public VisionEquipmentDropDownItem(UUIItem uiItem) : base(uiItem)
	{
	}

	// Token: 0x06012D46 RID: 77126 RVA: 0x004A5DAC File Offset: 0x004A3FAC
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

	// Token: 0x06012D47 RID: 77127 RVA: 0x004A5E3D File Offset: 0x004A403D
	[NullableContext(2)]
	protected override UUIExtendToggle GetDropDownToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x06012D48 RID: 77128 RVA: 0x004A5E46 File Offset: 0x004A4046
	public void SetRoleId(int id)
	{
		this.CurrentRoleId = id;
	}

	// Token: 0x06012D49 RID: 77129 RVA: 0x004A5E50 File Offset: 0x004A4050
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
			list = PhantomBattleModel.Instance.GetVisionSortUseDataList(data, 0).ToList<IPhantomItemData>();
			newText = (ConfigMultiTextLang.GetLocalTextNew(PhantomBattleConfig.Instance.GetFetterGroupById(data).FetterGroupName, null) ?? "");
		}
		else
		{
			list = PhantomBattleModel.Instance.GetVisionSortUseDataList(0, 0).ToList<IPhantomItemData>();
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

	// Token: 0x06012D4A RID: 77130 RVA: 0x004A5FB6 File Offset: 0x004A41B6
	protected override void OnBeforeDestroy()
	{
		VisionFetterSuitItem visionFetterSuitItem = this.VisionFetterSuitItem;
		if (visionFetterSuitItem == null)
		{
			return;
		}
		visionFetterSuitItem.Destroy(null);
	}

	// Token: 0x04008DD1 RID: 36305
	private int CurrentRoleId;

	// Token: 0x04008DD2 RID: 36306
	[Nullable(2)]
	private VisionFetterSuitItem VisionFetterSuitItem;

	// Token: 0x02008A27 RID: 35367
	private enum EComponent
	{
		// Token: 0x0402CDC3 RID: 183747
		TogOption,
		// Token: 0x0402CDC4 RID: 183748
		TxtOption,
		// Token: 0x0402CDC5 RID: 183749
		SuitElementItem,
		// Token: 0x0402CDC6 RID: 183750
		CurrentNumText,
		// Token: 0x0402CDC7 RID: 183751
		LikeItem
	}
}
