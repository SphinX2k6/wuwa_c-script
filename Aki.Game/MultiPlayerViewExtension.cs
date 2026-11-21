using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using UnrealEngine;

// Token: 0x02001096 RID: 4246
[NullableContext(1)]
[Nullable(0)]
public class MultiPlayerViewExtension : IViewExtension
{
	// Token: 0x0600A885 RID: 43141 RVA: 0x00319774 File Offset: 0x00317974
	public MultiPlayerViewExtension(UUIItem rootItem, UUIItem chatInfoItem, UUIText chatInfoText, Func<List<FormationRoleSlot>> getRoleSlots, Action refreshConfirm, Action refreshEnter, Func<bool> isMulti)
	{
		this.RootItem = rootItem;
		this.ChatInfoItem = chatInfoItem;
		this.ChatInfoText = chatInfoText;
		this.GetRoleSlots = getRoleSlots;
		this.RefreshConfirm = refreshConfirm;
		this.RefreshEnter = refreshEnter;
		this.IsMulti = isMulti;
	}

	// Token: 0x0600A886 RID: 43142 RVA: 0x003197B1 File Offset: 0x003179B1
	public bool ShouldActivate()
	{
		return this.IsMulti();
	}

	// Token: 0x0600A887 RID: 43143 RVA: 0x003197C0 File Offset: 0x003179C0
	public void OnViewStart()
	{
		this.ChatNotice = new ChatNoticeComponent(this.RootItem, this.ChatInfoItem, this.ChatInfoText);
		this.MatchPanel = new MatchPanelComponent(this.GetRoleSlots);
		EventSystem.Instance.Add(EEventName.OnPushChatRowData, new Action<ChatRowData>(this.OnPushChatRowData));
		EventSystem.Instance.Add(EEventName.MatchTeamFlagChange, new Action<bool>(this.MatchTeamFlagChange));
		EventSystem.Instance.Add(EEventName.OnRefreshPlayerUiState, new Action<int>(this.OnRefreshPlayerUiState));
		EventSystem.Instance.Add(EEventName.OnRefreshEditBattleRoleReady, new Action<int, bool>(this.OnRefreshEditBattleRoleReady));
		EventSystem.Instance.Add(EEventName.ScenePlayerLeaveScene, new Action<int>(this.ScenePlayerLeaveScene));
	}

	// Token: 0x0600A888 RID: 43144 RVA: 0x00319888 File Offset: 0x00317A88
	public void OnViewRefresh()
	{
		bool editBattleTeamMatching = InstanceDungeonEntranceModel.Instance.EditBattleTeamMatching;
		MatchPanelComponent matchPanel = this.MatchPanel;
		if (matchPanel == null)
		{
			return;
		}
		matchPanel.Refresh(editBattleTeamMatching);
	}

	// Token: 0x0600A889 RID: 43145 RVA: 0x003198B4 File Offset: 0x00317AB4
	public void OnDetach()
	{
		if (this.ChatNotice == null)
		{
			return;
		}
		EventSystem.Instance.Remove(EEventName.OnPushChatRowData, new Action<ChatRowData>(this.OnPushChatRowData));
		EventSystem.Instance.Remove(EEventName.MatchTeamFlagChange, new Action<bool>(this.MatchTeamFlagChange));
		EventSystem.Instance.Remove(EEventName.OnRefreshPlayerUiState, new Action<int>(this.OnRefreshPlayerUiState));
		EventSystem.Instance.Remove(EEventName.OnRefreshEditBattleRoleReady, new Action<int, bool>(this.OnRefreshEditBattleRoleReady));
		EventSystem.Instance.Remove(EEventName.ScenePlayerLeaveScene, new Action<int>(this.ScenePlayerLeaveScene));
		this.ChatNotice.Destroy();
		this.ChatNotice = null;
		this.MatchPanel = null;
	}

	// Token: 0x0600A88A RID: 43146 RVA: 0x0031996F File Offset: 0x00317B6F
	public void OnClickChat()
	{
		if (UiManager.Instance.IsViewShow(EUiViewName.ChatView))
		{
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.ChatView, null, null);
	}

	// Token: 0x0600A88B RID: 43147 RVA: 0x00319994 File Offset: 0x00317B94
	public void OnClickAddPlayer()
	{
		InstanceDungeonEntranceModel.Instance.SetEditBattleTeamMatching(true);
		InstanceDungeonEntranceController.Instance.SetMatchTeamMatchFlagRequest(InstanceDungeonEntranceModel.Instance.EditBattleTeamMatching);
	}

	// Token: 0x0600A88C RID: 43148 RVA: 0x003199B8 File Offset: 0x00317BB8
	public void OnClickInvite()
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		if (serverTime - this.RequestTimeStamp > (double)OnlineModel.Instance.ApplyCd)
		{
			InstanceDungeonEntranceController.Instance.TeamMatchInviteRequest();
			this.RequestTimeStamp = serverTime;
			ScrollingTipsController.Instance.ShowTipsById("HaveMatched", Array.Empty<object>());
			return;
		}
		ScrollingTipsController.Instance.ShowTipsById("MatchingInviteCd", Array.Empty<object>());
	}

	// Token: 0x0600A88D RID: 43149 RVA: 0x00319A1F File Offset: 0x00317C1F
	private void OnPushChatRowData(ChatRowData chatRowData)
	{
		ChatNoticeComponent chatNotice = this.ChatNotice;
		if (chatNotice == null)
		{
			return;
		}
		chatNotice.HandlePushChatRowData(chatRowData);
	}

	// Token: 0x0600A88E RID: 43150 RVA: 0x00319A32 File Offset: 0x00317C32
	private void MatchTeamFlagChange(bool isMatching)
	{
		this.RefreshConfirm();
		this.RefreshEnter();
		MatchPanelComponent matchPanel = this.MatchPanel;
		if (matchPanel == null)
		{
			return;
		}
		matchPanel.Refresh(isMatching);
	}

	// Token: 0x0600A88F RID: 43151 RVA: 0x00319A5C File Offset: 0x00317C5C
	private void OnRefreshPlayerUiState(int playerId)
	{
		InstanceDungeonModel instance = InstanceDungeonModel.Instance;
		int hostId = instance.GetMatchTeamInfo().HostId;
		foreach (FormationRoleSlot formationRoleSlot in this.GetRoleSlots())
		{
			int valueOrDefault = formationRoleSlot.GetPlayer().GetValueOrDefault(-1);
			if (valueOrDefault == playerId)
			{
				formationRoleSlot.RefreshPrepareState(new EMatchPlayerUiState?(instance.GetPlayerUiState(valueOrDefault)));
			}
			else if (playerId == hostId)
			{
				int valueOrDefault2 = formationRoleSlot.GetPlayer().GetValueOrDefault(hostId);
				formationRoleSlot.RefreshPrepareState(new EMatchPlayerUiState?(instance.GetPlayerUiState(valueOrDefault2)));
			}
		}
	}

	// Token: 0x0600A890 RID: 43152 RVA: 0x00319B14 File Offset: 0x00317D14
	private void OnRefreshEditBattleRoleReady(int position, bool bReady)
	{
		this.RefreshConfirm();
		this.RefreshEnter();
	}

	// Token: 0x0600A891 RID: 43153 RVA: 0x00319B2C File Offset: 0x00317D2C
	private void ScenePlayerLeaveScene(int playerId)
	{
		this.RefreshConfirm();
	}

	// Token: 0x040061E3 RID: 25059
	[Nullable(2)]
	private ChatNoticeComponent ChatNotice;

	// Token: 0x040061E4 RID: 25060
	[Nullable(2)]
	private MatchPanelComponent MatchPanel;

	// Token: 0x040061E5 RID: 25061
	private double RequestTimeStamp;

	// Token: 0x040061E6 RID: 25062
	private readonly UUIItem RootItem;

	// Token: 0x040061E7 RID: 25063
	private readonly UUIItem ChatInfoItem;

	// Token: 0x040061E8 RID: 25064
	private readonly UUIText ChatInfoText;

	// Token: 0x040061E9 RID: 25065
	private readonly Func<List<FormationRoleSlot>> GetRoleSlots;

	// Token: 0x040061EA RID: 25066
	private readonly Action RefreshConfirm;

	// Token: 0x040061EB RID: 25067
	private readonly Action RefreshEnter;

	// Token: 0x040061EC RID: 25068
	private readonly Func<bool> IsMulti;
}
