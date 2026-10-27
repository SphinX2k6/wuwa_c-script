using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004636 RID: 17974
	[NullableContext(1)]
	[Nullable(0)]
	public class UiSequencePlayer
	{
		// Token: 0x0602E575 RID: 189813 RVA: 0x00AB5D14 File Offset: 0x00AB3F14
		public UiSequencePlayer(UUIItem item)
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(item);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.FinishSequenceEvent), false);
			this.LevelSequencePlayer.BindSequenceStartEvent(new TSequenceStartEvent(this.PlaySequenceStartEvent));
		}

		// Token: 0x0602E576 RID: 189814 RVA: 0x00AB5D6D File Offset: 0x00AB3F6D
		[NullableContext(2)]
		private void ClearSequenceMapValue(string key)
		{
			if (key != null)
			{
				this.CurrentSequenceStateMap.Remove(key);
			}
		}

		// Token: 0x0602E577 RID: 189815 RVA: 0x00AB5D7F File Offset: 0x00AB3F7F
		private void AddItemToSequenceMap(string key)
		{
			this.CurrentSequenceStateMap[key] = ESequenceState.Start;
		}

		// Token: 0x0602E578 RID: 189816 RVA: 0x00AB5D8E File Offset: 0x00AB3F8E
		public void BindOnEndSequenceEvent(Action<string> sequencePlayCloseEvent)
		{
			if (this.OnSequenceEndEvent == null)
			{
				this.OnSequenceEndEvent = new List<Action<string>>();
			}
			this.OnSequenceEndEvent.Add(sequencePlayCloseEvent);
		}

		// Token: 0x0602E579 RID: 189817 RVA: 0x00AB5DAF File Offset: 0x00AB3FAF
		public void BindOnStartSequenceEvent(Action<string> sequenceStartEvent)
		{
			if (this.OnSequenceStartEvent == null)
			{
				this.OnSequenceStartEvent = new List<Action<string>>();
			}
			this.OnSequenceStartEvent.Add(sequenceStartEvent);
		}

		// Token: 0x0602E57A RID: 189818 RVA: 0x00AB5DD0 File Offset: 0x00AB3FD0
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

		// Token: 0x0602E57B RID: 189819 RVA: 0x00AB5E28 File Offset: 0x00AB4028
		public bool IsSequenceInPlaying(string sequenceName)
		{
			return this.CurrentSequenceStateMap.ContainsKey(sequenceName) && this.CurrentSequenceStateMap[sequenceName] == ESequenceState.Playing;
		}

		// Token: 0x0602E57C RID: 189820 RVA: 0x00AB5E49 File Offset: 0x00AB4049
		public bool IsSequenceFinish(string sequenceName)
		{
			return !this.CurrentSequenceStateMap.ContainsKey(sequenceName) || this.CurrentSequenceStateMap[sequenceName] == ESequenceState.End;
		}

		// Token: 0x0602E57D RID: 189821 RVA: 0x00AB5E6C File Offset: 0x00AB406C
		public bool IsStartSequenceFinish(string sequenceName)
		{
			ESequenceState esequenceState;
			return !this.CurrentSequenceStateMap.TryGetValue(sequenceName, out esequenceState) || esequenceState > ESequenceState.Start;
		}

		// Token: 0x0602E57E RID: 189822 RVA: 0x00AB5E8F File Offset: 0x00AB408F
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

		// Token: 0x0602E57F RID: 189823 RVA: 0x00AB5EA4 File Offset: 0x00AB40A4
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

		// Token: 0x0602E580 RID: 189824 RVA: 0x00AB5F0C File Offset: 0x00AB410C
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

		// Token: 0x0602E581 RID: 189825 RVA: 0x00AB5F74 File Offset: 0x00AB4174
		public void PlaySequencePurely(string sequenceName, bool blockClick = false, bool isReverse = false)
		{
			this.LevelSequencePlayer.PlaySequencePurely(sequenceName, blockClick, isReverse, null, null, false);
		}

		// Token: 0x0602E582 RID: 189826 RVA: 0x00AB5F9C File Offset: 0x00AB419C
		public void StopPrevSequence(bool needEvent, bool toLastFrame = false)
		{
			string currentSequence = this.LevelSequencePlayer.GetCurrentSequence();
			this.LevelSequencePlayer.StopCurrentSequence(needEvent, toLastFrame);
			this.ClearSequenceMapValue(currentSequence);
		}

		// Token: 0x0602E583 RID: 189827 RVA: 0x00AB5FCC File Offset: 0x00AB41CC
		public void StopCurrentSequenceByName(string sequenceName, bool needEvent, bool toLastFrame = false)
		{
			string currentSequence = this.LevelSequencePlayer.GetCurrentSequence();
			if (currentSequence == sequenceName)
			{
				this.LevelSequencePlayer.StopCurrentSequence(needEvent, toLastFrame);
				this.ClearSequenceMapValue(currentSequence);
			}
		}

		// Token: 0x0602E584 RID: 189828 RVA: 0x00AB6002 File Offset: 0x00AB4202
		public void PlaySequence(string sequenceName, bool blockClick = false, float? playRate = null)
		{
			this.RemoveCurrentRunningSequence();
			this.AddItemToSequenceMap(sequenceName.ToString());
			this.LevelSequencePlayer.PlayLevelSequenceByName(sequenceName.ToString(), blockClick, playRate, false);
		}

		// Token: 0x0602E585 RID: 189829 RVA: 0x00AB602C File Offset: 0x00AB422C
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

		// Token: 0x0602E586 RID: 189830 RVA: 0x00AB609C File Offset: 0x00AB429C
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

		// Token: 0x0602E587 RID: 189831 RVA: 0x00AB6109 File Offset: 0x00AB4309
		public void ReplaySequence(string sequenceName)
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.ReplaySequenceByKey(sequenceName);
		}

		// Token: 0x0602E588 RID: 189832 RVA: 0x00AB611C File Offset: 0x00AB431C
		public void PlayOrReplaySequenceByName(string sequenceName, bool blockClick = false, float? playRate = null)
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayOrReplaySequenceByName(sequenceName, blockClick, playRate);
		}

		// Token: 0x0602E589 RID: 189833 RVA: 0x00AB6134 File Offset: 0x00AB4334
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

		// Token: 0x0602E58A RID: 189834 RVA: 0x00AB6177 File Offset: 0x00AB4377
		public void StopSequenceByKey(string sequenceName, bool needEvent = false, bool toLastFrame = false)
		{
			this.LevelSequencePlayer.StopSequenceByKey(sequenceName, needEvent, toLastFrame);
		}

		// Token: 0x0602E58B RID: 189835 RVA: 0x00AB6188 File Offset: 0x00AB4388
		public void SequencePlayReverseByKey(string sequenceName, bool block)
		{
			this.LevelSequencePlayer.PlaySequencePurely(sequenceName, block, true, null, null, false);
		}

		// Token: 0x0602E58C RID: 189836 RVA: 0x00AB61AE File Offset: 0x00AB43AE
		public void PauseSequence()
		{
			this.LevelSequencePlayer.PauseSequence();
		}

		// Token: 0x0602E58D RID: 189837 RVA: 0x00AB61BB File Offset: 0x00AB43BB
		public void ResumeSequence()
		{
			this.LevelSequencePlayer.ResumeSequence();
		}

		// Token: 0x0602E58E RID: 189838 RVA: 0x00AB61C8 File Offset: 0x00AB43C8
		public void ChangePlaybackDirection(string sequenceName)
		{
			this.LevelSequencePlayer.ChangePlaybackDirection(sequenceName);
		}

		// Token: 0x0602E58F RID: 189839 RVA: 0x00AB61D6 File Offset: 0x00AB43D6
		public void SetActorTag(string sequenceName, FName tag, AActor actor)
		{
			this.LevelSequencePlayer.SetActorTag(sequenceName, tag, actor);
		}

		// Token: 0x0602E590 RID: 189840 RVA: 0x00AB61E6 File Offset: 0x00AB43E6
		public void SetRelativeTransform(string sequenceName, FTransformDouble transform)
		{
			this.LevelSequencePlayer.SetRelativeTransform(sequenceName, transform);
		}

		// Token: 0x0602E591 RID: 189841 RVA: 0x00AB61F5 File Offset: 0x00AB43F5
		public void Clear()
		{
			this.LevelSequencePlayer.Clear();
			this.LevelSequencePlayer = null;
		}

		// Token: 0x0602E592 RID: 189842 RVA: 0x00AB620C File Offset: 0x00AB440C
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

		// Token: 0x0602E593 RID: 189843 RVA: 0x00AB6268 File Offset: 0x00AB4468
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

		// Token: 0x0602E594 RID: 189844 RVA: 0x00AB62C3 File Offset: 0x00AB44C3
		public void LiteStop()
		{
			if (this.LevelSequencePlayer != null && this.LitePlayingSequenceName != null && this.LitePlayingPromise != null)
			{
				this.LevelSequencePlayer.StopSequenceByKey(this.LitePlayingSequenceName.ToString(), false, false);
			}
			this.LitePlayingSequenceName = null;
			this.LitePlayingPromise = null;
		}

		// Token: 0x0602E595 RID: 189845 RVA: 0x00AB6303 File Offset: 0x00AB4503
		public void LiteExit()
		{
			this.LiteStop();
			this.Clear();
		}

		// Token: 0x0602E596 RID: 189846 RVA: 0x00AB6311 File Offset: 0x00AB4511
		public void LiteJumpToEnd(string sequenceName)
		{
			if (this.LevelSequencePlayer != null)
			{
				this.LitePlayAsync(sequenceName, true, false);
				this.LevelSequencePlayer.EndSequenceLastFrame(sequenceName.ToString());
				this.LiteStop();
			}
		}

		// Token: 0x0602E597 RID: 189847 RVA: 0x00AB633C File Offset: 0x00AB453C
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

		// Token: 0x04018D8E RID: 101774
		private readonly Dictionary<string, ESequenceState> CurrentSequenceStateMap = new Dictionary<string, ESequenceState>();

		// Token: 0x04018D8F RID: 101775
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04018D90 RID: 101776
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private List<Action<string>> OnSequenceEndEvent;

		// Token: 0x04018D91 RID: 101777
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private List<Action<string>> OnSequenceStartEvent;

		// Token: 0x04018D92 RID: 101778
		[Nullable(2)]
		private string LitePlayingSequenceName;

		// Token: 0x04018D93 RID: 101779
		[Nullable(2)]
		private CustomPromise<bool> LitePlayingPromise;
	}
}
