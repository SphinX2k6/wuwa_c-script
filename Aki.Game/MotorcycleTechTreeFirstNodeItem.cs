using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200223F RID: 8767
public class MotorcycleTechTreeFirstNodeItem : UiPanelBase
{
	// Token: 0x060111AF RID: 70063 RVA: 0x0042C68C File Offset: 0x0042A88C
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

	// Token: 0x060111B0 RID: 70064 RVA: 0x0042C735 File Offset: 0x0042A935
	protected override void OnStart()
	{
		this.LevelLayout = new GenericLayout<MotorcycleTechTreeLevelItem, IMotorTechLevelPoint>(base.GetHorizontalLayout(2), new Func<MotorcycleTechTreeLevelItem>(this.InitLevelItem), null, false, true);
	}

	// Token: 0x060111B1 RID: 70065 RVA: 0x0042C758 File Offset: 0x0042A958
	public UniTask RefreshNodeAsync()
	{
		MotorcycleTechTreeFirstNodeItem.<RefreshNodeAsync>d__6 <RefreshNodeAsync>d__;
		<RefreshNodeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshNodeAsync>d__.<>4__this = this;
		<RefreshNodeAsync>d__.<>1__state = -1;
		<RefreshNodeAsync>d__.<>t__builder.Start<MotorcycleTechTreeFirstNodeItem.<RefreshNodeAsync>d__6>(ref <RefreshNodeAsync>d__);
		return <RefreshNodeAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060111B2 RID: 70066 RVA: 0x0042C79C File Offset: 0x0042A99C
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

	// Token: 0x060111B3 RID: 70067 RVA: 0x0042C7E7 File Offset: 0x0042A9E7
	[NullableContext(1)]
	private MotorcycleTechTreeLevelItem InitLevelItem()
	{
		return new MotorcycleTechTreeLevelItem();
	}

	// Token: 0x060111B4 RID: 70068 RVA: 0x0042C7EE File Offset: 0x0042A9EE
	public void SelectNode()
	{
		this.OnSelectTechTreeNode();
	}

	// Token: 0x060111B5 RID: 70069 RVA: 0x0042C7F6 File Offset: 0x0042A9F6
	private void OnTechTreeNodeClick(EToggleState toggleState)
	{
		this.OnSelectTechTreeNode();
	}

	// Token: 0x060111B6 RID: 70070 RVA: 0x0042C7FE File Offset: 0x0042A9FE
	private void OnSelectTechTreeNode()
	{
		Action<MotorTechTreeNode, UUIExtendToggle> onClickToggleBack = this.OnClickToggleBack;
		if (onClickToggleBack == null)
		{
			return;
		}
		onClickToggleBack(this.Node, base.GetExtendToggle(0));
	}

	// Token: 0x04008246 RID: 33350
	[Nullable(2)]
	public MotorTechTreeNode Node;

	// Token: 0x04008247 RID: 33351
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MotorcycleTechTreeLevelItem, IMotorTechLevelPoint> LevelLayout;

	// Token: 0x04008248 RID: 33352
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<MotorTechTreeNode, UUIExtendToggle> OnClickToggleBack;

	// Token: 0x02008779 RID: 34681
	private class EMotorTreeFirstItemComponent
	{
		// Token: 0x0402C090 RID: 180368
		public const int TogItem = 0;

		// Token: 0x0402C091 RID: 180369
		public const int TexIcon = 1;

		// Token: 0x0402C092 RID: 180370
		public const int LevelLayout = 2;

		// Token: 0x0402C093 RID: 180371
		public const int LevelItem = 3;

		// Token: 0x0402C094 RID: 180372
		public const int RedDotItem = 4;
	}
}
