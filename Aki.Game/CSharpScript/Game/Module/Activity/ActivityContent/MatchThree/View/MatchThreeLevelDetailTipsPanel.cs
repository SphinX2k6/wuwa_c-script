using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.View
{
	// Token: 0x02006494 RID: 25748
	[NullableContext(1)]
	[Nullable(0)]
	public class MatchThreeLevelDetailTipsPanel : UiPanelBase
	{
		// Token: 0x06040A90 RID: 264848 RVA: 0x00FA6514 File Offset: 0x00FA4714
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClickConfirm));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickLevelDetail));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06040A91 RID: 264849 RVA: 0x00FA672C File Offset: 0x00FA492C
		protected override UniTask OnBeforeStartAsync()
		{
			MatchThreeLevelDetailTipsPanel.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MatchThreeLevelDetailTipsPanel.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040A92 RID: 264850 RVA: 0x00FA676F File Offset: 0x00FA496F
		public void SetConfirmCallback(Action callback)
		{
			this.ConfirmCallback = callback;
		}

		// Token: 0x06040A93 RID: 264851 RVA: 0x00FA6778 File Offset: 0x00FA4978
		public void SetLevelDetailCallback(Action callback)
		{
			this.LevelDetailCallback = callback;
		}

		// Token: 0x06040A94 RID: 264852 RVA: 0x00FA6784 File Offset: 0x00FA4984
		public void Refresh(MatchThreeLevelDetailViewModel viewModel, ActivityMatchThreeData activityData)
		{
			this.ActivityData = activityData;
			this.CurrentLevelId = viewModel.CurrentLevelId;
			MatchThreeLevel? levelConfig = activityData.GetLevelConfig(this.CurrentLevelId);
			bool isEndless = viewModel.ChapterData.IsEndless;
			this.RefreshTitleBg(isEndless);
			this.RefreshLevelInfo(levelConfig, this.CurrentLevelId);
			this.RefreshReward(levelConfig);
			this.RefreshChallengeButton(viewModel, activityData, isEndless);
		}

		// Token: 0x06040A95 RID: 264853 RVA: 0x00FA67E4 File Offset: 0x00FA49E4
		private void RefreshLevelInfo(MatchThreeLevel? levelConfig, int levelId)
		{
			ActivityMatchThreeConfig instance = ActivityMatchThreeConfig.Instance;
			string content = (levelConfig != null) ? instance.BuildLevelDetailTitle(levelConfig.Value) : string.Empty;
			MatchThreeLevelDetailTipsPanel.SetInfoText(base.GetText(0), content);
			this.RefreshLevelDesc(levelConfig);
			this.RefreshTargetText(levelConfig, levelId);
			this.RefreshEnvironmentText(levelId);
			UUIButtonComponent button = base.GetButton(6);
			if (button == null)
			{
				return;
			}
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(ActivityMatchThreeConfig.Instance.HasLevelEnvironments(levelId));
		}

		// Token: 0x06040A96 RID: 264854 RVA: 0x00FA6868 File Offset: 0x00FA4A68
		private void RefreshLevelDesc(MatchThreeLevel? levelConfig)
		{
			UUIText text = base.GetText(11);
			if (text == null)
			{
				return;
			}
			string text2 = (levelConfig != null) ? levelConfig.GetValueOrDefault().Description : null;
			if (string.IsNullOrEmpty(text2))
			{
				text.SetUIActive(true);
				return;
			}
			LguiUtil.Instance.TrySetLocalTextNew(text, text2, Array.Empty<object>());
		}

		// Token: 0x06040A97 RID: 264855 RVA: 0x00FA68C0 File Offset: 0x00FA4AC0
		private void RefreshTargetText(MatchThreeLevel? levelConfig, int levelId)
		{
			UUIText text = base.GetText(4);
			if (text == null)
			{
				return;
			}
			if (levelConfig != null && levelConfig.GetValueOrDefault().EndLess)
			{
				text.SetUIActive(true);
				LguiUtil.Instance.TrySetLocalTextNew(text, "MatchThree_StageGoal_Endless", Array.Empty<object>());
				return;
			}
			MatchThreeGameplay? gameplayConfig = ActivityMatchThreeConfig.Instance.GetGameplayConfig(levelId);
			if (gameplayConfig == null || gameplayConfig.Value.GoalLength <= 0)
			{
				text.SetUIActive(false);
				return;
			}
			MatchThreeGoal? goalConfig = ActivityMatchThreeConfig.Instance.GetGoalConfig(gameplayConfig.Value.Goal(0));
			if (goalConfig == null)
			{
				text.SetUIActive(false);
				return;
			}
			MatchThreeGoal value = goalConfig.Value;
			string condDesc = value.CondDesc;
			if (string.IsNullOrEmpty(condDesc) || value.ParamsLength <= 0)
			{
				text.SetUIActive(false);
				return;
			}
			text.SetUIActive(true);
			EGoalCondType condType = (EGoalCondType)value.CondType;
			bool flag = condType - EGoalCondType.ClearCharger <= 1;
			if (flag)
			{
				LguiUtil.Instance.TrySetLocalTextNew(text, condDesc, new <>z__ReadOnlyArray<object>(new object[]
				{
					value.Params(0),
					ActivityMatchThreeConfig.Instance.GetGoalPieceDisplayName(value)
				}));
				return;
			}
			LguiUtil.Instance.TrySetLocalTextNew(text, condDesc, new <>z__ReadOnlySingleElementList<object>(value.Params(0)));
		}

		// Token: 0x06040A98 RID: 264856 RVA: 0x00FA6A14 File Offset: 0x00FA4C14
		private void RefreshEnvironmentText(int levelId)
		{
			UUIText text = base.GetText(5);
			if (text == null)
			{
				return;
			}
			string levelEnvironmentDescTextId = ActivityMatchThreeConfig.Instance.GetLevelEnvironmentDescTextId(levelId);
			if (string.IsNullOrEmpty(levelEnvironmentDescTextId))
			{
				LguiUtil.Instance.TrySetLocalTextNew(text, "Weather_NoEffect", Array.Empty<object>());
				return;
			}
			LguiUtil.Instance.TrySetLocalTextNew(text, levelEnvironmentDescTextId, Array.Empty<object>());
		}

		// Token: 0x06040A99 RID: 264857 RVA: 0x00FA6A68 File Offset: 0x00FA4C68
		private static void SetInfoText([Nullable(2)] UUIText text, string content)
		{
			if (text == null)
			{
				return;
			}
			bool flag = !string.IsNullOrEmpty(content);
			text.SetUIActive(flag);
			if (flag)
			{
				text.SetText(content, true);
			}
		}

		// Token: 0x06040A9A RID: 264858 RVA: 0x00FA6A98 File Offset: 0x00FA4C98
		private void RefreshReward(MatchThreeLevel? levelConfig)
		{
			int num = (levelConfig != null) ? levelConfig.GetValueOrDefault().RewardDrop : 0;
			List<TItem> list = (num > 0) ? CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(num) : new List<TItem>();
			GenericScrollViewNew<CommonItemSmallItemGrid, TItem> rewardScroll = this.RewardScroll;
			if (rewardScroll != null)
			{
				rewardScroll.RefreshByData(list, null, false);
			}
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(7);
			if (scrollViewWithScrollbar == null)
			{
				return;
			}
			UUIItem uuiitem = scrollViewWithScrollbar.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(list.Count > 0);
		}

		// Token: 0x06040A9B RID: 264859 RVA: 0x00FA6B18 File Offset: 0x00FA4D18
		private void RefreshChallengeButton(MatchThreeLevelDetailViewModel viewModel, ActivityMatchThreeData activityData, bool isEndless)
		{
			bool flag = !isEndless && viewModel.DifficultyIndex > 0 && !activityData.CheckChallengeComplete(viewModel.ChapterData.NormalLevelId);
			UUIButtonComponent button = base.GetButton(9);
			if (button != null)
			{
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(!flag);
				}
			}
			UUIItem item = base.GetItem(10);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			if (flag)
			{
				MatchThreeLevelDetailTipsPanel.RefreshHardLockTipText(item);
			}
		}

		// Token: 0x06040A9C RID: 264860 RVA: 0x00FA6B90 File Offset: 0x00FA4D90
		[NullableContext(2)]
		private static void RefreshHardLockTipText(UUIItem lockPanel)
		{
			if (lockPanel == null)
			{
				return;
			}
			AActor owner = lockPanel.GetOwner();
			if (owner == null)
			{
				return;
			}
			TArray<UActorComponent> componentsInChildren = ULGUIBPLibrary.GetComponentsInChildren(owner, UUIText.StaticClass(), true);
			for (int i = 0; i < componentsInChildren.Num(); i++)
			{
				UUIText uuitext = componentsInChildren.Get(i) as UUIText;
				if (uuitext != null)
				{
					LguiUtil.Instance.TrySetLocalTextNew(uuitext, "Tetristext_14", Array.Empty<object>());
				}
			}
		}

		// Token: 0x06040A9D RID: 264861 RVA: 0x00FA6BF4 File Offset: 0x00FA4DF4
		private void RefreshTitleBg(bool isEndless)
		{
			string path = isEndless ? "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity37/Match3Game/LevelDetail/SP_InfoTitleBg2.SP_InfoTitleBg2" : "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity37/Match3Game/LevelDetail/SP_InfoTitleBg1.SP_InfoTitleBg1";
			UUISprite sprite = base.GetSprite(2);
			if (sprite != null)
			{
				this.SetSpriteByPath(path, sprite, false, null, null);
			}
			UUISprite sprite2 = base.GetSprite(3);
			if (sprite2 != null)
			{
				this.SetSpriteByPath(path, sprite2, false, null, null);
			}
		}

		// Token: 0x06040A9E RID: 264862 RVA: 0x00FA6C4D File Offset: 0x00FA4E4D
		private CommonItemSmallItemGrid CreateRewardItem()
		{
			return new CommonItemSmallItemGrid
			{
				ShowReceivedCallBack = new Func<TItem, bool>(this.OnShowRewardReceived)
			};
		}

		// Token: 0x06040A9F RID: 264863 RVA: 0x00FA6C66 File Offset: 0x00FA4E66
		private bool OnShowRewardReceived(TItem _)
		{
			return this.ActivityData != null && this.CurrentLevelId > 0 && this.ActivityData.CheckChallengeComplete(this.CurrentLevelId);
		}

		// Token: 0x06040AA0 RID: 264864 RVA: 0x00FA6C8C File Offset: 0x00FA4E8C
		private void OnClickConfirm()
		{
			Action confirmCallback = this.ConfirmCallback;
			if (confirmCallback == null)
			{
				return;
			}
			confirmCallback();
		}

		// Token: 0x06040AA1 RID: 264865 RVA: 0x00FA6C9E File Offset: 0x00FA4E9E
		private void OnClickLevelDetail()
		{
			Action levelDetailCallback = this.LevelDetailCallback;
			if (levelDetailCallback == null)
			{
				return;
			}
			levelDetailCallback();
		}

		// Token: 0x04021A39 RID: 137785
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScroll;

		// Token: 0x04021A3A RID: 137786
		[Nullable(2)]
		private Action ConfirmCallback;

		// Token: 0x04021A3B RID: 137787
		[Nullable(2)]
		private Action LevelDetailCallback;

		// Token: 0x04021A3C RID: 137788
		[Nullable(2)]
		private ActivityMatchThreeData ActivityData;

		// Token: 0x04021A3D RID: 137789
		private int CurrentLevelId;
	}
}
