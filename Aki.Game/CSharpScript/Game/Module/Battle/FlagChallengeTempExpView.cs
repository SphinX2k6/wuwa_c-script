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
	// Token: 0x02004C24 RID: 19492
	[NullableContext(2)]
	[Nullable(0)]
	public class FlagChallengeTempExpView : BattleVisibleChildView
	{
		// Token: 0x060309FD RID: 199165 RVA: 0x00D8DCCC File Offset: 0x00D8BECC
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

		// Token: 0x060309FE RID: 199166 RVA: 0x00D8DD98 File Offset: 0x00D8BF98
		protected override UniTask OnCreateAsync()
		{
			FlagChallengeTempExpView.<OnCreateAsync>d__20 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<FlagChallengeTempExpView.<OnCreateAsync>d__20>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060309FF RID: 199167 RVA: 0x00D8DDDC File Offset: 0x00D8BFDC
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

		// Token: 0x06030A00 RID: 199168 RVA: 0x00D8DF28 File Offset: 0x00D8C128
		protected override void OnBeforeDestroy()
		{
			foreach (FlagChallengeTempExpItem flagChallengeTempExpItem in this.ExpItems)
			{
				flagChallengeTempExpItem.Clean();
			}
			this.ExpItems.Clear();
			base.OnBeforeDestroy();
		}

		// Token: 0x06030A01 RID: 199169 RVA: 0x00D8DF8C File Offset: 0x00D8C18C
		public override void Reset()
		{
			this.RemoveEvents();
			base.Reset();
		}

		// Token: 0x06030A02 RID: 199170 RVA: 0x00D8DF9C File Offset: 0x00D8C19C
		private UniTask AddExpItem()
		{
			FlagChallengeTempExpView.<AddExpItem>d__24 <AddExpItem>d__;
			<AddExpItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AddExpItem>d__.<>4__this = this;
			<AddExpItem>d__.<>1__state = -1;
			<AddExpItem>d__.<>t__builder.Start<FlagChallengeTempExpView.<AddExpItem>d__24>(ref <AddExpItem>d__);
			return <AddExpItem>d__.<>t__builder.Task;
		}

		// Token: 0x06030A03 RID: 199171 RVA: 0x00D8DFDF File Offset: 0x00D8C1DF
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnFlagChallengeTempExpChanged, new Action<int, int, int, int>(this.OnFlagChallengeTempExpChanged));
		}

		// Token: 0x06030A04 RID: 199172 RVA: 0x00D8DFFD File Offset: 0x00D8C1FD
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnFlagChallengeTempExpChanged, new Action<int, int, int, int>(this.OnFlagChallengeTempExpChanged));
		}

		// Token: 0x06030A05 RID: 199173 RVA: 0x00D8E01B File Offset: 0x00D8C21B
		protected override void OnShowBattleChildView()
		{
			this.RefreshFlagChallengeInfo();
		}

		// Token: 0x06030A06 RID: 199174 RVA: 0x00D8E023 File Offset: 0x00D8C223
		protected override void OnHideBattleChildView()
		{
			this.StopCurrentState();
			this.AnimState = FlagChallengeTempExpView.EAnimState.None;
		}

		// Token: 0x06030A07 RID: 199175 RVA: 0x00D8E034 File Offset: 0x00D8C234
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

		// Token: 0x06030A08 RID: 199176 RVA: 0x00D8E0CC File Offset: 0x00D8C2CC
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

		// Token: 0x06030A09 RID: 199177 RVA: 0x00D8E100 File Offset: 0x00D8C300
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

		// Token: 0x06030A0A RID: 199178 RVA: 0x00D8E2A8 File Offset: 0x00D8C4A8
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

		// Token: 0x06030A0B RID: 199179 RVA: 0x00D8E36C File Offset: 0x00D8C56C
		private void PlayLevelUpAnim()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlaySequencePurely("Up", false, false, null, null, false);
		}

		// Token: 0x06030A0C RID: 199180 RVA: 0x00D8E39C File Offset: 0x00D8C59C
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

		// Token: 0x06030A0D RID: 199181 RVA: 0x00D8E3EC File Offset: 0x00D8C5EC
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

		// Token: 0x06030A0E RID: 199182 RVA: 0x00D8E460 File Offset: 0x00D8C660
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

		// Token: 0x06030A0F RID: 199183 RVA: 0x00D8E4D4 File Offset: 0x00D8C6D4
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

		// Token: 0x06030A10 RID: 199184 RVA: 0x00D8E538 File Offset: 0x00D8C738
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

		// Token: 0x06030A11 RID: 199185 RVA: 0x00D8E644 File Offset: 0x00D8C844
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

		// Token: 0x06030A12 RID: 199186 RVA: 0x00D8E6D8 File Offset: 0x00D8C8D8
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

		// Token: 0x06030A13 RID: 199187 RVA: 0x00D8E887 File Offset: 0x00D8CA87
		private void DelayPlayNextTween()
		{
			this.StopPlayNextTween();
			this.TweenAnimTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.TweenAnimTimer = null;
				this.PlayTweenByNextItem(false);
			}, (float)Math.Max(20, this.ExpItemTweenInterval), null, null, true, 1f);
		}

		// Token: 0x06030A14 RID: 199188 RVA: 0x00D8E8C1 File Offset: 0x00D8CAC1
		private void StopPlayNextTween()
		{
			if (this.TweenAnimTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TweenAnimTimer);
			}
			this.TweenAnimTimer = null;
		}

		// Token: 0x06030A15 RID: 199189 RVA: 0x00D8E8E3 File Offset: 0x00D8CAE3
		public override void ShowBattleVisibleChildView(bool checkVisible = false)
		{
			base.ShowBattleVisibleChildView(checkVisible);
			EventSystem.Instance.Emit<bool>(EEventName.OnMoraleTempExpViewVisibleChanged, true);
		}

		// Token: 0x06030A16 RID: 199190 RVA: 0x00D8E8FD File Offset: 0x00D8CAFD
		public override void HideBattleVisibleChildView()
		{
			base.HideBattleVisibleChildView();
			EventSystem.Instance.Emit<bool>(EEventName.OnMoraleTempExpViewVisibleChanged, false);
		}

		// Token: 0x04019BAF RID: 105391
		private UUIArtText LevelText;

		// Token: 0x04019BB0 RID: 105392
		private UUIItem ItemPanel;

		// Token: 0x04019BB1 RID: 105393
		private UUISprite LevelMaxSprite;

		// Token: 0x04019BB2 RID: 105394
		private UUIItem LevelAnimItem;

		// Token: 0x04019BB3 RID: 105395
		[Nullable(1)]
		private readonly List<FlagChallengeTempExpItem> ExpItems = new List<FlagChallengeTempExpItem>();

		// Token: 0x04019BB4 RID: 105396
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04019BB5 RID: 105397
		private int CurrentLevel;

		// Token: 0x04019BB6 RID: 105398
		private int TargetLevel;

		// Token: 0x04019BB7 RID: 105399
		private int MaxLevel;

		// Token: 0x04019BB8 RID: 105400
		private float TargetExpProgress;

		// Token: 0x04019BB9 RID: 105401
		private bool IsAddProgress;

		// Token: 0x04019BBA RID: 105402
		private int CurrentItemIndex = -1;

		// Token: 0x04019BBB RID: 105403
		private TimerHandle TweenAnimTimer;

		// Token: 0x04019BBC RID: 105404
		private FlagChallengeTempExpView.EAnimState AnimState;

		// Token: 0x04019BBD RID: 105405
		private bool IsPendingPlayNext;

		// Token: 0x04019BBE RID: 105406
		private int ExpItemTweenInterval = 20;

		// Token: 0x04019BBF RID: 105407
		private int CrossLevelDiff = 3;

		// Token: 0x0200A848 RID: 43080
		[NullableContext(0)]
		private enum EAnimState
		{
			// Token: 0x04033FBC RID: 212924
			None,
			// Token: 0x04033FBD RID: 212925
			StepByStep,
			// Token: 0x04033FBE RID: 212926
			CrossLevel,
			// Token: 0x04033FBF RID: 212927
			ReduceExp,
			// Token: 0x04033FC0 RID: 212928
			ReduceLevel,
			// Token: 0x04033FC1 RID: 212929
			MaxLevel
		}

		// Token: 0x0200A849 RID: 43081
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x04033FC3 RID: 212931
			LevelText,
			// Token: 0x04033FC4 RID: 212932
			LevelMaxSprite,
			// Token: 0x04033FC5 RID: 212933
			ItemPanel,
			// Token: 0x04033FC6 RID: 212934
			UnitItem,
			// Token: 0x04033FC7 RID: 212935
			LevelAnimItem
		}
	}
}
