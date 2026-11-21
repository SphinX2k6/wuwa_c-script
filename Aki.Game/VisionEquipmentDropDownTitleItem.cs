using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x0200198B RID: 6539
public class VisionEquipmentDropDownTitleItem : TitleItemBase<int>
{
	// Token: 0x0601020C RID: 66060 RVA: 0x004B3AA1 File Offset: 0x004B1CA1
	[NullableContext(1)]
	public VisionEquipmentDropDownTitleItem(UUIItem uiItem) : base(uiItem)
	{
	}

	// Token: 0x0601020D RID: 66061 RVA: 0x004B3AAA File Offset: 0x004B1CAA
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0601020E RID: 66062 RVA: 0x004B3AE4 File Offset: 0x004B1CE4
	[NullableContext(1)]
	public override void ShowTemp(int data, DropDownItemBase<int> selectedItemObj)
	{
		if (this.VisionFetterSuitItem == null)
		{
			this.VisionFetterSuitItem = new VisionFetterSuitItem(base.GetItem(1));
			this.VisionFetterSuitItem.Init();
		}
		string newText;
		if (data > 0)
		{
			newText = (ConfigMultiTextLang.GetLocalTextNew(PhantomBattleConfig.Instance.GetFetterGroupById(data).FetterGroupName, null) ?? "");
		}
		else
		{
			newText = (ConfigMultiTextLang.GetLocalTextNew("Text_FilterTextAllVisionFetter_Text", null) ?? "");
		}
		base.GetText(0).SetText(newText, true);
		bool flag = true;
		if (flag)
		{
			PhantomFetterGroup? fetterGroupData = (data > 0) ? new PhantomFetterGroup?(PhantomBattleConfig.Instance.GetFetterGroupById(data)) : null;
			this.VisionFetterSuitItem.Update(fetterGroupData);
		}
		this.VisionFetterSuitItem.SetActive(flag);
	}

	// Token: 0x0601020F RID: 66063 RVA: 0x004B3BA5 File Offset: 0x004B1DA5
	protected override void OnBeforeDestroy()
	{
		VisionFetterSuitItem visionFetterSuitItem = this.VisionFetterSuitItem;
		if (visionFetterSuitItem == null)
		{
			return;
		}
		visionFetterSuitItem.Destroy(null);
	}

	// Token: 0x04008F1D RID: 36637
	[Nullable(2)]
	private VisionFetterSuitItem VisionFetterSuitItem;

	// Token: 0x02007BB3 RID: 31667
	private enum EComponent
	{
		// Token: 0x040280EA RID: 164074
		TxtOption,
		// Token: 0x040280EB RID: 164075
		SuitElementItem
	}
}
