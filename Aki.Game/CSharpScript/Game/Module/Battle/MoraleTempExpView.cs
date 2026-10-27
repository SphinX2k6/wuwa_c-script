using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02005C55 RID: 23637
	[NullableContext(2)]
	[Nullable(0)]
	public class MoraleTempExpView : BattleVisibleChildView
	{
		// Token: 0x0603BBEF RID: 244719 RVA: 0x00E44E28 File Offset: 0x00E43028
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

		// Token: 0x0603BBF0 RID: 244720 RVA: 0x00E44EF4 File Offset: 0x00E430F4
		protected override UniTask OnCreateAsync()
		{
			MoraleTempExpView.<OnCreateAsync>d__25 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<MoraleTempExpView.<OnCreateAsync>d__25>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603BBF1 RID: 244721 RVA: 0x00E44F38 File Offset: 0x00E43138
		protected override void OnStart()
		{
			base.OnStart();
			base.InitChildType(EBattleUiChild.RoleState);
			this.AddEvents();
			this.MaxLevel = MoraleBattleModel.Instance.GetTempMoraleMaxLevel();
			this.ExpUnitTweenInterval = Math.Max(20, ConfigCommonParamById.GetIntConfig("MoraleTempExpUnitInterval").GetValueOrDefault(20));
			this.CrossLevelDiff = ConfigCommonParamById.GetIntConfig("MoraleTempExpCrossLevel").GetValueOrDefault(3);
			this.LevelText = base.GetArtText(0);
			this.UnitPanel = base.GetItem(2);
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
			for (int i = 0; i < this.ExpUnits.Count; i++)
			{
				MoraleTempExpUnit moraleTempExpUnit = this.ExpUnits[i];
				moraleTempExpUnit.SetIndex(i);
				if (i % 2 == 1)
				{
					moraleTempExpUnit.GetRootItem().SetUIRelativeRotation(frotator);
				}
				moraleTempExpUnit.GetRootItem().SetUIParent(this.UnitPanel, false);
			}
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceEndEvent), false);
		}

		// Token: 0x0603BBF2 RID: 244722 RVA: 0x00E4509C File Offset: 0x00E4329C
		protected override void OnBeforeDestroy()
		{
			foreach (MoraleTempExpUnit moraleTempExpUnit in this.ExpUnits)
			{
				moraleTempExpUnit.Clean();
			}
			this.ExpUnits.Clear();
			base.OnBeforeDestroy();
		}

		// Token: 0x0603BBF3 RID: 244723 RVA: 0x00E45100 File Offset: 0x00E43300
		public override void Reset()
		{
			this.RemoveEvents();
			base.Reset();
		}

		// Token: 0x0603BBF4 RID: 244724 RVA: 0x00E45110 File Offset: 0x00E43310
		private UniTask AddExpUnit()
		{
			MoraleTempExpView.<AddExpUnit>d__29 <AddExpUnit>d__;
			<AddExpUnit>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AddExpUnit>d__.<>4__this = this;
			<AddExpUnit>d__.<>1__state = -1;
			<AddExpUnit>d__.<>t__builder.Start<MoraleTempExpView.<AddExpUnit>d__29>(ref <AddExpUnit>d__);
			return <AddExpUnit>d__.<>t__builder.Task;
		}

		// Token: 0x0603BBF5 RID: 244725 RVA: 0x00E45153 File Offset: 0x00E43353
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnMoraleTempExpChanged, new Action<int, int, int, int>(this.OnMoraleTempExpChanged));
		}

		// Token: 0x0603BBF6 RID: 244726 RVA: 0x00E45171 File Offset: 0x00E43371
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnMoraleTempExpChanged, new Action<int, int, int, int>(this.OnMoraleTempExpChanged));
		}

		// Token: 0x0603BBF7 RID: 244727 RVA: 0x00E4518F File Offset: 0x00E4338F
		protected override void OnShowBattleChildView()
		{
			this.RefreshMoraleInfo();
		}

		// Token: 0x0603BBF8 RID: 244728 RVA: 0x00E45197 File Offset: 0x00E43397
		protected override void OnHideBattleChildView()
		{
			this.StopCurrentState();
			this.AnimState = MoraleTempExpView.EAnimState.None;
		}

		// Token: 0x0603BBF9 RID: 244729 RVA: 0x00E451A8 File Offset: 0x00E433A8
		private void RefreshMoraleInfo()
		{
			MoraleBattleModel instance = MoraleBattleModel.Instance;
			this.CurrentLevel = instance.GetTempMoraleLevel();
			this.TargetLevel = this.CurrentLevel;
			this.TargetExpProgress = instance.GetTempMoraleExpProgress();
			this.MaxLevel = instance.GetTempMoraleMaxLevel();
			this.ResetAllUnit(this.TargetExpProgress, null);
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

		// Token: 0x0603BBFA RID: 244730 RVA: 0x00E45240 File Offset: 0x00E43440
		private void RefreshTempLevelText(int tempLevel)
		{
			int num = MoraleBattleModel.Instance.GetMoraleLevel() + tempLevel;
			UUIArtText levelText = this.LevelText;
			if (levelText == null)
			{
				return;
			}
			levelText.SetText(num.ToString());
		}

		// Token: 0x0603BBFB RID: 244731 RVA: 0x00E45274 File Offset: 0x00E43474
		private void OnMoraleTempExpChanged(int oldExp, int newExp, int oldLevel, int newLevel)
		{
			if (!base.GetVisible())
			{
				return;
			}
			if (oldExp == newExp && oldLevel == newLevel)
			{
				return;
			}
			MoraleBattleModel instance = MoraleBattleModel.Instance;
			if (newLevel == oldLevel)
			{
				this.IsAddProgress = (newExp > oldExp);
			}
			else
			{
				this.IsAddProgress = (newLevel > oldLevel);
				this.MaxLevel = instance.GetTempMoraleMaxLevel();
			}
			if (this.IsAddProgress)
			{
				bool flag = false;
				if (this.AnimState != MoraleTempExpView.EAnimState.CrossLevel && newLevel - oldLevel >= this.CrossLevelDiff)
				{
					flag = true;
				}
				if (this.AnimState == MoraleTempExpView.EAnimState.None && !flag)
				{
					ref ValueTuple<int, int> tempLevelExpRange = instance.GetTempLevelExpRange(oldLevel);
					int tempMoraleLevelUpExp = instance.GetTempMoraleLevelUpExp(new int?(oldLevel));
					int item = tempLevelExpRange.Item1;
					float progress = (float)(oldExp - item) / (float)tempMoraleLevelUpExp;
					this.TargetExpProgress = instance.GetTempMoraleExpProgress();
					this.CurrentLevel = oldLevel;
					this.TargetLevel = newLevel;
					this.RefreshTempLevelText(oldLevel);
					this.ResetAllUnit(progress, null);
					this.PlayTweenByNextUnit(true);
					return;
				}
				if (this.AnimState == MoraleTempExpView.EAnimState.CrossLevel || flag)
				{
					this.TargetExpProgress = instance.GetTempMoraleExpProgress();
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
					if (this.AnimState == MoraleTempExpView.EAnimState.StepByStep)
					{
						this.TargetExpProgress = instance.GetTempMoraleExpProgress();
						this.TargetLevel = newLevel;
						return;
					}
					if (this.AnimState == MoraleTempExpView.EAnimState.ReduceLevel || this.AnimState == MoraleTempExpView.EAnimState.ReduceExp)
					{
						this.TargetExpProgress = instance.GetTempMoraleExpProgress();
						this.TargetLevel = newLevel;
						this.IsPendingPlayNext = true;
						return;
					}
				}
			}
			else
			{
				this.TargetExpProgress = instance.GetTempMoraleExpProgress();
				this.CurrentLevel = newLevel;
				this.TargetLevel = newLevel;
				this.ResetAllUnit(this.TargetExpProgress, new MoraleTempExpView.ETweenAnimType?(MoraleTempExpView.ETweenAnimType.Red));
				this.RefreshTempLevelText(newLevel);
				if (oldLevel == newLevel)
				{
					this.PlayReduceExpAnim();
					return;
				}
				this.PlayReduceLevelAnim();
			}
		}

		// Token: 0x0603BBFC RID: 244732 RVA: 0x00E4541C File Offset: 0x00E4361C
		[NullableContext(1)]
		private void OnSequenceEndEvent(string sequenceName)
		{
			if (sequenceName == "YJ" && this.AnimState == MoraleTempExpView.EAnimState.CrossLevel)
			{
				this.AnimState = MoraleTempExpView.EAnimState.None;
				this.PlayLevelUpAnim();
				this.ResetAllUnit(this.TargetExpProgress, null);
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
			else if ((sequenceName == "Decline" && this.AnimState == MoraleTempExpView.EAnimState.ReduceLevel) || (sequenceName == "Decline01" && this.AnimState == MoraleTempExpView.EAnimState.ReduceExp))
			{
				this.AnimState = MoraleTempExpView.EAnimState.None;
				if (this.IsPendingPlayNext)
				{
					this.PlayTweenByNextUnit(false);
					this.IsPendingPlayNext = false;
				}
			}
		}

		// Token: 0x0603BBFD RID: 244733 RVA: 0x00E454E0 File Offset: 0x00E436E0
		private void PlayLevelUpAnim()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlaySequencePurely("Up", false, false, null, null, false);
		}

		// Token: 0x0603BBFE RID: 244734 RVA: 0x00E45510 File Offset: 0x00E43710
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
			this.AnimState = MoraleTempExpView.EAnimState.CrossLevel;
		}

		// Token: 0x0603BBFF RID: 244735 RVA: 0x00E45560 File Offset: 0x00E43760
		private void PlayReduceExpAnim()
		{
			this.StopCurrentState();
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlaySequencePurely("Decline01", false, false, null, null, false);
			}
			UUIItem unitPanel = this.UnitPanel;
			if (unitPanel != null)
			{
				unitPanel.SetUIActive(true);
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
			this.AnimState = MoraleTempExpView.EAnimState.ReduceExp;
		}

		// Token: 0x0603BC00 RID: 244736 RVA: 0x00E455D4 File Offset: 0x00E437D4
		private void PlayReduceLevelAnim()
		{
			this.StopCurrentState();
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlaySequencePurely("Decline", false, false, null, null, false);
			}
			UUIItem unitPanel = this.UnitPanel;
			if (unitPanel != null)
			{
				unitPanel.SetUIActive(true);
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
			this.AnimState = MoraleTempExpView.EAnimState.ReduceLevel;
		}

		// Token: 0x0603BC01 RID: 244737 RVA: 0x00E45648 File Offset: 0x00E43848
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
			this.AnimState = MoraleTempExpView.EAnimState.MaxLevel;
		}

		// Token: 0x0603BC02 RID: 244738 RVA: 0x00E456AC File Offset: 0x00E438AC
		private void StopCurrentState()
		{
			switch (this.AnimState)
			{
			case MoraleTempExpView.EAnimState.CrossLevel:
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
			case MoraleTempExpView.EAnimState.ReduceExp:
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
			case MoraleTempExpView.EAnimState.ReduceLevel:
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
			case MoraleTempExpView.EAnimState.MaxLevel:
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

		// Token: 0x0603BC03 RID: 244739 RVA: 0x00E457B8 File Offset: 0x00E439B8
		private void ResetAllUnit(float progress, MoraleTempExpView.ETweenAnimType? playTween = null)
		{
			this.CurrentUnitIndex = -1;
			foreach (MoraleTempExpUnit moraleTempExpUnit in this.ExpUnits)
			{
				moraleTempExpUnit.Reset();
				if (moraleTempExpUnit.IsShowUnit(progress))
				{
					this.CurrentUnitIndex = moraleTempExpUnit.Index;
					moraleTempExpUnit.ShowUnit();
					if (playTween != null)
					{
						moraleTempExpUnit.PlayTweenAnim(playTween.Value);
					}
				}
				else
				{
					moraleTempExpUnit.HideUnit(true);
				}
			}
		}

		// Token: 0x0603BC04 RID: 244740 RVA: 0x00E4584C File Offset: 0x00E43A4C
		private void PlayTweenByNextUnit(bool needOffset = false)
		{
			int num = this.IsAddProgress ? (this.CurrentUnitIndex + 1) : (this.CurrentUnitIndex - 1);
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
					this.ResetAllUnit(0f, null);
					this.PlayLevelUpAnim();
					if (this.CurrentLevel == this.MaxLevel)
					{
						this.PlayMaxLevelAnim();
						return;
					}
					this.PlayTweenByNextUnit(false);
					return;
				}
				else
				{
					if (this.CurrentLevel == this.MaxLevel - 1 && this.TargetExpProgress == 1f)
					{
						this.PlayMaxLevelAnim();
						return;
					}
					this.AnimState = MoraleTempExpView.EAnimState.None;
					return;
				}
			}
			else if (num < 0)
			{
				if (this.CurrentLevel != this.TargetLevel)
				{
					this.CurrentLevel--;
					this.RefreshTempLevelText(this.CurrentLevel);
					this.ResetAllUnit(1f, null);
					this.PlayTweenByNextUnit(true);
					return;
				}
				this.AnimState = MoraleTempExpView.EAnimState.None;
				return;
			}
			else
			{
				MoraleTempExpUnit moraleTempExpUnit = this.ExpUnits[num];
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
					if (moraleTempExpUnit.IsHideUnit(progress))
					{
						this.CurrentUnitIndex = num;
						moraleTempExpUnit.HideUnit(true);
						this.DelayPlayNextTween();
					}
					return;
				}
				if (moraleTempExpUnit.IsShowUnit(progress))
				{
					this.CurrentUnitIndex = num;
					moraleTempExpUnit.ShowUnit();
					moraleTempExpUnit.PlayTweenIn();
					this.DelayPlayNextTween();
					this.AnimState = MoraleTempExpView.EAnimState.StepByStep;
					return;
				}
				this.AnimState = MoraleTempExpView.EAnimState.None;
				return;
			}
		}

		// Token: 0x0603BC05 RID: 244741 RVA: 0x00E459FB File Offset: 0x00E43BFB
		private void DelayPlayNextTween()
		{
			this.StopPlayNextTween();
			this.TweenAnimTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.TweenAnimTimer = null;
				this.PlayTweenByNextUnit(false);
			}, (float)Math.Max(20, this.ExpUnitTweenInterval), null, null, true, 1f);
		}

		// Token: 0x0603BC06 RID: 244742 RVA: 0x00E45A35 File Offset: 0x00E43C35
		private void StopPlayNextTween()
		{
			if (this.TweenAnimTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TweenAnimTimer);
			}
			this.TweenAnimTimer = null;
		}

		// Token: 0x0603BC07 RID: 244743 RVA: 0x00E45A57 File Offset: 0x00E43C57
		public override void ShowBattleVisibleChildView(bool checkVisible = false)
		{
			base.ShowBattleVisibleChildView(checkVisible);
			EventSystem.Instance.Emit<bool>(EEventName.OnMoraleTempExpViewVisibleChanged, true);
		}

		// Token: 0x0603BC08 RID: 244744 RVA: 0x00E45A71 File Offset: 0x00E43C71
		public override void HideBattleVisibleChildView()
		{
			base.HideBattleVisibleChildView();
			EventSystem.Instance.Emit<bool>(EEventName.OnMoraleTempExpViewVisibleChanged, false);
		}

		// Token: 0x0401F1BB RID: 127419
		private const int EXP_UNIT_COUNT = 10;

		// Token: 0x0401F1BC RID: 127420
		public const float EXP_PROGRESS_STEP = 0.1f;

		// Token: 0x0401F1BD RID: 127421
		private const int EXP_UNIT_TWEEN_INTERVAL = 20;

		// Token: 0x0401F1BE RID: 127422
		private const int CROSS_LEVEL_DIFF = 3;

		// Token: 0x0401F1BF RID: 127423
		private UUIArtText LevelText;

		// Token: 0x0401F1C0 RID: 127424
		private UUIItem UnitPanel;

		// Token: 0x0401F1C1 RID: 127425
		private UUISprite LevelMaxSprite;

		// Token: 0x0401F1C2 RID: 127426
		private UUIItem LevelAnimItem;

		// Token: 0x0401F1C3 RID: 127427
		[Nullable(1)]
		private readonly List<MoraleTempExpUnit> ExpUnits = new List<MoraleTempExpUnit>();

		// Token: 0x0401F1C4 RID: 127428
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401F1C5 RID: 127429
		private int CurrentLevel = 1;

		// Token: 0x0401F1C6 RID: 127430
		private int TargetLevel = 1;

		// Token: 0x0401F1C7 RID: 127431
		private int MaxLevel = 1;

		// Token: 0x0401F1C8 RID: 127432
		private float TargetExpProgress;

		// Token: 0x0401F1C9 RID: 127433
		private bool IsAddProgress = true;

		// Token: 0x0401F1CA RID: 127434
		private int CurrentUnitIndex = -1;

		// Token: 0x0401F1CB RID: 127435
		private TimerHandle TweenAnimTimer;

		// Token: 0x0401F1CC RID: 127436
		private MoraleTempExpView.EAnimState AnimState;

		// Token: 0x0401F1CD RID: 127437
		private bool IsPendingPlayNext;

		// Token: 0x0401F1CE RID: 127438
		private int ExpUnitTweenInterval = 20;

		// Token: 0x0401F1CF RID: 127439
		private int CrossLevelDiff = 3;

		// Token: 0x0200BE68 RID: 48744
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x040396B7 RID: 235191
			LevelText,
			// Token: 0x040396B8 RID: 235192
			LevelMaxSprite,
			// Token: 0x040396B9 RID: 235193
			UnitPanel,
			// Token: 0x040396BA RID: 235194
			UnitItem,
			// Token: 0x040396BB RID: 235195
			LevelAnimItem
		}

		// Token: 0x0200BE69 RID: 48745
		[NullableContext(0)]
		private enum EAnimState
		{
			// Token: 0x040396BD RID: 235197
			None,
			// Token: 0x040396BE RID: 235198
			StepByStep,
			// Token: 0x040396BF RID: 235199
			CrossLevel,
			// Token: 0x040396C0 RID: 235200
			ReduceExp,
			// Token: 0x040396C1 RID: 235201
			ReduceLevel,
			// Token: 0x040396C2 RID: 235202
			MaxLevel
		}

		// Token: 0x0200BE6A RID: 48746
		[NullableContext(0)]
		public enum ETweenAnimType
		{
			// Token: 0x040396C4 RID: 235204
			In,
			// Token: 0x040396C5 RID: 235205
			Out,
			// Token: 0x040396C6 RID: 235206
			Break,
			// Token: 0x040396C7 RID: 235207
			Red
		}
	}
}
