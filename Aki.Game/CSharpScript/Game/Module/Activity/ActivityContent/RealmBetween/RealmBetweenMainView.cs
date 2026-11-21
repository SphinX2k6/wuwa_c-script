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

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x020051F7 RID: 20983
	[NullableContext(1)]
	[Nullable(0)]
	public class RealmBetweenMainView : UiViewBase
	{
		// Token: 0x0603441F RID: 214047 RVA: 0x00E9E3F3 File Offset: 0x00E9C5F3
		public RealmBetweenMainView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06034420 RID: 214048 RVA: 0x00E9E410 File Offset: 0x00E9C610
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIArtText)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIItem)),
				new ValueTuple<int, Type>(14, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUISprite)),
				new ValueTuple<int, Type>(11, typeof(UUIText)),
				new ValueTuple<int, Type>(9, typeof(UUIItem))
			};
		}

		// Token: 0x06034421 RID: 214049 RVA: 0x00E9E578 File Offset: 0x00E9C778
		protected override UniTask OnBeforeStartAsync()
		{
			RealmBetweenMainView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RealmBetweenMainView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034422 RID: 214050 RVA: 0x00E9E5BB File Offset: 0x00E9C7BB
		protected override void OnStart()
		{
			this.SelectedLevel = this.ActivityBaseData.TravelLevel;
		}

		// Token: 0x06034423 RID: 214051 RVA: 0x00E9E5CE File Offset: 0x00E9C7CE
		protected override void OnBeforeShow()
		{
			this.RefreshExpComponent(this.SelectedLevel);
			this.RefreshSubViewButton();
		}

		// Token: 0x06034424 RID: 214052 RVA: 0x00E9E5E2 File Offset: 0x00E9C7E2
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnRewardViewClose));
		}

		// Token: 0x06034425 RID: 214053 RVA: 0x00E9E5FD File Offset: 0x00E9C7FD
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnRewardViewClose));
		}

		// Token: 0x06034426 RID: 214054 RVA: 0x00E9E618 File Offset: 0x00E9C818
		private UniTask CreateSubViewButton()
		{
			RealmBetweenMainView.<CreateSubViewButton>d__17 <CreateSubViewButton>d__;
			<CreateSubViewButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateSubViewButton>d__.<>4__this = this;
			<CreateSubViewButton>d__.<>1__state = -1;
			<CreateSubViewButton>d__.<>t__builder.Start<RealmBetweenMainView.<CreateSubViewButton>d__17>(ref <CreateSubViewButton>d__);
			return <CreateSubViewButton>d__.<>t__builder.Task;
		}

		// Token: 0x06034427 RID: 214055 RVA: 0x00E9E65C File Offset: 0x00E9C85C
		protected void OnOpenSubView(ERealmBetweenSubType type)
		{
			switch (type)
			{
			case ERealmBetweenSubType.TravelTask:
				UiManager.Instance.OpenView(EUiViewName.RealmBetweenTravelTaskView, this.ActivityBaseData, null);
				return;
			case ERealmBetweenSubType.PhantomQuest:
				break;
			case ERealmBetweenSubType.PhantomCollect:
				UiManager.Instance.OpenView(EUiViewName.RealmBetweenPhantomTaskView, this.ActivityBaseData, null);
				break;
			case ERealmBetweenSubType.MotorChallenge:
				UiManager.Instance.OpenView(EUiViewName.RealmBetweenVehicleTaskView, this.ActivityBaseData, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06034428 RID: 214056 RVA: 0x00E9E6C6 File Offset: 0x00E9C8C6
		private void OnClickedLevelUpButton()
		{
			ActivityRealmBetweenController.Instance.RequestRealmBetweenLevelUp(delegate(bool success)
			{
				this.NeedLevelUp = success;
				this.LevelUp();
			});
		}

		// Token: 0x06034429 RID: 214057 RVA: 0x00E9E6E0 File Offset: 0x00E9C8E0
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

		// Token: 0x0603442A RID: 214058 RVA: 0x00E9E749 File Offset: 0x00E9C949
		private void OnRewardViewClose(EUiViewName viewName, int viewId)
		{
			if (this.SelectedViewType != ERealmBetweenSubType.Main)
			{
				return;
			}
			if (viewName == EUiViewName.CommonRewardView || viewName == EUiViewName.RoleLevelUpSuccessAttributeView)
			{
				this.LevelUp();
			}
		}

		// Token: 0x0603442B RID: 214059 RVA: 0x00E9E774 File Offset: 0x00E9C974
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
			IRealmBetweenLevelData realmBetweenLevelData;
			this.ActivityBaseData.TravelLevelData.TryGetValue(level, out realmBetweenLevelData);
			if (realmBetweenLevelData == null)
			{
				return;
			}
			RealmBetweenLevelExp value = ActivityRealmBetweenConfig.Instance.GetLevelExpConfig(realmBetweenLevelData.Id).Value;
			string text;
			if (level <= 0 || level >= 10)
			{
				text = level.ToString();
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("0");
				defaultInterpolatedStringHandler.AppendFormatted<int>(level);
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			string text2 = text;
			base.GetArtText(1).SetText(text2);
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
			base.GetItem(3).SetUIActive(level > 0);
			base.GetItem(4).SetUIActive(level < this.ActivityBaseData.MaxTravelLevel);
		}

		// Token: 0x0603442C RID: 214060 RVA: 0x00E9E950 File Offset: 0x00E9CB50
		private void RefreshSubViewButton()
		{
			foreach (KeyValuePair<ERealmBetweenSubType, RealmBetweenSubViewButton> keyValuePair in this.SubViewButtonMap)
			{
				ERealmBetweenSubType key = keyValuePair.Key;
				RealmBetweenSubViewButton value = keyValuePair.Value;
				ValueTuple<int, int> typeProgress = this.ActivityBaseData.GetTypeProgress(key);
				int item = typeProgress.Item1;
				int item2 = typeProgress.Item2;
				int num = (int)Math.Ceiling((double)item / (double)item2 * 100.0);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(num);
				defaultInterpolatedStringHandler.AppendLiteral("%");
				value.SetProgressText(defaultInterpolatedStringHandler.ToStringAndClear());
				value.SeFinishIconState(num >= 100);
				bool typeRedDotState = this.ActivityBaseData.GetTypeRedDotState(key);
				bool typeNewState = this.ActivityBaseData.GetTypeNewState(key);
				value.RefreshRedDot(typeRedDotState || typeNewState);
			}
		}

		// Token: 0x0603442D RID: 214061 RVA: 0x00E9EA44 File Offset: 0x00E9CC44
		private void SetPerformanceFinishedLevel(int level)
		{
			IRealmBetweenLevelData realmBetweenLevelData;
			this.ActivityBaseData.TravelLevelData.TryGetValue(level, out realmBetweenLevelData);
			base.GetItem(5).SetUIActive(true);
			base.GetItem(7).SetUIActive(false);
			base.GetItem(8).SetUIActive(true);
			base.GetItem(9).SetUIActive(false);
			UUIText text = base.GetText(2);
			text.SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(text, "RealmBetweenExp_Text", new <>z__ReadOnlyArray<object>(new object[]
			{
				realmBetweenLevelData.TargetExp,
				realmBetweenLevelData.TargetExp
			}));
		}

		// Token: 0x0603442E RID: 214062 RVA: 0x00E9EAE0 File Offset: 0x00E9CCE0
		private void SetPerformanceCurrentLevel(int level)
		{
			ActivityRealmBetweenData activityBaseData = this.ActivityBaseData;
			bool flag = activityBaseData.MaxTravelLevel == level;
			bool flag2 = !flag && activityBaseData.CanTravelLevelUp();
			IRealmBetweenLevelData realmBetweenLevelData;
			activityBaseData.TravelLevelData.TryGetValue(level, out realmBetweenLevelData);
			base.GetItem(5).SetUIActive(!flag);
			base.GetItem(7).SetUIActive(true);
			base.GetItem(8).SetUIActive(false);
			base.GetItem(9).SetUIActive(flag);
			base.GetText(11).ShowTextNew("RealmBetweenLevelMaxBtn_Text");
			base.GetText(2).SetUIActive(true);
			UUIText text = base.GetText(2);
			if (flag)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "RealmBetweenLevelMax_Text", Array.Empty<object>());
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(text, "RealmBetweenExp_Text", new <>z__ReadOnlyArray<object>(new object[]
				{
					activityBaseData.GetCurrentExp(),
					realmBetweenLevelData.TargetExp
				}));
			}
			if (flag2)
			{
				this.UiViewSequence.PlaySequence("PreLevelUp", false, null);
				this.LevelUpButton.SetShowText("RealmBetweenLevelUp_Text");
				this.LevelUpButton.SetRedDotVisible(true);
				this.LevelUpButton.SetEnableClick(true);
				return;
			}
			this.LevelUpButton.SetShowText("RealmBetweenExpNotEnough_Text");
			this.LevelUpButton.SetRedDotVisible(false);
			this.LevelUpButton.SetEnableClick(false);
		}

		// Token: 0x0603442F RID: 214063 RVA: 0x00E9EC3C File Offset: 0x00E9CE3C
		private void SetPerformanceUnFinishedLevel(int level)
		{
			bool flag = this.ActivityBaseData.MaxTravelLevel == level;
			base.GetItem(5).SetUIActive(!flag);
			this.LevelUpButton.SetShowText("RealmBetweenLevelNotReach_Text");
			this.LevelUpButton.SetRedDotVisible(false);
			this.LevelUpButton.SetEnableClick(false);
			base.GetItem(9).SetUIActive(flag);
			base.GetText(11).ShowTextNew("RealmBetweenLevelNotReach_Text");
			base.GetSprite(10).SetUIActive(false);
			base.GetText(2).SetUIActive(false);
		}

		// Token: 0x06034430 RID: 214064 RVA: 0x00E9ECCC File Offset: 0x00E9CECC
		private void OnClickedPreLevelButton()
		{
			this.SelectedLevel--;
			this.RefreshExpComponent(this.SelectedLevel);
			this.UiViewSequence.PlaySequence("Switch", true, null);
		}

		// Token: 0x06034431 RID: 214065 RVA: 0x00E9ED10 File Offset: 0x00E9CF10
		private void OnClickedNextLevelButton()
		{
			this.SelectedLevel++;
			this.RefreshExpComponent(this.SelectedLevel);
			this.UiViewSequence.PlaySequence("Switch", true, null);
		}

		// Token: 0x06034432 RID: 214066 RVA: 0x00E9ED51 File Offset: 0x00E9CF51
		private void CloseButtonClicked()
		{
			base.CloseMe(null);
		}

		// Token: 0x06034433 RID: 214067 RVA: 0x00E9ED5C File Offset: 0x00E9CF5C
		private void HelpButtonClicked()
		{
			HelpController.Instance.OpenHelpById(this.ActivityBaseData.LocalConfig.Value.HelpId);
		}

		// Token: 0x0401BBC8 RID: 113608
		[Nullable(2)]
		private PopupCaptionItem CaptionComponent;

		// Token: 0x0401BBC9 RID: 113609
		protected ActivityRealmBetweenData ActivityBaseData;

		// Token: 0x0401BBCA RID: 113610
		private int SelectedLevel = -1;

		// Token: 0x0401BBCB RID: 113611
		[Nullable(2)]
		private ActivityButtonItem LevelUpButton;

		// Token: 0x0401BBCC RID: 113612
		private readonly Dictionary<ERealmBetweenSubType, RealmBetweenSubViewButton> SubViewButtonMap = new Dictionary<ERealmBetweenSubType, RealmBetweenSubViewButton>();

		// Token: 0x0401BBCD RID: 113613
		private bool NeedLevelUp;

		// Token: 0x0401BBCE RID: 113614
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData> LevelRewardLayout;

		// Token: 0x0401BBCF RID: 113615
		private readonly ERealmBetweenSubType SelectedViewType;

		// Token: 0x0401BBD0 RID: 113616
		private ButtonWithRedDot BtnRight;

		// Token: 0x0401BBD1 RID: 113617
		private ButtonWithRedDot BtnLeft;
	}
}
