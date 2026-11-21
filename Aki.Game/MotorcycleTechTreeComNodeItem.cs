using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001720 RID: 5920
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleTechTreeComNodeItem : GridProxyAbstract<MotorTechTreeNode>
{
	// Token: 0x0600E62D RID: 58925 RVA: 0x00438C50 File Offset: 0x00436E50
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUITexture)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUISprite)),
			new ValueTuple<int, Type>(10, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnTechTreeNodeClick))
		};
	}

	// Token: 0x0600E62E RID: 58926 RVA: 0x00438D7F File Offset: 0x00436F7F
	protected override void OnStart()
	{
		this.LevelLayout = new GenericLayout<MotorcycleTechTreeLevelItem, IMotorTechLevelPoint>(base.GetHorizontalLayout(7), new Func<MotorcycleTechTreeLevelItem>(this.InitLevelItem), null, false, true);
	}

	// Token: 0x0600E62F RID: 58927 RVA: 0x00438DA2 File Offset: 0x00436FA2
	public override void Refresh(MotorTechTreeNode data, bool isSelected, int gridIndex)
	{
		this.RefreshNodeAsyncByData(data).Forget();
	}

	// Token: 0x0600E630 RID: 58928 RVA: 0x00438DB0 File Offset: 0x00436FB0
	public UniTask RefreshNodeAsync()
	{
		MotorcycleTechTreeComNodeItem.<RefreshNodeAsync>d__7 <RefreshNodeAsync>d__;
		<RefreshNodeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshNodeAsync>d__.<>4__this = this;
		<RefreshNodeAsync>d__.<>1__state = -1;
		<RefreshNodeAsync>d__.<>t__builder.Start<MotorcycleTechTreeComNodeItem.<RefreshNodeAsync>d__7>(ref <RefreshNodeAsync>d__);
		return <RefreshNodeAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E631 RID: 58929 RVA: 0x00438DF4 File Offset: 0x00436FF4
	[NullableContext(2)]
	public UniTask RefreshNodeAsyncByData(MotorTechTreeNode treeNode)
	{
		MotorcycleTechTreeComNodeItem.<RefreshNodeAsyncByData>d__8 <RefreshNodeAsyncByData>d__;
		<RefreshNodeAsyncByData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshNodeAsyncByData>d__.<>4__this = this;
		<RefreshNodeAsyncByData>d__.treeNode = treeNode;
		<RefreshNodeAsyncByData>d__.<>1__state = -1;
		<RefreshNodeAsyncByData>d__.<>t__builder.Start<MotorcycleTechTreeComNodeItem.<RefreshNodeAsyncByData>d__8>(ref <RefreshNodeAsyncByData>d__);
		return <RefreshNodeAsyncByData>d__.<>t__builder.Task;
	}

	// Token: 0x0600E632 RID: 58930 RVA: 0x00438E3F File Offset: 0x0043703F
	private MotorcycleTechTreeLevelItem InitLevelItem()
	{
		return new MotorcycleTechTreeLevelItem();
	}

	// Token: 0x0600E633 RID: 58931 RVA: 0x00438E46 File Offset: 0x00437046
	public void SelectNode()
	{
		this.InvokeOnClickToggleBack();
	}

	// Token: 0x0600E634 RID: 58932 RVA: 0x00438E4E File Offset: 0x0043704E
	private void OnTechTreeNodeClick(EToggleState toggleState)
	{
		this.InvokeOnClickToggleBack();
	}

	// Token: 0x0600E635 RID: 58933 RVA: 0x00438E56 File Offset: 0x00437056
	private void InvokeOnClickToggleBack()
	{
		Action<MotorTechTreeNode, UUIExtendToggle> onClickToggleBack = this.OnClickToggleBack;
		if (onClickToggleBack == null)
		{
			return;
		}
		onClickToggleBack(this.Node, base.GetExtendToggle(0));
	}

	// Token: 0x04008379 RID: 33657
	[Nullable(2)]
	public MotorTechTreeNode Node;

	// Token: 0x0400837A RID: 33658
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MotorcycleTechTreeLevelItem, IMotorTechLevelPoint> LevelLayout;

	// Token: 0x0400837B RID: 33659
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<MotorTechTreeNode, UUIExtendToggle> OnClickToggleBack;

	// Token: 0x020078F9 RID: 30969
	[NullableContext(0)]
	private class EMotorTreeComItemComponent
	{
		// Token: 0x0402737A RID: 160634
		public const int TogItem = 0;

		// Token: 0x0402737B RID: 160635
		public const int ActivateBgItem = 1;

		// Token: 0x0402737C RID: 160636
		public const int TexIconActivate = 2;

		// Token: 0x0402737D RID: 160637
		public const int LockBgItem = 3;

		// Token: 0x0402737E RID: 160638
		public const int TexIconLock = 4;

		// Token: 0x0402737F RID: 160639
		public const int LockItem = 5;

		// Token: 0x04027380 RID: 160640
		public const int RedDotItem = 6;

		// Token: 0x04027381 RID: 160641
		public const int LevelLayout = 7;

		// Token: 0x04027382 RID: 160642
		public const int TopUnlockItem = 8;

		// Token: 0x04027383 RID: 160643
		public const int ActivateBgIcon = 9;

		// Token: 0x04027384 RID: 160644
		public const int TopLockItem = 10;
	}
}
