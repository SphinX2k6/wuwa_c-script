using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02004C2F RID: 19503
	[NullableContext(2)]
	[Nullable(0)]
	public class MoraleExpView : BattleVisibleChildView
	{
		// Token: 0x06030AE2 RID: 199394 RVA: 0x00D936C8 File Offset: 0x00D918C8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 13;
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
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06030AE3 RID: 199395 RVA: 0x00D938A4 File Offset: 0x00D91AA4
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleExpView.<OnBeforeStartAsync>d__28 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleExpView.<OnBeforeStartAsync>d__28>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030AE4 RID: 199396 RVA: 0x00D938E8 File Offset: 0x00D91AE8
		protected override void OnStart()
		{
			this.AddExpBar = base.GetSprite(0);
			this.ChangeExpBar = base.GetSprite(1);
			this.LevelText = base.GetArtText(2);
			this.ExpValuePanel = base.GetItem(3);
			this.AddExpText = base.GetText(4);
			this.CurrentExpText = base.GetText(5);
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
			MoraleAnimItem moraleAnimItem = this.MoraleAnimItem;
			if (moraleAnimItem != null)
			{
				moraleAnimItem.SetUiActive(false);
			}
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceEnd), false);
		}

		// Token: 0x06030AE5 RID: 199397 RVA: 0x00D939E9 File Offset: 0x00D91BE9
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			base.InitChildType(EBattleUiChild.MiniMap);
			base.SetVisible(1, false);
			this.AddEvents();
		}

		// Token: 0x06030AE6 RID: 199398 RVA: 0x00D93A07 File Offset: 0x00D91C07
		public override void Reset()
		{
			this.RemoveEvents();
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.IsPendingChangeInfo = false;
			MoraleAnimItem moraleAnimItem = this.MoraleAnimItem;
			if (moraleAnimItem != null)
			{
				moraleAnimItem.Clear();
			}
			base.Reset();
		}

		// Token: 0x06030AE7 RID: 199399 RVA: 0x00D93A40 File Offset: 0x00D91C40
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnMoraleExpChanged, new Action<int, int, int, int>(this.OnMoraleExpChanged));
			EventSystem.Instance.Add(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
			EventSystem.Instance.Add(EEventName.OnMoralePromptShow, new Action(this.OnMoralePromptShow));
			EventSystem.Instance.Add(EEventName.OnMoralePlayIndomitableLevelAnim, new Action(this.OnMoralePlayIndomitableLevelAnim));
			EventSystem.Instance.Add(EEventName.LoadingViewOnAfterShow, new Action(this.OnRefreshPendingChangeInfo));
			EventSystem.Instance.Add(EEventName.OnMoraleBattleFail, new Action(this.OnMoraleBattleFail));
		}

		// Token: 0x06030AE8 RID: 199400 RVA: 0x00D93AF8 File Offset: 0x00D91CF8
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnMoraleExpChanged, new Action<int, int, int, int>(this.OnMoraleExpChanged));
			EventSystem.Instance.Remove(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
			EventSystem.Instance.Remove(EEventName.OnMoralePromptShow, new Action(this.OnMoralePromptShow));
			EventSystem.Instance.Remove(EEventName.OnMoralePlayIndomitableLevelAnim, new Action(this.OnMoralePlayIndomitableLevelAnim));
			EventSystem.Instance.Remove(EEventName.LoadingViewOnAfterShow, new Action(this.OnRefreshPendingChangeInfo));
			EventSystem.Instance.Remove(EEventName.OnMoraleBattleFail, new Action(this.OnMoraleBattleFail));
		}

		// Token: 0x06030AE9 RID: 199401 RVA: 0x00D93BAD File Offset: 0x00D91DAD
		protected override void OnShowBattleChildView()
		{
			this.RefreshMoraleInfo();
		}

		// Token: 0x06030AEA RID: 199402 RVA: 0x00D93BB5 File Offset: 0x00D91DB5
		[NullableContext(1)]
		private void OnSequenceEnd(string sequenceName)
		{
			if (sequenceName == "Close" && !MoraleBattleModel.Instance.IsMoraleActive())
			{
				base.SetVisible(1, false);
			}
		}

		// Token: 0x06030AEB RID: 199403 RVA: 0x00D93BD8 File Offset: 0x00D91DD8
		public void StartShow()
		{
			this.IsShowMoraleUi = true;
			this.RefreshMoraleInfo();
			base.SetVisible(1, true);
			this.PlayStartShowAnim();
			this.OnBattleStateChanged(FormationDataController.Instance.GlobalIsInFight);
		}

		// Token: 0x06030AEC RID: 199404 RVA: 0x00D93C05 File Offset: 0x00D91E05
		public void EndShow()
		{
			this.IsShowMoraleUi = false;
			this.PlayEndShowAnim();
		}

		// Token: 0x06030AED RID: 199405 RVA: 0x00D93C14 File Offset: 0x00D91E14
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
			MoraleAnimItem moraleAnimItem = this.MoraleAnimItem;
			if (moraleAnimItem != null)
			{
				moraleAnimItem.PlayStartShowAnim();
			}
			MoraleAnimItem moraleAnimItem2 = this.MoraleAnimItem;
			if (moraleAnimItem2 == null)
			{
				return;
			}
			moraleAnimItem2.SetUiActive(true);
		}

		// Token: 0x06030AEE RID: 199406 RVA: 0x00D93C7C File Offset: 0x00D91E7C
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
			MoraleAnimItem moraleAnimItem = this.MoraleAnimItem;
			if (moraleAnimItem != null)
			{
				moraleAnimItem.PlayEndShowAnim();
			}
			MoraleAnimItem moraleAnimItem2 = this.MoraleAnimItem;
			if (moraleAnimItem2 == null)
			{
				return;
			}
			moraleAnimItem2.SetUiActive(true);
		}

		// Token: 0x06030AEF RID: 199407 RVA: 0x00D93CE4 File Offset: 0x00D91EE4
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

		// Token: 0x06030AF0 RID: 199408 RVA: 0x00D93D44 File Offset: 0x00D91F44
		public void Tick(float delta)
		{
			if (!base.GetVisible() || this.ProgressAnimSpeed == 0f)
			{
				return;
			}
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
			int moraleLevelUpExp = MoraleBattleModel.Instance.GetMoraleLevelUpExp(new int?(value));
			UUIText currentExpText = this.CurrentExpText;
			if (currentExpText == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
			defaultInterpolatedStringHandler.AppendFormatted<double>(Math.Floor((double)((float)moraleLevelUpExp * this.CurrentExpProgress)));
			defaultInterpolatedStringHandler.AppendLiteral(" / ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(moraleLevelUpExp);
			currentExpText.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x06030AF1 RID: 199409 RVA: 0x00D94108 File Offset: 0x00D92308
		private void RefreshMoraleInfo()
		{
			int num = MoraleBattleModel.Instance.GetMoraleLevel();
			float num2 = MoraleBattleModel.Instance.GetMoraleCurrentExpProgress();
			if (this.IsPendingChangeInfo && MoraleBattleModel.Instance.GetMoraleIndomitableLevel() > 1)
			{
				num = 1;
				num2 = 0f;
			}
			this.CurrentLevel = num;
			this.TargetLevel = num;
			UUIArtText levelText = this.LevelText;
			if (levelText != null)
			{
				levelText.SetText(num.ToString());
			}
			this.CurrentExpProgress = num2;
			float fillAmount = MathUtils.Instance.RangeClamp(num2, 0f, 1f, 0f, 0.3f);
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
			this.MaxLevel = MoraleBattleModel.Instance.GetMoraleMaxLevel();
			this.RefreshLevelMaxItem();
		}

		// Token: 0x06030AF2 RID: 199410 RVA: 0x00D941D4 File Offset: 0x00D923D4
		private void OnMoraleExpChanged(int oldExp, int newExp, int oldLevel, int newLevel)
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
			int num = newLevel - oldLevel;
			if (num != 0)
			{
				if (newLevel == this.MaxLevel)
				{
					num--;
				}
				else if (oldLevel == this.MaxLevel)
				{
					num++;
				}
			}
			float moraleCurrentExpProgress = MoraleBattleModel.Instance.GetMoraleCurrentExpProgress();
			float num2 = (float)num + moraleCurrentExpProgress - this.CurrentExpProgress;
			this.ProgressAnimSpeed = num2 / 1000f;
			this.CurrentLevel = oldLevel;
			this.TargetLevel = newLevel;
			this.TargetExpProgress = moraleCurrentExpProgress;
			this.IsAddProgress = (this.ProgressAnimSpeed >= 0f);
			this.IsLevelUp = (newLevel > oldLevel && this.IsNeedLevelUpAnim);
			int moraleLevelUpExp = MoraleBattleModel.Instance.GetMoraleLevelUpExp(new int?(oldLevel));
			UUIText currentExpText = this.CurrentExpText;
			if (currentExpText != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(oldExp);
				defaultInterpolatedStringHandler.AppendLiteral(" / ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(moraleLevelUpExp);
				currentExpText.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			int value = newExp - oldExp;
			LguiUtil.Instance.SetLocalTextNew(this.AddExpText, "PrefabTextItem_147616326_Text", new <>z__ReadOnlySingleElementList<object>(Math.Abs(value)));
			UUIItem expValuePanel = this.ExpValuePanel;
			if (expValuePanel != null)
			{
				expValuePanel.SetUIActive(this.IsNeedLevelUpAnim && this.ProgressAnimSpeed != 0f);
			}
			MoraleAnimItem moraleAnimItem = this.MoraleAnimItem;
			if (moraleAnimItem == null)
			{
				return;
			}
			moraleAnimItem.SetUiActive(false);
		}

		// Token: 0x06030AF3 RID: 199411 RVA: 0x00D9433C File Offset: 0x00D9253C
		private void OnBattleStateChanged(bool isInBattleState)
		{
			if (!this.IsShowMoraleUi)
			{
				return;
			}
			UUITexture texture = base.GetTexture(8);
			if (texture != null)
			{
				texture.SetUIActive(!isInBattleState);
			}
			UUISprite addExpBar = this.AddExpBar;
			FColor? fcolor;
			if (addExpBar != null)
			{
				fcolor = new FColor?(this.AddExpBar.changeColor);
				addExpBar.SetChangeColor(isInBattleState, fcolor);
			}
			UUIArtText levelText = this.LevelText;
			if (levelText != null)
			{
				fcolor = new FColor?(this.LevelText.changeColor);
				levelText.SetChangeColor(isInBattleState, fcolor);
			}
			UUITexture texture2 = base.GetTexture(9);
			if (texture2 != null)
			{
				fcolor = new FColor?(base.GetTexture(9).changeColor);
				texture2.SetChangeColor(isInBattleState, fcolor);
			}
			UUITexture texture3 = base.GetTexture(10);
			if (texture3 != null)
			{
				fcolor = new FColor?(base.GetTexture(10).changeColor);
				texture3.SetChangeColor(isInBattleState, fcolor);
			}
			UUITexture texture4 = base.GetTexture(11);
			if (texture4 != null)
			{
				fcolor = new FColor?(base.GetTexture(11).changeColor);
				texture4.SetChangeColor(isInBattleState, fcolor);
			}
			UUISprite sprite = base.GetSprite(12);
			if (sprite == null)
			{
				return;
			}
			fcolor = new FColor?(base.GetSprite(12).changeColor);
			sprite.SetChangeColor(isInBattleState, fcolor);
		}

		// Token: 0x06030AF4 RID: 199412 RVA: 0x00D94455 File Offset: 0x00D92655
		private void OnMoralePromptShow()
		{
			this.PlayStartShowAnim();
		}

		// Token: 0x06030AF5 RID: 199413 RVA: 0x00D9445D File Offset: 0x00D9265D
		private void OnRefreshPendingChangeInfo()
		{
			if (this.IsPendingChangeInfo)
			{
				this.RefreshMoraleInfo();
				this.IsPendingChangeInfo = false;
			}
		}

		// Token: 0x06030AF6 RID: 199414 RVA: 0x00D94474 File Offset: 0x00D92674
		private void OnMoraleBattleFail()
		{
			this.IsPendingChangeInfo = true;
		}

		// Token: 0x06030AF7 RID: 199415 RVA: 0x00D94480 File Offset: 0x00D92680
		private void OnMoralePlayIndomitableLevelAnim()
		{
			int moraleIndomitableLevel = MoraleBattleModel.Instance.GetMoraleIndomitableLevel();
			if (moraleIndomitableLevel > 1 && this.TargetLevel < moraleIndomitableLevel)
			{
				this.IsNeedLevelUpAnim = false;
				this.OnMoraleExpChanged(0, 0, 1, moraleIndomitableLevel);
				this.IsNeedLevelUpAnim = true;
			}
		}

		// Token: 0x06030AF8 RID: 199416 RVA: 0x00D944C0 File Offset: 0x00D926C0
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
					MoraleAnimItem moraleAnimItem = this.MoraleAnimItem;
					if (moraleAnimItem != null)
					{
						moraleAnimItem.PlayLevelUpAnim();
					}
					MoraleAnimItem moraleAnimItem2 = this.MoraleAnimItem;
					if (moraleAnimItem2 != null)
					{
						moraleAnimItem2.SetUiActive(true);
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

		// Token: 0x06030AF9 RID: 199417 RVA: 0x00D9450F File Offset: 0x00D9270F
		private void RefreshLevelMaxItem()
		{
			if (this.CurrentLevel == this.MaxLevel)
			{
				UUIItem item = base.GetItem(7);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(true);
				return;
			}
			else
			{
				UUIItem item2 = base.GetItem(7);
				if (item2 == null)
				{
					return;
				}
				item2.SetUIActive(false);
				return;
			}
		}

		// Token: 0x04019C32 RID: 105522
		private const float UI_BAR_MIN_PERCENT = 0f;

		// Token: 0x04019C33 RID: 105523
		private const float UI_BAR_MAX_PERCENT = 0.3f;

		// Token: 0x04019C34 RID: 105524
		private const float PROGRESS_ANIM_DURATION = 1000f;

		// Token: 0x04019C35 RID: 105525
		private const float EXP_TEXT_STAY_DURATION = 2000f;

		// Token: 0x04019C36 RID: 105526
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat TickStatsObject = Stat.Create("[BattleView]MoraleExpView", "", "");

		// Token: 0x04019C37 RID: 105527
		private UUISprite AddExpBar;

		// Token: 0x04019C38 RID: 105528
		private UUISprite ChangeExpBar;

		// Token: 0x04019C39 RID: 105529
		private UUIArtText LevelText;

		// Token: 0x04019C3A RID: 105530
		private UUIItem ExpValuePanel;

		// Token: 0x04019C3B RID: 105531
		private UUIText AddExpText;

		// Token: 0x04019C3C RID: 105532
		private UUIText CurrentExpText;

		// Token: 0x04019C3D RID: 105533
		private MoraleAnimItem MoraleAnimItem;

		// Token: 0x04019C3E RID: 105534
		private int CurrentLevel;

		// Token: 0x04019C3F RID: 105535
		private float CurrentExpProgress;

		// Token: 0x04019C40 RID: 105536
		private int TargetLevel;

		// Token: 0x04019C41 RID: 105537
		private float TargetExpProgress;

		// Token: 0x04019C42 RID: 105538
		private float ProgressAnimSpeed;

		// Token: 0x04019C43 RID: 105539
		private bool IsAddProgress = true;

		// Token: 0x04019C44 RID: 105540
		private bool IsLevelUp;

		// Token: 0x04019C45 RID: 105541
		private int MaxLevel;

		// Token: 0x04019C46 RID: 105542
		private bool IsPendingChangeInfo;

		// Token: 0x04019C47 RID: 105543
		private bool IsNeedLevelUpAnim = true;

		// Token: 0x04019C48 RID: 105544
		private bool IsShowMoraleUi;

		// Token: 0x04019C49 RID: 105545
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04019C4A RID: 105546
		private TimerHandle ExpTextTimer;

		// Token: 0x0200A863 RID: 43107
		[NullableContext(0)]
		private enum EVisibleReason
		{
			// Token: 0x04034046 RID: 213062
			Default = 1
		}

		// Token: 0x0200A864 RID: 43108
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034048 RID: 213064
			AddExpBar,
			// Token: 0x04034049 RID: 213065
			ChangeExpBar,
			// Token: 0x0403404A RID: 213066
			LevelText,
			// Token: 0x0403404B RID: 213067
			ExpValuePanel,
			// Token: 0x0403404C RID: 213068
			AddExpText,
			// Token: 0x0403404D RID: 213069
			CurrentExpText,
			// Token: 0x0403404E RID: 213070
			MoraleAnimItem,
			// Token: 0x0403404F RID: 213071
			LevelMaxItem,
			// Token: 0x04034050 RID: 213072
			LevelMaxLightTexture,
			// Token: 0x04034051 RID: 213073
			LevelMaxBgTexture,
			// Token: 0x04034052 RID: 213074
			LevelMaxText,
			// Token: 0x04034053 RID: 213075
			LevelBgTexture,
			// Token: 0x04034054 RID: 213076
			LevelBgSprite
		}
	}
}
