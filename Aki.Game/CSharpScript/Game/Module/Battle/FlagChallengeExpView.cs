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
	// Token: 0x02005C33 RID: 23603
	[NullableContext(2)]
	[Nullable(0)]
	public class FlagChallengeExpView : BattleVisibleChildView
	{
		// Token: 0x0603BA2B RID: 244267 RVA: 0x00E3A774 File Offset: 0x00E38974
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

		// Token: 0x0603BA2C RID: 244268 RVA: 0x00E3A970 File Offset: 0x00E38B70
		protected override UniTask OnBeforeStartAsync()
		{
			FlagChallengeExpView.<OnBeforeStartAsync>d__35 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FlagChallengeExpView.<OnBeforeStartAsync>d__35>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603BA2D RID: 244269 RVA: 0x00E3A9B4 File Offset: 0x00E38BB4
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

		// Token: 0x0603BA2E RID: 244270 RVA: 0x00E3AAFA File Offset: 0x00E38CFA
		protected override void OnBeforeDestroy()
		{
			if (this.ExpTextTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.ExpTextTimer);
				this.ExpTextTimer = null;
			}
		}

		// Token: 0x0603BA2F RID: 244271 RVA: 0x00E3AB1C File Offset: 0x00E38D1C
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			base.InitChildType(EBattleUiChild.MiniMap);
			base.SetVisible(1, false);
			this.AddEvents();
		}

		// Token: 0x0603BA30 RID: 244272 RVA: 0x00E3AB3A File Offset: 0x00E38D3A
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

		// Token: 0x0603BA31 RID: 244273 RVA: 0x00E3AB74 File Offset: 0x00E38D74
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnFlagChallengeExpChanged, new Action<int, int, int, int>(this.OnFlagChallengeExpChanged));
			EventSystem.Instance.Add(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
			EventSystem.Instance.Add(EEventName.LoadingViewOnAfterShow, new Action(this.OnRefreshPendingChangeInfo));
		}

		// Token: 0x0603BA32 RID: 244274 RVA: 0x00E3ABD8 File Offset: 0x00E38DD8
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnFlagChallengeExpChanged, new Action<int, int, int, int>(this.OnFlagChallengeExpChanged));
			EventSystem.Instance.Remove(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
			EventSystem.Instance.Remove(EEventName.LoadingViewOnAfterShow, new Action(this.OnRefreshPendingChangeInfo));
		}

		// Token: 0x0603BA33 RID: 244275 RVA: 0x00E3AC39 File Offset: 0x00E38E39
		[NullableContext(1)]
		private void OnSequenceEnd(string sequenceName)
		{
			if (sequenceName == "Close" && !FlagChallengeBattleModel.Instance.IsInFlagChallengeDungeon)
			{
				base.SetVisible(1, false);
			}
		}

		// Token: 0x0603BA34 RID: 244276 RVA: 0x00E3AC5C File Offset: 0x00E38E5C
		public void StartShow()
		{
			this.IsShowFlagChallengeUi = true;
			this.RefreshFlagChallengeInfo();
			base.SetVisible(1, true);
			this.PlayStartShowAnim();
			this.OnBattleStateChanged(FormationDataController.Instance.GlobalIsInFight);
		}

		// Token: 0x0603BA35 RID: 244277 RVA: 0x00E3AC89 File Offset: 0x00E38E89
		public void EndShow()
		{
			this.IsShowFlagChallengeUi = false;
			this.PlayEndShowAnim();
		}

		// Token: 0x0603BA36 RID: 244278 RVA: 0x00E3AC98 File Offset: 0x00E38E98
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

		// Token: 0x0603BA37 RID: 244279 RVA: 0x00E3AD00 File Offset: 0x00E38F00
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

		// Token: 0x0603BA38 RID: 244280 RVA: 0x00E3AD68 File Offset: 0x00E38F68
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

		// Token: 0x0603BA39 RID: 244281 RVA: 0x00E3ADC8 File Offset: 0x00E38FC8
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

		// Token: 0x0603BA3A RID: 244282 RVA: 0x00E3B1A4 File Offset: 0x00E393A4
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

		// Token: 0x0603BA3B RID: 244283 RVA: 0x00E3B278 File Offset: 0x00E39478
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

		// Token: 0x0603BA3C RID: 244284 RVA: 0x00E3B428 File Offset: 0x00E39628
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

		// Token: 0x0603BA3D RID: 244285 RVA: 0x00E3B532 File Offset: 0x00E39732
		private void OnRefreshPendingChangeInfo()
		{
			if (this.IsPendingChangeInfo)
			{
				this.RefreshFlagChallengeInfo();
				this.IsPendingChangeInfo = false;
			}
		}

		// Token: 0x0603BA3E RID: 244286 RVA: 0x00E3B54C File Offset: 0x00E3974C
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

		// Token: 0x0603BA3F RID: 244287 RVA: 0x00E3B59B File Offset: 0x00E3979B
		private void RefreshLevelMaxItem()
		{
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(this.CurrentLevel == this.MaxLevel);
		}

		// Token: 0x0603BA40 RID: 244288 RVA: 0x00E3B5BC File Offset: 0x00E397BC
		[NullableContext(1)]
		public UUIItem GetLevelBgTextureItem()
		{
			return base.GetTexture(11);
		}

		// Token: 0x0401F0A8 RID: 127144
		private const float UI_BAR_MIN_PERCENT = 0f;

		// Token: 0x0401F0A9 RID: 127145
		private const float UI_BAR_MAX_PERCENT = 0.3f;

		// Token: 0x0401F0AA RID: 127146
		private const float PROGRESS_ANIM_DURATION = 1000f;

		// Token: 0x0401F0AB RID: 127147
		private const float EXP_TEXT_STAY_DURATION = 2000f;

		// Token: 0x0401F0AC RID: 127148
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat TickStatsObject = Stat.Create("[BattleView]FlagChallengeExpView", "", "");

		// Token: 0x0401F0AD RID: 127149
		private UUISprite AddExpBar;

		// Token: 0x0401F0AE RID: 127150
		private UUISprite ChangeExpBar;

		// Token: 0x0401F0AF RID: 127151
		private UUIArtText LevelText;

		// Token: 0x0401F0B0 RID: 127152
		private UUIItem ExpValuePanel;

		// Token: 0x0401F0B1 RID: 127153
		private UUIText AddExpText;

		// Token: 0x0401F0B2 RID: 127154
		private UUIText CurrentExpText;

		// Token: 0x0401F0B3 RID: 127155
		private UUITexture LevelMaxLightTexture;

		// Token: 0x0401F0B4 RID: 127156
		private UUITexture LevelMaxBgTexture;

		// Token: 0x0401F0B5 RID: 127157
		private UUITexture LevelMaxText;

		// Token: 0x0401F0B6 RID: 127158
		private UUISprite LevelBgSprite;

		// Token: 0x0401F0B7 RID: 127159
		private UUIItem DisableItem;

		// Token: 0x0401F0B8 RID: 127160
		private FlagChallengeAnimItem FlagChallengeAnimItem;

		// Token: 0x0401F0B9 RID: 127161
		private int CacheOldExp;

		// Token: 0x0401F0BA RID: 127162
		private int CacheOldLevel;

		// Token: 0x0401F0BB RID: 127163
		private bool IsPlaying;

		// Token: 0x0401F0BC RID: 127164
		private int CurrentLevel;

		// Token: 0x0401F0BD RID: 127165
		private float CurrentExpProgress;

		// Token: 0x0401F0BE RID: 127166
		private int TargetLevel;

		// Token: 0x0401F0BF RID: 127167
		private float TargetExpProgress;

		// Token: 0x0401F0C0 RID: 127168
		private float ProgressAnimSpeed;

		// Token: 0x0401F0C1 RID: 127169
		private bool IsAddProgress = true;

		// Token: 0x0401F0C2 RID: 127170
		private bool IsLevelUp;

		// Token: 0x0401F0C3 RID: 127171
		private int MaxLevel;

		// Token: 0x0401F0C4 RID: 127172
		private bool IsPendingChangeInfo;

		// Token: 0x0401F0C5 RID: 127173
		private bool IsShowFlagChallengeUi;

		// Token: 0x0401F0C6 RID: 127174
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401F0C7 RID: 127175
		private TimerHandle ExpTextTimer;

		// Token: 0x0200BE23 RID: 48675
		[NullableContext(0)]
		private enum EVisibleReason
		{
			// Token: 0x0403955F RID: 234847
			Default = 1
		}

		// Token: 0x0200BE24 RID: 48676
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x04039561 RID: 234849
			AddExpBar,
			// Token: 0x04039562 RID: 234850
			ChangeExpBar,
			// Token: 0x04039563 RID: 234851
			LevelText,
			// Token: 0x04039564 RID: 234852
			ExpValuePanel,
			// Token: 0x04039565 RID: 234853
			AddExpText,
			// Token: 0x04039566 RID: 234854
			CurrentExpText,
			// Token: 0x04039567 RID: 234855
			MoraleAnimItem,
			// Token: 0x04039568 RID: 234856
			LevelMaxItem,
			// Token: 0x04039569 RID: 234857
			LevelMaxLightTexture,
			// Token: 0x0403956A RID: 234858
			LevelMaxBgTexture,
			// Token: 0x0403956B RID: 234859
			LevelMaxText,
			// Token: 0x0403956C RID: 234860
			LevelBgTexture,
			// Token: 0x0403956D RID: 234861
			LevelBgSprite,
			// Token: 0x0403956E RID: 234862
			DisableItem
		}
	}
}
