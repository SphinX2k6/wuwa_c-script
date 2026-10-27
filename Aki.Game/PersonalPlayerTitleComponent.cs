using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020023DA RID: 9178
[NullableContext(1)]
[Nullable(0)]
public class PersonalPlayerTitleComponent : UiPanelBase
{
	// Token: 0x0601258E RID: 75150 RVA: 0x00485450 File Offset: 0x00483650
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(11, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(10, new Action(this.OnClickTitlePreviewBtn))
		};
	}

	// Token: 0x0601258F RID: 75151 RVA: 0x00485598 File Offset: 0x00483798
	protected override UniTask OnBeforeStartAsync()
	{
		PersonalPlayerTitleComponent.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PersonalPlayerTitleComponent.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012590 RID: 75152 RVA: 0x004855DC File Offset: 0x004837DC
	protected override UniTask OnBeforeShowAsyncImplement()
	{
		PersonalPlayerTitleComponent.<OnBeforeShowAsyncImplement>d__9 <OnBeforeShowAsyncImplement>d__;
		<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<PersonalPlayerTitleComponent.<OnBeforeShowAsyncImplement>d__9>(ref <OnBeforeShowAsyncImplement>d__);
		return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
	}

	// Token: 0x06012591 RID: 75153 RVA: 0x0048561F File Offset: 0x0048381F
	protected override void OnBeforeDestroy()
	{
		this.RemoveEventListener();
	}

	// Token: 0x06012592 RID: 75154 RVA: 0x00485627 File Offset: 0x00483827
	protected void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnPlayerTitleChange, new Action(this.OnPlayerTitleChange));
	}

	// Token: 0x06012593 RID: 75155 RVA: 0x00485645 File Offset: 0x00483845
	protected void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnPlayerTitleChange, new Action(this.OnPlayerTitleChange));
	}

	// Token: 0x06012594 RID: 75156 RVA: 0x00485663 File Offset: 0x00483863
	public void SetPersonalInfoData(PersonalInfoData personalInfoData)
	{
		this.PersonalInfoData = personalInfoData;
	}

	// Token: 0x06012595 RID: 75157 RVA: 0x0048566C File Offset: 0x0048386C
	public void SetRefreshConfirmBtn(Action<bool, bool> refreshConfirmBtn)
	{
		this.RefreshConfirmBtn = refreshConfirmBtn;
	}

	// Token: 0x06012596 RID: 75158 RVA: 0x00485675 File Offset: 0x00483875
	private void OnPlayerTitleChange()
	{
		this.RefreshScrollView();
		this.RefreshConfirmBtnState();
	}

	// Token: 0x06012597 RID: 75159 RVA: 0x00485683 File Offset: 0x00483883
	private PersonalPlayerTitleItem CreatePlayerTitleItem()
	{
		PersonalPlayerTitleItem personalPlayerTitleItem = new PersonalPlayerTitleItem();
		personalPlayerTitleItem.SetToggleCallBack(new Action<int, PersonalPlayerTitleData>(this.PlayerTitleItemToggleClick));
		return personalPlayerTitleItem;
	}

	// Token: 0x06012598 RID: 75160 RVA: 0x0048569C File Offset: 0x0048389C
	private void PlayerTitleItemToggleClick(int gridIndex, PersonalPlayerTitleData playerTitleData)
	{
		this.CurPersonalPlayerTitleData = playerTitleData;
		this.RefreshPlayerTitleInfo();
		this.ScrollView.SelectGridProxy(gridIndex, false);
	}

	// Token: 0x06012599 RID: 75161 RVA: 0x004856B8 File Offset: 0x004838B8
	protected void RefreshPlayerTitleInfo()
	{
		UUIItem item = base.GetItem(7);
		if (item != null)
		{
			item.SetActive(this.CurPersonalPlayerTitleData != null, false);
		}
		if (this.CurPersonalPlayerTitleData != null)
		{
			PlayerTitle? config = ConfigPlayerTitleById.GetConfig(this.CurPersonalPlayerTitleData.PlayerTitleId, true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), config.Value.TitleName, Array.Empty<object>());
			UUIText text = base.GetText(3);
			if (this.CurPersonalPlayerTitleData.IsEffective())
			{
				text.SetUIActive(true);
				int id = config.Value.Id;
				int playerTitleStarLevel = PersonalModel.Instance.GetPlayerTitleStarLevel(id);
				string playerTitleInfoString = PersonalModel.Instance.GetPlayerTitleInfoString(id, playerTitleStarLevel, true);
				text.SetText(playerTitleInfoString, true);
			}
			else
			{
				text.SetUIActive(false);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), config.Value.Description, Array.Empty<object>());
			if (config.Value.IsShowProgress)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(5), config.Value.ItemAccess, new <>z__ReadOnlyArray<object>(new object[]
				{
					this.CurPersonalPlayerTitleData.CurProgress,
					this.CurPersonalPlayerTitleData.TargetProgress
				}));
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(5), config.Value.ItemAccess, Array.Empty<object>());
			}
			double? unlockTime = this.CurPersonalPlayerTitleData.UnlockTime;
			UUIItem item2 = base.GetItem(8);
			if (unlockTime != null && this.CurPersonalPlayerTitleData != null && !this.CurPersonalPlayerTitleData.IsExpired())
			{
				item2.SetUIActive(true);
				base.GetText(6).SetText(TimeUtil.Instance.DateFormat4String(unlockTime.Value / 1000.0), true);
			}
			else
			{
				item2.SetUIActive(false);
			}
			bool flag = this.CurPersonalPlayerTitleData.IsTimeLimitTitle();
			UUIText text2 = base.GetText(11);
			if (text2 != null)
			{
				bool flag2 = flag && !this.CurPersonalPlayerTitleData.IsExpired();
				text2.SetUIActive(flag2);
				if (flag2)
				{
					double remainTime = this.CurPersonalPlayerTitleData.EndTime.Value - TimeUtil.Instance.GetServerTime();
					string item3 = TimeUtil.Instance.GetRemainTimeDataFormat3(remainTime).CountDownText ?? "";
					LguiUtil.Instance.SetLocalTextNew(text2, "LimitTimeTitle", new <>z__ReadOnlySingleElementList<object>(item3));
				}
			}
			this.RefreshConfirmBtnState();
			this.MiniTitlePreView.RefreshView(this.CurPersonalPlayerTitleData);
		}
	}

	// Token: 0x0601259A RID: 75162 RVA: 0x00485948 File Offset: 0x00483B48
	public void RefreshScrollView()
	{
		List<PersonalPlayerTitleData> sortedList = this.GetSortedList();
		this.ScrollView.RefreshByData(sortedList, false, null, false);
		int num = 0;
		if (this.LastLogTitleId.GetValueOrDefault() != -1 && this.PersonalInfoData.CurPlayerTitleId != null && this.PersonalInfoData.CurPlayerTitleId.Value <= 0)
		{
			num = sortedList.FindIndex(delegate(PersonalPlayerTitleData data)
			{
				int playerTitleId = data.PlayerTitleId;
				int? lastLogTitleId = this.LastLogTitleId;
				return playerTitleId == lastLogTitleId.GetValueOrDefault() & lastLogTitleId != null;
			});
		}
		num = ((num < 0) ? 0 : num);
		this.ScrollView.SelectGridProxy(num, false);
		this.ScrollView.ScrollToGridIndex(num, true);
		this.LastLogTitleId = this.PersonalInfoData.CurPlayerTitleId;
		UiNavigationNewController.Instance.SetNavigationFocusForView(this.ScrollView.GetGrid(num), true, false, false);
	}

	// Token: 0x0601259B RID: 75163 RVA: 0x00485A04 File Offset: 0x00483C04
	public void RefreshConfirmBtnState()
	{
		int? curPlayerTitleId = this.PersonalInfoData.CurPlayerTitleId;
		bool flag = this.CurPersonalPlayerTitleData.IsEffective();
		if (this.RefreshConfirmBtn != null)
		{
			Action<bool, bool> refreshConfirmBtn = this.RefreshConfirmBtn;
			bool arg = flag;
			int? num = curPlayerTitleId;
			int playerTitleId = this.CurPersonalPlayerTitleData.PlayerTitleId;
			refreshConfirmBtn(arg, num.GetValueOrDefault() == playerTitleId & num != null);
		}
	}

	// Token: 0x0601259C RID: 75164 RVA: 0x00485A60 File Offset: 0x00483C60
	private List<PersonalPlayerTitleData> GetSortedList()
	{
		List<PersonalPlayerTitleData> list = new List<PersonalPlayerTitleData>(PersonalModel.Instance.GetPlayerTitleList());
		int num = list.FindIndex(delegate(PersonalPlayerTitleData data)
		{
			int playerTitleId = data.PlayerTitleId;
			int? curPlayerTitleId = this.PersonalInfoData.CurPlayerTitleId;
			return playerTitleId == curPlayerTitleId.GetValueOrDefault() & curPlayerTitleId != null;
		});
		if (num <= 0 || num >= list.Count)
		{
			return list;
		}
		if (list[num].IsExpired())
		{
			return list;
		}
		PersonalPlayerTitleData value = list[num];
		for (int i = num; i > 0; i--)
		{
			list[i] = list[i - 1];
		}
		list[0] = value;
		return list;
	}

	// Token: 0x0601259D RID: 75165 RVA: 0x00485ADC File Offset: 0x00483CDC
	public void OnClickConfirm(int _)
	{
		if (this.CurPersonalPlayerTitleData.IsExpired())
		{
			return;
		}
		int num = this.CurPersonalPlayerTitleData.PlayerTitleId;
		int? curPlayerTitleId = this.PersonalInfoData.CurPlayerTitleId;
		int num2 = num;
		if (curPlayerTitleId.GetValueOrDefault() == num2 & curPlayerTitleId != null)
		{
			num = 0;
		}
		PersonalController.Instance.SendChangePlayerTitleRequest(num);
	}

	// Token: 0x0601259E RID: 75166 RVA: 0x00485B32 File Offset: 0x00483D32
	private void OnClickTitlePreviewBtn()
	{
		ItemController.Instance.OpenTitleTipsByItemId(this.CurPersonalPlayerTitleData.PlayerTitleId);
	}

	// Token: 0x04008AC9 RID: 35529
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<PersonalPlayerTitleItem, PersonalPlayerTitleData> ScrollView;

	// Token: 0x04008ACA RID: 35530
	[Nullable(2)]
	private PersonalPlayerTitleData CurPersonalPlayerTitleData;

	// Token: 0x04008ACB RID: 35531
	[Nullable(2)]
	private PersonalInfoData PersonalInfoData;

	// Token: 0x04008ACC RID: 35532
	[Nullable(2)]
	private PersonalPlayerTitleMiniPreView MiniTitlePreView;

	// Token: 0x04008ACD RID: 35533
	[Nullable(2)]
	private Action<bool, bool> RefreshConfirmBtn;

	// Token: 0x04008ACE RID: 35534
	private int? LastLogTitleId = new int?(-1);

	// Token: 0x0200897C RID: 35196
	[NullableContext(0)]
	private enum EPersonalTitleComponentDefine
	{
		// Token: 0x0402CACE RID: 182990
		ScrollView,
		// Token: 0x0402CACF RID: 182991
		PersonalTitleItem,
		// Token: 0x0402CAD0 RID: 182992
		TxtName,
		// Token: 0x0402CAD1 RID: 182993
		TxtDetail,
		// Token: 0x0402CAD2 RID: 182994
		TxtDescription,
		// Token: 0x0402CAD3 RID: 182995
		TxtAccess,
		// Token: 0x0402CAD4 RID: 182996
		TxtAccessTime,
		// Token: 0x0402CAD5 RID: 182997
		PanelRight,
		// Token: 0x0402CAD6 RID: 182998
		PanelAccess,
		// Token: 0x0402CAD7 RID: 182999
		PanelCard,
		// Token: 0x0402CAD8 RID: 183000
		TitlePreviewBtn,
		// Token: 0x0402CAD9 RID: 183001
		TxtTimeLimit
	}
}
