using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Spring25
{
	// Token: 0x020060A4 RID: 24740
	[NullableContext(1)]
	[Nullable(0)]
	public class Spring25MainView : UiViewBase
	{
		// Token: 0x0603E89F RID: 256159 RVA: 0x00F1D80A File Offset: 0x00F1BA0A
		public Spring25MainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603E8A0 RID: 256160 RVA: 0x00F1D820 File Offset: 0x00F1BA20
		protected unsafe override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIItem)),
				new ValueTuple<int, Type>(14, typeof(UUIItem)),
				new ValueTuple<int, Type>(15, typeof(UUIItem)),
				new ValueTuple<int, Type>(16, typeof(UUIItem))
			};
			int num = 3;
			List<ValueTuple<int, Delegate>> list = new List<ValueTuple<int, Delegate>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list, num);
			Span<ValueTuple<int, Delegate>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Delegate>(2, new Action(this.HandleInviteClick));
			num2++;
			*span[num2] = new ValueTuple<int, Delegate>(3, new Action(this.HandleGiftClick));
			num2++;
			*span[num2] = new ValueTuple<int, Delegate>(4, new Action(this.HandleLetterClick));
			this.BtnBindInfo = list;
		}

		// Token: 0x0603E8A1 RID: 256161 RVA: 0x00F1DA3C File Offset: 0x00F1BC3C
		protected override UniTask OnBeforeStartAsync()
		{
			Spring25MainView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<Spring25MainView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E8A2 RID: 256162 RVA: 0x00F1DA80 File Offset: 0x00F1BC80
		protected override void OnStart()
		{
			this.RefreshByOpenParam();
			RedDotController.Instance.BindRedDot(ERedDotName.Spring25AllLetter, base.GetItem(15), null, 0);
			RedDotController.Instance.BindRedDot(ERedDotName.Spring25Reward, base.GetItem(14), null, 0);
			RedDotController.Instance.BindRedDot(ERedDotName.Spring25Invite, base.GetItem(16), null, 0);
			this.SelfItem.RefreshByInvitedAsync(!Spring25Model.Instance.NeedStartDialog, false);
		}

		// Token: 0x0603E8A3 RID: 256163 RVA: 0x00F1DAF8 File Offset: 0x00F1BCF8
		protected override void OnBeforeDestroy()
		{
			ActivitySpring25Controller.Instance.HandleResetCurrentSignId();
			RedDotController.Instance.UnBindRedDot(ERedDotName.Spring25AllLetter);
			RedDotController.Instance.UnBindRedDot(ERedDotName.Spring25Reward);
			RedDotController.Instance.UnBindRedDot(ERedDotName.Spring25Invite);
		}

		// Token: 0x0603E8A4 RID: 256164 RVA: 0x00F1DB34 File Offset: 0x00F1BD34
		protected override void OnBeforeShow()
		{
			RedDotController.Instance.BindRedDot(ERedDotName.Spring25AllLetter, base.GetItem(15), null, 0);
			RedDotController.Instance.BindRedDot(ERedDotName.Spring25Reward, base.GetItem(14), null, 0);
			RedDotController.Instance.BindRedDot(ERedDotName.Spring25Invite, base.GetItem(16), null, 0);
		}

		// Token: 0x0603E8A5 RID: 256165 RVA: 0x00F1DB8C File Offset: 0x00F1BD8C
		protected override void OnAfterHide()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.Spring25AllLetter, base.GetItem(15), 0);
			RedDotController.Instance.UnBindGivenUi(ERedDotName.Spring25Reward, base.GetItem(14), 0);
			RedDotController.Instance.UnBindGivenUi(ERedDotName.Spring25Invite, base.GetItem(16), 0);
		}

		// Token: 0x0603E8A6 RID: 256166 RVA: 0x00F1DBE4 File Offset: 0x00F1BDE4
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.Spring25InviteDone, new Action(this.HandleSpring25InviteDone));
			EventSystem.Instance.Add(EEventName.Spring25ActivityParseDone, new Action(this.HandleSpring25ActivityParseDone));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.HandleCloseEnvelopeView));
			EventSystem.Instance.Add(EEventName.Spring25UnlockAnimDone, new Action(this.HandleSpring25UnlockAnimDone));
		}

		// Token: 0x0603E8A7 RID: 256167 RVA: 0x00F1DC60 File Offset: 0x00F1BE60
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.Spring25InviteDone, new Action(this.HandleSpring25InviteDone));
			EventSystem.Instance.Remove(EEventName.Spring25ActivityParseDone, new Action(this.HandleSpring25ActivityParseDone));
			EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.HandleCloseEnvelopeView));
			EventSystem.Instance.Remove(EEventName.Spring25UnlockAnimDone, new Action(this.HandleSpring25UnlockAnimDone));
		}

		// Token: 0x0603E8A8 RID: 256168 RVA: 0x00F1DCDA File Offset: 0x00F1BEDA
		protected override void OnAfterPlayStartSequence()
		{
			this.TryPlayOpening();
		}

		// Token: 0x0603E8A9 RID: 256169 RVA: 0x00F1DCE4 File Offset: 0x00F1BEE4
		private UniTask TryPlayOpening()
		{
			Spring25MainView.<TryPlayOpening>d__15 <TryPlayOpening>d__;
			<TryPlayOpening>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TryPlayOpening>d__.<>4__this = this;
			<TryPlayOpening>d__.<>1__state = -1;
			<TryPlayOpening>d__.<>t__builder.Start<Spring25MainView.<TryPlayOpening>d__15>(ref <TryPlayOpening>d__);
			return <TryPlayOpening>d__.<>t__builder.Task;
		}

		// Token: 0x0603E8AA RID: 256170 RVA: 0x00F1DD28 File Offset: 0x00F1BF28
		private unsafe void RefreshByOpenParam()
		{
			Spring25MainViewData spring25MainViewData = this.OpenParam as Spring25MainViewData;
			if (spring25MainViewData == null)
			{
				return;
			}
			if (spring25MainViewData.CharacterInvitedMap.Count != this.CharacterItemCache.Count)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Spring25;
				ELogAuthor author = ELogAuthor.WZ;
				string message = "春节活动角色信息和UI节点不符，隐藏全部节点";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("data count", spring25MainViewData.CharacterInvitedMap.Count);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("item count", this.CharacterItemCache.Count);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				foreach (ItemInMain itemInMain in this.CharacterItemCache.Values)
				{
					itemInMain.SetUiActive(false);
				}
				return;
			}
			foreach (KeyValuePair<ESpring25RoleType, bool> keyValuePair in spring25MainViewData.CharacterInvitedMap)
			{
				ItemInMain itemInMain2;
				if (this.CharacterItemCache.TryGetValue(keyValuePair.Key, out itemInMain2))
				{
					ItemInMain itemInMain3 = itemInMain2;
					bool value = keyValuePair.Value;
					ESpring25RoleType key = keyValuePair.Key;
					ESpring25RoleType? newRoleType = spring25MainViewData.NewRoleType;
					itemInMain3.RefreshByInvitedAsync(value, key == newRoleType.GetValueOrDefault() & newRoleType != null);
				}
			}
			this.CaptionItem.SetTitleByTextIdAndArgNew(spring25MainViewData.TitleTextId, Array.Empty<object>());
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetText(spring25MainViewData.InviteRemainCount.ToString(), true);
		}

		// Token: 0x0603E8AB RID: 256171 RVA: 0x00F1DED4 File Offset: 0x00F1C0D4
		private void HandleInviteClick()
		{
			if (this.ClickLock)
			{
				return;
			}
			this.ClickLock = true;
			ActivitySpring25Controller.Instance.HandleInviteClickInMainView();
		}

		// Token: 0x0603E8AC RID: 256172 RVA: 0x00F1DEF1 File Offset: 0x00F1C0F1
		private void HandleGiftClick()
		{
			if (this.ClickLock)
			{
				return;
			}
			ActivitySpring25Controller.Instance.HandleGiftClickInMainView();
		}

		// Token: 0x0603E8AD RID: 256173 RVA: 0x00F1DF06 File Offset: 0x00F1C106
		private void HandleLetterClick()
		{
			if (this.ClickLock)
			{
				return;
			}
			ActivitySpring25Controller.Instance.HandleLetterClickInMainView();
		}

		// Token: 0x0603E8AE RID: 256174 RVA: 0x00F1DF1B File Offset: 0x00F1C11B
		private void HandleOnCloseClick()
		{
			if (this.ClickLock)
			{
				return;
			}
			base.CloseMe(null);
		}

		// Token: 0x0603E8AF RID: 256175 RVA: 0x00F1DF2D File Offset: 0x00F1C12D
		private void HandleOnHelpClick()
		{
			ActivitySpring25Controller.Instance.HandleHelpClick();
		}

		// Token: 0x0603E8B0 RID: 256176 RVA: 0x00F1DF39 File Offset: 0x00F1C139
		private void HandleSpring25InviteDone()
		{
			this.OpenParam = Spring25Model.Instance.BuildMainViewData(false);
			this.RefreshByOpenParam();
		}

		// Token: 0x0603E8B1 RID: 256177 RVA: 0x00F1DF52 File Offset: 0x00F1C152
		private void HandleSpring25ActivityParseDone()
		{
			this.OpenParam = Spring25Model.Instance.BuildMainViewData(true);
			this.RefreshByOpenParam();
		}

		// Token: 0x0603E8B2 RID: 256178 RVA: 0x00F1DF6B File Offset: 0x00F1C16B
		private void HandleCloseEnvelopeView(EUiViewName viewName, int i)
		{
			if (viewName == EUiViewName.Spring25EnvelopeView)
			{
				ActivitySpring25Controller.Instance.HandleTryOpenShareViewAsync();
			}
		}

		// Token: 0x0603E8B3 RID: 256179 RVA: 0x00F1DF85 File Offset: 0x00F1C185
		private void HandleSpring25UnlockAnimDone()
		{
			this.ClickLock = false;
		}

		// Token: 0x04020B81 RID: 134017
		private readonly Dictionary<ESpring25RoleType, ItemInMain> CharacterItemCache = new Dictionary<ESpring25RoleType, ItemInMain>();

		// Token: 0x04020B82 RID: 134018
		private ItemInMain SelfItem;

		// Token: 0x04020B83 RID: 134019
		private PopupCaptionItem CaptionItem;

		// Token: 0x04020B84 RID: 134020
		private bool ClickLock;

		// Token: 0x0200C303 RID: 49923
		[NullableContext(0)]
		private static class EComponent
		{
			// Token: 0x0403AE2A RID: 241194
			public const int CaptionItem = 0;

			// Token: 0x0403AE2B RID: 241195
			public const int TicketCountText = 1;

			// Token: 0x0403AE2C RID: 241196
			public const int InviteButton = 2;

			// Token: 0x0403AE2D RID: 241197
			public const int GiftButton = 3;

			// Token: 0x0403AE2E RID: 241198
			public const int LetterButton = 4;

			// Token: 0x0403AE2F RID: 241199
			public const int AbuItem = 5;

			// Token: 0x0403AE30 RID: 241200
			public const int SanhuaItem = 6;

			// Token: 0x0403AE31 RID: 241201
			public const int MaleItem = 7;

			// Token: 0x0403AE32 RID: 241202
			public const int FemaleItem = 8;

			// Token: 0x0403AE33 RID: 241203
			public const int BulanteItem = 9;

			// Token: 0x0403AE34 RID: 241204
			public const int LuokekeItem = 10;

			// Token: 0x0403AE35 RID: 241205
			public const int ChangliItem = 11;

			// Token: 0x0403AE36 RID: 241206
			public const int KelaitaItem = 12;

			// Token: 0x0403AE37 RID: 241207
			public const int JinxiItem = 13;

			// Token: 0x0403AE38 RID: 241208
			public const int RewardRedDotItem = 14;

			// Token: 0x0403AE39 RID: 241209
			public const int LetterRedDotItem = 15;

			// Token: 0x0403AE3A RID: 241210
			public const int InviteRedDotItem = 16;
		}
	}
}
