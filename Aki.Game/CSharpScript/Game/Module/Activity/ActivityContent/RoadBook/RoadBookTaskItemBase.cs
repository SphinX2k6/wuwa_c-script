using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x02005165 RID: 20837
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoadBookTaskItemBase<[Nullable(2)] TData> : GridProxyAbstract<TData>
	{
		// Token: 0x060340F5 RID: 213237 RVA: 0x00E904FB File Offset: 0x00E8E6FB
		public RoadBookTaskItemBase(ActivityRoadBookData activityBaseData)
		{
			this.ActivityBaseData = activityBaseData;
		}

		// Token: 0x060340F6 RID: 213238 RVA: 0x00E9050C File Offset: 0x00E8E70C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem))
			};
		}

		// Token: 0x060340F7 RID: 213239 RVA: 0x00E905D4 File Offset: 0x00E8E7D4
		protected override UniTask OnBeforeStartAsync()
		{
			RoadBookTaskItemBase<TData>.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoadBookTaskItemBase<TData>.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060340F8 RID: 213240 RVA: 0x00E90618 File Offset: 0x00E8E818
		protected override void OnStart()
		{
			this.RewardScrollView = new GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData>(base.GetScrollViewWithScrollbar(2), new Func<ActivitySmallItemGrid>(this.InitItem), null, false, null);
			this.ButtonItem.SetLocalTextNew("MapTravelJump_Text", Array.Empty<object>());
			this.RewardButtonItem.SetLocalTextNew("MapTravelGetReward_Text", Array.Empty<object>());
		}

		// Token: 0x060340F9 RID: 213241 RVA: 0x00E90670 File Offset: 0x00E8E870
		private ActivitySmallItemGrid InitItem()
		{
			return new ActivitySmallItemGrid();
		}

		// Token: 0x060340FA RID: 213242 RVA: 0x00E90677 File Offset: 0x00E8E877
		public override void Refresh(TData taskData, bool isSelected, int gridIndex)
		{
			this.TaskData = taskData;
		}

		// Token: 0x060340FB RID: 213243 RVA: 0x00E90680 File Offset: 0x00E8E880
		protected virtual void OnClickedButton()
		{
		}

		// Token: 0x060340FC RID: 213244 RVA: 0x00E90682 File Offset: 0x00E8E882
		protected virtual void OnClickedRewardButton()
		{
		}

		// Token: 0x0401B904 RID: 112900
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData> RewardScrollView;

		// Token: 0x0401B905 RID: 112901
		protected ActivityButtonItem ButtonItem;

		// Token: 0x0401B906 RID: 112902
		protected ActivityButtonItem RewardButtonItem;

		// Token: 0x0401B907 RID: 112903
		protected TData TaskData;

		// Token: 0x0401B908 RID: 112904
		protected ActivityRoadBookData ActivityBaseData;
	}
}
