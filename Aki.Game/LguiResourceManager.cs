using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002A16 RID: 10774
[NullableContext(1)]
[Nullable(0)]
public class LguiResourceManager : Singleton
{
	// Token: 0x0601B261 RID: 111201 RVA: 0x008549D0 File Offset: 0x00852BD0
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

	// Token: 0x0601B262 RID: 111202 RVA: 0x008549F4 File Offset: 0x00852BF4
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

	// Token: 0x0601B263 RID: 111203 RVA: 0x00854AAC File Offset: 0x00852CAC
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

	// Token: 0x17002C4E RID: 11342
	// (get) Token: 0x0601B264 RID: 111204 RVA: 0x00854AEC File Offset: 0x00852CEC
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

	// Token: 0x0601B265 RID: 111205 RVA: 0x00854B0F File Offset: 0x00852D0F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601B266 RID: 111206 RVA: 0x00854B11 File Offset: 0x00852D11
	public static void ResetStaticDefaultValue()
	{
		LguiResourceManager instance = LguiResourceManager._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		LguiResourceManager._instance = null;
	}

	// Token: 0x0601B267 RID: 111207 RVA: 0x00854B2A File Offset: 0x00852D2A
	static LguiResourceManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LguiResourceManager.CreateStaticDefaultValue), new Action(LguiResourceManager.ResetStaticDefaultValue));
	}

	// Token: 0x0400EBCE RID: 60366
	private readonly Dictionary<int, string> LguiResourceLoadMap = new Dictionary<int, string>();

	// Token: 0x0400EBCF RID: 60367
	public readonly int InvalidId = -1;

	// Token: 0x0400EBD0 RID: 60368
	[Nullable(2)]
	private static LguiResourceManager _instance;
}
