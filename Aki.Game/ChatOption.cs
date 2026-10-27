using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020017A5 RID: 6053
public class ChatOption : UiViewBase
{
	// Token: 0x0600B064 RID: 45156 RVA: 0x0027DAC7 File Offset: 0x0027BCC7
	[NullableContext(1)]
	public ChatOption(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600B065 RID: 45157 RVA: 0x0027DAD0 File Offset: 0x0027BCD0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 3;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickJoinBlackListButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickReportButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickPlayerInformationButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600B066 RID: 45158 RVA: 0x0027DC20 File Offset: 0x0027BE20
	protected override void OnStart()
	{
		this.MutePlayerButton = new ChatOptionButton(base.GetItem(2));
		this.MutePlayerButton.SetClickCallBack(new Action(this.OnClickMutePlayerButton));
		this.PlayerId = (this.OpenParam as int?);
		this.FriendData = FriendModel.Instance.GetFriendById(this.PlayerId.Value);
		if (this.FriendData == null)
		{
			return;
		}
		UUIText text = base.GetText(0);
		LguiUtil.Instance.SetLocalText(text, "OptionTitle", new <>z__ReadOnlySingleElementList<object>(this.FriendData.PlayerName));
		this.RefreshMuteText();
	}

	// Token: 0x0600B067 RID: 45159 RVA: 0x0027DCBE File Offset: 0x0027BEBE
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.OnAddMutePlayer, new Action<int>(this.OnRefreshMutePlayer));
		EventSystem.Instance.Add<int>(EEventName.OnRemoveMutePlayer, new Action<int>(this.OnRefreshMutePlayer));
	}

	// Token: 0x0600B068 RID: 45160 RVA: 0x0027DCF8 File Offset: 0x0027BEF8
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnAddMutePlayer, new Action<int>(this.OnRefreshMutePlayer));
		EventSystem.Instance.Remove(EEventName.OnRemoveMutePlayer, new Action<int>(this.OnRefreshMutePlayer));
	}

	// Token: 0x0600B069 RID: 45161 RVA: 0x0027DD34 File Offset: 0x0027BF34
	private void OnRefreshMutePlayer(int playerId)
	{
		int? playerId2 = this.PlayerId;
		if (!(playerId == playerId2.GetValueOrDefault() & playerId2 != null))
		{
			return;
		}
		this.RefreshMuteText();
	}

	// Token: 0x0600B06A RID: 45162 RVA: 0x0027DD63 File Offset: 0x0027BF63
	protected override void OnBeforeDestroy()
	{
		this.PlayerId = null;
		this.FriendData = null;
	}

	// Token: 0x0600B06B RID: 45163 RVA: 0x0027DD78 File Offset: 0x0027BF78
	private void RefreshMuteText()
	{
		if (ChatModel.Instance.IsInMute(this.PlayerId.Value))
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(TextConfig.Instance.GetTextContentIdById("CancelMuteText"), null);
			this.MutePlayerButton.RefreshButtonText(localTextNew);
			return;
		}
		string localTextNew2 = ConfigMultiTextLang.GetLocalTextNew(TextConfig.Instance.GetTextContentIdById("MuteText"), null);
		this.MutePlayerButton.RefreshButtonText(localTextNew2);
	}

	// Token: 0x0600B06C RID: 45164 RVA: 0x0027DDE4 File Offset: 0x0027BFE4
	private void OnClickMutePlayerButton()
	{
		if (ChatModel.Instance.IsInMute(this.PlayerId.Value))
		{
			ChatController.Instance.ChatMutePlayerRequest(this.PlayerId.Value, false);
		}
		else
		{
			ChatController.Instance.ChatMutePlayerRequest(this.PlayerId.Value, true);
		}
		UiManager.Instance.CloseView(EUiViewName.ChatOption, null);
	}

	// Token: 0x0600B06D RID: 45165 RVA: 0x0027DE48 File Offset: 0x0027C048
	private void OnClickJoinBlackListButton()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.BlockFriend);
		confirmBoxDataNew.SetTextArgs(new string[]
		{
			this.FriendData.PlayerName
		});
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			FriendController.Instance.RequestBlockPlayer(this.PlayerId.Value);
			UiManager.Instance.CloseView(EUiViewName.ChatOption, null);
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600B06E RID: 45166 RVA: 0x0027DE9C File Offset: 0x0027C09C
	private void OnClickReportButton()
	{
		UiManager.Instance.CloseView(EUiViewName.ChatOption, null);
		FriendData friendById = FriendModel.Instance.GetFriendById(this.PlayerId.Value);
		ReportController.Instance.OpenReportView(friendById, EReportSourceType.PrivateRoom);
	}

	// Token: 0x0600B06F RID: 45167 RVA: 0x0027DEDB File Offset: 0x0027C0DB
	private void OnClickPlayerInformationButton()
	{
		this.CheckOpenPersonalRootView().Forget();
	}

	// Token: 0x0600B070 RID: 45168 RVA: 0x0027DEE8 File Offset: 0x0027C0E8
	private UniTask CheckOpenPersonalRootView()
	{
		ChatOption.<CheckOpenPersonalRootView>d__16 <CheckOpenPersonalRootView>d__;
		<CheckOpenPersonalRootView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckOpenPersonalRootView>d__.<>4__this = this;
		<CheckOpenPersonalRootView>d__.<>1__state = -1;
		<CheckOpenPersonalRootView>d__.<>t__builder.Start<ChatOption.<CheckOpenPersonalRootView>d__16>(ref <CheckOpenPersonalRootView>d__);
		return <CheckOpenPersonalRootView>d__.<>t__builder.Task;
	}

	// Token: 0x04005020 RID: 20512
	private int? PlayerId;

	// Token: 0x04005021 RID: 20513
	[Nullable(2)]
	private FriendData FriendData;

	// Token: 0x04005022 RID: 20514
	[Nullable(2)]
	private ChatOptionButton MutePlayerButton;

	// Token: 0x02007DB5 RID: 32181
	private class EChildType
	{
		// Token: 0x04029278 RID: 168568
		public const int TitleText = 0;

		// Token: 0x04029279 RID: 168569
		public const int PlayerInformationButton = 1;

		// Token: 0x0402927A RID: 168570
		public const int MutePlayerButton = 2;

		// Token: 0x0402927B RID: 168571
		public const int JoinBlackListButton = 3;

		// Token: 0x0402927C RID: 168572
		public const int ReportButton = 4;
	}
}
