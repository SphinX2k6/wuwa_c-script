using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A8D RID: 19085
	public class TrapDefenseEntryBtnItem : UiPanelBase
	{
		// Token: 0x0603177E RID: 202622 RVA: 0x00B772A7 File Offset: 0x00B754A7
		public TrapDefenseEntryBtnItem(ETrapDefenseLevelType mode)
		{
			this.Mode = mode;
		}

		// Token: 0x0603177F RID: 202623 RVA: 0x00B772B8 File Offset: 0x00B754B8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
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
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06031780 RID: 202624 RVA: 0x00B7748A File Offset: 0x00B7568A
		protected override void OnStart()
		{
			this.BindRedDot();
			this.RefreshByMode();
		}

		// Token: 0x06031781 RID: 202625 RVA: 0x00B77498 File Offset: 0x00B75698
		protected override void OnBeforeDestroy()
		{
			RedDotController.Instance.UnBindRedDot(ERedDotName.TrapDefenseMainLevel);
			RedDotController.Instance.UnBindRedDot(ERedDotName.TrapDefenseRougeLevel);
		}

		// Token: 0x06031782 RID: 202626 RVA: 0x00B774B8 File Offset: 0x00B756B8
		public void RefreshUnlockTimer()
		{
			if (TrapDefenseModel.Instance.RougeModeData.ModeIsOpen())
			{
				return;
			}
			double unlockRemainTime = TrapDefenseModel.Instance.RougeModeData.GetUnlockRemainTime();
			string item = TimeUtil.Instance.GetRemainTimeDataFormat3(unlockRemainTime).CountDownText ?? "";
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), ETrapDefenseTextKey.RogueUnlockCountDown.ToString(), new <>z__ReadOnlySingleElementList<object>(item));
		}

		// Token: 0x06031783 RID: 202627 RVA: 0x00B77528 File Offset: 0x00B75728
		public void RefreshByMode()
		{
			if (this.Mode == ETrapDefenseLevelType.Mainline)
			{
				this.RefreshLevelMode();
				return;
			}
			if (this.Mode == ETrapDefenseLevelType.RougeNormal)
			{
				this.RefreshRogueMode();
			}
		}

		// Token: 0x06031784 RID: 202628 RVA: 0x00B7754C File Offset: 0x00B7574C
		private void RefreshLevelMode()
		{
			ValueTuple<int, int> modeStarProgress = TrapDefenseModel.Instance.LevelModeData.GetModeStarProgress();
			int item = modeStarProgress.Item1;
			int item2 = modeStarProgress.Item2;
			UUIArtText artText = base.GetArtText(3);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(item);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(item2);
			artText.SetText(defaultInterpolatedStringHandler.ToStringAndClear());
			TrapDefenseLevelData nextChallengeData = TrapDefenseModel.Instance.LevelModeData.GetNextChallengeData();
			if (nextChallengeData != null)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(4), nextChallengeData.Config.Name, Array.Empty<object>());
				LguiUtil.Instance.SetLocalTextNew(base.GetText(5), nextChallengeData.GetDifficultyUiInfo().NameKey.ToString(), Array.Empty<object>());
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "", Array.Empty<object>());
			base.GetText(5).SetText("", true);
		}

		// Token: 0x06031785 RID: 202629 RVA: 0x00B77638 File Offset: 0x00B75838
		private void RefreshRogueMode()
		{
			bool flag = TrapDefenseModel.Instance.RougeModeData.ModeIsOpen();
			base.GetText(2).SetUIActive(flag);
			ValueTuple<int, int> modeStarProgress = TrapDefenseModel.Instance.RougeModeData.GetModeStarProgress();
			int item = modeStarProgress.Item1;
			int item2 = modeStarProgress.Item2;
			UUIArtText artText = base.GetArtText(3);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(item);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(item2);
			artText.SetText(defaultInterpolatedStringHandler.ToStringAndClear());
			int endlessPassedMaxWaveTimes = TrapDefenseModel.Instance.RougeModeData.GetEndlessPassedMaxWaveTimes();
			base.GetText(4).SetUIActive(endlessPassedMaxWaveTimes > 0);
			base.GetText(5).SetUIActive(endlessPassedMaxWaveTimes > 0);
			if (endlessPassedMaxWaveTimes > 0)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(4), ETrapDefenseTextKey.EndlessRogueBestRecord.ToString(), Array.Empty<object>());
				LguiUtil.Instance.SetLocalTextNew(base.GetText(5), ETrapDefenseTextKey.EndlessRogueBestWaves.ToString(), new <>z__ReadOnlySingleElementList<object>(endlessPassedMaxWaveTimes));
			}
			bool flag2 = TrapDefenseModel.Instance.RougeModeData.CanEnterRougeMode();
			base.GetItem(8).SetUIActive(flag && flag2);
			base.GetItem(9).SetUIActive(!flag || !flag2);
			this.RefreshUnlockTimer();
			if (!flag)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(7), ETrapDefenseTextKey.RogueUnlockTimeLimit.ToString(), Array.Empty<object>());
				return;
			}
			if (!flag2 && TrapDefenseModel.Instance.RougeModeData.GetUnlockRemainTime() <= 0.0)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(7), ETrapDefenseTextKey.RogueUnlockStageLimit.ToString(), Array.Empty<object>());
			}
		}

		// Token: 0x06031786 RID: 202630 RVA: 0x00B777EC File Offset: 0x00B759EC
		private void BindRedDot()
		{
			UUIItem item = base.GetItem(6);
			if (this.Mode == ETrapDefenseLevelType.Mainline)
			{
				RedDotController.Instance.BindRedDot(ERedDotName.TrapDefenseMainLevel, item, null, 0);
				return;
			}
			RedDotController.Instance.BindRedDot(ERedDotName.TrapDefenseRougeModeOpen, item, null, 0);
		}

		// Token: 0x06031787 RID: 202631 RVA: 0x00B77830 File Offset: 0x00B75A30
		private void OnBtnClick()
		{
			if (this.Mode == ETrapDefenseLevelType.Mainline)
			{
				TrapDefenseLevelData nextChallengeData = TrapDefenseModel.Instance.LevelModeData.GetNextChallengeData();
				TrapDefenseModel instance = TrapDefenseModel.Instance;
				int? id = (nextChallengeData != null) ? new int?(nextChallengeData.Id) : null;
				ETrapDefenseDifficultyLevel? difficulty2;
				if (nextChallengeData != null)
				{
					int difficulty = nextChallengeData.Config.Difficulty;
					difficulty2 = new ETrapDefenseDifficultyLevel?((ETrapDefenseDifficultyLevel)((nextChallengeData != null) ? new int?(nextChallengeData.Config.Difficulty) : null).Value);
				}
				else
				{
					difficulty2 = null;
				}
				instance.OpenViewMainLevelMode(id, difficulty2, null);
				return;
			}
			TrapDefenseModel.Instance.OpenViewRougeLevelMode(null, null);
		}

		// Token: 0x0401A73E RID: 108350
		public readonly ETrapDefenseLevelType Mode;

		// Token: 0x0200ABDE RID: 43998
		private class EComponentDefine
		{
			// Token: 0x040343A7 RID: 213927
			public const int BtnSelf = 0;

			// Token: 0x040343A8 RID: 213928
			public const int TextTitle = 1;

			// Token: 0x040343A9 RID: 213929
			public const int TextScoreLabel = 2;

			// Token: 0x040343AA RID: 213930
			public const int ArtTextScore = 3;

			// Token: 0x040343AB RID: 213931
			public const int TextLevelLabel = 4;

			// Token: 0x040343AC RID: 213932
			public const int TextLevelProgress = 5;

			// Token: 0x040343AD RID: 213933
			public const int ItemRedDot = 6;

			// Token: 0x040343AE RID: 213934
			public const int TextLockTips = 7;

			// Token: 0x040343AF RID: 213935
			public const int ItemUnlockPanel = 8;

			// Token: 0x040343B0 RID: 213936
			public const int ItemLockPanel = 9;

			// Token: 0x040343B1 RID: 213937
			public const int ItemLevelInfo = 10;
		}
	}
}
