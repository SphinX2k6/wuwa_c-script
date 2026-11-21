using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020017D0 RID: 6096
[NullableContext(1)]
[Nullable(0)]
public class OnlineChallengeStateView : UiTickViewBase
{
	// Token: 0x0600EE6C RID: 61036 RVA: 0x0045E832 File Offset: 0x0045CA32
	public OnlineChallengeStateView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EE6D RID: 61037 RVA: 0x0045E854 File Offset: 0x0045CA54
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

	// Token: 0x0600EE6E RID: 61038 RVA: 0x0045E900 File Offset: 0x0045CB00
	protected override void OnStart()
	{
		this.CountDownNumber = (float)OnlineModel.Instance.ApplyCd;
		this.CountDownBar = base.GetSprite(3);
		this.PlayerLayout = new GenericLayout<OnlineChallengePlayerStateItem, int>(base.GetHorizontalLayout(1), new Func<OnlineChallengePlayerStateItem>(this.InitPlayerItem), null, false, true);
		this.RefreshView();
	}

	// Token: 0x0600EE6F RID: 61039 RVA: 0x0045E952 File Offset: 0x0045CB52
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int, EContinuingChallenge>(EEventName.PlayerChallengeStateChange, new Action<int, EContinuingChallenge>(this.OnlineTeamPlayerAccept));
	}

	// Token: 0x0600EE70 RID: 61040 RVA: 0x0045E970 File Offset: 0x0045CB70
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.PlayerChallengeStateChange, new Action<int, EContinuingChallenge>(this.OnlineTeamPlayerAccept));
	}

	// Token: 0x0600EE71 RID: 61041 RVA: 0x0045E98E File Offset: 0x0045CB8E
	protected override void OnBeforeDestroy()
	{
		this.CountDownBar = null;
		this.CountDownNumber = -1f;
		this.PlayerStateItemList = new List<OnlineChallengePlayerStateItem>();
	}

	// Token: 0x0600EE72 RID: 61042 RVA: 0x0045E9B0 File Offset: 0x0045CBB0
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

	// Token: 0x0600EE73 RID: 61043 RVA: 0x0045EA0C File Offset: 0x0045CC0C
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

	// Token: 0x0600EE74 RID: 61044 RVA: 0x0045EB1C File Offset: 0x0045CD1C
	private OnlineChallengePlayerStateItem InitPlayerItem()
	{
		OnlineChallengePlayerStateItem onlineChallengePlayerStateItem = new OnlineChallengePlayerStateItem();
		this.PlayerStateItemList.Add(onlineChallengePlayerStateItem);
		return onlineChallengePlayerStateItem;
	}

	// Token: 0x0600EE75 RID: 61045 RVA: 0x0045EB3C File Offset: 0x0045CD3C
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

	// Token: 0x040086F3 RID: 34547
	private float CountDownNumber = -1f;

	// Token: 0x040086F4 RID: 34548
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<OnlineChallengePlayerStateItem, int> PlayerLayout;

	// Token: 0x040086F5 RID: 34549
	[Nullable(2)]
	private UUISprite CountDownBar;

	// Token: 0x040086F6 RID: 34550
	private List<OnlineChallengePlayerStateItem> PlayerStateItemList = new List<OnlineChallengePlayerStateItem>();

	// Token: 0x020079E6 RID: 31206
	[NullableContext(0)]
	private enum EOnlineChallengeStateView
	{
		// Token: 0x0402780E RID: 161806
		TitleText,
		// Token: 0x0402780F RID: 161807
		PlayerLayout,
		// Token: 0x04027810 RID: 161808
		TeamLeaderText,
		// Token: 0x04027811 RID: 161809
		CountDownProgressBar
	}
}
