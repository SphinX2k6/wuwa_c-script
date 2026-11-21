using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001722 RID: 5922
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleTechTreeComStyleItem2 : UiPanelBase
{
	// Token: 0x0600E63E RID: 58942 RVA: 0x00439014 File Offset: 0x00437214
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x0600E63F RID: 58943 RVA: 0x00439084 File Offset: 0x00437284
	protected override void OnStart()
	{
		this.LeftLayout = new GenericLayout<MotorcycleTechTreeComNodeItem, MotorTechTreeNode>(base.GetVerticalLayout(0), new Func<MotorcycleTechTreeComNodeItem>(this.InitComNodeItem), null, false, true);
		this.RightLayout = new GenericLayout<MotorcycleTechTreeComNodeItem, MotorTechTreeNode>(base.GetVerticalLayout(2), new Func<MotorcycleTechTreeComNodeItem>(this.InitComNodeItem), null, false, true);
	}

	// Token: 0x0600E640 RID: 58944 RVA: 0x004390D3 File Offset: 0x004372D3
	private MotorcycleTechTreeComNodeItem InitComNodeItem()
	{
		return new MotorcycleTechTreeComNodeItem();
	}

	// Token: 0x0600E641 RID: 58945 RVA: 0x004390DC File Offset: 0x004372DC
	public void SetNodeClick(Action<MotorTechTreeNode, UUIExtendToggle> nodeClick)
	{
		GenericLayout<MotorcycleTechTreeComNodeItem, MotorTechTreeNode> leftLayout = this.LeftLayout;
		List<MotorcycleTechTreeComNodeItem> list = (leftLayout != null) ? leftLayout.GetLayoutItemList() : null;
		GenericLayout<MotorcycleTechTreeComNodeItem, MotorTechTreeNode> rightLayout = this.RightLayout;
		List<MotorcycleTechTreeComNodeItem> list2 = (rightLayout != null) ? rightLayout.GetLayoutItemList() : null;
		if (list != null)
		{
			for (int i = 0; i < list.Count; i++)
			{
				list[i].OnClickToggleBack = nodeClick;
			}
		}
		if (list2 != null)
		{
			for (int j = 0; j < list2.Count; j++)
			{
				list2[j].OnClickToggleBack = nodeClick;
			}
		}
	}

	// Token: 0x0600E642 RID: 58946 RVA: 0x00439154 File Offset: 0x00437354
	[NullableContext(2)]
	public MotorcycleTechTreeComNodeItem GetGuideNodeItem(int index)
	{
		GenericLayout<MotorcycleTechTreeComNodeItem, MotorTechTreeNode> leftLayout = this.LeftLayout;
		List<MotorcycleTechTreeComNodeItem> list = (leftLayout != null) ? leftLayout.GetLayoutItemList() : null;
		if (list != null && index < list.Count)
		{
			return list[index];
		}
		int num = index - ((list != null) ? list.Count : 0);
		GenericLayout<MotorcycleTechTreeComNodeItem, MotorTechTreeNode> rightLayout = this.RightLayout;
		List<MotorcycleTechTreeComNodeItem> list2 = (rightLayout != null) ? rightLayout.GetLayoutItemList() : null;
		if (list2 != null && num >= 0 && num < list2.Count)
		{
			return list2[num];
		}
		return null;
	}

	// Token: 0x0600E643 RID: 58947 RVA: 0x004391C4 File Offset: 0x004373C4
	public UniTask RefreshCommonNodeItemAsync(int[] nodeIds)
	{
		MotorcycleTechTreeComStyleItem2.<RefreshCommonNodeItemAsync>d__11 <RefreshCommonNodeItemAsync>d__;
		<RefreshCommonNodeItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshCommonNodeItemAsync>d__.<>4__this = this;
		<RefreshCommonNodeItemAsync>d__.nodeIds = nodeIds;
		<RefreshCommonNodeItemAsync>d__.<>1__state = -1;
		<RefreshCommonNodeItemAsync>d__.<>t__builder.Start<MotorcycleTechTreeComStyleItem2.<RefreshCommonNodeItemAsync>d__11>(ref <RefreshCommonNodeItemAsync>d__);
		return <RefreshCommonNodeItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0400837F RID: 33663
	private const int LEFT_NODE_MAX_COUNT = 4;

	// Token: 0x04008380 RID: 33664
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MotorcycleTechTreeComNodeItem, MotorTechTreeNode> LeftLayout;

	// Token: 0x04008381 RID: 33665
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MotorcycleTechTreeComNodeItem, MotorTechTreeNode> RightLayout;

	// Token: 0x04008382 RID: 33666
	private List<MotorTechTreeNode> LeftDataList = new List<MotorTechTreeNode>();

	// Token: 0x04008383 RID: 33667
	private List<MotorTechTreeNode> RightDataList = new List<MotorTechTreeNode>();

	// Token: 0x02007900 RID: 30976
	[NullableContext(0)]
	private static class EMotorTreeComStyleItemComponent
	{
		// Token: 0x0402739F RID: 160671
		public const int LeftLayout = 0;

		// Token: 0x040273A0 RID: 160672
		public const int LeftItem = 1;

		// Token: 0x040273A1 RID: 160673
		public const int RightLayout = 2;

		// Token: 0x040273A2 RID: 160674
		public const int RightItem = 3;
	}
}
