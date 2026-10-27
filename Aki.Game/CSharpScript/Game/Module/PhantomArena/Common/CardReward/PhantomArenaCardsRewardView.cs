using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardReward
{
	// Token: 0x020051C3 RID: 20931
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaCardsRewardView : UiViewBase, IUiViewResource
	{
		// Token: 0x06035985 RID: 219525 RVA: 0x00CB2EB7 File Offset: 0x00CB10B7
		public PhantomArenaCardsRewardView(UiViewInfo uiViewInfo) : base(uiViewInfo)
		{
		}

		// Token: 0x06035986 RID: 219526 RVA: 0x00CB2ECC File Offset: 0x00CB10CC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action(this.OnCloseButtonClick))
			};
		}

		// Token: 0x06035987 RID: 219527 RVA: 0x00CB2F75 File Offset: 0x00CB1175
		private RewardGridCardItem CreateCardItem()
		{
			return new RewardGridCardItem
			{
				IsNewPhantomArenaActivity = this.IsNewPhantomArenaActivity
			};
		}

		// Token: 0x06035988 RID: 219528 RVA: 0x00CB2F88 File Offset: 0x00CB1188
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaCardsRewardView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaCardsRewardView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035989 RID: 219529 RVA: 0x00CB2FCC File Offset: 0x00CB11CC
		protected UniTask RefreshCardList()
		{
			PhantomArenaCardsRewardView.<RefreshCardList>d__11 <RefreshCardList>d__;
			<RefreshCardList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshCardList>d__.<>4__this = this;
			<RefreshCardList>d__.<>1__state = -1;
			<RefreshCardList>d__.<>t__builder.Start<PhantomArenaCardsRewardView.<RefreshCardList>d__11>(ref <RefreshCardList>d__);
			return <RefreshCardList>d__.<>t__builder.Task;
		}

		// Token: 0x0603598A RID: 219530 RVA: 0x00CB300F File Offset: 0x00CB120F
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnSeqEvent));
		}

		// Token: 0x0603598B RID: 219531 RVA: 0x00CB302D File Offset: 0x00CB122D
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnSeqEvent));
		}

		// Token: 0x0603598C RID: 219532 RVA: 0x00CB304B File Offset: 0x00CB124B
		private void OnSeqEvent(string seqName)
		{
			if (seqName == "CardChange")
			{
				this.RefreshCardList().Forget();
			}
		}

		// Token: 0x0603598D RID: 219533 RVA: 0x00CB3065 File Offset: 0x00CB1265
		private void OnCloseButtonClick()
		{
			if (this.CardIdList.Count > 0)
			{
				base.PlaySequence("Switch", null, true);
				return;
			}
			base.CloseMe(delegate(bool _)
			{
				this.CallbackOnClose();
			});
		}

		// Token: 0x0603598E RID: 219534 RVA: 0x00CB3095 File Offset: 0x00CB1295
		public string GetExtraResourceId(object param = null)
		{
			BattleResultCardsViewOpenParam battleResultCardsViewOpenParam = param as BattleResultCardsViewOpenParam;
			if (battleResultCardsViewOpenParam != null && battleResultCardsViewOpenParam.IsNewPhantomArenaActivity)
			{
				return "UiView_CardUnlockNew";
			}
			return "UiView_CardUnlock";
		}

		// Token: 0x0401C723 RID: 116515
		private const int MAX_CARD_NUM = 5;

		// Token: 0x0401C724 RID: 116516
		private RewardGridCardItem CardItem;

		// Token: 0x0401C725 RID: 116517
		private GenericLayout<RewardGridCardItem, CollectGridCardData> CardLayout;

		// Token: 0x0401C726 RID: 116518
		private Action CallbackOnClose;

		// Token: 0x0401C727 RID: 116519
		private List<int> CardIdList = new List<int>();

		// Token: 0x0401C728 RID: 116520
		private bool IsNewPhantomArenaActivity;

		// Token: 0x0200B358 RID: 45912
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x040365CE RID: 222670
			public const int TitleText = 0;

			// Token: 0x040365CF RID: 222671
			public const int CloseButton = 1;

			// Token: 0x040365D0 RID: 222672
			public const int CardItem = 2;

			// Token: 0x040365D1 RID: 222673
			public const int PanelCard = 3;

			// Token: 0x040365D2 RID: 222674
			public const int PanelCards = 4;
		}
	}
}
