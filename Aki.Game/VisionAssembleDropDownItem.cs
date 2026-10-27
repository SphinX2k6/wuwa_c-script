using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x0200248B RID: 9355
public class VisionAssembleDropDownItem : DropDownItemBase<int>
{
	// Token: 0x06012C71 RID: 76913 RVA: 0x004A1B81 File Offset: 0x0049FD81
	[NullableContext(1)]
	public VisionAssembleDropDownItem(UUIItem uiItem) : base(uiItem)
	{
	}

	// Token: 0x06012C72 RID: 76914 RVA: 0x004A1B8C File Offset: 0x0049FD8C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
	}

	// Token: 0x06012C73 RID: 76915 RVA: 0x004A1C07 File Offset: 0x0049FE07
	[NullableContext(2)]
	protected override UUIExtendToggle GetDropDownToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x06012C74 RID: 76916 RVA: 0x004A1C10 File Offset: 0x0049FE10
	protected override void OnShowDropDownItemBase(int data)
	{
		this.VisionFetterSuitItem = new VisionFetterSuitItem(base.GetItem(2));
		this.VisionFetterSuitItem.Init();
		string newText;
		if (data > 0)
		{
			newText = (ConfigMultiTextLang.GetLocalTextNew(PhantomBattleConfig.Instance.GetFetterGroupById(data).FetterGroupName, null) ?? "");
		}
		else
		{
			newText = (ConfigMultiTextLang.GetLocalTextNew("Text_FilterTextAllVisionFetter_Text", null) ?? "");
		}
		base.GetText(1).SetText(newText, true);
		base.GetText(3).SetText("", true);
		PhantomFetterGroup? fetterGroupData = (data > 0) ? new PhantomFetterGroup?(PhantomBattleConfig.Instance.GetFetterGroupById(data)) : null;
		this.VisionFetterSuitItem.Update(fetterGroupData);
		this.VisionFetterSuitItem.SetActive(true);
	}

	// Token: 0x06012C75 RID: 76917 RVA: 0x004A1CD4 File Offset: 0x0049FED4
	protected override void OnBeforeDestroy()
	{
		VisionFetterSuitItem visionFetterSuitItem = this.VisionFetterSuitItem;
		if (visionFetterSuitItem == null)
		{
			return;
		}
		visionFetterSuitItem.Destroy(null);
	}

	// Token: 0x04008D66 RID: 36198
	[Nullable(2)]
	private VisionFetterSuitItem VisionFetterSuitItem;

	// Token: 0x02008A02 RID: 35330
	private enum EComponent
	{
		// Token: 0x0402CD1A RID: 183578
		TogOption,
		// Token: 0x0402CD1B RID: 183579
		TxtOption,
		// Token: 0x0402CD1C RID: 183580
		SuitElementItem,
		// Token: 0x0402CD1D RID: 183581
		CurrentNumText
	}
}
