using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020017CE RID: 6094
[NullableContext(2)]
[Nullable(0)]
public class OnlineChallengeApplyView : UiTickViewBase
{
	// Token: 0x0600EE5A RID: 61018 RVA: 0x0045DC8C File Offset: 0x0045BE8C
	[NullableContext(1)]
	public OnlineChallengeApplyView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EE5B RID: 61019 RVA: 0x0045DCAC File Offset: 0x0045BEAC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 13;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickHandleBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickCancelBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600EE5C RID: 61020 RVA: 0x0045DEE8 File Offset: 0x0045C0E8
	protected override void OnStart()
	{
		base.GetButton(8).GetRootComponent().SetUIActive(true);
		this.CountDown = base.GetText(5);
		this.CountDownBar = base.GetSprite(6);
		if (GameModeController.Instance.IsInInstance())
		{
			this.CountDownNumber = (float)OnlineModel.Instance.ApplyCd;
			this.CountDownNumberMax = (float)OnlineModel.Instance.ApplyCd;
			this.RefreshViewInInstance();
			return;
		}
		int value = ConfigCommonParamById.GetIntConfig("match_confirm_time_out_seconds").Value;
		this.CountDownNumber = (float)value;
		this.CountDownNumberMax = (float)value;
		this.RefreshViewOutInstance();
	}

	// Token: 0x0600EE5D RID: 61021 RVA: 0x0045DF7F File Offset: 0x0045C17F
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshSuggestChallengePlayerInfo, new Action(this.OnRefreshSuggestChallengePlayerInfo));
		EventSystem.Instance.Add<PlotInfo>(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.PlotNetworkStart));
	}

	// Token: 0x0600EE5E RID: 61022 RVA: 0x0045DFB9 File Offset: 0x0045C1B9
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshSuggestChallengePlayerInfo, new Action(this.OnRefreshSuggestChallengePlayerInfo));
		EventSystem.Instance.Remove(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.PlotNetworkStart));
	}

	// Token: 0x0600EE5F RID: 61023 RVA: 0x0045DFF4 File Offset: 0x0045C1F4
	protected override void OnTick(float delta)
	{
		if (this.IsViewClose)
		{
			return;
		}
		this.CountDownNumber -= delta * (float)TimeUtil.Instance.Millisecond;
		if (this.CountDownNumber <= 0f)
		{
			if (!GameModeController.Instance.IsInInstance())
			{
				InstanceDungeonEntranceController.Instance.TeamMatchAcceptInviteRequest(false, false);
			}
			else
			{
				OnlineController.Instance.ReceiveRechallengeRequest(false, false);
			}
			base.CloseMe(null);
			this.IsViewClose = true;
			return;
		}
		this.CountDown.SetText(TimeUtil.Instance.GetCoolDown((double)this.CountDownNumber), true);
		this.CountDownBar.SetFillAmount(this.CountDownNumber / this.CountDownNumberMax);
	}

	// Token: 0x0600EE60 RID: 61024 RVA: 0x0045E09C File Offset: 0x0045C29C
	private void RefreshViewInInstance()
	{
		UUIItem item = base.GetItem(3);
		UUIItem item2 = base.GetItem(4);
		UUIText text = base.GetText(7);
		item.SetUIActive(true);
		item2.SetUIActive(false);
		if (!SceneTeamModel.Instance.IsAllDid())
		{
			if (CreatureModel.Instance.IsMyWorld())
			{
				LguiUtil.Instance.SetLocalText(text, "SuggestContinueChallenge", Array.Empty<object>());
			}
			else
			{
				LguiUtil.Instance.SetLocalText(text, "InviteContinueChallenge", Array.Empty<object>());
			}
		}
		else if (CreatureModel.Instance.IsMyWorld())
		{
			LguiUtil.Instance.SetLocalText(text, "SuggestChallengeAgain", Array.Empty<object>());
		}
		else
		{
			LguiUtil.Instance.SetLocalText(text, "InviteChallengeAgain", Array.Empty<object>());
		}
		int challengeApplyPlayerId = OnlineModel.Instance.ChallengeApplyPlayerId;
		OnlineTeamData currentTeamListById = OnlineModel.Instance.GetCurrentTeamListById(challengeApplyPlayerId);
		if (currentTeamListById == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MultiPlayerTeam;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "未找到发起邀请的玩家";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("playerId：", challengeApplyPlayerId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		base.GetText(1).SetText(currentTeamListById.Name, true);
		this.CountDown.SetText(TimeUtil.Instance.GetCoolDown((double)this.CountDownNumber), true);
		this.CountDownBar.SetFillAmount(this.CountDownNumber / this.CountDownNumberMax);
		PlayerHeadData playerHeadData = PersonalModel.Instance.GetPlayerHeadData(currentTeamListById.HeadId, false);
		if (playerHeadData != null)
		{
			base.SetTextureByPath(playerHeadData.GetRoleHeadIconCircle(), base.GetTexture(0), null, null);
		}
		this.RefreshThirdPartyItem(currentTeamListById.ThirdPartyOnlineId, currentTeamListById.ThirdPartyUserId);
		this.RefreshPcItem(currentTeamListById.ThirdPartyOnlineId);
	}

	// Token: 0x0600EE61 RID: 61025 RVA: 0x0045E230 File Offset: 0x0045C430
	private void RefreshThirdPartyItem(string onlineId, string userId)
	{
		if (KuroSdkController.Instance.NeedShowThirdPartyId())
		{
			bool flag = userId != null && userId != "";
			UUIItem item = base.GetItem(16);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			if (flag)
			{
				string newText = onlineId ?? "";
				UUIText text = base.GetText(17);
				if (text != null)
				{
					text.SetText(newText, true);
				}
			}
			string thirdPartyLogoTexturePath = UiResourceConfig.Instance.GetThirdPartyLogoTexturePath(ELogoSize.Medium);
			base.SetTextureByPath(thirdPartyLogoTexturePath, base.GetTexture(18), null, null);
			string thirdPartyTextColor = UiResourceConfig.Instance.GetThirdPartyTextColor(EConsoleColorSet.Set1);
			UUIText text2 = base.GetText(17);
			if (text2 == null)
			{
				return;
			}
			text2.SetColor(FColor.FromHex(thirdPartyTextColor));
			return;
		}
		else
		{
			UUIItem item2 = base.GetItem(16);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
			return;
		}
	}

	// Token: 0x0600EE62 RID: 61026 RVA: 0x0045E2F4 File Offset: 0x0045C4F4
	private void RefreshPcItem(string onlineId)
	{
		KuroSdkController instance = KuroSdkController.Instance;
		if (((instance != null) ? new bool?(instance.NeedShowThirdPartyId()) : null).GetValueOrDefault())
		{
			bool flag = onlineId != null && onlineId != "";
			UUIItem item = base.GetItem(15);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(!flag);
			return;
		}
		else
		{
			UUIItem item2 = base.GetItem(15);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
			return;
		}
	}

	// Token: 0x0600EE63 RID: 61027 RVA: 0x0045E368 File Offset: 0x0045C568
	private void RefreshViewOutInstance()
	{
		UUIItem item = base.GetItem(3);
		UUIItem item2 = base.GetItem(4);
		item.SetUIActive(true);
		item2.SetUIActive(false);
		UUIText text = base.GetText(1);
		LguiUtil.Instance.SetLocalText(text, "TeamLeaderInviteToInstance", Array.Empty<object>());
		UUIText text2 = base.GetText(7);
		int instanceId = InstanceDungeonModel.Instance.GetInstanceId();
		string text3 = ConfigMultiTextLang.GetLocalTextNew(InstanceDungeonConfig.Instance.GetConfig(instanceId).Value.MapName, null);
		text3 += OnlineModel.Instance.GetMultiInstanceRecommendLevelText(instanceId);
		text2.SetText(text3, true);
		int ownerId = OnlineModel.Instance.OwnerId;
		OnlineTeamData currentTeamListById = OnlineModel.Instance.GetCurrentTeamListById(ownerId);
		if (currentTeamListById == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MultiPlayerTeam;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "未找到发起邀请的玩家";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("playerId：", ownerId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			UUIItem item3 = base.GetItem(16);
			if (item3 != null)
			{
				item3.SetUIActive(false);
			}
			UUIItem item4 = base.GetItem(15);
			if (item4 == null)
			{
				return;
			}
			item4.SetUIActive(false);
			return;
		}
		else
		{
			this.CountDown.SetText(TimeUtil.Instance.GetCoolDown((double)this.CountDownNumber), true);
			this.CountDownBar.SetFillAmount(this.CountDownNumber / this.CountDownNumberMax);
			PlayerHeadData playerHeadData = PersonalModel.Instance.GetPlayerHeadData(currentTeamListById.HeadId, false);
			if (playerHeadData != null)
			{
				base.SetTextureByPath(playerHeadData.GetRoleHeadIconCircle(), base.GetTexture(0), null, null);
			}
			UUIItem item5 = base.GetItem(16);
			if (item5 != null)
			{
				item5.SetUIActive(false);
			}
			UUIItem item6 = base.GetItem(15);
			if (item6 == null)
			{
				return;
			}
			item6.SetUIActive(false);
			return;
		}
	}

	// Token: 0x0600EE64 RID: 61028 RVA: 0x0045E508 File Offset: 0x0045C708
	private void OnClickHandleBtn()
	{
		if (GameModeController.Instance.IsInInstance())
		{
			EContinuingChallenge? continuingChallengeConfirmState = OnlineModel.Instance.GetContinuingChallengeConfirmState(PlayerInfoModel.Instance.GetId().Value);
			EContinuingChallenge econtinuingChallenge = EContinuingChallenge.Accept;
			if ((continuingChallengeConfirmState.GetValueOrDefault() == econtinuingChallenge & continuingChallengeConfirmState != null) && OnlineModel.Instance.GetIsMyTeam())
			{
				OnlineController.Instance.InviteRechallengeRequest();
				return;
			}
			OnlineController.Instance.ReceiveRechallengeRequest(true, false);
		}
		else
		{
			InstanceDungeonEntranceController.Instance.TeamMatchAcceptInviteRequest(true, false);
		}
		base.CloseMe(null);
	}

	// Token: 0x0600EE65 RID: 61029 RVA: 0x0045E58C File Offset: 0x0045C78C
	private void OnClickCancelBtn()
	{
		if (!GameModeController.Instance.IsInInstance())
		{
			InstanceDungeonEntranceController.Instance.TeamMatchAcceptInviteRequest(false, true);
		}
		else
		{
			OnlineController.Instance.ReceiveRechallengeRequest(false, true);
		}
		base.CloseMe(null);
	}

	// Token: 0x0600EE66 RID: 61030 RVA: 0x0045E5BC File Offset: 0x0045C7BC
	private void OnRefreshSuggestChallengePlayerInfo()
	{
		if (GameModeController.Instance.IsInInstance())
		{
			this.CountDownNumber = (float)OnlineModel.Instance.ApplyCd;
			this.RefreshViewInInstance();
			return;
		}
		int value = ConfigCommonParamById.GetIntConfig("match_confirm_time_out_seconds").Value;
		this.CountDownNumber = (float)value;
		this.RefreshViewOutInstance();
	}

	// Token: 0x0600EE67 RID: 61031 RVA: 0x0045E60E File Offset: 0x0045C80E
	[NullableContext(1)]
	private void PlotNetworkStart(PlotInfo plotInfo)
	{
		base.CloseMe(null);
	}

	// Token: 0x040086ED RID: 34541
	private float CountDownNumber = -1f;

	// Token: 0x040086EE RID: 34542
	private float CountDownNumberMax = -1f;

	// Token: 0x040086EF RID: 34543
	private UUIText CountDown;

	// Token: 0x040086F0 RID: 34544
	private UUISprite CountDownBar;

	// Token: 0x040086F1 RID: 34545
	private bool IsViewClose;

	// Token: 0x020079E4 RID: 31204
	[NullableContext(0)]
	private enum EOnlineChallengeApplyView
	{
		// Token: 0x040277FB RID: 161787
		RoleTexture,
		// Token: 0x040277FC RID: 161788
		PlayerName,
		// Token: 0x040277FD RID: 161789
		HandleBtn,
		// Token: 0x040277FE RID: 161790
		ApplySprite,
		// Token: 0x040277FF RID: 161791
		MoreSprite,
		// Token: 0x04027800 RID: 161792
		CountDown,
		// Token: 0x04027801 RID: 161793
		CountDownProgressBar,
		// Token: 0x04027802 RID: 161794
		MultipleApplyText,
		// Token: 0x04027803 RID: 161795
		CancelBtn,
		// Token: 0x04027804 RID: 161796
		TexturePc = 15,
		// Token: 0x04027805 RID: 161797
		ThirdPartyItem,
		// Token: 0x04027806 RID: 161798
		ThirdPartyText,
		// Token: 0x04027807 RID: 161799
		ThirdPartyTexture
	}
}
