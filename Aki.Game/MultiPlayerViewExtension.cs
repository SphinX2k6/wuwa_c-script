using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using UnrealEngine;

// Token: 0x02001BD7 RID: 7127
[NullableContext(1)]
[Nullable(0)]
public class MultiPlayerViewExtension : IViewExtension
{
	// Token: 0x0600D473 RID: 54387 RVA: 0x0030E600 File Offset: 0x0030C800
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

	// Token: 0x0600D474 RID: 54388 RVA: 0x0030E63D File Offset: 0x0030C83D
	public bool ShouldActivate()
	{
		return this.IsMulti();
	}

	// Token: 0x0600D475 RID: 54389 RVA: 0x0030E64C File Offset: 0x0030C84C
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

	// Token: 0x0600D476 RID: 54390 RVA: 0x0030E714 File Offset: 0x0030C914
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

	// Token: 0x0600D477 RID: 54391 RVA: 0x0030E740 File Offset: 0x0030C940
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

	// Token: 0x0600D478 RID: 54392 RVA: 0x0030E7FB File Offset: 0x0030C9FB
	public void OnClickChat()
	{
		if (UiManager.Instance.IsViewShow(EUiViewName.ChatView))
		{
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.ChatView, null, null);
	}

	// Token: 0x0600D479 RID: 54393 RVA: 0x0030E820 File Offset: 0x0030CA20
	public void OnClickAddPlayer()
	{
		InstanceDungeonEntranceModel.Instance.SetEditBattleTeamMatching(true);
		InstanceDungeonEntranceController.Instance.SetMatchTeamMatchFlagRequest(InstanceDungeonEntranceModel.Instance.EditBattleTeamMatching);
	}

	// Token: 0x0600D47A RID: 54394 RVA: 0x0030E844 File Offset: 0x0030CA44
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

	// Token: 0x0600D47B RID: 54395 RVA: 0x0030E8AB File Offset: 0x0030CAAB
	private void OnPushChatRowData(ChatRowData chatRowData)
	{
		ChatNoticeComponent chatNotice = this.ChatNotice;
		if (chatNotice == null)
		{
			return;
		}
		chatNotice.HandlePushChatRowData(chatRowData);
	}

	// Token: 0x0600D47C RID: 54396 RVA: 0x0030E8BE File Offset: 0x0030CABE
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

	// Token: 0x0600D47D RID: 54397 RVA: 0x0030E8E8 File Offset: 0x0030CAE8
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

	// Token: 0x0600D47E RID: 54398 RVA: 0x0030E9A0 File Offset: 0x0030CBA0
	private void OnRefreshEditBattleRoleReady(int position, bool bReady)
	{
		this.RefreshConfirm();
		this.RefreshEnter();
	}

	// Token: 0x0600D47F RID: 54399 RVA: 0x0030E9B8 File Offset: 0x0030CBB8
	private void ScenePlayerLeaveScene(int playerId)
	{
		this.RefreshConfirm();
	}

	// Token: 0x04006114 RID: 24852
	[Nullable(2)]
	private ChatNoticeComponent ChatNotice;

	// Token: 0x04006115 RID: 24853
	[Nullable(2)]
	private MatchPanelComponent MatchPanel;

	// Token: 0x04006116 RID: 24854
	private double RequestTimeStamp;

	// Token: 0x04006117 RID: 24855
	private readonly UUIItem RootItem;

	// Token: 0x04006118 RID: 24856
	private readonly UUIItem ChatInfoItem;

	// Token: 0x04006119 RID: 24857
	private readonly UUIText ChatInfoText;

	// Token: 0x0400611A RID: 24858
	private readonly Func<List<FormationRoleSlot>> GetRoleSlots;

	// Token: 0x0400611B RID: 24859
	private readonly Action RefreshConfirm;

	// Token: 0x0400611C RID: 24860
	private readonly Action RefreshEnter;

	// Token: 0x0400611D RID: 24861
	private readonly Func<bool> IsMulti;
}
