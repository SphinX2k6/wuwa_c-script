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
	// Token: 0x02006279 RID: 25209
	[NullableContext(1)]
	[Nullable(0)]
	public class RealmBetweenMainView : UiViewBase
	{
		// Token: 0x0603F75E RID: 259934 RVA: 0x00F57497 File Offset: 0x00F55697
		public RealmBetweenMainView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603F75F RID: 259935 RVA: 0x00F574B4 File Offset: 0x00F556B4
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

		// Token: 0x0603F760 RID: 259936 RVA: 0x00F5761C File Offset: 0x00F5581C
		protected override UniTask OnBeforeStartAsync()
		{
			RealmBetweenMainView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RealmBetweenMainView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F761 RID: 259937 RVA: 0x00F5765F File Offset: 0x00F5585F
		protected override void OnStart()
		{
			this.SelectedLevel = this.ActivityBaseData.TravelLevel;
		}

		// Token: 0x0603F762 RID: 259938 RVA: 0x00F57672 File Offset: 0x00F55872
		protected override void OnBeforeShow()
		{
			this.RefreshExpComponent(this.SelectedLevel);
			this.RefreshSubViewButton();
		}

		// Token: 0x0603F763 RID: 259939 RVA: 0x00F57686 File Offset: 0x00F55886
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnRewardViewClose));
		}

		// Token: 0x0603F764 RID: 259940 RVA: 0x00F576A1 File Offset: 0x00F558A1
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnRewardViewClose));
		}

		// Token: 0x0603F765 RID: 259941 RVA: 0x00F576BC File Offset: 0x00F558BC
		private UniTask CreateSubViewButton()
		{
			RealmBetweenMainView.<CreateSubViewButton>d__17 <CreateSubViewButton>d__;
			<CreateSubViewButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateSubViewButton>d__.<>4__this = this;
			<CreateSubViewButton>d__.<>1__state = -1;
			<CreateSubViewButton>d__.<>t__builder.Start<RealmBetweenMainView.<CreateSubViewButton>d__17>(ref <CreateSubViewButton>d__);
			return <CreateSubViewButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603F766 RID: 259942 RVA: 0x00F57700 File Offset: 0x00F55900
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

		// Token: 0x0603F767 RID: 259943 RVA: 0x00F5776A File Offset: 0x00F5596A
		private void OnClickedLevelUpButton()
		{
			ActivityRealmBetweenController.Instance.RequestRealmBetweenLevelUp(delegate(bool success)
			{
				this.NeedLevelUp = success;
				this.LevelUp();
			});
		}

		// Token: 0x0603F768 RID: 259944 RVA: 0x00F57784 File Offset: 0x00F55984
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

		// Token: 0x0603F769 RID: 259945 RVA: 0x00F577ED File Offset: 0x00F559ED
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

		// Token: 0x0603F76A RID: 259946 RVA: 0x00F57818 File Offset: 0x00F55A18
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

		// Token: 0x0603F76B RID: 259947 RVA: 0x00F579F4 File Offset: 0x00F55BF4
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

		// Token: 0x0603F76C RID: 259948 RVA: 0x00F57AE8 File Offset: 0x00F55CE8
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

		// Token: 0x0603F76D RID: 259949 RVA: 0x00F57B84 File Offset: 0x00F55D84
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

		// Token: 0x0603F76E RID: 259950 RVA: 0x00F57CE0 File Offset: 0x00F55EE0
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

		// Token: 0x0603F76F RID: 259951 RVA: 0x00F57D70 File Offset: 0x00F55F70
		private void OnClickedPreLevelButton()
		{
			this.SelectedLevel--;
			this.RefreshExpComponent(this.SelectedLevel);
			this.UiViewSequence.PlaySequence("Switch", true, null);
		}

		// Token: 0x0603F770 RID: 259952 RVA: 0x00F57DB4 File Offset: 0x00F55FB4
		private void OnClickedNextLevelButton()
		{
			this.SelectedLevel++;
			this.RefreshExpComponent(this.SelectedLevel);
			this.UiViewSequence.PlaySequence("Switch", true, null);
		}

		// Token: 0x0603F771 RID: 259953 RVA: 0x00F57DF5 File Offset: 0x00F55FF5
		private void CloseButtonClicked()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603F772 RID: 259954 RVA: 0x00F57E00 File Offset: 0x00F56000
		private void HelpButtonClicked()
		{
			HelpController.Instance.OpenHelpById(this.ActivityBaseData.LocalConfig.Value.HelpId);
		}

		// Token: 0x04021299 RID: 135833
		[Nullable(2)]
		private PopupCaptionItem CaptionComponent;

		// Token: 0x0402129A RID: 135834
		protected ActivityRealmBetweenData ActivityBaseData;

		// Token: 0x0402129B RID: 135835
		private int SelectedLevel = -1;

		// Token: 0x0402129C RID: 135836
		[Nullable(2)]
		private ActivityButtonItem LevelUpButton;

		// Token: 0x0402129D RID: 135837
		private readonly Dictionary<ERealmBetweenSubType, RealmBetweenSubViewButton> SubViewButtonMap = new Dictionary<ERealmBetweenSubType, RealmBetweenSubViewButton>();

		// Token: 0x0402129E RID: 135838
		private bool NeedLevelUp;

		// Token: 0x0402129F RID: 135839
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData> LevelRewardLayout;

		// Token: 0x040212A0 RID: 135840
		private readonly ERealmBetweenSubType SelectedViewType;

		// Token: 0x040212A1 RID: 135841
		private ButtonWithRedDot BtnRight;

		// Token: 0x040212A2 RID: 135842
		private ButtonWithRedDot BtnLeft;
	}
}
