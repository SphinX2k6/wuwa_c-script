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
	// Token: 0x020047CD RID: 18381
	public class CompositeRewardView : UiTickViewBase
	{
		// Token: 0x0602E2E1 RID: 189153 RVA: 0x00CE13C7 File Offset: 0x00CDF5C7
		[NullableContext(1)]
		public CompositeRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602E2E2 RID: 189154 RVA: 0x00CE13D0 File Offset: 0x00CDF5D0
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

		// Token: 0x0602E2E3 RID: 189155 RVA: 0x00CE153C File Offset: 0x00CDF73C
		private void OnClickedMaskButton()
		{
			UiManager.Instance.CloseView(EUiViewName.CompositeRewardView, null);
		}

		// Token: 0x0602E2E4 RID: 189156 RVA: 0x00CE154E File Offset: 0x00CDF74E
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<IReadOnlyList<RewardItemData>>(EEventName.OnRefreshRewardViewItemList, new Action<IReadOnlyList<RewardItemData>>(this.OnRefreshRewardItemList));
			EventSystem.Instance.Add(EEventName.OnRefreshRewardProgressBar, new Action(this.OnRefreshRewardProgressBar));
		}

		// Token: 0x0602E2E5 RID: 189157 RVA: 0x00CE1588 File Offset: 0x00CDF788
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnRefreshRewardViewItemList, new Action<IReadOnlyList<RewardItemData>>(this.OnRefreshRewardItemList));
			EventSystem.Instance.Remove(EEventName.OnRefreshRewardProgressBar, new Action(this.OnRefreshRewardProgressBar));
		}

		// Token: 0x0602E2E6 RID: 189158 RVA: 0x00CE15C2 File Offset: 0x00CDF7C2
		[NullableContext(1)]
		private void OnRefreshRewardItemList(IReadOnlyList<RewardItemData> itemList)
		{
			if (this.RefreshItemListVisible())
			{
				this.RefreshItemList();
			}
		}

		// Token: 0x0602E2E7 RID: 189159 RVA: 0x00CE15D2 File Offset: 0x00CDF7D2
		private void OnRefreshRewardProgressBar()
		{
			if (this.RefreshProgressVisible())
			{
				this.RefreshProgressBar();
			}
		}

		// Token: 0x0602E2E8 RID: 189160 RVA: 0x00CE15E4 File Offset: 0x00CDF7E4
		protected override UniTask OnBeforeStartAsync()
		{
			CompositeRewardView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CompositeRewardView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E2E9 RID: 189161 RVA: 0x00CE1628 File Offset: 0x00CDF828
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

		// Token: 0x0602E2EA RID: 189162 RVA: 0x00CE16AC File Offset: 0x00CDF8AC
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

		// Token: 0x0602E2EB RID: 189163 RVA: 0x00CE1711 File Offset: 0x00CDF911
		protected override void OnBeforeDestroy()
		{
			this.RewardProgressBar = null;
			this.RewardData = null;
			ItemRewardModel.Instance.ClearCurrentRewardData();
		}

		// Token: 0x0602E2EC RID: 189164 RVA: 0x00CE172B File Offset: 0x00CDF92B
		protected override void OnTick(float delta)
		{
			this.RewardProgressBar.Tick(delta);
		}

		// Token: 0x0602E2ED RID: 189165 RVA: 0x00CE173C File Offset: 0x00CDF93C
		private bool RefreshTitleVisible()
		{
			bool flag = !StringUtils.IsEmpty(this.RewardData.GetRewardInfo().Title);
			base.GetItem(4).SetUIActive(flag);
			return flag;
		}

		// Token: 0x0602E2EE RID: 189166 RVA: 0x00CE1770 File Offset: 0x00CDF970
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

		// Token: 0x0602E2EF RID: 189167 RVA: 0x00CE17B0 File Offset: 0x00CDF9B0
		private bool RefreshTitleTextureVisible()
		{
			bool flag = !StringUtils.IsEmpty(this.RewardData.GetRewardInfo().TitleIconPath);
			UUITexture texture = base.GetTexture(2);
			UUIItem texture2 = base.GetTexture(3);
			texture.SetUIActive(flag);
			texture2.SetUIActive(flag);
			return flag;
		}

		// Token: 0x0602E2F0 RID: 189168 RVA: 0x00CE17F4 File Offset: 0x00CDF9F4
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

		// Token: 0x0602E2F1 RID: 189169 RVA: 0x00CE185C File Offset: 0x00CDFA5C
		private bool RefreshContinueTextVisible()
		{
			bool flag = !StringUtils.IsEmpty(this.RewardData.GetRewardInfo().ContinueText);
			base.GetItem(7).SetUIActive(flag);
			return flag;
		}

		// Token: 0x0602E2F2 RID: 189170 RVA: 0x00CE1890 File Offset: 0x00CDFA90
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

		// Token: 0x0602E2F3 RID: 189171 RVA: 0x00CE18D0 File Offset: 0x00CDFAD0
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

		// Token: 0x0602E2F4 RID: 189172 RVA: 0x00CE192C File Offset: 0x00CDFB2C
		private void RefreshItemList()
		{
			this.RewardItemList.Refresh(this.RewardData.GetItemList(), true);
		}

		// Token: 0x0602E2F5 RID: 189173 RVA: 0x00CE1948 File Offset: 0x00CDFB48
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

		// Token: 0x0602E2F6 RID: 189174 RVA: 0x00CE19A0 File Offset: 0x00CDFBA0
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

		// Token: 0x040189AB RID: 100779
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private RewardData<ICompositeRewardInfo> RewardData;

		// Token: 0x040189AC RID: 100780
		[Nullable(2)]
		private RewardItemList RewardItemList;

		// Token: 0x040189AD RID: 100781
		[Nullable(2)]
		private RewardProgressBar RewardProgressBar;

		// Token: 0x0200A3E8 RID: 41960
		private class EChildType
		{
			// Token: 0x04032CC7 RID: 208071
			public const int MaskButton = 0;

			// Token: 0x04032CC8 RID: 208072
			public const int TitleText = 1;

			// Token: 0x04032CC9 RID: 208073
			public const int TitleTexture = 2;

			// Token: 0x04032CCA RID: 208074
			public const int TitleBgTexture = 3;

			// Token: 0x04032CCB RID: 208075
			public const int TitlePanelItem = 4;

			// Token: 0x04032CCC RID: 208076
			public const int RewardItemListItem = 5;

			// Token: 0x04032CCD RID: 208077
			public const int RewardProgressBarItem = 6;

			// Token: 0x04032CCE RID: 208078
			public const int ContinueText = 7;
		}
	}
}
