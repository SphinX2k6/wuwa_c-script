using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F2B RID: 7979
public class ShipTowerGetBuffView : UiViewBase
{
	// Token: 0x06013C22 RID: 80930 RVA: 0x005C402D File Offset: 0x005C222D
	[NullableContext(1)]
	public ShipTowerGetBuffView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013C23 RID: 80931 RVA: 0x005C4038 File Offset: 0x005C2238
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

	// Token: 0x06013C24 RID: 80932 RVA: 0x005C40A0 File Offset: 0x005C22A0
	private void InitDataParam()
	{
	}

	// Token: 0x06013C25 RID: 80933 RVA: 0x005C40A4 File Offset: 0x005C22A4
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerGetBuffView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerGetBuffView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013C26 RID: 80934 RVA: 0x005C40E8 File Offset: 0x005C22E8
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

	// Token: 0x06013C27 RID: 80935 RVA: 0x005C4124 File Offset: 0x005C2324
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

	// Token: 0x0400A8D6 RID: 43222
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardLayout;

	// Token: 0x0200820C RID: 33292
	private static class EChildType
	{
		// Token: 0x0402A006 RID: 172038
		public const int ScrollBarReward = 0;

		// Token: 0x0402A007 RID: 172039
		public const int BtnClose = 1;
	}
}
