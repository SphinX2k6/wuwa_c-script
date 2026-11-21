using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02001971 RID: 6513
public class VisionAssembleDropDownItem : DropDownItemBase<int>
{
	// Token: 0x0601012A RID: 65834 RVA: 0x004AF2E9 File Offset: 0x004AD4E9
	[NullableContext(1)]
	public VisionAssembleDropDownItem(UUIItem uiItem) : base(uiItem)
	{
	}

	// Token: 0x0601012B RID: 65835 RVA: 0x004AF2F4 File Offset: 0x004AD4F4
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

	// Token: 0x0601012C RID: 65836 RVA: 0x004AF36F File Offset: 0x004AD56F
	[NullableContext(2)]
	protected override UUIExtendToggle GetDropDownToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x0601012D RID: 65837 RVA: 0x004AF378 File Offset: 0x004AD578
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

	// Token: 0x0601012E RID: 65838 RVA: 0x004AF43C File Offset: 0x004AD63C
	protected override void OnBeforeDestroy()
	{
		VisionFetterSuitItem visionFetterSuitItem = this.VisionFetterSuitItem;
		if (visionFetterSuitItem == null)
		{
			return;
		}
		visionFetterSuitItem.Destroy(null);
	}

	// Token: 0x04008EAD RID: 36525
	[Nullable(2)]
	private VisionFetterSuitItem VisionFetterSuitItem;

	// Token: 0x02007B89 RID: 31625
	private enum EComponent
	{
		// Token: 0x04028030 RID: 163888
		TogOption,
		// Token: 0x04028031 RID: 163889
		TxtOption,
		// Token: 0x04028032 RID: 163890
		SuitElementItem,
		// Token: 0x04028033 RID: 163891
		CurrentNumText
	}
}
