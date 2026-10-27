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
	// Token: 0x020057F8 RID: 22520
	public class PayRewardView : UiViewBase, ICommonRewardComponentUiAccessor, ICommonRewardComponentChildType, ICommonRewardComponentCallbacks
	{
		// Token: 0x0603940B RID: 234507 RVA: 0x00D939B8 File Offset: 0x00D91BB8
		[NullableContext(2)]
		public UUIItem GetItemForComponent(int childType)
		{
			return base.GetItem(childType);
		}

		// Token: 0x0603940C RID: 234508 RVA: 0x00D939C1 File Offset: 0x00D91BC1
		[NullableContext(2)]
		public UUIText GetTextForComponent(int childType)
		{
			return base.GetText(childType);
		}

		// Token: 0x0603940D RID: 234509 RVA: 0x00D939CA File Offset: 0x00D91BCA
		[NullableContext(2)]
		public UUIGridLayout GetGridLayoutForComponent(int childType)
		{
			return base.GetGridLayout(childType);
		}

		// Token: 0x0603940E RID: 234510 RVA: 0x00D939D3 File Offset: 0x00D91BD3
		[NullableContext(2)]
		public UUIButtonComponent GetButtonForComponent(int childType)
		{
			return base.GetButton(childType);
		}

		// Token: 0x17008A1E RID: 35358
		// (get) Token: 0x0603940F RID: 234511 RVA: 0x00D939DC File Offset: 0x00D91BDC
		public int TitleText
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17008A1F RID: 35359
		// (get) Token: 0x06039410 RID: 234512 RVA: 0x00D939DF File Offset: 0x00D91BDF
		public int TitlePanelItem
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17008A20 RID: 35360
		// (get) Token: 0x06039411 RID: 234513 RVA: 0x00D939E2 File Offset: 0x00D91BE2
		public int RewardItemListItem
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x17008A21 RID: 35361
		// (get) Token: 0x06039412 RID: 234514 RVA: 0x00D939E5 File Offset: 0x00D91BE5
		public int ContinueText
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x17008A22 RID: 35362
		// (get) Token: 0x06039413 RID: 234515 RVA: 0x00D939E8 File Offset: 0x00D91BE8
		public int LeftButton
		{
			get
			{
				return 5;
			}
		}

		// Token: 0x17008A23 RID: 35363
		// (get) Token: 0x06039414 RID: 234516 RVA: 0x00D939EB File Offset: 0x00D91BEB
		public int RightButton
		{
			get
			{
				return 6;
			}
		}

		// Token: 0x17008A24 RID: 35364
		// (get) Token: 0x06039415 RID: 234517 RVA: 0x00D939EE File Offset: 0x00D91BEE
		public int RewardItemLoopListItem
		{
			get
			{
				return 7;
			}
		}

		// Token: 0x17008A25 RID: 35365
		// (get) Token: 0x06039416 RID: 234518 RVA: 0x00D939F1 File Offset: 0x00D91BF1
		public int ListContentItem
		{
			get
			{
				return 8;
			}
		}

		// Token: 0x17008A26 RID: 35366
		// (get) Token: 0x06039417 RID: 234519 RVA: 0x00D939F4 File Offset: 0x00D91BF4
		public int MaskButton
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06039418 RID: 234520 RVA: 0x00D939F7 File Offset: 0x00D91BF7
		void ICommonRewardComponentCallbacks.OnCloseView()
		{
			this.OnCloseView();
		}

		// Token: 0x06039419 RID: 234521 RVA: 0x00D939FF File Offset: 0x00D91BFF
		void ICommonRewardComponentCallbacks.OnRefreshView()
		{
			this.OnRefreshView();
		}

		// Token: 0x0603941A RID: 234522 RVA: 0x00D93A07 File Offset: 0x00D91C07
		[NullableContext(1)]
		public PayRewardView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603941B RID: 234523 RVA: 0x00D93A10 File Offset: 0x00D91C10
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIGridLayout));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedMaskButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603941C RID: 234524 RVA: 0x00D93B9E File Offset: 0x00D91D9E
		protected override void OnAddEventListener()
		{
			CommonRewardComponent commonRewardComponent = this.CommonRewardComponent;
			if (commonRewardComponent == null)
			{
				return;
			}
			commonRewardComponent.AddEventListener();
		}

		// Token: 0x0603941D RID: 234525 RVA: 0x00D93BB0 File Offset: 0x00D91DB0
		protected override void OnRemoveEventListener()
		{
			CommonRewardComponent commonRewardComponent = this.CommonRewardComponent;
			if (commonRewardComponent == null)
			{
				return;
			}
			commonRewardComponent.RemoveEventListener();
		}

		// Token: 0x0603941E RID: 234526 RVA: 0x00D93BC4 File Offset: 0x00D91DC4
		protected override UniTask OnCreateAsync()
		{
			PayRewardView.<OnCreateAsync>d__30 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<PayRewardView.<OnCreateAsync>d__30>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603941F RID: 234527 RVA: 0x00D93C08 File Offset: 0x00D91E08
		protected override UniTask OnBeforeStartAsync()
		{
			PayRewardView.<OnBeforeStartAsync>d__31 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PayRewardView.<OnBeforeStartAsync>d__31>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039420 RID: 234528 RVA: 0x00D93C4C File Offset: 0x00D91E4C
		protected override void OnStart()
		{
			RewardData<ICommonRewardInfo> rewardData = this.PickLastRewardData();
			if (rewardData == null)
			{
				return;
			}
			this.RefreshDisplay(rewardData);
		}

		// Token: 0x06039421 RID: 234529 RVA: 0x00D93C6C File Offset: 0x00D91E6C
		[NullableContext(1)]
		private void RefreshDisplay(RewardData<ICommonRewardInfo> rewardData)
		{
			CommonRewardComponent commonRewardComponent = this.CommonRewardComponent;
			if (commonRewardComponent != null)
			{
				commonRewardComponent.OnRefreshRewardView(rewardData);
			}
			string audioId = rewardData.GetRewardInfo().AudioId;
			ItemRewardController.Instance.PlayAudio(audioId, null);
		}

		// Token: 0x06039422 RID: 234530 RVA: 0x00D93CA4 File Offset: 0x00D91EA4
		protected override void OnAfterPlayStartSequence()
		{
			this.UiViewSequence.PlaySequence("Switch", false, null);
		}

		// Token: 0x06039423 RID: 234531 RVA: 0x00D93CCB File Offset: 0x00D91ECB
		protected override void OnAfterShow()
		{
			EventSystem.Instance.Emit(EEventName.OnShowRewardView);
		}

		// Token: 0x06039424 RID: 234532 RVA: 0x00D93CDD File Offset: 0x00D91EDD
		protected override void OnBeforePlayCloseSequence()
		{
			this.UiViewSequence.StopSequenceByKey("Switch", false, false);
		}

		// Token: 0x06039425 RID: 234533 RVA: 0x00D93CF4 File Offset: 0x00D91EF4
		protected override void OnBeforeDestroy()
		{
			CommonRewardComponent commonRewardComponent = this.CommonRewardComponent;
			if (commonRewardComponent != null)
			{
				commonRewardComponent.HandleCloseCallback();
			}
			CommonRewardComponent commonRewardComponent2 = this.CommonRewardComponent;
			if (commonRewardComponent2 != null)
			{
				commonRewardComponent2.Destroy();
			}
			this.CommonRewardComponent = null;
			EventSystem.Instance.Emit(EEventName.OnCloseRewardView);
			ItemRewardModel.Instance.ClearCurrentRewardData();
		}

		// Token: 0x06039426 RID: 234534 RVA: 0x00D93D44 File Offset: 0x00D91F44
		private void OnCloseView()
		{
			RewardData<ICommonRewardInfo> rewardData = this.PickLastRewardData();
			if (rewardData == null)
			{
				UiInteractLogReport.ReportSpaceKeyInteract(EUiInteractSpaceKeyType.Reward);
				base.CloseMe(null);
				return;
			}
			this.RefreshDisplay(rewardData);
		}

		// Token: 0x06039427 RID: 234535 RVA: 0x00D93D71 File Offset: 0x00D91F71
		private void OnRefreshView()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlaySequencePurely("Start01", true, false);
		}

		// Token: 0x06039428 RID: 234536 RVA: 0x00D93D8A File Offset: 0x00D91F8A
		private void OnClickedMaskButton()
		{
			CommonRewardComponent commonRewardComponent = this.CommonRewardComponent;
			if (commonRewardComponent == null)
			{
				return;
			}
			commonRewardComponent.OnClickMaskButton();
		}

		// Token: 0x06039429 RID: 234537 RVA: 0x00D93D9C File Offset: 0x00D91F9C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private RewardData<ICommonRewardInfo> PickLastRewardData()
		{
			List<RewardData<ICommonRewardInfo>> cacheCommonRewardDataList = ItemRewardModel.Instance.CacheCommonRewardDataList;
			if (cacheCommonRewardDataList.Count > 0)
			{
				RewardData<ICommonRewardInfo> rewardData = cacheCommonRewardDataList[0];
				cacheCommonRewardDataList.RemoveAt(0);
				if (rewardData != null)
				{
					return rewardData;
				}
			}
			return null;
		}

		// Token: 0x0401DF2D RID: 122669
		[Nullable(2)]
		private CommonRewardComponent CommonRewardComponent;

		// Token: 0x0200B9E8 RID: 47592
		private class EChildType
		{
			// Token: 0x04038349 RID: 230217
			public const int MaskButton = 0;

			// Token: 0x0403834A RID: 230218
			public const int TitleText = 1;

			// Token: 0x0403834B RID: 230219
			public const int TitlePanelItem = 2;

			// Token: 0x0403834C RID: 230220
			public const int RewardItemListItem = 3;

			// Token: 0x0403834D RID: 230221
			public const int ContinueText = 4;

			// Token: 0x0403834E RID: 230222
			public const int LeftButton = 5;

			// Token: 0x0403834F RID: 230223
			public const int RightButton = 6;

			// Token: 0x04038350 RID: 230224
			public const int RewardItemLoopListItem = 7;

			// Token: 0x04038351 RID: 230225
			public const int ListContentItem = 8;
		}
	}
}
