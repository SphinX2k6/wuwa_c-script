using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena.Battle.Card;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.Process;
using CSharpScript.Game.Module.PhantomArena.Battle.View.Panel;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View
{
	// Token: 0x0200421F RID: 16927
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaChangeCardView : UiViewBase, IUiViewResource
	{
		// Token: 0x0602AC7B RID: 175227 RVA: 0x00C0B5BA File Offset: 0x00C097BA
		public PhantomArenaChangeCardView(UiViewInfo uiViewInfo) : base(uiViewInfo)
		{
		}

		// Token: 0x0602AC7C RID: 175228 RVA: 0x00C0B5D8 File Offset: 0x00C097D8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUILayoutBase)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(2, new Action(this.ConfirmClick)),
				new ValueTuple<int, Delegate>(3, new Action(this.EmptyClick))
			};
		}

		// Token: 0x0602AC7D RID: 175229 RVA: 0x00C0B69C File Offset: 0x00C0989C
		private UniTask InitTipsItem()
		{
			PhantomArenaChangeCardView.<InitTipsItem>d__7 <InitTipsItem>d__;
			<InitTipsItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTipsItem>d__.<>4__this = this;
			<InitTipsItem>d__.<>1__state = -1;
			<InitTipsItem>d__.<>t__builder.Start<PhantomArenaChangeCardView.<InitTipsItem>d__7>(ref <InitTipsItem>d__);
			return <InitTipsItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602AC7E RID: 175230 RVA: 0x00C0B6E0 File Offset: 0x00C098E0
		private UniTask InitLayout()
		{
			PhantomArenaChangeCardView.<InitLayout>d__8 <InitLayout>d__;
			<InitLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLayout>d__.<>4__this = this;
			<InitLayout>d__.<>1__state = -1;
			<InitLayout>d__.<>t__builder.Start<PhantomArenaChangeCardView.<InitLayout>d__8>(ref <InitLayout>d__);
			return <InitLayout>d__.<>t__builder.Task;
		}

		// Token: 0x0602AC7F RID: 175231 RVA: 0x00C0B724 File Offset: 0x00C09924
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaChangeCardView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaChangeCardView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602AC80 RID: 175232 RVA: 0x00C0B767 File Offset: 0x00C09967
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.ReplaceCardFinish, new Action(this.JumpToBattleView));
		}

		// Token: 0x0602AC81 RID: 175233 RVA: 0x00C0B785 File Offset: 0x00C09985
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.ReplaceCardFinish, new Action(this.JumpToBattleView));
		}

		// Token: 0x0602AC82 RID: 175234 RVA: 0x00C0B7A3 File Offset: 0x00C099A3
		private PhantomArenaReplaceCard InitCard()
		{
			return new PhantomArenaReplaceCard
			{
				ClickCallback = new Action<int, bool>(this.CardClick)
			};
		}

		// Token: 0x0602AC83 RID: 175235 RVA: 0x00C0B7BC File Offset: 0x00C099BC
		private void ConfirmClick()
		{
			PhantomArenaBattleController.RequestPhantomBattleDealCardReplace(new List<int>(this.ReplaceIdSet));
		}

		// Token: 0x0602AC84 RID: 175236 RVA: 0x00C0B7CF File Offset: 0x00C099CF
		private void EmptyClick()
		{
			this.CancelSelectState();
		}

		// Token: 0x0602AC85 RID: 175237 RVA: 0x00C0B7D7 File Offset: 0x00C099D7
		private void CardClick(int id, bool isReplace)
		{
			if (isReplace)
			{
				this.ReplaceIdSet.Add(id);
			}
			else
			{
				this.ReplaceIdSet.Remove(id);
			}
			this.HandleSelectState(id);
		}

		// Token: 0x0602AC86 RID: 175238 RVA: 0x00C0B7FF File Offset: 0x00C099FF
		private void JumpToBattleView()
		{
			base.CloseMe(delegate(bool _)
			{
				PhantomArenaBattleController.Instance.SwitchPhantomArenaBattleViewState(EPlayingCardProcessState.BothDrawCard);
			});
		}

		// Token: 0x0602AC87 RID: 175239 RVA: 0x00C0B828 File Offset: 0x00C09A28
		private void HandleSelectState(int selectId)
		{
			if (this.CurrentSelectId == selectId)
			{
				return;
			}
			if (this.CurrentSelectId != -1)
			{
				PhantomArenaReplaceCard layoutItemByKey = this.Layout.GetLayoutItemByKey(this.CurrentSelectId);
				if (layoutItemByKey != null)
				{
					layoutItemByKey.SetSelectState(false);
				}
			}
			PhantomArenaReplaceCard layoutItemByKey2 = this.Layout.GetLayoutItemByKey(selectId);
			if (layoutItemByKey2 != null)
			{
				layoutItemByKey2.SetSelectState(true);
				this.TipsItem.RefreshTips(layoutItemByKey2.Card.Data, false);
				this.TipsItem.SetTipsActive(true);
			}
			this.CurrentSelectId = selectId;
		}

		// Token: 0x0602AC88 RID: 175240 RVA: 0x00C0B8B0 File Offset: 0x00C09AB0
		private void CancelSelectState()
		{
			if (this.CurrentSelectId == -1)
			{
				return;
			}
			PhantomArenaReplaceCard layoutItemByKey = this.Layout.GetLayoutItemByKey(this.CurrentSelectId);
			if (layoutItemByKey != null)
			{
				layoutItemByKey.SetSelectState(false);
			}
			this.CurrentSelectId = -1;
			this.TipsItem.SetTipsActive(false);
		}

		// Token: 0x0602AC89 RID: 175241 RVA: 0x00C0B8FC File Offset: 0x00C09AFC
		public string GetExtraResourceId(object param = null)
		{
			if (!PhantomArenaBattleModel.Instance.IsOldBvb)
			{
				return "UiView_CardChageNew";
			}
			return "UiView_CardChage";
		}

		// Token: 0x040172D6 RID: 94934
		protected GenericLayout<PhantomArenaReplaceCard, PhantomCardData> Layout;

		// Token: 0x040172D7 RID: 94935
		private PhantomArenaBattleTips TipsItem;

		// Token: 0x040172D8 RID: 94936
		private readonly HashSet<int> ReplaceIdSet = new HashSet<int>();

		// Token: 0x040172D9 RID: 94937
		private int CurrentSelectId = -1;

		// Token: 0x02009E39 RID: 40505
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04031313 RID: 201491
			public const int Layout = 0;

			// Token: 0x04031314 RID: 201492
			public const int LayoutItem = 1;

			// Token: 0x04031315 RID: 201493
			public const int ConfirmBtn = 2;

			// Token: 0x04031316 RID: 201494
			public const int EmptyBtn = 3;

			// Token: 0x04031317 RID: 201495
			public const int TipsItem = 4;
		}
	}
}
