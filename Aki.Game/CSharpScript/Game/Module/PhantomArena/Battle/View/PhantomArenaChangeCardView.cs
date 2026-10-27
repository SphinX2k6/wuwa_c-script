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
	// Token: 0x0200524F RID: 21071
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaChangeCardView : UiViewBase, IUiViewResource
	{
		// Token: 0x06035D80 RID: 220544 RVA: 0x00CBDF2A File Offset: 0x00CBC12A
		public PhantomArenaChangeCardView(UiViewInfo uiViewInfo) : base(uiViewInfo)
		{
		}

		// Token: 0x06035D81 RID: 220545 RVA: 0x00CBDF48 File Offset: 0x00CBC148
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

		// Token: 0x06035D82 RID: 220546 RVA: 0x00CBE00C File Offset: 0x00CBC20C
		private UniTask InitTipsItem()
		{
			PhantomArenaChangeCardView.<InitTipsItem>d__7 <InitTipsItem>d__;
			<InitTipsItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTipsItem>d__.<>4__this = this;
			<InitTipsItem>d__.<>1__state = -1;
			<InitTipsItem>d__.<>t__builder.Start<PhantomArenaChangeCardView.<InitTipsItem>d__7>(ref <InitTipsItem>d__);
			return <InitTipsItem>d__.<>t__builder.Task;
		}

		// Token: 0x06035D83 RID: 220547 RVA: 0x00CBE050 File Offset: 0x00CBC250
		private UniTask InitLayout()
		{
			PhantomArenaChangeCardView.<InitLayout>d__8 <InitLayout>d__;
			<InitLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLayout>d__.<>4__this = this;
			<InitLayout>d__.<>1__state = -1;
			<InitLayout>d__.<>t__builder.Start<PhantomArenaChangeCardView.<InitLayout>d__8>(ref <InitLayout>d__);
			return <InitLayout>d__.<>t__builder.Task;
		}

		// Token: 0x06035D84 RID: 220548 RVA: 0x00CBE094 File Offset: 0x00CBC294
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaChangeCardView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaChangeCardView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035D85 RID: 220549 RVA: 0x00CBE0D7 File Offset: 0x00CBC2D7
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.ReplaceCardFinish, new Action(this.JumpToBattleView));
		}

		// Token: 0x06035D86 RID: 220550 RVA: 0x00CBE0F5 File Offset: 0x00CBC2F5
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.ReplaceCardFinish, new Action(this.JumpToBattleView));
		}

		// Token: 0x06035D87 RID: 220551 RVA: 0x00CBE113 File Offset: 0x00CBC313
		private PhantomArenaReplaceCard InitCard()
		{
			return new PhantomArenaReplaceCard
			{
				ClickCallback = new Action<int, bool>(this.CardClick)
			};
		}

		// Token: 0x06035D88 RID: 220552 RVA: 0x00CBE12C File Offset: 0x00CBC32C
		private void ConfirmClick()
		{
			PhantomArenaBattleController.RequestPhantomBattleDealCardReplace(new List<int>(this.ReplaceIdSet));
		}

		// Token: 0x06035D89 RID: 220553 RVA: 0x00CBE13F File Offset: 0x00CBC33F
		private void EmptyClick()
		{
			this.CancelSelectState();
		}

		// Token: 0x06035D8A RID: 220554 RVA: 0x00CBE147 File Offset: 0x00CBC347
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

		// Token: 0x06035D8B RID: 220555 RVA: 0x00CBE16F File Offset: 0x00CBC36F
		private void JumpToBattleView()
		{
			base.CloseMe(delegate(bool _)
			{
				PhantomArenaBattleController.Instance.SwitchPhantomArenaBattleViewState(EPlayingCardProcessState.BothDrawCard);
			});
		}

		// Token: 0x06035D8C RID: 220556 RVA: 0x00CBE198 File Offset: 0x00CBC398
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

		// Token: 0x06035D8D RID: 220557 RVA: 0x00CBE220 File Offset: 0x00CBC420
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

		// Token: 0x06035D8E RID: 220558 RVA: 0x00CBE26C File Offset: 0x00CBC46C
		public string GetExtraResourceId(object param = null)
		{
			if (!PhantomArenaBattleModel.Instance.IsOldBvb)
			{
				return "UiView_CardChageNew";
			}
			return "UiView_CardChage";
		}

		// Token: 0x0401C8A1 RID: 116897
		protected GenericLayout<PhantomArenaReplaceCard, PhantomCardData> Layout;

		// Token: 0x0401C8A2 RID: 116898
		private PhantomArenaBattleTips TipsItem;

		// Token: 0x0401C8A3 RID: 116899
		private readonly HashSet<int> ReplaceIdSet = new HashSet<int>();

		// Token: 0x0401C8A4 RID: 116900
		private int CurrentSelectId = -1;

		// Token: 0x0200B401 RID: 46081
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040368C0 RID: 223424
			public const int Layout = 0;

			// Token: 0x040368C1 RID: 223425
			public const int LayoutItem = 1;

			// Token: 0x040368C2 RID: 223426
			public const int ConfirmBtn = 2;

			// Token: 0x040368C3 RID: 223427
			public const int EmptyBtn = 3;

			// Token: 0x040368C4 RID: 223428
			public const int TipsItem = 4;
		}
	}
}
