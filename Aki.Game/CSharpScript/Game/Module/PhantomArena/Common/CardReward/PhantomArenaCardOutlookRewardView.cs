using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardReward
{
	// Token: 0x02004192 RID: 16786
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaCardOutlookRewardView : UiViewBase
	{
		// Token: 0x0602A873 RID: 174195 RVA: 0x00C00246 File Offset: 0x00BFE446
		public PhantomArenaCardOutlookRewardView(UiViewInfo uiViewInfo) : base(uiViewInfo)
		{
		}

		// Token: 0x0602A874 RID: 174196 RVA: 0x00C00250 File Offset: 0x00BFE450
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action(this.OnCloseButtonClick))
			};
		}

		// Token: 0x0602A875 RID: 174197 RVA: 0x00C002FC File Offset: 0x00BFE4FC
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaCardOutlookRewardView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaCardOutlookRewardView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A876 RID: 174198 RVA: 0x00C00340 File Offset: 0x00BFE540
		protected override void OnStart()
		{
			base.GetItem(3).SetUIActive(true);
			base.GetItem(4).SetUIActive(false);
			this.CardId = PhantomArenaModel.Instance.CardOutlookUnlockQueue[0];
			PhantomArenaModel.Instance.CardOutlookUnlockQueue.RemoveAt(0);
			this.RefreshByCardId(this.CardId);
		}

		// Token: 0x0602A877 RID: 174199 RVA: 0x00C00399 File Offset: 0x00BFE599
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnSeqEvent));
		}

		// Token: 0x0602A878 RID: 174200 RVA: 0x00C003B7 File Offset: 0x00BFE5B7
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnSeqEvent));
		}

		// Token: 0x0602A879 RID: 174201 RVA: 0x00C003D5 File Offset: 0x00BFE5D5
		public void RefreshByCardId(int cardId)
		{
			this.CardItem.Refresh(cardId);
		}

		// Token: 0x0602A87A RID: 174202 RVA: 0x00C003E4 File Offset: 0x00BFE5E4
		public void ShowNext()
		{
			UiAsyncTask task = new UiAsyncTask("PhantomArenaCardOutlookRewardView", delegate()
			{
				PhantomArenaCardOutlookRewardView.<<ShowNext>b__11_0>d <<ShowNext>b__11_0>d;
				<<ShowNext>b__11_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<ShowNext>b__11_0>d.<>4__this = this;
				<<ShowNext>b__11_0>d.<>1__state = -1;
				<<ShowNext>b__11_0>d.<>t__builder.Start<PhantomArenaCardOutlookRewardView.<<ShowNext>b__11_0>d>(ref <<ShowNext>b__11_0>d);
				return <<ShowNext>b__11_0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task).Forget();
		}

		// Token: 0x0602A87B RID: 174203 RVA: 0x00C00418 File Offset: 0x00BFE618
		public UniTask ShowNextAsync()
		{
			PhantomArenaCardOutlookRewardView.<ShowNextAsync>d__12 <ShowNextAsync>d__;
			<ShowNextAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowNextAsync>d__.<>4__this = this;
			<ShowNextAsync>d__.<>1__state = -1;
			<ShowNextAsync>d__.<>t__builder.Start<PhantomArenaCardOutlookRewardView.<ShowNextAsync>d__12>(ref <ShowNextAsync>d__);
			return <ShowNextAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A87C RID: 174204 RVA: 0x00C0045B File Offset: 0x00BFE65B
		private void OnCloseButtonClick()
		{
			if (PhantomArenaModel.Instance.CardOutlookUnlockQueue.Count > 0)
			{
				this.ShowNext();
				return;
			}
			base.CloseMe(null);
		}

		// Token: 0x0602A87D RID: 174205 RVA: 0x00C0047D File Offset: 0x00BFE67D
		protected override void OnAfterDestroy()
		{
			PhantomArenaController.Instance.PostUnlockView();
		}

		// Token: 0x0602A87E RID: 174206 RVA: 0x00C0048A File Offset: 0x00BFE68A
		private void OnSeqEvent(string seqName)
		{
			if (seqName == "Change" && this.IsWaitingChange)
			{
				this.RefreshByCardId(this.CardId);
			}
		}

		// Token: 0x04017155 RID: 94549
		private UnlockViewCardItem CardItem;

		// Token: 0x04017156 RID: 94550
		protected int CardId;

		// Token: 0x04017157 RID: 94551
		protected bool IsWaitingChange;

		// Token: 0x02009D8C RID: 40332
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04031010 RID: 200720
			public const int TitleText = 0;

			// Token: 0x04031011 RID: 200721
			public const int CloseButton = 1;

			// Token: 0x04031012 RID: 200722
			public const int CardItem = 2;

			// Token: 0x04031013 RID: 200723
			public const int PanelCard = 3;

			// Token: 0x04031014 RID: 200724
			public const int PanelCards = 4;
		}
	}
}
