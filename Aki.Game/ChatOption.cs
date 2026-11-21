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

// Token: 0x02000C5E RID: 3166
public class ChatOption : UiViewBase
{
	// Token: 0x0600844C RID: 33868 RVA: 0x0028805F File Offset: 0x0028625F
	[NullableContext(1)]
	public ChatOption(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600844D RID: 33869 RVA: 0x00288068 File Offset: 0x00286268
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

	// Token: 0x0600844E RID: 33870 RVA: 0x002881B8 File Offset: 0x002863B8
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

	// Token: 0x0600844F RID: 33871 RVA: 0x00288256 File Offset: 0x00286456
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.OnAddMutePlayer, new Action<int>(this.OnRefreshMutePlayer));
		EventSystem.Instance.Add<int>(EEventName.OnRemoveMutePlayer, new Action<int>(this.OnRefreshMutePlayer));
	}

	// Token: 0x06008450 RID: 33872 RVA: 0x00288290 File Offset: 0x00286490
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnAddMutePlayer, new Action<int>(this.OnRefreshMutePlayer));
		EventSystem.Instance.Remove(EEventName.OnRemoveMutePlayer, new Action<int>(this.OnRefreshMutePlayer));
	}

	// Token: 0x06008451 RID: 33873 RVA: 0x002882CC File Offset: 0x002864CC
	private void OnRefreshMutePlayer(int playerId)
	{
		int? playerId2 = this.PlayerId;
		if (!(playerId == playerId2.GetValueOrDefault() & playerId2 != null))
		{
			return;
		}
		this.RefreshMuteText();
	}

	// Token: 0x06008452 RID: 33874 RVA: 0x002882FB File Offset: 0x002864FB
	protected override void OnBeforeDestroy()
	{
		this.PlayerId = null;
		this.FriendData = null;
	}

	// Token: 0x06008453 RID: 33875 RVA: 0x00288310 File Offset: 0x00286510
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

	// Token: 0x06008454 RID: 33876 RVA: 0x0028837C File Offset: 0x0028657C
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

	// Token: 0x06008455 RID: 33877 RVA: 0x002883E0 File Offset: 0x002865E0
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

	// Token: 0x06008456 RID: 33878 RVA: 0x00288434 File Offset: 0x00286634
	private void OnClickReportButton()
	{
		UiManager.Instance.CloseView(EUiViewName.ChatOption, null);
		FriendData friendById = FriendModel.Instance.GetFriendById(this.PlayerId.Value);
		ReportController.Instance.OpenReportView(friendById, EReportSourceType.PrivateRoom);
	}

	// Token: 0x06008457 RID: 33879 RVA: 0x00288473 File Offset: 0x00286673
	private void OnClickPlayerInformationButton()
	{
		this.CheckOpenPersonalRootView().Forget();
	}

	// Token: 0x06008458 RID: 33880 RVA: 0x00288480 File Offset: 0x00286680
	private UniTask CheckOpenPersonalRootView()
	{
		ChatOption.<CheckOpenPersonalRootView>d__16 <CheckOpenPersonalRootView>d__;
		<CheckOpenPersonalRootView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckOpenPersonalRootView>d__.<>4__this = this;
		<CheckOpenPersonalRootView>d__.<>1__state = -1;
		<CheckOpenPersonalRootView>d__.<>t__builder.Start<ChatOption.<CheckOpenPersonalRootView>d__16>(ref <CheckOpenPersonalRootView>d__);
		return <CheckOpenPersonalRootView>d__.<>t__builder.Task;
	}

	// Token: 0x040050CA RID: 20682
	private int? PlayerId;

	// Token: 0x040050CB RID: 20683
	[Nullable(2)]
	private FriendData FriendData;

	// Token: 0x040050CC RID: 20684
	[Nullable(2)]
	private ChatOptionButton MutePlayerButton;

	// Token: 0x02006F3B RID: 28475
	private class EChildType
	{
		// Token: 0x040245A3 RID: 148899
		public const int TitleText = 0;

		// Token: 0x040245A4 RID: 148900
		public const int PlayerInformationButton = 1;

		// Token: 0x040245A5 RID: 148901
		public const int MutePlayerButton = 2;

		// Token: 0x040245A6 RID: 148902
		public const int JoinBlackListButton = 3;

		// Token: 0x040245A7 RID: 148903
		public const int ReportButton = 4;
	}
}
