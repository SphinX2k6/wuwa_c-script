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
	// Token: 0x02006496 RID: 25750
	[NullableContext(2)]
	[Nullable(0)]
	public class MatchThreeLevelDetailView : UiViewBase
	{
		// Token: 0x06040AA3 RID: 264867 RVA: 0x00FA6CB8 File Offset: 0x00FA4EB8
		[NullableContext(1)]
		public MatchThreeLevelDetailView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06040AA4 RID: 264868 RVA: 0x00FA6CC4 File Offset: 0x00FA4EC4
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

		// Token: 0x06040AA5 RID: 264869 RVA: 0x00FA6F84 File Offset: 0x00FA5184
		protected override UniTask OnBeforeStartAsync()
		{
			MatchThreeLevelDetailView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MatchThreeLevelDetailView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040AA6 RID: 264870 RVA: 0x00FA6FC8 File Offset: 0x00FA51C8
		private UniTask InitDifficultyTabsAsync()
		{
			MatchThreeLevelDetailView.<InitDifficultyTabsAsync>d__12 <InitDifficultyTabsAsync>d__;
			<InitDifficultyTabsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDifficultyTabsAsync>d__.<>4__this = this;
			<InitDifficultyTabsAsync>d__.<>1__state = -1;
			<InitDifficultyTabsAsync>d__.<>t__builder.Start<MatchThreeLevelDetailView.<InitDifficultyTabsAsync>d__12>(ref <InitDifficultyTabsAsync>d__);
			return <InitDifficultyTabsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040AA7 RID: 264871 RVA: 0x00FA700B File Offset: 0x00FA520B
		protected override void OnBeforeShow()
		{
			this.SetEnteringChallenge(false);
			this.RefreshAll();
			ActivityMatchThreeController.Instance.TryShowPendingRoleUnlockTips(new Action(this.RefreshSelectRoleRedDot));
		}

		// Token: 0x06040AA8 RID: 264872 RVA: 0x00FA7030 File Offset: 0x00FA5230
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.OnMatchThreeChallengeStateUpdate, new Action<int>(this.OnChallengeStateUpdate));
			EventSystem.Instance.Add(EEventName.OnMatchThreeRoleNewRedDotUpdate, new Action(this.RefreshSelectRoleRedDot));
		}

		// Token: 0x06040AA9 RID: 264873 RVA: 0x00FA706A File Offset: 0x00FA526A
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.OnMatchThreeChallengeStateUpdate, new Action<int>(this.OnChallengeStateUpdate));
			EventSystem.Instance.Remove(EEventName.OnMatchThreeRoleNewRedDotUpdate, new Action(this.RefreshSelectRoleRedDot));
		}

		// Token: 0x06040AAA RID: 264874 RVA: 0x00FA70A4 File Offset: 0x00FA52A4
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

		// Token: 0x06040AAB RID: 264875 RVA: 0x00FA710C File Offset: 0x00FA530C
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

		// Token: 0x06040AAC RID: 264876 RVA: 0x00FA7174 File Offset: 0x00FA5374
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

		// Token: 0x06040AAD RID: 264877 RVA: 0x00FA71BB File Offset: 0x00FA53BB
		private void ApplyDefaultDifficulty()
		{
			if (this.ViewModel == null || this.ActivityData == null)
			{
				return;
			}
			this.ViewModel.DifficultyIndex = ActivityMatchThreeController.ResolveDefaultDifficultyIndex(this.ViewModel.ChapterData, this.ActivityData);
		}

		// Token: 0x06040AAE RID: 264878 RVA: 0x00FA71F0 File Offset: 0x00FA53F0
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

		// Token: 0x06040AAF RID: 264879 RVA: 0x00FA7244 File Offset: 0x00FA5444
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

		// Token: 0x06040AB0 RID: 264880 RVA: 0x00FA73E4 File Offset: 0x00FA55E4
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

		// Token: 0x06040AB1 RID: 264881 RVA: 0x00FA7430 File Offset: 0x00FA5630
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

		// Token: 0x06040AB2 RID: 264882 RVA: 0x00FA74CC File Offset: 0x00FA56CC
		private void PlaySwitchSequence()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.StopPrevSequence(false, true);
			}
			base.PlayOrReplaySequence("Switch", false, null);
		}

		// Token: 0x06040AB3 RID: 264883 RVA: 0x00FA7504 File Offset: 0x00FA5704
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

		// Token: 0x06040AB4 RID: 264884 RVA: 0x00FA75A4 File Offset: 0x00FA57A4
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

		// Token: 0x06040AB5 RID: 264885 RVA: 0x00FA7618 File Offset: 0x00FA5818
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

		// Token: 0x06040AB6 RID: 264886 RVA: 0x00FA7664 File Offset: 0x00FA5864
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

		// Token: 0x06040AB7 RID: 264887 RVA: 0x00FA76B0 File Offset: 0x00FA58B0
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

		// Token: 0x06040AB8 RID: 264888 RVA: 0x00FA76FC File Offset: 0x00FA58FC
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

		// Token: 0x06040AB9 RID: 264889 RVA: 0x00FA7760 File Offset: 0x00FA5960
		private void RefreshSkillIcons(MatchThreeRole roleConfig)
		{
			this.RefreshOneSkillIcon(7, (roleConfig.SkillsLength > 0) ? roleConfig.Skills(0) : 0);
			this.RefreshOneSkillIcon(8, (roleConfig.SkillsLength > 1) ? roleConfig.Skills(1) : 0);
		}

		// Token: 0x06040ABA RID: 264890 RVA: 0x00FA779C File Offset: 0x00FA599C
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

		// Token: 0x06040ABB RID: 264891 RVA: 0x00FA7820 File Offset: 0x00FA5A20
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

		// Token: 0x06040ABC RID: 264892 RVA: 0x00FA7889 File Offset: 0x00FA5A89
		private void OnRoleSelectedFromPopup()
		{
			this.PlaySwitchSequence();
			this.RefreshRoleInfo();
			this.RefreshSelectRoleRedDot();
		}

		// Token: 0x06040ABD RID: 264893 RVA: 0x00FA789D File Offset: 0x00FA5A9D
		private void OnClickPopupInfo()
		{
			if (this.ViewModel == null || this.IsEnteringChallenge)
			{
				return;
			}
			ActivityMatchThreeController.Instance.OpenPopupInfoByLevel(this.ViewModel.CurrentLevelId, this.ViewModel.SelectedRoleId, false, 0, 0);
		}

		// Token: 0x06040ABE RID: 264894 RVA: 0x00FA78D4 File Offset: 0x00FA5AD4
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

		// Token: 0x06040ABF RID: 264895 RVA: 0x00FA796E File Offset: 0x00FA5B6E
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

		// Token: 0x06040AC0 RID: 264896 RVA: 0x00FA798A File Offset: 0x00FA5B8A
		private void OnClickClose()
		{
			if (this.IsEnteringChallenge)
			{
				return;
			}
			UiManager.Instance.CloseView(EUiViewName.MatchThreeLevelDetailView, null);
		}

		// Token: 0x06040AC1 RID: 264897 RVA: 0x00FA79A8 File Offset: 0x00FA5BA8
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

		// Token: 0x06040AC2 RID: 264898 RVA: 0x00FA79FC File Offset: 0x00FA5BFC
		private void OnChallengeStateUpdate(int challengeId)
		{
			this.RefreshAll();
		}

		// Token: 0x04021A51 RID: 137809
		private PopupCaptionItem CaptionItem;

		// Token: 0x04021A52 RID: 137810
		private MatchThreeLevelDetailTipsPanel TipsPanel;

		// Token: 0x04021A53 RID: 137811
		private MatchThreeDifficultyTabItem EasyTab;

		// Token: 0x04021A54 RID: 137812
		private MatchThreeDifficultyTabItem HardTab;

		// Token: 0x04021A55 RID: 137813
		private MatchThreeLevelDetailViewModel ViewModel;

		// Token: 0x04021A56 RID: 137814
		private ActivityMatchThreeData ActivityData;

		// Token: 0x04021A57 RID: 137815
		private int SpineLoadSerial;

		// Token: 0x04021A58 RID: 137816
		private int SpineBackLoadSerial;

		// Token: 0x04021A59 RID: 137817
		private bool IsEnteringChallenge;
	}
}
