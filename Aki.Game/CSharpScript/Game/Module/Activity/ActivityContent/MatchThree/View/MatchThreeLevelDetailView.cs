using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.View
{
	// Token: 0x02005414 RID: 21524
	[NullableContext(2)]
	[Nullable(0)]
	public class MatchThreeLevelDetailView : UiViewBase
	{
		// Token: 0x06035767 RID: 218983 RVA: 0x00EEDD00 File Offset: 0x00EEBF00
		[NullableContext(1)]
		public MatchThreeLevelDetailView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06035768 RID: 218984 RVA: 0x00EEDD0C File Offset: 0x00EEBF0C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 18;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickSelectRole));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06035769 RID: 218985 RVA: 0x00EEDFCC File Offset: 0x00EEC1CC
		protected override UniTask OnBeforeStartAsync()
		{
			MatchThreeLevelDetailView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MatchThreeLevelDetailView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603576A RID: 218986 RVA: 0x00EEE010 File Offset: 0x00EEC210
		private UniTask InitDifficultyTabsAsync()
		{
			MatchThreeLevelDetailView.<InitDifficultyTabsAsync>d__12 <InitDifficultyTabsAsync>d__;
			<InitDifficultyTabsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDifficultyTabsAsync>d__.<>4__this = this;
			<InitDifficultyTabsAsync>d__.<>1__state = -1;
			<InitDifficultyTabsAsync>d__.<>t__builder.Start<MatchThreeLevelDetailView.<InitDifficultyTabsAsync>d__12>(ref <InitDifficultyTabsAsync>d__);
			return <InitDifficultyTabsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603576B RID: 218987 RVA: 0x00EEE053 File Offset: 0x00EEC253
		protected override void OnBeforeShow()
		{
			this.SetEnteringChallenge(false);
			this.RefreshAll();
			ActivityMatchThreeController.Instance.TryShowPendingRoleUnlockTips(new Action(this.RefreshSelectRoleRedDot));
		}

		// Token: 0x0603576C RID: 218988 RVA: 0x00EEE078 File Offset: 0x00EEC278
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.OnMatchThreeChallengeStateUpdate, new Action<int>(this.OnChallengeStateUpdate));
			EventSystem.Instance.Add(EEventName.OnMatchThreeRoleNewRedDotUpdate, new Action(this.RefreshSelectRoleRedDot));
		}

		// Token: 0x0603576D RID: 218989 RVA: 0x00EEE0B2 File Offset: 0x00EEC2B2
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.OnMatchThreeChallengeStateUpdate, new Action<int>(this.OnChallengeStateUpdate));
			EventSystem.Instance.Remove(EEventName.OnMatchThreeRoleNewRedDotUpdate, new Action(this.RefreshSelectRoleRedDot));
		}

		// Token: 0x0603576E RID: 218990 RVA: 0x00EEE0EC File Offset: 0x00EEC2EC
		private void InitDefaultRole()
		{
			if (this.ViewModel == null || this.ActivityData == null)
			{
				return;
			}
			if (this.ViewModel.SelectedRoleId > 0 && this.ActivityData.IsRoleUnlocked(this.ViewModel.SelectedRoleId))
			{
				return;
			}
			this.ViewModel.SelectedRoleId = this.ActivityData.ResolvePreferredRoleId(this.ViewModel.CurrentLevelId);
		}

		// Token: 0x0603576F RID: 218991 RVA: 0x00EEE154 File Offset: 0x00EEC354
		private void RefreshAll()
		{
			if (this.ViewModel == null || this.ActivityData == null)
			{
				return;
			}
			this.ApplyDefaultDifficulty();
			this.RefreshDifficultyArea();
			this.RefreshScore();
			this.RefreshModeVisual();
			MatchThreeLevelDetailTipsPanel tipsPanel = this.TipsPanel;
			if (tipsPanel != null)
			{
				tipsPanel.Refresh(this.ViewModel, this.ActivityData);
			}
			this.InitDefaultRole();
			this.RefreshRoleInfo();
			this.RefreshSelectRoleRedDot();
		}

		// Token: 0x06035770 RID: 218992 RVA: 0x00EEE1BC File Offset: 0x00EEC3BC
		private void RefreshSelectRoleRedDot()
		{
			bool uiactive = this.ActivityData != null && (this.ActivityData.HasSelectRoleBtnRedDot() || this.ActivityData.HasAnyNewRoleRedDot());
			UUIItem item = base.GetItem(16);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(uiactive);
		}

		// Token: 0x06035771 RID: 218993 RVA: 0x00EEE203 File Offset: 0x00EEC403
		private void ApplyDefaultDifficulty()
		{
			if (this.ViewModel == null || this.ActivityData == null)
			{
				return;
			}
			this.ViewModel.DifficultyIndex = ActivityMatchThreeController.ResolveDefaultDifficultyIndex(this.ViewModel.ChapterData, this.ActivityData);
		}

		// Token: 0x06035772 RID: 218994 RVA: 0x00EEE238 File Offset: 0x00EEC438
		private void RefreshModeVisual()
		{
			if (this.ViewModel == null)
			{
				return;
			}
			bool isEndless = this.ViewModel.ChapterData.IsEndless;
			UUIItem item = base.GetItem(11);
			if (item != null)
			{
				item.SetUIActive(!isEndless);
			}
			UUIItem item2 = base.GetItem(13);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(isEndless);
		}

		// Token: 0x06035773 RID: 218995 RVA: 0x00EEE28C File Offset: 0x00EEC48C
		private void RefreshDifficultyArea()
		{
			if (this.ViewModel == null || this.ActivityData == null)
			{
				return;
			}
			bool isEndless = this.ViewModel.ChapterData.IsEndless;
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(!isEndless);
			}
			if (isEndless)
			{
				return;
			}
			bool flag = this.ViewModel.ChapterData.LevelIds.Count > 1;
			MatchThreeDifficultyTabItem hardTab = this.HardTab;
			if (hardTab != null)
			{
				UUIItem rootItem = hardTab.GetRootItem();
				if (rootItem != null)
				{
					rootItem.SetUIActive(flag);
				}
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(14);
			if (extendToggle != null)
			{
				UUIItem uuiitem = extendToggle.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(flag);
				}
			}
			if (!flag && this.ViewModel.DifficultyIndex > 0)
			{
				this.ViewModel.DifficultyIndex = 0;
			}
			int normalLevelId = this.ViewModel.ChapterData.NormalLevelId;
			MatchThreeDifficultyTabItem easyTab = this.EasyTab;
			if (easyTab != null)
			{
				easyTab.SetNormalLevelId(normalLevelId);
			}
			MatchThreeDifficultyTabItem hardTab2 = this.HardTab;
			if (hardTab2 != null)
			{
				hardTab2.SetNormalLevelId(normalLevelId);
			}
			MatchThreeLevel? levelConfig = this.ActivityData.GetLevelConfig(normalLevelId);
			if (levelConfig != null && this.EasyTab != null)
			{
				this.EasyTab.Refresh(levelConfig.Value, this.ViewModel.DifficultyIndex == 0, 0);
			}
			int hardLevelId = this.ViewModel.ChapterData.HardLevelId;
			MatchThreeLevel? matchThreeLevel = flag ? this.ActivityData.GetLevelConfig(hardLevelId) : null;
			if (matchThreeLevel != null && this.HardTab != null)
			{
				this.HardTab.Refresh(matchThreeLevel.Value, this.ViewModel.DifficultyIndex > 0, 1);
			}
			this.RefreshDifficultyToggleState();
		}

		// Token: 0x06035774 RID: 218996 RVA: 0x00EEE42C File Offset: 0x00EEC62C
		private void RefreshDifficultyToggleState()
		{
			if (this.ViewModel == null)
			{
				return;
			}
			bool flag = this.ViewModel.DifficultyIndex > 0;
			MatchThreeDifficultyTabItem easyTab = this.EasyTab;
			if (easyTab != null)
			{
				easyTab.SetToggleActive(!flag);
			}
			MatchThreeDifficultyTabItem hardTab = this.HardTab;
			if (hardTab == null)
			{
				return;
			}
			hardTab.SetToggleActive(flag);
		}

		// Token: 0x06035775 RID: 218997 RVA: 0x00EEE478 File Offset: 0x00EEC678
		public void ChangeDifficultyIndex(int index)
		{
			if (this.IsEnteringChallenge || this.ViewModel == null || this.ActivityData == null)
			{
				return;
			}
			if (index < 0 || index >= this.ViewModel.ChapterData.LevelIds.Count)
			{
				return;
			}
			if (index == this.ViewModel.DifficultyIndex)
			{
				this.RefreshDifficultyToggleState();
				return;
			}
			this.ViewModel.DifficultyIndex = index;
			this.PlaySwitchSequence();
			this.RefreshDifficultyToggleState();
			MatchThreeLevelDetailTipsPanel tipsPanel = this.TipsPanel;
			if (tipsPanel != null)
			{
				tipsPanel.Refresh(this.ViewModel, this.ActivityData);
			}
			this.InitDefaultRole();
			this.RefreshRoleInfo();
		}

		// Token: 0x06035776 RID: 218998 RVA: 0x00EEE514 File Offset: 0x00EEC714
		private void PlaySwitchSequence()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.StopPrevSequence(false, true);
			}
			base.PlayOrReplaySequence("Switch", false, null);
		}

		// Token: 0x06035777 RID: 218999 RVA: 0x00EEE54C File Offset: 0x00EEC74C
		private void RefreshScore()
		{
			if (this.ViewModel == null || this.ActivityData == null)
			{
				return;
			}
			bool isEndless = this.ViewModel.ChapterData.IsEndless;
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(isEndless);
			}
			if (!isEndless)
			{
				return;
			}
			UUIText text = base.GetText(4);
			if (text == null)
			{
				return;
			}
			int endlessBestScore = this.ActivityData.GetEndlessBestScore(this.ViewModel.ChapterData);
			if (endlessBestScore > 0)
			{
				LguiUtil.Instance.TrySetLocalTextNew(text, "MatchThree_BestRecord", new <>z__ReadOnlySingleElementList<object>(endlessBestScore.ToString()));
				return;
			}
			LguiUtil.Instance.TrySetLocalTextNew(text, "MatchThree_NoRecord", Array.Empty<object>());
		}

		// Token: 0x06035778 RID: 219000 RVA: 0x00EEE5EC File Offset: 0x00EEC7EC
		private void RefreshRoleInfo()
		{
			if (this.ViewModel == null)
			{
				return;
			}
			MatchThreeRole? roleConfig = ActivityMatchThreeConfig.Instance.GetRoleConfig(this.ViewModel.SelectedRoleId);
			if (roleConfig == null)
			{
				return;
			}
			this.RefreshRoleName(roleConfig.Value);
			this.RefreshRoleSpine(roleConfig.Value).Forget();
			this.RefreshRoleSpineBack(roleConfig.Value).Forget();
			this.RefreshSkillIcons(roleConfig.Value);
		}

		// Token: 0x06035779 RID: 219001 RVA: 0x00EEE660 File Offset: 0x00EEC860
		private void RefreshRoleName(MatchThreeRole roleConfig)
		{
			UUIText text = base.GetText(10);
			if (text == null)
			{
				return;
			}
			if (string.IsNullOrEmpty(roleConfig.Name))
			{
				text.SetText(string.Empty, true);
				return;
			}
			LguiUtil.Instance.TrySetLocalTextNew(text, roleConfig.Name, Array.Empty<object>());
		}

		// Token: 0x0603577A RID: 219002 RVA: 0x00EEE6AC File Offset: 0x00EEC8AC
		private UniTask RefreshRoleSpine(MatchThreeRole roleConfig)
		{
			MatchThreeLevelDetailView.<RefreshRoleSpine>d__28 <RefreshRoleSpine>d__;
			<RefreshRoleSpine>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshRoleSpine>d__.<>4__this = this;
			<RefreshRoleSpine>d__.roleConfig = roleConfig;
			<RefreshRoleSpine>d__.<>1__state = -1;
			<RefreshRoleSpine>d__.<>t__builder.Start<MatchThreeLevelDetailView.<RefreshRoleSpine>d__28>(ref <RefreshRoleSpine>d__);
			return <RefreshRoleSpine>d__.<>t__builder.Task;
		}

		// Token: 0x0603577B RID: 219003 RVA: 0x00EEE6F8 File Offset: 0x00EEC8F8
		private UniTask RefreshRoleSpineBack(MatchThreeRole roleConfig)
		{
			MatchThreeLevelDetailView.<RefreshRoleSpineBack>d__29 <RefreshRoleSpineBack>d__;
			<RefreshRoleSpineBack>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshRoleSpineBack>d__.<>4__this = this;
			<RefreshRoleSpineBack>d__.roleConfig = roleConfig;
			<RefreshRoleSpineBack>d__.<>1__state = -1;
			<RefreshRoleSpineBack>d__.<>t__builder.Start<MatchThreeLevelDetailView.<RefreshRoleSpineBack>d__29>(ref <RefreshRoleSpineBack>d__);
			return <RefreshRoleSpineBack>d__.<>t__builder.Task;
		}

		// Token: 0x0603577C RID: 219004 RVA: 0x00EEE744 File Offset: 0x00EEC944
		[NullableContext(1)]
		private UniTask LoadAndPlayRoleSpine([Nullable(2)] USpineSkeletonAnimationComponent spine, MatchThreeRole roleConfig, Func<int> nextSerial, Func<int> currentSerial)
		{
			MatchThreeLevelDetailView.<LoadAndPlayRoleSpine>d__30 <LoadAndPlayRoleSpine>d__;
			<LoadAndPlayRoleSpine>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadAndPlayRoleSpine>d__.<>4__this = this;
			<LoadAndPlayRoleSpine>d__.spine = spine;
			<LoadAndPlayRoleSpine>d__.roleConfig = roleConfig;
			<LoadAndPlayRoleSpine>d__.nextSerial = nextSerial;
			<LoadAndPlayRoleSpine>d__.currentSerial = currentSerial;
			<LoadAndPlayRoleSpine>d__.<>1__state = -1;
			<LoadAndPlayRoleSpine>d__.<>t__builder.Start<MatchThreeLevelDetailView.<LoadAndPlayRoleSpine>d__30>(ref <LoadAndPlayRoleSpine>d__);
			return <LoadAndPlayRoleSpine>d__.<>t__builder.Task;
		}

		// Token: 0x0603577D RID: 219005 RVA: 0x00EEE7A8 File Offset: 0x00EEC9A8
		private void RefreshSkillIcons(MatchThreeRole roleConfig)
		{
			this.RefreshOneSkillIcon(7, (roleConfig.SkillsLength > 0) ? roleConfig.Skills(0) : 0);
			this.RefreshOneSkillIcon(8, (roleConfig.SkillsLength > 1) ? roleConfig.Skills(1) : 0);
		}

		// Token: 0x0603577E RID: 219006 RVA: 0x00EEE7E4 File Offset: 0x00EEC9E4
		private void RefreshOneSkillIcon(int componentIndex, int skillId)
		{
			UUISprite sprite = base.GetSprite(componentIndex);
			if (sprite == null)
			{
				return;
			}
			MatchThreeSkill? matchThreeSkill = (skillId > 0) ? ActivityMatchThreeConfig.Instance.GetSkillConfig(skillId) : null;
			if (matchThreeSkill == null || string.IsNullOrEmpty(matchThreeSkill.Value.Icon))
			{
				sprite.SetUIActive(false);
				return;
			}
			sprite.SetUIActive(true);
			this.SetSpriteByPath(matchThreeSkill.Value.Icon, sprite, false, null, null);
		}

		// Token: 0x0603577F RID: 219007 RVA: 0x00EEE868 File Offset: 0x00EECA68
		private void OnClickSelectRole()
		{
			if (this.ViewModel == null || this.IsEnteringChallenge)
			{
				return;
			}
			ActivityMatchThreeData activityData = this.ActivityData;
			if (activityData != null)
			{
				activityData.MarkSelectRoleBtnRedDotClicked();
			}
			this.RefreshSelectRoleRedDot();
			ActivityMatchThreeController.Instance.OpenRoleSelect(new MatchThreeRoleSelectViewParams
			{
				Mode = EMatchThreeRolePopupMode.Select,
				ViewModel = this.ViewModel,
				OnRoleSelected = new Action(this.OnRoleSelectedFromPopup)
			});
		}

		// Token: 0x06035780 RID: 219008 RVA: 0x00EEE8D1 File Offset: 0x00EECAD1
		private void OnRoleSelectedFromPopup()
		{
			this.PlaySwitchSequence();
			this.RefreshRoleInfo();
			this.RefreshSelectRoleRedDot();
		}

		// Token: 0x06035781 RID: 219009 RVA: 0x00EEE8E5 File Offset: 0x00EECAE5
		private void OnClickPopupInfo()
		{
			if (this.ViewModel == null || this.IsEnteringChallenge)
			{
				return;
			}
			ActivityMatchThreeController.Instance.OpenPopupInfoByLevel(this.ViewModel.CurrentLevelId, this.ViewModel.SelectedRoleId, false, 0, 0);
		}

		// Token: 0x06035782 RID: 219010 RVA: 0x00EEE91C File Offset: 0x00EECB1C
		private void OnClickChallenge()
		{
			if (this.ViewModel == null || this.ActivityData == null || this.IsEnteringChallenge)
			{
				return;
			}
			if (this.ViewModel.SelectedRoleId <= 0)
			{
				this.OnClickSelectRole();
				return;
			}
			if (this.ViewModel.DifficultyIndex > 0 && !this.ActivityData.CheckChallengeComplete(this.ViewModel.ChapterData.NormalLevelId))
			{
				return;
			}
			this.SetEnteringChallenge(true);
			ActivityMatchThreeController.Instance.TryEnterLevel(this.ViewModel.CurrentLevelId, this.ViewModel.SelectedRoleId, delegate(bool success)
			{
				if (!success && !base.IsDestroyOrDestroying)
				{
					this.SetEnteringChallenge(false);
				}
			});
		}

		// Token: 0x06035783 RID: 219011 RVA: 0x00EEE9B6 File Offset: 0x00EECBB6
		private void SetEnteringChallenge(bool entering)
		{
			this.IsEnteringChallenge = entering;
			UUIItem item = base.GetItem(17);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(entering);
		}

		// Token: 0x06035784 RID: 219012 RVA: 0x00EEE9D2 File Offset: 0x00EECBD2
		private void OnClickClose()
		{
			if (this.IsEnteringChallenge)
			{
				return;
			}
			UiManager.Instance.CloseView(EUiViewName.MatchThreeLevelDetailView, null);
		}

		// Token: 0x06035785 RID: 219013 RVA: 0x00EEE9F0 File Offset: 0x00EECBF0
		private void OnClickHelp()
		{
			if (!this.IsEnteringChallenge)
			{
				ActivityMatchThreeData activityData = this.ActivityData;
				if (activityData != null && activityData.LocalConfig != null)
				{
					HelpController.Instance.OpenHelpById(this.ActivityData.LocalConfig.Value.HelpId);
					return;
				}
			}
		}

		// Token: 0x06035786 RID: 219014 RVA: 0x00EEEA44 File Offset: 0x00EECC44
		private void OnChallengeStateUpdate(int challengeId)
		{
			this.RefreshAll();
		}

		// Token: 0x0401C382 RID: 115586
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401C383 RID: 115587
		private MatchThreeLevelDetailTipsPanel TipsPanel;

		// Token: 0x0401C384 RID: 115588
		private MatchThreeDifficultyTabItem EasyTab;

		// Token: 0x0401C385 RID: 115589
		private MatchThreeDifficultyTabItem HardTab;

		// Token: 0x0401C386 RID: 115590
		private MatchThreeLevelDetailViewModel ViewModel;

		// Token: 0x0401C387 RID: 115591
		private ActivityMatchThreeData ActivityData;

		// Token: 0x0401C388 RID: 115592
		private int SpineLoadSerial;

		// Token: 0x0401C389 RID: 115593
		private int SpineBackLoadSerial;

		// Token: 0x0401C38A RID: 115594
		private bool IsEnteringChallenge;
	}
}
