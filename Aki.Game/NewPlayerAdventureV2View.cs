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

// Token: 0x020013CC RID: 5068
[NullableContext(1)]
[Nullable(0)]
public class NewPlayerAdventureV2View : UiViewBase
{
	// Token: 0x06008F07 RID: 36615 RVA: 0x001EE0AB File Offset: 0x001EC2AB
	public NewPlayerAdventureV2View(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06008F08 RID: 36616 RVA: 0x001EE0D0 File Offset: 0x001EC2D0
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

	// Token: 0x06008F09 RID: 36617 RVA: 0x001EE1C8 File Offset: 0x001EC3C8
	protected override UniTask OnBeforeStartAsync()
	{
		NewPlayerAdventureV2View.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<NewPlayerAdventureV2View.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008F0A RID: 36618 RVA: 0x001EE204 File Offset: 0x001EC404
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

	// Token: 0x06008F0B RID: 36619 RVA: 0x001EE2F7 File Offset: 0x001EC4F7
	protected override void OnBeforeDestroy()
	{
		if (this.RefreshTimer != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.RefreshTimer);
			this.RefreshTimer = null;
		}
	}

	// Token: 0x06008F0C RID: 36620 RVA: 0x001EE319 File Offset: 0x001EC519
	private void RefreshTime(float delta)
	{
		base.GetText(8).SetText(this.GetRemainTimeText(), true);
	}

	// Token: 0x06008F0D RID: 36621 RVA: 0x001EE330 File Offset: 0x001EC530
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

	// Token: 0x06008F0E RID: 36622 RVA: 0x001EE38D File Offset: 0x001EC58D
	[NullableContext(2)]
	private ActivityNewPlayerSupportActivityV2Controller GetActivityController()
	{
		return ActivityManager.GetActivityController(ActivityType.NewPlayerSupportActivityV2) as ActivityNewPlayerSupportActivityV2Controller;
	}

	// Token: 0x06008F0F RID: 36623 RVA: 0x001EE39B File Offset: 0x001EC59B
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x06008F10 RID: 36624 RVA: 0x001EE3A4 File Offset: 0x001EC5A4
	private List<int> GetRoleIdList()
	{
		INewPlayerAdventureV2ViewOpenData newPlayerAdventureV2ViewOpenData = this.OpenParam as INewPlayerAdventureV2ViewOpenData;
		return ((newPlayerAdventureV2ViewOpenData != null) ? newPlayerAdventureV2ViewOpenData.RoleIdList : null) ?? new List<int>();
	}

	// Token: 0x06008F11 RID: 36625 RVA: 0x001EE3C8 File Offset: 0x001EC5C8
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

	// Token: 0x06008F12 RID: 36626 RVA: 0x001EE47E File Offset: 0x001EC67E
	private NewPlayerAdventureV2RoleItem InitRoleItem()
	{
		return new NewPlayerAdventureV2RoleItem
		{
			OnClickToggleCallBack = new Action<int, UUIExtendToggle>(this.OnClickRoleToggleCallBack)
		};
	}

	// Token: 0x06008F13 RID: 36627 RVA: 0x001EE497 File Offset: 0x001EC697
	private NewPlayerAdventureV2AdventureItem InitAdventureItem()
	{
		return new NewPlayerAdventureV2AdventureItem
		{
			OnClickJumpToCallBack = new Action(this.RefreshRolePanelState)
		};
	}

	// Token: 0x06008F14 RID: 36628 RVA: 0x001EE4B0 File Offset: 0x001EC6B0
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

	// Token: 0x04003F48 RID: 16200
	private const int TimerIntervalMs = 1000;

	// Token: 0x04003F49 RID: 16201
	private int CurrentSelectRoleId;

	// Token: 0x04003F4A RID: 16202
	[Nullable(2)]
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x04003F4B RID: 16203
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<NewPlayerAdventureV2RoleItem, int> RoleLayout;

	// Token: 0x04003F4C RID: 16204
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<NewPlayerAdventureV2AdventureItem, int> AdventureLayout;

	// Token: 0x04003F4D RID: 16205
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<NewPlayerAdventureV2AdventureItem, int> AdventureLayout2;

	// Token: 0x04003F4E RID: 16206
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003F4F RID: 16207
	[Nullable(2)]
	private TimerHandle RefreshTimer;

	// Token: 0x04003F50 RID: 16208
	private readonly string RemainTimeFormat = ConfigMultiTextLang.GetLocalTextNew("ActivityRemainingTime", null) ?? "";
}
