using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020022EC RID: 8940
[NullableContext(1)]
[Nullable(0)]
public class OnlineChallengeStateView : UiTickViewBase
{
	// Token: 0x060119D4 RID: 72148 RVA: 0x00451B66 File Offset: 0x0044FD66
	public OnlineChallengeStateView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060119D5 RID: 72149 RVA: 0x00451B88 File Offset: 0x0044FD88
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060119D6 RID: 72150 RVA: 0x00451C34 File Offset: 0x0044FE34
	protected override void OnStart()
	{
		this.CountDownNumber = (float)OnlineModel.Instance.ApplyCd;
		this.CountDownBar = base.GetSprite(3);
		this.PlayerLayout = new GenericLayout<OnlineChallengePlayerStateItem, int>(base.GetHorizontalLayout(1), new Func<OnlineChallengePlayerStateItem>(this.InitPlayerItem), null, false, true);
		this.RefreshView();
	}

	// Token: 0x060119D7 RID: 72151 RVA: 0x00451C86 File Offset: 0x0044FE86
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int, EContinuingChallenge>(EEventName.PlayerChallengeStateChange, new Action<int, EContinuingChallenge>(this.OnlineTeamPlayerAccept));
	}

	// Token: 0x060119D8 RID: 72152 RVA: 0x00451CA4 File Offset: 0x0044FEA4
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.PlayerChallengeStateChange, new Action<int, EContinuingChallenge>(this.OnlineTeamPlayerAccept));
	}

	// Token: 0x060119D9 RID: 72153 RVA: 0x00451CC2 File Offset: 0x0044FEC2
	protected override void OnBeforeDestroy()
	{
		this.CountDownBar = null;
		this.CountDownNumber = -1f;
		this.PlayerStateItemList = new List<OnlineChallengePlayerStateItem>();
	}

	// Token: 0x060119DA RID: 72154 RVA: 0x00451CE4 File Offset: 0x0044FEE4
	protected override void OnTick(float delta)
	{
		this.CountDownNumber -= delta * (float)TimeUtil.Instance.Millisecond;
		if (this.CountDownNumber <= 0f)
		{
			base.CloseMe(null);
			return;
		}
		this.CountDownBar.SetFillAmount(this.CountDownNumber / (float)OnlineModel.Instance.ApplyCd);
	}

	// Token: 0x060119DB RID: 72155 RVA: 0x00451D40 File Offset: 0x0044FF40
	public void RefreshView()
	{
		OnlineTeamData currentTeamListById = OnlineModel.Instance.GetCurrentTeamListById(OnlineModel.Instance.OwnerId);
		string item = (currentTeamListById != null) ? currentTeamListById.Name : null;
		if (!SceneTeamModel.Instance.IsAllDid())
		{
			LguiUtil.Instance.SetLocalText(base.GetText(0), "ContinueChallenge", Array.Empty<object>());
			LguiUtil.Instance.SetLocalText(base.GetText(2), "HasInviteContinueChallenge", new <>z__ReadOnlySingleElementList<object>(item));
		}
		else
		{
			LguiUtil.Instance.SetLocalText(base.GetText(0), "ChallengeAgain", Array.Empty<object>());
			LguiUtil.Instance.SetLocalText(base.GetText(2), "HasInviteChallengeAgain", new <>z__ReadOnlySingleElementList<object>(item));
		}
		List<ScenePlayerData> allScenePlayers = CreatureModel.Instance.GetAllScenePlayers();
		List<int> list = new List<int>();
		foreach (ScenePlayerData scenePlayerData in allScenePlayers)
		{
			list.Add(scenePlayerData.GetPlayerId());
		}
		this.PlayerLayout.RefreshByData(list, null, false);
	}

	// Token: 0x060119DC RID: 72156 RVA: 0x00451E50 File Offset: 0x00450050
	private OnlineChallengePlayerStateItem InitPlayerItem()
	{
		OnlineChallengePlayerStateItem onlineChallengePlayerStateItem = new OnlineChallengePlayerStateItem();
		this.PlayerStateItemList.Add(onlineChallengePlayerStateItem);
		return onlineChallengePlayerStateItem;
	}

	// Token: 0x060119DD RID: 72157 RVA: 0x00451E70 File Offset: 0x00450070
	private void OnlineTeamPlayerAccept(int playerId, EContinuingChallenge state)
	{
		if (state == EContinuingChallenge.Leave)
		{
			base.CloseMe(null);
			return;
		}
		foreach (OnlineChallengePlayerStateItem onlineChallengePlayerStateItem in this.PlayerStateItemList)
		{
			onlineChallengePlayerStateItem.SetTeamPlayerSprite(playerId, state);
		}
	}

	// Token: 0x040085B5 RID: 34229
	private float CountDownNumber = -1f;

	// Token: 0x040085B6 RID: 34230
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<OnlineChallengePlayerStateItem, int> PlayerLayout;

	// Token: 0x040085B7 RID: 34231
	[Nullable(2)]
	private UUISprite CountDownBar;

	// Token: 0x040085B8 RID: 34232
	private List<OnlineChallengePlayerStateItem> PlayerStateItemList = new List<OnlineChallengePlayerStateItem>();

	// Token: 0x02008862 RID: 34914
	[NullableContext(0)]
	private enum EOnlineChallengeStateView
	{
		// Token: 0x0402C50C RID: 181516
		TitleText,
		// Token: 0x0402C50D RID: 181517
		PlayerLayout,
		// Token: 0x0402C50E RID: 181518
		TeamLeaderText,
		// Token: 0x0402C50F RID: 181519
		CountDownProgressBar
	}
}
