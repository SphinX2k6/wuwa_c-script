using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001723 RID: 5923
public class MotorcycleTechTreeFirstNodeItem : UiPanelBase
{
	// Token: 0x0600E645 RID: 58949 RVA: 0x00439230 File Offset: 0x00437430
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnTechTreeNodeClick))
		};
	}

	// Token: 0x0600E646 RID: 58950 RVA: 0x004392D9 File Offset: 0x004374D9
	protected override void OnStart()
	{
		this.LevelLayout = new GenericLayout<MotorcycleTechTreeLevelItem, IMotorTechLevelPoint>(base.GetHorizontalLayout(2), new Func<MotorcycleTechTreeLevelItem>(this.InitLevelItem), null, false, true);
	}

	// Token: 0x0600E647 RID: 58951 RVA: 0x004392FC File Offset: 0x004374FC
	public UniTask RefreshNodeAsync()
	{
		MotorcycleTechTreeFirstNodeItem.<RefreshNodeAsync>d__6 <RefreshNodeAsync>d__;
		<RefreshNodeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshNodeAsync>d__.<>4__this = this;
		<RefreshNodeAsync>d__.<>1__state = -1;
		<RefreshNodeAsync>d__.<>t__builder.Start<MotorcycleTechTreeFirstNodeItem.<RefreshNodeAsync>d__6>(ref <RefreshNodeAsync>d__);
		return <RefreshNodeAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E648 RID: 58952 RVA: 0x00439340 File Offset: 0x00437540
	[NullableContext(2)]
	public UniTask RefreshNodeAsyncByData(MotorTechTreeNode treeNode)
	{
		MotorcycleTechTreeFirstNodeItem.<RefreshNodeAsyncByData>d__7 <RefreshNodeAsyncByData>d__;
		<RefreshNodeAsyncByData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshNodeAsyncByData>d__.<>4__this = this;
		<RefreshNodeAsyncByData>d__.treeNode = treeNode;
		<RefreshNodeAsyncByData>d__.<>1__state = -1;
		<RefreshNodeAsyncByData>d__.<>t__builder.Start<MotorcycleTechTreeFirstNodeItem.<RefreshNodeAsyncByData>d__7>(ref <RefreshNodeAsyncByData>d__);
		return <RefreshNodeAsyncByData>d__.<>t__builder.Task;
	}

	// Token: 0x0600E649 RID: 58953 RVA: 0x0043938B File Offset: 0x0043758B
	[NullableContext(1)]
	private MotorcycleTechTreeLevelItem InitLevelItem()
	{
		return new MotorcycleTechTreeLevelItem();
	}

	// Token: 0x0600E64A RID: 58954 RVA: 0x00439392 File Offset: 0x00437592
	public void SelectNode()
	{
		this.OnSelectTechTreeNode();
	}

	// Token: 0x0600E64B RID: 58955 RVA: 0x0043939A File Offset: 0x0043759A
	private void OnTechTreeNodeClick(EToggleState toggleState)
	{
		this.OnSelectTechTreeNode();
	}

	// Token: 0x0600E64C RID: 58956 RVA: 0x004393A2 File Offset: 0x004375A2
	private void OnSelectTechTreeNode()
	{
		Action<MotorTechTreeNode, UUIExtendToggle> onClickToggleBack = this.OnClickToggleBack;
		if (onClickToggleBack == null)
		{
			return;
		}
		onClickToggleBack(this.Node, base.GetExtendToggle(0));
	}

	// Token: 0x04008384 RID: 33668
	[Nullable(2)]
	public MotorTechTreeNode Node;

	// Token: 0x04008385 RID: 33669
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MotorcycleTechTreeLevelItem, IMotorTechLevelPoint> LevelLayout;

	// Token: 0x04008386 RID: 33670
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<MotorTechTreeNode, UUIExtendToggle> OnClickToggleBack;

	// Token: 0x02007902 RID: 30978
	private class EMotorTreeFirstItemComponent
	{
		// Token: 0x040273A8 RID: 160680
		public const int TogItem = 0;

		// Token: 0x040273A9 RID: 160681
		public const int TexIcon = 1;

		// Token: 0x040273AA RID: 160682
		public const int LevelLayout = 2;

		// Token: 0x040273AB RID: 160683
		public const int LevelItem = 3;

		// Token: 0x040273AC RID: 160684
		public const int RedDotItem = 4;
	}
}
