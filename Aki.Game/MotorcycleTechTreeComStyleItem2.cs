using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200223E RID: 8766
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleTechTreeComStyleItem2 : UiPanelBase
{
	// Token: 0x060111A8 RID: 70056 RVA: 0x0042C470 File Offset: 0x0042A670
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

	// Token: 0x060111A9 RID: 70057 RVA: 0x0042C4E0 File Offset: 0x0042A6E0
	protected override void OnStart()
	{
		this.LeftLayout = new GenericLayout<MotorcycleTechTreeComNodeItem, MotorTechTreeNode>(base.GetVerticalLayout(0), new Func<MotorcycleTechTreeComNodeItem>(this.InitComNodeItem), null, false, true);
		this.RightLayout = new GenericLayout<MotorcycleTechTreeComNodeItem, MotorTechTreeNode>(base.GetVerticalLayout(2), new Func<MotorcycleTechTreeComNodeItem>(this.InitComNodeItem), null, false, true);
	}

	// Token: 0x060111AA RID: 70058 RVA: 0x0042C52F File Offset: 0x0042A72F
	private MotorcycleTechTreeComNodeItem InitComNodeItem()
	{
		return new MotorcycleTechTreeComNodeItem();
	}

	// Token: 0x060111AB RID: 70059 RVA: 0x0042C538 File Offset: 0x0042A738
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

	// Token: 0x060111AC RID: 70060 RVA: 0x0042C5B0 File Offset: 0x0042A7B0
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

	// Token: 0x060111AD RID: 70061 RVA: 0x0042C620 File Offset: 0x0042A820
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

	// Token: 0x04008241 RID: 33345
	private const int LEFT_NODE_MAX_COUNT = 4;

	// Token: 0x04008242 RID: 33346
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MotorcycleTechTreeComNodeItem, MotorTechTreeNode> LeftLayout;

	// Token: 0x04008243 RID: 33347
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MotorcycleTechTreeComNodeItem, MotorTechTreeNode> RightLayout;

	// Token: 0x04008244 RID: 33348
	private List<MotorTechTreeNode> LeftDataList = new List<MotorTechTreeNode>();

	// Token: 0x04008245 RID: 33349
	private List<MotorTechTreeNode> RightDataList = new List<MotorTechTreeNode>();

	// Token: 0x02008777 RID: 34679
	[NullableContext(0)]
	private static class EMotorTreeComStyleItemComponent
	{
		// Token: 0x0402C087 RID: 180359
		public const int LeftLayout = 0;

		// Token: 0x0402C088 RID: 180360
		public const int LeftItem = 1;

		// Token: 0x0402C089 RID: 180361
		public const int RightLayout = 2;

		// Token: 0x0402C08A RID: 180362
		public const int RightItem = 3;
	}
}
