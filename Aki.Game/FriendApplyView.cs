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

// Token: 0x02001C37 RID: 7223
[NullableContext(2)]
[Nullable(0)]
public class FriendApplyView : UiTickViewBase
{
	// Token: 0x0600D974 RID: 55668 RVA: 0x0032620F File Offset: 0x0032440F
	[NullableContext(1)]
	public FriendApplyView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600D975 RID: 55669 RVA: 0x00326218 File Offset: 0x00324418
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

	// Token: 0x0600D976 RID: 55670 RVA: 0x003263C9 File Offset: 0x003245C9
	protected override void OnStart()
	{
		this.ToBeAddedPlayerIdList = (this.OpenParam as List<int>);
		this.CountDown = base.GetText(5);
		this.CountDownBar = base.GetSprite(6);
		this.ResetTime();
		this.RefreshView();
	}

	// Token: 0x0600D977 RID: 55671 RVA: 0x00326402 File Offset: 0x00324602
	protected override void OnBeforeDestroy()
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.FriendMultipleApplyView))
		{
			UiManager.Instance.CloseView(EUiViewName.FriendMultipleApplyView, null);
		}
	}

	// Token: 0x0600D978 RID: 55672 RVA: 0x00326428 File Offset: 0x00324628
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

	// Token: 0x0600D979 RID: 55673 RVA: 0x003264C2 File Offset: 0x003246C2
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RefreshFriendApplicationRedDot, new Action(this.CallServerNotifyFriendApply));
		EventSystem.Instance.Add<int>(EEventName.FriendOnMultiItemAction, new Action<int>(this.HandleFriendOnMultiItemAction));
	}

	// Token: 0x0600D97A RID: 55674 RVA: 0x003264FC File Offset: 0x003246FC
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshFriendApplicationRedDot, new Action(this.CallServerNotifyFriendApply));
		EventSystem.Instance.Remove(EEventName.FriendOnMultiItemAction, new Action<int>(this.HandleFriendOnMultiItemAction));
	}

	// Token: 0x0600D97B RID: 55675 RVA: 0x00326538 File Offset: 0x00324738
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

	// Token: 0x0600D97C RID: 55676 RVA: 0x003265A8 File Offset: 0x003247A8
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

	// Token: 0x0600D97D RID: 55677 RVA: 0x00326764 File Offset: 0x00324964
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

	// Token: 0x0600D97E RID: 55678 RVA: 0x00326804 File Offset: 0x00324A04
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

	// Token: 0x0600D97F RID: 55679 RVA: 0x0032689C File Offset: 0x00324A9C
	private void CallServerNotifyFriendApply()
	{
		this.ResetTime();
		this.RefreshView();
	}

	// Token: 0x0600D980 RID: 55680 RVA: 0x003268AC File Offset: 0x00324AAC
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

	// Token: 0x0400631D RID: 25373
	private UUIText CountDown;

	// Token: 0x0400631E RID: 25374
	private UUISprite CountDownBar;

	// Token: 0x0400631F RID: 25375
	private bool HaveClosed;

	// Token: 0x04006320 RID: 25376
	private List<int> ToBeAddedPlayerIdList;

	// Token: 0x020081FC RID: 33276
	[NullableContext(0)]
	private class EFriendApplyView
	{
		// Token: 0x0402A6A5 RID: 173733
		public const int RoleTexture = 0;

		// Token: 0x0402A6A6 RID: 173734
		public const int PlayerName = 1;

		// Token: 0x0402A6A7 RID: 173735
		public const int HandleBtn = 2;

		// Token: 0x0402A6A8 RID: 173736
		public const int ApplySprite = 3;

		// Token: 0x0402A6A9 RID: 173737
		public const int MoreSprite = 4;

		// Token: 0x0402A6AA RID: 173738
		public const int CountDown = 5;

		// Token: 0x0402A6AB RID: 173739
		public const int CountDownProgressBar = 6;

		// Token: 0x0402A6AC RID: 173740
		public const int MultipleApplyText = 7;

		// Token: 0x0402A6AD RID: 173741
		public const int CancelBtn = 8;
	}
}
