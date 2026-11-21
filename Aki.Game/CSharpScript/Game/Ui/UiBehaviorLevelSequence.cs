using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003573 RID: 13683
	[NullableContext(1)]
	[Nullable(0)]
	public class UiBehaviorLevelSequence : IUiBehavior
	{
		// Token: 0x170048B7 RID: 18615
		// (get) Token: 0x06022DBE RID: 142782 RVA: 0x009E6968 File Offset: 0x009E4B68
		// (set) Token: 0x06022DBF RID: 142783 RVA: 0x009E6970 File Offset: 0x009E4B70
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

		// Token: 0x170048B8 RID: 18616
		// (get) Token: 0x06022DC0 RID: 142784 RVA: 0x009E6979 File Offset: 0x009E4B79
		// (set) Token: 0x06022DC1 RID: 142785 RVA: 0x009E6981 File Offset: 0x009E4B81
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

		// Token: 0x170048B9 RID: 18617
		// (get) Token: 0x06022DC2 RID: 142786 RVA: 0x009E698A File Offset: 0x009E4B8A
		// (set) Token: 0x06022DC3 RID: 142787 RVA: 0x009E6992 File Offset: 0x009E4B92
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

		// Token: 0x170048BA RID: 18618
		// (get) Token: 0x06022DC4 RID: 142788 RVA: 0x009E699B File Offset: 0x009E4B9B
		// (set) Token: 0x06022DC5 RID: 142789 RVA: 0x009E69A3 File Offset: 0x009E4BA3
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

		// Token: 0x06022DC6 RID: 142790 RVA: 0x009E69AC File Offset: 0x009E4BAC
		public UiBehaviorLevelSequence(UiPanelBase owner)
		{
			this.Owner = owner;
		}

		// Token: 0x06022DC7 RID: 142791 RVA: 0x009E6A13 File Offset: 0x009E4C13
		public UniTask OnUiCreateAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06022DC8 RID: 142792 RVA: 0x009E6A1C File Offset: 0x009E4C1C
		public void OnUiStart()
		{
			this.UiSequencePlayer = new UiSequencePlayer(this.Owner.GetRootItem());
			this.UiSequencePlayer.BindOnStartSequenceEvent(new Action<string>(this.OnSequenceStart));
			this.UiSequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.OnSequenceEnd));
		}

		// Token: 0x06022DC9 RID: 142793 RVA: 0x009E6A70 File Offset: 0x009E4C70
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

		// Token: 0x06022DCA RID: 142794 RVA: 0x009E6AD4 File Offset: 0x009E4CD4
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

		// Token: 0x06022DCB RID: 142795 RVA: 0x009E6B38 File Offset: 0x009E4D38
		public bool IsInSequence()
		{
			return this.UiSequencePlayer.IsInSequence();
		}

		// Token: 0x06022DCC RID: 142796 RVA: 0x009E6B45 File Offset: 0x009E4D45
		public bool HasSequenceNameInPlaying(string sequenceName)
		{
			UiSequencePlayer uiSequencePlayer = this.UiSequencePlayer;
			return uiSequencePlayer != null && uiSequencePlayer.IsSequenceInPlaying(sequenceName);
		}

		// Token: 0x06022DCD RID: 142797 RVA: 0x009E6B59 File Offset: 0x009E4D59
		public void SetSequenceName(UiViewData viewData)
		{
			if (viewData != null)
			{
				this.StartSequenceNameInternal = (viewData.StartSequenceName ?? "Start");
				this.CloseSequenceNameInternal = (viewData.CloseSequenceName ?? "Close");
			}
		}

		// Token: 0x06022DCE RID: 142798 RVA: 0x009E6B88 File Offset: 0x009E4D88
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

		// Token: 0x06022DCF RID: 142799 RVA: 0x009E6BF0 File Offset: 0x009E4DF0
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

		// Token: 0x06022DD0 RID: 142800 RVA: 0x009E6C2C File Offset: 0x009E4E2C
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

		// Token: 0x06022DD1 RID: 142801 RVA: 0x009E6C8A File Offset: 0x009E4E8A
		public void StopSequenceByKey(string sequenceName, bool needEvent = false, bool toLastFrame = false)
		{
			UiSequencePlayer uiSequencePlayer = this.UiSequencePlayer;
			if (uiSequencePlayer == null)
			{
				return;
			}
			uiSequencePlayer.StopSequenceByKey(sequenceName, needEvent, toLastFrame);
		}

		// Token: 0x06022DD2 RID: 142802 RVA: 0x009E6C9F File Offset: 0x009E4E9F
		public void SequencePlayReverseByKey(string sequenceName, bool block)
		{
			UiSequencePlayer uiSequencePlayer = this.UiSequencePlayer;
			if (uiSequencePlayer == null)
			{
				return;
			}
			uiSequencePlayer.PlaySequencePurely(sequenceName, block, true);
		}

		// Token: 0x06022DD3 RID: 142803 RVA: 0x009E6CB4 File Offset: 0x009E4EB4
		public void PlaySequence(string sequenceName, bool blockClick = false, float? playRate = null)
		{
			this.CurrentPlayingSequenceName = sequenceName.ToString();
			this.UiSequencePlayer.PlaySequence(sequenceName, blockClick, playRate);
		}

		// Token: 0x170048BB RID: 18619
		// (get) Token: 0x06022DD4 RID: 142804 RVA: 0x009E6CD0 File Offset: 0x009E4ED0
		public string CurrentSequenceName
		{
			get
			{
				return this.CurrentPlayingSequenceName;
			}
		}

		// Token: 0x06022DD5 RID: 142805 RVA: 0x009E6CD8 File Offset: 0x009E4ED8
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

		// Token: 0x06022DD6 RID: 142806 RVA: 0x009E6D48 File Offset: 0x009E4F48
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

		// Token: 0x06022DD7 RID: 142807 RVA: 0x009E6DB5 File Offset: 0x009E4FB5
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

		// Token: 0x06022DD8 RID: 142808 RVA: 0x009E6DDB File Offset: 0x009E4FDB
		public void PlayOrReplaySequenceByName(string sequenceName, bool blockClick = false, float? playRate = null)
		{
			UiSequencePlayer uiSequencePlayer = this.UiSequencePlayer;
			if (uiSequencePlayer == null)
			{
				return;
			}
			uiSequencePlayer.PlayOrReplaySequenceByName(sequenceName, blockClick, playRate);
		}

		// Token: 0x06022DD9 RID: 142809 RVA: 0x009E6DF0 File Offset: 0x009E4FF0
		public void PauseSequence()
		{
			this.UiSequencePlayer.PauseSequence();
		}

		// Token: 0x06022DDA RID: 142810 RVA: 0x009E6DFD File Offset: 0x009E4FFD
		public void ResumeSequence()
		{
			this.UiSequencePlayer.ResumeSequence();
		}

		// Token: 0x06022DDB RID: 142811 RVA: 0x009E6E0A File Offset: 0x009E500A
		public void StopPrevSequence(bool needEvent, bool toLastFrame = false)
		{
			if (this.IsInSequence())
			{
				this.UiSequencePlayer.StopCurrentSequenceByName(this.CurrentPlayingSequenceName, needEvent, toLastFrame);
			}
		}

		// Token: 0x06022DDC RID: 142812 RVA: 0x009E6E27 File Offset: 0x009E5027
		public void ReplaySequence(string sequenceName)
		{
			if (this.IsInSequence())
			{
				this.UiSequencePlayer.ReplaySequence(sequenceName);
			}
		}

		// Token: 0x06022DDD RID: 142813 RVA: 0x009E6E3D File Offset: 0x009E503D
		public void ChangePlaybackDirection(string sequenceName)
		{
			if (!this.HasSequenceNameInPlaying(sequenceName))
			{
				return;
			}
			this.UiSequencePlayer.ChangePlaybackDirection(sequenceName);
		}

		// Token: 0x06022DDE RID: 142814 RVA: 0x009E6E55 File Offset: 0x009E5055
		public void SetActorTag(string sequenceName, FName tag, AActor actor)
		{
			this.UiSequencePlayer.SetActorTag(sequenceName, tag, actor);
		}

		// Token: 0x06022DDF RID: 142815 RVA: 0x009E6E65 File Offset: 0x009E5065
		public void SetRelativeTransform(string sequenceName, FTransformDouble transform)
		{
			this.UiSequencePlayer.SetRelativeTransform(sequenceName, transform);
		}

		// Token: 0x06022DE0 RID: 142816 RVA: 0x009E6E74 File Offset: 0x009E5074
		public void OnDestroy()
		{
			if (this.UiSequencePlayer != null)
			{
				this.UiSequencePlayer.Clear();
				this.UiSequencePlayer = null;
			}
			this.EndEventMap.Clear();
			this.StartEventMap.Clear();
		}

		// Token: 0x06022DE1 RID: 142817 RVA: 0x009E6EA6 File Offset: 0x009E50A6
		public void OnUiShow()
		{
		}

		// Token: 0x06022DE2 RID: 142818 RVA: 0x009E6EA8 File Offset: 0x009E50A8
		public void OnUiHide()
		{
		}

		// Token: 0x04013432 RID: 78898
		[Nullable(2)]
		private UiSequencePlayer UiSequencePlayer;

		// Token: 0x04013433 RID: 78899
		private string StartSequenceNameInternal = "Start";

		// Token: 0x04013434 RID: 78900
		private string CloseSequenceNameInternal = "Close";

		// Token: 0x04013435 RID: 78901
		private string ShowSequenceNameInternal = "ShowView";

		// Token: 0x04013436 RID: 78902
		private string HideSequenceNameInternal = "HideView";

		// Token: 0x04013437 RID: 78903
		private readonly Dictionary<string, HashSet<Action<string>>> EndEventMap = new Dictionary<string, HashSet<Action<string>>>();

		// Token: 0x04013438 RID: 78904
		private readonly Dictionary<string, HashSet<Action<string>>> StartEventMap = new Dictionary<string, HashSet<Action<string>>>();

		// Token: 0x04013439 RID: 78905
		private string CurrentPlayingSequenceName = "";

		// Token: 0x0401343A RID: 78906
		private readonly UiPanelBase Owner;
	}
}
