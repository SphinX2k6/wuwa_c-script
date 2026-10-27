using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x0200000D RID: 13
[NullableContext(1)]
[Nullable(0)]
public class AudioController : Singleton, ITickable
{
	// Token: 0x06000049 RID: 73 RVA: 0x00003F08 File Offset: 0x00002108
	[NullableContext(2)]
	public void PostEventByUi([Nullable(1)] string eventPath, PlayResult playResult = null, int? callbackMask = null, FOnAkPostEventCallback postEventCallback = null)
	{
		this.PostEvent(eventPath, null, playResult, callbackMask, postEventCallback, null, true, "");
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00003F30 File Offset: 0x00002130
	[NullableContext(2)]
	public void PostEvent([Nullable(1)] string eventPath, AActor actor = null, PlayResult playResult = null, int? callbackMask = null, FOnAkPostEventCallback postEventCallback = null, bool? bStopWhenAttachedToDestroyed = null, bool isFollow = true, [Nullable(1)] string eventName = "")
	{
		AudioController.<>c__DisplayClass4_0 CS$<>8__locals1 = new AudioController.<>c__DisplayClass4_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.eventPath = eventPath;
		CS$<>8__locals1.actor = actor;
		CS$<>8__locals1.callbackMask = callbackMask;
		CS$<>8__locals1.postEventCallback = postEventCallback;
		CS$<>8__locals1.bStopWhenAttachedToDestroyed = bStopWhenAttachedToDestroyed;
		CS$<>8__locals1.isFollow = isFollow;
		CS$<>8__locals1.eventName = eventName;
		CS$<>8__locals1.playResult = playResult;
		CS$<>8__locals1.playingId = new int?(0);
		if (CS$<>8__locals1.playResult != null)
		{
			CS$<>8__locals1.playResult.EventPath = CS$<>8__locals1.eventPath;
		}
		if (this.GetAudioEvent(CS$<>8__locals1.eventPath, false) != null)
		{
			CS$<>8__locals1.<PostEvent>g__doPostEvent|0();
			return;
		}
		this.LoadAndAddCallback(CS$<>8__locals1.eventPath, new Action(CS$<>8__locals1.<PostEvent>g__doPostEvent|0), CS$<>8__locals1.playResult);
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00003FE0 File Offset: 0x000021E0
	[NullableContext(2)]
	public void PostEventByComponent([Nullable(1)] string eventPath, UAkComponent component = null, PlayResult playResult = null, Action loadCallback = null, int? callbackMask = null, FOnAkPostEventCallback postEventCallback = null, bool isFollow = true)
	{
		AudioController.<>c__DisplayClass5_0 CS$<>8__locals1 = new AudioController.<>c__DisplayClass5_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.eventPath = eventPath;
		CS$<>8__locals1.component = component;
		CS$<>8__locals1.callbackMask = callbackMask;
		CS$<>8__locals1.postEventCallback = postEventCallback;
		CS$<>8__locals1.isFollow = isFollow;
		CS$<>8__locals1.playResult = playResult;
		CS$<>8__locals1.loadCallback = loadCallback;
		CS$<>8__locals1.playingId = new int?(0);
		if (CS$<>8__locals1.playResult != null)
		{
			CS$<>8__locals1.playResult.EventPath = CS$<>8__locals1.eventPath;
		}
		if (this.GetAudioEvent(CS$<>8__locals1.eventPath, false) != null)
		{
			CS$<>8__locals1.<PostEventByComponent>g__doPostEvent|0();
			return;
		}
		this.LoadAndAddCallback(CS$<>8__locals1.eventPath, new Action(CS$<>8__locals1.<PostEventByComponent>g__doPostEvent|0), CS$<>8__locals1.playResult);
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00004088 File Offset: 0x00002288
	public unsafe void StopEvent(PlayResult playResult, bool stopPlay = true, int? transitionDuration = null)
	{
		if (stopPlay && playResult.PlayingIds.Count > 0)
		{
			foreach (int playId in playResult.PlayingIds)
			{
				this.StopAudioByPlayId(playId, transitionDuration);
			}
			playResult.PlayingIds.Clear();
		}
		if (playResult.CallbackIds.Count > 0)
		{
			foreach (int num in playResult.CallbackIds)
			{
				this.DeleteAudioEventCallback(playResult.EventPath, num);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Audio;
				ELogAuthor author = ELogAuthor.ZS;
				string message = "停止加载音频";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("eventPath", playResult.EventPath);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CallbackId", num);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			playResult.CallbackIds.Clear();
		}
	}

	// Token: 0x0600004D RID: 77 RVA: 0x000041BC File Offset: 0x000023BC
	public bool LoadAudioEvent(string eventPath)
	{
		if (string.IsNullOrEmpty(eventPath))
		{
			Log.Instance.Error(ELogModule.Audio, ELogAuthor.LRA, "没有传入音频事件资源路径", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		return this.AudioPool.GetAudioPool(eventPath, true) != null;
	}

	// Token: 0x0600004E RID: 78 RVA: 0x000041FF File Offset: 0x000023FF
	public int? AddAudioEventCallback(string eventPath, Action callback)
	{
		return this.AudioPool.AddCallbackToLoad(eventPath, callback);
	}

	// Token: 0x0600004F RID: 79 RVA: 0x0000420E File Offset: 0x0000240E
	public void LoadAndAddCallback(string eventPath, Action callback, [Nullable(2)] PlayResult playResult = null)
	{
		this.AudioPool.LoadAndAddCallback(eventPath, callback, playResult);
	}

	// Token: 0x06000050 RID: 80 RVA: 0x0000421E File Offset: 0x0000241E
	private void DeleteAudioEventCallback(string eventPath, int callbackId)
	{
		this.AudioPool.DeleteCallback(eventPath, callbackId);
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00004230 File Offset: 0x00002430
	[NullableContext(2)]
	public int? PlayAudioByEventPath(string eventPath, AActor rootActor = null, int? callbackMask = null, FOnAkPostEventCallback postEventCallback = null, bool? bStopWhenAttachedToDestroyed = null, bool isFollow = true, [Nullable(1)] string eventName = "")
	{
		UAkAudioEvent audioEvent = this.GetAudioEvent(eventPath, false);
		if (string.IsNullOrEmpty(eventPath) || audioEvent == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Audio;
			ELogAuthor author = ELogAuthor.LRA;
			string message = "没有对应的音频事件资源，请检查是否已经加载！";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("eventPath", eventPath);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		this.AudioPool.SetPlayFlag(eventPath);
		int value;
		if (rootActor == null)
		{
			value = audioEvent.PostOnActor(null, postEventCallback, callbackMask.GetValueOrDefault(), false);
		}
		else if (!isFollow)
		{
			value = UAkGameplayStatics.D_PostEventAtLocation(audioEvent, rootActor.D_K2_GetActorLocation(), new FRotator(0f, 0f, 0f), eventName, rootActor.GetWorld());
		}
		else
		{
			value = UAkGameplayStatics.PostEvent(audioEvent, rootActor, callbackMask.GetValueOrDefault(), postEventCallback, bStopWhenAttachedToDestroyed.GetValueOrDefault(), eventName);
		}
		return new int?(value);
	}

	// Token: 0x06000052 RID: 82 RVA: 0x000042F8 File Offset: 0x000024F8
	[NullableContext(2)]
	private int? PlayComponentAudioByEventPath([Nullable(1)] string eventPath, UAkComponent component = null, int? callbackMask = null, FOnAkPostEventCallback postEventCallback = null, bool isFollow = true)
	{
		UAkAudioEvent audioEvent = this.GetAudioEvent(eventPath, false);
		if (audioEvent == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Audio;
			ELogAuthor author = ELogAuthor.LRA;
			string message = "没有对应的音频事件资源，请检查是否已经加载！";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("eventPath", eventPath);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		this.AudioPool.SetPlayFlag(eventPath);
		if (component == null)
		{
			return new int?(audioEvent.PostOnActor(null, postEventCallback, callbackMask.GetValueOrDefault(), false));
		}
		if (!isFollow)
		{
			return new int?(UAkGameplayStatics.D_PostEventAtLocation(audioEvent, component.D_K2_GetComponentLocation(), new FRotator(0f, 0f, 0f), "", component.GetWorld()));
		}
		return new int?(component.PostAkEvent(audioEvent, callbackMask.Value, postEventCallback, audioEvent.GetName()));
	}

	// Token: 0x06000053 RID: 83 RVA: 0x000043B8 File Offset: 0x000025B8
	[NullableContext(2)]
	public void StopAudio(AActor audioActor)
	{
		UKuroAudioStatics.StopAll(audioActor);
	}

	// Token: 0x06000054 RID: 84 RVA: 0x000043C0 File Offset: 0x000025C0
	public void StopAudioByPlayId(int playId, int? transitionDuration = null)
	{
		UAkGameplayStatics.ExecuteActionOnPlayingID(EAkActionOnEventType.Stop, playId, transitionDuration.GetValueOrDefault(), EAkCurveInterpolation.Linear);
	}

	// Token: 0x06000055 RID: 85 RVA: 0x000043D1 File Offset: 0x000025D1
	public void PauseAudioByPlayId(int playId)
	{
		UAkGameplayStatics.ExecuteActionOnPlayingID(EAkActionOnEventType.Pause, playId, 0, EAkCurveInterpolation.Linear);
	}

	// Token: 0x06000056 RID: 86 RVA: 0x000043DC File Offset: 0x000025DC
	public void ResumeAudioByPlayId(int playId)
	{
		UAkGameplayStatics.ExecuteActionOnPlayingID(EAkActionOnEventType.Resume, playId, 0, EAkCurveInterpolation.Linear);
	}

	// Token: 0x06000057 RID: 87 RVA: 0x000043E7 File Offset: 0x000025E7
	public void ExecuteActionOnEvent(UAkAudioEvent @event, EAkActionOnEventType actionType, AActor actor)
	{
		UAkGameplayStatics.ExecuteActionOnEvent(@event, actionType, actor, 0, EAkCurveInterpolation.Linear, 0);
	}

	// Token: 0x06000058 RID: 88 RVA: 0x000043F4 File Offset: 0x000025F4
	public unsafe void SetSwitch(string group, string state, AActor actor)
	{
		IReadOnlySet<string> readOnlySet;
		if (!AudioDefine.SwitchGroups.TryGetValue(group, out readOnlySet))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Audio;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "group没有在AudioDefine.SwitchGroups进行定义";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("group", group);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (readOnlySet.Count > 0 && !readOnlySet.Contains(state))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Audio;
			ELogAuthor author2 = ELogAuthor.LFJW;
			string message2 = "group不存在state定义";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("group", group);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("state", state);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		UKuroAudioStatics.SetSwitch(group, state, actor);
	}

	// Token: 0x06000059 RID: 89 RVA: 0x000044A4 File Offset: 0x000026A4
	public void SetSwitchValue([Nullable(2)] UAkSwitchValue switchValue, AActor audioActor)
	{
		UAkGameplayStatics.SetSwitch(switchValue, audioActor, null, null);
	}

	// Token: 0x0600005A RID: 90 RVA: 0x000044BC File Offset: 0x000026BC
	public unsafe void SetState(string group, string state)
	{
		IReadOnlySet<string> readOnlySet;
		if (!AudioDefine.StateGroups.TryGetValue(group, out readOnlySet))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Audio;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "group没有在AudioDefine.StateGroups进行定义";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("group", group);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (readOnlySet.Count > 0 && !readOnlySet.Contains(state))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Audio;
			ELogAuthor author2 = ELogAuthor.LFJW;
			string message2 = "group不存在state定义";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("group", group);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("state", state);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		UKuroAudioStatics.SetState(group, state);
	}

	// Token: 0x0600005B RID: 91 RVA: 0x0000456B File Offset: 0x0000276B
	public void Tick(float delta)
	{
		this.AudioPool.Tick(delta);
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00004579 File Offset: 0x00002779
	[NullableContext(2)]
	public void SetRTPCValue(float value, [Nullable(1)] string rtpc, UAkRtpc rtpcValue = null, int? interpolationTimeMs = null, AActor actor = null)
	{
		UAkGameplayStatics.SetRTPCValue(rtpcValue, value, interpolationTimeMs.GetValueOrDefault(), actor, new FName(rtpc));
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00004594 File Offset: 0x00002794
	[NullableContext(2)]
	public void GetRTPCValue(ref float retValue, [Nullable(1)] string rtpc, UAkRtpc rtpcValue = null, AActor actor = null, int playingId = 0)
	{
		ERTPCValueType ertpcvalueType = ERTPCValueType.Default;
		UAkGameplayStatics.GetRTPCValue(rtpcValue, playingId, ERTPCValueType.PlayingID, ref retValue, ref ertpcvalueType, actor, new FName(rtpc));
	}

	// Token: 0x0600005E RID: 94 RVA: 0x000045B8 File Offset: 0x000027B8
	[NullableContext(2)]
	public UAkAudioEvent GetAudioEvent(string eventPath, bool needLoad = true)
	{
		if (string.IsNullOrEmpty(eventPath))
		{
			Log.Instance.Error(ELogModule.Audio, ELogAuthor.LRA, "没有传入音频事件资源路径", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return this.AudioPool.GetAudioPool(eventPath, needLoad);
	}

	// Token: 0x0600005F RID: 95 RVA: 0x000045F8 File Offset: 0x000027F8
	[NullableContext(2)]
	public void PostEventNotInputPool([Nullable(1)] string eventPath, AActor rootActor = null, Action<UAkAudioEvent, int?> callback = null, int? callbackMask = null, FOnAkPostEventCallback postEventCallback = null, bool? bStopWhenAttachedToDestroyed = null, bool isFollow = true)
	{
		if (StringUtils.IsNothing(eventPath))
		{
			if (callback != null)
			{
				callback(null, null);
			}
			return;
		}
		ResourceSystem.Instance.LoadAsync<UAkAudioEvent>(eventPath, delegate([Nullable(2)] UAkAudioEvent audioEvent, string _)
		{
			if (audioEvent == null || !audioEvent.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Audio;
				ELogAuthor author = ELogAuthor.LRA;
				string message = "不进入缓存池音效加载资源失败：";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("eventPath: ", eventPath);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				if (callback != null)
				{
					callback(null, null);
					return;
				}
			}
			else
			{
				int value;
				if (rootActor == null)
				{
					value = audioEvent.PostOnActor(null, postEventCallback, callbackMask.GetValueOrDefault(), false);
				}
				else if (!isFollow)
				{
					value = UAkGameplayStatics.D_PostEventAtLocation(audioEvent, rootActor.D_K2_GetActorLocation(), new FRotator(0f, 0f, 0f), "", rootActor.GetWorld());
				}
				else
				{
					value = UAkGameplayStatics.PostEvent(audioEvent, rootActor, callbackMask.Value, postEventCallback, bStopWhenAttachedToDestroyed.GetValueOrDefault(), "");
				}
				if (callback != null)
				{
					callback(audioEvent, new int?(value));
				}
			}
		}, 100, "js_undefined");
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00004690 File Offset: 0x00002890
	public void PostEventByExternalSourcesByUi(string eventPath, string mediaName, string externalSourceName, [Nullable(2)] PlayResult playResult = null, [Nullable(2)] Action loadCallback = null, int? callbackMask = null, [Nullable(2)] FOnAkPostEventCallback postEventCallback = null)
	{
		this.PostEventByExternalSources(eventPath, null, mediaName, externalSourceName, playResult, loadCallback, callbackMask, postEventCallback);
	}

	// Token: 0x06000061 RID: 97 RVA: 0x000046B0 File Offset: 0x000028B0
	[NullableContext(2)]
	public unsafe void PostEventByExternalSources([Nullable(1)] string eventPath, AActor actor = null, [Nullable(1)] string mediaName = "", [Nullable(1)] string externalSourceName = "", PlayResult playResult = null, Action loadCallback = null, int? callbackMask = null, FOnAkPostEventCallback postEventCallback = null)
	{
		if (StringUtils.IsNothing(mediaName) || StringUtils.IsNothing(externalSourceName))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Audio;
			ELogAuthor author = ELogAuthor.LRA;
			string message = "输入MediaName 或者 ExternalSourceName 异常";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MediaName", mediaName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ExternalSourceName", externalSourceName);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		UWwiseExternalSourceStatics.SetExternalSourceMediaByName(externalSourceName, mediaName);
		this.PostEvent(eventPath, actor, playResult, callbackMask, postEventCallback, null, true, "");
	}

	// Token: 0x06000062 RID: 98 RVA: 0x00004747 File Offset: 0x00002947
	public void SetMultiplePositions([Nullable(2)] UAkComponent component, TArray<FTransformDouble> positions, EAkMultiPositionType? multiPositionType = null)
	{
		UAkGameplayStatics.D_SetMultiplePositions(component, positions, multiPositionType.GetValueOrDefault(EAkMultiPositionType.MultiDirections));
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00004758 File Offset: 0x00002958
	public void PostSelectableAudioEvent(string eventPath, AActor actor)
	{
		string audioKey = this.AddAudioKey(eventPath, actor.GetName());
		PlayResult playResult = this.AddAudioPlayResult(audioKey);
		if (playResult != null)
		{
			this.PostEventByUi(eventPath, playResult, null, null);
		}
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00004790 File Offset: 0x00002990
	public void StopSelectableAudioEventByName(string name)
	{
		HashSet<string> audioKeySet = this.GetAudioKeySet(name);
		if (audioKeySet == null)
		{
			return;
		}
		this.StopAudioKeySetEvent(audioKeySet);
	}

	// Token: 0x06000065 RID: 101 RVA: 0x000047B0 File Offset: 0x000029B0
	public void StopSelectableAudioEvent(AActor actor)
	{
		HashSet<string> audioKeySet = this.GetAudioKeySet(actor.GetName());
		if (audioKeySet == null)
		{
			return;
		}
		this.StopAudioKeySetEvent(audioKeySet);
	}

	// Token: 0x06000066 RID: 102 RVA: 0x000047D8 File Offset: 0x000029D8
	private void StopAudioKeySetEvent(HashSet<string> audioKeySet)
	{
		foreach (string audioKey in audioKeySet)
		{
			PlayResult andDeleteAudioPlayResult = this.GetAndDeleteAudioPlayResult(audioKey);
			if (andDeleteAudioPlayResult != null)
			{
				this.StopEvent(andDeleteAudioPlayResult, false, null);
			}
		}
	}

	// Token: 0x06000067 RID: 103 RVA: 0x0000483C File Offset: 0x00002A3C
	[return: Nullable(2)]
	private PlayResult AddAudioPlayResult(string audioKey)
	{
		if (!StringUtils.IsEmpty(audioKey))
		{
			PlayResult playResult = null;
			if (!this.AudioPlayResultMap.TryGetValue(audioKey, out playResult))
			{
				playResult = new PlayResult();
				this.AudioPlayResultMap[audioKey] = playResult;
			}
			return playResult;
		}
		return null;
	}

	// Token: 0x06000068 RID: 104 RVA: 0x0000487C File Offset: 0x00002A7C
	private void ClearAudioPlay()
	{
		foreach (HashSet<string> audioKeySet in this.AudioKeyMap.Values)
		{
			this.StopAudioKeySetEvent(audioKeySet);
		}
		this.AudioKeyMap.Clear();
		this.AudioPlayResultMap.Clear();
	}

	// Token: 0x06000069 RID: 105 RVA: 0x000048EC File Offset: 0x00002AEC
	[return: Nullable(2)]
	private PlayResult GetAndDeleteAudioPlayResult(string audioKey)
	{
		PlayResult result = null;
		if (this.AudioPlayResultMap.TryGetValue(audioKey, out result))
		{
			this.AudioPlayResultMap.Remove(audioKey);
		}
		return result;
	}

	// Token: 0x0600006A RID: 106 RVA: 0x0000491C File Offset: 0x00002B1C
	private string AddAudioKey(string eventPath, string actorName)
	{
		string text = eventPath + "_" + actorName;
		HashSet<string> hashSet;
		if (!this.AudioKeyMap.TryGetValue(actorName, out hashSet))
		{
			hashSet = new HashSet<string>();
			this.AudioKeyMap[actorName] = hashSet;
		}
		hashSet.Add(text);
		return text;
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00004964 File Offset: 0x00002B64
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	private HashSet<string> GetAudioKeySet(string audioKey)
	{
		HashSet<string> result = null;
		this.AudioKeyMap.TryGetValue(audioKey, out result);
		return result;
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00004983 File Offset: 0x00002B83
	public void Clear()
	{
		this.ClearAudioPlay();
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x0600006D RID: 109 RVA: 0x0000498B File Offset: 0x00002B8B
	public static AudioController Instance
	{
		get
		{
			if (AudioController._instance == null)
			{
				AudioController._instance = new AudioController();
				AudioController._instance.OnInit();
			}
			return AudioController._instance;
		}
	}

	// Token: 0x0600006E RID: 110 RVA: 0x000049AE File Offset: 0x00002BAE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600006F RID: 111 RVA: 0x000049B0 File Offset: 0x00002BB0
	public static void ResetStaticDefaultValue()
	{
		AudioController instance = AudioController._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		AudioController._instance = null;
	}

	// Token: 0x06000070 RID: 112 RVA: 0x000049C9 File Offset: 0x00002BC9
	static AudioController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AudioController.CreateStaticDefaultValue), new Action(AudioController.ResetStaticDefaultValue));
	}

	// Token: 0x0400004A RID: 74
	private readonly AudioPool AudioPool = new AudioPool();

	// Token: 0x0400004B RID: 75
	private readonly Dictionary<string, HashSet<string>> AudioKeyMap = new Dictionary<string, HashSet<string>>();

	// Token: 0x0400004C RID: 76
	private readonly Dictionary<string, PlayResult> AudioPlayResultMap = new Dictionary<string, PlayResult>();

	// Token: 0x0400004D RID: 77
	private readonly Stat StatPlayAudioByEventPath = Stat.Create("PlayAudioByEventPath", "", "");

	// Token: 0x0400004E RID: 78
	[Nullable(2)]
	private static AudioController _instance;
}
