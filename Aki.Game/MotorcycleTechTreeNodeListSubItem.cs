using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001729 RID: 5929
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleTechTreeNodeListSubItem : UiPanelBase
{
	// Token: 0x0600E667 RID: 58983 RVA: 0x00439C48 File Offset: 0x00437E48
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x0600E668 RID: 58984 RVA: 0x00439CA2 File Offset: 0x00437EA2
	protected override void OnStart()
	{
		this.SubLayout = new GenericLayout<MotorcycleTechTreeNodeItem, MotorTechTreeNode>(base.GetVerticalLayout(0), new Func<MotorcycleTechTreeNodeItem>(this.InitItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
		base.GetItem(1).SetUIActive(false);
	}

	// Token: 0x0600E669 RID: 58985 RVA: 0x00439CE4 File Offset: 0x00437EE4
	public UniTask RefreshAsync(int[] idList)
	{
		MotorcycleTechTreeNodeListSubItem.<RefreshAsync>d__4 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.idList = idList;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<MotorcycleTechTreeNodeListSubItem.<RefreshAsync>d__4>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E66A RID: 58986 RVA: 0x00439D2F File Offset: 0x00437F2F
	public List<MotorcycleTechTreeNodeItem> GetSubLayoutItemList()
	{
		return this.SubLayout.GetLayoutItemList();
	}

	// Token: 0x0600E66B RID: 58987 RVA: 0x00439D3C File Offset: 0x00437F3C
	private MotorcycleTechTreeNodeItem InitItem()
	{
		return new MotorcycleTechTreeNodeItem();
	}

	// Token: 0x04008390 RID: 33680
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MotorcycleTechTreeNodeItem, MotorTechTreeNode> SubLayout;

	// Token: 0x0200790C RID: 30988
	[NullableContext(0)]
	private class EMotorTreeNodeListSubItemComponent
	{
		// Token: 0x040273D9 RID: 160729
		public const int LayoutItem = 0;

		// Token: 0x040273DA RID: 160730
		public const int LineItem = 1;

		// Token: 0x040273DB RID: 160731
		public const int SubItem = 2;
	}
}
