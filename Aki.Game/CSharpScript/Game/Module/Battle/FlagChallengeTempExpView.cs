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
	// Token: 0x02005C44 RID: 23620
	[NullableContext(2)]
	[Nullable(0)]
	public class FlagChallengeTempExpView : BattleVisibleChildView
	{
		// Token: 0x0603BAB2 RID: 244402 RVA: 0x00E3D948 File Offset: 0x00E3BB48
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603BAB3 RID: 244403 RVA: 0x00E3DA14 File Offset: 0x00E3BC14
		protected override UniTask OnCreateAsync()
		{
			FlagChallengeTempExpView.<OnCreateAsync>d__20 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<FlagChallengeTempExpView.<OnCreateAsync>d__20>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603BAB4 RID: 244404 RVA: 0x00E3DA58 File Offset: 0x00E3BC58
		protected override void OnStart()
		{
			base.InitChildType(EBattleUiChild.RoleState);
			this.AddEvents();
			this.MaxLevel = FlagChallengeBattleModel.Instance.GetTempFlagChallengeMaxLevel();
			this.ExpItemTweenInterval = Math.Max(20, FlagChallengeConfig.Instance.GetTempExpItemInterval());
			this.CrossLevelDiff = FlagChallengeConfig.Instance.GetTempExpCrossLevel();
			this.LevelText = base.GetArtText(0);
			this.ItemPanel = base.GetItem(2);
			this.LevelMaxSprite = base.GetSprite(1);
			UUISprite levelMaxSprite = this.LevelMaxSprite;
			if (levelMaxSprite != null)
			{
				levelMaxSprite.SetUIActive(false);
			}
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			this.LevelAnimItem = base.GetItem(4);
			UUIItem levelAnimItem = this.LevelAnimItem;
			if (levelAnimItem != null)
			{
				levelAnimItem.SetUIActive(false);
			}
			FRotator frotator = new FRotator(0f, 180f, 0f);
			for (int i = 0; i < this.ExpItems.Count; i++)
			{
				FlagChallengeTempExpItem flagChallengeTempExpItem = this.ExpItems[i];
				flagChallengeTempExpItem.SetIndex(i);
				if (i % 2 == 1)
				{
					flagChallengeTempExpItem.GetRootItem().SetUIRelativeRotation(frotator);
				}
				flagChallengeTempExpItem.GetRootItem().SetUIParent(this.ItemPanel, false);
			}
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceEndEvent), false);
		}

		// Token: 0x0603BAB5 RID: 244405 RVA: 0x00E3DBA4 File Offset: 0x00E3BDA4
		protected override void OnBeforeDestroy()
		{
			foreach (FlagChallengeTempExpItem flagChallengeTempExpItem in this.ExpItems)
			{
				flagChallengeTempExpItem.Clean();
			}
			this.ExpItems.Clear();
			base.OnBeforeDestroy();
		}

		// Token: 0x0603BAB6 RID: 244406 RVA: 0x00E3DC08 File Offset: 0x00E3BE08
		public override void Reset()
		{
			this.RemoveEvents();
			base.Reset();
		}

		// Token: 0x0603BAB7 RID: 244407 RVA: 0x00E3DC18 File Offset: 0x00E3BE18
		private UniTask AddExpItem()
		{
			FlagChallengeTempExpView.<AddExpItem>d__24 <AddExpItem>d__;
			<AddExpItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AddExpItem>d__.<>4__this = this;
			<AddExpItem>d__.<>1__state = -1;
			<AddExpItem>d__.<>t__builder.Start<FlagChallengeTempExpView.<AddExpItem>d__24>(ref <AddExpItem>d__);
			return <AddExpItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603BAB8 RID: 244408 RVA: 0x00E3DC5B File Offset: 0x00E3BE5B
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnFlagChallengeTempExpChanged, new Action<int, int, int, int>(this.OnFlagChallengeTempExpChanged));
		}

		// Token: 0x0603BAB9 RID: 244409 RVA: 0x00E3DC79 File Offset: 0x00E3BE79
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnFlagChallengeTempExpChanged, new Action<int, int, int, int>(this.OnFlagChallengeTempExpChanged));
		}

		// Token: 0x0603BABA RID: 244410 RVA: 0x00E3DC97 File Offset: 0x00E3BE97
		protected override void OnShowBattleChildView()
		{
			this.RefreshFlagChallengeInfo();
		}

		// Token: 0x0603BABB RID: 244411 RVA: 0x00E3DC9F File Offset: 0x00E3BE9F
		protected override void OnHideBattleChildView()
		{
			this.StopCurrentState();
			this.AnimState = FlagChallengeTempExpView.EAnimState.None;
		}

		// Token: 0x0603BABC RID: 244412 RVA: 0x00E3DCB0 File Offset: 0x00E3BEB0
		private void RefreshFlagChallengeInfo()
		{
			FlagChallengeBattleModel instance = FlagChallengeBattleModel.Instance;
			this.CurrentLevel = instance.GetTempLevel();
			this.TargetLevel = this.CurrentLevel;
			this.TargetExpProgress = instance.GetTempExpProgress();
			this.MaxLevel = instance.GetTempFlagChallengeMaxLevel();
			this.ResetAllItem(this.TargetExpProgress, null);
			this.RefreshTempLevelText(this.TargetLevel);
			bool uiactive = this.TargetLevel == this.MaxLevel;
			UUIItem levelAnimItem = this.LevelAnimItem;
			if (levelAnimItem != null)
			{
				levelAnimItem.SetUIActive(uiactive);
			}
			UUISprite levelMaxSprite = this.LevelMaxSprite;
			if (levelMaxSprite == null)
			{
				return;
			}
			levelMaxSprite.SetUIActive(uiactive);
		}

		// Token: 0x0603BABD RID: 244413 RVA: 0x00E3DD48 File Offset: 0x00E3BF48
		private void RefreshTempLevelText(int tempLevel)
		{
			int num = FlagChallengeBattleModel.Instance.GetCalculatedLevel() + tempLevel;
			UUIArtText levelText = this.LevelText;
			if (levelText == null)
			{
				return;
			}
			levelText.SetText(num.ToString());
		}

		// Token: 0x0603BABE RID: 244414 RVA: 0x00E3DD7C File Offset: 0x00E3BF7C
		private void OnFlagChallengeTempExpChanged(int oldExp, int newExp, int oldLevel, int newLevel)
		{
			if (!base.GetVisible())
			{
				return;
			}
			if (oldExp == newExp && oldLevel == newLevel)
			{
				return;
			}
			FlagChallengeBattleModel instance = FlagChallengeBattleModel.Instance;
			if (newLevel == oldLevel)
			{
				this.IsAddProgress = (newExp > oldExp);
			}
			else
			{
				this.IsAddProgress = (newLevel > oldLevel);
				this.MaxLevel = instance.GetTempFlagChallengeMaxLevel();
			}
			if (this.IsAddProgress)
			{
				bool flag = false;
				if (this.AnimState != FlagChallengeTempExpView.EAnimState.CrossLevel && newLevel - oldLevel >= this.CrossLevelDiff)
				{
					flag = true;
				}
				if (this.AnimState == FlagChallengeTempExpView.EAnimState.None && !flag)
				{
					ref ValueTuple<int, int> tempLevelExpRange = instance.GetTempLevelExpRange(oldLevel);
					int tempLevelUpExp = instance.GetTempLevelUpExp(new int?(oldLevel));
					int item = tempLevelExpRange.Item1;
					float progress = (float)(oldExp - item) / (float)tempLevelUpExp;
					this.TargetExpProgress = instance.GetTempExpProgress();
					this.CurrentLevel = oldLevel;
					this.TargetLevel = newLevel;
					this.RefreshTempLevelText(oldLevel);
					this.ResetAllItem(progress, null);
					this.PlayTweenByNextItem(true);
					return;
				}
				if (this.AnimState == FlagChallengeTempExpView.EAnimState.CrossLevel || flag)
				{
					this.TargetExpProgress = instance.GetTempExpProgress();
					this.CurrentLevel = newLevel;
					this.TargetLevel = newLevel;
					if (flag)
					{
						this.PlayCrossLevelAnim();
						return;
					}
				}
				else
				{
					if (this.AnimState == FlagChallengeTempExpView.EAnimState.StepByStep)
					{
						this.TargetExpProgress = instance.GetTempExpProgress();
						this.TargetLevel = newLevel;
						return;
					}
					if (this.AnimState == FlagChallengeTempExpView.EAnimState.ReduceLevel || this.AnimState == FlagChallengeTempExpView.EAnimState.ReduceExp)
					{
						this.TargetExpProgress = instance.GetTempExpProgress();
						this.TargetLevel = newLevel;
						this.IsPendingPlayNext = true;
						return;
					}
				}
			}
			else
			{
				this.TargetExpProgress = instance.GetTempExpProgress();
				this.CurrentLevel = newLevel;
				this.TargetLevel = newLevel;
				this.ResetAllItem(this.TargetExpProgress, new EFlagChallengeExpItemTweenAnimType?(EFlagChallengeExpItemTweenAnimType.Red));
				this.RefreshTempLevelText(newLevel);
				if (oldLevel == newLevel)
				{
					this.PlayReduceExpAnim();
					return;
				}
				this.PlayReduceLevelAnim();
			}
		}

		// Token: 0x0603BABF RID: 244415 RVA: 0x00E3DF24 File Offset: 0x00E3C124
		[NullableContext(1)]
		private void OnSequenceEndEvent(string sequenceName)
		{
			if (sequenceName == "YJ" && this.AnimState == FlagChallengeTempExpView.EAnimState.CrossLevel)
			{
				this.AnimState = FlagChallengeTempExpView.EAnimState.None;
				this.PlayLevelUpAnim();
				this.ResetAllItem(this.TargetExpProgress, null);
				this.RefreshTempLevelText(this.TargetLevel);
				UUIItem levelAnimItem = this.LevelAnimItem;
				if (levelAnimItem != null)
				{
					levelAnimItem.SetUIActive(false);
				}
				if (this.TargetLevel == this.MaxLevel)
				{
					this.PlayMaxLevelAnim();
					return;
				}
			}
			else if ((sequenceName == "Decline" && this.AnimState == FlagChallengeTempExpView.EAnimState.ReduceLevel) || (sequenceName == "Decline01" && this.AnimState == FlagChallengeTempExpView.EAnimState.ReduceExp))
			{
				this.AnimState = FlagChallengeTempExpView.EAnimState.None;
				if (this.IsPendingPlayNext)
				{
					this.PlayTweenByNextItem(false);
					this.IsPendingPlayNext = false;
				}
			}
		}

		// Token: 0x0603BAC0 RID: 244416 RVA: 0x00E3DFE8 File Offset: 0x00E3C1E8
		private void PlayLevelUpAnim()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlaySequencePurely("Up", false, false, null, null, false);
		}

		// Token: 0x0603BAC1 RID: 244417 RVA: 0x00E3E018 File Offset: 0x00E3C218
		private void PlayCrossLevelAnim()
		{
			this.StopCurrentState();
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlaySequencePurely("YJ", false, false, null, null, false);
			}
			UUIItem levelAnimItem = this.LevelAnimItem;
			if (levelAnimItem != null)
			{
				levelAnimItem.SetUIActive(true);
			}
			this.AnimState = FlagChallengeTempExpView.EAnimState.CrossLevel;
		}

		// Token: 0x0603BAC2 RID: 244418 RVA: 0x00E3E068 File Offset: 0x00E3C268
		private void PlayReduceExpAnim()
		{
			this.StopCurrentState();
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlaySequencePurely("Decline01", false, false, null, null, false);
			}
			UUIItem itemPanel = this.ItemPanel;
			if (itemPanel != null)
			{
				itemPanel.SetUIActive(true);
			}
			UUIItem levelAnimItem = this.LevelAnimItem;
			if (levelAnimItem != null)
			{
				levelAnimItem.SetUIActive(false);
			}
			UUISprite levelMaxSprite = this.LevelMaxSprite;
			if (levelMaxSprite != null)
			{
				levelMaxSprite.SetUIActive(false);
			}
			this.AnimState = FlagChallengeTempExpView.EAnimState.ReduceExp;
		}

		// Token: 0x0603BAC3 RID: 244419 RVA: 0x00E3E0DC File Offset: 0x00E3C2DC
		private void PlayReduceLevelAnim()
		{
			this.StopCurrentState();
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlaySequencePurely("Decline", false, false, null, null, false);
			}
			UUIItem itemPanel = this.ItemPanel;
			if (itemPanel != null)
			{
				itemPanel.SetUIActive(true);
			}
			UUIItem levelAnimItem = this.LevelAnimItem;
			if (levelAnimItem != null)
			{
				levelAnimItem.SetUIActive(false);
			}
			UUISprite levelMaxSprite = this.LevelMaxSprite;
			if (levelMaxSprite != null)
			{
				levelMaxSprite.SetUIActive(false);
			}
			this.AnimState = FlagChallengeTempExpView.EAnimState.ReduceLevel;
		}

		// Token: 0x0603BAC4 RID: 244420 RVA: 0x00E3E150 File Offset: 0x00E3C350
		private void PlayMaxLevelAnim()
		{
			this.StopCurrentState();
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlaySequencePurely("MaxStart", false, false, null, null, false);
			}
			UUIItem levelAnimItem = this.LevelAnimItem;
			if (levelAnimItem != null)
			{
				levelAnimItem.SetUIActive(true);
			}
			UUISprite levelMaxSprite = this.LevelMaxSprite;
			if (levelMaxSprite != null)
			{
				levelMaxSprite.SetUIActive(true);
			}
			this.AnimState = FlagChallengeTempExpView.EAnimState.MaxLevel;
		}

		// Token: 0x0603BAC5 RID: 244421 RVA: 0x00E3E1B4 File Offset: 0x00E3C3B4
		private void StopCurrentState()
		{
			switch (this.AnimState)
			{
			case FlagChallengeTempExpView.EAnimState.CrossLevel:
			{
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer != null && levelSequencePlayer.IsPlayingSequence("YJ"))
				{
					LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
					if (levelSequencePlayer2 == null)
					{
						return;
					}
					levelSequencePlayer2.StopSequenceByKey("YJ", false, true);
					return;
				}
				break;
			}
			case FlagChallengeTempExpView.EAnimState.ReduceExp:
			{
				LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
				if (levelSequencePlayer3 != null && levelSequencePlayer3.IsPlayingSequence("Decline01"))
				{
					LevelSequencePlayer levelSequencePlayer4 = this.LevelSequencePlayer;
					if (levelSequencePlayer4 == null)
					{
						return;
					}
					levelSequencePlayer4.StopSequenceByKey("Decline01", false, true);
					return;
				}
				break;
			}
			case FlagChallengeTempExpView.EAnimState.ReduceLevel:
			{
				LevelSequencePlayer levelSequencePlayer5 = this.LevelSequencePlayer;
				if (levelSequencePlayer5 != null && levelSequencePlayer5.IsPlayingSequence("Decline"))
				{
					LevelSequencePlayer levelSequencePlayer6 = this.LevelSequencePlayer;
					if (levelSequencePlayer6 == null)
					{
						return;
					}
					levelSequencePlayer6.StopSequenceByKey("Decline", false, true);
					return;
				}
				break;
			}
			case FlagChallengeTempExpView.EAnimState.MaxLevel:
			{
				LevelSequencePlayer levelSequencePlayer7 = this.LevelSequencePlayer;
				if (levelSequencePlayer7 != null && levelSequencePlayer7.IsPlayingSequence("MaxStart"))
				{
					LevelSequencePlayer levelSequencePlayer8 = this.LevelSequencePlayer;
					if (levelSequencePlayer8 != null)
					{
						levelSequencePlayer8.StopSequenceByKey("MaxStart", false, true);
					}
				}
				AUIBaseActor rootActor = this.RootActor;
				if (rootActor == null)
				{
					return;
				}
				rootActor.StopSequenceByKey("MaxLoop");
				break;
			}
			default:
				return;
			}
		}

		// Token: 0x0603BAC6 RID: 244422 RVA: 0x00E3E2C0 File Offset: 0x00E3C4C0
		private void ResetAllItem(float progress, EFlagChallengeExpItemTweenAnimType? playTween = null)
		{
			this.CurrentItemIndex = -1;
			foreach (FlagChallengeTempExpItem flagChallengeTempExpItem in this.ExpItems)
			{
				flagChallengeTempExpItem.Reset();
				if (flagChallengeTempExpItem.IsShowItem(progress))
				{
					this.CurrentItemIndex = flagChallengeTempExpItem.GetIndex();
					flagChallengeTempExpItem.ShowItem();
					if (playTween != null)
					{
						flagChallengeTempExpItem.PlayTweenAnim(playTween.Value);
					}
				}
				else
				{
					flagChallengeTempExpItem.HideItem(true);
				}
			}
		}

		// Token: 0x0603BAC7 RID: 244423 RVA: 0x00E3E354 File Offset: 0x00E3C554
		private void PlayTweenByNextItem(bool needOffset = false)
		{
			int num = this.IsAddProgress ? (this.CurrentItemIndex + 1) : (this.CurrentItemIndex - 1);
			if (needOffset && !this.IsAddProgress)
			{
				num++;
			}
			if (num >= 10)
			{
				if (this.CurrentLevel != this.TargetLevel)
				{
					this.CurrentLevel++;
					this.RefreshTempLevelText(this.CurrentLevel);
					this.ResetAllItem(0f, null);
					this.PlayLevelUpAnim();
					if (this.CurrentLevel == this.MaxLevel)
					{
						this.PlayMaxLevelAnim();
						return;
					}
					this.PlayTweenByNextItem(false);
					return;
				}
				else
				{
					if (this.CurrentLevel == this.MaxLevel - 1 && this.TargetExpProgress == 1f)
					{
						this.PlayMaxLevelAnim();
						return;
					}
					this.AnimState = FlagChallengeTempExpView.EAnimState.None;
					return;
				}
			}
			else if (num < 0)
			{
				if (this.CurrentLevel != this.TargetLevel)
				{
					this.CurrentLevel--;
					this.RefreshTempLevelText(this.CurrentLevel);
					this.ResetAllItem(1f, null);
					this.PlayTweenByNextItem(true);
					return;
				}
				this.AnimState = FlagChallengeTempExpView.EAnimState.None;
				return;
			}
			else
			{
				FlagChallengeTempExpItem flagChallengeTempExpItem = this.ExpItems[num];
				float progress = this.TargetExpProgress;
				if (this.CurrentLevel < this.TargetLevel)
				{
					progress = 1f;
				}
				else if (this.CurrentLevel > this.TargetLevel)
				{
					progress = 0f;
				}
				if (!this.IsAddProgress)
				{
					if (flagChallengeTempExpItem.IsHideItem(progress))
					{
						this.CurrentItemIndex = num;
						flagChallengeTempExpItem.HideItem(true);
						this.DelayPlayNextTween();
					}
					return;
				}
				if (flagChallengeTempExpItem.IsShowItem(progress))
				{
					this.CurrentItemIndex = num;
					flagChallengeTempExpItem.ShowItem();
					flagChallengeTempExpItem.PlayTweenIn();
					this.DelayPlayNextTween();
					this.AnimState = FlagChallengeTempExpView.EAnimState.StepByStep;
					return;
				}
				this.AnimState = FlagChallengeTempExpView.EAnimState.None;
				return;
			}
		}

		// Token: 0x0603BAC8 RID: 244424 RVA: 0x00E3E503 File Offset: 0x00E3C703
		private void DelayPlayNextTween()
		{
			this.StopPlayNextTween();
			this.TweenAnimTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.TweenAnimTimer = null;
				this.PlayTweenByNextItem(false);
			}, (float)Math.Max(20, this.ExpItemTweenInterval), null, null, true, 1f);
		}

		// Token: 0x0603BAC9 RID: 244425 RVA: 0x00E3E53D File Offset: 0x00E3C73D
		private void StopPlayNextTween()
		{
			if (this.TweenAnimTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TweenAnimTimer);
			}
			this.TweenAnimTimer = null;
		}

		// Token: 0x0603BACA RID: 244426 RVA: 0x00E3E55F File Offset: 0x00E3C75F
		public override void ShowBattleVisibleChildView(bool checkVisible = false)
		{
			base.ShowBattleVisibleChildView(checkVisible);
			EventSystem.Instance.Emit<bool>(EEventName.OnMoraleTempExpViewVisibleChanged, true);
		}

		// Token: 0x0603BACB RID: 244427 RVA: 0x00E3E579 File Offset: 0x00E3C779
		public override void HideBattleVisibleChildView()
		{
			base.HideBattleVisibleChildView();
			EventSystem.Instance.Emit<bool>(EEventName.OnMoraleTempExpViewVisibleChanged, false);
		}

		// Token: 0x0401F0FE RID: 127230
		private UUIArtText LevelText;

		// Token: 0x0401F0FF RID: 127231
		private UUIItem ItemPanel;

		// Token: 0x0401F100 RID: 127232
		private UUISprite LevelMaxSprite;

		// Token: 0x0401F101 RID: 127233
		private UUIItem LevelAnimItem;

		// Token: 0x0401F102 RID: 127234
		[Nullable(1)]
		private readonly List<FlagChallengeTempExpItem> ExpItems = new List<FlagChallengeTempExpItem>();

		// Token: 0x0401F103 RID: 127235
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401F104 RID: 127236
		private int CurrentLevel;

		// Token: 0x0401F105 RID: 127237
		private int TargetLevel;

		// Token: 0x0401F106 RID: 127238
		private int MaxLevel;

		// Token: 0x0401F107 RID: 127239
		private float TargetExpProgress;

		// Token: 0x0401F108 RID: 127240
		private bool IsAddProgress;

		// Token: 0x0401F109 RID: 127241
		private int CurrentItemIndex = -1;

		// Token: 0x0401F10A RID: 127242
		private TimerHandle TweenAnimTimer;

		// Token: 0x0401F10B RID: 127243
		private FlagChallengeTempExpView.EAnimState AnimState;

		// Token: 0x0401F10C RID: 127244
		private bool IsPendingPlayNext;

		// Token: 0x0401F10D RID: 127245
		private int ExpItemTweenInterval = 20;

		// Token: 0x0401F10E RID: 127246
		private int CrossLevelDiff = 3;

		// Token: 0x0200BE40 RID: 48704
		[NullableContext(0)]
		private enum EAnimState
		{
			// Token: 0x040395F9 RID: 235001
			None,
			// Token: 0x040395FA RID: 235002
			StepByStep,
			// Token: 0x040395FB RID: 235003
			CrossLevel,
			// Token: 0x040395FC RID: 235004
			ReduceExp,
			// Token: 0x040395FD RID: 235005
			ReduceLevel,
			// Token: 0x040395FE RID: 235006
			MaxLevel
		}

		// Token: 0x0200BE41 RID: 48705
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x04039600 RID: 235008
			LevelText,
			// Token: 0x04039601 RID: 235009
			LevelMaxSprite,
			// Token: 0x04039602 RID: 235010
			ItemPanel,
			// Token: 0x04039603 RID: 235011
			UnitItem,
			// Token: 0x04039604 RID: 235012
			LevelAnimItem
		}
	}
}
