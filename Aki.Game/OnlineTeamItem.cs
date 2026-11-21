using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020017DB RID: 6107
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class OnlineTeamItem : GridProxyAbstract<OnlineTeamData>
{
	// Token: 0x0600EEFE RID: 61182 RVA: 0x00462690 File Offset: 0x00460890
	protected unsafe override void OnRegisterComponent()
	{
		int num = 19;
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
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
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
		num2 = 4;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(14, new Action(this.OnClickOperationBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(16, new Action(this.OnClickKickOutBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(22, new Action(this.OnClickItemBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(15, new Action(this.OnClickExitBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600EEFF RID: 61183 RVA: 0x004629E4 File Offset: 0x00460BE4
	protected override UniTask OnBeforeStartAsync()
	{
		OnlineTeamItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<OnlineTeamItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600EF00 RID: 61184 RVA: 0x00462A27 File Offset: 0x00460C27
	protected override void OnStart()
	{
		base.GetItem(18).SetUIActive(false);
		base.GetItem(13).SetUIActive(true);
		this.AddEventListener();
	}

	// Token: 0x0600EF01 RID: 61185 RVA: 0x00462A4B File Offset: 0x00460C4B
	protected void AddEventListener()
	{
		EventSystem.Instance.Add<int, ENetPingState>(EEventName.OnRefreshPlayerPing, new Action<int, ENetPingState>(this.OnRefreshPlayerPing));
	}

	// Token: 0x0600EF02 RID: 61186 RVA: 0x00462A69 File Offset: 0x00460C69
	protected void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshPlayerPing, new Action<int, ENetPingState>(this.OnRefreshPlayerPing));
	}

	// Token: 0x0600EF03 RID: 61187 RVA: 0x00462A87 File Offset: 0x00460C87
	protected override void OnBeforeDestroy()
	{
		this.RemoveEventListener();
		PlayerTitleItem titleItem = this.TitleItem;
		if (titleItem != null)
		{
			titleItem.Destroy(null);
		}
		this.TitleItem = null;
	}

	// Token: 0x0600EF04 RID: 61188 RVA: 0x00462AA8 File Offset: 0x00460CA8
	[NullableContext(1)]
	public override void Refresh(OnlineTeamData data, bool isSelected, int gridIndex)
	{
		base.GetButton(22).RootUIComp.Get().SetRaycastTarget(data.PlayerId != FunctionModel.Instance.PlayerId);
		this.OnlineTeamData = data;
		bool uiactive = false;
		bool uiactive2 = false;
		bool uiactive3 = false;
		bool uiactive4 = false;
		if (data.IsSelf)
		{
			uiactive3 = true;
		}
		else if (!FriendModel.Instance.IsMyFriend(data.PlayerId))
		{
			uiactive = OnlineModel.Instance.GetIsMyTeam();
			uiactive2 = true;
		}
		else if (this.IsApplyFriend)
		{
			uiactive = OnlineModel.Instance.GetIsMyTeam();
		}
		else
		{
			uiactive = OnlineModel.Instance.GetIsMyTeam();
			uiactive4 = true;
		}
		base.GetButton(16).RootUIComp.Get().SetUIActive(uiactive);
		base.GetButton(14).RootUIComp.Get().SetUIActive(uiactive2);
		base.GetButton(15).RootUIComp.Get().SetUIActive(uiactive3);
		base.GetText(1).SetUIActive(uiactive4);
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
				text.SetText(data.GetRawName(), true);
			}
		}
		else
		{
			text.SetText(data.GetRawName(), true);
		}
		UUIText text3 = base.GetText(2);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
		defaultInterpolatedStringHandler.AppendLiteral("Lv.");
		defaultInterpolatedStringHandler.AppendFormatted<int>(data.Level);
		text3.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		UUIText text4 = base.GetText(7);
		if (data.Signature == null || data.Signature == "")
		{
			LguiUtil.Instance.SetLocalText(text4, "DefaultSign", Array.Empty<object>());
			base.GetItem(20).SetUIActive(true);
		}
		else
		{
			text4.SetText(data.Signature, true);
			base.GetItem(20).SetUIActive(true);
		}
		string inString;
		if (data.PlayerId == CreatureModel.Instance.GetPlayerId())
		{
			inString = "SP_Online{0}PIcon_Self";
		}
		else
		{
			inString = "SP_Online{0}PIcon";
		}
		UUISprite sprite = base.GetSprite(17);
		string resourceId = StringUtils.Format(inString, new string[]
		{
			this.OnlineTeamData.PlayerNumber.ToString()
		});
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		if (string.IsNullOrEmpty(resourcePath))
		{
			sprite.SetUIActive(false);
		}
		else
		{
			sprite.SetUIActive(true);
			this.SetSpriteByPath(resourcePath, sprite, false, null, null);
		}
		this.RefreshPlayerPingItem(data.PingState);
		int curCard = data.PlayerDetails.CurCard;
		if (curCard > 0)
		{
			base.SetTextureByPath(ConfigBackgroundCardById.GetConfig(curCard, true).Value.LongCardPath, base.GetTexture(21), null, null);
		}
		this.RefreshPlayStationItem(data.GetOnlineName());
		this.RefreshPcItem(data.GetOnlineName());
		PlayerTitleItem titleItem = this.TitleItem;
		if (titleItem == null)
		{
			return;
		}
		titleItem.Refresh(new int?(data.PlayerTitleId), new int?(data.PlayerTitleStarLevel), new int?(data.Sex));
	}

	// Token: 0x0600EF05 RID: 61189 RVA: 0x00462E28 File Offset: 0x00461028
	private void RefreshPcItem(string onlineName)
	{
		KuroSdkController instance = KuroSdkController.Instance;
		if (((instance != null) ? new bool?(instance.NeedShowThirdPartyId()) : null).GetValueOrDefault())
		{
			if (onlineName != null && onlineName != "")
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

	// Token: 0x0600EF06 RID: 61190 RVA: 0x00462EAC File Offset: 0x004610AC
	private void RefreshPlayStationItem(string onlineName)
	{
		KuroSdkController instance = KuroSdkController.Instance;
		if (((instance != null) ? new bool?(instance.NeedShowThirdPartyId()) : null).GetValueOrDefault())
		{
			bool flag = onlineName != "" && onlineName != null;
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
				string newText = onlineName ?? "";
				UUIText text2 = base.GetText(24);
				if (text2 != null)
				{
					text2.SetText(newText, true);
				}
			}
			string thirdPartyLogoTexturePath = UiResourceConfig.Instance.GetThirdPartyLogoTexturePath(ELogoSize.Medium);
			base.SetTextureByPath(thirdPartyLogoTexturePath, base.GetTexture(23), null, null);
			string thirdPartyTextColor = UiResourceConfig.Instance.GetThirdPartyTextColor(EConsoleColorSet.Set1);
			UUIText text3 = base.GetText(24);
			if (text3 == null)
			{
				return;
			}
			text3.SetColor(FColor.FromHex(thirdPartyTextColor));
			return;
		}
		else
		{
			UUITexture texture2 = base.GetTexture(23);
			if (texture2 != null)
			{
				texture2.SetUIActive(false);
			}
			UUIText text4 = base.GetText(24);
			if (text4 == null)
			{
				return;
			}
			text4.SetUIActive(false);
			return;
		}
	}

	// Token: 0x0600EF07 RID: 61191 RVA: 0x00462FBA File Offset: 0x004611BA
	private void OnClickOperationBtn()
	{
		FriendController.Instance.RequestFriendApplyAddSend(this.OnlineTeamData.PlayerId, FriendApplyWay.RecentlyTeam);
		this.IsApplyFriend = true;
	}

	// Token: 0x0600EF08 RID: 61192 RVA: 0x00462FDC File Offset: 0x004611DC
	private void OnClickExitBtn()
	{
		ConfirmBoxDataNew confirmBoxDataNew;
		if (OnlineModel.Instance.GetIsMyTeam())
		{
			confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.QuitOnlineWorldAndReduceTeam);
		}
		else
		{
			confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.QuitOnlineWorld);
		}
		confirmBoxDataNew.FunctionMap.Add(2, delegate
		{
			OnlineController.Instance.LeaveWorldTeamRequest(this.OnlineTeamData.PlayerId, null);
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600EF09 RID: 61193 RVA: 0x0046302C File Offset: 0x0046122C
	private void OnClickKickOutBtn()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.KnockPlayerOnlineWorld);
		confirmBoxDataNew.FunctionMap.Add(2, delegate
		{
			OnlineController.Instance.KickWorldTeamRequest(this.OnlineTeamData.PlayerId);
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600EF0A RID: 61194 RVA: 0x00463065 File Offset: 0x00461265
	private void OnClickItemBtn()
	{
		OnlineModel.Instance.CachePlayerData = this.OnlineTeamData;
		UiManager.Instance.OpenView(EUiViewName.OnlineProcessView, null, null);
	}

	// Token: 0x0600EF0B RID: 61195 RVA: 0x00463088 File Offset: 0x00461288
	private void OnRefreshPlayerPing(int playerId, ENetPingState ping)
	{
		if (this.OnlineTeamData.PlayerId != playerId)
		{
			return;
		}
		this.RefreshPlayerPingItem(ping);
	}

	// Token: 0x0600EF0C RID: 61196 RVA: 0x004630A0 File Offset: 0x004612A0
	private void RefreshPlayerPingItem(ENetPingState ping)
	{
		UUISprite sprite = base.GetSprite(19);
		sprite.SetUIActive(true);
		if (ping == ENetPingState.Unknown)
		{
			UiResourceConfig instance = UiResourceConfig.Instance;
			string path = (instance != null) ? instance.GetResourcePath("SP_SignalUnknown") : null;
			this.SetSpriteByPath(path, sprite, false, null, null);
			return;
		}
		if (ping == ENetPingState.Great)
		{
			UiResourceConfig instance2 = UiResourceConfig.Instance;
			string path2 = (instance2 != null) ? instance2.GetResourcePath("SP_SignalGreat") : null;
			this.SetSpriteByPath(path2, sprite, false, null, null);
			return;
		}
		if (ping == ENetPingState.Good)
		{
			UiResourceConfig instance3 = UiResourceConfig.Instance;
			string path3 = (instance3 != null) ? instance3.GetResourcePath("SP_SignalGood") : null;
			this.SetSpriteByPath(path3, sprite, false, null, null);
			return;
		}
		if (ping == ENetPingState.Poor)
		{
			UiResourceConfig instance4 = UiResourceConfig.Instance;
			string path4 = (instance4 != null) ? instance4.GetResourcePath("SP_SignalPoor") : null;
			this.SetSpriteByPath(path4, sprite, false, null, null);
		}
	}

	// Token: 0x04008722 RID: 34594
	private OnlineTeamData OnlineTeamData;

	// Token: 0x04008723 RID: 34595
	private bool IsApplyFriend;

	// Token: 0x04008724 RID: 34596
	private PlayerTitleItem TitleItem;

	// Token: 0x020079FD RID: 31229
	[NullableContext(0)]
	private enum EOnlineTeamItem
	{
		// Token: 0x040278AC RID: 161964
		PlayerName,
		// Token: 0x040278AD RID: 161965
		TipText,
		// Token: 0x040278AE RID: 161966
		Level,
		// Token: 0x040278AF RID: 161967
		RoleHead,
		// Token: 0x040278B0 RID: 161968
		ApplyEnterBtn,
		// Token: 0x040278B1 RID: 161969
		PlayerCount2,
		// Token: 0x040278B2 RID: 161970
		PlayerCount3,
		// Token: 0x040278B3 RID: 161971
		Sign,
		// Token: 0x040278B4 RID: 161972
		ApplyEnterBtnInteraction,
		// Token: 0x040278B5 RID: 161973
		ApplyEnterBtnText,
		// Token: 0x040278B6 RID: 161974
		ApplyCountDown,
		// Token: 0x040278B7 RID: 161975
		ApplyCountDownText,
		// Token: 0x040278B8 RID: 161976
		TeamCount,
		// Token: 0x040278B9 RID: 161977
		TeamItem,
		// Token: 0x040278BA RID: 161978
		OperationBtn,
		// Token: 0x040278BB RID: 161979
		ExitBtn,
		// Token: 0x040278BC RID: 161980
		KickOutBtn,
		// Token: 0x040278BD RID: 161981
		PlayerSprite,
		// Token: 0x040278BE RID: 161982
		HallItem,
		// Token: 0x040278BF RID: 161983
		NetStateSprite,
		// Token: 0x040278C0 RID: 161984
		SignTeamItem,
		// Token: 0x040278C1 RID: 161985
		PlayerTextureBg,
		// Token: 0x040278C2 RID: 161986
		BtnPlayerHead,
		// Token: 0x040278C3 RID: 161987
		ThirdPartyTexture,
		// Token: 0x040278C4 RID: 161988
		ThirdPartyText,
		// Token: 0x040278C5 RID: 161989
		PcItem,
		// Token: 0x040278C6 RID: 161990
		PlayerTitleItem
	}
}
