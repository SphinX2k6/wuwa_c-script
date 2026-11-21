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
	// Token: 0x02005022 RID: 20514
	[NullableContext(1)]
	[Nullable(0)]
	public class Spring25MainView : UiViewBase
	{
		// Token: 0x06033563 RID: 210275 RVA: 0x00E645CE File Offset: 0x00E627CE
		public Spring25MainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033564 RID: 210276 RVA: 0x00E645E4 File Offset: 0x00E627E4
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

		// Token: 0x06033565 RID: 210277 RVA: 0x00E64800 File Offset: 0x00E62A00
		protected override UniTask OnBeforeStartAsync()
		{
			Spring25MainView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<Spring25MainView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033566 RID: 210278 RVA: 0x00E64844 File Offset: 0x00E62A44
		protected override void OnStart()
		{
			this.RefreshByOpenParam();
			RedDotController.Instance.BindRedDot(ERedDotName.Spring25AllLetter, base.GetItem(15), null, 0);
			RedDotController.Instance.BindRedDot(ERedDotName.Spring25Reward, base.GetItem(14), null, 0);
			RedDotController.Instance.BindRedDot(ERedDotName.Spring25Invite, base.GetItem(16), null, 0);
			this.SelfItem.RefreshByInvitedAsync(!Spring25Model.Instance.NeedStartDialog, false);
		}

		// Token: 0x06033567 RID: 210279 RVA: 0x00E648BC File Offset: 0x00E62ABC
		protected override void OnBeforeDestroy()
		{
			ActivitySpring25Controller.Instance.HandleResetCurrentSignId();
			RedDotController.Instance.UnBindRedDot(ERedDotName.Spring25AllLetter);
			RedDotController.Instance.UnBindRedDot(ERedDotName.Spring25Reward);
			RedDotController.Instance.UnBindRedDot(ERedDotName.Spring25Invite);
		}

		// Token: 0x06033568 RID: 210280 RVA: 0x00E648F8 File Offset: 0x00E62AF8
		protected override void OnBeforeShow()
		{
			RedDotController.Instance.BindRedDot(ERedDotName.Spring25AllLetter, base.GetItem(15), null, 0);
			RedDotController.Instance.BindRedDot(ERedDotName.Spring25Reward, base.GetItem(14), null, 0);
			RedDotController.Instance.BindRedDot(ERedDotName.Spring25Invite, base.GetItem(16), null, 0);
		}

		// Token: 0x06033569 RID: 210281 RVA: 0x00E64950 File Offset: 0x00E62B50
		protected override void OnAfterHide()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.Spring25AllLetter, base.GetItem(15), 0);
			RedDotController.Instance.UnBindGivenUi(ERedDotName.Spring25Reward, base.GetItem(14), 0);
			RedDotController.Instance.UnBindGivenUi(ERedDotName.Spring25Invite, base.GetItem(16), 0);
		}

		// Token: 0x0603356A RID: 210282 RVA: 0x00E649A8 File Offset: 0x00E62BA8
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.Spring25InviteDone, new Action(this.HandleSpring25InviteDone));
			EventSystem.Instance.Add(EEventName.Spring25ActivityParseDone, new Action(this.HandleSpring25ActivityParseDone));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.HandleCloseEnvelopeView));
			EventSystem.Instance.Add(EEventName.Spring25UnlockAnimDone, new Action(this.HandleSpring25UnlockAnimDone));
		}

		// Token: 0x0603356B RID: 210283 RVA: 0x00E64A24 File Offset: 0x00E62C24
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.Spring25InviteDone, new Action(this.HandleSpring25InviteDone));
			EventSystem.Instance.Remove(EEventName.Spring25ActivityParseDone, new Action(this.HandleSpring25ActivityParseDone));
			EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.HandleCloseEnvelopeView));
			EventSystem.Instance.Remove(EEventName.Spring25UnlockAnimDone, new Action(this.HandleSpring25UnlockAnimDone));
		}

		// Token: 0x0603356C RID: 210284 RVA: 0x00E64A9E File Offset: 0x00E62C9E
		protected override void OnAfterPlayStartSequence()
		{
			this.TryPlayOpening();
		}

		// Token: 0x0603356D RID: 210285 RVA: 0x00E64AA8 File Offset: 0x00E62CA8
		private UniTask TryPlayOpening()
		{
			Spring25MainView.<TryPlayOpening>d__15 <TryPlayOpening>d__;
			<TryPlayOpening>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TryPlayOpening>d__.<>4__this = this;
			<TryPlayOpening>d__.<>1__state = -1;
			<TryPlayOpening>d__.<>t__builder.Start<Spring25MainView.<TryPlayOpening>d__15>(ref <TryPlayOpening>d__);
			return <TryPlayOpening>d__.<>t__builder.Task;
		}

		// Token: 0x0603356E RID: 210286 RVA: 0x00E64AEC File Offset: 0x00E62CEC
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

		// Token: 0x0603356F RID: 210287 RVA: 0x00E64C98 File Offset: 0x00E62E98
		private void HandleInviteClick()
		{
			if (this.ClickLock)
			{
				return;
			}
			this.ClickLock = true;
			ActivitySpring25Controller.Instance.HandleInviteClickInMainView();
		}

		// Token: 0x06033570 RID: 210288 RVA: 0x00E64CB5 File Offset: 0x00E62EB5
		private void HandleGiftClick()
		{
			if (this.ClickLock)
			{
				return;
			}
			ActivitySpring25Controller.Instance.HandleGiftClickInMainView();
		}

		// Token: 0x06033571 RID: 210289 RVA: 0x00E64CCA File Offset: 0x00E62ECA
		private void HandleLetterClick()
		{
			if (this.ClickLock)
			{
				return;
			}
			ActivitySpring25Controller.Instance.HandleLetterClickInMainView();
		}

		// Token: 0x06033572 RID: 210290 RVA: 0x00E64CDF File Offset: 0x00E62EDF
		private void HandleOnCloseClick()
		{
			if (this.ClickLock)
			{
				return;
			}
			base.CloseMe(null);
		}

		// Token: 0x06033573 RID: 210291 RVA: 0x00E64CF1 File Offset: 0x00E62EF1
		private void HandleOnHelpClick()
		{
			ActivitySpring25Controller.Instance.HandleHelpClick();
		}

		// Token: 0x06033574 RID: 210292 RVA: 0x00E64CFD File Offset: 0x00E62EFD
		private void HandleSpring25InviteDone()
		{
			this.OpenParam = Spring25Model.Instance.BuildMainViewData(false);
			this.RefreshByOpenParam();
		}

		// Token: 0x06033575 RID: 210293 RVA: 0x00E64D16 File Offset: 0x00E62F16
		private void HandleSpring25ActivityParseDone()
		{
			this.OpenParam = Spring25Model.Instance.BuildMainViewData(true);
			this.RefreshByOpenParam();
		}

		// Token: 0x06033576 RID: 210294 RVA: 0x00E64D2F File Offset: 0x00E62F2F
		private void HandleCloseEnvelopeView(EUiViewName viewName, int i)
		{
			if (viewName == EUiViewName.Spring25EnvelopeView)
			{
				ActivitySpring25Controller.Instance.HandleTryOpenShareViewAsync();
			}
		}

		// Token: 0x06033577 RID: 210295 RVA: 0x00E64D49 File Offset: 0x00E62F49
		private void HandleSpring25UnlockAnimDone()
		{
			this.ClickLock = false;
		}

		// Token: 0x0401B4AE RID: 111790
		private readonly Dictionary<ESpring25RoleType, ItemInMain> CharacterItemCache = new Dictionary<ESpring25RoleType, ItemInMain>();

		// Token: 0x0401B4AF RID: 111791
		private ItemInMain SelfItem;

		// Token: 0x0401B4B0 RID: 111792
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401B4B1 RID: 111793
		private bool ClickLock;

		// Token: 0x0200ACEE RID: 44270
		[NullableContext(0)]
		private static class EComponent
		{
			// Token: 0x04035792 RID: 219026
			public const int CaptionItem = 0;

			// Token: 0x04035793 RID: 219027
			public const int TicketCountText = 1;

			// Token: 0x04035794 RID: 219028
			public const int InviteButton = 2;

			// Token: 0x04035795 RID: 219029
			public const int GiftButton = 3;

			// Token: 0x04035796 RID: 219030
			public const int LetterButton = 4;

			// Token: 0x04035797 RID: 219031
			public const int AbuItem = 5;

			// Token: 0x04035798 RID: 219032
			public const int SanhuaItem = 6;

			// Token: 0x04035799 RID: 219033
			public const int MaleItem = 7;

			// Token: 0x0403579A RID: 219034
			public const int FemaleItem = 8;

			// Token: 0x0403579B RID: 219035
			public const int BulanteItem = 9;

			// Token: 0x0403579C RID: 219036
			public const int LuokekeItem = 10;

			// Token: 0x0403579D RID: 219037
			public const int ChangliItem = 11;

			// Token: 0x0403579E RID: 219038
			public const int KelaitaItem = 12;

			// Token: 0x0403579F RID: 219039
			public const int JinxiItem = 13;

			// Token: 0x040357A0 RID: 219040
			public const int RewardRedDotItem = 14;

			// Token: 0x040357A1 RID: 219041
			public const int LetterRedDotItem = 15;

			// Token: 0x040357A2 RID: 219042
			public const int InviteRedDotItem = 16;
		}
	}
}
