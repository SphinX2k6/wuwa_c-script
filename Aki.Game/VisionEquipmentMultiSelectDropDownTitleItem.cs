using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Extension;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x020024A5 RID: 9381
public class VisionEquipmentMultiSelectDropDownTitleItem : MultiSelectTitleItemBase<int>
{
	// Token: 0x06012D4F RID: 77135 RVA: 0x004A60E0 File Offset: 0x004A42E0
	[NullableContext(1)]
	public VisionEquipmentMultiSelectDropDownTitleItem(UUIItem uiItem) : base(uiItem)
	{
	}

	// Token: 0x06012D50 RID: 77136 RVA: 0x004A60E9 File Offset: 0x004A42E9
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06012D51 RID: 77137 RVA: 0x004A6124 File Offset: 0x004A4324
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
		if (dataList.Count == 0 || dataList.Contains(0))
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

	// Token: 0x06012D52 RID: 77138 RVA: 0x004A62B8 File Offset: 0x004A44B8
	protected override void OnBeforeDestroy()
	{
		VisionFetterSuitItem visionFetterSuitItem = this.VisionFetterSuitItem;
		if (visionFetterSuitItem == null)
		{
			return;
		}
		visionFetterSuitItem.Destroy(null);
	}

	// Token: 0x04008DD4 RID: 36308
	[Nullable(2)]
	private VisionFetterSuitItem VisionFetterSuitItem;

	// Token: 0x02008A2A RID: 35370
	private enum EComponent
	{
		// Token: 0x0402CDCD RID: 183757
		TxtOption,
		// Token: 0x0402CDCE RID: 183758
		SuitElementItem
	}
}
