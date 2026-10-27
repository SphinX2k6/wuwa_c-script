using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200223D RID: 8765
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleTechTreeComStyleItem : UiPanelBase
{
	// Token: 0x060111A1 RID: 70049 RVA: 0x0042C2DC File Offset: 0x0042A4DC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x060111A2 RID: 70050 RVA: 0x0042C338 File Offset: 0x0042A538
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleTechTreeComStyleItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleTechTreeComStyleItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060111A3 RID: 70051 RVA: 0x0042C37B File Offset: 0x0042A57B
	[NullableContext(1)]
	public void SetNodeClick(Action<MotorTechTreeNode, UUIExtendToggle> nodeClick)
	{
		this.CommonNodeItemFirst.OnClickToggleBack = nodeClick;
		this.CommonNodeItemSecond.OnClickToggleBack = nodeClick;
		this.CommonNodeItemThird.OnClickToggleBack = nodeClick;
	}

	// Token: 0x060111A4 RID: 70052 RVA: 0x0042C3A4 File Offset: 0x0042A5A4
	[NullableContext(1)]
	private UniTask RefreshOneNodeItemAsync(MotorcycleTechTreeComNodeItem item, int nodeId)
	{
		MotorcycleTechTreeComStyleItem.<RefreshOneNodeItemAsync>d__7 <RefreshOneNodeItemAsync>d__;
		<RefreshOneNodeItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshOneNodeItemAsync>d__.item = item;
		<RefreshOneNodeItemAsync>d__.nodeId = nodeId;
		<RefreshOneNodeItemAsync>d__.<>1__state = -1;
		<RefreshOneNodeItemAsync>d__.<>t__builder.Start<MotorcycleTechTreeComStyleItem.<RefreshOneNodeItemAsync>d__7>(ref <RefreshOneNodeItemAsync>d__);
		return <RefreshOneNodeItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060111A5 RID: 70053 RVA: 0x0042C3F0 File Offset: 0x0042A5F0
	[NullableContext(1)]
	public UniTask RefreshCommonNodeItemAsync(int[] nodeIds)
	{
		MotorcycleTechTreeComStyleItem.<RefreshCommonNodeItemAsync>d__8 <RefreshCommonNodeItemAsync>d__;
		<RefreshCommonNodeItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshCommonNodeItemAsync>d__.<>4__this = this;
		<RefreshCommonNodeItemAsync>d__.nodeIds = nodeIds;
		<RefreshCommonNodeItemAsync>d__.<>1__state = -1;
		<RefreshCommonNodeItemAsync>d__.<>t__builder.Start<MotorcycleTechTreeComStyleItem.<RefreshCommonNodeItemAsync>d__8>(ref <RefreshCommonNodeItemAsync>d__);
		return <RefreshCommonNodeItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060111A6 RID: 70054 RVA: 0x0042C43B File Offset: 0x0042A63B
	public MotorcycleTechTreeComNodeItem GetGuideNodeItem(int index)
	{
		switch (index)
		{
		case 0:
			return this.CommonNodeItemFirst;
		case 1:
			return this.CommonNodeItemSecond;
		case 2:
			return this.CommonNodeItemThird;
		default:
			return null;
		}
	}

	// Token: 0x0400823E RID: 33342
	private MotorcycleTechTreeComNodeItem CommonNodeItemFirst;

	// Token: 0x0400823F RID: 33343
	private MotorcycleTechTreeComNodeItem CommonNodeItemSecond;

	// Token: 0x04008240 RID: 33344
	private MotorcycleTechTreeComNodeItem CommonNodeItemThird;

	// Token: 0x02008773 RID: 34675
	[NullableContext(0)]
	private static class EMotorTreeComStyleItemComponent
	{
		// Token: 0x0402C076 RID: 180342
		public const int CommonNodeItem1 = 0;

		// Token: 0x0402C077 RID: 180343
		public const int CommonNodeItem2 = 1;

		// Token: 0x0402C078 RID: 180344
		public const int CommonNodeItem3 = 2;
	}
}
