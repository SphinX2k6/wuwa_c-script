using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001BA3 RID: 7075
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchTechGridPanel : UiPanelBase, IGridProxy<List<FloroRanchTechnologyData>>
{
	// Token: 0x17001165 RID: 4453
	// (get) Token: 0x0600D2A7 RID: 53927 RVA: 0x00306B03 File Offset: 0x00304D03
	// (set) Token: 0x0600D2A8 RID: 53928 RVA: 0x00306B0B File Offset: 0x00304D0B
	public IScrollViewDelegate<IGridProxy<List<FloroRanchTechnologyData>>, List<FloroRanchTechnologyData>> ScrollViewDelegate { get; set; }

	// Token: 0x17001166 RID: 4454
	// (get) Token: 0x0600D2A9 RID: 53929 RVA: 0x00306B14 File Offset: 0x00304D14
	// (set) Token: 0x0600D2AA RID: 53930 RVA: 0x00306B1C File Offset: 0x00304D1C
	public int GridIndex { get; set; }

	// Token: 0x17001167 RID: 4455
	// (get) Token: 0x0600D2AB RID: 53931 RVA: 0x00306B25 File Offset: 0x00304D25
	// (set) Token: 0x0600D2AC RID: 53932 RVA: 0x00306B2D File Offset: 0x00304D2D
	public int DisplayIndex { get; set; }

	// Token: 0x0600D2AD RID: 53933 RVA: 0x00306B38 File Offset: 0x00304D38
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600D2AE RID: 53934 RVA: 0x00306BC4 File Offset: 0x00304DC4
	public void Refresh(List<FloroRanchTechnologyData> dataList, bool isSelected, int gridIndex)
	{
		foreach (FloroRanchTechnologyData floroRanchTechnologyData in dataList)
		{
			UUIItem item = base.GetItem(floroRanchTechnologyData.Row);
			FloroRanchTechNodeItem floroRanchTechNodeItem = null;
			if (floroRanchTechnologyData.Row < this.TechNodeItemList.Count)
			{
				floroRanchTechNodeItem = this.TechNodeItemList[floroRanchTechnologyData.Row];
			}
			if (floroRanchTechNodeItem != null)
			{
				floroRanchTechNodeItem.Refresh(null);
			}
			else
			{
				FloroRanchTechNodeItem techNode = new FloroRanchTechNodeItem(item, floroRanchTechnologyData, this.RootItem);
				techNode.CreateThenShowByResourceIdAsync("UiItem_PastureSkillA", item, false).ContinueWith(delegate()
				{
					techNode.OnClickCallback = this.OnSelectTechNode;
					techNode.Refresh(null);
				});
				while (this.TechNodeItemList.Count <= floroRanchTechnologyData.Row)
				{
					this.TechNodeItemList.Add(null);
				}
				this.TechNodeItemList[floroRanchTechnologyData.Row] = techNode;
			}
		}
	}

	// Token: 0x0600D2AF RID: 53935 RVA: 0x00306CD8 File Offset: 0x00304ED8
	public void Clear()
	{
	}

	// Token: 0x0600D2B0 RID: 53936 RVA: 0x00306CDA File Offset: 0x00304EDA
	public void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x0600D2B1 RID: 53937 RVA: 0x00306CDC File Offset: 0x00304EDC
	public void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x0600D2B2 RID: 53938 RVA: 0x00306CDE File Offset: 0x00304EDE
	[return: Nullable(2)]
	public object GetKey(List<FloroRanchTechnologyData> data, int gridIndex)
	{
		return null;
	}

	// Token: 0x04006090 RID: 24720
	private readonly List<FloroRanchTechNodeItem> TechNodeItemList = new List<FloroRanchTechNodeItem>();

	// Token: 0x04006092 RID: 24722
	public Action<FloroRanchTechNodeItem> OnSelectTechNode = delegate(FloroRanchTechNodeItem technologyNode)
	{
	};

	// Token: 0x02008140 RID: 33088
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402A306 RID: 172806
		public const int Pos1 = 0;

		// Token: 0x0402A307 RID: 172807
		public const int Pos2 = 1;

		// Token: 0x0402A308 RID: 172808
		public const int Pos3 = 2;
	}
}
