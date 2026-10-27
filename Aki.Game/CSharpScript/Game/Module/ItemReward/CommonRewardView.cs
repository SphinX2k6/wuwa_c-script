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
	// Token: 0x020057F5 RID: 22517
	public class CommonRewardView : UiViewBase, ICommonRewardComponentUiAccessor, ICommonRewardComponentChildType, ICommonRewardComponentCallbacks
	{
		// Token: 0x060393AF RID: 234415 RVA: 0x00D92180 File Offset: 0x00D90380
		[NullableContext(2)]
		public UUIItem GetItemForComponent(int childType)
		{
			return base.GetItem(childType);
		}

		// Token: 0x060393B0 RID: 234416 RVA: 0x00D92189 File Offset: 0x00D90389
		[NullableContext(2)]
		public UUIText GetTextForComponent(int childType)
		{
			return base.GetText(childType);
		}

		// Token: 0x060393B1 RID: 234417 RVA: 0x00D92192 File Offset: 0x00D90392
		[NullableContext(2)]
		public UUIGridLayout GetGridLayoutForComponent(int childType)
		{
			return base.GetGridLayout(childType);
		}

		// Token: 0x060393B2 RID: 234418 RVA: 0x00D9219B File Offset: 0x00D9039B
		[NullableContext(2)]
		public UUIButtonComponent GetButtonForComponent(int childType)
		{
			return base.GetButton(childType);
		}

		// Token: 0x17008A15 RID: 35349
		// (get) Token: 0x060393B3 RID: 234419 RVA: 0x00D921A4 File Offset: 0x00D903A4
		public int TitleText
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17008A16 RID: 35350
		// (get) Token: 0x060393B4 RID: 234420 RVA: 0x00D921A7 File Offset: 0x00D903A7
		public int TitlePanelItem
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17008A17 RID: 35351
		// (get) Token: 0x060393B5 RID: 234421 RVA: 0x00D921AA File Offset: 0x00D903AA
		public int RewardItemListItem
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x17008A18 RID: 35352
		// (get) Token: 0x060393B6 RID: 234422 RVA: 0x00D921AD File Offset: 0x00D903AD
		public int ContinueText
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x17008A19 RID: 35353
		// (get) Token: 0x060393B7 RID: 234423 RVA: 0x00D921B0 File Offset: 0x00D903B0
		public int LeftButton
		{
			get
			{
				return 5;
			}
		}

		// Token: 0x17008A1A RID: 35354
		// (get) Token: 0x060393B8 RID: 234424 RVA: 0x00D921B3 File Offset: 0x00D903B3
		public int RightButton
		{
			get
			{
				return 6;
			}
		}

		// Token: 0x17008A1B RID: 35355
		// (get) Token: 0x060393B9 RID: 234425 RVA: 0x00D921B6 File Offset: 0x00D903B6
		public int RewardItemLoopListItem
		{
			get
			{
				return 7;
			}
		}

		// Token: 0x17008A1C RID: 35356
		// (get) Token: 0x060393BA RID: 234426 RVA: 0x00D921B9 File Offset: 0x00D903B9
		public int ListContentItem
		{
			get
			{
				return 8;
			}
		}

		// Token: 0x17008A1D RID: 35357
		// (get) Token: 0x060393BB RID: 234427 RVA: 0x00D921BC File Offset: 0x00D903BC
		public int MaskButton
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x060393BC RID: 234428 RVA: 0x00D921BF File Offset: 0x00D903BF
		void ICommonRewardComponentCallbacks.OnCloseView()
		{
			this.OnCloseView();
		}

		// Token: 0x060393BD RID: 234429 RVA: 0x00D921C7 File Offset: 0x00D903C7
		void ICommonRewardComponentCallbacks.OnRefreshView()
		{
			this.OnRefreshView();
		}

		// Token: 0x060393BE RID: 234430 RVA: 0x00D921CF File Offset: 0x00D903CF
		[NullableContext(1)]
		public CommonRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060393BF RID: 234431 RVA: 0x00D921D8 File Offset: 0x00D903D8
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

		// Token: 0x060393C0 RID: 234432 RVA: 0x00D92366 File Offset: 0x00D90566
		protected override void OnAddEventListener()
		{
			CommonRewardComponent commonRewardComponent = this.CommonRewardComponent;
			if (commonRewardComponent != null)
			{
				commonRewardComponent.AddEventListener();
			}
			EventSystem.Instance.Add<IRewardDataInterface>(EEventName.OnRefreshRewardView, new Action<IRewardDataInterface>(this.OnRefreshRewardView));
		}

		// Token: 0x060393C1 RID: 234433 RVA: 0x00D92395 File Offset: 0x00D90595
		protected override void OnRemoveEventListener()
		{
			CommonRewardComponent commonRewardComponent = this.CommonRewardComponent;
			if (commonRewardComponent != null)
			{
				commonRewardComponent.RemoveEventListener();
			}
			EventSystem.Instance.Remove(EEventName.OnRefreshRewardView, new Action<IRewardDataInterface>(this.OnRefreshRewardView));
		}

		// Token: 0x060393C2 RID: 234434 RVA: 0x00D923C4 File Offset: 0x00D905C4
		[NullableContext(1)]
		private void OnRefreshRewardView(IRewardDataInterface rewardData)
		{
			CommonRewardComponent commonRewardComponent = this.CommonRewardComponent;
			if (commonRewardComponent == null)
			{
				return;
			}
			commonRewardComponent.OnRefreshRewardView(rewardData);
		}

		// Token: 0x060393C3 RID: 234435 RVA: 0x00D923D8 File Offset: 0x00D905D8
		protected override UniTask OnCreateAsync()
		{
			CommonRewardView.<OnCreateAsync>d__31 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<CommonRewardView.<OnCreateAsync>d__31>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060393C4 RID: 234436 RVA: 0x00D9241C File Offset: 0x00D9061C
		protected override UniTask OnBeforeStartAsync()
		{
			CommonRewardView.<OnBeforeStartAsync>d__32 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CommonRewardView.<OnBeforeStartAsync>d__32>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060393C5 RID: 234437 RVA: 0x00D92460 File Offset: 0x00D90660
		protected override void OnStart()
		{
			RewardData<ICommonRewardInfo> rewardData = this.OpenParam as RewardData<ICommonRewardInfo>;
			CommonRewardComponent commonRewardComponent = this.CommonRewardComponent;
			if (commonRewardComponent != null)
			{
				commonRewardComponent.Refresh(rewardData);
			}
			string audioId = rewardData.GetRewardInfo().AudioId;
			ItemRewardController.Instance.PlayAudio(audioId, null);
		}

		// Token: 0x060393C6 RID: 234438 RVA: 0x00D924A4 File Offset: 0x00D906A4
		protected override void OnAfterPlayStartSequence()
		{
			this.UiViewSequence.PlaySequence("Switch", false, null);
		}

		// Token: 0x060393C7 RID: 234439 RVA: 0x00D924CB File Offset: 0x00D906CB
		protected override void OnAfterShow()
		{
			EventSystem.Instance.Emit(EEventName.OnShowRewardView);
		}

		// Token: 0x060393C8 RID: 234440 RVA: 0x00D924DD File Offset: 0x00D906DD
		protected override void OnBeforePlayCloseSequence()
		{
			this.UiViewSequence.StopSequenceByKey("Switch", false, false);
		}

		// Token: 0x060393C9 RID: 234441 RVA: 0x00D924F4 File Offset: 0x00D906F4
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

		// Token: 0x060393CA RID: 234442 RVA: 0x00D92544 File Offset: 0x00D90744
		private void OnCloseView()
		{
			UiInteractLogReport.ReportSpaceKeyInteract(EUiInteractSpaceKeyType.Reward);
			base.CloseMe(null);
		}

		// Token: 0x060393CB RID: 234443 RVA: 0x00D92554 File Offset: 0x00D90754
		private void OnRefreshView()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlaySequencePurely("Start01", true, false);
		}

		// Token: 0x060393CC RID: 234444 RVA: 0x00D9256D File Offset: 0x00D9076D
		private void OnClickedMaskButton()
		{
			CommonRewardComponent commonRewardComponent = this.CommonRewardComponent;
			if (commonRewardComponent == null)
			{
				return;
			}
			commonRewardComponent.OnClickMaskButton();
		}

		// Token: 0x0401DF13 RID: 122643
		[Nullable(2)]
		private CommonRewardComponent CommonRewardComponent;

		// Token: 0x0200B9CF RID: 47567
		private class EChildType
		{
			// Token: 0x040382C9 RID: 230089
			public const int MaskButton = 0;

			// Token: 0x040382CA RID: 230090
			public const int TitleText = 1;

			// Token: 0x040382CB RID: 230091
			public const int TitlePanelItem = 2;

			// Token: 0x040382CC RID: 230092
			public const int RewardItemListItem = 3;

			// Token: 0x040382CD RID: 230093
			public const int ContinueText = 4;

			// Token: 0x040382CE RID: 230094
			public const int LeftButton = 5;

			// Token: 0x040382CF RID: 230095
			public const int RightButton = 6;

			// Token: 0x040382D0 RID: 230096
			public const int RewardItemLoopListItem = 7;

			// Token: 0x040382D1 RID: 230097
			public const int ListContentItem = 8;
		}
	}
}
