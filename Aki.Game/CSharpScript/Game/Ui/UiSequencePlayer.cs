using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003560 RID: 13664
	[NullableContext(1)]
	[Nullable(0)]
	public class UiSequencePlayer
	{
		// Token: 0x06022C99 RID: 142489 RVA: 0x009E2EF0 File Offset: 0x009E10F0
		public UiSequencePlayer(UUIItem item)
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(item);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.FinishSequenceEvent), false);
			this.LevelSequencePlayer.BindSequenceStartEvent(new TSequenceStartEvent(this.PlaySequenceStartEvent));
		}

		// Token: 0x06022C9A RID: 142490 RVA: 0x009E2F49 File Offset: 0x009E1149
		[NullableContext(2)]
		private void ClearSequenceMapValue(string key)
		{
			if (key != null)
			{
				this.CurrentSequenceStateMap.Remove(key);
			}
		}

		// Token: 0x06022C9B RID: 142491 RVA: 0x009E2F5B File Offset: 0x009E115B
		private void AddItemToSequenceMap(string key)
		{
			this.CurrentSequenceStateMap[key] = ESequenceState.Start;
		}

		// Token: 0x06022C9C RID: 142492 RVA: 0x009E2F6A File Offset: 0x009E116A
		public void BindOnEndSequenceEvent(Action<string> sequencePlayCloseEvent)
		{
			if (this.OnSequenceEndEvent == null)
			{
				this.OnSequenceEndEvent = new List<Action<string>>();
			}
			this.OnSequenceEndEvent.Add(sequencePlayCloseEvent);
		}

		// Token: 0x06022C9D RID: 142493 RVA: 0x009E2F8B File Offset: 0x009E118B
		public void BindOnStartSequenceEvent(Action<string> sequenceStartEvent)
		{
			if (this.OnSequenceStartEvent == null)
			{
				this.OnSequenceStartEvent = new List<Action<string>>();
			}
			this.OnSequenceStartEvent.Add(sequenceStartEvent);
		}

		// Token: 0x06022C9E RID: 142494 RVA: 0x009E2FAC File Offset: 0x009E11AC
		public bool IsInSequence()
		{
			bool result = false;
			string[] array = new string[this.CurrentSequenceStateMap.Count];
			this.CurrentSequenceStateMap.Keys.CopyTo(array, 0);
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				if (this.CurrentSequenceStateMap[array[i]] != ESequenceState.End)
				{
					result = true;
					break;
				}
			}
			return result;
		}

		// Token: 0x06022C9F RID: 142495 RVA: 0x009E3004 File Offset: 0x009E1204
		public bool IsSequenceInPlaying(string sequenceName)
		{
			return this.CurrentSequenceStateMap.ContainsKey(sequenceName) && this.CurrentSequenceStateMap[sequenceName] == ESequenceState.Playing;
		}

		// Token: 0x06022CA0 RID: 142496 RVA: 0x009E3025 File Offset: 0x009E1225
		public bool IsSequenceFinish(string sequenceName)
		{
			return !this.CurrentSequenceStateMap.ContainsKey(sequenceName) || this.CurrentSequenceStateMap[sequenceName] == ESequenceState.End;
		}

		// Token: 0x06022CA1 RID: 142497 RVA: 0x009E3048 File Offset: 0x009E1248
		public bool IsStartSequenceFinish(string sequenceName)
		{
			ESequenceState esequenceState;
			return !this.CurrentSequenceStateMap.TryGetValue(sequenceName, out esequenceState) || esequenceState > ESequenceState.Start;
		}

		// Token: 0x06022CA2 RID: 142498 RVA: 0x009E306B File Offset: 0x009E126B
		[NullableContext(2)]
		public string GetCurrentSequence()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return null;
			}
			return levelSequencePlayer.GetCurrentSequence();
		}

		// Token: 0x06022CA3 RID: 142499 RVA: 0x009E3080 File Offset: 0x009E1280
		private void FinishSequenceEvent(string sequenceName)
		{
			this.CurrentSequenceStateMap[sequenceName] = ESequenceState.End;
			if (this.OnSequenceEndEvent != null)
			{
				foreach (Action<string> action in this.OnSequenceEndEvent)
				{
					action(sequenceName);
				}
			}
		}

		// Token: 0x06022CA4 RID: 142500 RVA: 0x009E30E8 File Offset: 0x009E12E8
		private void PlaySequenceStartEvent(string sequenceName)
		{
			this.CurrentSequenceStateMap[sequenceName] = ESequenceState.Playing;
			if (this.OnSequenceStartEvent != null)
			{
				foreach (Action<string> action in this.OnSequenceStartEvent)
				{
					action(sequenceName);
				}
			}
		}

		// Token: 0x06022CA5 RID: 142501 RVA: 0x009E3150 File Offset: 0x009E1350
		public void PlaySequencePurely(string sequenceName, bool blockClick = false, bool isReverse = false)
		{
			this.LevelSequencePlayer.PlaySequencePurely(sequenceName, blockClick, isReverse, null, null, false);
		}

		// Token: 0x06022CA6 RID: 142502 RVA: 0x009E3178 File Offset: 0x009E1378
		public void StopPrevSequence(bool needEvent, bool toLastFrame = false)
		{
			string currentSequence = this.LevelSequencePlayer.GetCurrentSequence();
			this.LevelSequencePlayer.StopCurrentSequence(needEvent, toLastFrame);
			this.ClearSequenceMapValue(currentSequence);
		}

		// Token: 0x06022CA7 RID: 142503 RVA: 0x009E31A8 File Offset: 0x009E13A8
		public void StopCurrentSequenceByName(string sequenceName, bool needEvent, bool toLastFrame = false)
		{
			string currentSequence = this.LevelSequencePlayer.GetCurrentSequence();
			if (currentSequence == sequenceName)
			{
				this.LevelSequencePlayer.StopCurrentSequence(needEvent, toLastFrame);
				this.ClearSequenceMapValue(currentSequence);
			}
		}

		// Token: 0x06022CA8 RID: 142504 RVA: 0x009E31DE File Offset: 0x009E13DE
		public void PlaySequence(string sequenceName, bool blockClick = false, float? playRate = null)
		{
			this.RemoveCurrentRunningSequence();
			this.AddItemToSequenceMap(sequenceName.ToString());
			this.LevelSequencePlayer.PlayLevelSequenceByName(sequenceName.ToString(), blockClick, playRate, false);
		}

		// Token: 0x06022CA9 RID: 142505 RVA: 0x009E3208 File Offset: 0x009E1408
		public UniTask PlaySequenceAsync(string sequenceName, CustomPromise<bool> stopPromise, bool blockClick = false, bool playReverse = false, float? playRate = null)
		{
			UiSequencePlayer.<PlaySequenceAsync>d__20 <PlaySequenceAsync>d__;
			<PlaySequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySequenceAsync>d__.<>4__this = this;
			<PlaySequenceAsync>d__.sequenceName = sequenceName;
			<PlaySequenceAsync>d__.stopPromise = stopPromise;
			<PlaySequenceAsync>d__.blockClick = blockClick;
			<PlaySequenceAsync>d__.playReverse = playReverse;
			<PlaySequenceAsync>d__.playRate = playRate;
			<PlaySequenceAsync>d__.<>1__state = -1;
			<PlaySequenceAsync>d__.<>t__builder.Start<UiSequencePlayer.<PlaySequenceAsync>d__20>(ref <PlaySequenceAsync>d__);
			return <PlaySequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022CAA RID: 142506 RVA: 0x009E3278 File Offset: 0x009E1478
		public UniTask PlaySequenceAsyncNoStopRunning(string sequenceName, CustomPromise<bool> stopPromise, bool blockClick = false, bool playReverse = false, float? playRate = null)
		{
			UiSequencePlayer.<PlaySequenceAsyncNoStopRunning>d__21 <PlaySequenceAsyncNoStopRunning>d__;
			<PlaySequenceAsyncNoStopRunning>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySequenceAsyncNoStopRunning>d__.<>4__this = this;
			<PlaySequenceAsyncNoStopRunning>d__.sequenceName = sequenceName;
			<PlaySequenceAsyncNoStopRunning>d__.stopPromise = stopPromise;
			<PlaySequenceAsyncNoStopRunning>d__.blockClick = blockClick;
			<PlaySequenceAsyncNoStopRunning>d__.playReverse = playReverse;
			<PlaySequenceAsyncNoStopRunning>d__.playRate = playRate;
			<PlaySequenceAsyncNoStopRunning>d__.<>1__state = -1;
			<PlaySequenceAsyncNoStopRunning>d__.<>t__builder.Start<UiSequencePlayer.<PlaySequenceAsyncNoStopRunning>d__21>(ref <PlaySequenceAsyncNoStopRunning>d__);
			return <PlaySequenceAsyncNoStopRunning>d__.<>t__builder.Task;
		}

		// Token: 0x06022CAB RID: 142507 RVA: 0x009E32E5 File Offset: 0x009E14E5
		public void ReplaySequence(string sequenceName)
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.ReplaySequenceByKey(sequenceName);
		}

		// Token: 0x06022CAC RID: 142508 RVA: 0x009E32F8 File Offset: 0x009E14F8
		public void PlayOrReplaySequenceByName(string sequenceName, bool blockClick = false, float? playRate = null)
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayOrReplaySequenceByName(sequenceName, blockClick, playRate);
		}

		// Token: 0x06022CAD RID: 142509 RVA: 0x009E3310 File Offset: 0x009E1510
		private void RemoveCurrentRunningSequence()
		{
			if (this.IsInSequence())
			{
				string[] array = new string[this.CurrentSequenceStateMap.Count];
				this.CurrentSequenceStateMap.Keys.CopyTo(array, 0);
				string key = array[0];
				this.ClearSequenceMapValue(key);
			}
		}

		// Token: 0x06022CAE RID: 142510 RVA: 0x009E3353 File Offset: 0x009E1553
		public void StopSequenceByKey(string sequenceName, bool needEvent = false, bool toLastFrame = false)
		{
			this.LevelSequencePlayer.StopSequenceByKey(sequenceName, needEvent, toLastFrame);
		}

		// Token: 0x06022CAF RID: 142511 RVA: 0x009E3364 File Offset: 0x009E1564
		public void SequencePlayReverseByKey(string sequenceName, bool block)
		{
			this.LevelSequencePlayer.PlaySequencePurely(sequenceName, block, true, null, null, false);
		}

		// Token: 0x06022CB0 RID: 142512 RVA: 0x009E338A File Offset: 0x009E158A
		public void PauseSequence()
		{
			this.LevelSequencePlayer.PauseSequence();
		}

		// Token: 0x06022CB1 RID: 142513 RVA: 0x009E3397 File Offset: 0x009E1597
		public void ResumeSequence()
		{
			this.LevelSequencePlayer.ResumeSequence();
		}

		// Token: 0x06022CB2 RID: 142514 RVA: 0x009E33A4 File Offset: 0x009E15A4
		public void ChangePlaybackDirection(string sequenceName)
		{
			this.LevelSequencePlayer.ChangePlaybackDirection(sequenceName);
		}

		// Token: 0x06022CB3 RID: 142515 RVA: 0x009E33B2 File Offset: 0x009E15B2
		public void SetActorTag(string sequenceName, FName tag, AActor actor)
		{
			this.LevelSequencePlayer.SetActorTag(sequenceName, tag, actor);
		}

		// Token: 0x06022CB4 RID: 142516 RVA: 0x009E33C2 File Offset: 0x009E15C2
		public void SetRelativeTransform(string sequenceName, FTransformDouble transform)
		{
			this.LevelSequencePlayer.SetRelativeTransform(sequenceName, transform);
		}

		// Token: 0x06022CB5 RID: 142517 RVA: 0x009E33D1 File Offset: 0x009E15D1
		public void Clear()
		{
			this.LevelSequencePlayer.Clear();
			this.LevelSequencePlayer = null;
		}

		// Token: 0x06022CB6 RID: 142518 RVA: 0x009E33E8 File Offset: 0x009E15E8
		[NullableContext(0)]
		public UniTask<bool> LitePlayAsync([Nullable(1)] string sequenceName, bool blockClick = false, bool playReverse = false)
		{
			UiSequencePlayer.<LitePlayAsync>d__35 <LitePlayAsync>d__;
			<LitePlayAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<LitePlayAsync>d__.<>4__this = this;
			<LitePlayAsync>d__.sequenceName = sequenceName;
			<LitePlayAsync>d__.blockClick = blockClick;
			<LitePlayAsync>d__.playReverse = playReverse;
			<LitePlayAsync>d__.<>1__state = -1;
			<LitePlayAsync>d__.<>t__builder.Start<UiSequencePlayer.<LitePlayAsync>d__35>(ref <LitePlayAsync>d__);
			return <LitePlayAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022CB7 RID: 142519 RVA: 0x009E3444 File Offset: 0x009E1644
		[NullableContext(0)]
		public UniTask<bool> LiteReplayAsync([Nullable(1)] string sequenceName, bool blockClick = false, bool playReverse = false)
		{
			UiSequencePlayer.<LiteReplayAsync>d__36 <LiteReplayAsync>d__;
			<LiteReplayAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<LiteReplayAsync>d__.<>4__this = this;
			<LiteReplayAsync>d__.sequenceName = sequenceName;
			<LiteReplayAsync>d__.blockClick = blockClick;
			<LiteReplayAsync>d__.playReverse = playReverse;
			<LiteReplayAsync>d__.<>1__state = -1;
			<LiteReplayAsync>d__.<>t__builder.Start<UiSequencePlayer.<LiteReplayAsync>d__36>(ref <LiteReplayAsync>d__);
			return <LiteReplayAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022CB8 RID: 142520 RVA: 0x009E349F File Offset: 0x009E169F
		public void LiteStop()
		{
			if (this.LevelSequencePlayer != null && this.LitePlayingSequenceName != null && this.LitePlayingPromise != null)
			{
				this.LevelSequencePlayer.StopSequenceByKey(this.LitePlayingSequenceName.ToString(), false, false);
			}
			this.LitePlayingSequenceName = null;
			this.LitePlayingPromise = null;
		}

		// Token: 0x06022CB9 RID: 142521 RVA: 0x009E34DF File Offset: 0x009E16DF
		public void LiteExit()
		{
			this.LiteStop();
			this.Clear();
		}

		// Token: 0x06022CBA RID: 142522 RVA: 0x009E34ED File Offset: 0x009E16ED
		public void LiteJumpToEnd(string sequenceName)
		{
			if (this.LevelSequencePlayer != null)
			{
				this.LitePlayAsync(sequenceName, true, false);
				this.LevelSequencePlayer.EndSequenceLastFrame(sequenceName.ToString());
				this.LiteStop();
			}
		}

		// Token: 0x06022CBB RID: 142523 RVA: 0x009E3518 File Offset: 0x009E1718
		[NullableContext(0)]
		public UniTask<bool> LiteWaitFor([Nullable(1)] string sequenceName)
		{
			UiSequencePlayer.<LiteWaitFor>d__40 <LiteWaitFor>d__;
			<LiteWaitFor>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<LiteWaitFor>d__.<>4__this = this;
			<LiteWaitFor>d__.sequenceName = sequenceName;
			<LiteWaitFor>d__.<>1__state = -1;
			<LiteWaitFor>d__.<>t__builder.Start<UiSequencePlayer.<LiteWaitFor>d__40>(ref <LiteWaitFor>d__);
			return <LiteWaitFor>d__.<>t__builder.Task;
		}

		// Token: 0x040133DD RID: 78813
		private readonly Dictionary<string, ESequenceState> CurrentSequenceStateMap = new Dictionary<string, ESequenceState>();

		// Token: 0x040133DE RID: 78814
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x040133DF RID: 78815
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private List<Action<string>> OnSequenceEndEvent;

		// Token: 0x040133E0 RID: 78816
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private List<Action<string>> OnSequenceStartEvent;

		// Token: 0x040133E1 RID: 78817
		[Nullable(2)]
		private string LitePlayingSequenceName;

		// Token: 0x040133E2 RID: 78818
		[Nullable(2)]
		private CustomPromise<bool> LitePlayingPromise;
	}
}
