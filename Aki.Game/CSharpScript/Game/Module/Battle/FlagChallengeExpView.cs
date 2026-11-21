using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.FlagChallenge;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02004C13 RID: 19475
	[NullableContext(2)]
	[Nullable(0)]
	public class FlagChallengeExpView : BattleVisibleChildView
	{
		// Token: 0x06030976 RID: 199030 RVA: 0x00D8AAE4 File Offset: 0x00D88CE4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 14;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06030977 RID: 199031 RVA: 0x00D8ACE0 File Offset: 0x00D88EE0
		protected override UniTask OnBeforeStartAsync()
		{
			FlagChallengeExpView.<OnBeforeStartAsync>d__35 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FlagChallengeExpView.<OnBeforeStartAsync>d__35>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030978 RID: 199032 RVA: 0x00D8AD24 File Offset: 0x00D88F24
		protected override void OnStart()
		{
			this.AddExpBar = base.GetSprite(0);
			this.ChangeExpBar = base.GetSprite(1);
			this.LevelText = base.GetArtText(2);
			this.ExpValuePanel = base.GetItem(3);
			this.AddExpText = base.GetText(4);
			this.CurrentExpText = base.GetText(5);
			this.LevelMaxLightTexture = base.GetTexture(8);
			this.LevelMaxBgTexture = base.GetTexture(9);
			this.LevelMaxText = base.GetTexture(10);
			this.LevelBgSprite = base.GetSprite(12);
			this.DisableItem = base.GetItem(13);
			UUISprite addExpBar = this.AddExpBar;
			if (addExpBar != null)
			{
				addExpBar.SetFillAmount(0f);
			}
			UUISprite changeExpBar = this.ChangeExpBar;
			if (changeExpBar != null)
			{
				changeExpBar.SetFillAmount(0f);
			}
			UUIArtText levelText = this.LevelText;
			if (levelText != null)
			{
				levelText.SetText("1");
			}
			UUIItem expValuePanel = this.ExpValuePanel;
			if (expValuePanel != null)
			{
				expValuePanel.SetUIActive(false);
			}
			UUISprite changeExpBar2 = this.ChangeExpBar;
			if (changeExpBar2 != null)
			{
				changeExpBar2.SetUIActive(false);
			}
			FlagChallengeAnimItem flagChallengeAnimItem = this.FlagChallengeAnimItem;
			if (flagChallengeAnimItem != null)
			{
				flagChallengeAnimItem.SetUiActive(false);
			}
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceEnd), false);
		}

		// Token: 0x06030979 RID: 199033 RVA: 0x00D8AE6A File Offset: 0x00D8906A
		protected override void OnBeforeDestroy()
		{
			if (this.ExpTextTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.ExpTextTimer);
				this.ExpTextTimer = null;
			}
		}

		// Token: 0x0603097A RID: 199034 RVA: 0x00D8AE8C File Offset: 0x00D8908C
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			base.InitChildType(EBattleUiChild.MiniMap);
			base.SetVisible(1, false);
			this.AddEvents();
		}

		// Token: 0x0603097B RID: 199035 RVA: 0x00D8AEAA File Offset: 0x00D890AA
		public override void Reset()
		{
			this.RemoveEvents();
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.IsPendingChangeInfo = false;
			FlagChallengeAnimItem flagChallengeAnimItem = this.FlagChallengeAnimItem;
			if (flagChallengeAnimItem != null)
			{
				flagChallengeAnimItem.Clear();
			}
			base.Reset();
		}

		// Token: 0x0603097C RID: 199036 RVA: 0x00D8AEE4 File Offset: 0x00D890E4
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnFlagChallengeExpChanged, new Action<int, int, int, int>(this.OnFlagChallengeExpChanged));
			EventSystem.Instance.Add(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
			EventSystem.Instance.Add(EEventName.LoadingViewOnAfterShow, new Action(this.OnRefreshPendingChangeInfo));
		}

		// Token: 0x0603097D RID: 199037 RVA: 0x00D8AF48 File Offset: 0x00D89148
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnFlagChallengeExpChanged, new Action<int, int, int, int>(this.OnFlagChallengeExpChanged));
			EventSystem.Instance.Remove(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
			EventSystem.Instance.Remove(EEventName.LoadingViewOnAfterShow, new Action(this.OnRefreshPendingChangeInfo));
		}

		// Token: 0x0603097E RID: 199038 RVA: 0x00D8AFA9 File Offset: 0x00D891A9
		[NullableContext(1)]
		private void OnSequenceEnd(string sequenceName)
		{
			if (sequenceName == "Close" && !FlagChallengeBattleModel.Instance.IsInFlagChallengeDungeon)
			{
				base.SetVisible(1, false);
			}
		}

		// Token: 0x0603097F RID: 199039 RVA: 0x00D8AFCC File Offset: 0x00D891CC
		public void StartShow()
		{
			this.IsShowFlagChallengeUi = true;
			this.RefreshFlagChallengeInfo();
			base.SetVisible(1, true);
			this.PlayStartShowAnim();
			this.OnBattleStateChanged(FormationDataController.Instance.GlobalIsInFight);
		}

		// Token: 0x06030980 RID: 199040 RVA: 0x00D8AFF9 File Offset: 0x00D891F9
		public void EndShow()
		{
			this.IsShowFlagChallengeUi = false;
			this.PlayEndShowAnim();
		}

		// Token: 0x06030981 RID: 199041 RVA: 0x00D8B008 File Offset: 0x00D89208
		private void PlayStartShowAnim()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.StopCurrentSequence(false, false);
			}
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 != null)
			{
				levelSequencePlayer2.PlaySequencePurely("Start", false, false, null, null, false);
			}
			FlagChallengeAnimItem flagChallengeAnimItem = this.FlagChallengeAnimItem;
			if (flagChallengeAnimItem != null)
			{
				flagChallengeAnimItem.PlayStartShowAnim();
			}
			FlagChallengeAnimItem flagChallengeAnimItem2 = this.FlagChallengeAnimItem;
			if (flagChallengeAnimItem2 == null)
			{
				return;
			}
			flagChallengeAnimItem2.SetUiActive(true);
		}

		// Token: 0x06030982 RID: 199042 RVA: 0x00D8B070 File Offset: 0x00D89270
		private void PlayEndShowAnim()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.StopCurrentSequence(false, false);
			}
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 != null)
			{
				levelSequencePlayer2.PlaySequencePurely("Close", false, false, null, null, false);
			}
			FlagChallengeAnimItem flagChallengeAnimItem = this.FlagChallengeAnimItem;
			if (flagChallengeAnimItem != null)
			{
				flagChallengeAnimItem.PlayEndShowAnim();
			}
			FlagChallengeAnimItem flagChallengeAnimItem2 = this.FlagChallengeAnimItem;
			if (flagChallengeAnimItem2 == null)
			{
				return;
			}
			flagChallengeAnimItem2.SetUiActive(true);
		}

		// Token: 0x06030983 RID: 199043 RVA: 0x00D8B0D8 File Offset: 0x00D892D8
		private void PlayLevelUpAnim()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null && levelSequencePlayer.IsPlayingSequence("Up"))
			{
				LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
				if (levelSequencePlayer2 != null)
				{
					levelSequencePlayer2.StopSequenceByKey("Up", false, true);
				}
			}
			LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
			if (levelSequencePlayer3 == null)
			{
				return;
			}
			levelSequencePlayer3.PlaySequencePurely("Up", false, false, null, null, false);
		}

		// Token: 0x06030984 RID: 199044 RVA: 0x00D8B138 File Offset: 0x00D89338
		public void Tick(float delta)
		{
			if (!base.GetVisible() || this.ProgressAnimSpeed == 0f)
			{
				this.IsPlaying = false;
				return;
			}
			this.IsPlaying = true;
			float num = delta * this.ProgressAnimSpeed;
			this.CurrentExpProgress += num;
			float num2 = 0f;
			if (this.CurrentLevel == this.TargetLevel)
			{
				num2 = this.TargetExpProgress;
				if (this.IsAddProgress)
				{
					this.CurrentExpProgress = Math.Min(this.TargetExpProgress, this.CurrentExpProgress);
				}
				else
				{
					this.CurrentExpProgress = Math.Max(this.TargetExpProgress, this.CurrentExpProgress);
				}
				if (this.CurrentExpProgress == this.TargetExpProgress)
				{
					num2 = 0f;
					this.ProgressAnimSpeed = 0f;
					this.DelayHideExpText();
				}
			}
			else
			{
				if (this.IsAddProgress)
				{
					num2 = 1f;
				}
				if (this.IsAddProgress && this.CurrentExpProgress > 1f)
				{
					int num3 = (int)Math.Floor((double)this.CurrentExpProgress);
					this.CurrentLevel = Math.Min(this.MaxLevel, Math.Min(this.TargetLevel, this.CurrentLevel + num3));
					UUIArtText levelText = this.LevelText;
					if (levelText != null)
					{
						levelText.SetText(this.CurrentLevel.ToString());
					}
					this.PlayLevelUpAnim();
					if (this.CurrentLevel == this.TargetLevel)
					{
						if (this.CurrentLevel == this.MaxLevel)
						{
							this.CurrentExpProgress = 1f;
							this.RefreshLevelMaxItem();
						}
						else
						{
							this.CurrentExpProgress = Math.Min(this.TargetExpProgress, this.CurrentExpProgress - 1f);
						}
					}
					else
					{
						this.CurrentExpProgress -= (float)num3;
					}
				}
				else if (!this.IsAddProgress && this.CurrentExpProgress < 0f)
				{
					int num4 = (int)Math.Abs(Math.Floor((double)this.CurrentExpProgress));
					this.CurrentLevel = Math.Min(this.MaxLevel, Math.Max(this.TargetLevel, this.CurrentLevel - num4));
					UUIArtText levelText2 = this.LevelText;
					if (levelText2 != null)
					{
						levelText2.SetText(this.CurrentLevel.ToString());
					}
					if (this.CurrentLevel == this.TargetLevel)
					{
						this.CurrentExpProgress = Math.Max(this.TargetExpProgress, this.CurrentExpProgress + 1f);
					}
					else
					{
						this.CurrentExpProgress += (float)num4;
					}
				}
				else if (!this.IsAddProgress && this.CurrentLevel == this.MaxLevel)
				{
					this.CurrentLevel = Math.Max(this.TargetLevel, this.CurrentLevel - 1);
					UUIArtText levelText3 = this.LevelText;
					if (levelText3 != null)
					{
						levelText3.SetText(this.CurrentLevel.ToString());
					}
					this.RefreshLevelMaxItem();
				}
			}
			float fillAmount = MathUtils.Instance.RangeClamp(this.CurrentExpProgress, 0f, 1f, 0f, 0.3f);
			UUISprite addExpBar = this.AddExpBar;
			if (addExpBar != null)
			{
				addExpBar.SetFillAmount(fillAmount);
			}
			if (num2 > 0f && this.IsAddProgress)
			{
				float fillAmount2 = MathUtils.Instance.RangeClamp(num2, 0f, 1f, 0f, 0.3f);
				UUISprite changeExpBar = this.ChangeExpBar;
				if (changeExpBar != null)
				{
					changeExpBar.SetFillAmount(fillAmount2);
				}
				UUISprite changeExpBar2 = this.ChangeExpBar;
				if (changeExpBar2 != null)
				{
					changeExpBar2.SetUIActive(true);
				}
			}
			else
			{
				UUISprite changeExpBar3 = this.ChangeExpBar;
				if (changeExpBar3 != null)
				{
					changeExpBar3.SetUIActive(false);
				}
			}
			int value = (this.CurrentLevel == this.MaxLevel) ? (this.CurrentLevel - 1) : this.CurrentLevel;
			int targetLevelUpExp = FlagChallengeModel.Instance.GetTargetLevelUpExp(FlagChallengeBattleModel.Instance.ActivityId, new int?(value));
			UUIText currentExpText = this.CurrentExpText;
			if (currentExpText == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
			defaultInterpolatedStringHandler.AppendFormatted<double>(Math.Floor((double)((float)targetLevelUpExp * this.CurrentExpProgress)));
			defaultInterpolatedStringHandler.AppendLiteral(" / ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(targetLevelUpExp);
			currentExpText.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x06030985 RID: 199045 RVA: 0x00D8B514 File Offset: 0x00D89714
		private void RefreshFlagChallengeInfo()
		{
			int activityId = FlagChallengeBattleModel.Instance.ActivityId;
			int calculatedLevel = FlagChallengeModel.Instance.GetCalculatedLevel(activityId);
			int calculatedLevelExp = FlagChallengeModel.Instance.GetCalculatedLevelExp(activityId);
			float targetLevelExpProgress = FlagChallengeModel.Instance.GetTargetLevelExpProgress(activityId, new int?(calculatedLevel), new int?(calculatedLevelExp));
			this.CurrentLevel = calculatedLevel;
			this.TargetLevel = calculatedLevel;
			UUIArtText levelText = this.LevelText;
			if (levelText != null)
			{
				levelText.SetText(calculatedLevel.ToString());
			}
			this.CurrentExpProgress = targetLevelExpProgress;
			float fillAmount = MathUtils.Instance.RangeClamp(targetLevelExpProgress, 0f, 1f, 0f, 0.3f);
			UUISprite addExpBar = this.AddExpBar;
			if (addExpBar != null)
			{
				addExpBar.SetFillAmount(fillAmount);
			}
			UUISprite changeExpBar = this.ChangeExpBar;
			if (changeExpBar != null)
			{
				changeExpBar.SetUIActive(false);
			}
			this.MaxLevel = FlagChallengeModel.Instance.GetMaxLevel(activityId);
			this.RefreshLevelMaxItem();
		}

		// Token: 0x06030986 RID: 199046 RVA: 0x00D8B5E8 File Offset: 0x00D897E8
		private void OnFlagChallengeExpChanged(int oldExp, int newExp, int oldLevel, int newLevel)
		{
			if (!base.GetVisible())
			{
				return;
			}
			if (newLevel < oldLevel || newExp < oldExp)
			{
				this.IsPendingChangeInfo = true;
				return;
			}
			int num = this.IsPlaying ? this.CacheOldLevel : oldLevel;
			int num2 = this.IsPlaying ? this.CacheOldExp : oldExp;
			int num3 = newLevel - num;
			if (num3 != 0)
			{
				if (newLevel == this.MaxLevel)
				{
					num3--;
				}
				else if (num == this.MaxLevel)
				{
					num3++;
				}
			}
			int activityId = FlagChallengeBattleModel.Instance.ActivityId;
			float targetLevelExpProgress = FlagChallengeModel.Instance.GetTargetLevelExpProgress(activityId, new int?(newLevel), new int?(newExp));
			float num4 = (float)num3 + targetLevelExpProgress - this.CurrentExpProgress;
			this.ProgressAnimSpeed = num4 / 1000f;
			this.TargetLevel = newLevel;
			this.TargetExpProgress = targetLevelExpProgress;
			this.IsAddProgress = (this.ProgressAnimSpeed >= 0f);
			this.IsLevelUp = (newLevel > num);
			if (!this.IsPlaying)
			{
				this.CurrentLevel = oldLevel;
				int targetLevelUpExp = FlagChallengeModel.Instance.GetTargetLevelUpExp(activityId, new int?(oldLevel));
				UUIText currentExpText = this.CurrentExpText;
				if (currentExpText != null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
					defaultInterpolatedStringHandler.AppendFormatted<int>(oldExp);
					defaultInterpolatedStringHandler.AppendLiteral(" / ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(targetLevelUpExp);
					currentExpText.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
				}
				this.CacheOldLevel = oldLevel;
				this.CacheOldExp = oldExp;
			}
			int value = newExp - num2;
			LguiUtil.Instance.SetLocalTextNew(this.AddExpText, "PrefabTextItem_147616326_Text", new <>z__ReadOnlySingleElementList<object>(Math.Abs(value)));
			UUIItem expValuePanel = this.ExpValuePanel;
			if (expValuePanel != null)
			{
				expValuePanel.SetUIActive(this.ProgressAnimSpeed != 0f);
			}
			FlagChallengeAnimItem flagChallengeAnimItem = this.FlagChallengeAnimItem;
			if (flagChallengeAnimItem == null)
			{
				return;
			}
			flagChallengeAnimItem.SetUiActive(false);
		}

		// Token: 0x06030987 RID: 199047 RVA: 0x00D8B798 File Offset: 0x00D89998
		private void OnBattleStateChanged(bool isInBattleState)
		{
			if (!this.IsShowFlagChallengeUi)
			{
				return;
			}
			UUITexture levelMaxLightTexture = this.LevelMaxLightTexture;
			if (levelMaxLightTexture != null)
			{
				levelMaxLightTexture.SetUIActive(!isInBattleState);
			}
			UUISprite addExpBar = this.AddExpBar;
			if (addExpBar != null)
			{
				FColor? fcolor = new FColor?(this.AddExpBar.changeColor);
				addExpBar.SetChangeColor(isInBattleState, fcolor);
			}
			UUIArtText levelText = this.LevelText;
			if (levelText != null)
			{
				FColor? fcolor = new FColor?(this.LevelText.changeColor);
				levelText.SetChangeColor(isInBattleState, fcolor);
			}
			UUIArtText levelText2 = this.LevelText;
			if (levelText2 != null)
			{
				levelText2.SetUIActive(!isInBattleState);
			}
			UUITexture levelMaxBgTexture = this.LevelMaxBgTexture;
			if (levelMaxBgTexture != null)
			{
				FColor? fcolor = new FColor?(this.LevelMaxBgTexture.changeColor);
				levelMaxBgTexture.SetChangeColor(isInBattleState, fcolor);
			}
			UUITexture levelMaxText = this.LevelMaxText;
			if (levelMaxText != null)
			{
				FColor? fcolor = new FColor?(this.LevelMaxText.changeColor);
				levelMaxText.SetChangeColor(isInBattleState, fcolor);
			}
			UUISprite levelBgSprite = this.LevelBgSprite;
			if (levelBgSprite != null)
			{
				FColor? fcolor = new FColor?(this.LevelBgSprite.changeColor);
				levelBgSprite.SetChangeColor(isInBattleState, fcolor);
			}
			UUIItem disableItem = this.DisableItem;
			if (disableItem == null)
			{
				return;
			}
			disableItem.SetUIActive(isInBattleState);
		}

		// Token: 0x06030988 RID: 199048 RVA: 0x00D8B8A2 File Offset: 0x00D89AA2
		private void OnRefreshPendingChangeInfo()
		{
			if (this.IsPendingChangeInfo)
			{
				this.RefreshFlagChallengeInfo();
				this.IsPendingChangeInfo = false;
			}
		}

		// Token: 0x06030989 RID: 199049 RVA: 0x00D8B8BC File Offset: 0x00D89ABC
		private void DelayHideExpText()
		{
			if (this.ExpTextTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.ExpTextTimer);
			}
			this.ExpTextTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				if (this.IsLevelUp)
				{
					FlagChallengeAnimItem flagChallengeAnimItem = this.FlagChallengeAnimItem;
					if (flagChallengeAnimItem != null)
					{
						flagChallengeAnimItem.PlayLevelUpAnim();
					}
					FlagChallengeAnimItem flagChallengeAnimItem2 = this.FlagChallengeAnimItem;
					if (flagChallengeAnimItem2 != null)
					{
						flagChallengeAnimItem2.SetUiActive(true);
					}
				}
				UUIItem expValuePanel = this.ExpValuePanel;
				if (expValuePanel != null)
				{
					expValuePanel.SetUIActive(false);
				}
				this.ExpTextTimer = null;
			}, 2000f, null, null, true, 1f);
		}

		// Token: 0x0603098A RID: 199050 RVA: 0x00D8B90B File Offset: 0x00D89B0B
		private void RefreshLevelMaxItem()
		{
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(this.CurrentLevel == this.MaxLevel);
		}

		// Token: 0x0603098B RID: 199051 RVA: 0x00D8B92C File Offset: 0x00D89B2C
		[NullableContext(1)]
		public UUIItem GetLevelBgTextureItem()
		{
			return base.GetTexture(11);
		}

		// Token: 0x04019B59 RID: 105305
		private const float UI_BAR_MIN_PERCENT = 0f;

		// Token: 0x04019B5A RID: 105306
		private const float UI_BAR_MAX_PERCENT = 0.3f;

		// Token: 0x04019B5B RID: 105307
		private const float PROGRESS_ANIM_DURATION = 1000f;

		// Token: 0x04019B5C RID: 105308
		private const float EXP_TEXT_STAY_DURATION = 2000f;

		// Token: 0x04019B5D RID: 105309
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat TickStatsObject = Stat.Create("[BattleView]FlagChallengeExpView", "", "");

		// Token: 0x04019B5E RID: 105310
		private UUISprite AddExpBar;

		// Token: 0x04019B5F RID: 105311
		private UUISprite ChangeExpBar;

		// Token: 0x04019B60 RID: 105312
		private UUIArtText LevelText;

		// Token: 0x04019B61 RID: 105313
		private UUIItem ExpValuePanel;

		// Token: 0x04019B62 RID: 105314
		private UUIText AddExpText;

		// Token: 0x04019B63 RID: 105315
		private UUIText CurrentExpText;

		// Token: 0x04019B64 RID: 105316
		private UUITexture LevelMaxLightTexture;

		// Token: 0x04019B65 RID: 105317
		private UUITexture LevelMaxBgTexture;

		// Token: 0x04019B66 RID: 105318
		private UUITexture LevelMaxText;

		// Token: 0x04019B67 RID: 105319
		private UUISprite LevelBgSprite;

		// Token: 0x04019B68 RID: 105320
		private UUIItem DisableItem;

		// Token: 0x04019B69 RID: 105321
		private FlagChallengeAnimItem FlagChallengeAnimItem;

		// Token: 0x04019B6A RID: 105322
		private int CacheOldExp;

		// Token: 0x04019B6B RID: 105323
		private int CacheOldLevel;

		// Token: 0x04019B6C RID: 105324
		private bool IsPlaying;

		// Token: 0x04019B6D RID: 105325
		private int CurrentLevel;

		// Token: 0x04019B6E RID: 105326
		private float CurrentExpProgress;

		// Token: 0x04019B6F RID: 105327
		private int TargetLevel;

		// Token: 0x04019B70 RID: 105328
		private float TargetExpProgress;

		// Token: 0x04019B71 RID: 105329
		private float ProgressAnimSpeed;

		// Token: 0x04019B72 RID: 105330
		private bool IsAddProgress = true;

		// Token: 0x04019B73 RID: 105331
		private bool IsLevelUp;

		// Token: 0x04019B74 RID: 105332
		private int MaxLevel;

		// Token: 0x04019B75 RID: 105333
		private bool IsPendingChangeInfo;

		// Token: 0x04019B76 RID: 105334
		private bool IsShowFlagChallengeUi;

		// Token: 0x04019B77 RID: 105335
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04019B78 RID: 105336
		private TimerHandle ExpTextTimer;

		// Token: 0x0200A82B RID: 43051
		[NullableContext(0)]
		private enum EVisibleReason
		{
			// Token: 0x04033F22 RID: 212770
			Default = 1
		}

		// Token: 0x0200A82C RID: 43052
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x04033F24 RID: 212772
			AddExpBar,
			// Token: 0x04033F25 RID: 212773
			ChangeExpBar,
			// Token: 0x04033F26 RID: 212774
			LevelText,
			// Token: 0x04033F27 RID: 212775
			ExpValuePanel,
			// Token: 0x04033F28 RID: 212776
			AddExpText,
			// Token: 0x04033F29 RID: 212777
			CurrentExpText,
			// Token: 0x04033F2A RID: 212778
			MoraleAnimItem,
			// Token: 0x04033F2B RID: 212779
			LevelMaxItem,
			// Token: 0x04033F2C RID: 212780
			LevelMaxLightTexture,
			// Token: 0x04033F2D RID: 212781
			LevelMaxBgTexture,
			// Token: 0x04033F2E RID: 212782
			LevelMaxText,
			// Token: 0x04033F2F RID: 212783
			LevelBgTexture,
			// Token: 0x04033F30 RID: 212784
			LevelBgSprite,
			// Token: 0x04033F31 RID: 212785
			DisableItem
		}
	}
}
