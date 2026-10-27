using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200001A RID: 26
[NullableContext(1)]
[Nullable(0)]
public class AudioPoolItem
{
	// Token: 0x060000B4 RID: 180 RVA: 0x00006653 File Offset: 0x00004853
	public AudioPoolItem(string path)
	{
		this.Path = path;
		this.UseTime = Time.Instance.Now;
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x0000667D File Offset: 0x0000487D
	public int AddCallback(Action callback)
	{
		if (this.LoadFinishCallBack == null)
		{
			this.LoadFinishCallBack = new Dictionary<int, Action>();
		}
		this.CallbackId++;
		this.LoadFinishCallBack[this.CallbackId] = callback;
		return this.CallbackId;
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x000066B8 File Offset: 0x000048B8
	public unsafe bool DeleteCallback(int callbackFlag)
	{
		if (this.LoadFinishCallBack == null)
		{
			return false;
		}
		if (this.LoadFinishCallBack.ContainsKey(callbackFlag))
		{
			this.LoadFinishCallBack.Remove(callbackFlag);
			return true;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Audio;
		ELogAuthor author = ELogAuthor.LRA;
		string message = "没有找到对应paramFlag的回调注册！";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("callbackFlag", callbackFlag);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Path", this.Path);
		instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		return false;
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x0000674C File Offset: 0x0000494C
	public void DoCallback()
	{
		if (this.LoadFinishCallBack != null)
		{
			foreach (KeyValuePair<int, Action> keyValuePair in this.LoadFinishCallBack)
			{
				keyValuePair.Value();
			}
			this.LoadFinishCallBack.Clear();
		}
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x000067B8 File Offset: 0x000049B8
	public void Destroy()
	{
		if (this.AudioEvent != null)
		{
			this.AudioEvent = null;
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Audio;
		ELogAuthor author = ELogAuthor.LRA;
		string message = "Destroy 没有找到对应AudioEvent对象！";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", this.Path);
		instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0400008F RID: 143
	private readonly string Path;

	// Token: 0x04000090 RID: 144
	[Nullable(2)]
	public UAkAudioEvent AudioEvent;

	// Token: 0x04000091 RID: 145
	public double UseTime;

	// Token: 0x04000092 RID: 146
	private Dictionary<int, Action> LoadFinishCallBack = new Dictionary<int, Action>();

	// Token: 0x04000093 RID: 147
	private int CallbackId;
}
