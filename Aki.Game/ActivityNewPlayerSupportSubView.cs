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

// Token: 0x020013B8 RID: 5048
[NullableContext(1)]
[Nullable(0)]
public class ActivityNewPlayerSupportSubView : ActivitySubViewBase
{
	// Token: 0x06008E59 RID: 36441 RVA: 0x001EB443 File Offset: 0x001E9643
	protected override void OnSetData()
	{
		this.ActivityData = (this.ActivityBaseData as ActivityNewPlayerSupportData);
	}

	// Token: 0x06008E5A RID: 36442 RVA: 0x001EB458 File Offset: 0x001E9658
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

	// Token: 0x06008E5B RID: 36443 RVA: 0x001EB5FC File Offset: 0x001E97FC
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityNewPlayerSupportSubView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityNewPlayerSupportSubView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008E5C RID: 36444 RVA: 0x001EB640 File Offset: 0x001E9840
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

	// Token: 0x06008E5D RID: 36445 RVA: 0x001EB70C File Offset: 0x001E990C
	protected override void OnBeforeDestroy()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotNewPlayerSupportTrialRoleEntrance, base.GetItem(12), 0);
	}

	// Token: 0x06008E5E RID: 36446 RVA: 0x001EB726 File Offset: 0x001E9926
	protected override void OnBeforeShow()
	{
		this.RefreshTrailRoleView();
		this.RefreshTaskView();
		EventSystem.Instance.Emit(EEventName.OnActivityNewPlayerSupportEntranceRedDotUpdate);
	}

	// Token: 0x06008E5F RID: 36447 RVA: 0x001EB744 File Offset: 0x001E9944
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnActivityNewPlayerSupportTaskUpdate, new Action(this.OnTaskUpdate));
		EventSystem.Instance.Add<int>(EEventName.OnActivityNewPlayerSupportCurTrialRoleChange, new Action<int>(this.OnCurTrialRoleChange));
	}

	// Token: 0x06008E60 RID: 36448 RVA: 0x001EB77E File Offset: 0x001E997E
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnActivityNewPlayerSupportTaskUpdate, new Action(this.OnTaskUpdate));
		EventSystem.Instance.Remove(EEventName.OnActivityNewPlayerSupportCurTrialRoleChange, new Action<int>(this.OnCurTrialRoleChange));
	}

	// Token: 0x06008E61 RID: 36449 RVA: 0x001EB7B8 File Offset: 0x001E99B8
	protected override void OnRefreshView()
	{
		this.RefreshTrailRoleView();
		this.RefreshTaskView();
		EventSystem.Instance.Emit(EEventName.OnActivityNewPlayerSupportEntranceRedDotUpdate);
	}

	// Token: 0x06008E62 RID: 36450 RVA: 0x001EB7D6 File Offset: 0x001E99D6
	private void SetRemainTimeActive(bool isActive)
	{
		if (this.IsRemainTimeActive == isActive)
		{
			return;
		}
		this.IsRemainTimeActive = isActive;
		this.TimeTxt.SetUIActive(isActive);
	}

	// Token: 0x06008E63 RID: 36451 RVA: 0x001EB7F8 File Offset: 0x001E99F8
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

	// Token: 0x06008E64 RID: 36452 RVA: 0x001EB830 File Offset: 0x001E9A30
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

	// Token: 0x06008E65 RID: 36453 RVA: 0x001EB879 File Offset: 0x001E9A79
	protected override void OnTimer(float gap)
	{
		this.SetRemainTimeText();
	}

	// Token: 0x06008E66 RID: 36454 RVA: 0x001EB884 File Offset: 0x001E9A84
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

	// Token: 0x06008E67 RID: 36455 RVA: 0x001EBA0C File Offset: 0x001E9C0C
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

	// Token: 0x06008E68 RID: 36456 RVA: 0x001EBA84 File Offset: 0x001E9C84
	private void OnChangeRoleClick()
	{
		ActivityNewPlayerSupportController instance = ActivityNewPlayerSupportController.Instance;
		if (instance == null)
		{
			return;
		}
		instance.OpenTrialRoleView(null);
	}

	// Token: 0x06008E69 RID: 36457 RVA: 0x001EBAA9 File Offset: 0x001E9CA9
	private ActivityNewPlayerSupportTaskItem CreateLayoutItem()
	{
		return new ActivityNewPlayerSupportTaskItem();
	}

	// Token: 0x06008E6A RID: 36458 RVA: 0x001EBAB0 File Offset: 0x001E9CB0
	private void OnTaskUpdate()
	{
		this.RefreshTaskView();
	}

	// Token: 0x06008E6B RID: 36459 RVA: 0x001EBAB8 File Offset: 0x001E9CB8
	private void OnCurTrialRoleChange(int _)
	{
		this.RefreshTrailRoleView();
	}

	// Token: 0x06008E6C RID: 36460 RVA: 0x001EBAC0 File Offset: 0x001E9CC0
	private void AdventureEntranceFunc()
	{
		IActivityRegressMainViewOpenData activityRegressMainViewOpenData = new IActivityRegressMainViewOpenData
		{
			SubView = EActivityMainSubViewNewType.Adventure,
			OpenType = EActivityRegressMainViewOpenDataType.NewPlayer
		};
		UiManager.Instance.OpenView(EUiViewName.ActivityRegressMainView, activityRegressMainViewOpenData, null);
	}

	// Token: 0x06008E6D RID: 36461 RVA: 0x001EBB00 File Offset: 0x001E9D00
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

	// Token: 0x04003F05 RID: 16133
	[Nullable(2)]
	private ActivityNewPlayerSupportData ActivityData;

	// Token: 0x04003F06 RID: 16134
	[Nullable(2)]
	private UUIText TimeTxt;

	// Token: 0x04003F07 RID: 16135
	private bool IsRemainTimeActive;

	// Token: 0x04003F08 RID: 16136
	private string RemainTimeText = "";

	// Token: 0x04003F09 RID: 16137
	private string ChosenText = "";

	// Token: 0x04003F0A RID: 16138
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ActivityNewPlayerSupportTaskItem, IActivityNewPlayerSupportTaskItemData> TaskLayout;

	// Token: 0x04003F0B RID: 16139
	[Nullable(2)]
	private ActivityNewPlayerSupportEntranceItem AdventureEntrance;

	// Token: 0x02007A2D RID: 31277
	[NullableContext(0)]
	private static class EComponentType
	{
		// Token: 0x0402836F RID: 164719
		public const int TitleTxt = 0;

		// Token: 0x04028370 RID: 164720
		public const int TimeTxt = 1;

		// Token: 0x04028371 RID: 164721
		public const int DescTxt = 2;

		// Token: 0x04028372 RID: 164722
		public const int RoleItem = 3;

		// Token: 0x04028373 RID: 164723
		public const int RoleTex = 4;

		// Token: 0x04028374 RID: 164724
		public const int RoleLockTex = 5;

		// Token: 0x04028375 RID: 164725
		public const int EntranceItem1 = 6;

		// Token: 0x04028376 RID: 164726
		public const int EntranceItem2 = 7;

		// Token: 0x04028377 RID: 164727
		public const int EntranceItem3 = 8;

		// Token: 0x04028378 RID: 164728
		public const int TaskLayout = 9;

		// Token: 0x04028379 RID: 164729
		public const int TaskItem = 10;

		// Token: 0x0402837A RID: 164730
		public const int RoleTxt = 11;

		// Token: 0x0402837B RID: 164731
		public const int RedDotItem = 12;

		// Token: 0x0402837C RID: 164732
		public const int TrialTxt = 13;

		// Token: 0x0402837D RID: 164733
		public const int RoleLockItem1 = 14;

		// Token: 0x0402837E RID: 164734
		public const int RoleLockItem2 = 15;
	}
}
