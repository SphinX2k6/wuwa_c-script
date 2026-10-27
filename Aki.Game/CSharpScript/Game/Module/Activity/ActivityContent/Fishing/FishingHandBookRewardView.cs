using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02006615 RID: 26133
	public class FishingHandBookRewardView : UiViewBase
	{
		// Token: 0x060417CD RID: 268237 RVA: 0x00FDCF4B File Offset: 0x00FDB14B
		[NullableContext(1)]
		public FishingHandBookRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060417CE RID: 268238 RVA: 0x00FDCF54 File Offset: 0x00FDB154
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

		// Token: 0x060417CF RID: 268239 RVA: 0x00FDCFDE File Offset: 0x00FDB1DE
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.FishingRefreshHandBookRewardView, new Action(this.FishingRefreshHandBookRewardView));
		}

		// Token: 0x060417D0 RID: 268240 RVA: 0x00FDCFFC File Offset: 0x00FDB1FC
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.FishingRefreshHandBookRewardView, new Action(this.FishingRefreshHandBookRewardView));
		}

		// Token: 0x060417D1 RID: 268241 RVA: 0x00FDD01C File Offset: 0x00FDB21C
		protected override UniTask OnBeforeStartAsync()
		{
			FishingHandBookRewardView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FishingHandBookRewardView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060417D2 RID: 268242 RVA: 0x00FDD05F File Offset: 0x00FDB25F
		protected override void OnStart()
		{
			this.RewardItemLayout = new GenericLayout<FishingHandBookRewardItem, int>(base.GetVerticalLayout(1), new Func<FishingHandBookRewardItem>(this.InitRewardItem), null, false, true);
			this.RefreshLayout();
		}

		// Token: 0x060417D3 RID: 268243 RVA: 0x00FDD088 File Offset: 0x00FDB288
		[NullableContext(1)]
		private FishingHandBookRewardItem InitRewardItem()
		{
			return new FishingHandBookRewardItem();
		}

		// Token: 0x060417D4 RID: 268244 RVA: 0x00FDD08F File Offset: 0x00FDB28F
		private void FishingRefreshHandBookRewardView()
		{
			this.RefreshLayout();
		}

		// Token: 0x060417D5 RID: 268245 RVA: 0x00FDD098 File Offset: 0x00FDB298
		private void RefreshLayout()
		{
			List<IFishingReward> list = FishingModel.Instance.FishingItemHandBookRewardMap.Values.ToList<IFishingReward>();
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

		// Token: 0x04022142 RID: 139586
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04022143 RID: 139587
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<FishingHandBookRewardItem, int> RewardItemLayout;

		// Token: 0x0200C825 RID: 51237
		private class EComponentDefine
		{
			// Token: 0x0403C727 RID: 247591
			public const int CaptionItem = 0;

			// Token: 0x0403C728 RID: 247592
			public const int RewardItemLayout = 1;

			// Token: 0x0403C729 RID: 247593
			public const int RewardItem = 2;
		}
	}
}
