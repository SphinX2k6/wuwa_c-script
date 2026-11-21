using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.Entity.Struct;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x020021B6 RID: 8630
[NullableContext(1)]
[Nullable(0)]
public class UiModelResourcesManager : Singleton
{
	// Token: 0x17002028 RID: 8232
	// (get) Token: 0x060153D2 RID: 86994 RVA: 0x0062CC80 File Offset: 0x0062AE80
	private int UiModelHandleId
	{
		get
		{
			int uiModelHandleIdInternal = this.UiModelHandleIdInternal;
			this.UiModelHandleIdInternal = uiModelHandleIdInternal + 1;
			return uiModelHandleIdInternal;
		}
	}

	// Token: 0x060153D3 RID: 86995 RVA: 0x0062CC9E File Offset: 0x0062AE9E
	public UiModelResourcesManager()
	{
		this.LoadUiModelHandleMap = new Dictionary<int, int[]>();
		this.UiModelHandleIdInternal = 0;
		this.InvalidValue = 0;
	}

	// Token: 0x060153D4 RID: 86996 RVA: 0x0062CCC0 File Offset: 0x0062AEC0
	public int LoadUiModelResources(List<string> paths, [Nullable(new byte[]
	{
		2,
		2,
		1,
		1
	})] Action<EUiRoleLoadResult, Dictionary<string, UObject>> callback = null)
	{
		if (paths == null || paths.Count == 0)
		{
			Log.Instance.Error(ELogModule.UiModelResourcesManager, ELogAuthor.XXJ, "加载资源内容为空,检查一下传进来的数据", default(ReadOnlySpan<ValueTuple<string, object>>));
			Action<EUiRoleLoadResult, Dictionary<string, UObject>> callback2 = callback;
			if (callback2 != null)
			{
				callback2(EUiRoleLoadResult.Fail, null);
			}
			return 0;
		}
		List<string> completeList = new List<string>();
		List<string> finishList = new List<string>();
		int modelHandleId = this.UiModelHandleId;
		Dictionary<string, UObject> loadedResources = new Dictionary<string, UObject>();
		LoadModeManager.Instance.SetLoadModeByReason(ELoadMode.Loading, ELoadModeReason.LoadUiModelResources);
		this.LoadUiModelHandleMap[modelHandleId] = Array.Empty<int>();
		List<int> list = new List<int>();
		Action<UObject, string> <>9__0;
		foreach (string text in paths)
		{
			ResourceSystem instance = ResourceSystem.Instance;
			string path = text;
			Action<UObject, string> callback3;
			if ((callback3 = <>9__0) == null)
			{
				callback3 = (<>9__0 = delegate([Nullable(2)] UObject result, string loadPath)
				{
					if (result != null)
					{
						completeList.Add(loadPath);
						loadedResources[loadPath] = result;
					}
					finishList.Add(loadPath);
					if (finishList.Count == paths.Count)
					{
						this.LoadUiModelHandleMap.Remove(modelHandleId);
						if (completeList.Count != finishList.Count)
						{
							Action<EUiRoleLoadResult, Dictionary<string, UObject>> callback4 = callback;
							if (callback4 != null)
							{
								callback4(EUiRoleLoadResult.LoadingMissing, null);
							}
							if (LoadModeManager.Instance.IsReasonTargetNotDefault(ELoadModeReason.LoadUiModelResources))
							{
								LoadModeManager.Instance.ResetLoadModeByReason(ELoadModeReason.LoadUiModelResources);
								return;
							}
						}
						else
						{
							Action<EUiRoleLoadResult, Dictionary<string, UObject>> callback5 = callback;
							if (callback5 != null)
							{
								callback5(EUiRoleLoadResult.Success, loadedResources);
							}
							if (LoadModeManager.Instance.IsReasonTargetNotDefault(ELoadModeReason.LoadUiModelResources))
							{
								LoadModeManager.Instance.ResetLoadModeByReason(ELoadModeReason.LoadUiModelResources);
							}
						}
					}
				});
			}
			int item = instance.LoadAsync<UObject>(path, callback3, 100, "js_undefined");
			if (this.LoadUiModelHandleMap.ContainsKey(modelHandleId))
			{
				list.Add(item);
			}
		}
		this.LoadUiModelHandleMap[modelHandleId] = list.ToArray();
		return modelHandleId;
	}

	// Token: 0x060153D5 RID: 86997 RVA: 0x0062CE34 File Offset: 0x0062B034
	public int LoadUiRoleAllResourceByRoleConfigId(int roleId, [Nullable(new byte[]
	{
		2,
		2,
		1,
		1
	})] Action<EUiRoleLoadResult, Dictionary<string, UObject>> callback = null)
	{
		List<string> list = new List<string>();
		list.AddRange(this.GetRoleResourcesPath(roleId));
		list.Add(EffectUtil.GetEffectPath("ChangeRoleMaterialController"));
		return this.LoadUiModelResources(list, callback);
	}

	// Token: 0x060153D6 RID: 86998 RVA: 0x0062CE6C File Offset: 0x0062B06C
	public void CancelUiModelResourceLoad(int handleId)
	{
		if (handleId == this.InvalidValue)
		{
			return;
		}
		int[] array;
		if (!this.LoadUiModelHandleMap.TryGetValue(handleId, out array))
		{
			return;
		}
		foreach (int id in array)
		{
			ResourceSystem.Instance.CancelAsyncLoad(id);
		}
		if (LoadModeManager.Instance.IsReasonTargetNotDefault(ELoadModeReason.LoadUiModelResources))
		{
			LoadModeManager.Instance.ResetLoadModeByReason(ELoadModeReason.LoadUiModelResources);
		}
	}

	// Token: 0x060153D7 RID: 86999 RVA: 0x0062CECC File Offset: 0x0062B0CC
	public List<string> GetRoleResourcesPath(int roleConfigId)
	{
		List<string> list = new List<string>();
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleConfigId);
		SModelConfig modelConfig = ModelUtil.GetModelConfig(roleConfig.Value.UiMeshId);
		list.Add(modelConfig.网格体.ToAssetPathName());
		list.Add(roleConfig.Value.UiScenePerformanceABP);
		TArray<SModelChildMeshConfig> ui用子网格体 = modelConfig.UI用子网格体;
		if (ui用子网格体 != null)
		{
			for (int i = 0; i < ui用子网格体.Num(); i++)
			{
				list.Add(ui用子网格体.Get(i).SkeletalMesh.ToAssetPathName());
			}
		}
		return list;
	}

	// Token: 0x060153D8 RID: 87000 RVA: 0x0062CF60 File Offset: 0x0062B160
	public unsafe List<string> GetWeaponResourcesPath(int weaponId)
	{
		List<string> list = new List<string>();
		Span<int> modelsBytes = WeaponConfig.Instance.GetWeaponConfigByItemId(weaponId).Value.GetModelsBytes();
		for (int i = 0; i < modelsBytes.Length; i++)
		{
			SModelConfig modelConfig = ModelUtil.GetModelConfig(*modelsBytes[i]);
			string text = modelConfig.网格体.ToAssetPathName();
			if (!string.IsNullOrEmpty(text))
			{
				list.Add(text);
			}
			string text2 = modelConfig.动画蓝图.ToAssetPathName();
			if (!string.IsNullOrEmpty(text2))
			{
				list.Add(text2);
			}
			FSoftObjectPath da = modelConfig.DA;
			string text3 = (da != null) ? da.GetAssetPathString() : null;
			if (!string.IsNullOrEmpty(text3))
			{
				list.Add(text3);
			}
		}
		return list;
	}

	// Token: 0x060153D9 RID: 87001 RVA: 0x0062D018 File Offset: 0x0062B218
	public string[] GetHuluResourcesPath(int huluId)
	{
		List<string> list = new List<string>();
		SModelConfig modelConfig = ModelUtil.GetModelConfig(huluId);
		string text = modelConfig.网格体.ToAssetPathName();
		if (!string.IsNullOrEmpty(text))
		{
			list.Add(text);
		}
		string text2 = modelConfig.动画蓝图.ToAssetPathName();
		if (!string.IsNullOrEmpty(text2))
		{
			list.Add(text2);
		}
		return list.ToArray();
	}

	// Token: 0x17002029 RID: 8233
	// (get) Token: 0x060153DA RID: 87002 RVA: 0x0062D06C File Offset: 0x0062B26C
	public static UiModelResourcesManager Instance
	{
		get
		{
			if (UiModelResourcesManager._instance == null)
			{
				UiModelResourcesManager._instance = new UiModelResourcesManager();
				UiModelResourcesManager._instance.OnInit();
			}
			return UiModelResourcesManager._instance;
		}
	}

	// Token: 0x060153DB RID: 87003 RVA: 0x0062D08F File Offset: 0x0062B28F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060153DC RID: 87004 RVA: 0x0062D091 File Offset: 0x0062B291
	public static void ResetStaticDefaultValue()
	{
		UiModelResourcesManager instance = UiModelResourcesManager._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		UiModelResourcesManager._instance = null;
	}

	// Token: 0x060153DD RID: 87005 RVA: 0x0062D0AA File Offset: 0x0062B2AA
	static UiModelResourcesManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiModelResourcesManager.CreateStaticDefaultValue), new Action(UiModelResourcesManager.ResetStaticDefaultValue));
	}

	// Token: 0x0400B415 RID: 46101
	private readonly Dictionary<int, int[]> LoadUiModelHandleMap;

	// Token: 0x0400B416 RID: 46102
	private int UiModelHandleIdInternal;

	// Token: 0x0400B417 RID: 46103
	public readonly int InvalidValue;

	// Token: 0x0400B418 RID: 46104
	[Nullable(2)]
	private static UiModelResourcesManager _instance;
}
