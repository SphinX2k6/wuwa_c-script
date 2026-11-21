using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001CC8 RID: 7368
[NullableContext(2)]
[Nullable(0)]
public class RoleTowerActivityView : UiViewBase
{
	// Token: 0x060123DD RID: 74717 RVA: 0x00560B66 File Offset: 0x0055ED66
	[NullableContext(1)]
	public RoleTowerActivityView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060123DE RID: 74718 RVA: 0x00560B70 File Offset: 0x0055ED70
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(11, typeof(UUITexture)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickBuff)),
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickRank)),
			new ValueTuple<int, Delegate>(7, new Action(this.OnClickReward)),
			new ValueTuple<int, Delegate>(10, new Action(this.OnClickLearn)),
			new ValueTuple<int, Delegate>(13, new Action(this.OnClickBattle))
		};
	}

	// Token: 0x060123DF RID: 74719 RVA: 0x00560D8C File Offset: 0x0055EF8C
	protected override void OnStart()
	{
		this.UiViewSequence.StartSequenceName = "StartZ";
		this.Caption = new PopupCaptionItem(base.GetItem(15));
		this.Caption.SetCloseCallBack(delegate
		{
			if (GameModeController.Instance.IsInInstance())
			{
				RoleTowerModel.Instance.LeaveDungeon();
			}
			base.CloseMe(null);
		});
		RoleTowerModel.Instance.AddHomeBtnLeaveDungeonCallback(this.UiBehaviourHomeBtn);
		this.RefreshGroupButtons();
		UUIItem item = base.GetItem(4);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x060123E0 RID: 74720 RVA: 0x00560DFC File Offset: 0x0055EFFC
	protected override UniTask OnPlayingStartSequenceAsync()
	{
		if ((this.OpenParam as bool?).GetValueOrDefault())
		{
			RoleTowerModel.Instance.NotifyActivityIntroStart();
		}
		return UniTask.CompletedTask;
	}

	// Token: 0x060123E1 RID: 74721 RVA: 0x00560E34 File Offset: 0x0055F034
	protected override void OnBeforeShow()
	{
		ActivityRoleTowerData activityData = this.GetActivityData();
		if (activityData != null)
		{
			activityData.ReadFirstOpenPageRedDot();
		}
		this.RefreshTitle();
		this.RefreshLimitReward();
		this.RefreshRedDots();
		this.UpdateRemainTime();
		this.RefreshTimerHandle = TimerSystem.Instance.Forever(new TTimerAction(this.OnTimerRefresh), 500f, 1f, null, null, true);
	}

	// Token: 0x060123E2 RID: 74722 RVA: 0x00560E94 File Offset: 0x0055F094
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RoleTowerRewardReceive, new Action(this.RefreshLimitReward));
		EventSystem.Instance.Add(EEventName.RoleTowerInfoUpdate, new Action(this.RefreshLimitReward));
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnActivityRedDotRefresh));
	}

	// Token: 0x060123E3 RID: 74723 RVA: 0x00560EF8 File Offset: 0x0055F0F8
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RoleTowerRewardReceive, new Action(this.RefreshLimitReward));
		EventSystem.Instance.Remove(EEventName.RoleTowerInfoUpdate, new Action(this.RefreshLimitReward));
		EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnActivityRedDotRefresh));
	}

	// Token: 0x060123E4 RID: 74724 RVA: 0x00560F59 File Offset: 0x0055F159
	protected override void OnBeforeDestroy()
	{
		this.ClearTimer();
	}

	// Token: 0x060123E5 RID: 74725 RVA: 0x00560F64 File Offset: 0x0055F164
	private void RefreshTitle()
	{
		ActivityRoleTowerData activityData = this.GetActivityData();
		string text = (activityData != null) ? activityData.GetTitleTextId() : null;
		if (!string.IsNullOrEmpty(text))
		{
			UUIText text2 = base.GetText(0);
			if (text2 == null)
			{
				return;
			}
			text2.ShowTextNew(text);
		}
	}

	// Token: 0x060123E6 RID: 74726 RVA: 0x00560FA0 File Offset: 0x0055F1A0
	private void RefreshGroupButtons()
	{
		int num = 0;
		int num2 = 0;
		foreach (RoleTowerLevelGroup roleTowerLevelGroup in RoleTowerModel.Instance.GetGroupCfgList())
		{
			if (roleTowerLevelGroup.Type == 1)
			{
				num = roleTowerLevelGroup.Id;
			}
			else if (roleTowerLevelGroup.Type == 2)
			{
				num2 = roleTowerLevelGroup.Id;
			}
		}
		this.CurTeachGroupId = num;
		this.CurRoleGroupId = num2;
		UUIButtonComponent button = base.GetButton(10);
		if (button != null)
		{
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(num > 0);
			}
		}
		UUIButtonComponent button2 = base.GetButton(13);
		if (button2 != null)
		{
			UUIItem uuiitem2 = button2.RootUIComp.Get();
			if (uuiitem2 != null)
			{
				uuiitem2.SetUIActive(num2 > 0);
			}
		}
		bool uiactive = num2 > 0 && RoleTowerModel.Instance.IsGroupAllLocked(num2);
		UUIItem item = base.GetItem(16);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(uiactive);
	}

	// Token: 0x060123E7 RID: 74727 RVA: 0x005610A0 File Offset: 0x0055F2A0
	private void RefreshLimitReward()
	{
		int num = 0;
		int num2 = 0;
		foreach (RoleTowerReward roleTowerReward in RoleTowerModel.Instance.GetRewardCfgList())
		{
			num2++;
			RoleTowerRewardData rewardState = RoleTowerModel.Instance.GetRewardState(roleTowerReward.Id);
			if (rewardState != null && rewardState.State == ERoleTowerRewardState.Received)
			{
				num++;
			}
		}
		UUIText text = base.GetText(8);
		if (text == null)
		{
			return;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(num);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x060123E8 RID: 74728 RVA: 0x00561158 File Offset: 0x0055F358
	private void RefreshRedDots()
	{
		ActivityRoleTowerData activityData = this.GetActivityData();
		UUIItem item = base.GetItem(12);
		if (item != null)
		{
			item.SetUIActive(this.CurTeachGroupId > 0 && activityData != null && activityData.HasTeachRedDot());
		}
		UUIItem item2 = base.GetItem(14);
		if (item2 != null)
		{
			item2.SetUIActive(this.CurRoleGroupId > 0 && activityData != null && activityData.HasNewLevelRedDot(ActivityRoleTowerData.ENewLevelRedDotDepth.RoleGroupButton));
		}
		UUIItem item3 = base.GetItem(6);
		if (item3 != null)
		{
			item3.SetUIActive(activityData != null && activityData.HasAnyNewRecordRedDot());
		}
		UUIItem item4 = base.GetItem(9);
		if (item4 == null)
		{
			return;
		}
		item4.SetUIActive(RoleTowerModel.Instance.HasAnyRedDot());
	}

	// Token: 0x060123E9 RID: 74729 RVA: 0x00561200 File Offset: 0x0055F400
	private void OnActivityRedDotRefresh(int activityId)
	{
		ActivityRoleTowerData activityData = this.GetActivityData();
		int? num = (activityData != null) ? new int?(activityData.Id) : null;
		if (!(activityId == num.GetValueOrDefault() & num != null))
		{
			return;
		}
		this.RefreshRedDots();
	}

	// Token: 0x060123EA RID: 74730 RVA: 0x00561248 File Offset: 0x0055F448
	private void OnTimerRefresh(float delta)
	{
		this.UpdateRemainTime();
	}

	// Token: 0x060123EB RID: 74731 RVA: 0x00561250 File Offset: 0x0055F450
	private void UpdateRemainTime()
	{
		ActivityRoleTowerData activityData = this.GetActivityData();
		if (activityData != null)
		{
			ValueTuple<bool, string, long> timeVisibleAndRemainTime = ActivityModel.Instance.GetTimeVisibleAndRemainTime(activityData, null);
			bool item = timeVisibleAndRemainTime.Item1;
			string item2 = timeVisibleAndRemainTime.Item2;
			UUIItem item3 = base.GetItem(1);
			if (item3 != null)
			{
				item3.SetUIActive(item);
			}
			if (item)
			{
				UUIText text = base.GetText(2);
				if (text == null)
				{
					return;
				}
				text.SetText(item2, true);
			}
			return;
		}
		UUIItem item4 = base.GetItem(1);
		if (item4 == null)
		{
			return;
		}
		item4.SetUIActive(false);
	}

	// Token: 0x060123EC RID: 74732 RVA: 0x005612BC File Offset: 0x0055F4BC
	private void ClearTimer()
	{
		if (this.RefreshTimerHandle != null)
		{
			TimerSystem.Instance.Remove(this.RefreshTimerHandle);
			this.RefreshTimerHandle = null;
		}
	}

	// Token: 0x060123ED RID: 74733 RVA: 0x005612DE File Offset: 0x0055F4DE
	private void OnClickBuff()
	{
		RoleTowerModel.Instance.OpenTokenCodexView();
	}

	// Token: 0x060123EE RID: 74734 RVA: 0x005612EA File Offset: 0x0055F4EA
	private void OnClickRank()
	{
		RoleTowerModel.Instance.OpenRankView(0);
	}

	// Token: 0x060123EF RID: 74735 RVA: 0x005612F7 File Offset: 0x0055F4F7
	private void OnClickReward()
	{
		RoleTowerModel.Instance.OpenRewardView();
	}

	// Token: 0x060123F0 RID: 74736 RVA: 0x00561304 File Offset: 0x0055F504
	private void OnClickLearn()
	{
		if (this.CurTeachGroupId <= 0)
		{
			return;
		}
		ActivityRoleTowerData activityData = this.GetActivityData();
		if (activityData != null)
		{
			activityData.ClearTeachRedDot();
		}
		IReadOnlyList<RoleTowerLevel> levelCfgListByGroup = RoleTowerModel.Instance.GetLevelCfgListByGroup(this.CurTeachGroupId);
		int num = (levelCfgListByGroup.Count > 0) ? levelCfgListByGroup[0].Id : 0;
		RoleTowerLevelData levelState = RoleTowerModel.Instance.GetLevelState(num);
		bool isFromSave = levelState != null && levelState.HasSave;
		RoleTowerModel.Instance.OpenPrepareView(num, isFromSave, false, false);
	}

	// Token: 0x060123F1 RID: 74737 RVA: 0x00561380 File Offset: 0x0055F580
	private void OnClickBattle()
	{
		if (this.CurRoleGroupId <= 0)
		{
			return;
		}
		if (RoleTowerModel.Instance.IsGroupAllLocked(this.CurRoleGroupId))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("RoleTowerLevelGroupLockTips", Array.Empty<object>());
			return;
		}
		RoleTowerModel.Instance.OpenLevelSelectView(this.CurRoleGroupId);
	}

	// Token: 0x060123F2 RID: 74738 RVA: 0x005613CE File Offset: 0x0055F5CE
	private ActivityRoleTowerData GetActivityData()
	{
		return ActivityRoleTowerController.Instance.Data;
	}

	// Token: 0x04009F6A RID: 40810
	private TimerHandle RefreshTimerHandle;

	// Token: 0x04009F6B RID: 40811
	private PopupCaptionItem Caption;

	// Token: 0x04009F6C RID: 40812
	private int CurTeachGroupId;

	// Token: 0x04009F6D RID: 40813
	private int CurRoleGroupId;

	// Token: 0x02007FB8 RID: 32696
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402951A RID: 169242
		public const int TxtTitle = 0;

		// Token: 0x0402951B RID: 169243
		public const int PnlTime = 1;

		// Token: 0x0402951C RID: 169244
		public const int TxtTime = 2;

		// Token: 0x0402951D RID: 169245
		public const int BtnBuff = 3;

		// Token: 0x0402951E RID: 169246
		public const int BtnBuffRedDot = 4;

		// Token: 0x0402951F RID: 169247
		public const int BtnRank = 5;

		// Token: 0x04029520 RID: 169248
		public const int BtnRankRedDot = 6;

		// Token: 0x04029521 RID: 169249
		public const int BtnReward = 7;

		// Token: 0x04029522 RID: 169250
		public const int TxtRewardValue = 8;

		// Token: 0x04029523 RID: 169251
		public const int BtnRewardRedDot = 9;

		// Token: 0x04029524 RID: 169252
		public const int BtnLearn = 10;

		// Token: 0x04029525 RID: 169253
		public const int TexRole = 11;

		// Token: 0x04029526 RID: 169254
		public const int BtnLearnRedDot = 12;

		// Token: 0x04029527 RID: 169255
		public const int BtnBattle = 13;

		// Token: 0x04029528 RID: 169256
		public const int BtnBattleRedDot = 14;

		// Token: 0x04029529 RID: 169257
		public const int UiItemCaption = 15;

		// Token: 0x0402952A RID: 169258
		public const int PnlBattleLock = 16;
	}
}
