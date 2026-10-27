using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x020016A5 RID: 5797
public class NewSoundSuitDropDownItem : DropDownItemBase<int>
{
	// Token: 0x0600A56F RID: 42351 RVA: 0x0024F924 File Offset: 0x0024DB24
	[NullableContext(1)]
	public NewSoundSuitDropDownItem(UUIItem uiItem) : base(uiItem)
	{
	}

	// Token: 0x0600A570 RID: 42352 RVA: 0x0024F930 File Offset: 0x0024DB30
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
	}

	// Token: 0x0600A571 RID: 42353 RVA: 0x0024FA07 File Offset: 0x0024DC07
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIText text = base.GetText(3);
		if (text == null)
		{
			return;
		}
		text.SetUIActive(false);
	}

	// Token: 0x0600A572 RID: 42354 RVA: 0x0024FA2E File Offset: 0x0024DC2E
	[NullableContext(2)]
	protected override UUIExtendToggle GetDropDownToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x0600A573 RID: 42355 RVA: 0x0024FA38 File Offset: 0x0024DC38
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
		bool flag = true;
		if (flag)
		{
			PhantomFetterGroup? fetterGroupData = (data > 0) ? new PhantomFetterGroup?(PhantomBattleConfig.Instance.GetFetterGroupById(data)) : null;
			this.VisionFetterSuitItem.Update(fetterGroupData);
		}
		this.VisionFetterSuitItem.SetActive(flag);
	}

	// Token: 0x0600A574 RID: 42356 RVA: 0x0024FAF7 File Offset: 0x0024DCF7
	protected override void OnBeforeDestroy()
	{
		VisionFetterSuitItem visionFetterSuitItem = this.VisionFetterSuitItem;
		if (visionFetterSuitItem == null)
		{
			return;
		}
		visionFetterSuitItem.Destroy(null);
	}

	// Token: 0x04004AD6 RID: 19158
	[Nullable(2)]
	private VisionFetterSuitItem VisionFetterSuitItem;

	// Token: 0x02007C7C RID: 31868
	private enum EComponent
	{
		// Token: 0x04028D82 RID: 167298
		TogOption,
		// Token: 0x04028D83 RID: 167299
		TxtOption,
		// Token: 0x04028D84 RID: 167300
		SuitElementItem,
		// Token: 0x04028D85 RID: 167301
		CurrentNumText,
		// Token: 0x04028D86 RID: 167302
		LikeItem
	}
}
