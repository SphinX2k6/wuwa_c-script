using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityCommonRootView;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A2F RID: 23087
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolMainPanel : SolarSchoolChildViewBase
	{
		// Token: 0x17006C74 RID: 27764
		// (get) Token: 0x06038DBE RID: 232894 RVA: 0x00FEB4B8 File Offset: 0x00FE96B8
		private ESolarSchoolMainPanelMode Mode
		{
			get
			{
				return (this.OpenParam as ESolarSchoolMainPanelMode?).GetValueOrDefault();
			}
		}

		// Token: 0x17006C75 RID: 27765
		// (get) Token: 0x06038DBF RID: 232895 RVA: 0x00FEB4DD File Offset: 0x00FE96DD
		private int HomeLocationId
		{
			get
			{
				return base.SolarSchoolViewModel.CurLocationId;
			}
		}

		// Token: 0x06038DC0 RID: 232896 RVA: 0x00FEB4EC File Offset: 0x00FE96EC
		[NullableContext(1)]
		protected override SolarSchoolRootUiParams CreateRootUiParams()
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			return new SolarSchoolRootUiParams
			{
				Caption = new SolarSchoolCaptionParams
				{
					SetVisible = true,
					TipCostVisible = true,
					HelpGroupId = 732
				},
				FestivalTips = (instance.IsFestivalInstance ? new SolarSchoolFestivalTipsParams(instance.FestivalName) : null),
				InvitationTagVisible = instance.ShouldShowInvitationTag()
			};
		}

		// Token: 0x06038DC1 RID: 232897 RVA: 0x00FEB550 File Offset: 0x00FE9750
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnDoubleCheckMaskClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038DC2 RID: 232898 RVA: 0x00FEB724 File Offset: 0x00FE9924
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolMainPanel.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolMainPanel.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038DC3 RID: 232899 RVA: 0x00FEB768 File Offset: 0x00FE9968
		protected override void OnStart()
		{
			this.TogLayout = new GenericLayout<SolarSchoolTogItem, SolarSchoolTogItemData>(base.GetVerticalLayout(5), new Func<SolarSchoolTogItem>(this.CreateSolarSchoolTogItem), base.GetItem(6).GetOwner() as AUIBaseActor, false, true);
			SolarSchoolBtnItem overViewBtn = this.OverViewBtn;
			if (overViewBtn != null)
			{
				overViewBtn.SetClickCallback(new Action(this.OnOverViewClick));
			}
			SolarSchoolBtnItem goingOutBtn = this.GoingOutBtn;
			if (goingOutBtn != null)
			{
				goingOutBtn.SetClickCallback(new Action(this.OnGoingOutClick));
			}
			SolarSchoolBtnItem scheduleBtn = this.ScheduleBtn;
			if (scheduleBtn != null)
			{
				scheduleBtn.SetClickCallback(new Action(this.OnScheduleClick));
			}
			SolarSchoolBtnItem backpackBtn = this.BackpackBtn;
			if (backpackBtn != null)
			{
				backpackBtn.SetClickCallback(new Action(this.OnBackpackClick));
			}
			UUIButtonComponent button = base.GetButton(8);
			object obj;
			if (button == null)
			{
				obj = null;
			}
			else
			{
				AActor owner = button.GetOwner();
				obj = ((owner != null) ? owner.GetComponentByClass(UUIItem.StaticClass()) : null);
			}
			this.DoubleCheckMask = (obj as UUIItem);
		}

		// Token: 0x06038DC4 RID: 232900 RVA: 0x00FEB84E File Offset: 0x00FE9A4E
		protected override void OnBeforeShow()
		{
			this.BackgroundRefreshEnabled = true;
			this.RefreshAll();
		}

		// Token: 0x06038DC5 RID: 232901 RVA: 0x00FEB85D File Offset: 0x00FE9A5D
		public override void OnReopen()
		{
			this.BackgroundRefreshEnabled = true;
			this.RefreshAll();
		}

		// Token: 0x06038DC6 RID: 232902 RVA: 0x00FEB86C File Offset: 0x00FE9A6C
		protected override void OnBeforeHide()
		{
			this.BackgroundRefreshEnabled = false;
			base.SolarSchoolViewModel.SetBackgroundSpine(null);
			this.SetDoubleCheckVisible(false);
		}

		// Token: 0x06038DC7 RID: 232903 RVA: 0x00FEB89C File Offset: 0x00FE9A9C
		private void RefreshAll()
		{
			this.ApplyBackground();
			this.ApplyBackgroundSpine();
			Action refreshDate = base.SolarSchoolViewModel.RefreshDate;
			if (refreshDate != null)
			{
				refreshDate();
			}
			this.SetDoubleCheckVisible(false);
			SolarSchoolAttrPanel scorePanel = this.ScorePanel;
			if (scorePanel != null)
			{
				scorePanel.RefreshAttr();
			}
			this.RefreshGoingOutBtn();
			this.RefreshConditionStates();
			base.SolarSchoolViewModel.RefreshLocationRole();
			base.SolarSchoolViewModel.RefreshInvitationTag();
			base.SolarSchoolViewModel.RefreshFestivalTips();
		}

		// Token: 0x06038DC8 RID: 232904 RVA: 0x00FEB910 File Offset: 0x00FE9B10
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.SolarSchoolTimeChanged, new Action(this.OnTimeChanged));
			foreach (EEventName name in this.RefreshEvents)
			{
				EventSystem.Instance.Add(name, new GenericEventHandler(this.OnConditionRelatedEventChanged));
			}
		}

		// Token: 0x06038DC9 RID: 232905 RVA: 0x00FEB96C File Offset: 0x00FE9B6C
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.SolarSchoolTimeChanged, new Action(this.OnTimeChanged));
			foreach (EEventName name in this.RefreshEvents)
			{
				EventSystem.Instance.Remove(name, new GenericEventHandler(this.OnConditionRelatedEventChanged));
			}
		}

		// Token: 0x06038DCA RID: 232906 RVA: 0x00FEB9C8 File Offset: 0x00FE9BC8
		private void OnTimeChanged()
		{
			if (this.BackgroundRefreshEnabled)
			{
				SolarSchoolRootView solarSchoolRootView = this.RootView as SolarSchoolRootView;
				if (solarSchoolRootView != null)
				{
					ECommonChildViewName? currentChildViewName = solarSchoolRootView.CurrentChildViewName;
					ECommonChildViewName ecommonChildViewName = ECommonChildViewName.SolarSchoolMain;
					if ((currentChildViewName.GetValueOrDefault() == ecommonChildViewName & currentChildViewName != null) && solarSchoolRootView.VisualNovelContext == null)
					{
						this.ApplyBackgroundSpine();
						this.RefreshConditionStates();
						base.SolarSchoolViewModel.RefreshInvitationTag();
						base.SolarSchoolViewModel.RefreshFestivalTips();
						return;
					}
				}
			}
		}

		// Token: 0x06038DCB RID: 232907 RVA: 0x00FEBA34 File Offset: 0x00FE9C34
		[NullableContext(1)]
		private void OnConditionRelatedEventChanged(params object[] args)
		{
			this.RefreshConditionStates();
		}

		// Token: 0x06038DCC RID: 232908 RVA: 0x00FEBA3C File Offset: 0x00FE9C3C
		private void RefreshConditionStates()
		{
			this.RefreshFunctionUnlock();
			this.RefreshScheduleBtn();
			this.RefreshScheduleTip();
			this.RefreshOptions();
		}

		// Token: 0x06038DCD RID: 232909 RVA: 0x00FEBA56 File Offset: 0x00FE9C56
		[NullableContext(1)]
		private SolarSchoolTogItem CreateSolarSchoolTogItem()
		{
			return new SolarSchoolTogItem
			{
				ClickCallback = new Action<SolarSchoolTogItemData>(this.OnOptionClick)
			};
		}

		// Token: 0x06038DCE RID: 232910 RVA: 0x00FEBA70 File Offset: 0x00FE9C70
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			int num;
			if (configParams.Length < 2 || configParams[0] != "QuestInfoEntry" || !int.TryParse(configParams[1], out num) || num <= 0)
			{
				return null;
			}
			SolarSchoolQuestInfoItem questInfoItem = this.QuestInfoItem;
			UUIItem uuiitem = (questInfoItem != null) ? questInfoItem.GetGuideEntryItem(num) : null;
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

		// Token: 0x06038DCF RID: 232911 RVA: 0x00FEBACC File Offset: 0x00FE9CCC
		private void RefreshOptions()
		{
			if (this.Mode != ESolarSchoolMainPanelMode.Home)
			{
				this.SetOptionsVisible(false);
				return;
			}
			bool flag = SolarSchoolGamePlayModel.Instance.CanPlayerFreeChoose();
			int homeLocationId = this.HomeLocationId;
			List<SolarSchoolTogItemData> list = new List<SolarSchoolTogItemData>();
			foreach (SolarSchoolOptionInfo solarSchoolOptionInfo in SolarSchoolGamePlayModel.Instance.MapData.GetLocationOptions(homeLocationId))
			{
				list.Add(new SolarSchoolTogItemData
				{
					OptionId = solarSchoolOptionInfo.Row.Id,
					Text = SolarSchoolUtils.GetTextWithPlaceholder(solarSchoolOptionInfo.Row.TextKey),
					IconPath = solarSchoolOptionInfo.Row.OptionIcon,
					CanClick = (solarSchoolOptionInfo.CanClick && flag),
					LockHint = (solarSchoolOptionInfo.CanClick ? string.Empty : SolarSchoolUtils.GetConditionHintText(solarSchoolOptionInfo.Row.ConditionId))
				});
			}
			SolarSchoolPlayerData playerData = SolarSchoolGamePlayModel.Instance.PlayerData;
			foreach (int behaviorId in SolarSchoolGamePlayModel.Instance.GetLocationBehaviors(homeLocationId))
			{
				SolarSchoolBehavior? currentLevelRow = playerData.GetCurrentLevelRow(behaviorId);
				list.Add(new SolarSchoolTogItemData
				{
					BehaviorId = behaviorId,
					Text = playerData.GetBehaviorName(behaviorId),
					IconPath = ((currentLevelRow != null) ? currentLevelRow.GetValueOrDefault().OptionIcon : null),
					CanClick = flag,
					Level = ((currentLevelRow != null) ? currentLevelRow.GetValueOrDefault().Level : 0),
					OccupySlot = SolarSchoolGamePlayModel.Instance.GetBehaviorOccupySlot(currentLevelRow)
				});
			}
			if (list.Count > 0)
			{
				GenericLayout<SolarSchoolTogItem, SolarSchoolTogItemData> togLayout = this.TogLayout;
				if (togLayout != null)
				{
					togLayout.RefreshByData(list, null, false);
				}
			}
			this.SetOptionsVisible(list.Count > 0);
		}

		// Token: 0x06038DD0 RID: 232912 RVA: 0x00FEBCE8 File Offset: 0x00FE9EE8
		private void SetOptionsVisible(bool visible)
		{
			GenericLayout<SolarSchoolTogItem, SolarSchoolTogItemData> togLayout = this.TogLayout;
			if (togLayout != null)
			{
				togLayout.SetActive(visible);
			}
			if (visible && !this.IsOptionsVisible)
			{
				this.SequencePlayer.PlayOrReplaySequenceByName("Gift_Start", false, null);
			}
			this.IsOptionsVisible = visible;
		}

		// Token: 0x06038DD1 RID: 232913 RVA: 0x00FEBD34 File Offset: 0x00FE9F34
		private void SetDoubleCheckVisible(bool visible)
		{
			UUIItem doubleCheckMask = this.DoubleCheckMask;
			if (doubleCheckMask != null)
			{
				doubleCheckMask.SetUIActive(visible);
			}
			if (!visible)
			{
				base.SolarSchoolViewModel.ClearFatiguePreview();
				SolarSchoolAttrPanel scorePanel = this.ScorePanel;
				if (scorePanel != null)
				{
					scorePanel.ClearBehaviorPreview();
				}
				GenericLayout<SolarSchoolTogItem, SolarSchoolTogItemData> togLayout = this.TogLayout;
				if (togLayout == null)
				{
					return;
				}
				togLayout.DeselectCurrentGridProxy();
			}
		}

		// Token: 0x06038DD2 RID: 232914 RVA: 0x00FEBD82 File Offset: 0x00FE9F82
		private void OnDoubleCheckMaskClick()
		{
			this.SetDoubleCheckVisible(false);
			SolarSchoolDoubleCheckItem doubleCheck = this.DoubleCheck;
			if (doubleCheck == null)
			{
				return;
			}
			doubleCheck.CancelCheck();
		}

		// Token: 0x06038DD3 RID: 232915 RVA: 0x00FEBD9C File Offset: 0x00FE9F9C
		[NullableContext(1)]
		private void OnOptionClick(SolarSchoolTogItemData data)
		{
			if (!data.CanClick)
			{
				return;
			}
			if (data.BehaviorId == 0)
			{
				SolarSchoolGamePlayModel.Instance.PlayerChooseOption(this.HomeLocationId, data.OptionId);
				this.RefreshOptions();
				return;
			}
			this.SetDoubleCheckVisible(true);
			base.SolarSchoolViewModel.SetFatiguePreview(SolarSchoolGamePlayModel.Instance.GetFatigueAfterBehavior(data.BehaviorId));
			SolarSchoolAttrPanel scorePanel = this.ScorePanel;
			if (scorePanel != null)
			{
				scorePanel.SetBehaviorPreview(data.BehaviorId);
			}
			GenericLayout<SolarSchoolTogItem, SolarSchoolTogItemData> togLayout = this.TogLayout;
			if (togLayout != null)
			{
				SolarSchoolTogItem selectedProxy = togLayout.GetSelectedProxy();
				if (selectedProxy != null)
				{
					selectedProxy.SetAboveMask(true);
				}
			}
			SolarSchoolDoubleCheckItem doubleCheck = this.DoubleCheck;
			if (doubleCheck == null)
			{
				return;
			}
			doubleCheck.ShowBehaviorCheck(data.BehaviorId, delegate
			{
				this.SetDoubleCheckVisible(false);
				if (SolarSchoolGamePlayModel.Instance.CanPlayerFreeChoose())
				{
					this.SolarSchoolViewModel.HoldFatigueUntilSettled(SolarSchoolGamePlayModel.Instance.GetFatigueAfterBehavior(data.BehaviorId));
					SolarSchoolGamePlayModel.Instance.PlayerChooseBehavior(data.BehaviorId);
				}
				this.RefreshOptions();
			});
		}

		// Token: 0x06038DD4 RID: 232916 RVA: 0x00FEBE84 File Offset: 0x00FEA084
		private void ApplyBackground()
		{
			if (this.Mode == ESolarSchoolMainPanelMode.Home)
			{
				base.SolarSchoolViewModel.SetBackgroundByLocationId(this.HomeLocationId, null);
				return;
			}
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			if (instance.InstanceType != ESolarSchoolInstanceType.Normal)
			{
				SolarSchoolLocation? activityHomeLocation = SolarSchoolConfig.Instance.GetActivityHomeLocation(instance.ActivityId);
				if (activityHomeLocation != null)
				{
					base.SolarSchoolViewModel.SetBackgroundByLocationId(activityHomeLocation.Value.Id, null);
					return;
				}
			}
			bool flag = instance.TimeData.DayOfWeek == DayOfWeek.Monday;
			base.SolarSchoolViewModel.SetBackgroundByBackgroundId(flag ? 700020 : 700021);
		}

		// Token: 0x06038DD5 RID: 232917 RVA: 0x00FEBF1A File Offset: 0x00FEA11A
		private void ApplyBackgroundSpine()
		{
			base.SolarSchoolViewModel.SetBackgroundSpine(this.GetBackgroundSpineResourceIds());
		}

		// Token: 0x06038DD6 RID: 232918 RVA: 0x00FEBF30 File Offset: 0x00FEA130
		[return: TupleElementNames(new string[]
		{
			"AtlasResourceId",
			"SkeletonDataResourceId"
		})]
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		private ValueTuple<string, string>? GetBackgroundSpineResourceIds()
		{
			if (this.Mode == ESolarSchoolMainPanelMode.Home)
			{
				return new ValueTuple<string, string>?(this.GetHomeBackgroundSpineResourceIds());
			}
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			if (instance.TimeData.DayOfWeek != DayOfWeek.Monday || (instance.InstanceType != ESolarSchoolInstanceType.Normal && SolarSchoolConfig.Instance.GetActivityHomeLocation(instance.ActivityId) != null))
			{
				return new ValueTuple<string, string>?(this.GetHomeBackgroundSpineResourceIds());
			}
			if (instance.TimeData.DisplaySlot != ESolarSchoolTimeSlot.Morning)
			{
				return null;
			}
			return new ValueTuple<string, string>?((instance.GetPlayerGender() == EPlayerGender.Female) ? new ValueTuple<string, string>("SolarSchoolClassroomMorningSpineFemaleAtlas", "SolarSchoolClassroomMorningSpineFemaleData") : new ValueTuple<string, string>("SolarSchoolClassroomMorningSpineMaleAtlas", "SolarSchoolClassroomMorningSpineMaleData"));
		}

		// Token: 0x06038DD7 RID: 232919 RVA: 0x00FEBFDC File Offset: 0x00FEA1DC
		[return: TupleElementNames(new string[]
		{
			"AtlasResourceId",
			"SkeletonDataResourceId"
		})]
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		private ValueTuple<string, string> GetHomeBackgroundSpineResourceIds()
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			bool flag = instance.GetPlayerGender() == EPlayerGender.Female;
			if (instance.TimeData.DisplayMapTimePhase == ESolarSchoolMapTimePhase.Dusk)
			{
				if (!flag)
				{
					return new ValueTuple<string, string>("SolarSchoolHomeDuskSpineMaleAtlas", "SolarSchoolHomeDuskSpineMaleData");
				}
				return new ValueTuple<string, string>("SolarSchoolHomeDuskSpineFemaleAtlas", "SolarSchoolHomeDuskSpineFemaleData");
			}
			else
			{
				if (!flag)
				{
					return new ValueTuple<string, string>("SolarSchoolHomeMorningSpineMaleAtlas", "SolarSchoolHomeMorningSpineMaleData");
				}
				return new ValueTuple<string, string>("SolarSchoolHomeMorningSpineFemaleAtlas", "SolarSchoolHomeMorningSpineFemaleData");
			}
		}

		// Token: 0x06038DD8 RID: 232920 RVA: 0x00FEC04C File Offset: 0x00FEA24C
		private void RefreshFunctionUnlock()
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			bool flag = instance.IsFunctionUnlocked(ESolarSchoolFunction.RoleInfo);
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			SolarSchoolBtnItem overViewBtn = this.OverViewBtn;
			if (overViewBtn == null)
			{
				return;
			}
			overViewBtn.SetRedDotVisible(flag && instance.HasAnyFavorLevelUpPending());
		}

		// Token: 0x06038DD9 RID: 232921 RVA: 0x00FEC098 File Offset: 0x00FEA298
		private void RefreshGoingOutBtn()
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			SolarSchoolInstance? solarSchoolInstance = (instance.InstanceId == 0) ? null : SolarSchoolConfig.Instance.GetInstance(instance.ActivityId, instance.InstanceId);
			string text = ((solarSchoolInstance != null) ? solarSchoolInstance.GetValueOrDefault().OutBtnText : null) ?? string.Empty;
			SolarSchoolBtnItem goingOutBtn = this.GoingOutBtn;
			if (goingOutBtn == null)
			{
				return;
			}
			goingOutBtn.SetTextByTextId(string.IsNullOrEmpty(text) ? "SolarSchool_GoOutButton_Default" : text);
		}

		// Token: 0x06038DDA RID: 232922 RVA: 0x00FEC11C File Offset: 0x00FEA31C
		private void RefreshScheduleBtn()
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			bool flag = instance.IsFunctionUnlocked(ESolarSchoolFunction.Schedule);
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			if (!flag)
			{
				return;
			}
			SolarSchoolBtnItem scheduleBtn = this.ScheduleBtn;
			if (scheduleBtn == null)
			{
				return;
			}
			scheduleBtn.SetEnable(instance.CanUseSchedule);
		}

		// Token: 0x06038DDB RID: 232923 RVA: 0x00FEC164 File Offset: 0x00FEA364
		private void RefreshScheduleTip()
		{
			UUIItem item = base.GetItem(10);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(SolarSchoolGamePlayModel.Instance.ShouldRemindSchedule());
		}

		// Token: 0x06038DDC RID: 232924 RVA: 0x00FEC182 File Offset: 0x00FEA382
		private void OnOverViewClick()
		{
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolInfoOverviewView, null, null);
		}

		// Token: 0x06038DDD RID: 232925 RVA: 0x00FEC198 File Offset: 0x00FEA398
		private unsafe void OnGoingOutClick()
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			SolarSchoolInstance? instance2 = SolarSchoolConfig.Instance.GetInstance(instance.ActivityId, instance.InstanceId);
			int num = (instance2 != null) ? instance2.GetValueOrDefault().OutFrameId : 0;
			if (num <= 0)
			{
				instance.OnClickGoOut();
				return;
			}
			ConfirmBox? confirmBoxConfig = ConfirmBoxConfig.Instance.GetConfirmBoxConfig(num);
			int num2 = (confirmBoxConfig != null) ? confirmBoxConfig.GetValueOrDefault().ButtonTextLength : 0;
			if (num2 < 1 || num2 > 2)
			{
				Log instance3 = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 外出确认框按钮配置无效";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("configId", num);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("buttonCount", num2);
				instance3.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			if (ConfirmBoxController.Instance.GetUiViewName(num) == null)
			{
				Log instance4 = Log.Instance;
				ELogModule module2 = ELogModule.SolarSchool;
				ELogAuthor author2 = ELogAuthor.LRC;
				string message2 = "[SolarSchool] 外出确认框未配置弹窗类型";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configId", num);
				instance4.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew((EConfirmBoxConfigId)num);
			confirmBoxDataNew.FunctionMap[2] = new Action(instance.OnClickGoOut);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06038DDE RID: 232926 RVA: 0x00FEC2F4 File Offset: 0x00FEA4F4
		private void OnScheduleClick()
		{
			SolarSchoolGamePlayModel.Instance.TryOpenScheduleView();
		}

		// Token: 0x06038DDF RID: 232927 RVA: 0x00FEC300 File Offset: 0x00FEA500
		private void OnBackpackClick()
		{
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolBagView, null, null);
		}

		// Token: 0x0401DEC0 RID: 122560
		[Nullable(1)]
		private const string OptionsStartSequence = "Gift_Start";

		// Token: 0x0401DEC1 RID: 122561
		private SolarSchoolAttrPanel ScorePanel;

		// Token: 0x0401DEC2 RID: 122562
		private SolarSchoolBtnItem OverViewBtn;

		// Token: 0x0401DEC3 RID: 122563
		private SolarSchoolBtnItem BackpackBtn;

		// Token: 0x0401DEC4 RID: 122564
		private SolarSchoolBtnItem ScheduleBtn;

		// Token: 0x0401DEC5 RID: 122565
		private SolarSchoolBtnItem GoingOutBtn;

		// Token: 0x0401DEC6 RID: 122566
		private SolarSchoolQuestInfoItem QuestInfoItem;

		// Token: 0x0401DEC7 RID: 122567
		private SolarSchoolDoubleCheckItem DoubleCheck;

		// Token: 0x0401DEC8 RID: 122568
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<SolarSchoolTogItem, SolarSchoolTogItemData> TogLayout;

		// Token: 0x0401DEC9 RID: 122569
		private UUIItem DoubleCheckMask;

		// Token: 0x0401DECA RID: 122570
		private bool BackgroundRefreshEnabled;

		// Token: 0x0401DECB RID: 122571
		private bool IsOptionsVisible;

		// Token: 0x0401DECC RID: 122572
		[Nullable(1)]
		private readonly EEventName[] RefreshEvents = new EEventName[]
		{
			EEventName.SolarSchoolAttrChanged,
			EEventName.SolarSchoolFavorChanged,
			EEventName.SolarSchoolItemChanged,
			EEventName.SolarSchoolBehaviorSettled,
			EEventName.SolarSchoolSpecialStateChanged,
			EEventName.SolarSchoolExamScoreChanged,
			EEventName.SolarSchoolAvgParamChanged
		};

		// Token: 0x0200B604 RID: 46596
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04038489 RID: 230537
			public const int ScorePanel = 0;

			// Token: 0x0403848A RID: 230538
			public const int BtnOverView = 1;

			// Token: 0x0403848B RID: 230539
			public const int BtnBackpack = 2;

			// Token: 0x0403848C RID: 230540
			public const int BtnSchedule = 3;

			// Token: 0x0403848D RID: 230541
			public const int BtnGoingOut = 4;

			// Token: 0x0403848E RID: 230542
			public const int TogLayout = 5;

			// Token: 0x0403848F RID: 230543
			public const int TogItem = 6;

			// Token: 0x04038490 RID: 230544
			public const int QuestInfoItem = 7;

			// Token: 0x04038491 RID: 230545
			public const int PnlDoubleCheck = 8;

			// Token: 0x04038492 RID: 230546
			public const int DoubleCheckItem = 9;

			// Token: 0x04038493 RID: 230547
			public const int ScheduleTipItem = 10;
		}
	}
}
