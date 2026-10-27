using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057F6 RID: 22518
	public class CompositeRewardView : UiTickViewBase
	{
		// Token: 0x060393CD RID: 234445 RVA: 0x00D9257F File Offset: 0x00D9077F
		[NullableContext(1)]
		public CompositeRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060393CE RID: 234446 RVA: 0x00D92588 File Offset: 0x00D90788
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedMaskButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060393CF RID: 234447 RVA: 0x00D926F4 File Offset: 0x00D908F4
		private void OnClickedMaskButton()
		{
			UiManager.Instance.CloseView(EUiViewName.CompositeRewardView, null);
		}

		// Token: 0x060393D0 RID: 234448 RVA: 0x00D92706 File Offset: 0x00D90906
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<IReadOnlyList<RewardItemData>>(EEventName.OnRefreshRewardViewItemList, new Action<IReadOnlyList<RewardItemData>>(this.OnRefreshRewardItemList));
			EventSystem.Instance.Add(EEventName.OnRefreshRewardProgressBar, new Action(this.OnRefreshRewardProgressBar));
		}

		// Token: 0x060393D1 RID: 234449 RVA: 0x00D92740 File Offset: 0x00D90940
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnRefreshRewardViewItemList, new Action<IReadOnlyList<RewardItemData>>(this.OnRefreshRewardItemList));
			EventSystem.Instance.Remove(EEventName.OnRefreshRewardProgressBar, new Action(this.OnRefreshRewardProgressBar));
		}

		// Token: 0x060393D2 RID: 234450 RVA: 0x00D9277A File Offset: 0x00D9097A
		[NullableContext(1)]
		private void OnRefreshRewardItemList(IReadOnlyList<RewardItemData> itemList)
		{
			if (this.RefreshItemListVisible())
			{
				this.RefreshItemList();
			}
		}

		// Token: 0x060393D3 RID: 234451 RVA: 0x00D9278A File Offset: 0x00D9098A
		private void OnRefreshRewardProgressBar()
		{
			if (this.RefreshProgressVisible())
			{
				this.RefreshProgressBar();
			}
		}

		// Token: 0x060393D4 RID: 234452 RVA: 0x00D9279C File Offset: 0x00D9099C
		protected override UniTask OnBeforeStartAsync()
		{
			CompositeRewardView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CompositeRewardView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060393D5 RID: 234453 RVA: 0x00D927E0 File Offset: 0x00D909E0
		protected override void OnStart()
		{
			this.RewardData = (this.OpenParam as RewardData<ICompositeRewardInfo>);
			if (this.RefreshTitleVisible())
			{
				this.RefreshTitle();
			}
			if (this.RefreshTitleTextureVisible())
			{
				this.RefreshTitleTexture();
			}
			if (this.RefreshContinueTextVisible())
			{
				this.RefreshContinueText();
			}
			if (this.RefreshItemListVisible())
			{
				this.RefreshItemList();
			}
			if (this.RefreshProgressVisible())
			{
				this.RefreshProgressBar();
			}
			string audioId = this.RewardData.GetRewardInfo().AudioId;
			ItemRewardController.Instance.PlayAudio(audioId, null);
		}

		// Token: 0x060393D6 RID: 234454 RVA: 0x00D92864 File Offset: 0x00D90A64
		protected override void OnAfterShow()
		{
			if (this.RewardData.GetRewardInfo().IsSuccess)
			{
				this.UiViewSequence.PlaySequence("Success", true, null);
			}
			else
			{
				this.UiViewSequence.PlaySequence("Fail", true, null);
			}
			EventSystem.Instance.Emit(EEventName.OnShowRewardView);
		}

		// Token: 0x060393D7 RID: 234455 RVA: 0x00D928C9 File Offset: 0x00D90AC9
		protected override void OnBeforeDestroy()
		{
			this.RewardProgressBar = null;
			this.RewardData = null;
			ItemRewardModel.Instance.ClearCurrentRewardData();
		}

		// Token: 0x060393D8 RID: 234456 RVA: 0x00D928E3 File Offset: 0x00D90AE3
		protected override void OnTick(float delta)
		{
			this.RewardProgressBar.Tick(delta);
		}

		// Token: 0x060393D9 RID: 234457 RVA: 0x00D928F4 File Offset: 0x00D90AF4
		private bool RefreshTitleVisible()
		{
			bool flag = !StringUtils.IsEmpty(this.RewardData.GetRewardInfo().Title);
			base.GetItem(4).SetUIActive(flag);
			return flag;
		}

		// Token: 0x060393DA RID: 234458 RVA: 0x00D92928 File Offset: 0x00D90B28
		private void RefreshTitle()
		{
			string title = this.RewardData.GetRewardInfo().Title;
			if (StringUtils.IsEmpty(title))
			{
				return;
			}
			UUIText text = base.GetText(1);
			LguiUtil.Instance.SetLocalTextNew(text, title, Array.Empty<object>());
		}

		// Token: 0x060393DB RID: 234459 RVA: 0x00D92968 File Offset: 0x00D90B68
		private bool RefreshTitleTextureVisible()
		{
			bool flag = !StringUtils.IsEmpty(this.RewardData.GetRewardInfo().TitleIconPath);
			UUITexture texture = base.GetTexture(2);
			UUIItem texture2 = base.GetTexture(3);
			texture.SetUIActive(flag);
			texture2.SetUIActive(flag);
			return flag;
		}

		// Token: 0x060393DC RID: 234460 RVA: 0x00D929AC File Offset: 0x00D90BAC
		private void RefreshTitleTexture()
		{
			string titleIconPath = this.RewardData.GetRewardInfo().TitleIconPath;
			if (StringUtils.IsEmpty(titleIconPath))
			{
				return;
			}
			UUITexture titleTexture = base.GetTexture(2);
			titleTexture.SetUIActive(false);
			base.SetTextureByPath(titleIconPath, titleTexture, null, delegate(bool _)
			{
				titleTexture.SetUIActive(true);
			});
		}

		// Token: 0x060393DD RID: 234461 RVA: 0x00D92A14 File Offset: 0x00D90C14
		private bool RefreshContinueTextVisible()
		{
			bool flag = !StringUtils.IsEmpty(this.RewardData.GetRewardInfo().ContinueText);
			base.GetItem(7).SetUIActive(flag);
			return flag;
		}

		// Token: 0x060393DE RID: 234462 RVA: 0x00D92A48 File Offset: 0x00D90C48
		private void RefreshContinueText()
		{
			string continueText = this.RewardData.GetRewardInfo().ContinueText;
			if (StringUtils.IsEmpty(continueText))
			{
				return;
			}
			UUIText text = base.GetText(7);
			LguiUtil.Instance.SetLocalTextNew(text, continueText, Array.Empty<object>());
		}

		// Token: 0x060393DF RID: 234463 RVA: 0x00D92A88 File Offset: 0x00D90C88
		private bool RefreshItemListVisible()
		{
			bool isItemVisible = this.RewardData.GetRewardInfo().IsItemVisible;
			List<RewardItemData> itemList = this.RewardData.GetItemList();
			bool flag = isItemVisible && itemList != null && itemList != null && itemList.Count > 0;
			if (this.RewardItemList.GetActive() != flag)
			{
				this.RewardItemList.SetActive(flag);
			}
			return flag;
		}

		// Token: 0x060393E0 RID: 234464 RVA: 0x00D92AE4 File Offset: 0x00D90CE4
		private void RefreshItemList()
		{
			this.RewardItemList.Refresh(this.RewardData.GetItemList(), true);
		}

		// Token: 0x060393E1 RID: 234465 RVA: 0x00D92B00 File Offset: 0x00D90D00
		private bool RefreshProgressVisible()
		{
			ICompositeRewardInfo rewardInfo = this.RewardData.GetRewardInfo();
			IExtendRewardInfo extendRewardInfo = this.RewardData.GetExtendRewardInfo();
			bool isProgressVisible = rewardInfo.IsProgressVisible;
			List<IRewardProgress> progressQueue = extendRewardInfo.ProgressQueue;
			bool flag = isProgressVisible && progressQueue != null && progressQueue != null && progressQueue.Count > 0;
			this.RewardProgressBar.SetActive(flag);
			return flag;
		}

		// Token: 0x060393E2 RID: 234466 RVA: 0x00D92B58 File Offset: 0x00D90D58
		private void RefreshProgressBar()
		{
			ICompositeRewardInfo rewardInfo = this.RewardData.GetRewardInfo();
			List<IRewardProgress> progressQueue = this.RewardData.GetExtendRewardInfo().ProgressQueue;
			if (progressQueue == null || progressQueue.Count == 0)
			{
				return;
			}
			this.RewardProgressBar.Refresh(rewardInfo.ProgressBarTitle, progressQueue, (float)rewardInfo.ProgressBarAnimationTime);
		}

		// Token: 0x0401DF14 RID: 122644
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private RewardData<ICompositeRewardInfo> RewardData;

		// Token: 0x0401DF15 RID: 122645
		[Nullable(2)]
		private RewardItemList RewardItemList;

		// Token: 0x0401DF16 RID: 122646
		[Nullable(2)]
		private RewardProgressBar RewardProgressBar;

		// Token: 0x0200B9D2 RID: 47570
		private class EChildType
		{
			// Token: 0x040382DA RID: 230106
			public const int MaskButton = 0;

			// Token: 0x040382DB RID: 230107
			public const int TitleText = 1;

			// Token: 0x040382DC RID: 230108
			public const int TitleTexture = 2;

			// Token: 0x040382DD RID: 230109
			public const int TitleBgTexture = 3;

			// Token: 0x040382DE RID: 230110
			public const int TitlePanelItem = 4;

			// Token: 0x040382DF RID: 230111
			public const int RewardItemListItem = 5;

			// Token: 0x040382E0 RID: 230112
			public const int RewardProgressBarItem = 6;

			// Token: 0x040382E1 RID: 230113
			public const int ContinueText = 7;
		}
	}
}
