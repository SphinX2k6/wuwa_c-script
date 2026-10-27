using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x02006283 RID: 25219
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RealmBetweenTaskItemBase<[Nullable(2)] TData> : GridProxyAbstract<TData>
	{
		// Token: 0x0603F798 RID: 259992 RVA: 0x00F58622 File Offset: 0x00F56822
		public RealmBetweenTaskItemBase(ActivityRealmBetweenData activityBaseData)
		{
			this.ActivityBaseData = activityBaseData;
		}

		// Token: 0x0603F799 RID: 259993 RVA: 0x00F58634 File Offset: 0x00F56834
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

		// Token: 0x0603F79A RID: 259994 RVA: 0x00F586FC File Offset: 0x00F568FC
		protected override UniTask OnBeforeStartAsync()
		{
			RealmBetweenTaskItemBase<TData>.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RealmBetweenTaskItemBase<TData>.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F79B RID: 259995 RVA: 0x00F58740 File Offset: 0x00F56940
		protected override void OnStart()
		{
			this.RewardScrollView = new GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData>(base.GetScrollViewWithScrollbar(2), new Func<ActivitySmallItemGrid>(this.InitItem), null, false, null);
			this.ButtonItem.SetLocalTextNew("RealmBetweenJump_Text", Array.Empty<object>());
			this.RewardButtonItem.SetLocalTextNew("RealmBetweenGetReward_Text", Array.Empty<object>());
		}

		// Token: 0x0603F79C RID: 259996 RVA: 0x00F58798 File Offset: 0x00F56998
		private ActivitySmallItemGrid InitItem()
		{
			return new ActivitySmallItemGrid();
		}

		// Token: 0x0603F79D RID: 259997 RVA: 0x00F5879F File Offset: 0x00F5699F
		public override void Refresh(TData taskData, bool isSelected, int gridIndex)
		{
			this.TaskData = taskData;
		}

		// Token: 0x0603F79E RID: 259998 RVA: 0x00F587A8 File Offset: 0x00F569A8
		protected virtual void OnClickedButton()
		{
		}

		// Token: 0x0603F79F RID: 259999 RVA: 0x00F587AA File Offset: 0x00F569AA
		protected virtual void OnClickedRewardButton()
		{
		}

		// Token: 0x040212C7 RID: 135879
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData> RewardScrollView;

		// Token: 0x040212C8 RID: 135880
		protected ActivityButtonItem ButtonItem;

		// Token: 0x040212C9 RID: 135881
		protected ActivityButtonItem RewardButtonItem;

		// Token: 0x040212CA RID: 135882
		protected TData TaskData;

		// Token: 0x040212CB RID: 135883
		protected ActivityRealmBetweenData ActivityBaseData;
	}
}
