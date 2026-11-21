using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001721 RID: 5921
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleTechTreeComStyleItem : UiPanelBase
{
	// Token: 0x0600E637 RID: 58935 RVA: 0x00438E80 File Offset: 0x00437080
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x0600E638 RID: 58936 RVA: 0x00438EDC File Offset: 0x004370DC
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleTechTreeComStyleItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleTechTreeComStyleItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E639 RID: 58937 RVA: 0x00438F1F File Offset: 0x0043711F
	[NullableContext(1)]
	public void SetNodeClick(Action<MotorTechTreeNode, UUIExtendToggle> nodeClick)
	{
		this.CommonNodeItemFirst.OnClickToggleBack = nodeClick;
		this.CommonNodeItemSecond.OnClickToggleBack = nodeClick;
		this.CommonNodeItemThird.OnClickToggleBack = nodeClick;
	}

	// Token: 0x0600E63A RID: 58938 RVA: 0x00438F48 File Offset: 0x00437148
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

	// Token: 0x0600E63B RID: 58939 RVA: 0x00438F94 File Offset: 0x00437194
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

	// Token: 0x0600E63C RID: 58940 RVA: 0x00438FDF File Offset: 0x004371DF
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

	// Token: 0x0400837C RID: 33660
	private MotorcycleTechTreeComNodeItem CommonNodeItemFirst;

	// Token: 0x0400837D RID: 33661
	private MotorcycleTechTreeComNodeItem CommonNodeItemSecond;

	// Token: 0x0400837E RID: 33662
	private MotorcycleTechTreeComNodeItem CommonNodeItemThird;

	// Token: 0x020078FC RID: 30972
	[NullableContext(0)]
	private static class EMotorTreeComStyleItemComponent
	{
		// Token: 0x0402738E RID: 160654
		public const int CommonNodeItem1 = 0;

		// Token: 0x0402738F RID: 160655
		public const int CommonNodeItem2 = 1;

		// Token: 0x04027390 RID: 160656
		public const int CommonNodeItem3 = 2;
	}
}
