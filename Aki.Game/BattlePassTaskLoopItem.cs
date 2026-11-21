using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001818 RID: 6168
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class BattlePassTaskLoopItem : GridProxyAbstract<BattlePassTaskData>
{
	// Token: 0x0600F20D RID: 61965 RVA: 0x00472068 File Offset: 0x00470268
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

	// Token: 0x0600F20E RID: 61966 RVA: 0x004721D8 File Offset: 0x004703D8
	private void OnClickSkipToBtn()
	{
		BattlePassTaskData dataCache = this.DataCache;
		int? num = (dataCache != null) ? dataCache.SkipId : null;
		if (num != null)
		{
			EventSystem.Instance.Emit<int>(EEventName.OnBattlePassSkip, num.Value);
		}
	}

	// Token: 0x0600F20F RID: 61967 RVA: 0x00472220 File Offset: 0x00470420
	private void OnClickTakeRewardBtn()
	{
		BattlePassController.Instance.TryRequestTaskList(new List<int>
		{
			this.TaskId
		});
	}

	// Token: 0x0600F210 RID: 61968 RVA: 0x0047223D File Offset: 0x0047043D
	protected override void OnStart()
	{
		this.CommonItemGrid = new CommonItemSmallItemGrid();
		this.CommonItemGrid.Initialize(base.GetItem(5).GetOwner());
	}

	// Token: 0x0600F211 RID: 61969 RVA: 0x00472261 File Offset: 0x00470461
	[NullableContext(1)]
	public override void Refresh(BattlePassTaskData data, bool isSelected, int gridIndex)
	{
		this.RefreshAsyncInternal(data).Forget();
	}

	// Token: 0x0600F212 RID: 61970 RVA: 0x00472270 File Offset: 0x00470470
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

	// Token: 0x04008875 RID: 34933
	private CommonItemSmallItemGrid CommonItemGrid;

	// Token: 0x04008876 RID: 34934
	private BattlePassTaskLoopItemButton SkipToButtonItem;

	// Token: 0x04008877 RID: 34935
	private BattlePassTaskLoopItemButton RewardButtonItem;

	// Token: 0x04008878 RID: 34936
	private int TaskId;

	// Token: 0x04008879 RID: 34937
	private BattlePassTaskData DataCache;

	// Token: 0x02007A3D RID: 31293
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x040279F3 RID: 162291
		TaskDescriptionText,
		// Token: 0x040279F4 RID: 162292
		CompleteText,
		// Token: 0x040279F5 RID: 162293
		SprDone,
		// Token: 0x040279F6 RID: 162294
		RunningTip,
		// Token: 0x040279F7 RID: 162295
		SkipToBtn,
		// Token: 0x040279F8 RID: 162296
		CommonItem,
		// Token: 0x040279F9 RID: 162297
		TakeRewardBtn
	}
}
