using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000DB5 RID: 3509
[NullableContext(1)]
[Nullable(0)]
public class LevelSequencePlayer : IStaticVariableResetter
{
	// Token: 0x06008F62 RID: 36706 RVA: 0x002B260D File Offset: 0x002B080D
	static LevelSequencePlayer()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LevelSequencePlayer.CreateStaticDefaultValue), new Action(LevelSequencePlayer.ResetStaticDefaultValue));
	}

	// Token: 0x17000FBF RID: 4031
	// (get) Token: 0x06008F63 RID: 36707 RVA: 0x002B262C File Offset: 0x002B082C
	private static HashSet<LevelSequencePlayer> PlayingInstances
	{
		get
		{
			return LevelSequencePlayer._playingInstances;
		}
	}

	// Token: 0x06008F64 RID: 36708 RVA: 0x002B2634 File Offset: 0x002B0834
	[NullableContext(2)]
	public LevelSequencePlayer(UUIItem uiItem = null)
	{
		this.UiItem = uiItem;
		this.UiBaseActor = (((uiItem != null) ? uiItem.GetOwner() : null) as AUIBaseActor);
		this.UiBaseActor.OnPreDestroyed.Add(new Action<AActor>(this.AutoDestroy));
	}

	// Token: 0x06008F65 RID: 36709 RVA: 0x002B2697 File Offset: 0x002B0897
	[NullableContext(2)]
	private void AutoDestroy(AActor _)
	{
		this.Clear();
	}

	// Token: 0x06008F66 RID: 36710 RVA: 0x002B26A0 File Offset: 0x002B08A0
	public void BindSequenceCloseEvent(TSequenceEndEvent sequencePlayCloseEvent, bool clear = false)
	{
		if (clear && this.OnSequenceEndEvent != null)
		{
			this.OnSequenceEndEvent = Array.Empty<TSequenceEndEvent>();
		}
		if (this.OnSequenceEndEvent == null)
		{
			this.OnSequenceEndEvent = Array.Empty<TSequenceEndEvent>();
		}
		TSequenceEndEvent[] array = new TSequenceEndEvent[this.OnSequenceEndEvent.Length + 1];
		this.OnSequenceEndEvent.CopyTo(array, 0);
		array[this.OnSequenceEndEvent.Length] = sequencePlayCloseEvent;
		this.OnSequenceEndEvent = array;
	}

	// Token: 0x06008F67 RID: 36711 RVA: 0x002B2708 File Offset: 0x002B0908
	public void BindSequenceStartEvent(TSequenceStartEvent sequenceStartEvent)
	{
		if (this.OnSequenceStartEvent == null)
		{
			this.OnSequenceStartEvent = new TSequenceStartEvent[0];
		}
		TSequenceStartEvent[] array = new TSequenceStartEvent[this.OnSequenceStartEvent.Length + 1];
		this.OnSequenceStartEvent.CopyTo(array, 0);
		array[this.OnSequenceStartEvent.Length] = sequenceStartEvent;
		this.OnSequenceStartEvent = array;
	}

	// Token: 0x06008F68 RID: 36712 RVA: 0x002B2758 File Offset: 0x002B0958
	public void StopCurrentSequence(bool needEvent = false, bool toLastFrame = false)
	{
		if (this.CurrentSequenceName == null)
		{
			return;
		}
		this.StopSequenceByKey(this.CurrentSequenceName, needEvent, toLastFrame);
		this.CurrentSequenceName = null;
	}

	// Token: 0x06008F69 RID: 36713 RVA: 0x002B2778 File Offset: 0x002B0978
	public void StopSequenceByKey(string sequenceName, bool needEvent = false, bool toLastFrame = false)
	{
		if (!this.IsValid())
		{
			return;
		}
		if (toLastFrame)
		{
			this.EndSequenceLastFrame(sequenceName);
		}
		SequenceData sequenceData;
		if (this.PlayingSequenceNameMap.TryGetValue(sequenceName, out sequenceData))
		{
			sequenceData.NeedFinishEvent = needEvent;
		}
		USequencePlayContext usequencePlayContext;
		if (this.PlayContextMap.TryGetValue(sequenceName, out usequencePlayContext) && usequencePlayContext.IsValid())
		{
			usequencePlayContext.TryStop();
			return;
		}
		this.OnSequenceStop(sequenceName);
	}

	// Token: 0x06008F6A RID: 36714 RVA: 0x002B27D8 File Offset: 0x002B09D8
	public void ReplaySequenceByKey(string sequenceName)
	{
		if (!this.IsValid())
		{
			return;
		}
		SequenceData sequenceData;
		if (!this.PlayingSequenceNameMap.TryGetValue(sequenceName, out sequenceData))
		{
			return;
		}
		USequencePlayContext usequencePlayContext;
		if (!this.PlayContextMap.TryGetValue(sequenceName, out usequencePlayContext))
		{
			return;
		}
		ALevelSequenceActor sequencePlayerByKey = this.UiBaseActor.GetSequencePlayerByKey(sequenceName);
		if (sequencePlayerByKey != null && sequencePlayerByKey.IsValid())
		{
			ULevelSequencePlayer sequencePlayer = sequencePlayerByKey.SequencePlayer;
			if (sequencePlayer != null && sequencePlayer.IsValid())
			{
				if (sequencePlayer.IsStopped())
				{
					this.PlayLevelSequenceByName(sequenceName, sequenceData.IsBlock, null, false);
					return;
				}
				AUIBaseActor uiBaseActor = this.UiBaseActor;
				FFrameTime fframeTime = new FFrameTime();
				uiBaseActor.SequenceJumpToSecondByKey(sequenceName, fframeTime);
			}
		}
	}

	// Token: 0x06008F6B RID: 36715 RVA: 0x002B2870 File Offset: 0x002B0A70
	public void SequenceJumpToStartWhenPlaying(string sequenceName)
	{
		if (!this.IsValid())
		{
			return;
		}
		ALevelSequenceActor sequencePlayerByKey = this.UiBaseActor.GetSequencePlayerByKey(sequenceName);
		if (sequencePlayerByKey != null && sequencePlayerByKey.IsValid())
		{
			ULevelSequencePlayer sequencePlayer = sequencePlayerByKey.SequencePlayer;
			if (sequencePlayer != null && sequencePlayer.IsValid() && !sequencePlayer.IsStopped())
			{
				AUIBaseActor uiBaseActor = this.UiBaseActor;
				FFrameTime fframeTime = new FFrameTime();
				uiBaseActor.SequenceJumpToSecondByKey(sequenceName, fframeTime);
			}
		}
	}

	// Token: 0x06008F6C RID: 36716 RVA: 0x002B28CC File Offset: 0x002B0ACC
	public void ChangePlaybackDirection(string sequenceName)
	{
		SequenceData sequenceData;
		if (!this.PlayingSequenceNameMap.TryGetValue(sequenceName, out sequenceData))
		{
			return;
		}
		USequencePlayContext usequencePlayContext;
		if (!this.PlayContextMap.TryGetValue(sequenceName, out usequencePlayContext))
		{
			return;
		}
		ALevelSequenceActor sequencePlayerByKey = this.UiBaseActor.GetSequencePlayerByKey(sequenceName);
		if (sequencePlayerByKey == null || !sequencePlayerByKey.IsValid())
		{
			return;
		}
		ULevelSequencePlayer sequencePlayer = sequencePlayerByKey.GetSequencePlayer();
		if (sequencePlayer == null || !sequencePlayer.IsValid())
		{
			return;
		}
		sequencePlayer.ChangePlaybackDirection();
	}

	// Token: 0x06008F6D RID: 36717 RVA: 0x002B292D File Offset: 0x002B0B2D
	[NullableContext(2)]
	public string GetCurrentSequence()
	{
		return this.CurrentSequenceName;
	}

	// Token: 0x06008F6E RID: 36718 RVA: 0x002B2938 File Offset: 0x002B0B38
	public unsafe void PauseSequence()
	{
		if (!this.IsValid())
		{
			return;
		}
		if (this.CurrentSequenceName == null)
		{
			return;
		}
		ALevelSequenceActor levelSequenceActor = this.GetLevelSequenceActor(this.CurrentSequenceName);
		if (levelSequenceActor != null)
		{
			levelSequenceActor.SequencePlayer.Pause();
			return;
		}
		USequencePlayContext usequencePlayContext;
		if (!this.PlayContextMap.TryGetValue(this.CurrentSequenceName, out usequencePlayContext))
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.LevelSequencePlayer;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "异步加载暂停关卡序列";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("停止节点", this.UiItem.GetDisplayName());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("关卡序列", this.CurrentSequenceName);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		usequencePlayContext.TryStop();
	}

	// Token: 0x06008F6F RID: 36719 RVA: 0x002B29F4 File Offset: 0x002B0BF4
	public unsafe void ResumeSequence()
	{
		if (!this.IsValid())
		{
			return;
		}
		if (this.CurrentSequenceName == null)
		{
			return;
		}
		ALevelSequenceActor levelSequenceActor = this.GetLevelSequenceActor(this.CurrentSequenceName);
		if (levelSequenceActor == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.LevelSequencePlayer;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "异步恢复关卡序列动画";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "停止节点";
			UUIItem uiItem = this.UiItem;
			ptr = new ValueTuple<string, object>(item, (uiItem != null) ? uiItem.GetDisplayName() : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("关卡序列", this.CurrentSequenceName);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			USequencePlayContext usequencePlayContext;
			if (this.PlayContextMap.TryGetValue(this.CurrentSequenceName, out usequencePlayContext))
			{
				usequencePlayContext.ExecutePlay();
			}
			return;
		}
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.LevelSequencePlayer;
		ELogAuthor author2 = ELogAuthor.XXJ;
		string message2 = "恢复关卡序列动画";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
		ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0);
		string item2 = "停止节点";
		UUIItem uiItem2 = this.UiItem;
		ptr2 = new ValueTuple<string, object>(item2, (uiItem2 != null) ? uiItem2.GetDisplayName() : null);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("关卡序列", this.CurrentSequenceName);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		ULevelSequencePlayer sequencePlayer = levelSequenceActor.SequencePlayer;
		if (sequencePlayer == null)
		{
			return;
		}
		sequencePlayer.Play();
	}

	// Token: 0x06008F70 RID: 36720 RVA: 0x002B2B24 File Offset: 0x002B0D24
	public void Clear()
	{
		UUIItem uiItem = this.UiItem;
		foreach (USequencePlayContext usequencePlayContext in this.PlayContextMap.Values)
		{
			usequencePlayContext.OnStop.Unbind();
		}
		foreach (string sequenceName in new List<string>(this.PlayingSequenceNameMap.Keys))
		{
			this.OnSequenceStop(sequenceName);
		}
		this.PlayContextMap.Clear();
		this.PlayingSequenceNameMap.Clear();
		LevelSequencePlayer.PlayingInstances.Remove(this);
		AUIBaseActor uiBaseActor = this.UiBaseActor;
		if (uiBaseActor != null)
		{
			uiBaseActor.ClearAllSequence();
		}
		AUIBaseActor uiBaseActor2 = this.UiBaseActor;
		if (uiBaseActor2 != null)
		{
			uiBaseActor2.OnPreDestroyed.Remove(new Action<AActor>(this.AutoDestroy));
		}
		this.UiBaseActor = null;
		this.UiItem = null;
	}

	// Token: 0x06008F71 RID: 36721 RVA: 0x002B2C34 File Offset: 0x002B0E34
	public void StopPlayingSequence(bool needEvent = false, bool toLastFrame = true)
	{
		foreach (string sequenceName in new List<string>(this.PlayingSequenceNameMap.Keys))
		{
			this.StopSequenceByKey(sequenceName, needEvent, toLastFrame);
		}
	}

	// Token: 0x06008F72 RID: 36722 RVA: 0x002B2C94 File Offset: 0x002B0E94
	public bool IsPlayingSequence(string sequenceName)
	{
		return this.PlayingSequenceNameMap.ContainsKey(sequenceName);
	}

	// Token: 0x06008F73 RID: 36723 RVA: 0x002B2CA4 File Offset: 0x002B0EA4
	public void EndSequenceLastFrame(string sequenceName)
	{
		if (!this.IsValid())
		{
			return;
		}
		AUIBaseActor uiBaseActor = this.UiBaseActor;
		UUIItem uuiitem = (uiBaseActor != null) ? uiBaseActor.GetUIItem() : null;
		if (uuiitem != null && uuiitem.LevelSequences.Contains(sequenceName))
		{
			ALevelSequenceActor levelSequenceActor = this.GetLevelSequenceActor(sequenceName);
			if (levelSequenceActor != null)
			{
				AUIBaseActor uiBaseActor2 = this.UiBaseActor;
				FFrameTime time = levelSequenceActor.SequencePlayer.GetDuration().Time;
				uiBaseActor2.SequenceJumpToSecondByKey(sequenceName, time);
			}
		}
	}

	// Token: 0x06008F74 RID: 36724 RVA: 0x002B2D08 File Offset: 0x002B0F08
	public bool CheckSeqActorIsSeqPlaying(string sequenceName)
	{
		ALevelSequenceActor levelSequenceActor = this.GetLevelSequenceActor(sequenceName);
		if (levelSequenceActor != null && levelSequenceActor.IsValid())
		{
			ULevelSequencePlayer sequencePlayer = levelSequenceActor.SequencePlayer;
			if (sequencePlayer != null && sequencePlayer.IsValid() && sequencePlayer.IsPlaying())
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06008F75 RID: 36725 RVA: 0x002B2D48 File Offset: 0x002B0F48
	public bool CheckSeqActorIsUnStopped(string sequenceName)
	{
		ALevelSequenceActor levelSequenceActor = this.GetLevelSequenceActor(sequenceName);
		if (levelSequenceActor != null && levelSequenceActor.IsValid())
		{
			ULevelSequencePlayer sequencePlayer = levelSequenceActor.SequencePlayer;
			if (sequencePlayer != null && sequencePlayer.IsValid() && !sequencePlayer.IsStopped())
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06008F76 RID: 36726 RVA: 0x002B2D85 File Offset: 0x002B0F85
	public void PlayOrReplaySequenceByName(string sequenceName, bool blockClick = false, float? playRate = null)
	{
		if (this.CheckSeqActorIsSeqPlaying(sequenceName))
		{
			this.ReplaySequenceByKey(sequenceName);
			return;
		}
		this.PlaySequencePurely(sequenceName, blockClick, false, null, playRate, false);
	}

	// Token: 0x06008F77 RID: 36727 RVA: 0x002B2DA4 File Offset: 0x002B0FA4
	public void PlayLevelSequenceByName(string sequenceName, bool blockClick = false, float? playRate = null, bool bJumpToLastFrame = false)
	{
		this.PlaySequencePurely(sequenceName, blockClick, false, null, playRate, bJumpToLastFrame);
	}

	// Token: 0x06008F78 RID: 36728 RVA: 0x002B2DB4 File Offset: 0x002B0FB4
	public UniTask PlaySequenceAsync(string sequenceName, [Nullable(2)] CustomPromise<bool> stopPromise, bool blockClick = false, bool playReverse = false, float? playRate = null, bool bJumpToLastFrame = false)
	{
		LevelSequencePlayer.<PlaySequenceAsync>d__32 <PlaySequenceAsync>d__;
		<PlaySequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlaySequenceAsync>d__.<>4__this = this;
		<PlaySequenceAsync>d__.sequenceName = sequenceName;
		<PlaySequenceAsync>d__.stopPromise = stopPromise;
		<PlaySequenceAsync>d__.blockClick = blockClick;
		<PlaySequenceAsync>d__.playReverse = playReverse;
		<PlaySequenceAsync>d__.playRate = playRate;
		<PlaySequenceAsync>d__.bJumpToLastFrame = bJumpToLastFrame;
		<PlaySequenceAsync>d__.<>1__state = -1;
		<PlaySequenceAsync>d__.<>t__builder.Start<LevelSequencePlayer.<PlaySequenceAsync>d__32>(ref <PlaySequenceAsync>d__);
		return <PlaySequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008F79 RID: 36729 RVA: 0x002B2E2C File Offset: 0x002B102C
	public void PlaySequencePurely(string sequenceName, bool blockClick = false, bool playReverse = false, [Nullable(2)] CustomPromise<bool> stopPromise = null, float? playRate = null, bool bJumpToLastFrame = false)
	{
		if (!this.IsValid())
		{
			if (stopPromise != null)
			{
				stopPromise.SetResult(false);
			}
			return;
		}
		USequencePlayContext sequencePlayContext = this.GetSequencePlayContext(sequenceName);
		string displayName = this.UiItem.GetDisplayName();
		this.CurrentSequenceName = sequenceName;
		SequenceData value = new SequenceData(sequenceName, blockClick, displayName, stopPromise);
		this.PlayingSequenceNameMap[sequenceName] = value;
		LevelSequencePlayer.PlayingInstances.Add(this);
		if (LevelSequencePlayer.Banned)
		{
			this.OnSequenceStart(sequenceName);
			this.OnSequenceStop(sequenceName);
			return;
		}
		if (sequencePlayContext != null)
		{
			sequencePlayContext.bReverse = playReverse;
			if (playRate != null)
			{
				sequencePlayContext.PlayInfo.PlaySetting.PlayRate = playRate.Value;
			}
			sequencePlayContext.bJumpToLastFrame = bJumpToLastFrame;
			sequencePlayContext.ExecutePlay();
			this.OnSequenceStart(sequenceName);
			return;
		}
		this.OnSequenceStop(sequenceName);
	}

	// Token: 0x06008F7A RID: 36730 RVA: 0x002B2EEC File Offset: 0x002B10EC
	[return: Nullable(2)]
	public USequencePlayContext GetSequencePlayContext(string sequenceName)
	{
		if (!this.IsValid())
		{
			return null;
		}
		USequencePlayContext sequencePlayContextOfKey;
		if (!this.PlayContextMap.TryGetValue(sequenceName, out sequencePlayContextOfKey))
		{
			sequencePlayContextOfKey = this.UiBaseActor.GetSequencePlayContextOfKey(sequenceName);
			if (sequencePlayContextOfKey == null)
			{
				return null;
			}
			sequencePlayContextOfKey.bIsAsync = false;
			sequencePlayContextOfKey.OnStop.Bind(delegate()
			{
				this.OnSequenceStop(sequenceName);
			});
			this.PlayContextMap[sequenceName] = sequencePlayContextOfKey;
		}
		return sequencePlayContextOfKey;
	}

	// Token: 0x06008F7B RID: 36731 RVA: 0x002B2F74 File Offset: 0x002B1174
	[return: Nullable(2)]
	public CustomPromise<bool> GetCurrentStopPromise(string sequenceName)
	{
		SequenceData sequenceData;
		if (this.PlayingSequenceNameMap.TryGetValue(sequenceName, out sequenceData))
		{
			return sequenceData.StopPromise;
		}
		return null;
	}

	// Token: 0x06008F7C RID: 36732 RVA: 0x002B2F9C File Offset: 0x002B119C
	private void OnSequenceStart(string sequenceName)
	{
		SequenceData sequenceData;
		this.PlayingSequenceNameMap.TryGetValue(sequenceName, out sequenceData);
		if (sequenceData != null && sequenceData.IsBlock)
		{
			UiLayer.Instance.SetShowMaskLayer(sequenceData.Tag, true);
		}
		if (this.OnSequenceStartEvent != null)
		{
			TSequenceStartEvent[] onSequenceStartEvent = this.OnSequenceStartEvent;
			for (int i = 0; i < onSequenceStartEvent.Length; i++)
			{
				onSequenceStartEvent[i](sequenceName);
			}
		}
	}

	// Token: 0x06008F7D RID: 36733 RVA: 0x002B2FFC File Offset: 0x002B11FC
	private void OnSequenceStop(string sequenceName)
	{
		SequenceData sequenceData;
		this.PlayingSequenceNameMap.TryGetValue(sequenceName, out sequenceData);
		bool flag = true;
		if (sequenceData != null)
		{
			if (sequenceData.IsBlock)
			{
				UiLayer.Instance.SetShowMaskLayer(sequenceData.Tag, false);
			}
			flag = sequenceData.NeedFinishEvent;
			sequenceData.NeedFinishEvent = true;
			this.PlayingSequenceNameMap.Remove(sequenceName);
		}
		if (this.CurrentSequenceName == sequenceName)
		{
			this.CurrentSequenceName = null;
		}
		if (flag && this.OnSequenceEndEvent != null)
		{
			TSequenceEndEvent[] onSequenceEndEvent = this.OnSequenceEndEvent;
			for (int i = 0; i < onSequenceEndEvent.Length; i++)
			{
				onSequenceEndEvent[i](sequenceName);
			}
		}
		if (this.PlayingSequenceNameMap.Count == 0)
		{
			LevelSequencePlayer.PlayingInstances.Remove(this);
		}
		if (((sequenceData != null) ? sequenceData.StopPromise : null) != null)
		{
			sequenceData.StopPromise.SetResult(true);
			sequenceData.StopPromise = null;
		}
	}

	// Token: 0x06008F7E RID: 36734 RVA: 0x002B30C9 File Offset: 0x002B12C9
	[return: Nullable(2)]
	private ALevelSequenceActor GetLevelSequenceActor(string sequenceName)
	{
		if (this.UiBaseActor != null)
		{
			return this.UiBaseActor.GetSequencePlayerByKey(sequenceName);
		}
		return null;
	}

	// Token: 0x06008F7F RID: 36735 RVA: 0x002B30E4 File Offset: 0x002B12E4
	public void SetActorTag(string sequenceName, FName tag, AActor actor)
	{
		ALevelSequenceActor levelSequenceActor = this.GetLevelSequenceActor(sequenceName);
		if (levelSequenceActor != null)
		{
			levelSequenceActor.AddBindingByTag(tag, actor, false, false);
		}
	}

	// Token: 0x06008F80 RID: 36736 RVA: 0x002B3108 File Offset: 0x002B1308
	public void SetRelativeTransform(string sequenceName, FTransformDouble transform)
	{
		ALevelSequenceActor levelSequenceActor = this.GetLevelSequenceActor(sequenceName);
		if (levelSequenceActor != null)
		{
			levelSequenceActor.bOverrideInstanceData = true;
			UDefaultLevelSequenceInstanceData udefaultLevelSequenceInstanceData = levelSequenceActor.DefaultInstanceData as UDefaultLevelSequenceInstanceData;
			FTransform transformOrigin = UKismetMathLibrary.Conv_TransformDoubleToTransform(transform);
			udefaultLevelSequenceInstanceData.TransformOrigin = transformOrigin;
		}
	}

	// Token: 0x06008F81 RID: 36737 RVA: 0x002B313F File Offset: 0x002B133F
	public bool IsValid()
	{
		AUIBaseActor uiBaseActor = this.UiBaseActor;
		return uiBaseActor != null && uiBaseActor.IsValid();
	}

	// Token: 0x06008F82 RID: 36738 RVA: 0x002B3154 File Offset: 0x002B1354
	public static void SetBanned(bool value)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.LevelSequencePlayer;
		ELogAuthor author = ELogAuthor.TL;
		string message = "[LevelSequencePlayer.SetBanned] 设置禁用动画";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("value", value.ToString());
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (value)
		{
			LevelSequencePlayer.Banned = true;
			using (HashSet<LevelSequencePlayer>.Enumerator enumerator = LevelSequencePlayer.PlayingInstances.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					LevelSequencePlayer levelSequencePlayer = enumerator.Current;
					if (!levelSequencePlayer.IsValid())
					{
						LevelSequencePlayer.PlayingInstances.Remove(levelSequencePlayer);
					}
					else
					{
						levelSequencePlayer.StopCurrentSequence(true, false);
					}
				}
				goto IL_88;
			}
		}
		LevelSequencePlayer.Banned = false;
		IL_88:
		EventSystem.Instance.Emit<bool>(EEventName.LevelSequencePlayerBandStateChange, value);
	}

	// Token: 0x06008F83 RID: 36739 RVA: 0x002B3208 File Offset: 0x002B1408
	public static void CreateStaticDefaultValue()
	{
		LevelSequencePlayer._playingInstances = new HashSet<LevelSequencePlayer>();
	}

	// Token: 0x06008F84 RID: 36740 RVA: 0x002B3214 File Offset: 0x002B1414
	public static void ResetStaticDefaultValue()
	{
		LevelSequencePlayer.Banned = false;
		LevelSequencePlayer.PlayingInstances.Clear();
		LevelSequencePlayer._playingInstances = null;
	}

	// Token: 0x06008F85 RID: 36741 RVA: 0x002B322C File Offset: 0x002B142C
	public static bool GetBanned()
	{
		return LevelSequencePlayer.Banned;
	}

	// Token: 0x040055C1 RID: 21953
	private readonly Dictionary<string, USequencePlayContext> PlayContextMap = new Dictionary<string, USequencePlayContext>();

	// Token: 0x040055C2 RID: 21954
	[Nullable(2)]
	private AUIBaseActor UiBaseActor;

	// Token: 0x040055C3 RID: 21955
	[Nullable(2)]
	private UUIItem UiItem;

	// Token: 0x040055C4 RID: 21956
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSequenceEndEvent[] OnSequenceEndEvent;

	// Token: 0x040055C5 RID: 21957
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSequenceStartEvent[] OnSequenceStartEvent;

	// Token: 0x040055C6 RID: 21958
	[Nullable(2)]
	private string CurrentSequenceName;

	// Token: 0x040055C7 RID: 21959
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static HashSet<LevelSequencePlayer> _playingInstances;

	// Token: 0x040055C8 RID: 21960
	private static bool Banned;

	// Token: 0x040055C9 RID: 21961
	private readonly Dictionary<string, SequenceData> PlayingSequenceNameMap = new Dictionary<string, SequenceData>();
}
