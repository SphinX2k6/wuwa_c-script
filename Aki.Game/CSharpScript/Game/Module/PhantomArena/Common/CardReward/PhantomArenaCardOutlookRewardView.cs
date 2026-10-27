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
	// Token: 0x020051C2 RID: 20930
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaCardOutlookRewardView : UiViewBase
	{
		// Token: 0x06035978 RID: 219512 RVA: 0x00CB2C0A File Offset: 0x00CB0E0A
		public PhantomArenaCardOutlookRewardView(UiViewInfo uiViewInfo) : base(uiViewInfo)
		{
		}

		// Token: 0x06035979 RID: 219513 RVA: 0x00CB2C14 File Offset: 0x00CB0E14
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

		// Token: 0x0603597A RID: 219514 RVA: 0x00CB2CC0 File Offset: 0x00CB0EC0
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaCardOutlookRewardView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaCardOutlookRewardView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603597B RID: 219515 RVA: 0x00CB2D04 File Offset: 0x00CB0F04
		protected override void OnStart()
		{
			base.GetItem(3).SetUIActive(true);
			base.GetItem(4).SetUIActive(false);
			this.CardId = PhantomArenaModel.Instance.CardOutlookUnlockQueue[0];
			PhantomArenaModel.Instance.CardOutlookUnlockQueue.RemoveAt(0);
			this.RefreshByCardId(this.CardId);
		}

		// Token: 0x0603597C RID: 219516 RVA: 0x00CB2D5D File Offset: 0x00CB0F5D
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnSeqEvent));
		}

		// Token: 0x0603597D RID: 219517 RVA: 0x00CB2D7B File Offset: 0x00CB0F7B
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnSeqEvent));
		}

		// Token: 0x0603597E RID: 219518 RVA: 0x00CB2D99 File Offset: 0x00CB0F99
		public void RefreshByCardId(int cardId)
		{
			this.CardItem.Refresh(cardId);
		}

		// Token: 0x0603597F RID: 219519 RVA: 0x00CB2DA8 File Offset: 0x00CB0FA8
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

		// Token: 0x06035980 RID: 219520 RVA: 0x00CB2DDC File Offset: 0x00CB0FDC
		public UniTask ShowNextAsync()
		{
			PhantomArenaCardOutlookRewardView.<ShowNextAsync>d__12 <ShowNextAsync>d__;
			<ShowNextAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowNextAsync>d__.<>4__this = this;
			<ShowNextAsync>d__.<>1__state = -1;
			<ShowNextAsync>d__.<>t__builder.Start<PhantomArenaCardOutlookRewardView.<ShowNextAsync>d__12>(ref <ShowNextAsync>d__);
			return <ShowNextAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035981 RID: 219521 RVA: 0x00CB2E1F File Offset: 0x00CB101F
		private void OnCloseButtonClick()
		{
			if (PhantomArenaModel.Instance.CardOutlookUnlockQueue.Count > 0)
			{
				this.ShowNext();
				return;
			}
			base.CloseMe(null);
		}

		// Token: 0x06035982 RID: 219522 RVA: 0x00CB2E41 File Offset: 0x00CB1041
		protected override void OnAfterDestroy()
		{
			PhantomArenaController.Instance.PostUnlockView();
		}

		// Token: 0x06035983 RID: 219523 RVA: 0x00CB2E4E File Offset: 0x00CB104E
		private void OnSeqEvent(string seqName)
		{
			if (seqName == "Change" && this.IsWaitingChange)
			{
				this.RefreshByCardId(this.CardId);
			}
		}

		// Token: 0x0401C720 RID: 116512
		private UnlockViewCardItem CardItem;

		// Token: 0x0401C721 RID: 116513
		protected int CardId;

		// Token: 0x0401C722 RID: 116514
		protected bool IsWaitingChange;

		// Token: 0x0200B354 RID: 45908
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x040365BD RID: 222653
			public const int TitleText = 0;

			// Token: 0x040365BE RID: 222654
			public const int CloseButton = 1;

			// Token: 0x040365BF RID: 222655
			public const int CardItem = 2;

			// Token: 0x040365C0 RID: 222656
			public const int PanelCard = 3;

			// Token: 0x040365C1 RID: 222657
			public const int PanelCards = 4;
		}
	}
}
