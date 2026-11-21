using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001728 RID: 5928
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleTechTreeNodeListItem : GridProxyAbstract<IMotorTechNodeListData>
{
	// Token: 0x0600E662 RID: 58978 RVA: 0x00439B04 File Offset: 0x00437D04
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x0600E663 RID: 58979 RVA: 0x00439B8C File Offset: 0x00437D8C
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleTechTreeNodeListItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleTechTreeNodeListItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E664 RID: 58980 RVA: 0x00439BCF File Offset: 0x00437DCF
	public override void Refresh(IMotorTechNodeListData data, bool isSelected, int gridIndex)
	{
		this.RefreshTopOrBottomAsync(data);
	}

	// Token: 0x0600E665 RID: 58981 RVA: 0x00439BDC File Offset: 0x00437DDC
	private UniTask RefreshTopOrBottomAsync(IMotorTechNodeListData data)
	{
		MotorcycleTechTreeNodeListItem.<RefreshTopOrBottomAsync>d__8 <RefreshTopOrBottomAsync>d__;
		<RefreshTopOrBottomAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTopOrBottomAsync>d__.<>4__this = this;
		<RefreshTopOrBottomAsync>d__.data = data;
		<RefreshTopOrBottomAsync>d__.<>1__state = -1;
		<RefreshTopOrBottomAsync>d__.<>t__builder.Start<MotorcycleTechTreeNodeListItem.<RefreshTopOrBottomAsync>d__8>(ref <RefreshTopOrBottomAsync>d__);
		return <RefreshTopOrBottomAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0400838C RID: 33676
	private readonly List<MotorcycleTechTreeNodeItem> TopNodeItemList = new List<MotorcycleTechTreeNodeItem>();

	// Token: 0x0400838D RID: 33677
	[Nullable(2)]
	private MotorcycleTechTreeNodeItem MiddleNodeItem;

	// Token: 0x0400838E RID: 33678
	private readonly List<MotorcycleTechTreeNodeItem> BottomNodeItemList = new List<MotorcycleTechTreeNodeItem>();

	// Token: 0x0400838F RID: 33679
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<MotorcycleTechTreeNodeItem> OnAfterRefreshOneNode;

	// Token: 0x02007909 RID: 30985
	[NullableContext(0)]
	private class EMotorTreeNodeListItemComponent
	{
		// Token: 0x040273C8 RID: 160712
		public const int NodeItem = 0;

		// Token: 0x040273C9 RID: 160713
		public const int TopLineItem = 1;

		// Token: 0x040273CA RID: 160714
		public const int BottomLineItem = 2;

		// Token: 0x040273CB RID: 160715
		public const int TopRoot = 3;

		// Token: 0x040273CC RID: 160716
		public const int BottomRoot = 4;

		// Token: 0x040273CD RID: 160717
		public const int LeftLineItem = 5;
	}
}
