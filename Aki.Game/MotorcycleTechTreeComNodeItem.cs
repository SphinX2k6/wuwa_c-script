using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200223C RID: 8764
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleTechTreeComNodeItem : GridProxyAbstract<MotorTechTreeNode>
{
	// Token: 0x06011197 RID: 70039 RVA: 0x0042C0AC File Offset: 0x0042A2AC
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

	// Token: 0x06011198 RID: 70040 RVA: 0x0042C1DB File Offset: 0x0042A3DB
	protected override void OnStart()
	{
		this.LevelLayout = new GenericLayout<MotorcycleTechTreeLevelItem, IMotorTechLevelPoint>(base.GetHorizontalLayout(7), new Func<MotorcycleTechTreeLevelItem>(this.InitLevelItem), null, false, true);
	}

	// Token: 0x06011199 RID: 70041 RVA: 0x0042C1FE File Offset: 0x0042A3FE
	public override void Refresh(MotorTechTreeNode data, bool isSelected, int gridIndex)
	{
		this.RefreshNodeAsyncByData(data).Forget();
	}

	// Token: 0x0601119A RID: 70042 RVA: 0x0042C20C File Offset: 0x0042A40C
	public UniTask RefreshNodeAsync()
	{
		MotorcycleTechTreeComNodeItem.<RefreshNodeAsync>d__7 <RefreshNodeAsync>d__;
		<RefreshNodeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshNodeAsync>d__.<>4__this = this;
		<RefreshNodeAsync>d__.<>1__state = -1;
		<RefreshNodeAsync>d__.<>t__builder.Start<MotorcycleTechTreeComNodeItem.<RefreshNodeAsync>d__7>(ref <RefreshNodeAsync>d__);
		return <RefreshNodeAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601119B RID: 70043 RVA: 0x0042C250 File Offset: 0x0042A450
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

	// Token: 0x0601119C RID: 70044 RVA: 0x0042C29B File Offset: 0x0042A49B
	private MotorcycleTechTreeLevelItem InitLevelItem()
	{
		return new MotorcycleTechTreeLevelItem();
	}

	// Token: 0x0601119D RID: 70045 RVA: 0x0042C2A2 File Offset: 0x0042A4A2
	public void SelectNode()
	{
		this.InvokeOnClickToggleBack();
	}

	// Token: 0x0601119E RID: 70046 RVA: 0x0042C2AA File Offset: 0x0042A4AA
	private void OnTechTreeNodeClick(EToggleState toggleState)
	{
		this.InvokeOnClickToggleBack();
	}

	// Token: 0x0601119F RID: 70047 RVA: 0x0042C2B2 File Offset: 0x0042A4B2
	private void InvokeOnClickToggleBack()
	{
		Action<MotorTechTreeNode, UUIExtendToggle> onClickToggleBack = this.OnClickToggleBack;
		if (onClickToggleBack == null)
		{
			return;
		}
		onClickToggleBack(this.Node, base.GetExtendToggle(0));
	}

	// Token: 0x0400823B RID: 33339
	[Nullable(2)]
	public MotorTechTreeNode Node;

	// Token: 0x0400823C RID: 33340
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MotorcycleTechTreeLevelItem, IMotorTechLevelPoint> LevelLayout;

	// Token: 0x0400823D RID: 33341
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<MotorTechTreeNode, UUIExtendToggle> OnClickToggleBack;

	// Token: 0x02008770 RID: 34672
	[NullableContext(0)]
	private class EMotorTreeComItemComponent
	{
		// Token: 0x0402C062 RID: 180322
		public const int TogItem = 0;

		// Token: 0x0402C063 RID: 180323
		public const int ActivateBgItem = 1;

		// Token: 0x0402C064 RID: 180324
		public const int TexIconActivate = 2;

		// Token: 0x0402C065 RID: 180325
		public const int LockBgItem = 3;

		// Token: 0x0402C066 RID: 180326
		public const int TexIconLock = 4;

		// Token: 0x0402C067 RID: 180327
		public const int LockItem = 5;

		// Token: 0x0402C068 RID: 180328
		public const int RedDotItem = 6;

		// Token: 0x0402C069 RID: 180329
		public const int LevelLayout = 7;

		// Token: 0x0402C06A RID: 180330
		public const int TopUnlockItem = 8;

		// Token: 0x0402C06B RID: 180331
		public const int ActivateBgIcon = 9;

		// Token: 0x0402C06C RID: 180332
		public const int TopLockItem = 10;
	}
}
