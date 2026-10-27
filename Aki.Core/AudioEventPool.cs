using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000014 RID: 20
[NullableContext(1)]
[Nullable(0)]
public class AudioEventPool
{
	// Token: 0x0600008F RID: 143 RVA: 0x00005AE4 File Offset: 0x00003CE4
	public void PreloadAudioEvent(string @event)
	{
		if (string.IsNullOrEmpty(@event))
		{
			return;
		}
		if (this.PreloadAudioEventMap.ContainsKey(@event))
		{
			return;
		}
		string path = "/Game/Aki/WwiseAudio/Events/" + @event + "." + @event;
		ResourceSystem.Instance.LoadAsync<UAkAudioEvent>(path, delegate([Nullable(2)] UAkAudioEvent audioEvent, string _)
		{
			if (audioEvent == null || !audioEvent.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Audio;
				ELogAuthor author = ELogAuthor.CWZ;
				string message = "[Core.AudioEventPool] AudioEvent 加载失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Event", @event);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (!this.PreloadAudioEventMap.ContainsKey(@event))
			{
				this.PreloadAudioEventMap[@event] = audioEvent;
			}
		}, 100, "js_undefined");
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00005B62 File Offset: 0x00003D62
	public void ReleaseAudioEvent(string @event)
	{
		if (string.IsNullOrEmpty(@event))
		{
			return;
		}
		this.PreloadAudioEventMap.Remove(@event);
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00005B7C File Offset: 0x00003D7C
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public UniTask<UAkAudioEvent> GetAudioEvent(string @event)
	{
		AudioEventPool.<GetAudioEvent>d__10 <GetAudioEvent>d__;
		<GetAudioEvent>d__.<>t__builder = AsyncUniTaskMethodBuilder<UAkAudioEvent>.Create();
		<GetAudioEvent>d__.<>4__this = this;
		<GetAudioEvent>d__.@event = @event;
		<GetAudioEvent>d__.<>1__state = -1;
		<GetAudioEvent>d__.<>t__builder.Start<AudioEventPool.<GetAudioEvent>d__10>(ref <GetAudioEvent>d__);
		return <GetAudioEvent>d__.<>t__builder.Task;
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00005BC8 File Offset: 0x00003DC8
	public void Tick(float delta)
	{
		if (!this.IsInCacheClear)
		{
			this.ElapsedTime += delta;
			if (this.ElapsedTime > (float)this.CheckInterval)
			{
				this.IsInCacheClear = true;
				this.CurrentClearIndex = this.AudioEventList.Count - 1;
				this.ElapsedTime = 0f;
			}
			return;
		}
		int num = this.CurrentClearIndex;
		while (num >= 0 && num > this.CurrentClearIndex - 5)
		{
			string key = this.AudioEventList[num];
			AudioEventPoolItem audioEventPoolItem = null;
			this.AudioEventMap.TryGetValue(key, out audioEventPoolItem);
			if (((audioEventPoolItem != null) ? audioEventPoolItem.AudioEvent : null) == null || !audioEventPoolItem.AudioEvent.IsValid())
			{
				this.AudioEventMap.Remove(key);
				this.AudioEventList.RemoveAt(num);
			}
			else if (UAkGameplayStatics.IsAudioEventActive(audioEventPoolItem.AudioEvent))
			{
				audioEventPoolItem.LastActiveTime = Time.Instance.Now;
			}
			else if (Time.Instance.Now - audioEventPoolItem.LastActiveTime >= (double)this.CacheLifeTime)
			{
				audioEventPoolItem.Destroy();
				this.AudioEventMap.Remove(key);
				this.AudioEventList.RemoveAt(num);
			}
			num--;
		}
		if (num < 0)
		{
			this.IsInCacheClear = false;
			return;
		}
		this.CurrentClearIndex = num;
	}

	// Token: 0x04000077 RID: 119
	private float ElapsedTime;

	// Token: 0x04000078 RID: 120
	private readonly int CheckInterval = 10000;

	// Token: 0x04000079 RID: 121
	private readonly int CacheLifeTime = 60000;

	// Token: 0x0400007A RID: 122
	private readonly Dictionary<string, AudioEventPoolItem> AudioEventMap = new Dictionary<string, AudioEventPoolItem>();

	// Token: 0x0400007B RID: 123
	private readonly Dictionary<string, UAkAudioEvent> PreloadAudioEventMap = new Dictionary<string, UAkAudioEvent>();

	// Token: 0x0400007C RID: 124
	private readonly List<string> AudioEventList = new List<string>();

	// Token: 0x0400007D RID: 125
	private bool IsInCacheClear;

	// Token: 0x0400007E RID: 126
	private int CurrentClearIndex;
}
