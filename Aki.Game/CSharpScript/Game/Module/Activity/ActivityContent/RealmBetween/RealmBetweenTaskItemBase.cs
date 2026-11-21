using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x02005201 RID: 20993
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RealmBetweenTaskItemBase<[Nullable(2)] TData> : GridProxyAbstract<TData>
	{
		// Token: 0x06034459 RID: 214105 RVA: 0x00E9F57E File Offset: 0x00E9D77E
		public RealmBetweenTaskItemBase(ActivityRealmBetweenData activityBaseData)
		{
			this.ActivityBaseData = activityBaseData;
		}

		// Token: 0x0603445A RID: 214106 RVA: 0x00E9F590 File Offset: 0x00E9D790
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

		// Token: 0x0603445B RID: 214107 RVA: 0x00E9F658 File Offset: 0x00E9D858
		protected override UniTask OnBeforeStartAsync()
		{
			RealmBetweenTaskItemBase<TData>.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RealmBetweenTaskItemBase<TData>.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603445C RID: 214108 RVA: 0x00E9F69C File Offset: 0x00E9D89C
		protected override void OnStart()
		{
			this.RewardScrollView = new GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData>(base.GetScrollViewWithScrollbar(2), new Func<ActivitySmallItemGrid>(this.InitItem), null, false, null);
			this.ButtonItem.SetLocalTextNew("RealmBetweenJump_Text", Array.Empty<object>());
			this.RewardButtonItem.SetLocalTextNew("RealmBetweenGetReward_Text", Array.Empty<object>());
		}

		// Token: 0x0603445D RID: 214109 RVA: 0x00E9F6F4 File Offset: 0x00E9D8F4
		private ActivitySmallItemGrid InitItem()
		{
			return new ActivitySmallItemGrid();
		}

		// Token: 0x0603445E RID: 214110 RVA: 0x00E9F6FB File Offset: 0x00E9D8FB
		public override void Refresh(TData taskData, bool isSelected, int gridIndex)
		{
			this.TaskData = taskData;
		}

		// Token: 0x0603445F RID: 214111 RVA: 0x00E9F704 File Offset: 0x00E9D904
		protected virtual void OnClickedButton()
		{
		}

		// Token: 0x06034460 RID: 214112 RVA: 0x00E9F706 File Offset: 0x00E9D906
		protected virtual void OnClickedRewardButton()
		{
		}

		// Token: 0x0401BBF6 RID: 113654
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData> RewardScrollView;

		// Token: 0x0401BBF7 RID: 113655
		protected ActivityButtonItem ButtonItem;

		// Token: 0x0401BBF8 RID: 113656
		protected ActivityButtonItem RewardButtonItem;

		// Token: 0x0401BBF9 RID: 113657
		protected TData TaskData;

		// Token: 0x0401BBFA RID: 113658
		protected ActivityRealmBetweenData ActivityBaseData;
	}
}
