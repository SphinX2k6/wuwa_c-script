using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020017D2 RID: 6098
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class OnlineHallItem : GridProxyAbstract<OnlineHallData>
{
	// Token: 0x0600EE76 RID: 61046 RVA: 0x0045EB9C File Offset: 0x0045CD9C
	public OnlineHallItem(EUiViewName belongView)
	{
		this.BelongView = new EUiViewName?(belongView);
	}

	// Token: 0x0600EE77 RID: 61047 RVA: 0x0045EBB0 File Offset: 0x0045CDB0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 26;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIInteractionGroup));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(23, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickApplyEnterBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(22, new Action(this.OnClickItemBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600EE78 RID: 61048 RVA: 0x0045EFA4 File Offset: 0x0045D1A4
	protected override UniTask OnBeforeStartAsync()
	{
		OnlineHallItem.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<OnlineHallItem.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600EE79 RID: 61049 RVA: 0x0045EFE8 File Offset: 0x0045D1E8
	protected override void OnStart()
	{
		base.GetText(1).SetUIActive(false);
		base.GetSprite(19).SetUIActive(false);
		base.GetButton(16).RootUIComp.Get().SetUIActive(false);
		base.GetButton(14).RootUIComp.Get().SetUIActive(false);
		base.GetButton(15).RootUIComp.Get().SetUIActive(false);
		base.GetItem(18).SetUIActive(true);
		this.CountDown = base.GetText(11);
	}

	// Token: 0x0600EE7A RID: 61050 RVA: 0x0045F080 File Offset: 0x0045D280
	protected override void OnBeforeDestroy()
	{
		this.OnlineHallData = null;
		this.BelongView = null;
		if (this.CountDownTimer != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.CountDownTimer);
		}
		this.CountDownTimer = null;
		PlayerTitleItem titleItem = this.TitleItem;
		if (titleItem == null)
		{
			return;
		}
		titleItem.Destroy(null);
	}

	// Token: 0x0600EE7B RID: 61051 RVA: 0x0045F0D4 File Offset: 0x0045D2D4
	private void UpdateCountDown(float _)
	{
		if (this.OnlineHallData == null)
		{
			if (this.CountDownTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.CountDownTimer);
			}
			this.CountDownTimer = null;
			return;
		}
		if (this.OnlineHallData.ApplyTimeLeftTime > 0.0)
		{
			this.CountDown.SetText(TimeUtil.Instance.GetCoolDown(this.OnlineHallData.ApplyTimeLeftTime), true);
			return;
		}
		this.ShowApplyBtn(true);
		if (this.CountDownTimer != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.CountDownTimer);
		}
		this.CountDownTimer = null;
	}

	// Token: 0x0600EE7C RID: 61052 RVA: 0x0045F16C File Offset: 0x0045D36C
	[NullableContext(1)]
	public override void Refresh(OnlineHallData data, bool isSelected, int gridIndex)
	{
		this.OnlineHallData = data;
		if (this.OnlineHallData.ApplyTimeLeftTime > 0.0)
		{
			this.ShowApplyBtn(false);
			this.CountDownTimer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.UpdateCountDown), 100f, 1f, null, null, true);
		}
		else
		{
			this.ShowApplyBtn(true);
		}
		PlayerHeadData playerHeadData = PersonalModel.Instance.GetPlayerHeadData(data.HeadId, false);
		if (playerHeadData != null)
		{
			base.SetTextureByPath(playerHeadData.GetRoleHeadIconCircle(), base.GetTexture(3), null, null);
		}
		bool flag = FriendModel.Instance.IsMyFriend(data.PlayerId);
		UUIText text = base.GetText(0);
		if (flag)
		{
			FriendData friendById = FriendModel.Instance.GetFriendById(data.PlayerId);
			string text2 = (friendById != null) ? friendById.FriendRemark : null;
			if (text2 != null && text2 != "")
			{
				LguiUtil.Instance.SetLocalText(text, "NameMark", new <>z__ReadOnlySingleElementList<object>(text2));
			}
			else
			{
				text.SetText(data.Name, true);
			}
		}
		else
		{
			text.SetText(data.Name, true);
		}
		PlayerTitleItem titleItem = this.TitleItem;
		if (titleItem != null)
		{
			titleItem.Refresh(new int?(data.PlayerTitleId), new int?(data.PlayerTitleStarLevel), new int?(data.Sex));
		}
		UUIText text3 = base.GetText(2);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
		defaultInterpolatedStringHandler.AppendLiteral("Lv.");
		defaultInterpolatedStringHandler.AppendFormatted<int>(data.Level);
		text3.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		UUIText text4 = base.GetText(7);
		if (data.Signature == null || data.Signature == "")
		{
			base.GetItem(20).SetUIActive(false);
		}
		else
		{
			text4.SetText(data.Signature, true);
			base.GetItem(20).SetUIActive(true);
		}
		UUIItem item = base.GetItem(5);
		UUIItem item2 = base.GetItem(6);
		EPlayerCount playerCount = (EPlayerCount)data.PlayerCount;
		if (playerCount != EPlayerCount.TwoPlayer)
		{
			if (playerCount != EPlayerCount.ThreePlayer)
			{
				item.SetUIActive(false);
				item2.SetUIActive(false);
			}
			else
			{
				item.SetUIActive(true);
				item2.SetUIActive(true);
			}
		}
		else
		{
			item.SetUIActive(true);
			item2.SetUIActive(false);
		}
		int originWorldLevel = WorldLevelModel.Instance.OriginWorldLevel;
		int enterDiff = OnlineModel.Instance.EnterDiff;
		UUIInteractionGroup interactionGroup = base.GetInteractionGroup(8);
		UUIText text5 = base.GetText(9);
		if (data.WorldLevel > originWorldLevel + enterDiff)
		{
			interactionGroup.SetInteractable(false);
			int num = data.WorldLevel - enterDiff;
			LguiUtil.Instance.SetLocalText(text5, "ApplyBtnDisable", new <>z__ReadOnlySingleElementList<object>(num));
		}
		else
		{
			LguiUtil.Instance.SetLocalText(text5, "ApplyBtnEnable", Array.Empty<object>());
			interactionGroup.SetInteractable(true);
		}
		int playerCard = data.PlayerCard;
		if (playerCard > 0)
		{
			base.SetTextureByPath(ConfigBackgroundCardById.GetConfig(playerCard, true).Value.LongCardPath, base.GetTexture(21), null, null);
		}
		this.RefreshThirdPartyItem(data);
		this.RefreshPcItem(data);
	}

	// Token: 0x0600EE7D RID: 61053 RVA: 0x0045F464 File Offset: 0x0045D664
	private void ShowApplyBtn(bool show)
	{
		base.GetButton(4).RootUIComp.Get().SetUIActive(show);
		base.GetItem(12).SetUIActive(show);
		base.GetItem(10).SetUIActive(!show);
	}

	// Token: 0x0600EE7E RID: 61054 RVA: 0x0045F4AC File Offset: 0x0045D6AC
	private void OnClickApplyEnterBtn()
	{
		if (this.BelongView == EUiViewName.OnlineWorldHallView)
		{
			OnlineController.Instance.ApplyJoinWorldRequest(this.OnlineHallData.PlayerId, (OnlineModel.Instance.ShowFriend || OnlineModel.Instance.HallViewIsShowSearching) ? WorldEnterWay.QueryJoin : WorldEnterWay.LobbyJoin);
		}
		else
		{
			OnlineController.Instance.ApplyJoinWorldRequest(this.OnlineHallData.PlayerId, WorldEnterWay.QueryJoin);
		}
		this.OnlineHallData.SetApplyTime(TimeUtil.Instance.GetServerTime() + (double)OnlineModel.Instance.ApplyCd);
		this.ShowApplyBtn(false);
		this.CountDown.SetText(TimeUtil.Instance.GetCoolDown(this.OnlineHallData.ApplyTimeLeftTime), true);
		this.CountDownTimer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.UpdateCountDown), 100f, 1f, null, null, true);
	}

	// Token: 0x0600EE7F RID: 61055 RVA: 0x0045F59C File Offset: 0x0045D79C
	private void OnClickItemBtn()
	{
		OnlineModel.Instance.CachePlayerData = this.OnlineHallData;
		int playerId = this.OnlineHallData.PlayerId;
		FriendController.Instance.RequestPlayerCurrentDeactivationState(playerId, delegate(bool deactivation)
		{
			if (deactivation)
			{
				string localTextNew = ConfigMultiTextLang.GetLocalTextNew("PlayerDeleteSelf", null);
				GenericPromptController.Instance.ShowPromptByItsType<object>(EPromptSubViewType.FloatLinePrompt, null, null, new <>z__ReadOnlySingleElementList<object>(localTextNew), null, null, null, null, null, false, null);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.OnlineProcessView, null, null);
		});
	}

	// Token: 0x0600EE80 RID: 61056 RVA: 0x0045F5F0 File Offset: 0x0045D7F0
	[NullableContext(1)]
	private void RefreshThirdPartyItem(OnlineHallData data)
	{
		KuroSdkController instance = KuroSdkController.Instance;
		if (((instance != null) ? new bool?(instance.NeedShowThirdPartyId()) : null).GetValueOrDefault())
		{
			bool flag = (Info.Instance.IsPs5Platform() ? data.PlayerDetails.PsnUserId : data.PlayerDetails.XboxUserId) != "";
			UUITexture texture = base.GetTexture(23);
			if (texture != null)
			{
				texture.SetUIActive(flag);
			}
			UUIText text = base.GetText(24);
			if (text != null)
			{
				text.SetUIActive(flag);
			}
			if (flag)
			{
				string text2 = Info.Instance.IsPs5Platform() ? data.PlayerDetails.PsnOnlineId : data.PlayerDetails.XboxOnlineId;
				UUIText text3 = base.GetText(24);
				if (text3 != null)
				{
					text3.SetText(text2 ?? "", true);
				}
			}
			string thirdPartyLogoTexturePath = UiResourceConfig.Instance.GetThirdPartyLogoTexturePath(ELogoSize.Medium);
			base.SetTextureByPath(thirdPartyLogoTexturePath, base.GetTexture(23), null, null);
			string thirdPartyTextColor = UiResourceConfig.Instance.GetThirdPartyTextColor(EConsoleColorSet.Set1);
			UUIText text4 = base.GetText(24);
			if (text4 == null)
			{
				return;
			}
			text4.SetColor(FColor.FromHex(thirdPartyTextColor));
			return;
		}
		else
		{
			UUITexture texture2 = base.GetTexture(23);
			if (texture2 != null)
			{
				texture2.SetUIActive(false);
			}
			UUIText text5 = base.GetText(24);
			if (text5 == null)
			{
				return;
			}
			text5.SetUIActive(false);
			return;
		}
	}

	// Token: 0x0600EE81 RID: 61057 RVA: 0x0045F73C File Offset: 0x0045D93C
	[NullableContext(1)]
	private void RefreshPcItem(OnlineHallData data)
	{
		KuroSdkController instance = KuroSdkController.Instance;
		if (((instance != null) ? new bool?(instance.NeedShowThirdPartyId()) : null).GetValueOrDefault())
		{
			if ((Info.Instance.IsPs5Platform() ? data.PlayerDetails.PsnUserId : data.PlayerDetails.XboxUserId) != "")
			{
				UUIItem item = base.GetItem(25);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(false);
				return;
			}
			else
			{
				UUIItem item2 = base.GetItem(25);
				if (item2 == null)
				{
					return;
				}
				item2.SetUIActive(true);
				return;
			}
		}
		else
		{
			UUIItem item3 = base.GetItem(25);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(false);
			return;
		}
	}

	// Token: 0x040086FB RID: 34555
	private const int TICK_INTERVAL_TIME = 100;

	// Token: 0x040086FC RID: 34556
	private OnlineHallData OnlineHallData;

	// Token: 0x040086FD RID: 34557
	private EUiViewName? BelongView;

	// Token: 0x040086FE RID: 34558
	private UUIText CountDown;

	// Token: 0x040086FF RID: 34559
	private TimerHandle CountDownTimer;

	// Token: 0x04008700 RID: 34560
	private PlayerTitleItem TitleItem;

	// Token: 0x020079E7 RID: 31207
	[NullableContext(0)]
	private enum EOnlineHallItem
	{
		// Token: 0x04027813 RID: 161811
		PlayerName,
		// Token: 0x04027814 RID: 161812
		TipText,
		// Token: 0x04027815 RID: 161813
		Level,
		// Token: 0x04027816 RID: 161814
		RoleHead,
		// Token: 0x04027817 RID: 161815
		ApplyEnterBtn,
		// Token: 0x04027818 RID: 161816
		PlayerCount2,
		// Token: 0x04027819 RID: 161817
		PlayerCount3,
		// Token: 0x0402781A RID: 161818
		Sign,
		// Token: 0x0402781B RID: 161819
		ApplyEnterBtnInteraction,
		// Token: 0x0402781C RID: 161820
		ApplyEnterBtnText,
		// Token: 0x0402781D RID: 161821
		ApplyCountDown,
		// Token: 0x0402781E RID: 161822
		ApplyCountDownText,
		// Token: 0x0402781F RID: 161823
		TeamCount,
		// Token: 0x04027820 RID: 161824
		TeamItem,
		// Token: 0x04027821 RID: 161825
		OperationBtn,
		// Token: 0x04027822 RID: 161826
		ExitBtn,
		// Token: 0x04027823 RID: 161827
		KickOutBtn,
		// Token: 0x04027824 RID: 161828
		PlayerSprite,
		// Token: 0x04027825 RID: 161829
		HallItem,
		// Token: 0x04027826 RID: 161830
		NetStateSprite,
		// Token: 0x04027827 RID: 161831
		SignTeamItem,
		// Token: 0x04027828 RID: 161832
		PlayerTextureBg,
		// Token: 0x04027829 RID: 161833
		BtnPlayerHead,
		// Token: 0x0402782A RID: 161834
		ThirdPartyTexture,
		// Token: 0x0402782B RID: 161835
		ThirdPartyText,
		// Token: 0x0402782C RID: 161836
		PcItem,
		// Token: 0x0402782D RID: 161837
		PlayerTitleItem
	}
}
