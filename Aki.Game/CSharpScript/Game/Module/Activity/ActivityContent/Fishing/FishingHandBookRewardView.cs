using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005593 RID: 21907
	public class FishingHandBookRewardView : UiViewBase
	{
		// Token: 0x06036492 RID: 222354 RVA: 0x00F23FE3 File Offset: 0x00F221E3
		[NullableContext(1)]
		public FishingHandBookRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06036493 RID: 222355 RVA: 0x00F23FEC File Offset: 0x00F221EC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06036494 RID: 222356 RVA: 0x00F24076 File Offset: 0x00F22276
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.FishingRefreshHandBookRewardView, new Action(this.FishingRefreshHandBookRewardView));
		}

		// Token: 0x06036495 RID: 222357 RVA: 0x00F24094 File Offset: 0x00F22294
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.FishingRefreshHandBookRewardView, new Action(this.FishingRefreshHandBookRewardView));
		}

		// Token: 0x06036496 RID: 222358 RVA: 0x00F240B4 File Offset: 0x00F222B4
		protected override UniTask OnBeforeStartAsync()
		{
			FishingHandBookRewardView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FishingHandBookRewardView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036497 RID: 222359 RVA: 0x00F240F7 File Offset: 0x00F222F7
		protected override void OnStart()
		{
			this.RewardItemLayout = new GenericLayout<FishingHandBookRewardItem, int>(base.GetVerticalLayout(1), new Func<FishingHandBookRewardItem>(this.InitRewardItem), null, false, true);
			this.RefreshLayout();
		}

		// Token: 0x06036498 RID: 222360 RVA: 0x00F24120 File Offset: 0x00F22320
		[NullableContext(1)]
		private FishingHandBookRewardItem InitRewardItem()
		{
			return new FishingHandBookRewardItem();
		}

		// Token: 0x06036499 RID: 222361 RVA: 0x00F24127 File Offset: 0x00F22327
		private void FishingRefreshHandBookRewardView()
		{
			this.RefreshLayout();
		}

		// Token: 0x0603649A RID: 222362 RVA: 0x00F24130 File Offset: 0x00F22330
		private void RefreshLayout()
		{
			List<IFishingReward> list = new List<IFishingReward>(FishingModel.Instance.FishingItemHandBookRewardMap.Values);
			list.Sort(delegate(IFishingReward a, IFishingReward b)
			{
				int num = a.IsTaken ? 2 : ((!a.IsFinished) ? 1 : 0);
				int num2 = b.IsTaken ? 2 : ((!b.IsFinished) ? 1 : 0);
				return num - num2;
			});
			List<int> list2 = new List<int>();
			foreach (IFishingReward fishingReward in list)
			{
				list2.Add(fishingReward.Id);
			}
			this.RewardItemLayout.RefreshByData(list2, delegate
			{
				GenericLayout<FishingHandBookRewardItem, int> rewardItemLayout = this.RewardItemLayout;
				if (rewardItemLayout == null)
				{
					return;
				}
				UUIInturnAnimController uiAnimController = rewardItemLayout.GetUiAnimController();
				if (uiAnimController == null)
				{
					return;
				}
				uiAnimController.Play("", -1, false);
			}, false);
		}

		// Token: 0x0401CA73 RID: 117363
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401CA74 RID: 117364
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<FishingHandBookRewardItem, int> RewardItemLayout;

		// Token: 0x0200B207 RID: 45575
		private class EComponentDefine
		{
			// Token: 0x0403706C RID: 225388
			public const int CaptionItem = 0;

			// Token: 0x0403706D RID: 225389
			public const int RewardItemLayout = 1;

			// Token: 0x0403706E RID: 225390
			public const int RewardItem = 2;
		}
	}
}
