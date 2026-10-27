using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020034A2 RID: 13474
[NullableContext(1)]
[Nullable(0)]
public class LguiResourceManager : Singleton
{
	// Token: 0x0601D564 RID: 120164 RVA: 0x0082D824 File Offset: 0x0082BA24
	public int LoadPrefabByResourceId(string resourceId, [Nullable(2)] UUIItem parent = null, [Nullable(new byte[]
	{
		2,
		2,
		1
	})] Action<AActor, string, ELguiLoadResultType> callback = null, string memoryTag = "js_undefined")
	{
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		return this.LoadPrefab(resourcePath, parent, callback, memoryTag);
	}

	// Token: 0x0601D565 RID: 120165 RVA: 0x0082D848 File Offset: 0x0082BA48
	public int LoadPrefab(string path, [Nullable(2)] UUIItem parent = null, [Nullable(new byte[]
	{
		2,
		2,
		1
	})] Action<AActor, string, ELguiLoadResultType> callback = null, string memoryTag = "js_undefined")
	{
		string realMemoryTag = LguiUtil.Instance.GetRootActorMemoryTag(parent, memoryTag);
		bool isCompleted = false;
		int handleId = this.InvalidId;
		handleId = ResourceSystem.Instance.LoadAsync<UPrefabAsset>(path, delegate([Nullable(2)] UPrefabAsset result, string loadedPath)
		{
			isCompleted = true;
			if (handleId != this.InvalidId)
			{
				this.LguiResourceLoadMap.Remove(handleId);
			}
			if (result == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LguiUtil;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "资源加载失败,资源不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", path);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				Action<AActor, string, ELguiLoadResultType> callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2(null, path, ELguiLoadResultType.Fail);
				return;
			}
			else
			{
				if (GlobalData.World != null)
				{
					AActor aactor = ULGUIBPLibrary.LoadPrefabWithAsset(GlobalData.World, result, parent);
					LguiUtil.SetRootActorMemoryTag(aactor, realMemoryTag);
					if (callback != null)
					{
						callback(aactor, path, ELguiLoadResultType.Success);
					}
					return;
				}
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.LguiUtil;
				ELogAuthor author2 = ELogAuthor.XXJ;
				string message2 = "资源加载失败,Game.World为空";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("path", path);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				Action<AActor, string, ELguiLoadResultType> callback3 = callback;
				if (callback3 == null)
				{
					return;
				}
				callback3(null, path, ELguiLoadResultType.Fail);
				return;
			}
		}, 100, realMemoryTag);
		if (!isCompleted && handleId != this.InvalidId)
		{
			this.LguiResourceLoadMap[handleId] = path;
		}
		return handleId;
	}

	// Token: 0x0601D566 RID: 120166 RVA: 0x0082D900 File Offset: 0x0082BB00
	public void CancelLoadPrefab(int handleId)
	{
		if (this.InvalidId == handleId)
		{
			return;
		}
		string text;
		if (!this.LguiResourceLoadMap.TryGetValue(handleId, out text))
		{
			return;
		}
		this.LguiResourceLoadMap.Remove(handleId);
		ResourceSystem.Instance.CancelAsyncLoad(handleId);
	}

	// Token: 0x170028B6 RID: 10422
	// (get) Token: 0x0601D567 RID: 120167 RVA: 0x0082D940 File Offset: 0x0082BB40
	public static LguiResourceManager Instance
	{
		get
		{
			if (LguiResourceManager._instance == null)
			{
				LguiResourceManager._instance = new LguiResourceManager();
				LguiResourceManager._instance.OnInit();
			}
			return LguiResourceManager._instance;
		}
	}

	// Token: 0x0601D568 RID: 120168 RVA: 0x0082D963 File Offset: 0x0082BB63
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601D569 RID: 120169 RVA: 0x0082D965 File Offset: 0x0082BB65
	public static void ResetStaticDefaultValue()
	{
		LguiResourceManager instance = LguiResourceManager._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		LguiResourceManager._instance = null;
	}

	// Token: 0x0601D56A RID: 120170 RVA: 0x0082D97E File Offset: 0x0082BB7E
	static LguiResourceManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LguiResourceManager.CreateStaticDefaultValue), new Action(LguiResourceManager.ResetStaticDefaultValue));
	}

	// Token: 0x0400E71A RID: 59162
	private readonly Dictionary<int, string> LguiResourceLoadMap = new Dictionary<int, string>();

	// Token: 0x0400E71B RID: 59163
	public readonly int InvalidId = -1;

	// Token: 0x0400E71C RID: 59164
	[Nullable(2)]
	private static LguiResourceManager _instance;
}
