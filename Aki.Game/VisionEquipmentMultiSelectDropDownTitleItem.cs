using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Extension;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x0200198C RID: 6540
public class VisionEquipmentMultiSelectDropDownTitleItem : MultiSelectTitleItemBase<int>
{
	// Token: 0x06010210 RID: 66064 RVA: 0x004B3BB8 File Offset: 0x004B1DB8
	[NullableContext(1)]
	public VisionEquipmentMultiSelectDropDownTitleItem(UUIItem uiItem) : base(uiItem)
	{
	}

	// Token: 0x06010211 RID: 66065 RVA: 0x004B3BC1 File Offset: 0x004B1DC1
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06010212 RID: 66066 RVA: 0x004B3BFC File Offset: 0x004B1DFC
	[NullableContext(1)]
	public override void ShowMultiSelectTitle(IReadOnlyList<int> dataList)
	{
		if (this.VisionFetterSuitItem == null)
		{
			this.VisionFetterSuitItem = new VisionFetterSuitItem(base.GetItem(1));
			this.VisionFetterSuitItem.Init().Finally(delegate()
			{
			}).Forget();
		}
		bool flag = false;
		for (int i = 0; i < dataList.Count; i++)
		{
			if (dataList[i] == 0)
			{
				flag = true;
				break;
			}
		}
		if (dataList.Count == 0 || flag)
		{
			string newText = ConfigMultiTextLang.GetLocalTextNew("Text_FilterTextAllVisionFetter_Text", null) ?? "";
			base.GetText(0).SetText(newText, true);
			this.VisionFetterSuitItem.SetActive(false);
			return;
		}
		if (dataList.Count == 1)
		{
			int groupId = dataList[0];
			PhantomFetterGroup fetterGroupById = PhantomBattleConfig.Instance.GetFetterGroupById(groupId);
			string newText2 = ConfigMultiTextLang.GetLocalTextNew(fetterGroupById.FetterGroupName, null) ?? "";
			base.GetText(0).SetText(newText2, true);
			this.VisionFetterSuitItem.Update(new PhantomFetterGroup?(fetterGroupById));
			this.VisionFetterSuitItem.SetActive(true);
			return;
		}
		List<string> list = new List<string>();
		foreach (int num in dataList)
		{
			if (num > 0)
			{
				list.Add(ConfigMultiTextLang.GetLocalTextNew(PhantomBattleConfig.Instance.GetFetterGroupById(num).FetterGroupName, null) ?? "");
			}
		}
		base.GetText(0).SetText(string.Join(",", list), true);
		this.VisionFetterSuitItem.SetActive(false);
	}

	// Token: 0x06010213 RID: 66067 RVA: 0x004B3DB0 File Offset: 0x004B1FB0
	protected override void OnBeforeDestroy()
	{
		VisionFetterSuitItem visionFetterSuitItem = this.VisionFetterSuitItem;
		if (visionFetterSuitItem == null)
		{
			return;
		}
		visionFetterSuitItem.Destroy(null);
	}

	// Token: 0x04008F1E RID: 36638
	[Nullable(2)]
	private VisionFetterSuitItem VisionFetterSuitItem;

	// Token: 0x02007BB4 RID: 31668
	private enum EComponent
	{
		// Token: 0x040280ED RID: 164077
		TxtOption,
		// Token: 0x040280EE RID: 164078
		SuitElementItem
	}
}
