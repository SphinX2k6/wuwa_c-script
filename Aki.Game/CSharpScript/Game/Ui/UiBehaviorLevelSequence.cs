using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004642 RID: 17986
	[NullableContext(1)]
	[Nullable(0)]
	public class UiBehaviorLevelSequence : IUiBehavior
	{
		// Token: 0x170075FB RID: 30203
		// (get) Token: 0x0602E674 RID: 190068 RVA: 0x00AB9338 File Offset: 0x00AB7538
		// (set) Token: 0x0602E675 RID: 190069 RVA: 0x00AB9340 File Offset: 0x00AB7540
		public string StartSequenceName
		{
			get
			{
				return this.StartSequenceNameInternal;
			}
			set
			{
				this.StartSequenceNameInternal = value;
			}
		}

		// Token: 0x170075FC RID: 30204
		// (get) Token: 0x0602E676 RID: 190070 RVA: 0x00AB9349 File Offset: 0x00AB7549
		// (set) Token: 0x0602E677 RID: 190071 RVA: 0x00AB9351 File Offset: 0x00AB7551
		public string CloseSequenceName
		{
			get
			{
				return this.CloseSequenceNameInternal;
			}
			set
			{
				this.CloseSequenceNameInternal = value;
			}
		}

		// Token: 0x170075FD RID: 30205
		// (get) Token: 0x0602E678 RID: 190072 RVA: 0x00AB935A File Offset: 0x00AB755A
		// (set) Token: 0x0602E679 RID: 190073 RVA: 0x00AB9362 File Offset: 0x00AB7562
		public string ShowSequenceName
		{
			get
			{
				return this.ShowSequenceNameInternal;
			}
			set
			{
				this.ShowSequenceNameInternal = value;
			}
		}

		// Token: 0x170075FE RID: 30206
		// (get) Token: 0x0602E67A RID: 190074 RVA: 0x00AB936B File Offset: 0x00AB756B
		// (set) Token: 0x0602E67B RID: 190075 RVA: 0x00AB9373 File Offset: 0x00AB7573
		public string HideSequenceName
		{
			get
			{
				return this.HideSequenceNameInternal;
			}
			set
			{
				this.HideSequenceNameInternal = value;
			}
		}

		// Token: 0x0602E67C RID: 190076 RVA: 0x00AB937C File Offset: 0x00AB757C
		public UiBehaviorLevelSequence(UiPanelBase owner)
		{
			this.Owner = owner;
		}

		// Token: 0x0602E67D RID: 190077 RVA: 0x00AB93E3 File Offset: 0x00AB75E3
		public UniTask OnUiCreateAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0602E67E RID: 190078 RVA: 0x00AB93EC File Offset: 0x00AB75EC
		public void OnAfterUiStart()
		{
			this.UiSequencePlayer = new UiSequencePlayer(this.Owner.GetRootItem());
			this.UiSequencePlayer.BindOnStartSequenceEvent(new Action<string>(this.OnSequenceStart));
			this.UiSequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.OnSequenceEnd));
		}

		// Token: 0x0602E67F RID: 190079 RVA: 0x00AB9440 File Offset: 0x00AB7640
		private void OnSequenceStart(string sequenceName)
		{
			HashSet<Action<string>> hashSet;
			if (this.StartEventMap.TryGetValue(sequenceName, out hashSet))
			{
				foreach (Action<string> action in hashSet)
				{
					if (action != null)
					{
						action(sequenceName);
					}
				}
			}
		}

		// Token: 0x0602E680 RID: 190080 RVA: 0x00AB94A4 File Offset: 0x00AB76A4
		private void OnSequenceEnd(string sequenceName)
		{
			HashSet<Action<string>> hashSet;
			if (this.EndEventMap.TryGetValue(sequenceName, out hashSet))
			{
				foreach (Action<string> action in hashSet)
				{
					if (action != null)
					{
						action(sequenceName);
					}
				}
			}
		}

		// Token: 0x0602E681 RID: 190081 RVA: 0x00AB9508 File Offset: 0x00AB7708
		public bool IsInSequence()
		{
			return this.UiSequencePlayer.IsInSequence();
		}

		// Token: 0x0602E682 RID: 190082 RVA: 0x00AB9515 File Offset: 0x00AB7715
		public bool HasSequenceNameInPlaying(string sequenceName)
		{
			UiSequencePlayer uiSequencePlayer = this.UiSequencePlayer;
			return uiSequencePlayer != null && uiSequencePlayer.IsSequenceInPlaying(sequenceName);
		}

		// Token: 0x0602E683 RID: 190083 RVA: 0x00AB9529 File Offset: 0x00AB7729
		public void SetSequenceName(UiViewData viewData)
		{
			if (viewData != null)
			{
				this.StartSequenceNameInternal = (viewData.StartSequenceName ?? "Start");
				this.CloseSequenceNameInternal = (viewData.CloseSequenceName ?? "Close");
			}
		}

		// Token: 0x0602E684 RID: 190084 RVA: 0x00AB9558 File Offset: 0x00AB7758
		public void AddSequenceFinishEvent(string sequenceName, Action<string> finishEvent, bool clear = false)
		{
			HashSet<Action<string>> hashSet;
			if (!this.EndEventMap.TryGetValue(sequenceName, out hashSet))
			{
				hashSet = new HashSet<Action<string>>();
				this.EndEventMap[sequenceName] = hashSet;
			}
			else if (clear)
			{
				hashSet.Clear();
			}
			if (hashSet.Contains(finishEvent))
			{
				Log.Instance.Error(ELogModule.UiCore, ELogAuthor.LFJW, "SequenceFinishEvent重复添加。", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			hashSet.Add(finishEvent);
		}

		// Token: 0x0602E685 RID: 190085 RVA: 0x00AB95C0 File Offset: 0x00AB77C0
		public void RemoveSequenceFinishEvent(string sequenceName, Action<string> finishEvent)
		{
			if (this.EndEventMap == null || finishEvent == null)
			{
				return;
			}
			HashSet<Action<string>> hashSet;
			if (!this.EndEventMap.TryGetValue(sequenceName, out hashSet))
			{
				return;
			}
			if (!hashSet.Contains(finishEvent))
			{
				return;
			}
			hashSet.Remove(finishEvent);
		}

		// Token: 0x0602E686 RID: 190086 RVA: 0x00AB95FC File Offset: 0x00AB77FC
		public void AddSequenceStartEvent(string name, Action<string> eventAction)
		{
			HashSet<Action<string>> hashSet;
			if (!this.StartEventMap.TryGetValue(name, out hashSet))
			{
				hashSet = new HashSet<Action<string>>();
				this.StartEventMap[name] = hashSet;
			}
			if (hashSet.Contains(eventAction))
			{
				Log.Instance.Error(ELogModule.UiCore, ELogAuthor.YZY, "AddSequenceStartEvent重复添加。", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			hashSet.Add(eventAction);
		}

		// Token: 0x0602E687 RID: 190087 RVA: 0x00AB965A File Offset: 0x00AB785A
		public void StopSequenceByKey(string sequenceName, bool needEvent = false, bool toLastFrame = false)
		{
			UiSequencePlayer uiSequencePlayer = this.UiSequencePlayer;
			if (uiSequencePlayer == null)
			{
				return;
			}
			uiSequencePlayer.StopSequenceByKey(sequenceName, needEvent, toLastFrame);
		}

		// Token: 0x0602E688 RID: 190088 RVA: 0x00AB966F File Offset: 0x00AB786F
		public void SequencePlayReverseByKey(string sequenceName, bool block)
		{
			UiSequencePlayer uiSequencePlayer = this.UiSequencePlayer;
			if (uiSequencePlayer == null)
			{
				return;
			}
			uiSequencePlayer.PlaySequencePurely(sequenceName, block, true);
		}

		// Token: 0x0602E689 RID: 190089 RVA: 0x00AB9684 File Offset: 0x00AB7884
		public void PlaySequence(string sequenceName, bool blockClick = false, float? playRate = null)
		{
			this.CurrentPlayingSequenceName = sequenceName.ToString();
			this.UiSequencePlayer.PlaySequence(sequenceName, blockClick, playRate);
		}

		// Token: 0x170075FF RID: 30207
		// (get) Token: 0x0602E68A RID: 190090 RVA: 0x00AB96A0 File Offset: 0x00AB78A0
		public string CurrentSequenceName
		{
			get
			{
				return this.CurrentPlayingSequenceName;
			}
		}

		// Token: 0x0602E68B RID: 190091 RVA: 0x00AB96A8 File Offset: 0x00AB78A8
		public UniTask PlaySequenceAsync(string sequenceName, CustomPromise<bool> stopPromise, bool blockClick = false, bool playReverse = false, float? playRate = null)
		{
			UiBehaviorLevelSequence.<PlaySequenceAsync>d__37 <PlaySequenceAsync>d__;
			<PlaySequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySequenceAsync>d__.<>4__this = this;
			<PlaySequenceAsync>d__.sequenceName = sequenceName;
			<PlaySequenceAsync>d__.stopPromise = stopPromise;
			<PlaySequenceAsync>d__.blockClick = blockClick;
			<PlaySequenceAsync>d__.playReverse = playReverse;
			<PlaySequenceAsync>d__.playRate = playRate;
			<PlaySequenceAsync>d__.<>1__state = -1;
			<PlaySequenceAsync>d__.<>t__builder.Start<UiBehaviorLevelSequence.<PlaySequenceAsync>d__37>(ref <PlaySequenceAsync>d__);
			return <PlaySequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E68C RID: 190092 RVA: 0x00AB9718 File Offset: 0x00AB7918
		public UniTask PlaySequenceAsyncNoStopRunning(string sequenceName, CustomPromise<bool> stopPromise, bool blockClick = false, bool playReverse = false, float? playRate = null)
		{
			UiBehaviorLevelSequence.<PlaySequenceAsyncNoStopRunning>d__38 <PlaySequenceAsyncNoStopRunning>d__;
			<PlaySequenceAsyncNoStopRunning>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySequenceAsyncNoStopRunning>d__.<>4__this = this;
			<PlaySequenceAsyncNoStopRunning>d__.sequenceName = sequenceName;
			<PlaySequenceAsyncNoStopRunning>d__.stopPromise = stopPromise;
			<PlaySequenceAsyncNoStopRunning>d__.blockClick = blockClick;
			<PlaySequenceAsyncNoStopRunning>d__.playReverse = playReverse;
			<PlaySequenceAsyncNoStopRunning>d__.playRate = playRate;
			<PlaySequenceAsyncNoStopRunning>d__.<>1__state = -1;
			<PlaySequenceAsyncNoStopRunning>d__.<>t__builder.Start<UiBehaviorLevelSequence.<PlaySequenceAsyncNoStopRunning>d__38>(ref <PlaySequenceAsyncNoStopRunning>d__);
			return <PlaySequenceAsyncNoStopRunning>d__.<>t__builder.Task;
		}

		// Token: 0x0602E68D RID: 190093 RVA: 0x00AB9785 File Offset: 0x00AB7985
		public void PlaySequencePurely(string sequenceName, bool blockClick = false, bool isReverse = false)
		{
			this.CurrentPlayingSequenceName = sequenceName.ToString();
			UiSequencePlayer uiSequencePlayer = this.UiSequencePlayer;
			if (uiSequencePlayer == null)
			{
				return;
			}
			uiSequencePlayer.PlaySequencePurely(sequenceName.ToString(), blockClick, isReverse);
		}

		// Token: 0x0602E68E RID: 190094 RVA: 0x00AB97AB File Offset: 0x00AB79AB
		public void PlayOrReplaySequenceByName(string sequenceName, bool blockClick = false, float? playRate = null)
		{
			UiSequencePlayer uiSequencePlayer = this.UiSequencePlayer;
			if (uiSequencePlayer == null)
			{
				return;
			}
			uiSequencePlayer.PlayOrReplaySequenceByName(sequenceName, blockClick, playRate);
		}

		// Token: 0x0602E68F RID: 190095 RVA: 0x00AB97C0 File Offset: 0x00AB79C0
		public void PauseSequence()
		{
			this.UiSequencePlayer.PauseSequence();
		}

		// Token: 0x0602E690 RID: 190096 RVA: 0x00AB97CD File Offset: 0x00AB79CD
		public void ResumeSequence()
		{
			this.UiSequencePlayer.ResumeSequence();
		}

		// Token: 0x0602E691 RID: 190097 RVA: 0x00AB97DA File Offset: 0x00AB79DA
		public void StopPrevSequence(bool needEvent, bool toLastFrame = false)
		{
			if (this.IsInSequence())
			{
				this.UiSequencePlayer.StopCurrentSequenceByName(this.CurrentPlayingSequenceName, needEvent, toLastFrame);
			}
		}

		// Token: 0x0602E692 RID: 190098 RVA: 0x00AB97F7 File Offset: 0x00AB79F7
		public void ReplaySequence(string sequenceName)
		{
			if (this.IsInSequence())
			{
				this.UiSequencePlayer.ReplaySequence(sequenceName);
			}
		}

		// Token: 0x0602E693 RID: 190099 RVA: 0x00AB980D File Offset: 0x00AB7A0D
		public void ChangePlaybackDirection(string sequenceName)
		{
			if (!this.HasSequenceNameInPlaying(sequenceName))
			{
				return;
			}
			this.UiSequencePlayer.ChangePlaybackDirection(sequenceName);
		}

		// Token: 0x0602E694 RID: 190100 RVA: 0x00AB9825 File Offset: 0x00AB7A25
		public void SetActorTag(string sequenceName, FName tag, AActor actor)
		{
			this.UiSequencePlayer.SetActorTag(sequenceName, tag, actor);
		}

		// Token: 0x0602E695 RID: 190101 RVA: 0x00AB9835 File Offset: 0x00AB7A35
		public void SetRelativeTransform(string sequenceName, FTransformDouble transform)
		{
			this.UiSequencePlayer.SetRelativeTransform(sequenceName, transform);
		}

		// Token: 0x0602E696 RID: 190102 RVA: 0x00AB9844 File Offset: 0x00AB7A44
		public void OnBeforeDestroy()
		{
			if (this.UiSequencePlayer != null)
			{
				this.UiSequencePlayer.Clear();
				this.UiSequencePlayer = null;
			}
			this.EndEventMap.Clear();
			this.StartEventMap.Clear();
		}

		// Token: 0x0602E697 RID: 190103 RVA: 0x00AB9876 File Offset: 0x00AB7A76
		public void OnAfterUiShow()
		{
		}

		// Token: 0x0602E698 RID: 190104 RVA: 0x00AB9878 File Offset: 0x00AB7A78
		public void OnBeforeUiHide()
		{
		}

		// Token: 0x04018DD9 RID: 101849
		[Nullable(2)]
		private UiSequencePlayer UiSequencePlayer;

		// Token: 0x04018DDA RID: 101850
		private string StartSequenceNameInternal = "Start";

		// Token: 0x04018DDB RID: 101851
		private string CloseSequenceNameInternal = "Close";

		// Token: 0x04018DDC RID: 101852
		private string ShowSequenceNameInternal = "ShowView";

		// Token: 0x04018DDD RID: 101853
		private string HideSequenceNameInternal = "HideView";

		// Token: 0x04018DDE RID: 101854
		private readonly Dictionary<string, HashSet<Action<string>>> EndEventMap = new Dictionary<string, HashSet<Action<string>>>();

		// Token: 0x04018DDF RID: 101855
		private readonly Dictionary<string, HashSet<Action<string>>> StartEventMap = new Dictionary<string, HashSet<Action<string>>>();

		// Token: 0x04018DE0 RID: 101856
		private string CurrentPlayingSequenceName = "";

		// Token: 0x04018DE1 RID: 101857
		private readonly UiPanelBase Owner;
	}
}
