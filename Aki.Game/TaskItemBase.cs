using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000793 RID: 1939
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class TaskItemBase<[Nullable(2)] TData> : GridProxyAbstract<TData>
{
	// Token: 0x060058D5 RID: 22741 RVA: 0x001CE32F File Offset: 0x001CC52F
	public TaskItemBase(ActivityMapTravelData activityBaseData)
	{
		this.ActivityBaseData = activityBaseData;
	}

	// Token: 0x060058D6 RID: 22742 RVA: 0x001CE340 File Offset: 0x001CC540
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

	// Token: 0x060058D7 RID: 22743 RVA: 0x001CE470 File Offset: 0x001CC670
	protected override UniTask OnBeforeStartAsync()
	{
		TaskItemBase<TData>.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TaskItemBase<TData>.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060058D8 RID: 22744 RVA: 0x001CE4B4 File Offset: 0x001CC6B4
	protected override void OnStart()
	{
		this.RewardScrollView = new GenericLayout<ActivitySmallItemGrid, IItemGridData>(base.GetHorizontalLayout(2), new Func<ActivitySmallItemGrid>(this.InitItem), null, false, true);
		this.ButtonItem.SetLocalTextNew("MapTravelJump_Text", Array.Empty<object>());
		this.RewardButtonItem.SetLocalTextNew("MapTravelGetReward_Text", Array.Empty<object>());
	}

	// Token: 0x060058D9 RID: 22745 RVA: 0x001CE50C File Offset: 0x001CC70C
	private ActivitySmallItemGrid InitItem()
	{
		return new ActivitySmallItemGrid();
	}

	// Token: 0x060058DA RID: 22746 RVA: 0x001CE513 File Offset: 0x001CC713
	public override void Refresh(TData taskData, bool isSelected, int gridIndex)
	{
		this.TaskData = taskData;
	}

	// Token: 0x060058DB RID: 22747 RVA: 0x001CE51C File Offset: 0x001CC71C
	protected virtual void OnClickedButton()
	{
	}

	// Token: 0x060058DC RID: 22748 RVA: 0x001CE51E File Offset: 0x001CC71E
	protected virtual void OnClickedRewardButton()
	{
	}

	// Token: 0x04003C5A RID: 15450
	protected GenericLayout<ActivitySmallItemGrid, IItemGridData> RewardScrollView;

	// Token: 0x04003C5B RID: 15451
	protected ActivityButtonItem ButtonItem;

	// Token: 0x04003C5C RID: 15452
	protected ActivityButtonItem RewardButtonItem;

	// Token: 0x04003C5D RID: 15453
	protected TData TaskData;

	// Token: 0x04003C5E RID: 15454
	protected ActivityMapTravelData ActivityBaseData;
}
