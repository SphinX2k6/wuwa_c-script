using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200086C RID: 2156
[NullableContext(1)]
[Nullable(0)]
public class ActivityNewPlayerSupportSubView : ActivitySubViewBase
{
	// Token: 0x060061EE RID: 25070 RVA: 0x001F3F63 File Offset: 0x001F2163
	protected override void OnSetData()
	{
		this.ActivityData = (this.ActivityBaseData as ActivityNewPlayerSupportData);
	}

	// Token: 0x060061EF RID: 25071 RVA: 0x001F3F78 File Offset: 0x001F2178
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUITexture)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIText)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIText)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnChangeRoleClick))
		};
	}

	// Token: 0x060061F0 RID: 25072 RVA: 0x001F411C File Offset: 0x001F231C
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityNewPlayerSupportSubView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityNewPlayerSupportSubView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060061F1 RID: 25073 RVA: 0x001F4160 File Offset: 0x001F2360
	protected override void OnStart()
	{
		this.RemainTimeText = ConfigMultiTextLang.GetLocalTextNew("ActivityRemainingTime", null);
		this.ChosenText = ConfigCommonParamById.GetStringConfig("NewPlayerSupportTrialRoleChosenDesc");
		this.TaskLayout = new GenericLayout<ActivityNewPlayerSupportTaskItem, IActivityNewPlayerSupportTaskItemData>(base.GetHorizontalLayout(9), new Func<ActivityNewPlayerSupportTaskItem>(this.CreateLayoutItem), null, false, true);
		this.TimeTxt = base.GetText(1);
		this.IsRemainTimeActive = (this.ActivityData.EndShowTime != 0L);
		this.TimeTxt.SetUIActive(this.IsRemainTimeActive);
		base.GetText(0).SetText(this.ActivityData.GetTitle(), true);
		base.GetText(2).SetText(this.ActivityData.GetDesc(), true);
		RedDotController.Instance.BindRedDot(ERedDotName.RedDotNewPlayerSupportTrialRoleEntrance, base.GetItem(12), null, 0);
	}

	// Token: 0x060061F2 RID: 25074 RVA: 0x001F422C File Offset: 0x001F242C
	protected override void OnBeforeDestroy()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotNewPlayerSupportTrialRoleEntrance, base.GetItem(12), 0);
	}

	// Token: 0x060061F3 RID: 25075 RVA: 0x001F4246 File Offset: 0x001F2446
	protected override void OnBeforeShow()
	{
		this.RefreshTrailRoleView();
		this.RefreshTaskView();
		EventSystem.Instance.Emit(EEventName.OnActivityNewPlayerSupportEntranceRedDotUpdate);
	}

	// Token: 0x060061F4 RID: 25076 RVA: 0x001F4264 File Offset: 0x001F2464
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnActivityNewPlayerSupportTaskUpdate, new Action(this.OnTaskUpdate));
		EventSystem.Instance.Add<int>(EEventName.OnActivityNewPlayerSupportCurTrialRoleChange, new Action<int>(this.OnCurTrialRoleChange));
	}

	// Token: 0x060061F5 RID: 25077 RVA: 0x001F429E File Offset: 0x001F249E
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnActivityNewPlayerSupportTaskUpdate, new Action(this.OnTaskUpdate));
		EventSystem.Instance.Remove(EEventName.OnActivityNewPlayerSupportCurTrialRoleChange, new Action<int>(this.OnCurTrialRoleChange));
	}

	// Token: 0x060061F6 RID: 25078 RVA: 0x001F42D8 File Offset: 0x001F24D8
	protected override void OnRefreshView()
	{
		this.RefreshTrailRoleView();
		this.RefreshTaskView();
		EventSystem.Instance.Emit(EEventName.OnActivityNewPlayerSupportEntranceRedDotUpdate);
	}

	// Token: 0x060061F7 RID: 25079 RVA: 0x001F42F6 File Offset: 0x001F24F6
	private void SetRemainTimeActive(bool isActive)
	{
		if (this.IsRemainTimeActive == isActive)
		{
			return;
		}
		this.IsRemainTimeActive = isActive;
		this.TimeTxt.SetUIActive(isActive);
	}

	// Token: 0x060061F8 RID: 25080 RVA: 0x001F4318 File Offset: 0x001F2518
	private void SetRemainTimeText()
	{
		ValueTuple<bool, string> isInRemainTime = this.GetIsInRemainTime();
		bool item = isInRemainTime.Item1;
		string item2 = isInRemainTime.Item2;
		this.SetRemainTimeActive(item);
		if (item)
		{
			this.TimeTxt.SetText(item2, true);
		}
	}

	// Token: 0x060061F9 RID: 25081 RVA: 0x001F4350 File Offset: 0x001F2550
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private ValueTuple<bool, string> GetIsInRemainTime()
	{
		if (!this.ActivityData.CheckIfInShowTime())
		{
			return new ValueTuple<bool, string>(false, "");
		}
		string remainTimeText = ActivityModel.Instance.GetRemainTimeText(this.ActivityData.EndShowTime, this.RemainTimeText);
		return new ValueTuple<bool, string>(true, remainTimeText);
	}

	// Token: 0x060061FA RID: 25082 RVA: 0x001F4399 File Offset: 0x001F2599
	protected override void OnTimer(float gap)
	{
		this.SetRemainTimeText();
	}

	// Token: 0x060061FB RID: 25083 RVA: 0x001F43A4 File Offset: 0x001F25A4
	private void RefreshTrailRoleView()
	{
		TrialRoleGroupData curUseTrialRoleData = this.ActivityData.CurUseTrialRoleData;
		bool flag = curUseTrialRoleData != null;
		UUITexture roleTex = base.GetTexture(4);
		roleTex.SetUIActive(flag);
		UUIText text = base.GetText(11);
		text.SetUIActive(flag);
		UUIText text2 = base.GetText(13);
		text2.SetUIActive(!flag);
		UUIItem item = base.GetItem(14);
		UUIItem item2 = base.GetItem(15);
		if (flag)
		{
			TrialRoleConfig instance = TrialRoleConfig.Instance;
			RoleInfo? roleInfo = (instance != null) ? instance.GetRoleConfigByTrialRoleId(curUseTrialRoleData.TrialRoleId) : null;
			string formationRoleCard = roleInfo.Value.FormationRoleCard;
			base.SetTextureByPath(formationRoleCard, roleTex, null, delegate(bool _)
			{
				roleTex.SetSizeFromTexture();
			});
			string str = ConfigMultiTextLang.GetLocalTextNew(roleInfo.Value.Name, null) ?? "";
			string str2 = ConfigMultiTextLang.GetLocalTextNew(this.ChosenText, null) ?? "";
			text.SetText(str + " <color=#e6efff><size=-6>" + str2 + "</size></color>", true);
			LguiUtil.Instance.SetLocalTextNew(text2, this.ChosenText, Array.Empty<object>());
			item.SetUIActive(false);
			item2.SetUIActive(false);
			return;
		}
		EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
		item.SetUIActive(playerGender == EPlayerGender.Male);
		item2.SetUIActive(playerGender == EPlayerGender.Female);
		LguiUtil.Instance.SetLocalTextNew(text2, "PrefabTextItem_436156489_Text", Array.Empty<object>());
	}

	// Token: 0x060061FC RID: 25084 RVA: 0x001F452C File Offset: 0x001F272C
	private void RefreshTaskView()
	{
		ActivityNewPlayerSupportData activityData = this.ActivityData;
		List<ActivityNewPlayerSupportTaskData> list = (activityData != null) ? activityData.GetTaskDataList() : null;
		if (list == null)
		{
			return;
		}
		int count = list.Count;
		List<IActivityNewPlayerSupportTaskItemData> list2 = new List<IActivityNewPlayerSupportTaskItemData>();
		for (int i = 0; i < count; i++)
		{
			list2.Add(new ActivityNewPlayerSupportTaskItemData
			{
				TaskData = list[i],
				ShowDecoration = (i != count - 1)
			});
		}
		GenericLayout<ActivityNewPlayerSupportTaskItem, IActivityNewPlayerSupportTaskItemData> taskLayout = this.TaskLayout;
		if (taskLayout == null)
		{
			return;
		}
		taskLayout.RefreshByData(list2, null, false);
	}

	// Token: 0x060061FD RID: 25085 RVA: 0x001F45A4 File Offset: 0x001F27A4
	private void OnChangeRoleClick()
	{
		ActivityNewPlayerSupportController instance = ActivityNewPlayerSupportController.Instance;
		if (instance == null)
		{
			return;
		}
		instance.OpenTrialRoleView(null);
	}

	// Token: 0x060061FE RID: 25086 RVA: 0x001F45C9 File Offset: 0x001F27C9
	private ActivityNewPlayerSupportTaskItem CreateLayoutItem()
	{
		return new ActivityNewPlayerSupportTaskItem();
	}

	// Token: 0x060061FF RID: 25087 RVA: 0x001F45D0 File Offset: 0x001F27D0
	private void OnTaskUpdate()
	{
		this.RefreshTaskView();
	}

	// Token: 0x06006200 RID: 25088 RVA: 0x001F45D8 File Offset: 0x001F27D8
	private void OnCurTrialRoleChange(int _)
	{
		this.RefreshTrailRoleView();
	}

	// Token: 0x06006201 RID: 25089 RVA: 0x001F45E0 File Offset: 0x001F27E0
	private void AdventureEntranceFunc()
	{
		IActivityRegressMainViewOpenData activityRegressMainViewOpenData = new IActivityRegressMainViewOpenData
		{
			SubView = EActivityMainSubViewNewType.Adventure,
			OpenType = EActivityRegressMainViewOpenDataType.NewPlayer
		};
		UiManager.Instance.OpenView(EUiViewName.ActivityRegressMainView, activityRegressMainViewOpenData, null);
	}

	// Token: 0x06006202 RID: 25090 RVA: 0x001F4620 File Offset: 0x001F2820
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		string text = configParams[0];
		if (!(text == "NewPlayer_Award") && !text.Contains("NewPlayer_AwardSlot"))
		{
			return null;
		}
		int index = 0;
		GenericLayout<ActivityNewPlayerSupportTaskItem, IActivityNewPlayerSupportTaskItemData> taskLayout = this.TaskLayout;
		ActivityNewPlayerSupportTaskItem activityNewPlayerSupportTaskItem = (taskLayout != null) ? taskLayout.GetLayoutItemByIndex(index) : null;
		UUIItem uuiitem = (activityNewPlayerSupportTaskItem != null) ? activityNewPlayerSupportTaskItem.GetReceiveBtn() : null;
		if (text == "NewPlayer_Award")
		{
			if (uuiitem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}
		else
		{
			UUIItem uuiitem2 = (activityNewPlayerSupportTaskItem != null) ? activityNewPlayerSupportTaskItem.GetGuideUiItem("0") : null;
			if (uuiitem2 == null || uuiitem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem,
				uuiitem2
			};
		}
	}

	// Token: 0x04003F9D RID: 16285
	[Nullable(2)]
	private ActivityNewPlayerSupportData ActivityData;

	// Token: 0x04003F9E RID: 16286
	[Nullable(2)]
	private UUIText TimeTxt;

	// Token: 0x04003F9F RID: 16287
	private bool IsRemainTimeActive;

	// Token: 0x04003FA0 RID: 16288
	private string RemainTimeText = "";

	// Token: 0x04003FA1 RID: 16289
	private string ChosenText = "";

	// Token: 0x04003FA2 RID: 16290
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ActivityNewPlayerSupportTaskItem, IActivityNewPlayerSupportTaskItemData> TaskLayout;

	// Token: 0x04003FA3 RID: 16291
	[Nullable(2)]
	private ActivityNewPlayerSupportEntranceItem AdventureEntrance;

	// Token: 0x02006BB3 RID: 27571
	[NullableContext(0)]
	private static class EComponentType
	{
		// Token: 0x0402368C RID: 145036
		public const int TitleTxt = 0;

		// Token: 0x0402368D RID: 145037
		public const int TimeTxt = 1;

		// Token: 0x0402368E RID: 145038
		public const int DescTxt = 2;

		// Token: 0x0402368F RID: 145039
		public const int RoleItem = 3;

		// Token: 0x04023690 RID: 145040
		public const int RoleTex = 4;

		// Token: 0x04023691 RID: 145041
		public const int RoleLockTex = 5;

		// Token: 0x04023692 RID: 145042
		public const int EntranceItem1 = 6;

		// Token: 0x04023693 RID: 145043
		public const int EntranceItem2 = 7;

		// Token: 0x04023694 RID: 145044
		public const int EntranceItem3 = 8;

		// Token: 0x04023695 RID: 145045
		public const int TaskLayout = 9;

		// Token: 0x04023696 RID: 145046
		public const int TaskItem = 10;

		// Token: 0x04023697 RID: 145047
		public const int RoleTxt = 11;

		// Token: 0x04023698 RID: 145048
		public const int RedDotItem = 12;

		// Token: 0x04023699 RID: 145049
		public const int TrialTxt = 13;

		// Token: 0x0402369A RID: 145050
		public const int RoleLockItem1 = 14;

		// Token: 0x0402369B RID: 145051
		public const int RoleLockItem2 = 15;
	}
}
