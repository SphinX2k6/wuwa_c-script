using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x020024A4 RID: 9380
public class VisionEquipmentDropDownTitleItem : TitleItemBase<int>
{
	// Token: 0x06012D4B RID: 77131 RVA: 0x004A5FC9 File Offset: 0x004A41C9
	[NullableContext(1)]
	public VisionEquipmentDropDownTitleItem(UUIItem uiItem) : base(uiItem)
	{
	}

	// Token: 0x06012D4C RID: 77132 RVA: 0x004A5FD2 File Offset: 0x004A41D2
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06012D4D RID: 77133 RVA: 0x004A600C File Offset: 0x004A420C
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

	// Token: 0x06012D4E RID: 77134 RVA: 0x004A60CD File Offset: 0x004A42CD
	protected override void OnBeforeDestroy()
	{
		VisionFetterSuitItem visionFetterSuitItem = this.VisionFetterSuitItem;
		if (visionFetterSuitItem == null)
		{
			return;
		}
		visionFetterSuitItem.Destroy(null);
	}

	// Token: 0x04008DD3 RID: 36307
	[Nullable(2)]
	private VisionFetterSuitItem VisionFetterSuitItem;

	// Token: 0x02008A29 RID: 35369
	private enum EComponent
	{
		// Token: 0x0402CDCA RID: 183754
		TxtOption,
		// Token: 0x0402CDCB RID: 183755
		SuitElementItem
	}
}
