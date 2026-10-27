using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002333 RID: 9011
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class BattlePassTaskLoopItem : GridProxyAbstract<BattlePassTaskData>
{
	// Token: 0x06011D5D RID: 73053 RVA: 0x00464FA0 File Offset: 0x004631A0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickSkipToBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickTakeRewardBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06011D5E RID: 73054 RVA: 0x00465110 File Offset: 0x00463310
	private void OnClickSkipToBtn()
	{
		BattlePassTaskData dataCache = this.DataCache;
		int? num = (dataCache != null) ? dataCache.SkipId : null;
		if (num != null)
		{
			EventSystem.Instance.Emit<int>(EEventName.OnBattlePassSkip, num.Value);
		}
	}

	// Token: 0x06011D5F RID: 73055 RVA: 0x00465158 File Offset: 0x00463358
	private void OnClickTakeRewardBtn()
	{
		BattlePassController.Instance.TryRequestTaskList(new List<int>
		{
			this.TaskId
		});
	}

	// Token: 0x06011D60 RID: 73056 RVA: 0x00465175 File Offset: 0x00463375
	protected override void OnStart()
	{
		this.CommonItemGrid = new CommonItemSmallItemGrid();
		this.CommonItemGrid.Initialize(base.GetItem(5).GetOwner());
	}

	// Token: 0x06011D61 RID: 73057 RVA: 0x00465199 File Offset: 0x00463399
	[NullableContext(1)]
	public override void Refresh(BattlePassTaskData data, bool isSelected, int gridIndex)
	{
		this.RefreshAsyncInternal(data).Forget();
	}

	// Token: 0x06011D62 RID: 73058 RVA: 0x004651A8 File Offset: 0x004633A8
	[NullableContext(1)]
	private UniTask RefreshAsyncInternal(BattlePassTaskData data)
	{
		BattlePassTaskLoopItem.<RefreshAsyncInternal>d__11 <RefreshAsyncInternal>d__;
		<RefreshAsyncInternal>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsyncInternal>d__.<>4__this = this;
		<RefreshAsyncInternal>d__.data = data;
		<RefreshAsyncInternal>d__.<>1__state = -1;
		<RefreshAsyncInternal>d__.<>t__builder.Start<BattlePassTaskLoopItem.<RefreshAsyncInternal>d__11>(ref <RefreshAsyncInternal>d__);
		return <RefreshAsyncInternal>d__.<>t__builder.Task;
	}

	// Token: 0x04008732 RID: 34610
	private CommonItemSmallItemGrid CommonItemGrid;

	// Token: 0x04008733 RID: 34611
	private BattlePassTaskLoopItemButton SkipToButtonItem;

	// Token: 0x04008734 RID: 34612
	private BattlePassTaskLoopItemButton RewardButtonItem;

	// Token: 0x04008735 RID: 34613
	private int TaskId;

	// Token: 0x04008736 RID: 34614
	private BattlePassTaskData DataCache;

	// Token: 0x020088B4 RID: 34996
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402C6DF RID: 181983
		TaskDescriptionText,
		// Token: 0x0402C6E0 RID: 181984
		CompleteText,
		// Token: 0x0402C6E1 RID: 181985
		SprDone,
		// Token: 0x0402C6E2 RID: 181986
		RunningTip,
		// Token: 0x0402C6E3 RID: 181987
		SkipToBtn,
		// Token: 0x0402C6E4 RID: 181988
		CommonItem,
		// Token: 0x0402C6E5 RID: 181989
		TakeRewardBtn
	}
}
