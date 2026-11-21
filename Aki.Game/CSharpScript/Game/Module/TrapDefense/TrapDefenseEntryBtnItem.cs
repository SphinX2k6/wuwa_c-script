using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A35 RID: 14901
	public class TrapDefenseEntryBtnItem : UiPanelBase
	{
		// Token: 0x0602650E RID: 156942 RVA: 0x00ABB25B File Offset: 0x00AB945B
		public TrapDefenseEntryBtnItem(ETrapDefenseLevelType mode)
		{
			this.Mode = mode;
		}

		// Token: 0x0602650F RID: 156943 RVA: 0x00ABB26C File Offset: 0x00AB946C
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

		// Token: 0x06026510 RID: 156944 RVA: 0x00ABB43E File Offset: 0x00AB963E
		protected override void OnStart()
		{
			this.BindRedDot();
			this.RefreshByMode();
		}

		// Token: 0x06026511 RID: 156945 RVA: 0x00ABB44C File Offset: 0x00AB964C
		protected override void OnBeforeDestroy()
		{
			RedDotController.Instance.UnBindRedDot(ERedDotName.TrapDefenseMainLevel);
			RedDotController.Instance.UnBindRedDot(ERedDotName.TrapDefenseRougeLevel);
		}

		// Token: 0x06026512 RID: 156946 RVA: 0x00ABB46C File Offset: 0x00AB966C
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

		// Token: 0x06026513 RID: 156947 RVA: 0x00ABB4DC File Offset: 0x00AB96DC
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

		// Token: 0x06026514 RID: 156948 RVA: 0x00ABB500 File Offset: 0x00AB9700
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

		// Token: 0x06026515 RID: 156949 RVA: 0x00ABB5EC File Offset: 0x00AB97EC
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

		// Token: 0x06026516 RID: 156950 RVA: 0x00ABB7A0 File Offset: 0x00AB99A0
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

		// Token: 0x06026517 RID: 156951 RVA: 0x00ABB7E4 File Offset: 0x00AB99E4
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

		// Token: 0x04015090 RID: 86160
		public readonly ETrapDefenseLevelType Mode;

		// Token: 0x020095FE RID: 38398
		private class EComponentDefine
		{
			// Token: 0x0402ED58 RID: 191832
			public const int BtnSelf = 0;

			// Token: 0x0402ED59 RID: 191833
			public const int TextTitle = 1;

			// Token: 0x0402ED5A RID: 191834
			public const int TextScoreLabel = 2;

			// Token: 0x0402ED5B RID: 191835
			public const int ArtTextScore = 3;

			// Token: 0x0402ED5C RID: 191836
			public const int TextLevelLabel = 4;

			// Token: 0x0402ED5D RID: 191837
			public const int TextLevelProgress = 5;

			// Token: 0x0402ED5E RID: 191838
			public const int ItemRedDot = 6;

			// Token: 0x0402ED5F RID: 191839
			public const int TextLockTips = 7;

			// Token: 0x0402ED60 RID: 191840
			public const int ItemUnlockPanel = 8;

			// Token: 0x0402ED61 RID: 191841
			public const int ItemLockPanel = 9;

			// Token: 0x0402ED62 RID: 191842
			public const int ItemLevelInfo = 10;
		}
	}
}
