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
	// Token: 0x020067E2 RID: 26594
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBackpackFight : UiPanelBase
	{
		// Token: 0x170096F8 RID: 38648
		// (get) Token: 0x06042398 RID: 271256 RVA: 0x01011696 File Offset: 0x0100F896
		[Nullable(2)]
		private UUIButtonComponent StartFightBtn
		{
			[NullableContext(2)]
			get
			{
				return base.GetButton(0);
			}
		}

		// Token: 0x06042399 RID: 271257 RVA: 0x010116A0 File Offset: 0x0100F8A0
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

		// Token: 0x0604239A RID: 271258 RVA: 0x01011850 File Offset: 0x0100FA50
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

		// Token: 0x0604239B RID: 271259 RVA: 0x010118ED File Offset: 0x0100FAED
		protected override void OnBeforeDestroy()
		{
			this.UnbindGlobalInput();
			this.StopMatchingTick();
			this.ClearSequencePlayer();
			this.UnbindEvents();
		}

		// Token: 0x0604239C RID: 271260 RVA: 0x01011907 File Offset: 0x0100FB07
		public void ClickFight()
		{
			this.OnClickFight();
		}

		// Token: 0x0604239D RID: 271261 RVA: 0x0101190F File Offset: 0x0100FB0F
		public bool IsFightBtnInteractive()
		{
			return this.IsExternalInteractive && !this.IsOverWeight;
		}

		// Token: 0x0604239E RID: 271262 RVA: 0x01011924 File Offset: 0x0100FB24
		private void BindEvents()
		{
			EventSystem.Instance.Add(EEventName.OnDangoBrawlCostChanged, new Action(this.OnCostChanged));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlLoseCountChanged, new Action(this.OnLoseCountChanged));
		}

		// Token: 0x0604239F RID: 271263 RVA: 0x0101195E File Offset: 0x0100FB5E
		private void UnbindEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlCostChanged, new Action(this.OnCostChanged));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlLoseCountChanged, new Action(this.OnLoseCountChanged));
		}

		// Token: 0x060423A0 RID: 271264 RVA: 0x01011998 File Offset: 0x0100FB98
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

		// Token: 0x060423A1 RID: 271265 RVA: 0x010119F0 File Offset: 0x0100FBF0
		private void ClearSequencePlayer()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x060423A2 RID: 271266 RVA: 0x01011A0A File Offset: 0x0100FC0A
		private void BindGlobalInput()
		{
			this.MatchingBoundFrame = UKismetSystemLibrary.GetFrameCount();
			EventSystem.Instance.Add<bool, FKey>(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnGlobalAnyKey));
			InputDistributeController.Instance.BindTouch(0, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnGlobalTouchAction));
		}

		// Token: 0x060423A3 RID: 271267 RVA: 0x01011A4A File Offset: 0x0100FC4A
		private void UnbindGlobalInput()
		{
			this.MatchingBoundFrame = -1L;
			EventSystem.Instance.Remove(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnGlobalAnyKey));
			InputDistributeController.Instance.UnBindTouch(0, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnGlobalTouchAction));
		}

		// Token: 0x060423A4 RID: 271268 RVA: 0x01011A88 File Offset: 0x0100FC88
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

		// Token: 0x060423A5 RID: 271269 RVA: 0x01011ABC File Offset: 0x0100FCBC
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

		// Token: 0x060423A6 RID: 271270 RVA: 0x01011B08 File Offset: 0x0100FD08
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

		// Token: 0x060423A7 RID: 271271 RVA: 0x01011B24 File Offset: 0x0100FD24
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

		// Token: 0x060423A8 RID: 271272 RVA: 0x01011B70 File Offset: 0x0100FD70
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

		// Token: 0x060423A9 RID: 271273 RVA: 0x01011C00 File Offset: 0x0100FE00
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

		// Token: 0x060423AA RID: 271274 RVA: 0x01011C43 File Offset: 0x0100FE43
		private void UpdateWatingState()
		{
			base.GetItem(1).SetUIActive(true);
		}

		// Token: 0x060423AB RID: 271275 RVA: 0x01011C52 File Offset: 0x0100FE52
		private void UpdateMatchingState()
		{
			base.GetItem(2).SetUIActive(true);
			this.SetMatchinProgress(0f);
		}

		// Token: 0x060423AC RID: 271276 RVA: 0x01011C6C File Offset: 0x0100FE6C
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

		// Token: 0x060423AD RID: 271277 RVA: 0x01011E14 File Offset: 0x01010014
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

		// Token: 0x060423AE RID: 271278 RVA: 0x01011E6E File Offset: 0x0101006E
		public void SetFightBtnInteractive(bool interactive)
		{
			this.IsExternalInteractive = interactive;
			this.RefreshFightBtnInteractive();
		}

		// Token: 0x060423AF RID: 271279 RVA: 0x01011E80 File Offset: 0x01010080
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

		// Token: 0x060423B0 RID: 271280 RVA: 0x01011EB8 File Offset: 0x010100B8
		private UniTask PlayMatchingProgressAsync()
		{
			DangoBrawlBackpackFight.<PlayMatchingProgressAsync>d__40 <PlayMatchingProgressAsync>d__;
			<PlayMatchingProgressAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayMatchingProgressAsync>d__.<>4__this = this;
			<PlayMatchingProgressAsync>d__.<>1__state = -1;
			<PlayMatchingProgressAsync>d__.<>t__builder.Start<DangoBrawlBackpackFight.<PlayMatchingProgressAsync>d__40>(ref <PlayMatchingProgressAsync>d__);
			return <PlayMatchingProgressAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060423B1 RID: 271281 RVA: 0x01011EFB File Offset: 0x010100FB
		private void StopMatchingTick()
		{
			if (this.MatchingTickId != -1)
			{
				TickSystem.Instance.Remove(this.MatchingTickId);
				this.MatchingTickId = -1;
			}
		}

		// Token: 0x060423B2 RID: 271282 RVA: 0x01011F20 File Offset: 0x01010120
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

		// Token: 0x060423B3 RID: 271283 RVA: 0x01011F98 File Offset: 0x01010198
		private void OnStartSequenceEvent(string sequenceStartEvent)
		{
		}

		// Token: 0x060423B4 RID: 271284 RVA: 0x01011F9A File Offset: 0x0101019A
		private void OnEndSequenceEvent(string sequenceStartEvent)
		{
			if (sequenceStartEvent == "Matching")
			{
				this.CompleteMatchingSeq();
			}
		}

		// Token: 0x060423B5 RID: 271285 RVA: 0x01011FB0 File Offset: 0x010101B0
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

		// Token: 0x060423B6 RID: 271286 RVA: 0x01012002 File Offset: 0x01010202
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

		// Token: 0x060423B7 RID: 271287 RVA: 0x0101201C File Offset: 0x0101021C
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

		// Token: 0x060423B8 RID: 271288 RVA: 0x0101203C File Offset: 0x0101023C
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

		// Token: 0x060423B9 RID: 271289 RVA: 0x010120A4 File Offset: 0x010102A4
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

		// Token: 0x060423BA RID: 271290 RVA: 0x010120EF File Offset: 0x010102EF
		private void OnCostChanged()
		{
			this.RefreshFightEnable();
		}

		// Token: 0x060423BB RID: 271291 RVA: 0x010120F7 File Offset: 0x010102F7
		private void OnLoseCountChanged()
		{
			this.RefreshView();
		}

		// Token: 0x040228FB RID: 141563
		private ActivityDangoBrawlData ActData;

		// Token: 0x040228FC RID: 141564
		private EDangoBrawlFightState State;

		// Token: 0x040228FD RID: 141565
		private int WinCount = -1;

		// Token: 0x040228FE RID: 141566
		private int LoseCount = -1;

		// Token: 0x040228FF RID: 141567
		private int MatchingTickId = -1;

		// Token: 0x04022900 RID: 141568
		private float MatchingElapsedMs;

		// Token: 0x04022901 RID: 141569
		private bool MatchingCanceled;

		// Token: 0x04022902 RID: 141570
		private long MatchingBoundFrame = -1L;

		// Token: 0x04022903 RID: 141571
		[Nullable(2)]
		private CustomPromise MatchingPromise;

		// Token: 0x04022904 RID: 141572
		[Nullable(2)]
		private CustomPromise MatchingSeqPromise;

		// Token: 0x04022905 RID: 141573
		private float MatchingDurationMs = 10000f;

		// Token: 0x04022906 RID: 141574
		private bool IsExternalInteractive = true;

		// Token: 0x04022907 RID: 141575
		private bool IsOverWeight;

		// Token: 0x04022908 RID: 141576
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0200C8F6 RID: 51446
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403CAAF RID: 248495
			BtnFight,
			// Token: 0x0403CAB0 RID: 248496
			PnlStart,
			// Token: 0x0403CAB1 RID: 248497
			PnlMatching,
			// Token: 0x0403CAB2 RID: 248498
			SprMatchingBar,
			// Token: 0x0403CAB3 RID: 248499
			PnlMatchingRotate,
			// Token: 0x0403CAB4 RID: 248500
			TxtLeftCost,
			// Token: 0x0403CAB5 RID: 248501
			TxtRightCost,
			// Token: 0x0403CAB6 RID: 248502
			SprDark,
			// Token: 0x0403CAB7 RID: 248503
			ItemIcon,
			// Token: 0x0403CAB8 RID: 248504
			ItemIconAddtional
		}
	}
}
