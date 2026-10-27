using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029B0 RID: 10672
public class ShipTowerGetBuffView : UiViewBase
{
	// Token: 0x0601621C RID: 90652 RVA: 0x005990A1 File Offset: 0x005972A1
	[NullableContext(1)]
	public ShipTowerGetBuffView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601621D RID: 90653 RVA: 0x005990AC File Offset: 0x005972AC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.CloseSelf))
		};
	}

	// Token: 0x0601621E RID: 90654 RVA: 0x00599114 File Offset: 0x00597314
	private void InitDataParam()
	{
	}

	// Token: 0x0601621F RID: 90655 RVA: 0x00599118 File Offset: 0x00597318
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerGetBuffView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerGetBuffView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016220 RID: 90656 RVA: 0x0059915C File Offset: 0x0059735C
	protected override void OnBeforeShow()
	{
		List<TItem> itemDataList = (this.OpenParam as ShipTowerGetBuffViewParams).ItemDataList;
		GenericScrollViewNew<CommonItemSmallItemGrid, TItem> rewardLayout = this.RewardLayout;
		if (rewardLayout == null)
		{
			return;
		}
		rewardLayout.RefreshByData(itemDataList, delegate
		{
			GenericScrollViewNew<CommonItemSmallItemGrid, TItem> rewardLayout2 = this.RewardLayout;
			if (rewardLayout2 != null && rewardLayout2.IsExpand)
			{
				GenericScrollViewNew<CommonItemSmallItemGrid, TItem> rewardLayout3 = this.RewardLayout;
				if (rewardLayout3 == null)
				{
					return;
				}
				rewardLayout3.ScrollToLeft(0);
			}
		}, false);
	}

	// Token: 0x06016221 RID: 90657 RVA: 0x00599198 File Offset: 0x00597398
	protected override void OnBeforeDestroy()
	{
		ShipTowerGetBuffViewParams shipTowerGetBuffViewParams = this.OpenParam as ShipTowerGetBuffViewParams;
		if (shipTowerGetBuffViewParams != null)
		{
			CustomPromise<bool> promise = shipTowerGetBuffViewParams.Promise;
			if (promise == null)
			{
				return;
			}
			promise.SetResult(true);
		}
	}

	// Token: 0x0400A4EC RID: 42220
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardLayout;

	// Token: 0x02008FC4 RID: 36804
	private static class EChildType
	{
		// Token: 0x0402E909 RID: 190729
		public const int ScrollBarReward = 0;

		// Token: 0x0402E90A RID: 190730
		public const int BtnClose = 1;
	}
}
