using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002245 RID: 8773
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleTechTreeNodeListSubItem : UiPanelBase
{
	// Token: 0x060111D1 RID: 70097 RVA: 0x0042D0A4 File Offset: 0x0042B2A4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x060111D2 RID: 70098 RVA: 0x0042D0FE File Offset: 0x0042B2FE
	protected override void OnStart()
	{
		this.SubLayout = new GenericLayout<MotorcycleTechTreeNodeItem, MotorTechTreeNode>(base.GetVerticalLayout(0), new Func<MotorcycleTechTreeNodeItem>(this.InitItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
		base.GetItem(1).SetUIActive(false);
	}

	// Token: 0x060111D3 RID: 70099 RVA: 0x0042D140 File Offset: 0x0042B340
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

	// Token: 0x060111D4 RID: 70100 RVA: 0x0042D18B File Offset: 0x0042B38B
	public List<MotorcycleTechTreeNodeItem> GetSubLayoutItemList()
	{
		return this.SubLayout.GetLayoutItemList();
	}

	// Token: 0x060111D5 RID: 70101 RVA: 0x0042D198 File Offset: 0x0042B398
	private MotorcycleTechTreeNodeItem InitItem()
	{
		return new MotorcycleTechTreeNodeItem();
	}

	// Token: 0x04008252 RID: 33362
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MotorcycleTechTreeNodeItem, MotorTechTreeNode> SubLayout;

	// Token: 0x02008783 RID: 34691
	[NullableContext(0)]
	private class EMotorTreeNodeListSubItemComponent
	{
		// Token: 0x0402C0C1 RID: 180417
		public const int LayoutItem = 0;

		// Token: 0x0402C0C2 RID: 180418
		public const int LineItem = 1;

		// Token: 0x0402C0C3 RID: 180419
		public const int SubItem = 2;
	}
}
