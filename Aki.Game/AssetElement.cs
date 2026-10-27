using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

// Token: 0x0200330F RID: 13071
[NullableContext(1)]
[Nullable(0)]
public class AssetElement
{
	// Token: 0x0601C78E RID: 116622 RVA: 0x007FCCB0 File Offset: 0x007FAEB0
	public Dictionary<string, string> SetupReplaceEffect(string replaceTablePath)
	{
		List<SReplaceEffect> dataTableAllRowFromTable = DataTableUtil.GetDataTableAllRowFromTable<SReplaceEffect>(ResourceSystem.Instance.Load<UDataTable>(replaceTablePath, "js_undefined"));
		if (dataTableAllRowFromTable.Count > 0)
		{
			foreach (SReplaceEffect sreplaceEffect in dataTableAllRowFromTable)
			{
				string text = sreplaceEffect.NewEffect.ToAssetPathName();
				if (!string.IsNullOrEmpty(text) && !(text == "None"))
				{
					string text2 = sreplaceEffect.OldEffect.ToAssetPathName();
					if (text.Contains("GA_"))
					{
						text += "_C";
						text2 += "_C";
					}
					this.ReplaceEffectMap[text2] = text;
				}
			}
		}
		return this.ReplaceEffectMap;
	}

	// Token: 0x0601C78F RID: 116623 RVA: 0x007FCD84 File Offset: 0x007FAF84
	public Dictionary<string, string> SetupReplaceMontage(string replaceTablePath)
	{
		List<SReplaceMontage> dataTableAllRowFromTable = DataTableUtil.GetDataTableAllRowFromTable<SReplaceMontage>(ResourceSystem.Instance.Load<UDataTable>(replaceTablePath, "js_undefined"));
		if (dataTableAllRowFromTable.Count > 0)
		{
			foreach (SReplaceMontage sreplaceMontage in dataTableAllRowFromTable)
			{
				string text = sreplaceMontage.NewMontage.ToAssetPathName();
				if (!string.IsNullOrEmpty(text) && !(text == "None"))
				{
					this.ReplaceMontageMap[sreplaceMontage.OldMontage.ToAssetPathName()] = sreplaceMontage.NewMontage.ToAssetPathName();
				}
			}
		}
		return this.ReplaceMontageMap;
	}

	// Token: 0x0601C790 RID: 116624 RVA: 0x007FCE34 File Offset: 0x007FB034
	[NullableContext(2)]
	public AssetElement(EntityAssetElement entityAssetElement)
	{
		this.EntityAssetElement = entityAssetElement;
		bool flag;
		if (entityAssetElement == null)
		{
			flag = (null != null);
		}
		else
		{
			AssetElement mainAsset = entityAssetElement.MainAsset;
			flag = (((mainAsset != null) ? mainAsset.ReplaceEffectMap : null) != null);
		}
		if (flag)
		{
			this.ReplaceEffectMap = entityAssetElement.MainAsset.ReplaceEffectMap;
		}
		bool flag2;
		if (entityAssetElement == null)
		{
			flag2 = (null != null);
		}
		else
		{
			AssetElement mainAsset2 = entityAssetElement.MainAsset;
			flag2 = (((mainAsset2 != null) ? mainAsset2.ReplaceMontageMap : null) != null);
		}
		if (flag2)
		{
			this.ReplaceMontageMap = entityAssetElement.MainAsset.ReplaceMontageMap;
		}
	}

	// Token: 0x0601C791 RID: 116625 RVA: 0x007FCF04 File Offset: 0x007FB104
	[NullableContext(2)]
	public EntityAssetElement GetEntityAssetElement()
	{
		return this.EntityAssetElement;
	}

	// Token: 0x0601C792 RID: 116626 RVA: 0x007FCF0C File Offset: 0x007FB10C
	[NullableContext(2)]
	public void AddPromise(object promise)
	{
		if (promise == null)
		{
			return;
		}
		if (this.PromiseSet == null)
		{
			this.PromiseSet = new HashSet<object>();
		}
		this.PromiseSet.Add(promise);
	}

	// Token: 0x0601C793 RID: 116627 RVA: 0x007FCF34 File Offset: 0x007FB134
	public void SetPromiseResult(object result)
	{
		if (this.PromiseSet == null)
		{
			return;
		}
		HashSet<object> promiseSet = this.PromiseSet;
		this.PromiseSet = null;
		if (result is bool)
		{
			bool flag = (bool)result;
			using (HashSet<object>.Enumerator enumerator = promiseSet.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					GameModePromise gameModePromise = obj as GameModePromise;
					if (gameModePromise != null)
					{
						gameModePromise.SetResult(flag);
					}
					else
					{
						CustomPromise<ELoadResultType> customPromise = obj as CustomPromise<ELoadResultType>;
						if (customPromise != null)
						{
							customPromise.SetResult(flag ? ELoadResultType.Done : ELoadResultType.Destroy);
						}
					}
				}
				return;
			}
		}
		if (result is ELoadResultType)
		{
			ELoadResultType eloadResultType = (ELoadResultType)result;
			foreach (object obj2 in promiseSet)
			{
				GameModePromise gameModePromise2 = obj2 as GameModePromise;
				if (gameModePromise2 != null)
				{
					gameModePromise2.SetResult(eloadResultType == ELoadResultType.Done);
				}
				else
				{
					CustomPromise<ELoadResultType> customPromise2 = obj2 as CustomPromise<ELoadResultType>;
					if (customPromise2 != null)
					{
						customPromise2.SetResult(eloadResultType);
					}
				}
			}
		}
	}

	// Token: 0x0601C794 RID: 116628 RVA: 0x007FD04C File Offset: 0x007FB24C
	[NullableContext(2)]
	public void SetCallback(Action<bool> value)
	{
		this.Callback = value;
	}

	// Token: 0x0601C795 RID: 116629 RVA: 0x007FD055 File Offset: 0x007FB255
	public void ExecuteCallback()
	{
		Action<bool> callback = this.Callback;
		this.Callback = null;
		if (callback == null)
		{
			return;
		}
		callback(!this.HasError);
	}

	// Token: 0x0601C796 RID: 116630 RVA: 0x007FD078 File Offset: 0x007FB278
	protected bool CheckPath(string asset)
	{
		if (string.IsNullOrEmpty(asset))
		{
			Log.Instance.Error(ELogModule.World, ELogAuthor.LFJW, "搜集资源失败，asset=undefined或asset.length=0。", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		return true;
	}

	// Token: 0x0601C797 RID: 116631 RVA: 0x007FD0AB File Offset: 0x007FB2AB
	protected bool AddPath(string asset)
	{
		if (this.AssetPathSet.Contains(asset))
		{
			return false;
		}
		this.AssetPathSet.Add(asset);
		return true;
	}

	// Token: 0x0601C798 RID: 116632 RVA: 0x007FD0CB File Offset: 0x007FB2CB
	public virtual bool AddObject(string path, UObject @object)
	{
		if (this.LoadedSet.Contains(path))
		{
			return false;
		}
		this.LoadedSet.Add(path);
		Action<UObject, string> addObjectCallback = this.AddObjectCallback;
		if (addObjectCallback != null)
		{
			addObjectCallback(@object, path);
		}
		return true;
	}

	// Token: 0x0601C799 RID: 116633 RVA: 0x007FD0FE File Offset: 0x007FB2FE
	public bool AddActorClass(string asset)
	{
		if (!this.CheckPath(asset))
		{
			return false;
		}
		if (!this.AddPath(asset))
		{
			return false;
		}
		this.NeedLoadAssets.Add(asset);
		this.NeedLoadAssetTypes.Add(EAssetType.ActorClass);
		return true;
	}

	// Token: 0x0601C79A RID: 116634 RVA: 0x007FD130 File Offset: 0x007FB330
	public bool AddAnimation(string asset)
	{
		if (!this.CheckPath(asset))
		{
			return false;
		}
		string valueOrDefault = this.ReplaceMontageMap.GetValueOrDefault(asset, asset);
		if (!this.AddPath(valueOrDefault))
		{
			return false;
		}
		this.NeedLoadAssets.Add(valueOrDefault);
		this.NeedLoadAssetTypes.Add(EAssetType.Animation);
		return true;
	}

	// Token: 0x0601C79B RID: 116635 RVA: 0x007FD17C File Offset: 0x007FB37C
	public bool AddEffect(string asset)
	{
		if (GlobalData.IsPlayInEditor && (GameModeModel.Instance.MapId < 3000 || GameModeModel.Instance.MapId > 4000 || GameModeModel.Instance.MapId == 1))
		{
			return true;
		}
		if (!this.CheckPath(asset))
		{
			return false;
		}
		string valueOrDefault = this.ReplaceEffectMap.GetValueOrDefault(asset, asset);
		if (!this.AddPath(valueOrDefault))
		{
			return false;
		}
		this.NeedLoadAssets.Add(valueOrDefault);
		this.NeedLoadAssetTypes.Add(EAssetType.Effect);
		return true;
	}

	// Token: 0x0601C79C RID: 116636 RVA: 0x007FD1FE File Offset: 0x007FB3FE
	public bool AddAudio(string asset)
	{
		if (!this.CheckPath(asset))
		{
			return false;
		}
		if (!this.AddPath(asset))
		{
			return false;
		}
		this.NeedLoadAssets.Add(asset);
		this.NeedLoadAssetTypes.Add(EAssetType.Audio);
		return true;
	}

	// Token: 0x0601C79D RID: 116637 RVA: 0x007FD22F File Offset: 0x007FB42F
	public bool AddMesh(string asset)
	{
		if (!this.CheckPath(asset))
		{
			return false;
		}
		if (!this.AddPath(asset))
		{
			return false;
		}
		this.NeedLoadAssets.Add(asset);
		this.NeedLoadAssetTypes.Add(EAssetType.Mesh);
		return true;
	}

	// Token: 0x0601C79E RID: 116638 RVA: 0x007FD260 File Offset: 0x007FB460
	public bool AddMaterial(string asset)
	{
		if (!this.CheckPath(asset))
		{
			return false;
		}
		if (!this.AddPath(asset))
		{
			return false;
		}
		this.NeedLoadAssets.Add(asset);
		this.NeedLoadAssetTypes.Add(EAssetType.Material);
		return true;
	}

	// Token: 0x0601C79F RID: 116639 RVA: 0x007FD294 File Offset: 0x007FB494
	public bool AddOther(string asset)
	{
		if (!this.CheckPath(asset))
		{
			return false;
		}
		string valueOrDefault = this.ReplaceEffectMap.GetValueOrDefault(asset, asset);
		if (!this.AddPath(valueOrDefault))
		{
			return false;
		}
		this.NeedLoadAssets.Add(valueOrDefault);
		this.NeedLoadAssetTypes.Add(EAssetType.Other);
		return true;
	}

	// Token: 0x0601C7A0 RID: 116640 RVA: 0x007FD2DE File Offset: 0x007FB4DE
	public bool AddAnimationBlueprint(string asset)
	{
		if (!this.CheckPath(asset))
		{
			return false;
		}
		if (!this.AddPath(asset))
		{
			return false;
		}
		this.NeedLoadAssets.Add(asset);
		this.NeedLoadAssetTypes.Add(EAssetType.AnimationBlueprint);
		return true;
	}

	// Token: 0x0601C7A1 RID: 116641 RVA: 0x007FD310 File Offset: 0x007FB510
	public bool AddAsset(EAssetType type, string asset)
	{
		switch (type)
		{
		case EAssetType.ActorClass:
			return this.AddActorClass(asset);
		case EAssetType.Animation:
			return this.AddAnimation(asset);
		case EAssetType.Effect:
			return this.AddEffect(asset);
		case EAssetType.Audio:
			return this.AddAudio(asset);
		case EAssetType.Mesh:
			return this.AddMesh(asset);
		case EAssetType.Material:
			return this.AddMaterial(asset);
		case EAssetType.AnimationBlueprint:
			return this.AddAnimationBlueprint(asset);
		case EAssetType.Other:
			return this.AddOther(asset);
		default:
			return true;
		}
	}

	// Token: 0x0601C7A2 RID: 116642 RVA: 0x007FD386 File Offset: 0x007FB586
	public int NeedLoadCount()
	{
		return this.NeedLoadAssets.Count;
	}

	// Token: 0x0601C7A3 RID: 116643 RVA: 0x007FD393 File Offset: 0x007FB593
	public bool AddLoading(string path)
	{
		if (this.LoadedSet.Contains(path))
		{
			return false;
		}
		if (this.LoadingSet.Contains(path))
		{
			return false;
		}
		this.LoadingSet.Add(path);
		return true;
	}

	// Token: 0x0601C7A4 RID: 116644 RVA: 0x007FD3C3 File Offset: 0x007FB5C3
	public bool RemoveLoading(string path)
	{
		return this.LoadingSet.Remove(path);
	}

	// Token: 0x0601C7A5 RID: 116645 RVA: 0x007FD3D1 File Offset: 0x007FB5D1
	public bool RemoveLoaded(string path)
	{
		return this.LoadedSet.Remove(path);
	}

	// Token: 0x0601C7A6 RID: 116646 RVA: 0x007FD3DF File Offset: 0x007FB5DF
	public bool Loading()
	{
		return this.NeedLoadAssets.Count > 0 || this.LoadingSet.Count > 0;
	}

	// Token: 0x0601C7A7 RID: 116647 RVA: 0x007FD3FF File Offset: 0x007FB5FF
	public virtual void Clear()
	{
		this.AssetForIndexMap.Clear();
		this.AssetPathSet.Clear();
		this.LoadedSet.Clear();
		this.LoadingSet.Clear();
	}

	// Token: 0x0601C7A8 RID: 116648 RVA: 0x007FD42D File Offset: 0x007FB62D
	public virtual void PrintDebugInfo()
	{
	}

	// Token: 0x0400E224 RID: 57892
	[Nullable(2)]
	private readonly EntityAssetElement EntityAssetElement;

	// Token: 0x0400E225 RID: 57893
	protected readonly Dictionary<string, int> AssetForIndexMap = new Dictionary<string, int>();

	// Token: 0x0400E226 RID: 57894
	public bool HasError;

	// Token: 0x0400E227 RID: 57895
	public readonly HashSet<string> AssetPathSet = new HashSet<string>();

	// Token: 0x0400E228 RID: 57896
	public readonly List<string> NeedLoadAssets = new List<string>();

	// Token: 0x0400E229 RID: 57897
	public readonly List<EAssetType> NeedLoadAssetTypes = new List<EAssetType>();

	// Token: 0x0400E22A RID: 57898
	public readonly HashSet<string> LoadingSet = new HashSet<string>();

	// Token: 0x0400E22B RID: 57899
	public readonly HashSet<string> LoadedSet = new HashSet<string>();

	// Token: 0x0400E22C RID: 57900
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<UObject, string> AddObjectCallback;

	// Token: 0x0400E22D RID: 57901
	public readonly ResourceSystem.EResourceLoadPriority LoadPriority = ResourceSystem.EResourceLoadPriority.Default;

	// Token: 0x0400E22E RID: 57902
	public Dictionary<string, string> ReplaceEffectMap = new Dictionary<string, string>();

	// Token: 0x0400E22F RID: 57903
	public Dictionary<string, string> ReplaceMontageMap = new Dictionary<string, string>();

	// Token: 0x0400E230 RID: 57904
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private HashSet<object> PromiseSet;

	// Token: 0x0400E231 RID: 57905
	[Nullable(2)]
	private Action<bool> Callback;
}
