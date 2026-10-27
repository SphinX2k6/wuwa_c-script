using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x020061E7 RID: 25063
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoadBookTaskItemBase<[Nullable(2)] TData> : GridProxyAbstract<TData>
	{
		// Token: 0x0603F434 RID: 259124 RVA: 0x00F495A3 File Offset: 0x00F477A3
		public RoadBookTaskItemBase(ActivityRoadBookData activityBaseData)
		{
			this.ActivityBaseData = activityBaseData;
		}

		// Token: 0x0603F435 RID: 259125 RVA: 0x00F495B4 File Offset: 0x00F477B4
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

		// Token: 0x0603F436 RID: 259126 RVA: 0x00F4967C File Offset: 0x00F4787C
		protected override UniTask OnBeforeStartAsync()
		{
			RoadBookTaskItemBase<TData>.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoadBookTaskItemBase<TData>.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F437 RID: 259127 RVA: 0x00F496C0 File Offset: 0x00F478C0
		protected override void OnStart()
		{
			this.RewardScrollView = new GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData>(base.GetScrollViewWithScrollbar(2), new Func<ActivitySmallItemGrid>(this.InitItem), null, false, null);
			this.ButtonItem.SetLocalTextNew("MapTravelJump_Text", Array.Empty<object>());
			this.RewardButtonItem.SetLocalTextNew("MapTravelGetReward_Text", Array.Empty<object>());
		}

		// Token: 0x0603F438 RID: 259128 RVA: 0x00F49718 File Offset: 0x00F47918
		private ActivitySmallItemGrid InitItem()
		{
			return new ActivitySmallItemGrid();
		}

		// Token: 0x0603F439 RID: 259129 RVA: 0x00F4971F File Offset: 0x00F4791F
		public override void Refresh(TData taskData, bool isSelected, int gridIndex)
		{
			this.TaskData = taskData;
		}

		// Token: 0x0603F43A RID: 259130 RVA: 0x00F49728 File Offset: 0x00F47928
		protected virtual void OnClickedButton()
		{
		}

		// Token: 0x0603F43B RID: 259131 RVA: 0x00F4972A File Offset: 0x00F4792A
		protected virtual void OnClickedRewardButton()
		{
		}

		// Token: 0x04020FD5 RID: 135125
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData> RewardScrollView;

		// Token: 0x04020FD6 RID: 135126
		protected ActivityButtonItem ButtonItem;

		// Token: 0x04020FD7 RID: 135127
		protected ActivityButtonItem RewardButtonItem;

		// Token: 0x04020FD8 RID: 135128
		protected TData TaskData;

		// Token: 0x04020FD9 RID: 135129
		protected ActivityRoadBookData ActivityBaseData;
	}
}
