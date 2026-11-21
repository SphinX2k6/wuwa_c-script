using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001062 RID: 4194
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchTechGridPanel : UiPanelBase, IGridProxy<List<FloroRanchTechnologyData>>
{
	// Token: 0x1700118A RID: 4490
	// (get) Token: 0x0600A6B8 RID: 42680 RVA: 0x00311BE3 File Offset: 0x0030FDE3
	// (set) Token: 0x0600A6B9 RID: 42681 RVA: 0x00311BEB File Offset: 0x0030FDEB
	public IScrollViewDelegate<IGridProxy<List<FloroRanchTechnologyData>>, List<FloroRanchTechnologyData>> ScrollViewDelegate { get; set; }

	// Token: 0x1700118B RID: 4491
	// (get) Token: 0x0600A6BA RID: 42682 RVA: 0x00311BF4 File Offset: 0x0030FDF4
	// (set) Token: 0x0600A6BB RID: 42683 RVA: 0x00311BFC File Offset: 0x0030FDFC
	public int GridIndex { get; set; }

	// Token: 0x1700118C RID: 4492
	// (get) Token: 0x0600A6BC RID: 42684 RVA: 0x00311C05 File Offset: 0x0030FE05
	// (set) Token: 0x0600A6BD RID: 42685 RVA: 0x00311C0D File Offset: 0x0030FE0D
	public int DisplayIndex { get; set; }

	// Token: 0x0600A6BE RID: 42686 RVA: 0x00311C18 File Offset: 0x0030FE18
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

	// Token: 0x0600A6BF RID: 42687 RVA: 0x00311CA4 File Offset: 0x0030FEA4
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

	// Token: 0x0600A6C0 RID: 42688 RVA: 0x00311DB8 File Offset: 0x0030FFB8
	public void Clear()
	{
	}

	// Token: 0x0600A6C1 RID: 42689 RVA: 0x00311DBA File Offset: 0x0030FFBA
	public void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x0600A6C2 RID: 42690 RVA: 0x00311DBC File Offset: 0x0030FFBC
	public void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x0600A6C3 RID: 42691 RVA: 0x00311DBE File Offset: 0x0030FFBE
	[return: Nullable(2)]
	public object GetKey(List<FloroRanchTechnologyData> data, int gridIndex)
	{
		return null;
	}

	// Token: 0x0400615F RID: 24927
	private readonly List<FloroRanchTechNodeItem> TechNodeItemList = new List<FloroRanchTechNodeItem>();

	// Token: 0x04006161 RID: 24929
	public Action<FloroRanchTechNodeItem> OnSelectTechNode = delegate(FloroRanchTechNodeItem technologyNode)
	{
	};

	// Token: 0x020072CE RID: 29390
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402563A RID: 153146
		public const int Pos1 = 0;

		// Token: 0x0402563B RID: 153147
		public const int Pos2 = 1;

		// Token: 0x0402563C RID: 153148
		public const int Pos3 = 2;
	}
}
