using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonSignIn
{
	// Token: 0x02006469 RID: 25705
	[NullableContext(1)]
	[Nullable(0)]
	public class MoonSignInRewardView : UiViewBase
	{
		// Token: 0x0604098D RID: 264589 RVA: 0x00FA2F30 File Offset: 0x00FA1130
		public MoonSignInRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0604098E RID: 264590 RVA: 0x00FA2F3C File Offset: 0x00FA113C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 14;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClickRewardBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0604098F RID: 264591 RVA: 0x00FA3178 File Offset: 0x00FA1378
		protected override UniTask OnBeforeStartAsync()
		{
			MoonSignInRewardView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoonSignInRewardView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040990 RID: 264592 RVA: 0x00FA31BB File Offset: 0x00FA13BB
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.MoonSignRewardRefresh, new Action(this.MoonSignRewardRefresh));
		}

		// Token: 0x06040991 RID: 264593 RVA: 0x00FA31D9 File Offset: 0x00FA13D9
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.MoonSignRewardRefresh, new Action(this.MoonSignRewardRefresh));
		}

		// Token: 0x06040992 RID: 264594 RVA: 0x00FA31F8 File Offset: 0x00FA13F8
		protected override void OnStart()
		{
			this.NormalRewardGenericScrollView = new GenericScrollViewNew<NormalRewardItem, int>(base.GetScrollViewWithScrollbar(1), new Func<NormalRewardItem>(this.InitGridItem), null, false, null);
			this.GrandRewardGenericScrollView = new GenericScrollViewNew<RewardItem, IRewardItemData>(base.GetScrollViewWithScrollbar(6), new Func<RewardItem>(this.InitGrandRewardGridItem), null, false, null);
			base.GetItem(12).SetUIActive(false);
			base.GetItem(13).SetUIActive(true);
			this.NormalRewardGenericScrollView.BindScrollValueChange(delegate(FVector2D progress)
			{
				base.GetItem(12).SetUIActive(progress.X < 1f);
				base.GetItem(13).SetUIActive(progress.X > 0f);
			});
		}

		// Token: 0x06040993 RID: 264595 RVA: 0x00FA327A File Offset: 0x00FA147A
		protected override void OnBeforeShow()
		{
			this.MoonSignRewardRefresh();
		}

		// Token: 0x06040994 RID: 264596 RVA: 0x00FA3284 File Offset: 0x00FA1484
		private void RefreshGrandRewardScrollView()
		{
			MoonSignInData data = MoonSignInController.Instance.GetData();
			if (data == null)
			{
				return;
			}
			MoonPhaseReward? moonSignReward = MoonSignInConfig.Instance.GetMoonSignReward(data.Id);
			if (moonSignReward == null)
			{
				return;
			}
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(moonSignReward.Value.Reward);
			bool moonGrandReward = data.MoonGrandReward;
			List<IRewardItemData> list = new List<IRewardItemData>();
			foreach (TItem itemData in dropPackagePreviewItemList)
			{
				RewardItemDataImpl item = new RewardItemDataImpl
				{
					ItemData = itemData,
					HaveFinish = moonGrandReward
				};
				list.Add(item);
			}
			this.GrandRewardGenericScrollView.RefreshByData(list, null, false);
		}

		// Token: 0x06040995 RID: 264597 RVA: 0x00FA334C File Offset: 0x00FA154C
		private NormalRewardItem InitGridItem()
		{
			return new NormalRewardItem();
		}

		// Token: 0x06040996 RID: 264598 RVA: 0x00FA3353 File Offset: 0x00FA1553
		private RewardItem InitGrandRewardGridItem()
		{
			return new RewardItem();
		}

		// Token: 0x06040997 RID: 264599 RVA: 0x00FA335C File Offset: 0x00FA155C
		private void MoonSignRewardRefresh()
		{
			GenericScrollViewNew<NormalRewardItem, int> normalRewardGenericScrollView = this.NormalRewardGenericScrollView;
			if (normalRewardGenericScrollView != null)
			{
				MoonSignInData data = MoonSignInController.Instance.GetData();
				normalRewardGenericScrollView.RefreshByData(((data != null) ? data.GetMoonNormalRewardData() : null) ?? new List<int>(), null, false);
			}
			this.RefreshGrandRewardScrollView();
			this.RefreshBtnState();
			this.RefreshDesText();
		}

		// Token: 0x06040998 RID: 264600 RVA: 0x00FA33B0 File Offset: 0x00FA15B0
		private void RefreshDesText()
		{
			MoonSignInData data = MoonSignInController.Instance.GetData();
			if (data == null)
			{
				return;
			}
			MoonPhaseReward? moonSignReward = MoonSignInConfig.Instance.GetMoonSignReward(data.Id);
			if (moonSignReward == null)
			{
				return;
			}
			int count = data.HaveSelectMoonPhaseSelectList.Count;
			int needMoonNum = moonSignReward.Value.NeedMoonNum;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "MoonSignInGrandRewardDes", new <>z__ReadOnlyArray<object>(new object[]
			{
				needMoonNum.ToString(),
				count.ToString(),
				needMoonNum.ToString()
			}));
		}

		// Token: 0x06040999 RID: 264601 RVA: 0x00FA3444 File Offset: 0x00FA1644
		private void RefreshBtnState()
		{
			MoonSignInData data = MoonSignInController.Instance.GetData();
			if (data == null)
			{
				return;
			}
			bool moonGrandReward = data.MoonGrandReward;
			bool canGetMoonGrandReward = data.GetCanGetMoonGrandReward();
			base.GetItem(11).SetUIActive(moonGrandReward);
			base.GetItem(10).SetUIActive(!moonGrandReward && !canGetMoonGrandReward);
			base.GetButton(9).RootUIComp.Get().SetUIActive(!moonGrandReward && canGetMoonGrandReward);
		}

		// Token: 0x0604099A RID: 264602 RVA: 0x00FA34B4 File Offset: 0x00FA16B4
		private void OnClickRewardBtn()
		{
			MoonSignInData data = MoonSignInController.Instance.GetData();
			if (data == null)
			{
				return;
			}
			if (data.GetCanGetMoonGrandReward())
			{
				MoonSignInController.Instance.MoonPhaseRewardRequest(data.Id);
			}
		}

		// Token: 0x04021958 RID: 137560
		private PopupCaptionItem CaptionItem;

		// Token: 0x04021959 RID: 137561
		private GenericScrollViewNew<NormalRewardItem, int> NormalRewardGenericScrollView;

		// Token: 0x0402195A RID: 137562
		private GenericScrollViewNew<RewardItem, IRewardItemData> GrandRewardGenericScrollView;

		// Token: 0x0200C695 RID: 50837
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403BF3B RID: 245563
			public const int CaptionItem = 0;

			// Token: 0x0403BF3C RID: 245564
			public const int RewardScrollView = 1;

			// Token: 0x0403BF3D RID: 245565
			public const int RewardContentItem = 2;

			// Token: 0x0403BF3E RID: 245566
			public const int RewardItem = 3;

			// Token: 0x0403BF3F RID: 245567
			public const int MoonGrandRewardTitleText = 4;

			// Token: 0x0403BF40 RID: 245568
			public const int MoonGrandRewardDesText = 5;

			// Token: 0x0403BF41 RID: 245569
			public const int MoonGrandRewardScrollView = 6;

			// Token: 0x0403BF42 RID: 245570
			public const int MoonGrandRewardContentItem = 7;

			// Token: 0x0403BF43 RID: 245571
			public const int MoonGrandRewardItem = 8;

			// Token: 0x0403BF44 RID: 245572
			public const int RewardBtn = 9;

			// Token: 0x0403BF45 RID: 245573
			public const int UnFinishItem = 10;

			// Token: 0x0403BF46 RID: 245574
			public const int ObtainedItem = 11;

			// Token: 0x0403BF47 RID: 245575
			public const int LeftButton = 12;

			// Token: 0x0403BF48 RID: 245576
			public const int RightButton = 13;
		}
	}
}
