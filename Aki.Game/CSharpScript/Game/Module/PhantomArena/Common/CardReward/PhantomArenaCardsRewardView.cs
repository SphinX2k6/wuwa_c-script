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
	// Token: 0x02004193 RID: 16787
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaCardsRewardView : UiViewBase, IUiViewResource
	{
		// Token: 0x0602A880 RID: 174208 RVA: 0x00C004F3 File Offset: 0x00BFE6F3
		public PhantomArenaCardsRewardView(UiViewInfo uiViewInfo) : base(uiViewInfo)
		{
		}

		// Token: 0x0602A881 RID: 174209 RVA: 0x00C00508 File Offset: 0x00BFE708
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

		// Token: 0x0602A882 RID: 174210 RVA: 0x00C005B1 File Offset: 0x00BFE7B1
		private RewardGridCardItem CreateCardItem()
		{
			return new RewardGridCardItem
			{
				IsNewPhantomArenaActivity = this.IsNewPhantomArenaActivity
			};
		}

		// Token: 0x0602A883 RID: 174211 RVA: 0x00C005C4 File Offset: 0x00BFE7C4
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaCardsRewardView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaCardsRewardView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A884 RID: 174212 RVA: 0x00C00608 File Offset: 0x00BFE808
		protected UniTask RefreshCardList()
		{
			PhantomArenaCardsRewardView.<RefreshCardList>d__11 <RefreshCardList>d__;
			<RefreshCardList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshCardList>d__.<>4__this = this;
			<RefreshCardList>d__.<>1__state = -1;
			<RefreshCardList>d__.<>t__builder.Start<PhantomArenaCardsRewardView.<RefreshCardList>d__11>(ref <RefreshCardList>d__);
			return <RefreshCardList>d__.<>t__builder.Task;
		}

		// Token: 0x0602A885 RID: 174213 RVA: 0x00C0064B File Offset: 0x00BFE84B
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnSeqEvent));
		}

		// Token: 0x0602A886 RID: 174214 RVA: 0x00C00669 File Offset: 0x00BFE869
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnSeqEvent));
		}

		// Token: 0x0602A887 RID: 174215 RVA: 0x00C00687 File Offset: 0x00BFE887
		private void OnSeqEvent(string seqName)
		{
			if (seqName == "CardChange")
			{
				this.RefreshCardList().Forget();
			}
		}

		// Token: 0x0602A888 RID: 174216 RVA: 0x00C006A1 File Offset: 0x00BFE8A1
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

		// Token: 0x0602A889 RID: 174217 RVA: 0x00C006D1 File Offset: 0x00BFE8D1
		public string GetExtraResourceId(object param = null)
		{
			BattleResultCardsViewOpenParam battleResultCardsViewOpenParam = param as BattleResultCardsViewOpenParam;
			if (battleResultCardsViewOpenParam != null && battleResultCardsViewOpenParam.IsNewPhantomArenaActivity)
			{
				return "UiView_CardUnlockNew";
			}
			return "UiView_CardUnlock";
		}

		// Token: 0x04017158 RID: 94552
		private const int MAX_CARD_NUM = 5;

		// Token: 0x04017159 RID: 94553
		private RewardGridCardItem CardItem;

		// Token: 0x0401715A RID: 94554
		private GenericLayout<RewardGridCardItem, CollectGridCardData> CardLayout;

		// Token: 0x0401715B RID: 94555
		private Action CallbackOnClose;

		// Token: 0x0401715C RID: 94556
		private List<int> CardIdList = new List<int>();

		// Token: 0x0401715D RID: 94557
		private bool IsNewPhantomArenaActivity;

		// Token: 0x02009D90 RID: 40336
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04031021 RID: 200737
			public const int TitleText = 0;

			// Token: 0x04031022 RID: 200738
			public const int CloseButton = 1;

			// Token: 0x04031023 RID: 200739
			public const int CardItem = 2;

			// Token: 0x04031024 RID: 200740
			public const int PanelCard = 3;

			// Token: 0x04031025 RID: 200741
			public const int PanelCards = 4;
		}
	}
}
