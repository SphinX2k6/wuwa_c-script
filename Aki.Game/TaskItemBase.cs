using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020012DF RID: 4831
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class TaskItemBase<[Nullable(2)] TData> : GridProxyAbstract<TData>
{
	// Token: 0x0600853A RID: 34106 RVA: 0x001C54D3 File Offset: 0x001C36D3
	public TaskItemBase(ActivityMapTravelData activityBaseData)
	{
		this.ActivityBaseData = activityBaseData;
	}

	// Token: 0x0600853B RID: 34107 RVA: 0x001C54E4 File Offset: 0x001C36E4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600853C RID: 34108 RVA: 0x001C5614 File Offset: 0x001C3814
	protected override UniTask OnBeforeStartAsync()
	{
		TaskItemBase<TData>.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TaskItemBase<TData>.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600853D RID: 34109 RVA: 0x001C5658 File Offset: 0x001C3858
	protected override void OnStart()
	{
		this.RewardScrollView = new GenericLayout<ActivitySmallItemGrid, IItemGridData>(base.GetHorizontalLayout(2), new Func<ActivitySmallItemGrid>(this.InitItem), null, false, true);
		this.ButtonItem.SetLocalTextNew("MapTravelJump_Text", Array.Empty<object>());
		this.RewardButtonItem.SetLocalTextNew("MapTravelGetReward_Text", Array.Empty<object>());
	}

	// Token: 0x0600853E RID: 34110 RVA: 0x001C56B0 File Offset: 0x001C38B0
	private ActivitySmallItemGrid InitItem()
	{
		return new ActivitySmallItemGrid();
	}

	// Token: 0x0600853F RID: 34111 RVA: 0x001C56B7 File Offset: 0x001C38B7
	public override void Refresh(TData taskData, bool isSelected, int gridIndex)
	{
		this.TaskData = taskData;
	}

	// Token: 0x06008540 RID: 34112 RVA: 0x001C56C0 File Offset: 0x001C38C0
	protected virtual void OnClickedButton()
	{
	}

	// Token: 0x06008541 RID: 34113 RVA: 0x001C56C2 File Offset: 0x001C38C2
	protected virtual void OnClickedRewardButton()
	{
	}

	// Token: 0x04003BC2 RID: 15298
	protected GenericLayout<ActivitySmallItemGrid, IItemGridData> RewardScrollView;

	// Token: 0x04003BC3 RID: 15299
	protected ActivityButtonItem ButtonItem;

	// Token: 0x04003BC4 RID: 15300
	protected ActivityButtonItem RewardButtonItem;

	// Token: 0x04003BC5 RID: 15301
	protected TData TaskData;

	// Token: 0x04003BC6 RID: 15302
	protected ActivityMapTravelData ActivityBaseData;
}
