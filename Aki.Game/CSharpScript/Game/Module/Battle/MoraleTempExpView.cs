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
	// Token: 0x02004C35 RID: 19509
	[NullableContext(2)]
	[Nullable(0)]
	public class MoraleTempExpView : BattleVisibleChildView
	{
		// Token: 0x06030B3A RID: 199482 RVA: 0x00D951F4 File Offset: 0x00D933F4
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

		// Token: 0x06030B3B RID: 199483 RVA: 0x00D952C0 File Offset: 0x00D934C0
		protected override UniTask OnCreateAsync()
		{
			MoraleTempExpView.<OnCreateAsync>d__25 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<MoraleTempExpView.<OnCreateAsync>d__25>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030B3C RID: 199484 RVA: 0x00D95304 File Offset: 0x00D93504
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

		// Token: 0x06030B3D RID: 199485 RVA: 0x00D95468 File Offset: 0x00D93668
		protected override void OnBeforeDestroy()
		{
			foreach (MoraleTempExpUnit moraleTempExpUnit in this.ExpUnits)
			{
				moraleTempExpUnit.Clean();
			}
			this.ExpUnits.Clear();
			base.OnBeforeDestroy();
		}

		// Token: 0x06030B3E RID: 199486 RVA: 0x00D954CC File Offset: 0x00D936CC
		public override void Reset()
		{
			this.RemoveEvents();
			base.Reset();
		}

		// Token: 0x06030B3F RID: 199487 RVA: 0x00D954DC File Offset: 0x00D936DC
		private UniTask AddExpUnit()
		{
			MoraleTempExpView.<AddExpUnit>d__29 <AddExpUnit>d__;
			<AddExpUnit>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AddExpUnit>d__.<>4__this = this;
			<AddExpUnit>d__.<>1__state = -1;
			<AddExpUnit>d__.<>t__builder.Start<MoraleTempExpView.<AddExpUnit>d__29>(ref <AddExpUnit>d__);
			return <AddExpUnit>d__.<>t__builder.Task;
		}

		// Token: 0x06030B40 RID: 199488 RVA: 0x00D9551F File Offset: 0x00D9371F
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnMoraleTempExpChanged, new Action<int, int, int, int>(this.OnMoraleTempExpChanged));
		}

		// Token: 0x06030B41 RID: 199489 RVA: 0x00D9553D File Offset: 0x00D9373D
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnMoraleTempExpChanged, new Action<int, int, int, int>(this.OnMoraleTempExpChanged));
		}

		// Token: 0x06030B42 RID: 199490 RVA: 0x00D9555B File Offset: 0x00D9375B
		protected override void OnShowBattleChildView()
		{
			this.RefreshMoraleInfo();
		}

		// Token: 0x06030B43 RID: 199491 RVA: 0x00D95563 File Offset: 0x00D93763
		protected override void OnHideBattleChildView()
		{
			this.StopCurrentState();
			this.AnimState = MoraleTempExpView.EAnimState.None;
		}

		// Token: 0x06030B44 RID: 199492 RVA: 0x00D95574 File Offset: 0x00D93774
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

		// Token: 0x06030B45 RID: 199493 RVA: 0x00D9560C File Offset: 0x00D9380C
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

		// Token: 0x06030B46 RID: 199494 RVA: 0x00D95640 File Offset: 0x00D93840
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

		// Token: 0x06030B47 RID: 199495 RVA: 0x00D957E8 File Offset: 0x00D939E8
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

		// Token: 0x06030B48 RID: 199496 RVA: 0x00D958AC File Offset: 0x00D93AAC
		private void PlayLevelUpAnim()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlaySequencePurely("Up", false, false, null, null, false);
		}

		// Token: 0x06030B49 RID: 199497 RVA: 0x00D958DC File Offset: 0x00D93ADC
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

		// Token: 0x06030B4A RID: 199498 RVA: 0x00D9592C File Offset: 0x00D93B2C
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

		// Token: 0x06030B4B RID: 199499 RVA: 0x00D959A0 File Offset: 0x00D93BA0
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

		// Token: 0x06030B4C RID: 199500 RVA: 0x00D95A14 File Offset: 0x00D93C14
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

		// Token: 0x06030B4D RID: 199501 RVA: 0x00D95A78 File Offset: 0x00D93C78
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

		// Token: 0x06030B4E RID: 199502 RVA: 0x00D95B84 File Offset: 0x00D93D84
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

		// Token: 0x06030B4F RID: 199503 RVA: 0x00D95C18 File Offset: 0x00D93E18
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

		// Token: 0x06030B50 RID: 199504 RVA: 0x00D95DC7 File Offset: 0x00D93FC7
		private void DelayPlayNextTween()
		{
			this.StopPlayNextTween();
			this.TweenAnimTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.TweenAnimTimer = null;
				this.PlayTweenByNextUnit(false);
			}, (float)Math.Max(20, this.ExpUnitTweenInterval), null, null, true, 1f);
		}

		// Token: 0x06030B51 RID: 199505 RVA: 0x00D95E01 File Offset: 0x00D94001
		private void StopPlayNextTween()
		{
			if (this.TweenAnimTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TweenAnimTimer);
			}
			this.TweenAnimTimer = null;
		}

		// Token: 0x06030B52 RID: 199506 RVA: 0x00D95E23 File Offset: 0x00D94023
		public override void ShowBattleVisibleChildView(bool checkVisible = false)
		{
			base.ShowBattleVisibleChildView(checkVisible);
			EventSystem.Instance.Emit<bool>(EEventName.OnMoraleTempExpViewVisibleChanged, true);
		}

		// Token: 0x06030B53 RID: 199507 RVA: 0x00D95E3D File Offset: 0x00D9403D
		public override void HideBattleVisibleChildView()
		{
			base.HideBattleVisibleChildView();
			EventSystem.Instance.Emit<bool>(EEventName.OnMoraleTempExpViewVisibleChanged, false);
		}

		// Token: 0x04019C6C RID: 105580
		private const int EXP_UNIT_COUNT = 10;

		// Token: 0x04019C6D RID: 105581
		public const float EXP_PROGRESS_STEP = 0.1f;

		// Token: 0x04019C6E RID: 105582
		private const int EXP_UNIT_TWEEN_INTERVAL = 20;

		// Token: 0x04019C6F RID: 105583
		private const int CROSS_LEVEL_DIFF = 3;

		// Token: 0x04019C70 RID: 105584
		private UUIArtText LevelText;

		// Token: 0x04019C71 RID: 105585
		private UUIItem UnitPanel;

		// Token: 0x04019C72 RID: 105586
		private UUISprite LevelMaxSprite;

		// Token: 0x04019C73 RID: 105587
		private UUIItem LevelAnimItem;

		// Token: 0x04019C74 RID: 105588
		[Nullable(1)]
		private readonly List<MoraleTempExpUnit> ExpUnits = new List<MoraleTempExpUnit>();

		// Token: 0x04019C75 RID: 105589
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04019C76 RID: 105590
		private int CurrentLevel = 1;

		// Token: 0x04019C77 RID: 105591
		private int TargetLevel = 1;

		// Token: 0x04019C78 RID: 105592
		private int MaxLevel = 1;

		// Token: 0x04019C79 RID: 105593
		private float TargetExpProgress;

		// Token: 0x04019C7A RID: 105594
		private bool IsAddProgress = true;

		// Token: 0x04019C7B RID: 105595
		private int CurrentUnitIndex = -1;

		// Token: 0x04019C7C RID: 105596
		private TimerHandle TweenAnimTimer;

		// Token: 0x04019C7D RID: 105597
		private MoraleTempExpView.EAnimState AnimState;

		// Token: 0x04019C7E RID: 105598
		private bool IsPendingPlayNext;

		// Token: 0x04019C7F RID: 105599
		private int ExpUnitTweenInterval = 20;

		// Token: 0x04019C80 RID: 105600
		private int CrossLevelDiff = 3;

		// Token: 0x0200A86E RID: 43118
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034078 RID: 213112
			LevelText,
			// Token: 0x04034079 RID: 213113
			LevelMaxSprite,
			// Token: 0x0403407A RID: 213114
			UnitPanel,
			// Token: 0x0403407B RID: 213115
			UnitItem,
			// Token: 0x0403407C RID: 213116
			LevelAnimItem
		}

		// Token: 0x0200A86F RID: 43119
		[NullableContext(0)]
		private enum EAnimState
		{
			// Token: 0x0403407E RID: 213118
			None,
			// Token: 0x0403407F RID: 213119
			StepByStep,
			// Token: 0x04034080 RID: 213120
			CrossLevel,
			// Token: 0x04034081 RID: 213121
			ReduceExp,
			// Token: 0x04034082 RID: 213122
			ReduceLevel,
			// Token: 0x04034083 RID: 213123
			MaxLevel
		}

		// Token: 0x0200A870 RID: 43120
		[NullableContext(0)]
		public enum ETweenAnimType
		{
			// Token: 0x04034085 RID: 213125
			In,
			// Token: 0x04034086 RID: 213126
			Out,
			// Token: 0x04034087 RID: 213127
			Break,
			// Token: 0x04034088 RID: 213128
			Red
		}
	}
}
