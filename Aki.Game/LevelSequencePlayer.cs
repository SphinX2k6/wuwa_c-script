using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020018FC RID: 6396
[NullableContext(1)]
[Nullable(0)]
public class LevelSequencePlayer : IStaticVariableResetter
{
	// Token: 0x0600BB78 RID: 47992 RVA: 0x002A7EB1 File Offset: 0x002A60B1
	static LevelSequencePlayer()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LevelSequencePlayer.CreateStaticDefaultValue), new Action(LevelSequencePlayer.ResetStaticDefaultValue));
	}

	// Token: 0x17000F9C RID: 3996
	// (get) Token: 0x0600BB79 RID: 47993 RVA: 0x002A7ED0 File Offset: 0x002A60D0
	private static HashSet<LevelSequencePlayer> PlayingInstances
	{
		get
		{
			return LevelSequencePlayer._playingInstances;
		}
	}

	// Token: 0x0600BB7A RID: 47994 RVA: 0x002A7ED8 File Offset: 0x002A60D8
	[NullableContext(2)]
	public LevelSequencePlayer(UUIItem uiItem = null)
	{
		this.UiItem = uiItem;
		this.UiBaseActor = (((uiItem != null) ? uiItem.GetOwner() : null) as AUIBaseActor);
		this.UiBaseActor.OnPreDestroyed.Add(new Action<AActor>(this.AutoDestroy));
	}

	// Token: 0x0600BB7B RID: 47995 RVA: 0x002A7F3B File Offset: 0x002A613B
	[NullableContext(2)]
	private void AutoDestroy(AActor _)
	{
		this.Clear();
	}

	// Token: 0x0600BB7C RID: 47996 RVA: 0x002A7F44 File Offset: 0x002A6144
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

	// Token: 0x0600BB7D RID: 47997 RVA: 0x002A7FAC File Offset: 0x002A61AC
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

	// Token: 0x0600BB7E RID: 47998 RVA: 0x002A7FFC File Offset: 0x002A61FC
	public void StopCurrentSequence(bool needEvent = false, bool toLastFrame = false)
	{
		if (this.CurrentSequenceName == null)
		{
			return;
		}
		this.StopSequenceByKey(this.CurrentSequenceName, needEvent, toLastFrame);
		this.CurrentSequenceName = null;
	}

	// Token: 0x0600BB7F RID: 47999 RVA: 0x002A801C File Offset: 0x002A621C
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

	// Token: 0x0600BB80 RID: 48000 RVA: 0x002A807C File Offset: 0x002A627C
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

	// Token: 0x0600BB81 RID: 48001 RVA: 0x002A8114 File Offset: 0x002A6314
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

	// Token: 0x0600BB82 RID: 48002 RVA: 0x002A8170 File Offset: 0x002A6370
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

	// Token: 0x0600BB83 RID: 48003 RVA: 0x002A81D1 File Offset: 0x002A63D1
	[NullableContext(2)]
	public string GetCurrentSequence()
	{
		return this.CurrentSequenceName;
	}

	// Token: 0x0600BB84 RID: 48004 RVA: 0x002A81DC File Offset: 0x002A63DC
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

	// Token: 0x0600BB85 RID: 48005 RVA: 0x002A8298 File Offset: 0x002A6498
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

	// Token: 0x0600BB86 RID: 48006 RVA: 0x002A83C8 File Offset: 0x002A65C8
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

	// Token: 0x0600BB87 RID: 48007 RVA: 0x002A84D8 File Offset: 0x002A66D8
	public void StopPlayingSequence(bool needEvent = false, bool toLastFrame = true)
	{
		foreach (string sequenceName in new List<string>(this.PlayingSequenceNameMap.Keys))
		{
			this.StopSequenceByKey(sequenceName, needEvent, toLastFrame);
		}
	}

	// Token: 0x0600BB88 RID: 48008 RVA: 0x002A8538 File Offset: 0x002A6738
	public bool IsPlayingSequence(string sequenceName)
	{
		return this.PlayingSequenceNameMap.ContainsKey(sequenceName);
	}

	// Token: 0x0600BB89 RID: 48009 RVA: 0x002A8548 File Offset: 0x002A6748
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

	// Token: 0x0600BB8A RID: 48010 RVA: 0x002A85AC File Offset: 0x002A67AC
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

	// Token: 0x0600BB8B RID: 48011 RVA: 0x002A85EC File Offset: 0x002A67EC
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

	// Token: 0x0600BB8C RID: 48012 RVA: 0x002A8629 File Offset: 0x002A6829
	public void PlayOrReplaySequenceByName(string sequenceName, bool blockClick = false, float? playRate = null)
	{
		if (this.CheckSeqActorIsSeqPlaying(sequenceName))
		{
			this.ReplaySequenceByKey(sequenceName);
			return;
		}
		this.PlaySequencePurely(sequenceName, blockClick, false, null, playRate, false);
	}

	// Token: 0x0600BB8D RID: 48013 RVA: 0x002A8648 File Offset: 0x002A6848
	public void PlayLevelSequenceByName(string sequenceName, bool blockClick = false, float? playRate = null, bool bJumpToLastFrame = false)
	{
		this.PlaySequencePurely(sequenceName, blockClick, false, null, playRate, bJumpToLastFrame);
	}

	// Token: 0x0600BB8E RID: 48014 RVA: 0x002A8658 File Offset: 0x002A6858
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

	// Token: 0x0600BB8F RID: 48015 RVA: 0x002A86D0 File Offset: 0x002A68D0
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

	// Token: 0x0600BB90 RID: 48016 RVA: 0x002A8790 File Offset: 0x002A6990
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

	// Token: 0x0600BB91 RID: 48017 RVA: 0x002A8818 File Offset: 0x002A6A18
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

	// Token: 0x0600BB92 RID: 48018 RVA: 0x002A8840 File Offset: 0x002A6A40
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

	// Token: 0x0600BB93 RID: 48019 RVA: 0x002A88A0 File Offset: 0x002A6AA0
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

	// Token: 0x0600BB94 RID: 48020 RVA: 0x002A896D File Offset: 0x002A6B6D
	[return: Nullable(2)]
	private ALevelSequenceActor GetLevelSequenceActor(string sequenceName)
	{
		if (this.UiBaseActor != null)
		{
			return this.UiBaseActor.GetSequencePlayerByKey(sequenceName);
		}
		return null;
	}

	// Token: 0x0600BB95 RID: 48021 RVA: 0x002A8988 File Offset: 0x002A6B88
	public void SetActorTag(string sequenceName, FName tag, AActor actor)
	{
		ALevelSequenceActor levelSequenceActor = this.GetLevelSequenceActor(sequenceName);
		if (levelSequenceActor != null)
		{
			levelSequenceActor.AddBindingByTag(tag, actor, false, false);
		}
	}

	// Token: 0x0600BB96 RID: 48022 RVA: 0x002A89AC File Offset: 0x002A6BAC
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

	// Token: 0x0600BB97 RID: 48023 RVA: 0x002A89E3 File Offset: 0x002A6BE3
	public bool IsValid()
	{
		AUIBaseActor uiBaseActor = this.UiBaseActor;
		return uiBaseActor != null && uiBaseActor.IsValid();
	}

	// Token: 0x0600BB98 RID: 48024 RVA: 0x002A89F8 File Offset: 0x002A6BF8
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

	// Token: 0x0600BB99 RID: 48025 RVA: 0x002A8AAC File Offset: 0x002A6CAC
	public static void CreateStaticDefaultValue()
	{
		LevelSequencePlayer._playingInstances = new HashSet<LevelSequencePlayer>();
	}

	// Token: 0x0600BB9A RID: 48026 RVA: 0x002A8AB8 File Offset: 0x002A6CB8
	public static void ResetStaticDefaultValue()
	{
		LevelSequencePlayer.Banned = false;
		LevelSequencePlayer.PlayingInstances.Clear();
		LevelSequencePlayer._playingInstances = null;
	}

	// Token: 0x0600BB9B RID: 48027 RVA: 0x002A8AD0 File Offset: 0x002A6CD0
	public static bool GetBanned()
	{
		return LevelSequencePlayer.Banned;
	}

	// Token: 0x04005516 RID: 21782
	private readonly Dictionary<string, USequencePlayContext> PlayContextMap = new Dictionary<string, USequencePlayContext>();

	// Token: 0x04005517 RID: 21783
	[Nullable(2)]
	private AUIBaseActor UiBaseActor;

	// Token: 0x04005518 RID: 21784
	[Nullable(2)]
	private UUIItem UiItem;

	// Token: 0x04005519 RID: 21785
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSequenceEndEvent[] OnSequenceEndEvent;

	// Token: 0x0400551A RID: 21786
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSequenceStartEvent[] OnSequenceStartEvent;

	// Token: 0x0400551B RID: 21787
	[Nullable(2)]
	private string CurrentSequenceName;

	// Token: 0x0400551C RID: 21788
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static HashSet<LevelSequencePlayer> _playingInstances;

	// Token: 0x0400551D RID: 21789
	private static bool Banned;

	// Token: 0x0400551E RID: 21790
	private readonly Dictionary<string, SequenceData> PlayingSequenceNameMap = new Dictionary<string, SequenceData>();
}
