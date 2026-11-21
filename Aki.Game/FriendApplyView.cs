using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020010F6 RID: 4342
[NullableContext(2)]
[Nullable(0)]
public class FriendApplyView : UiTickViewBase
{
	// Token: 0x0600AD8A RID: 44426 RVA: 0x0033160F File Offset: 0x0032F80F
	[NullableContext(1)]
	public FriendApplyView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600AD8B RID: 44427 RVA: 0x00331618 File Offset: 0x0032F818
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
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

	// Token: 0x0600AD8C RID: 44428 RVA: 0x003317C9 File Offset: 0x0032F9C9
	protected override void OnStart()
	{
		this.ToBeAddedPlayerIdList = (this.OpenParam as List<int>);
		this.CountDown = base.GetText(5);
		this.CountDownBar = base.GetSprite(6);
		this.ResetTime();
		this.RefreshView();
	}

	// Token: 0x0600AD8D RID: 44429 RVA: 0x00331802 File Offset: 0x0032FA02
	protected override void OnBeforeDestroy()
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.FriendMultipleApplyView))
		{
			UiManager.Instance.CloseView(EUiViewName.FriendMultipleApplyView, null);
		}
	}

	// Token: 0x0600AD8E RID: 44430 RVA: 0x00331828 File Offset: 0x0032FA28
	protected override void OnTick(float delta)
	{
		List<FriendApplyData> applyViewDataList = FriendModel.Instance.GetApplyViewDataList(this.ToBeAddedPlayerIdList);
		if (applyViewDataList.Count == 0 || applyViewDataList[0].ApplyTimeLeftTime < 0.0)
		{
			if (!this.HaveClosed)
			{
				base.CloseMe(null);
				this.HaveClosed = true;
			}
			return;
		}
		this.CountDown.SetText(TimeUtil.Instance.GetCoolDown(applyViewDataList[0].ApplyTimeLeftTime), true);
		this.CountDownBar.SetFillAmount((float)(applyViewDataList[0].ApplyTimeLeftTime / (double)FriendModel.Instance.ApplyCdTime));
	}

	// Token: 0x0600AD8F RID: 44431 RVA: 0x003318C2 File Offset: 0x0032FAC2
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RefreshFriendApplicationRedDot, new Action(this.CallServerNotifyFriendApply));
		EventSystem.Instance.Add<int>(EEventName.FriendOnMultiItemAction, new Action<int>(this.HandleFriendOnMultiItemAction));
	}

	// Token: 0x0600AD90 RID: 44432 RVA: 0x003318FC File Offset: 0x0032FAFC
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshFriendApplicationRedDot, new Action(this.CallServerNotifyFriendApply));
		EventSystem.Instance.Remove(EEventName.FriendOnMultiItemAction, new Action<int>(this.HandleFriendOnMultiItemAction));
	}

	// Token: 0x0600AD91 RID: 44433 RVA: 0x00331938 File Offset: 0x0032FB38
	private void ResetTime()
	{
		List<FriendApplyData> applyViewDataList = FriendModel.Instance.GetApplyViewDataList(this.ToBeAddedPlayerIdList);
		if (applyViewDataList.Count == 0)
		{
			return;
		}
		foreach (FriendApplyData friendApplyData in applyViewDataList)
		{
			friendApplyData.ApplyTimeLeftTime = TimeUtil.Instance.GetServerTime();
		}
	}

	// Token: 0x0600AD92 RID: 44434 RVA: 0x003319A8 File Offset: 0x0032FBA8
	private void RefreshView()
	{
		List<FriendApplyData> applyViewDataList = FriendModel.Instance.GetApplyViewDataList(this.ToBeAddedPlayerIdList);
		if (applyViewDataList.Count == 0)
		{
			base.Hide(null);
			return;
		}
		UUIItem item = base.GetItem(3);
		UUIItem item2 = base.GetItem(4);
		UUIText text = base.GetText(7);
		if (applyViewDataList.Count == 1)
		{
			item.SetUIActive(true);
			item2.SetUIActive(false);
			LguiUtil.Instance.SetLocalText(text, "TowerDefence_friendOnly", Array.Empty<object>());
			UUIButtonComponent button = base.GetButton(8);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(true);
			}
		}
		else
		{
			item.SetUIActive(false);
			item2.SetUIActive(true);
			LguiUtil.Instance.SetLocalText(text, "TowerDefence_friendMore", new <>z__ReadOnlySingleElementList<object>(applyViewDataList.Count));
			UUIButtonComponent button2 = base.GetButton(8);
			if (button2 != null)
			{
				button2.RootUIComp.Get().SetUIActive(false);
			}
		}
		FriendApplyData friendApplyData = applyViewDataList[0];
		FriendData applyPlayerData = friendApplyData.ApplyPlayerData;
		base.GetText(1).SetText(applyPlayerData.PlayerName, true);
		this.CountDown.SetText(TimeUtil.Instance.GetCoolDown(friendApplyData.ApplyTimeLeftTime), true);
		this.CountDownBar.SetFillAmount((float)(friendApplyData.ApplyTimeLeftTime / (double)FriendModel.Instance.ApplyCdTime));
		RoleInfo? roleInfo;
		string text2 = (RoleConfig.Instance.GetRoleConfig(applyPlayerData.PlayerHeadPhoto) != null) ? roleInfo.GetValueOrDefault().Card : null;
		if (!string.IsNullOrEmpty(text2))
		{
			base.SetTextureByPath(text2, base.GetTexture(0), null, null);
		}
		UUIButtonComponent button3 = base.GetButton(8);
		if (button3 == null)
		{
			return;
		}
		button3.RootUIComp.Get().SetUIActive(true);
	}

	// Token: 0x0600AD93 RID: 44435 RVA: 0x00331B64 File Offset: 0x0032FD64
	private void OnClickHandleBtn()
	{
		List<FriendApplyData> applyViewDataList = FriendModel.Instance.GetApplyViewDataList(this.ToBeAddedPlayerIdList);
		if (applyViewDataList.Count < 1)
		{
			UiManager.Instance.CloseView(EUiViewName.FriendMultipleApplyView, null);
			return;
		}
		if (applyViewDataList.Count == 1)
		{
			FriendData applyPlayerData = applyViewDataList[0].ApplyPlayerData;
			FriendController.Instance.RequestFriendApplyHandle(new List<int>
			{
				applyPlayerData.PlayerId
			}, FriendApplyOperator.Approve);
			return;
		}
		if (UiManager.Instance.IsViewOpen(EUiViewName.FriendMultipleApplyView))
		{
			UiManager.Instance.CloseView(EUiViewName.FriendMultipleApplyView, null);
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.FriendMultipleApplyView, applyViewDataList, null);
	}

	// Token: 0x0600AD94 RID: 44436 RVA: 0x00331C04 File Offset: 0x0032FE04
	private void OnClickCancelBtn()
	{
		List<FriendApplyData> applyViewDataList = FriendModel.Instance.GetApplyViewDataList(this.ToBeAddedPlayerIdList);
		if (applyViewDataList.Count < 1)
		{
			UiManager.Instance.CloseView(EUiViewName.OnlineMultipleApplyView, null);
			return;
		}
		List<int> list = new List<int>();
		foreach (FriendApplyData friendApplyData in applyViewDataList)
		{
			FriendData applyPlayerData = friendApplyData.ApplyPlayerData;
			if (applyPlayerData != null)
			{
				list.Add(applyPlayerData.PlayerId);
			}
		}
		FriendController.Instance.RequestFriendApplyHandle(list, FriendApplyOperator.Reject);
	}

	// Token: 0x0600AD95 RID: 44437 RVA: 0x00331C9C File Offset: 0x0032FE9C
	private void CallServerNotifyFriendApply()
	{
		this.ResetTime();
		this.RefreshView();
	}

	// Token: 0x0600AD96 RID: 44438 RVA: 0x00331CAC File Offset: 0x0032FEAC
	private void HandleFriendOnMultiItemAction(int playerId)
	{
		if (this.ToBeAddedPlayerIdList == null)
		{
			return;
		}
		int num = this.ToBeAddedPlayerIdList.IndexOf(playerId);
		if (num != -1)
		{
			this.ToBeAddedPlayerIdList.RemoveAt(num);
		}
		this.RefreshView();
	}

	// Token: 0x040063EF RID: 25583
	private UUIText CountDown;

	// Token: 0x040063F0 RID: 25584
	private UUISprite CountDownBar;

	// Token: 0x040063F1 RID: 25585
	private bool HaveClosed;

	// Token: 0x040063F2 RID: 25586
	private List<int> ToBeAddedPlayerIdList;

	// Token: 0x02007385 RID: 29573
	[NullableContext(0)]
	private class EFriendApplyView
	{
		// Token: 0x040259CC RID: 154060
		public const int RoleTexture = 0;

		// Token: 0x040259CD RID: 154061
		public const int PlayerName = 1;

		// Token: 0x040259CE RID: 154062
		public const int HandleBtn = 2;

		// Token: 0x040259CF RID: 154063
		public const int ApplySprite = 3;

		// Token: 0x040259D0 RID: 154064
		public const int MoreSprite = 4;

		// Token: 0x040259D1 RID: 154065
		public const int CountDown = 5;

		// Token: 0x040259D2 RID: 154066
		public const int CountDownProgressBar = 6;

		// Token: 0x040259D3 RID: 154067
		public const int MultipleApplyText = 7;

		// Token: 0x040259D4 RID: 154068
		public const int CancelBtn = 8;
	}
}
