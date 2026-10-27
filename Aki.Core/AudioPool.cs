using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000019 RID: 25
[NullableContext(1)]
[Nullable(0)]
public class AudioPool
{
	// Token: 0x060000AA RID: 170 RVA: 0x00006174 File Offset: 0x00004374
	[return: Nullable(2)]
	public UAkAudioEvent GetAudioPool(string path, bool needLoad = true)
	{
		AudioPoolItem audioPoolItem = null;
		if (this.AudioPoolMap.TryGetValue(path, out audioPoolItem))
		{
			return audioPoolItem.AudioEvent;
		}
		if (!needLoad)
		{
			return null;
		}
		this.AudioPoolMap[path] = new AudioPoolItem(path);
		this.LoadEventAsync(path, delegate(UAkAudioEvent audioEvent)
		{
			AudioPoolItem audioPoolItem2 = null;
			if (this.AudioPoolMap.TryGetValue(path, out audioPoolItem2))
			{
				audioPoolItem2.AudioEvent = audioEvent;
				audioPoolItem2.DoCallback();
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Audio;
			ELogAuthor author = ELogAuthor.LRA;
			string message = "GetAudioPool 没有找到对应路径的音效缓存！";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", path);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		});
		return null;
	}

	// Token: 0x060000AB RID: 171 RVA: 0x000061F0 File Offset: 0x000043F0
	public int? AddCallbackToLoad(string path, Action callback)
	{
		AudioPoolItem audioPoolItem = null;
		if (this.AudioPoolMap.TryGetValue(path, out audioPoolItem))
		{
			return new int?(audioPoolItem.AddCallback(callback));
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Audio;
		ELogAuthor author = ELogAuthor.LRA;
		string message = "AddCallbackToLoad 没有找到对应路径的音效缓存！";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", path);
		instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x060000AC RID: 172 RVA: 0x0000624C File Offset: 0x0000444C
	public void LoadAndAddCallback(string path, Action callback, [Nullable(2)] PlayResult playResult)
	{
		AudioPoolItem audioPoolItem = null;
		if (!this.AudioPoolMap.TryGetValue(path, out audioPoolItem))
		{
			audioPoolItem = new AudioPoolItem(path);
			this.AudioPoolMap[path] = audioPoolItem;
		}
		int id = audioPoolItem.AddCallback(callback);
		if (playResult != null)
		{
			playResult.AddCallbackId(id);
		}
		this.LoadEventAsync(path, delegate(UAkAudioEvent audioEvent)
		{
			AudioPoolItem audioPoolItem2 = null;
			if (this.AudioPoolMap.TryGetValue(path, out audioPoolItem2))
			{
				audioPoolItem2.AudioEvent = audioEvent;
				audioPoolItem2.DoCallback();
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Audio;
			ELogAuthor author = ELogAuthor.ZS;
			string message = "LoadAndAddCallback 没有找到对应路径的音效缓存！";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", path);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		});
	}

	// Token: 0x060000AD RID: 173 RVA: 0x000062CC File Offset: 0x000044CC
	public void DeleteCallback(string path, int callbackId)
	{
		AudioPoolItem audioPoolItem = null;
		if (this.AudioPoolMap.TryGetValue(path, out audioPoolItem))
		{
			audioPoolItem.DeleteCallback(callbackId);
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Audio;
		ELogAuthor author = ELogAuthor.LRA;
		string message = "DeleteCallback 没有找到对应路径的音效缓存！";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", path);
		instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x060000AE RID: 174 RVA: 0x0000631C File Offset: 0x0000451C
	public void SetPlayFlag(string path)
	{
		AudioPoolItem audioPoolItem = null;
		if (this.AudioPoolMap.TryGetValue(path, out audioPoolItem))
		{
			audioPoolItem.UseTime = Time.Instance.Now;
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Audio;
		ELogAuthor author = ELogAuthor.LRA;
		string message = "SetPlayFlag 没有找到对应路径的音效缓存！";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", path);
		instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00006374 File Offset: 0x00004574
	public void Tick(float delta)
	{
		this.TickTime += delta;
		if (this.TickTime > (float)this.CheckTime)
		{
			this.TickTime = 0f;
			double now = Time.Instance.Now;
			List<string> list = new List<string>();
			foreach (KeyValuePair<string, AudioPoolItem> keyValuePair in this.AudioPoolMap)
			{
				string key = keyValuePair.Key;
				AudioPoolItem value = keyValuePair.Value;
				if (now - value.UseTime >= (double)this.CacheTime)
				{
					value.Destroy();
					list.Add(key);
				}
			}
			foreach (string key2 in list)
			{
				this.AudioPoolMap.Remove(key2);
			}
			list.Clear();
			foreach (KeyValuePair<string, ExternalSourcesPoolItem> keyValuePair2 in this.ExternalSourcesPoolMap)
			{
				string key3 = keyValuePair2.Key;
				ExternalSourcesPoolItem value2 = keyValuePair2.Value;
				if (now - value2.UseTime >= (double)this.CacheTime)
				{
					value2.ClearData(key3);
					list.Add(key3);
				}
			}
			foreach (string key4 in list)
			{
				this.ExternalSourcesPoolMap.Remove(key4);
			}
		}
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x00006534 File Offset: 0x00004734
	private unsafe void LoadEventAsync(string eventPath, [Nullable(new byte[]
	{
		1,
		2
	})] Action<UAkAudioEvent> callback)
	{
		if (StringUtils.IsNothing(eventPath))
		{
			callback(null);
			return;
		}
		ResourceSystem.Instance.LoadAsync<UAkAudioEvent>(eventPath, delegate([Nullable(2)] UAkAudioEvent audioEvent, string _)
		{
			if (audioEvent == null || !audioEvent.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Audio;
				ELogAuthor author = ELogAuthor.LRA;
				string message = "音效加载资源失败：";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("eventPath: ", eventPath);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("time: ", Time.Instance.Now);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			callback(audioEvent);
		}, 100, "js_undefined");
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x00006594 File Offset: 0x00004794
	public void AddExternalSources(string path, UAkExternalMediaAsset asset)
	{
		ExternalSourcesPoolItem value = null;
		if (!this.ExternalSourcesPoolMap.TryGetValue(path, out value))
		{
			value = new ExternalSourcesPoolItem(asset);
			this.ExternalSourcesPoolMap[path] = value;
		}
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x000065C8 File Offset: 0x000047C8
	public void SetExternalSourcesPlayFlag(string path)
	{
		ExternalSourcesPoolItem externalSourcesPoolItem = null;
		if (this.ExternalSourcesPoolMap.TryGetValue(path, out externalSourcesPoolItem))
		{
			externalSourcesPoolItem.UseTime = Time.Instance.Now;
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Audio;
		ELogAuthor author = ELogAuthor.LRA;
		string message = "SetExternalSourcesPlayFlag 没有找到对应路径的ExternalSources音效缓存！";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", path);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0400008A RID: 138
	private readonly int CheckTime = 10000;

	// Token: 0x0400008B RID: 139
	private readonly int CacheTime = 120000;

	// Token: 0x0400008C RID: 140
	private readonly Dictionary<string, AudioPoolItem> AudioPoolMap = new Dictionary<string, AudioPoolItem>();

	// Token: 0x0400008D RID: 141
	private float TickTime;

	// Token: 0x0400008E RID: 142
	private readonly Dictionary<string, ExternalSourcesPoolItem> ExternalSourcesPoolMap = new Dictionary<string, ExternalSourcesPoolItem>();
}
