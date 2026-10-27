using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002244 RID: 8772
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleTechTreeNodeListItem : GridProxyAbstract<IMotorTechNodeListData>
{
	// Token: 0x060111CC RID: 70092 RVA: 0x0042CF60 File Offset: 0x0042B160
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

	// Token: 0x060111CD RID: 70093 RVA: 0x0042CFE8 File Offset: 0x0042B1E8
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleTechTreeNodeListItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleTechTreeNodeListItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060111CE RID: 70094 RVA: 0x0042D02B File Offset: 0x0042B22B
	public override void Refresh(IMotorTechNodeListData data, bool isSelected, int gridIndex)
	{
		this.RefreshTopOrBottomAsync(data);
	}

	// Token: 0x060111CF RID: 70095 RVA: 0x0042D038 File Offset: 0x0042B238
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

	// Token: 0x0400824E RID: 33358
	private readonly List<MotorcycleTechTreeNodeItem> TopNodeItemList = new List<MotorcycleTechTreeNodeItem>();

	// Token: 0x0400824F RID: 33359
	[Nullable(2)]
	private MotorcycleTechTreeNodeItem MiddleNodeItem;

	// Token: 0x04008250 RID: 33360
	private readonly List<MotorcycleTechTreeNodeItem> BottomNodeItemList = new List<MotorcycleTechTreeNodeItem>();

	// Token: 0x04008251 RID: 33361
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<MotorcycleTechTreeNodeItem> OnAfterRefreshOneNode;

	// Token: 0x02008780 RID: 34688
	[NullableContext(0)]
	private class EMotorTreeNodeListItemComponent
	{
		// Token: 0x0402C0B0 RID: 180400
		public const int NodeItem = 0;

		// Token: 0x0402C0B1 RID: 180401
		public const int TopLineItem = 1;

		// Token: 0x0402C0B2 RID: 180402
		public const int BottomLineItem = 2;

		// Token: 0x0402C0B3 RID: 180403
		public const int TopRoot = 3;

		// Token: 0x0402C0B4 RID: 180404
		public const int BottomRoot = 4;

		// Token: 0x0402C0B5 RID: 180405
		public const int LeftLineItem = 5;
	}
}
