using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000880 RID: 2176
[NullableContext(1)]
[Nullable(0)]
public class NewPlayerAdventureV2View : UiViewBase
{
	// Token: 0x0600629C RID: 25244 RVA: 0x001F6BCB File Offset: 0x001F4DCB
	public NewPlayerAdventureV2View(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600629D RID: 25245 RVA: 0x001F6BF0 File Offset: 0x001F4DF0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIItem))
		};
	}

	// Token: 0x0600629E RID: 25246 RVA: 0x001F6CE8 File Offset: 0x001F4EE8
	protected override UniTask OnBeforeStartAsync()
	{
		NewPlayerAdventureV2View.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<NewPlayerAdventureV2View.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600629F RID: 25247 RVA: 0x001F6D24 File Offset: 0x001F4F24
	protected override void OnStart()
	{
		this.RoleLayout = new GenericLayout<NewPlayerAdventureV2RoleItem, int>(base.GetHorizontalLayout(0), new Func<NewPlayerAdventureV2RoleItem>(this.InitRoleItem), null, false, true);
		this.AdventureLayout = new GenericLayout<NewPlayerAdventureV2AdventureItem, int>(base.GetVerticalLayout(2), new Func<NewPlayerAdventureV2AdventureItem>(this.InitAdventureItem), base.GetItem(3).GetOwner() as AUIBaseActor, false, true);
		this.AdventureLayout2 = new GenericLayout<NewPlayerAdventureV2AdventureItem, int>(base.GetVerticalLayout(4), new Func<NewPlayerAdventureV2AdventureItem>(this.InitAdventureItem), base.GetItem(3).GetOwner() as AUIBaseActor, false, true);
		this.CaptionItem = new PopupCaptionItem(base.GetItem(7));
		this.CaptionItem.SetCloseCallBack(new Action(this.OnClickCloseBtn));
		this.RefreshTime(0f);
		this.RefreshTimer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.RefreshTime), 1000f, 1f, null, null, true);
		this.RefreshRolePanelState();
	}

	// Token: 0x060062A0 RID: 25248 RVA: 0x001F6E17 File Offset: 0x001F5017
	protected override void OnBeforeDestroy()
	{
		if (this.RefreshTimer != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.RefreshTimer);
			this.RefreshTimer = null;
		}
	}

	// Token: 0x060062A1 RID: 25249 RVA: 0x001F6E39 File Offset: 0x001F5039
	private void RefreshTime(float delta)
	{
		base.GetText(8).SetText(this.GetRemainTimeText(), true);
	}

	// Token: 0x060062A2 RID: 25250 RVA: 0x001F6E50 File Offset: 0x001F5050
	private string GetRemainTimeText()
	{
		ActivityNewPlayerSupportActivityV2Controller activityController = this.GetActivityController();
		ActivityNewPlayerSupportActivityV2Data activityNewPlayerSupportActivityV2Data = (activityController != null) ? activityController.ActivityData : null;
		if (activityNewPlayerSupportActivityV2Data == null)
		{
			return "";
		}
		long displayRemainEndTime = activityNewPlayerSupportActivityV2Data.GetDisplayRemainEndTime();
		if (displayRemainEndTime <= 0L || !activityNewPlayerSupportActivityV2Data.CheckIfInShowTime())
		{
			return "";
		}
		return ActivityModel.Instance.GetRemainTimeText(displayRemainEndTime, this.RemainTimeFormat) ?? "";
	}

	// Token: 0x060062A3 RID: 25251 RVA: 0x001F6EAD File Offset: 0x001F50AD
	[NullableContext(2)]
	private ActivityNewPlayerSupportActivityV2Controller GetActivityController()
	{
		return ActivityManager.GetActivityController(ActivityType.NewPlayerSupportActivityV2) as ActivityNewPlayerSupportActivityV2Controller;
	}

	// Token: 0x060062A4 RID: 25252 RVA: 0x001F6EBB File Offset: 0x001F50BB
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x060062A5 RID: 25253 RVA: 0x001F6EC4 File Offset: 0x001F50C4
	private List<int> GetRoleIdList()
	{
		INewPlayerAdventureV2ViewOpenData newPlayerAdventureV2ViewOpenData = this.OpenParam as INewPlayerAdventureV2ViewOpenData;
		return ((newPlayerAdventureV2ViewOpenData != null) ? newPlayerAdventureV2ViewOpenData.RoleIdList : null) ?? new List<int>();
	}

	// Token: 0x060062A6 RID: 25254 RVA: 0x001F6EE8 File Offset: 0x001F50E8
	private void RefreshRolePanelState()
	{
		List<int> roleList = this.GetRoleIdList();
		bool flag = roleList.Count > 0;
		base.GetItem(5).SetUIActive(flag);
		base.GetItem(6).SetUIActive(!flag);
		if (!flag)
		{
			this.CurrentSelectRoleId = 0;
			this.CurrentSelectToggle = null;
			GenericLayout<NewPlayerAdventureV2AdventureItem, int> adventureLayout = this.AdventureLayout;
			if (adventureLayout != null)
			{
				adventureLayout.RefreshByData(new List<int>(), null, true);
			}
			GenericLayout<NewPlayerAdventureV2AdventureItem, int> adventureLayout2 = this.AdventureLayout2;
			if (adventureLayout2 == null)
			{
				return;
			}
			adventureLayout2.RefreshByData(new List<int>(), null, true);
			return;
		}
		else
		{
			GenericLayout<NewPlayerAdventureV2RoleItem, int> roleLayout = this.RoleLayout;
			if (roleLayout == null)
			{
				return;
			}
			roleLayout.RefreshByData(roleList, delegate
			{
				int num = (this.CurrentSelectRoleId != 0) ? roleList.IndexOf(this.CurrentSelectRoleId) : 0;
				GenericLayout<NewPlayerAdventureV2RoleItem, int> roleLayout2 = this.RoleLayout;
				if (roleLayout2 == null)
				{
					return;
				}
				NewPlayerAdventureV2RoleItem layoutItemByIndex = roleLayout2.GetLayoutItemByIndex((num >= 0) ? num : 0);
				if (layoutItemByIndex == null)
				{
					return;
				}
				layoutItemByIndex.SelectToggle();
			}, false);
			return;
		}
	}

	// Token: 0x060062A7 RID: 25255 RVA: 0x001F6F9E File Offset: 0x001F519E
	private NewPlayerAdventureV2RoleItem InitRoleItem()
	{
		return new NewPlayerAdventureV2RoleItem
		{
			OnClickToggleCallBack = new Action<int, UUIExtendToggle>(this.OnClickRoleToggleCallBack)
		};
	}

	// Token: 0x060062A8 RID: 25256 RVA: 0x001F6FB7 File Offset: 0x001F51B7
	private NewPlayerAdventureV2AdventureItem InitAdventureItem()
	{
		return new NewPlayerAdventureV2AdventureItem
		{
			OnClickJumpToCallBack = new Action(this.RefreshRolePanelState)
		};
	}

	// Token: 0x060062A9 RID: 25257 RVA: 0x001F6FD0 File Offset: 0x001F51D0
	private void OnClickRoleToggleCallBack(int roleId, UUIExtendToggle toggle)
	{
		this.RefreshRolePanelState();
		base.PlayOrReplaySequence("Switch", false, null);
		if (this.CurrentSelectRoleId == roleId)
		{
			return;
		}
		this.CurrentSelectRoleId = roleId;
		UUIExtendToggle currentSelectToggle = this.CurrentSelectToggle;
		if (currentSelectToggle != null)
		{
			currentSelectToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.CurrentSelectToggle = toggle;
		IReadOnlyList<GachaRoleDevelopIns> gachaRoleDevelopInsByRoleId = ActivityRegressConfig.Instance.GetGachaRoleDevelopInsByRoleId(roleId);
		List<int> list = new List<int>();
		List<int> list2 = new List<int>();
		if (gachaRoleDevelopInsByRoleId != null)
		{
			for (int i = 0; i < gachaRoleDevelopInsByRoleId.Count; i++)
			{
				GachaRoleDevelopIns gachaRoleDevelopIns = gachaRoleDevelopInsByRoleId[i];
				if (gachaRoleDevelopIns.Type == 1)
				{
					list.Add(gachaRoleDevelopIns.Id);
				}
				if (gachaRoleDevelopIns.Type == 2)
				{
					list2.Add(gachaRoleDevelopIns.Id);
				}
			}
		}
		GenericLayout<NewPlayerAdventureV2AdventureItem, int> adventureLayout = this.AdventureLayout;
		if (adventureLayout != null)
		{
			adventureLayout.RefreshByData(list, null, true);
		}
		GenericLayout<NewPlayerAdventureV2AdventureItem, int> adventureLayout2 = this.AdventureLayout2;
		if (adventureLayout2 == null)
		{
			return;
		}
		adventureLayout2.RefreshByData(list2, null, true);
	}

	// Token: 0x04003FE0 RID: 16352
	private const int TimerIntervalMs = 1000;

	// Token: 0x04003FE1 RID: 16353
	private int CurrentSelectRoleId;

	// Token: 0x04003FE2 RID: 16354
	[Nullable(2)]
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x04003FE3 RID: 16355
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<NewPlayerAdventureV2RoleItem, int> RoleLayout;

	// Token: 0x04003FE4 RID: 16356
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<NewPlayerAdventureV2AdventureItem, int> AdventureLayout;

	// Token: 0x04003FE5 RID: 16357
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<NewPlayerAdventureV2AdventureItem, int> AdventureLayout2;

	// Token: 0x04003FE6 RID: 16358
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003FE7 RID: 16359
	[Nullable(2)]
	private TimerHandle RefreshTimer;

	// Token: 0x04003FE8 RID: 16360
	private readonly string RemainTimeFormat = ConfigMultiTextLang.GetLocalTextNew("ActivityRemainingTime", null) ?? "";
}
