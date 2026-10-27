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
	// Token: 0x020061D6 RID: 25046
	[NullableContext(1)]
	[Nullable(0)]
	public class RoadBookMainView : UiViewBase
	{
		// Token: 0x0603F3E5 RID: 259045 RVA: 0x00F47CEB File Offset: 0x00F45EEB
		public RoadBookMainView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603F3E6 RID: 259046 RVA: 0x00F47D08 File Offset: 0x00F45F08
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

		// Token: 0x0603F3E7 RID: 259047 RVA: 0x00F47EFC File Offset: 0x00F460FC
		protected override UniTask OnBeforeStartAsync()
		{
			RoadBookMainView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoadBookMainView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F3E8 RID: 259048 RVA: 0x00F47F3F File Offset: 0x00F4613F
		protected override void OnStart()
		{
			this.SelectedLevel = this.ActivityBaseData.TravelLevel;
		}

		// Token: 0x0603F3E9 RID: 259049 RVA: 0x00F47F52 File Offset: 0x00F46152
		protected override void OnBeforeShow()
		{
			this.RefreshExpComponent(this.SelectedLevel);
			this.RefreshSubViewButton();
		}

		// Token: 0x0603F3EA RID: 259050 RVA: 0x00F47F66 File Offset: 0x00F46166
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnRewardViewClose));
		}

		// Token: 0x0603F3EB RID: 259051 RVA: 0x00F47F81 File Offset: 0x00F46181
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnRewardViewClose));
		}

		// Token: 0x0603F3EC RID: 259052 RVA: 0x00F47F9C File Offset: 0x00F4619C
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x0603F3ED RID: 259053 RVA: 0x00F47FA0 File Offset: 0x00F461A0
		private UniTask CreateSubViewButton()
		{
			RoadBookMainView.<CreateSubViewButton>d__18 <CreateSubViewButton>d__;
			<CreateSubViewButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateSubViewButton>d__.<>4__this = this;
			<CreateSubViewButton>d__.<>1__state = -1;
			<CreateSubViewButton>d__.<>t__builder.Start<RoadBookMainView.<CreateSubViewButton>d__18>(ref <CreateSubViewButton>d__);
			return <CreateSubViewButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603F3EE RID: 259054 RVA: 0x00F47FE4 File Offset: 0x00F461E4
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

		// Token: 0x0603F3EF RID: 259055 RVA: 0x00F4804E File Offset: 0x00F4624E
		private void OnClickedLevelUpButton()
		{
			ActivityRoadBookController.Instance.RequestRoadBookLevelUp(delegate(bool success)
			{
				this.NeedLevelUp = success;
				this.LevelUp();
			});
		}

		// Token: 0x0603F3F0 RID: 259056 RVA: 0x00F48068 File Offset: 0x00F46268
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

		// Token: 0x0603F3F1 RID: 259057 RVA: 0x00F480D1 File Offset: 0x00F462D1
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

		// Token: 0x0603F3F2 RID: 259058 RVA: 0x00F48104 File Offset: 0x00F46304
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

		// Token: 0x0603F3F3 RID: 259059 RVA: 0x00F482FC File Offset: 0x00F464FC
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

		// Token: 0x0603F3F4 RID: 259060 RVA: 0x00F483E0 File Offset: 0x00F465E0
		private void SetLevelProgress(int current, int target)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "RoadBookExp_Text", new <>z__ReadOnlyArray<object>(new object[]
			{
				current,
				target
			}));
			base.GetText(4).SetUIActive(true);
		}

		// Token: 0x0603F3F5 RID: 259061 RVA: 0x00F48430 File Offset: 0x00F46630
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

		// Token: 0x0603F3F6 RID: 259062 RVA: 0x00F484F0 File Offset: 0x00F466F0
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

		// Token: 0x0603F3F7 RID: 259063 RVA: 0x00F48658 File Offset: 0x00F46858
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

		// Token: 0x0603F3F8 RID: 259064 RVA: 0x00F48768 File Offset: 0x00F46968
		private void OnClickedPreLevelButton()
		{
			this.SelectedLevel--;
			this.RefreshExpComponent(this.SelectedLevel);
			this.UiViewSequence.PlaySequence("Switch", true, null);
		}

		// Token: 0x0603F3F9 RID: 259065 RVA: 0x00F487AC File Offset: 0x00F469AC
		private void OnClickedNextLevelButton()
		{
			this.SelectedLevel++;
			this.RefreshExpComponent(this.SelectedLevel);
			this.UiViewSequence.PlaySequence("Switch", true, null);
		}

		// Token: 0x0603F3FA RID: 259066 RVA: 0x00F487ED File Offset: 0x00F469ED
		private void CloseButtonClicked()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603F3FB RID: 259067 RVA: 0x00F487F8 File Offset: 0x00F469F8
		private void HelpButtonClicked()
		{
			HelpController.Instance.OpenHelpById(this.ActivityBaseData.LocalConfig.Value.HelpId);
		}

		// Token: 0x04020F90 RID: 135056
		[Nullable(2)]
		private PopupCaptionItem CaptionComponent;

		// Token: 0x04020F91 RID: 135057
		protected ActivityRoadBookData ActivityBaseData;

		// Token: 0x04020F92 RID: 135058
		private int SelectedLevel = -1;

		// Token: 0x04020F93 RID: 135059
		[Nullable(2)]
		private ActivityButtonItem LevelUpButton;

		// Token: 0x04020F94 RID: 135060
		private readonly Dictionary<ERoadBookSubType, RoadBookSubViewButton> SubViewButtonMap = new Dictionary<ERoadBookSubType, RoadBookSubViewButton>();

		// Token: 0x04020F95 RID: 135061
		private bool NeedLevelUp;

		// Token: 0x04020F96 RID: 135062
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData> LevelRewardLayout;

		// Token: 0x04020F97 RID: 135063
		private readonly ERoadBookSubType SelectedViewType;

		// Token: 0x04020F98 RID: 135064
		private ButtonWithRedDot BtnRight;

		// Token: 0x04020F99 RID: 135065
		private ButtonWithRedDot BtnLeft;
	}
}
