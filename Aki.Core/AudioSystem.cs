using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02000021 RID: 33
[NullableContext(1)]
[Nullable(0)]
public class AudioSystem : Singleton, ITickable
{
	// Token: 0x060000BE RID: 190 RVA: 0x00006876 File Offset: 0x00004A76
	public void Tick(float delta)
	{
		this.AudioEventPool.Tick(delta);
	}

	// Token: 0x060000BF RID: 191 RVA: 0x00006884 File Offset: 0x00004A84
	public int PostEvent(string @event)
	{
		return this.PostEventInternal(@event, null, null);
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x000068AA File Offset: 0x00004AAA
	public int PostEvent(string @event, [Nullable(2)] AActor target = null, PostEventArgs? args = null)
	{
		SharpherealAssert.Ensure(target == null || target.IsValid());
		return this.PostEventInternal(@event, new OneOf<AActor, UAkComponent, FTransformDouble>?(target), args);
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x000068D1 File Offset: 0x00004AD1
	public int PostEvent(string @event, [Nullable(2)] UAkComponent target = null, PostEventArgs? args = null)
	{
		return this.PostEventInternal(@event, new OneOf<AActor, UAkComponent, FTransformDouble>?(target), args);
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x000068E8 File Offset: 0x00004AE8
	public int PostEvent(string @event, FTransformDouble? target = null, PostEventArgs? args = null)
	{
		FTransformDouble? ftransformDouble = target;
		return this.PostEventInternal(@event, (ftransformDouble != null) ? new OneOf<AActor, UAkComponent, FTransformDouble>?(ftransformDouble.GetValueOrDefault()) : null, args);
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x00006924 File Offset: 0x00004B24
	private int PostEventInternal(string @event, [Nullable(new byte[]
	{
		0,
		1,
		1
	})] OneOf<AActor, UAkComponent, FTransformDouble>? target, PostEventArgs? args = null)
	{
		AudioSystem.<>c__DisplayClass11_0 CS$<>8__locals1 = new AudioSystem.<>c__DisplayClass11_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.@event = @event;
		CS$<>8__locals1.target = target;
		CS$<>8__locals1.args = args;
		if (string.IsNullOrEmpty(CS$<>8__locals1.@event) || CS$<>8__locals1.@event == "None" || CS$<>8__locals1.@event == "none")
		{
			return 0;
		}
		return this.ExecutionQueue.Enqueue(delegate(int handle)
		{
			AudioSystem.<>c__DisplayClass11_0.<<PostEventInternal>b__0>d <<PostEventInternal>b__0>d;
			<<PostEventInternal>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<PostEventInternal>b__0>d.<>4__this = CS$<>8__locals1;
			<<PostEventInternal>b__0>d.handle = handle;
			<<PostEventInternal>b__0>d.<>1__state = -1;
			<<PostEventInternal>b__0>d.<>t__builder.Start<AudioSystem.<>c__DisplayClass11_0.<<PostEventInternal>b__0>d>(ref <<PostEventInternal>b__0>d);
			return <<PostEventInternal>b__0>d.<>t__builder.Task;
		});
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x000069A0 File Offset: 0x00004BA0
	[NullableContext(0)]
	private UniTask<int> PostEventImpl([Nullable(1)] string @event, [Nullable(new byte[]
	{
		0,
		1,
		1
	})] OneOf<AActor, UAkComponent, FTransformDouble>? target, PostEventArgs args)
	{
		AudioSystem.<PostEventImpl>d__12 <PostEventImpl>d__;
		<PostEventImpl>d__.<>t__builder = AsyncUniTaskMethodBuilder<int>.Create();
		<PostEventImpl>d__.<>4__this = this;
		<PostEventImpl>d__.@event = @event;
		<PostEventImpl>d__.target = target;
		<PostEventImpl>d__.args = args;
		<PostEventImpl>d__.<>1__state = -1;
		<PostEventImpl>d__.<>t__builder.Start<AudioSystem.<PostEventImpl>d__12>(ref <PostEventImpl>d__);
		return <PostEventImpl>d__.<>t__builder.Task;
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x000069FB File Offset: 0x00004BFB
	private unsafe FOnAkPostEventCallback CreateCallbackDelegate(string @event, [Nullable(2)] Action<EAkCallbackType, UAkCallbackInfo> handler)
	{
		Action<EAkCallbackType, UAkCallbackInfo> callback = null;
		callback = delegate(EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
		{
			Action<EAkCallbackType, UAkCallbackInfo> handler2 = handler;
			if (handler2 != null)
			{
				handler2(callbackType, callbackInfo);
			}
			if (callbackType == EAkCallbackType.EndOfEvent)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(callback);
				int playingID = (callbackInfo as UAkEventCallbackInfo).PlayingID;
				int? num = null;
				int value;
				if (this.PlayingIdToHandle.TryGetValue(playingID, out value))
				{
					num = new int?(value);
					this.PlayingIdToHandle.Remove(playingID);
					this.HandleToPlayingId.Remove(num.Value);
				}
				if (@event == "play_external_vo_subtitle_assist")
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Audio;
					ELogAuthor author = ELogAuthor.MSY;
					string message = "[Core.AudioSystem] EndOfEvent 回调执行";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PlayingId", playingID);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Event", @event);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
			}
		};
		return DelegateUtils.ToManualReleaseDelegate<FOnAkPostEventCallback>(callback);
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x00006A3C File Offset: 0x00004C3C
	public void ExecuteAction(string @event, EAudioActionType action, ExecuteActionArgs? args = null)
	{
		if (string.IsNullOrEmpty(@event))
		{
			Log.Instance.Error(ELogModule.Audio, ELogAuthor.CWZ, "[Core.AudioSystem] 空的音频事件event参数", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		bool withActor = args != null && args.Value.Actor != null;
		this.ExecutionQueue.Enqueue(delegate(int handle)
		{
			if (withActor && !args.Value.Actor.IsValid())
			{
				Log.Instance.Warn(ELogModule.Audio, ELogAuthor.MSY, "[Core.AudioSystem] 绑定的 Actor 已失效，跳过执行", default(ReadOnlySpan<ValueTuple<string, object>>));
				return UniTask.CompletedTask;
			}
			ExecuteActionArgs valueOrDefault = args.GetValueOrDefault();
			UKuroAudioStatics.ExecuteActionOnEventName(@event, action, valueOrDefault.Actor, valueOrDefault.TransitionDuration.GetValueOrDefault(500), valueOrDefault.TransitionFadeCurve.GetValueOrDefault(EAudioFadeCurve.Linear));
			return UniTask.CompletedTask;
		});
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x00006AD0 File Offset: 0x00004CD0
	public void ExecuteAction(int handle, EAudioActionType action, ExecuteActionArgs? args = null)
	{
		if (action == EAudioActionType.Stop && this.ExecutionQueue.Cancel(handle))
		{
			return;
		}
		this.ExecutionQueue.Enqueue(delegate(int h)
		{
			int? num = null;
			int value;
			if (this.HandleToPlayingId.TryGetValue(handle, out value))
			{
				num = new int?(value);
			}
			if (num != null)
			{
				ExecuteActionArgs valueOrDefault = args.GetValueOrDefault();
				UKuroAudioStatics.ExecuteActionOnPlayingId(num.Value, action, valueOrDefault.TransitionDuration.GetValueOrDefault(500), valueOrDefault.TransitionFadeCurve.GetValueOrDefault(EAudioFadeCurve.Linear));
			}
			return UniTask.CompletedTask;
		});
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x00006B34 File Offset: 0x00004D34
	public void SeekOnEvent(string @event, int position, SeekOnEventArgs? args = null)
	{
		if (string.IsNullOrEmpty(@event))
		{
			Log.Instance.Error(ELogModule.Audio, ELogAuthor.CWZ, "[Core.AudioSystem] 空的音频事件event参数", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		bool withActor = args != null && args.Value.Actor != null;
		this.ExecutionQueue.Enqueue(delegate(int handle)
		{
			if (withActor && !args.Value.Actor.IsValid())
			{
				Log.Instance.Warn(ELogModule.Audio, ELogAuthor.MSY, "[Core.AudioSystem] 绑定的 Actor 已失效，跳过执行", default(ReadOnlySpan<ValueTuple<string, object>>));
				return UniTask.CompletedTask;
			}
			SeekOnEventArgs valueOrDefault = args.GetValueOrDefault();
			if (valueOrDefault.Handle == null)
			{
				UKuroAudioStatics.SeekOnEventName(@event, position, valueOrDefault.Actor, 0, valueOrDefault.SnapToMarker.GetValueOrDefault());
			}
			else
			{
				int? num = null;
				int value;
				if (this.HandleToPlayingId.TryGetValue(valueOrDefault.Handle.Value, out value))
				{
					num = new int?(value);
				}
				if (num != null)
				{
					UKuroAudioStatics.SeekOnEventName(@event, position, valueOrDefault.Actor, num.Value, valueOrDefault.SnapToMarker.GetValueOrDefault());
				}
			}
			return UniTask.CompletedTask;
		});
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x00006BD0 File Offset: 0x00004DD0
	public unsafe int? GetSourcePlayPosition(int handle, bool needLog = false)
	{
		int? num = null;
		int value;
		if (!this.HandleToPlayingId.TryGetValue(handle, out value))
		{
			if (needLog)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Audio;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[Core.AudioSystem] GetSourcePlayPosition";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("playingId", num);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return null;
		}
		num = new int?(value);
		int sourcePlayPosition = UKuroAudioStatics.GetSourcePlayPosition(num.Value, false);
		if (sourcePlayPosition == -1 && needLog)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Audio;
			ELogAuthor author2 = ELogAuthor.CH;
			string message2 = "[Core.AudioSystem] GetSourcePlayPosition";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("playingId", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("position", sourcePlayPosition);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		if (sourcePlayPosition != -1)
		{
			return new int?(sourcePlayPosition);
		}
		return null;
	}

	// Token: 0x060000CA RID: 202 RVA: 0x00006CC0 File Offset: 0x00004EC0
	public unsafe int? GetSourcePlayPositionWithExtrapolation(int handle, bool needLog = false)
	{
		int? num = null;
		int value;
		if (!this.HandleToPlayingId.TryGetValue(handle, out value))
		{
			if (needLog)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Audio;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[Core.AudioSystem] GetSourcePlayPositionWithExtrapolation";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("playingId", num);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return null;
		}
		num = new int?(value);
		int sourcePlayPosition = UKuroAudioStatics.GetSourcePlayPosition(num.Value, false);
		if (sourcePlayPosition == -1 && needLog)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Audio;
			ELogAuthor author2 = ELogAuthor.CH;
			string message2 = "[Core.AudioSystem] GetSourcePlayPosition";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("playingId", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("position", sourcePlayPosition);
			instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		if (sourcePlayPosition > 0)
		{
			return new int?(sourcePlayPosition);
		}
		return null;
	}

	// Token: 0x060000CB RID: 203 RVA: 0x00006DB0 File Offset: 0x00004FB0
	public unsafe void SetSwitch(string group, string state, AActor actor)
	{
		IReadOnlySet<string> readOnlySet;
		if (!AudioDefine.SwitchGroups.TryGetValue(group, out readOnlySet))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Audio;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "AudioDefine.SwitchGroups不存在group的定义";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("group", group);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (readOnlySet.Count > 0 && !readOnlySet.Contains(state))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Audio;
			ELogAuthor author2 = ELogAuthor.LFJW;
			string message2 = "AudioDefine.SwitchGroups的group不存在state的定义";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("group", group);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("state", state);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		this.ExecutionQueue.Enqueue(delegate(int handle)
		{
			if (actor == null || !actor.IsValid())
			{
				Log.Instance.Warn(ELogModule.Audio, ELogAuthor.MSY, "[Core.AudioSystem] 绑定的 Actor 已失效，跳过执行", default(ReadOnlySpan<ValueTuple<string, object>>));
				return UniTask.CompletedTask;
			}
			UKuroAudioStatics.SetSwitch(group, state, actor);
			return UniTask.CompletedTask;
		});
	}

	// Token: 0x060000CC RID: 204 RVA: 0x00006EA4 File Offset: 0x000050A4
	public unsafe void SetState(string group, string state, bool check = true)
	{
		if (check)
		{
			IReadOnlySet<string> readOnlySet;
			if (!AudioDefine.StateGroups.TryGetValue(group, out readOnlySet))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Audio;
				ELogAuthor author = ELogAuthor.LFJW;
				string message = "AudioDefine.StateGroups不存在group的定义";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("group", group);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (readOnlySet.Count > 0 && !readOnlySet.Contains(state))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Audio;
				ELogAuthor author2 = ELogAuthor.LFJW;
				string message2 = "AudioDefine.StateGroups的group不存在state的定义";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("group", group);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("state", state);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
		}
		this.ExecutionQueue.Enqueue(delegate(int handle)
		{
			UKuroAudioStatics.SetState(group, state);
			return UniTask.CompletedTask;
		});
	}

	// Token: 0x060000CD RID: 205 RVA: 0x00006F98 File Offset: 0x00005198
	public void SetRtpcValue(string rtpc, float value, SetRtpcValueArgs? args = null)
	{
		SetRtpcValueArgs actualArgs = args.GetValueOrDefault();
		bool withActor = args != null && actualArgs.Actor != null;
		this.ExecutionQueue.Enqueue(delegate(int handle)
		{
			if (withActor && !actualArgs.Actor.IsValid())
			{
				Log.Instance.Warn(ELogModule.Audio, ELogAuthor.MSY, "[Core.AudioSystem] 绑定的 Actor 已失效，跳过执行", default(ReadOnlySpan<ValueTuple<string, object>>));
				return UniTask.CompletedTask;
			}
			UKuroAudioStatics.SetRtpcValue(rtpc, value, actualArgs.Actor, actualArgs.TransitionDuration.GetValueOrDefault(), actualArgs.TransitionFadeCurve.GetValueOrDefault(EAudioFadeCurve.Linear));
			return UniTask.CompletedTask;
		});
	}

	// Token: 0x060000CE RID: 206 RVA: 0x00007000 File Offset: 0x00005200
	public void StopAll(AActor actor)
	{
		this.ExecutionQueue.Enqueue(delegate(int handle)
		{
			if (actor == null || !actor.IsValid())
			{
				Log.Instance.Warn(ELogModule.Audio, ELogAuthor.MSY, "[Core.AudioSystem] 绑定的 Actor 已失效，跳过执行", default(ReadOnlySpan<ValueTuple<string, object>>));
				return UniTask.CompletedTask;
			}
			UKuroAudioStatics.StopAll(actor);
			return UniTask.CompletedTask;
		});
	}

	// Token: 0x060000CF RID: 207 RVA: 0x00007034 File Offset: 0x00005234
	[NullableContext(2)]
	public UAkComponent GetAkComponent([Nullable(new byte[]
	{
		0,
		1,
		1
	})] OneOf<AActor, USceneComponent> target, string socketName = null, [Nullable(new byte[]
	{
		2,
		1,
		1
	})] Action<AActor, UAkComponent> onCreated = null)
	{
		FName socketName2 = FName.NAME_None;
		if (!string.IsNullOrEmpty(socketName))
		{
			socketName2 = (FNameUtil.GetDynamicFName(socketName) ?? FName.NAME_None);
		}
		return this.GetAkComponentInternal(target, socketName2, onCreated);
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x00007078 File Offset: 0x00005278
	[NullableContext(2)]
	public UAkComponent GetAkComponent([Nullable(new byte[]
	{
		0,
		1,
		1
	})] OneOf<AActor, USceneComponent> target, FName? socketName = null, [Nullable(new byte[]
	{
		2,
		1,
		1
	})] Action<AActor, UAkComponent> onCreated = null)
	{
		return this.GetAkComponentInternal(target, socketName ?? FName.NAME_None, onCreated);
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x000070A8 File Offset: 0x000052A8
	[NullableContext(2)]
	private UAkComponent GetAkComponentInternal([Nullable(new byte[]
	{
		0,
		1,
		1
	})] OneOf<AActor, USceneComponent> target, FName socketName, [Nullable(new byte[]
	{
		2,
		1,
		1
	})] Action<AActor, UAkComponent> onCreated = null)
	{
		UAkComponent uakComponent = null;
		bool flag = false;
		if (target.IsT1)
		{
			uakComponent = UKuroAudioStatics.GetAkComponent(target.AsT1.RootComponent, socketName, ref flag);
		}
		else if (target.IsT2)
		{
			uakComponent = UKuroAudioStatics.GetAkComponent(target.AsT2, socketName, ref flag);
		}
		if (!flag)
		{
			return uakComponent;
		}
		AActor aactor = (uakComponent != null) ? uakComponent.GetOwner() : null;
		if (onCreated != null && aactor != null && uakComponent != null)
		{
			onCreated(aactor, uakComponent);
		}
		return uakComponent;
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x00007118 File Offset: 0x00005318
	public void PreloadAudioEvent(string @event)
	{
		this.AudioEventPool.PreloadAudioEvent(@event);
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x00007126 File Offset: 0x00005326
	public void ReleaseAudioEvent(string @event)
	{
		this.AudioEventPool.ReleaseAudioEvent(@event);
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x00007134 File Offset: 0x00005334
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public UniTask<UAkAudioEvent> GetAudioEvent(string @event)
	{
		AudioSystem.<GetAudioEvent>d__28 <GetAudioEvent>d__;
		<GetAudioEvent>d__.<>t__builder = AsyncUniTaskMethodBuilder<UAkAudioEvent>.Create();
		<GetAudioEvent>d__.<>4__this = this;
		<GetAudioEvent>d__.@event = @event;
		<GetAudioEvent>d__.<>1__state = -1;
		<GetAudioEvent>d__.<>t__builder.Start<AudioSystem.<GetAudioEvent>d__28>(ref <GetAudioEvent>d__);
		return <GetAudioEvent>d__.<>t__builder.Task;
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x00007180 File Offset: 0x00005380
	[return: Nullable(2)]
	public unsafe string parseAudioEventPathInConfig(string path)
	{
		Match match = Regex.Match(path, "^/Game/Aki/WwiseAudio/Events/(?<name>\\w+)");
		if (!match.Success)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Audio;
			ELogAuthor author = ELogAuthor.MSY;
			string message = "[Core.AudioSystem] 非法的 AudioEvent 路径";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("path", path);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("reason", "未在 /Game/Aki/WwiseAudio/Events/ 路径下或命名不符合规范");
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		if (!match.Success)
		{
			return null;
		}
		return match.Groups["name"].Value;
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x00007218 File Offset: 0x00005418
	[return: Nullable(2)]
	public string parseAudioEventPath(string source)
	{
		if (string.IsNullOrEmpty(source))
		{
			return null;
		}
		string[] array = source.Split('.', StringSplitOptions.None);
		if (array.Length == 0)
		{
			return null;
		}
		return array[array.Length - 1].ToLower();
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x0000724C File Offset: 0x0000544C
	[return: Nullable(2)]
	public string parseAudioEventPath(TSoftObjectPtr<UAkAudioEvent> source)
	{
		string source2 = source.ToAssetPathName();
		return this.parseAudioEventPath(source2);
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x060000D8 RID: 216 RVA: 0x00007267 File Offset: 0x00005467
	public static AudioSystem Instance
	{
		get
		{
			if (AudioSystem._instance == null)
			{
				AudioSystem._instance = new AudioSystem();
				AudioSystem._instance.OnInit();
			}
			return AudioSystem._instance;
		}
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x0000728A File Offset: 0x0000548A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060000DA RID: 218 RVA: 0x0000728C File Offset: 0x0000548C
	public static void ResetStaticDefaultValue()
	{
		AudioSystem instance = AudioSystem._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		AudioSystem._instance = null;
	}

	// Token: 0x060000DB RID: 219 RVA: 0x000072A5 File Offset: 0x000054A5
	static AudioSystem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AudioSystem.CreateStaticDefaultValue), new Action(AudioSystem.ResetStaticDefaultValue));
	}

	// Token: 0x040000B3 RID: 179
	public const int INVALID_PLAYING_ID = 0;

	// Token: 0x040000B4 RID: 180
	public const int INVALID_AUDIO_EVENT_VALUE = 0;

	// Token: 0x040000B5 RID: 181
	private readonly AudioEventPool AudioEventPool = new AudioEventPool();

	// Token: 0x040000B6 RID: 182
	private readonly ExecutionQueue ExecutionQueue = new ExecutionQueue();

	// Token: 0x040000B7 RID: 183
	private readonly Dictionary<int, int> HandleToPlayingId = new Dictionary<int, int>();

	// Token: 0x040000B8 RID: 184
	private readonly Dictionary<int, int> PlayingIdToHandle = new Dictionary<int, int>();

	// Token: 0x040000B9 RID: 185
	[Nullable(2)]
	private static AudioSystem _instance;
}
