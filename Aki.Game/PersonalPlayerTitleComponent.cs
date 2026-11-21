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

// Token: 0x020018BF RID: 6335
[NullableContext(1)]
[Nullable(0)]
public class PersonalPlayerTitleComponent : UiPanelBase
{
	// Token: 0x0600FA40 RID: 64064 RVA: 0x0049295C File Offset: 0x00490B5C
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

	// Token: 0x0600FA41 RID: 64065 RVA: 0x00492AA4 File Offset: 0x00490CA4
	protected override UniTask OnBeforeStartAsync()
	{
		PersonalPlayerTitleComponent.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PersonalPlayerTitleComponent.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600FA42 RID: 64066 RVA: 0x00492AE8 File Offset: 0x00490CE8
	protected override UniTask OnBeforeShowAsyncImplement()
	{
		PersonalPlayerTitleComponent.<OnBeforeShowAsyncImplement>d__9 <OnBeforeShowAsyncImplement>d__;
		<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<PersonalPlayerTitleComponent.<OnBeforeShowAsyncImplement>d__9>(ref <OnBeforeShowAsyncImplement>d__);
		return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
	}

	// Token: 0x0600FA43 RID: 64067 RVA: 0x00492B2B File Offset: 0x00490D2B
	protected override void OnBeforeDestroy()
	{
		this.RemoveEventListener();
	}

	// Token: 0x0600FA44 RID: 64068 RVA: 0x00492B33 File Offset: 0x00490D33
	protected void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnPlayerTitleChange, new Action(this.OnPlayerTitleChange));
	}

	// Token: 0x0600FA45 RID: 64069 RVA: 0x00492B51 File Offset: 0x00490D51
	protected void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnPlayerTitleChange, new Action(this.OnPlayerTitleChange));
	}

	// Token: 0x0600FA46 RID: 64070 RVA: 0x00492B6F File Offset: 0x00490D6F
	public void SetPersonalInfoData(PersonalInfoData personalInfoData)
	{
		this.PersonalInfoData = personalInfoData;
	}

	// Token: 0x0600FA47 RID: 64071 RVA: 0x00492B78 File Offset: 0x00490D78
	public void SetRefreshConfirmBtn(Action<bool, bool> refreshConfirmBtn)
	{
		this.RefreshConfirmBtn = refreshConfirmBtn;
	}

	// Token: 0x0600FA48 RID: 64072 RVA: 0x00492B81 File Offset: 0x00490D81
	private void OnPlayerTitleChange()
	{
		this.RefreshScrollView();
		this.RefreshConfirmBtnState();
	}

	// Token: 0x0600FA49 RID: 64073 RVA: 0x00492B8F File Offset: 0x00490D8F
	private PersonalPlayerTitleItem CreatePlayerTitleItem()
	{
		PersonalPlayerTitleItem personalPlayerTitleItem = new PersonalPlayerTitleItem();
		personalPlayerTitleItem.SetToggleCallBack(new Action<int, PersonalPlayerTitleData>(this.PlayerTitleItemToggleClick));
		return personalPlayerTitleItem;
	}

	// Token: 0x0600FA4A RID: 64074 RVA: 0x00492BA8 File Offset: 0x00490DA8
	private void PlayerTitleItemToggleClick(int gridIndex, PersonalPlayerTitleData playerTitleData)
	{
		this.CurPersonalPlayerTitleData = playerTitleData;
		this.RefreshPlayerTitleInfo();
		this.ScrollView.SelectGridProxy(gridIndex, false);
	}

	// Token: 0x0600FA4B RID: 64075 RVA: 0x00492BC4 File Offset: 0x00490DC4
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

	// Token: 0x0600FA4C RID: 64076 RVA: 0x00492E54 File Offset: 0x00491054
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

	// Token: 0x0600FA4D RID: 64077 RVA: 0x00492F10 File Offset: 0x00491110
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

	// Token: 0x0600FA4E RID: 64078 RVA: 0x00492F6C File Offset: 0x0049116C
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

	// Token: 0x0600FA4F RID: 64079 RVA: 0x00492FE8 File Offset: 0x004911E8
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

	// Token: 0x0600FA50 RID: 64080 RVA: 0x0049303E File Offset: 0x0049123E
	private void OnClickTitlePreviewBtn()
	{
		ItemController.Instance.OpenTitleTipsByItemId(this.CurPersonalPlayerTitleData.PlayerTitleId);
	}

	// Token: 0x04008C10 RID: 35856
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<PersonalPlayerTitleItem, PersonalPlayerTitleData> ScrollView;

	// Token: 0x04008C11 RID: 35857
	[Nullable(2)]
	private PersonalPlayerTitleData CurPersonalPlayerTitleData;

	// Token: 0x04008C12 RID: 35858
	[Nullable(2)]
	private PersonalInfoData PersonalInfoData;

	// Token: 0x04008C13 RID: 35859
	[Nullable(2)]
	private PersonalPlayerTitleMiniPreView MiniTitlePreView;

	// Token: 0x04008C14 RID: 35860
	[Nullable(2)]
	private Action<bool, bool> RefreshConfirmBtn;

	// Token: 0x04008C15 RID: 35861
	private int? LastLogTitleId = new int?(-1);

	// Token: 0x02007B05 RID: 31493
	[NullableContext(0)]
	private enum EPersonalTitleComponentDefine
	{
		// Token: 0x04027DE9 RID: 163305
		ScrollView,
		// Token: 0x04027DEA RID: 163306
		PersonalTitleItem,
		// Token: 0x04027DEB RID: 163307
		TxtName,
		// Token: 0x04027DEC RID: 163308
		TxtDetail,
		// Token: 0x04027DED RID: 163309
		TxtDescription,
		// Token: 0x04027DEE RID: 163310
		TxtAccess,
		// Token: 0x04027DEF RID: 163311
		TxtAccessTime,
		// Token: 0x04027DF0 RID: 163312
		PanelRight,
		// Token: 0x04027DF1 RID: 163313
		PanelAccess,
		// Token: 0x04027DF2 RID: 163314
		PanelCard,
		// Token: 0x04027DF3 RID: 163315
		TitlePreviewBtn,
		// Token: 0x04027DF4 RID: 163316
		TxtTimeLimit
	}
}
