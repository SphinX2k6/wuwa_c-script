using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x02005154 RID: 20820
	[NullableContext(1)]
	[Nullable(0)]
	public class RoadBookMainView : UiViewBase
	{
		// Token: 0x060340A6 RID: 213158 RVA: 0x00E8EC43 File Offset: 0x00E8CE43
		public RoadBookMainView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060340A7 RID: 213159 RVA: 0x00E8EC60 File Offset: 0x00E8CE60
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIArtText)),
				new ValueTuple<int, Type>(3, typeof(UUIArtText)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIText)),
				new ValueTuple<int, Type>(13, typeof(UUITexture)),
				new ValueTuple<int, Type>(14, typeof(UUITexture)),
				new ValueTuple<int, Type>(15, typeof(UUIItem)),
				new ValueTuple<int, Type>(16, typeof(UUIItem)),
				new ValueTuple<int, Type>(17, typeof(UUIItem)),
				new ValueTuple<int, Type>(18, typeof(UUIText)),
				new ValueTuple<int, Type>(19, typeof(UUIItem)),
				new ValueTuple<int, Type>(20, typeof(UUIItem))
			};
		}

		// Token: 0x060340A8 RID: 213160 RVA: 0x00E8EE54 File Offset: 0x00E8D054
		protected override UniTask OnBeforeStartAsync()
		{
			RoadBookMainView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoadBookMainView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060340A9 RID: 213161 RVA: 0x00E8EE97 File Offset: 0x00E8D097
		protected override void OnStart()
		{
			this.SelectedLevel = this.ActivityBaseData.TravelLevel;
		}

		// Token: 0x060340AA RID: 213162 RVA: 0x00E8EEAA File Offset: 0x00E8D0AA
		protected override void OnBeforeShow()
		{
			this.RefreshExpComponent(this.SelectedLevel);
			this.RefreshSubViewButton();
		}

		// Token: 0x060340AB RID: 213163 RVA: 0x00E8EEBE File Offset: 0x00E8D0BE
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnRewardViewClose));
		}

		// Token: 0x060340AC RID: 213164 RVA: 0x00E8EED9 File Offset: 0x00E8D0D9
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnRewardViewClose));
		}

		// Token: 0x060340AD RID: 213165 RVA: 0x00E8EEF4 File Offset: 0x00E8D0F4
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x060340AE RID: 213166 RVA: 0x00E8EEF8 File Offset: 0x00E8D0F8
		private UniTask CreateSubViewButton()
		{
			RoadBookMainView.<CreateSubViewButton>d__18 <CreateSubViewButton>d__;
			<CreateSubViewButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateSubViewButton>d__.<>4__this = this;
			<CreateSubViewButton>d__.<>1__state = -1;
			<CreateSubViewButton>d__.<>t__builder.Start<RoadBookMainView.<CreateSubViewButton>d__18>(ref <CreateSubViewButton>d__);
			return <CreateSubViewButton>d__.<>t__builder.Task;
		}

		// Token: 0x060340AF RID: 213167 RVA: 0x00E8EF3C File Offset: 0x00E8D13C
		protected void OnOpenSubView(ERoadBookSubType type)
		{
			switch (type)
			{
			case ERoadBookSubType.TravelTask:
				UiManager.Instance.OpenView(EUiViewName.RoadBookTravelTaskView, this.ActivityBaseData, null);
				return;
			case ERoadBookSubType.PhantomQuest:
				break;
			case ERoadBookSubType.PhantomCollect:
				UiManager.Instance.OpenView(EUiViewName.RoadBookPhantomTaskView, this.ActivityBaseData, null);
				break;
			case ERoadBookSubType.MotorChallenge:
				UiManager.Instance.OpenView(EUiViewName.RoadBookVehicleTaskView, this.ActivityBaseData, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x060340B0 RID: 213168 RVA: 0x00E8EFA6 File Offset: 0x00E8D1A6
		private void OnClickedLevelUpButton()
		{
			ActivityRoadBookController.Instance.RequestRoadBookLevelUp(delegate(bool success)
			{
				this.NeedLevelUp = success;
				this.LevelUp();
			});
		}

		// Token: 0x060340B1 RID: 213169 RVA: 0x00E8EFC0 File Offset: 0x00E8D1C0
		private void LevelUp()
		{
			if (this.NeedLevelUp)
			{
				this.UiViewSequence.PlaySequence("LevelUp", false, null);
				if (this.SelectedLevel < this.ActivityBaseData.MaxTravelLevel)
				{
					this.SelectedLevel++;
				}
				this.RefreshExpComponent(this.SelectedLevel);
				this.RefreshSubViewButton();
				this.NeedLevelUp = false;
			}
		}

		// Token: 0x060340B2 RID: 213170 RVA: 0x00E8F029 File Offset: 0x00E8D229
		private void OnRewardViewClose(EUiViewName viewName, int viewId)
		{
			if (this.SelectedViewType != ERoadBookSubType.Main)
			{
				return;
			}
			if (viewName == EUiViewName.CommonRewardView)
			{
				this.LevelUp();
			}
			if (viewName == EUiViewName.RoleLevelUpSuccessAttributeView)
			{
				this.LevelUp();
			}
		}

		// Token: 0x060340B3 RID: 213171 RVA: 0x00E8F05C File Offset: 0x00E8D25C
		private void RefreshExpComponent(int level)
		{
			bool hasClaimed = level < this.ActivityBaseData.TravelLevel;
			if (level < this.ActivityBaseData.TravelLevel)
			{
				this.SetPerformanceFinishedLevel(level);
			}
			else if (level == this.ActivityBaseData.TravelLevel)
			{
				this.SetPerformanceCurrentLevel(level);
			}
			else
			{
				this.SetPerformanceUnFinishedLevel(level);
			}
			if (this.ActivityBaseData.CanTravelLevelUp())
			{
				this.BtnLeft.SetRedDotVisible(level > this.ActivityBaseData.TravelLevel);
				this.BtnRight.SetRedDotVisible(level < this.ActivityBaseData.TravelLevel);
			}
			else
			{
				this.BtnLeft.SetRedDotVisible(false);
				this.BtnRight.SetRedDotVisible(false);
			}
			IRoadBookLevelData roadBookLevelData;
			this.ActivityBaseData.TravelLevelData.TryGetValue(level, out roadBookLevelData);
			if (roadBookLevelData == null)
			{
				return;
			}
			RoadBookLevelExp value = ActivityRoadBookConfig.Instance.GetLevelExpConfig(roadBookLevelData.Id).Value;
			base.GetArtText(2).SetText(level.ToString());
			base.GetArtText(3).SetText(level.ToString());
			List<TItem> list = (value.RewardDropId > 0) ? CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(value.RewardDropId) : new List<TItem>();
			List<IItemGridData> list2 = new List<IItemGridData>();
			foreach (TItem item in list)
			{
				ItemGridData item2 = new ItemGridData
				{
					Item = item,
					HasClaimed = hasClaimed
				};
				list2.Add(item2);
			}
			this.LevelRewardLayout.RefreshByData(list2, null, false);
			UUIText text = base.GetText(12);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Lv.");
				defaultInterpolatedStringHandler.AppendFormatted<int>(level + 1);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			base.GetItem(6).SetUIActive(level > 0);
			base.GetItem(5).SetUIActive(level < this.ActivityBaseData.MaxTravelLevel);
		}

		// Token: 0x060340B4 RID: 213172 RVA: 0x00E8F254 File Offset: 0x00E8D454
		private void RefreshSubViewButton()
		{
			foreach (KeyValuePair<ERoadBookSubType, RoadBookSubViewButton> keyValuePair in this.SubViewButtonMap)
			{
				ERoadBookSubType key = keyValuePair.Key;
				RoadBookSubViewButton value = keyValuePair.Value;
				ValueTuple<int, int> typeProgress = this.ActivityBaseData.GetTypeProgress(key);
				int item = typeProgress.Item1;
				int item2 = typeProgress.Item2;
				int value2 = (int)Math.Ceiling((double)item / (double)item2 * 100.0);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(value2);
				defaultInterpolatedStringHandler.AppendLiteral("%");
				value.SetProgressText(defaultInterpolatedStringHandler.ToStringAndClear());
				bool typeRedDotState = this.ActivityBaseData.GetTypeRedDotState(key);
				bool typeNewState = this.ActivityBaseData.GetTypeNewState(key);
				value.RefreshRedDot(typeRedDotState || typeNewState);
			}
		}

		// Token: 0x060340B5 RID: 213173 RVA: 0x00E8F338 File Offset: 0x00E8D538
		private void SetLevelProgress(int current, int target)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "RoadBookExp_Text", new <>z__ReadOnlyArray<object>(new object[]
			{
				current,
				target
			}));
			base.GetText(4).SetUIActive(true);
		}

		// Token: 0x060340B6 RID: 213174 RVA: 0x00E8F388 File Offset: 0x00E8D588
		private void SetPerformanceFinishedLevel(int level)
		{
			base.GetItem(17).SetUIActive(true);
			base.GetItem(19).SetUIActive(true);
			base.GetItem(15).SetUIActive(true);
			base.GetItem(16).SetUIActive(false);
			if (level != this.ActivityBaseData.TravelLevel)
			{
				this.LevelUpButton.SetEnableClick(false);
				this.LevelUpButton.SetRedDotVisible(false);
				this.LevelUpButton.SetShowText("RoadBookClaimed_Text");
			}
			else
			{
				this.LevelUpButton.SetShowText("RoadBookLevelUp_Text");
				this.LevelUpButton.SetRedDotVisible(false);
				this.LevelUpButton.SetEnableClick(false);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "RoadBookLevelMax_Text", Array.Empty<object>());
		}

		// Token: 0x060340B7 RID: 213175 RVA: 0x00E8F448 File Offset: 0x00E8D648
		private void SetPerformanceCurrentLevel(int level)
		{
			bool flag = this.ActivityBaseData.MaxTravelLevel == level;
			bool flag2 = !flag && this.ActivityBaseData.CanTravelLevelUp();
			int currentExp = this.ActivityBaseData.GetCurrentExp();
			int currentTargetExp = this.ActivityBaseData.GetCurrentTargetExp();
			base.GetItem(17).SetUIActive(true);
			base.GetItem(19).SetUIActive(true);
			if (flag)
			{
				base.GetItem(15).SetUIActive(true);
				base.GetItem(16).SetUIActive(true);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(18), "PrefabTextItem_2612260890_Text", Array.Empty<object>());
				base.GetItem(20).SetUIActive(true);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "RoadBookLevelMax_Text", Array.Empty<object>());
				base.GetText(4).SetUIActive(true);
			}
			else
			{
				this.SetLevelProgress(currentExp, currentTargetExp);
				base.GetItem(15).SetUIActive(false);
				base.GetItem(16).SetUIActive(false);
			}
			if (flag2)
			{
				this.UiViewSequence.PlaySequence("PreLevelUp", false, null);
				this.LevelUpButton.SetShowText("RoadBookLevelUp_Text");
				this.LevelUpButton.SetRedDotVisible(true);
				this.LevelUpButton.SetEnableClick(true);
				return;
			}
			this.LevelUpButton.SetShowText("RoadBookExpNotEnough_Text");
			this.LevelUpButton.SetRedDotVisible(false);
			this.LevelUpButton.SetEnableClick(false);
		}

		// Token: 0x060340B8 RID: 213176 RVA: 0x00E8F5B0 File Offset: 0x00E8D7B0
		private void SetPerformanceUnFinishedLevel(int level)
		{
			IRoadBookLevelData roadBookLevelData;
			this.ActivityBaseData.TravelLevelData.TryGetValue(level, out roadBookLevelData);
			bool flag = this.ActivityBaseData.MaxTravelLevel == level;
			int current = 0;
			int target = flag ? roadBookLevelData.AccumulateExp : roadBookLevelData.TargetExp;
			base.GetItem(17).SetUIActive(true);
			if (flag)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "RoadBookLevelMax_Text", Array.Empty<object>());
				LguiUtil.Instance.SetLocalTextNew(base.GetText(18), "RoadBookLevelNotReach_Text", Array.Empty<object>());
				base.GetItem(19).SetUIActive(false);
				base.GetItem(16).SetUIActive(true);
				base.GetItem(20).SetUIActive(false);
			}
			else
			{
				this.SetLevelProgress(current, target);
				base.GetItem(19).SetUIActive(true);
				base.GetItem(16).SetUIActive(false);
				base.GetItem(20).SetUIActive(true);
			}
			this.LevelUpButton.SetShowText("RoadBookLevelNotReach_Text");
			this.LevelUpButton.SetRedDotVisible(false);
			this.LevelUpButton.SetEnableClick(false);
		}

		// Token: 0x060340B9 RID: 213177 RVA: 0x00E8F6C0 File Offset: 0x00E8D8C0
		private void OnClickedPreLevelButton()
		{
			this.SelectedLevel--;
			this.RefreshExpComponent(this.SelectedLevel);
			this.UiViewSequence.PlaySequence("Switch", true, null);
		}

		// Token: 0x060340BA RID: 213178 RVA: 0x00E8F704 File Offset: 0x00E8D904
		private void OnClickedNextLevelButton()
		{
			this.SelectedLevel++;
			this.RefreshExpComponent(this.SelectedLevel);
			this.UiViewSequence.PlaySequence("Switch", true, null);
		}

		// Token: 0x060340BB RID: 213179 RVA: 0x00E8F745 File Offset: 0x00E8D945
		private void CloseButtonClicked()
		{
			base.CloseMe(null);
		}

		// Token: 0x060340BC RID: 213180 RVA: 0x00E8F750 File Offset: 0x00E8D950
		private void HelpButtonClicked()
		{
			HelpController.Instance.OpenHelpById(this.ActivityBaseData.LocalConfig.Value.HelpId);
		}

		// Token: 0x0401B8BF RID: 112831
		[Nullable(2)]
		private PopupCaptionItem CaptionComponent;

		// Token: 0x0401B8C0 RID: 112832
		protected ActivityRoadBookData ActivityBaseData;

		// Token: 0x0401B8C1 RID: 112833
		private int SelectedLevel = -1;

		// Token: 0x0401B8C2 RID: 112834
		[Nullable(2)]
		private ActivityButtonItem LevelUpButton;

		// Token: 0x0401B8C3 RID: 112835
		private readonly Dictionary<ERoadBookSubType, RoadBookSubViewButton> SubViewButtonMap = new Dictionary<ERoadBookSubType, RoadBookSubViewButton>();

		// Token: 0x0401B8C4 RID: 112836
		private bool NeedLevelUp;

		// Token: 0x0401B8C5 RID: 112837
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData> LevelRewardLayout;

		// Token: 0x0401B8C6 RID: 112838
		private readonly ERoadBookSubType SelectedViewType;

		// Token: 0x0401B8C7 RID: 112839
		private ButtonWithRedDot BtnRight;

		// Token: 0x0401B8C8 RID: 112840
		private ButtonWithRedDot BtnLeft;
	}
}
