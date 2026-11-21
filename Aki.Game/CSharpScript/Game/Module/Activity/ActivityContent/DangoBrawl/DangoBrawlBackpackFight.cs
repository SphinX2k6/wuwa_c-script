using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005732 RID: 22322
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBackpackFight : UiPanelBase
	{
		// Token: 0x17006A39 RID: 27193
		// (get) Token: 0x06036EEE RID: 225006 RVA: 0x00F52B2E File Offset: 0x00F50D2E
		[Nullable(2)]
		private UUIButtonComponent StartFightBtn
		{
			[NullableContext(2)]
			get
			{
				return base.GetButton(0);
			}
		}

		// Token: 0x06036EEF RID: 225007 RVA: 0x00F52B38 File Offset: 0x00F50D38
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickFight));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06036EF0 RID: 225008 RVA: 0x00F52CE8 File Offset: 0x00F50EE8
		protected override void OnStart()
		{
			ActivityDangoBrawlData activityDangoBrawlData = this.OpenParam as ActivityDangoBrawlData;
			if (activityDangoBrawlData == null)
			{
				return;
			}
			this.ActData = activityDangoBrawlData;
			DangoBrawlActivity? dangoBrawlActivity;
			int? num = (DangoBrawlConfig.Instance.GetActivityConfigById(activityDangoBrawlData.Id) != null) ? new int?(dangoBrawlActivity.GetValueOrDefault().StartFightDuringTime) : null;
			this.MatchingDurationMs = ((num != null) ? ((float)num.GetValueOrDefault()) : this.MatchingDurationMs);
			this.CreateSequencePlayer();
			this.SetState(EDangoBrawlFightState.Default);
			this.RefreshView();
			this.RefreshFightEnable();
			this.BindEvents();
		}

		// Token: 0x06036EF1 RID: 225009 RVA: 0x00F52D85 File Offset: 0x00F50F85
		protected override void OnBeforeDestroy()
		{
			this.UnbindGlobalInput();
			this.StopMatchingTick();
			this.ClearSequencePlayer();
			this.UnbindEvents();
		}

		// Token: 0x06036EF2 RID: 225010 RVA: 0x00F52D9F File Offset: 0x00F50F9F
		public void ClickFight()
		{
			this.OnClickFight();
		}

		// Token: 0x06036EF3 RID: 225011 RVA: 0x00F52DA7 File Offset: 0x00F50FA7
		public bool IsFightBtnInteractive()
		{
			return this.IsExternalInteractive && !this.IsOverWeight;
		}

		// Token: 0x06036EF4 RID: 225012 RVA: 0x00F52DBC File Offset: 0x00F50FBC
		private void BindEvents()
		{
			EventSystem.Instance.Add(EEventName.OnDangoBrawlCostChanged, new Action(this.OnCostChanged));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlLoseCountChanged, new Action(this.OnLoseCountChanged));
		}

		// Token: 0x06036EF5 RID: 225013 RVA: 0x00F52DF6 File Offset: 0x00F50FF6
		private void UnbindEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlCostChanged, new Action(this.OnCostChanged));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlLoseCountChanged, new Action(this.OnLoseCountChanged));
		}

		// Token: 0x06036EF6 RID: 225014 RVA: 0x00F52E30 File Offset: 0x00F51030
		private void CreateSequencePlayer()
		{
			this.ClearSequencePlayer();
			UUIItem rootItem = base.GetRootItem();
			if (rootItem == null)
			{
				return;
			}
			this.SequencePlayer = new UiSequencePlayer(rootItem);
			this.SequencePlayer.BindOnStartSequenceEvent(new Action<string>(this.OnStartSequenceEvent));
			this.SequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.OnEndSequenceEvent));
		}

		// Token: 0x06036EF7 RID: 225015 RVA: 0x00F52E88 File Offset: 0x00F51088
		private void ClearSequencePlayer()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x06036EF8 RID: 225016 RVA: 0x00F52EA2 File Offset: 0x00F510A2
		private void BindGlobalInput()
		{
			this.MatchingBoundFrame = UKismetSystemLibrary.GetFrameCount();
			EventSystem.Instance.Add<bool, FKey>(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnGlobalAnyKey));
			InputDistributeController.Instance.BindTouch(0, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnGlobalTouchAction));
		}

		// Token: 0x06036EF9 RID: 225017 RVA: 0x00F52EE2 File Offset: 0x00F510E2
		private void UnbindGlobalInput()
		{
			this.MatchingBoundFrame = -1L;
			EventSystem.Instance.Remove(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnGlobalAnyKey));
			InputDistributeController.Instance.UnBindTouch(0, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnGlobalTouchAction));
		}

		// Token: 0x06036EFA RID: 225018 RVA: 0x00F52F20 File Offset: 0x00F51120
		private void TryCancelMatchingByHit()
		{
			if (this.State != EDangoBrawlFightState.Matching)
			{
				return;
			}
			UUIItem nowHitComponent = LguiEventSystemManager.Instance.GetNowHitComponent();
			if (this.IsHitOnFightButton(nowHitComponent))
			{
				return;
			}
			this.CancelMatching();
		}

		// Token: 0x06036EFB RID: 225019 RVA: 0x00F52F54 File Offset: 0x00F51154
		private void CancelMatching()
		{
			if (this.State != EDangoBrawlFightState.Matching)
			{
				return;
			}
			this.MatchingCanceled = true;
			this.StopMatchingTick();
			this.MatchingElapsedMs = 0f;
			this.SetState(EDangoBrawlFightState.Default);
			this.CompleteMatchingSeq();
			CustomPromise matchingPromise = this.MatchingPromise;
			if (matchingPromise == null)
			{
				return;
			}
			matchingPromise.SetResult();
		}

		// Token: 0x06036EFC RID: 225020 RVA: 0x00F52FA0 File Offset: 0x00F511A0
		private void CompleteMatchingSeq()
		{
			CustomPromise matchingSeqPromise = this.MatchingSeqPromise;
			this.MatchingSeqPromise = null;
			if (matchingSeqPromise == null)
			{
				return;
			}
			matchingSeqPromise.SetResult();
		}

		// Token: 0x06036EFD RID: 225021 RVA: 0x00F52FBC File Offset: 0x00F511BC
		[NullableContext(2)]
		private bool IsHitOnFightButton(UUIItem hit)
		{
			if (hit == null)
			{
				return false;
			}
			UUIButtonComponent startFightBtn = this.StartFightBtn;
			UUIItem uuiitem = (startFightBtn != null) ? startFightBtn.GetRootComponent() : null;
			if (uuiitem == null)
			{
				return false;
			}
			UUIItem uuiitem2 = hit;
			int num = 0;
			while (uuiitem2 != null && num < 32)
			{
				if (uuiitem2 == uuiitem)
				{
					return true;
				}
				uuiitem2 = uuiitem2.GetParentAsUIItem();
				num++;
			}
			return false;
		}

		// Token: 0x06036EFE RID: 225022 RVA: 0x00F53008 File Offset: 0x00F51208
		private void SetState(EDangoBrawlFightState val)
		{
			EDangoBrawlFightState state = this.State;
			this.State = val;
			if (state != EDangoBrawlFightState.Matching && val == EDangoBrawlFightState.Matching)
			{
				this.BindGlobalInput();
				this.MatchingSeqPromise = new CustomPromise();
				UiSequencePlayer sequencePlayer = this.SequencePlayer;
				if (sequencePlayer != null)
				{
					sequencePlayer.PlaySequencePurely("Matching", false, false);
				}
			}
			else if (state == EDangoBrawlFightState.Matching && val != EDangoBrawlFightState.Matching)
			{
				this.UnbindGlobalInput();
				if (val == EDangoBrawlFightState.Default)
				{
					UiSequencePlayer sequencePlayer2 = this.SequencePlayer;
					if (sequencePlayer2 != null)
					{
						sequencePlayer2.PlaySequencePurely("Return", false, false);
					}
				}
			}
			this.UpdateStateView();
			EventSystem.Instance.Emit<EDangoBrawlFightState, EDangoBrawlFightState>(EEventName.OnDangoBrawlFightStateModify, val, state);
		}

		// Token: 0x06036EFF RID: 225023 RVA: 0x00F53098 File Offset: 0x00F51298
		private void UpdateStateView()
		{
			base.GetItem(1).SetUIActive(false);
			base.GetItem(2).SetUIActive(false);
			EDangoBrawlFightState state = this.State;
			if (state == EDangoBrawlFightState.Default)
			{
				this.UpdateWatingState();
				return;
			}
			if (state != EDangoBrawlFightState.Matching)
			{
				return;
			}
			this.UpdateMatchingState();
		}

		// Token: 0x06036F00 RID: 225024 RVA: 0x00F530DB File Offset: 0x00F512DB
		private void UpdateWatingState()
		{
			base.GetItem(1).SetUIActive(true);
		}

		// Token: 0x06036F01 RID: 225025 RVA: 0x00F530EA File Offset: 0x00F512EA
		private void UpdateMatchingState()
		{
			base.GetItem(2).SetUIActive(true);
			this.SetMatchinProgress(0f);
		}

		// Token: 0x06036F02 RID: 225026 RVA: 0x00F53104 File Offset: 0x00F51304
		private void RefreshView()
		{
			DangoBrawlInstBaseNotify instBase = this.ActData.InstBase;
			if (instBase == null)
			{
				return;
			}
			DangoBrawlChallenge? challengeConfigById = DangoBrawlConfig.Instance.GetChallengeConfigById(instBase.ChallengeId);
			if (challengeConfigById == null)
			{
				return;
			}
			int winCount = instBase.WinCount;
			int loseCount = instBase.LoseCount;
			int winCount2 = challengeConfigById.Value.WinCount;
			int additionRound = challengeConfigById.Value.AdditionRound;
			int hpCount = challengeConfigById.Value.HpCount;
			bool flag = winCount >= winCount2 && additionRound > 0;
			UUIItem item = base.GetItem(8);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			UUIItem item2 = base.GetItem(9);
			if (item2 != null)
			{
				item2.SetUIActive(flag);
			}
			UUIText text = base.GetText(5);
			if (text != null)
			{
				string newText;
				if (!flag)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
					defaultInterpolatedStringHandler.AppendFormatted<int>(winCount);
					defaultInterpolatedStringHandler.AppendLiteral("/");
					defaultInterpolatedStringHandler.AppendFormatted<int>(winCount2);
					newText = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
					defaultInterpolatedStringHandler.AppendFormatted<int>(winCount - winCount2);
					defaultInterpolatedStringHandler.AppendLiteral("/");
					defaultInterpolatedStringHandler.AppendFormatted<int>(additionRound);
					newText = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				text.SetText(newText, true);
			}
			UUIText text2 = base.GetText(6);
			if (text2 != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(hpCount - loseCount);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(hpCount);
				text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			if (this.LoseCount >= 0 && this.LoseCount > loseCount)
			{
				UiSequencePlayer sequencePlayer = this.SequencePlayer;
				if (sequencePlayer != null)
				{
					sequencePlayer.PlaySequencePurely("HeartUp", false, false);
				}
			}
			this.WinCount = winCount;
			this.LoseCount = loseCount;
		}

		// Token: 0x06036F03 RID: 225027 RVA: 0x00F532AC File Offset: 0x00F514AC
		private void SetMatchinProgress(float val)
		{
			float num = 0.166f + 0.668f * val;
			base.GetSprite(3).SetFillAmount(num);
			float inYaw = (1f - num) * 360f;
			UUIItem item = base.GetItem(4);
			if (item == null)
			{
				return;
			}
			FRotator frotator = new FRotator(0f, inYaw, 0f);
			item.SetUIRelativeRotation(frotator);
		}

		// Token: 0x06036F04 RID: 225028 RVA: 0x00F53306 File Offset: 0x00F51506
		public void SetFightBtnInteractive(bool interactive)
		{
			this.IsExternalInteractive = interactive;
			this.RefreshFightBtnInteractive();
		}

		// Token: 0x06036F05 RID: 225029 RVA: 0x00F53318 File Offset: 0x00F51518
		private void RefreshFightBtnInteractive()
		{
			bool flag = this.IsExternalInteractive && !this.IsOverWeight;
			UUISprite sprite = base.GetSprite(7);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(!flag);
		}

		// Token: 0x06036F06 RID: 225030 RVA: 0x00F53350 File Offset: 0x00F51550
		private UniTask PlayMatchingProgressAsync()
		{
			DangoBrawlBackpackFight.<PlayMatchingProgressAsync>d__40 <PlayMatchingProgressAsync>d__;
			<PlayMatchingProgressAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayMatchingProgressAsync>d__.<>4__this = this;
			<PlayMatchingProgressAsync>d__.<>1__state = -1;
			<PlayMatchingProgressAsync>d__.<>t__builder.Start<DangoBrawlBackpackFight.<PlayMatchingProgressAsync>d__40>(ref <PlayMatchingProgressAsync>d__);
			return <PlayMatchingProgressAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036F07 RID: 225031 RVA: 0x00F53393 File Offset: 0x00F51593
		private void StopMatchingTick()
		{
			if (this.MatchingTickId != -1)
			{
				TickSystem.Instance.Remove(this.MatchingTickId);
				this.MatchingTickId = -1;
			}
		}

		// Token: 0x06036F08 RID: 225032 RVA: 0x00F533B8 File Offset: 0x00F515B8
		private void RefreshFightEnable()
		{
			UUIButtonComponent startFightBtn = this.StartFightBtn;
			if (startFightBtn != null)
			{
				startFightBtn.SetSelfInteractive(true);
			}
			DangoBrawlDataController dataController = DangoBrawlModel.Instance.GetDataController();
			int num = (dataController != null) ? dataController.GetViewCost() : 0;
			DangoBrawlFighterServerData selfFighter = this.ActData.FightersServerData.GetSelfFighter();
			int num2 = (selfFighter != null) ? selfFighter.Cost : 0;
			bool flag = num > num2;
			UUIButtonComponent startFightBtn2 = this.StartFightBtn;
			if (startFightBtn2 != null)
			{
				startFightBtn2.SetEnable(!flag);
			}
			this.IsOverWeight = flag;
			this.RefreshFightBtnInteractive();
		}

		// Token: 0x06036F09 RID: 225033 RVA: 0x00F53430 File Offset: 0x00F51630
		private void OnStartSequenceEvent(string sequenceStartEvent)
		{
		}

		// Token: 0x06036F0A RID: 225034 RVA: 0x00F53432 File Offset: 0x00F51632
		private void OnEndSequenceEvent(string sequenceStartEvent)
		{
			if (sequenceStartEvent == "Matching")
			{
				this.CompleteMatchingSeq();
			}
		}

		// Token: 0x06036F0B RID: 225035 RVA: 0x00F53448 File Offset: 0x00F51648
		private void OnMatchingTick(float deltaMs, CustomPromise promise)
		{
			this.MatchingElapsedMs += deltaMs;
			float num = this.MatchingElapsedMs / this.MatchingDurationMs;
			if (num >= 1f)
			{
				num = 1f;
				this.SetMatchinProgress(num);
				this.StopMatchingTick();
				promise.SetResult();
				return;
			}
			this.SetMatchinProgress(num);
		}

		// Token: 0x06036F0C RID: 225036 RVA: 0x00F5349A File Offset: 0x00F5169A
		private void OnGlobalAnyKey(bool bPress, FKey key)
		{
			if (!bPress)
			{
				return;
			}
			if (UKismetSystemLibrary.GetFrameCount() == this.MatchingBoundFrame)
			{
				return;
			}
			this.TryCancelMatchingByHit();
		}

		// Token: 0x06036F0D RID: 225037 RVA: 0x00F534B4 File Offset: 0x00F516B4
		private void OnGlobalTouchAction(string _, InputDistributeDefine.ITouchData touchData, InputIdentification __)
		{
			if (touchData.TouchType != InputDistributeDefine.ETouchType.TouchEnd)
			{
				return;
			}
			if (UKismetSystemLibrary.GetFrameCount() == this.MatchingBoundFrame)
			{
				return;
			}
			this.TryCancelMatchingByHit();
		}

		// Token: 0x06036F0E RID: 225038 RVA: 0x00F534D4 File Offset: 0x00F516D4
		private void OnClickFight()
		{
			if (this.State == EDangoBrawlFightState.Matching)
			{
				this.CancelMatching();
				return;
			}
			if (DangoBrawlViewManager.TryBlockIfHolding(null) || DangoBrawlViewManager.TryBlockIfLayerMode(true) || DangoBrawlViewManager.TryBlockIfThreeChoose(true) || DangoBrawlViewManager.TryBlockIfOverWeight(true) || DangoBrawlViewManager.TryBlockIfLayerMode(true))
			{
				return;
			}
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			this.OnClickFightAsync(battleManager).Forget();
		}

		// Token: 0x06036F0F RID: 225039 RVA: 0x00F5353C File Offset: 0x00F5173C
		private UniTask OnClickFightAsync(DangoBrawlBattleManager manager)
		{
			DangoBrawlBackpackFight.<OnClickFightAsync>d__49 <OnClickFightAsync>d__;
			<OnClickFightAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnClickFightAsync>d__.<>4__this = this;
			<OnClickFightAsync>d__.manager = manager;
			<OnClickFightAsync>d__.<>1__state = -1;
			<OnClickFightAsync>d__.<>t__builder.Start<DangoBrawlBackpackFight.<OnClickFightAsync>d__49>(ref <OnClickFightAsync>d__);
			return <OnClickFightAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036F10 RID: 225040 RVA: 0x00F53587 File Offset: 0x00F51787
		private void OnCostChanged()
		{
			this.RefreshFightEnable();
		}

		// Token: 0x06036F11 RID: 225041 RVA: 0x00F5358F File Offset: 0x00F5178F
		private void OnLoseCountChanged()
		{
			this.RefreshView();
		}

		// Token: 0x0401D158 RID: 119128
		private ActivityDangoBrawlData ActData;

		// Token: 0x0401D159 RID: 119129
		private EDangoBrawlFightState State;

		// Token: 0x0401D15A RID: 119130
		private int WinCount = -1;

		// Token: 0x0401D15B RID: 119131
		private int LoseCount = -1;

		// Token: 0x0401D15C RID: 119132
		private int MatchingTickId = -1;

		// Token: 0x0401D15D RID: 119133
		private float MatchingElapsedMs;

		// Token: 0x0401D15E RID: 119134
		private bool MatchingCanceled;

		// Token: 0x0401D15F RID: 119135
		private long MatchingBoundFrame = -1L;

		// Token: 0x0401D160 RID: 119136
		[Nullable(2)]
		private CustomPromise MatchingPromise;

		// Token: 0x0401D161 RID: 119137
		[Nullable(2)]
		private CustomPromise MatchingSeqPromise;

		// Token: 0x0401D162 RID: 119138
		private float MatchingDurationMs = 10000f;

		// Token: 0x0401D163 RID: 119139
		private bool IsExternalInteractive = true;

		// Token: 0x0401D164 RID: 119140
		private bool IsOverWeight;

		// Token: 0x0401D165 RID: 119141
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0200B2C6 RID: 45766
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x040373A4 RID: 226212
			BtnFight,
			// Token: 0x040373A5 RID: 226213
			PnlStart,
			// Token: 0x040373A6 RID: 226214
			PnlMatching,
			// Token: 0x040373A7 RID: 226215
			SprMatchingBar,
			// Token: 0x040373A8 RID: 226216
			PnlMatchingRotate,
			// Token: 0x040373A9 RID: 226217
			TxtLeftCost,
			// Token: 0x040373AA RID: 226218
			TxtRightCost,
			// Token: 0x040373AB RID: 226219
			SprDark,
			// Token: 0x040373AC RID: 226220
			ItemIcon,
			// Token: 0x040373AD RID: 226221
			ItemIconAddtional
		}
	}
}
