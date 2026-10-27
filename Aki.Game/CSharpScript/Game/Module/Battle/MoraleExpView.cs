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
	// Token: 0x02005C4F RID: 23631
	[NullableContext(2)]
	[Nullable(0)]
	public class MoraleExpView : BattleVisibleChildView
	{
		// Token: 0x0603BB97 RID: 244631 RVA: 0x00E432FC File Offset: 0x00E414FC
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

		// Token: 0x0603BB98 RID: 244632 RVA: 0x00E434D8 File Offset: 0x00E416D8
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleExpView.<OnBeforeStartAsync>d__28 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleExpView.<OnBeforeStartAsync>d__28>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603BB99 RID: 244633 RVA: 0x00E4351C File Offset: 0x00E4171C
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

		// Token: 0x0603BB9A RID: 244634 RVA: 0x00E4361D File Offset: 0x00E4181D
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			base.InitChildType(EBattleUiChild.MiniMap);
			base.SetVisible(1, false);
			this.AddEvents();
		}

		// Token: 0x0603BB9B RID: 244635 RVA: 0x00E4363B File Offset: 0x00E4183B
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

		// Token: 0x0603BB9C RID: 244636 RVA: 0x00E43674 File Offset: 0x00E41874
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnMoraleExpChanged, new Action<int, int, int, int>(this.OnMoraleExpChanged));
			EventSystem.Instance.Add(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
			EventSystem.Instance.Add(EEventName.OnMoralePromptShow, new Action(this.OnMoralePromptShow));
			EventSystem.Instance.Add(EEventName.OnMoralePlayIndomitableLevelAnim, new Action(this.OnMoralePlayIndomitableLevelAnim));
			EventSystem.Instance.Add(EEventName.LoadingViewOnAfterShow, new Action(this.OnRefreshPendingChangeInfo));
			EventSystem.Instance.Add(EEventName.OnMoraleBattleFail, new Action(this.OnMoraleBattleFail));
		}

		// Token: 0x0603BB9D RID: 244637 RVA: 0x00E4372C File Offset: 0x00E4192C
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnMoraleExpChanged, new Action<int, int, int, int>(this.OnMoraleExpChanged));
			EventSystem.Instance.Remove(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
			EventSystem.Instance.Remove(EEventName.OnMoralePromptShow, new Action(this.OnMoralePromptShow));
			EventSystem.Instance.Remove(EEventName.OnMoralePlayIndomitableLevelAnim, new Action(this.OnMoralePlayIndomitableLevelAnim));
			EventSystem.Instance.Remove(EEventName.LoadingViewOnAfterShow, new Action(this.OnRefreshPendingChangeInfo));
			EventSystem.Instance.Remove(EEventName.OnMoraleBattleFail, new Action(this.OnMoraleBattleFail));
		}

		// Token: 0x0603BB9E RID: 244638 RVA: 0x00E437E1 File Offset: 0x00E419E1
		protected override void OnShowBattleChildView()
		{
			this.RefreshMoraleInfo();
		}

		// Token: 0x0603BB9F RID: 244639 RVA: 0x00E437E9 File Offset: 0x00E419E9
		[NullableContext(1)]
		private void OnSequenceEnd(string sequenceName)
		{
			if (sequenceName == "Close" && !MoraleBattleModel.Instance.IsMoraleActive())
			{
				base.SetVisible(1, false);
			}
		}

		// Token: 0x0603BBA0 RID: 244640 RVA: 0x00E4380C File Offset: 0x00E41A0C
		public void StartShow()
		{
			this.IsShowMoraleUi = true;
			this.RefreshMoraleInfo();
			base.SetVisible(1, true);
			this.PlayStartShowAnim();
			this.OnBattleStateChanged(FormationDataController.Instance.GlobalIsInFight);
		}

		// Token: 0x0603BBA1 RID: 244641 RVA: 0x00E43839 File Offset: 0x00E41A39
		public void EndShow()
		{
			this.IsShowMoraleUi = false;
			this.PlayEndShowAnim();
		}

		// Token: 0x0603BBA2 RID: 244642 RVA: 0x00E43848 File Offset: 0x00E41A48
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

		// Token: 0x0603BBA3 RID: 244643 RVA: 0x00E438B0 File Offset: 0x00E41AB0
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

		// Token: 0x0603BBA4 RID: 244644 RVA: 0x00E43918 File Offset: 0x00E41B18
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

		// Token: 0x0603BBA5 RID: 244645 RVA: 0x00E43978 File Offset: 0x00E41B78
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

		// Token: 0x0603BBA6 RID: 244646 RVA: 0x00E43D3C File Offset: 0x00E41F3C
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

		// Token: 0x0603BBA7 RID: 244647 RVA: 0x00E43E08 File Offset: 0x00E42008
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

		// Token: 0x0603BBA8 RID: 244648 RVA: 0x00E43F70 File Offset: 0x00E42170
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

		// Token: 0x0603BBA9 RID: 244649 RVA: 0x00E44089 File Offset: 0x00E42289
		private void OnMoralePromptShow()
		{
			this.PlayStartShowAnim();
		}

		// Token: 0x0603BBAA RID: 244650 RVA: 0x00E44091 File Offset: 0x00E42291
		private void OnRefreshPendingChangeInfo()
		{
			if (this.IsPendingChangeInfo)
			{
				this.RefreshMoraleInfo();
				this.IsPendingChangeInfo = false;
			}
		}

		// Token: 0x0603BBAB RID: 244651 RVA: 0x00E440A8 File Offset: 0x00E422A8
		private void OnMoraleBattleFail()
		{
			this.IsPendingChangeInfo = true;
		}

		// Token: 0x0603BBAC RID: 244652 RVA: 0x00E440B4 File Offset: 0x00E422B4
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

		// Token: 0x0603BBAD RID: 244653 RVA: 0x00E440F4 File Offset: 0x00E422F4
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

		// Token: 0x0603BBAE RID: 244654 RVA: 0x00E44143 File Offset: 0x00E42343
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

		// Token: 0x0401F181 RID: 127361
		private const float UI_BAR_MIN_PERCENT = 0f;

		// Token: 0x0401F182 RID: 127362
		private const float UI_BAR_MAX_PERCENT = 0.3f;

		// Token: 0x0401F183 RID: 127363
		private const float PROGRESS_ANIM_DURATION = 1000f;

		// Token: 0x0401F184 RID: 127364
		private const float EXP_TEXT_STAY_DURATION = 2000f;

		// Token: 0x0401F185 RID: 127365
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat TickStatsObject = Stat.Create("[BattleView]MoraleExpView", "", "");

		// Token: 0x0401F186 RID: 127366
		private UUISprite AddExpBar;

		// Token: 0x0401F187 RID: 127367
		private UUISprite ChangeExpBar;

		// Token: 0x0401F188 RID: 127368
		private UUIArtText LevelText;

		// Token: 0x0401F189 RID: 127369
		private UUIItem ExpValuePanel;

		// Token: 0x0401F18A RID: 127370
		private UUIText AddExpText;

		// Token: 0x0401F18B RID: 127371
		private UUIText CurrentExpText;

		// Token: 0x0401F18C RID: 127372
		private MoraleAnimItem MoraleAnimItem;

		// Token: 0x0401F18D RID: 127373
		private int CurrentLevel;

		// Token: 0x0401F18E RID: 127374
		private float CurrentExpProgress;

		// Token: 0x0401F18F RID: 127375
		private int TargetLevel;

		// Token: 0x0401F190 RID: 127376
		private float TargetExpProgress;

		// Token: 0x0401F191 RID: 127377
		private float ProgressAnimSpeed;

		// Token: 0x0401F192 RID: 127378
		private bool IsAddProgress = true;

		// Token: 0x0401F193 RID: 127379
		private bool IsLevelUp;

		// Token: 0x0401F194 RID: 127380
		private int MaxLevel;

		// Token: 0x0401F195 RID: 127381
		private bool IsPendingChangeInfo;

		// Token: 0x0401F196 RID: 127382
		private bool IsNeedLevelUpAnim = true;

		// Token: 0x0401F197 RID: 127383
		private bool IsShowMoraleUi;

		// Token: 0x0401F198 RID: 127384
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401F199 RID: 127385
		private TimerHandle ExpTextTimer;

		// Token: 0x0200BE5D RID: 48733
		[NullableContext(0)]
		private enum EVisibleReason
		{
			// Token: 0x04039685 RID: 235141
			Default = 1
		}

		// Token: 0x0200BE5E RID: 48734
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04039687 RID: 235143
			AddExpBar,
			// Token: 0x04039688 RID: 235144
			ChangeExpBar,
			// Token: 0x04039689 RID: 235145
			LevelText,
			// Token: 0x0403968A RID: 235146
			ExpValuePanel,
			// Token: 0x0403968B RID: 235147
			AddExpText,
			// Token: 0x0403968C RID: 235148
			CurrentExpText,
			// Token: 0x0403968D RID: 235149
			MoraleAnimItem,
			// Token: 0x0403968E RID: 235150
			LevelMaxItem,
			// Token: 0x0403968F RID: 235151
			LevelMaxLightTexture,
			// Token: 0x04039690 RID: 235152
			LevelMaxBgTexture,
			// Token: 0x04039691 RID: 235153
			LevelMaxText,
			// Token: 0x04039692 RID: 235154
			LevelBgTexture,
			// Token: 0x04039693 RID: 235155
			LevelBgSprite
		}
	}
}
