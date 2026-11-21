using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

// Token: 0x02002881 RID: 10369
[NullableContext(1)]
[Nullable(0)]
public class AssetElement
{
	// Token: 0x0601A487 RID: 107655 RVA: 0x0082321C File Offset: 0x0082141C
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

	// Token: 0x0601A488 RID: 107656 RVA: 0x008232F0 File Offset: 0x008214F0
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

	// Token: 0x0601A489 RID: 107657 RVA: 0x008233A0 File Offset: 0x008215A0
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

	// Token: 0x0601A48A RID: 107658 RVA: 0x00823470 File Offset: 0x00821670
	[NullableContext(2)]
	public EntityAssetElement GetEntityAssetElement()
	{
		return this.EntityAssetElement;
	}

	// Token: 0x0601A48B RID: 107659 RVA: 0x00823478 File Offset: 0x00821678
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

	// Token: 0x0601A48C RID: 107660 RVA: 0x008234A0 File Offset: 0x008216A0
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

	// Token: 0x0601A48D RID: 107661 RVA: 0x008235B8 File Offset: 0x008217B8
	[NullableContext(2)]
	public void SetCallback(Action<bool> value)
	{
		this.Callback = value;
	}

	// Token: 0x0601A48E RID: 107662 RVA: 0x008235C1 File Offset: 0x008217C1
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

	// Token: 0x0601A48F RID: 107663 RVA: 0x008235E4 File Offset: 0x008217E4
	protected bool CheckPath(string asset)
	{
		if (string.IsNullOrEmpty(asset))
		{
			Log.Instance.Error(ELogModule.World, ELogAuthor.LFJW, "搜集资源失败，asset=undefined或asset.length=0。", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		return true;
	}

	// Token: 0x0601A490 RID: 107664 RVA: 0x00823617 File Offset: 0x00821817
	protected bool AddPath(string asset)
	{
		if (this.AssetPathSet.Contains(asset))
		{
			return false;
		}
		this.AssetPathSet.Add(asset);
		return true;
	}

	// Token: 0x0601A491 RID: 107665 RVA: 0x00823637 File Offset: 0x00821837
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

	// Token: 0x0601A492 RID: 107666 RVA: 0x0082366A File Offset: 0x0082186A
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

	// Token: 0x0601A493 RID: 107667 RVA: 0x0082369C File Offset: 0x0082189C
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

	// Token: 0x0601A494 RID: 107668 RVA: 0x008236E8 File Offset: 0x008218E8
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

	// Token: 0x0601A495 RID: 107669 RVA: 0x0082376A File Offset: 0x0082196A
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

	// Token: 0x0601A496 RID: 107670 RVA: 0x0082379B File Offset: 0x0082199B
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

	// Token: 0x0601A497 RID: 107671 RVA: 0x008237CC File Offset: 0x008219CC
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

	// Token: 0x0601A498 RID: 107672 RVA: 0x00823800 File Offset: 0x00821A00
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

	// Token: 0x0601A499 RID: 107673 RVA: 0x0082384A File Offset: 0x00821A4A
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

	// Token: 0x0601A49A RID: 107674 RVA: 0x0082387C File Offset: 0x00821A7C
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

	// Token: 0x0601A49B RID: 107675 RVA: 0x008238F2 File Offset: 0x00821AF2
	public int NeedLoadCount()
	{
		return this.NeedLoadAssets.Count;
	}

	// Token: 0x0601A49C RID: 107676 RVA: 0x008238FF File Offset: 0x00821AFF
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

	// Token: 0x0601A49D RID: 107677 RVA: 0x0082392F File Offset: 0x00821B2F
	public bool RemoveLoading(string path)
	{
		return this.LoadingSet.Remove(path);
	}

	// Token: 0x0601A49E RID: 107678 RVA: 0x0082393D File Offset: 0x00821B3D
	public bool RemoveLoaded(string path)
	{
		return this.LoadedSet.Remove(path);
	}

	// Token: 0x0601A49F RID: 107679 RVA: 0x0082394B File Offset: 0x00821B4B
	public bool Loading()
	{
		return this.NeedLoadAssets.Count > 0 || this.LoadingSet.Count > 0;
	}

	// Token: 0x0601A4A0 RID: 107680 RVA: 0x0082396B File Offset: 0x00821B6B
	public virtual void Clear()
	{
		this.AssetForIndexMap.Clear();
		this.AssetPathSet.Clear();
		this.LoadedSet.Clear();
		this.LoadingSet.Clear();
	}

	// Token: 0x0601A4A1 RID: 107681 RVA: 0x00823999 File Offset: 0x00821B99
	public virtual void PrintDebugInfo()
	{
	}

	// Token: 0x0400E6D5 RID: 59093
	[Nullable(2)]
	private readonly EntityAssetElement EntityAssetElement;

	// Token: 0x0400E6D6 RID: 59094
	protected readonly Dictionary<string, int> AssetForIndexMap = new Dictionary<string, int>();

	// Token: 0x0400E6D7 RID: 59095
	public bool HasError;

	// Token: 0x0400E6D8 RID: 59096
	public readonly HashSet<string> AssetPathSet = new HashSet<string>();

	// Token: 0x0400E6D9 RID: 59097
	public readonly List<string> NeedLoadAssets = new List<string>();

	// Token: 0x0400E6DA RID: 59098
	public readonly List<EAssetType> NeedLoadAssetTypes = new List<EAssetType>();

	// Token: 0x0400E6DB RID: 59099
	public readonly HashSet<string> LoadingSet = new HashSet<string>();

	// Token: 0x0400E6DC RID: 59100
	public readonly HashSet<string> LoadedSet = new HashSet<string>();

	// Token: 0x0400E6DD RID: 59101
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<UObject, string> AddObjectCallback;

	// Token: 0x0400E6DE RID: 59102
	public readonly ResourceSystem.EResourceLoadPriority LoadPriority = ResourceSystem.EResourceLoadPriority.Default;

	// Token: 0x0400E6DF RID: 59103
	public Dictionary<string, string> ReplaceEffectMap = new Dictionary<string, string>();

	// Token: 0x0400E6E0 RID: 59104
	public Dictionary<string, string> ReplaceMontageMap = new Dictionary<string, string>();

	// Token: 0x0400E6E1 RID: 59105
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private HashSet<object> PromiseSet;

	// Token: 0x0400E6E2 RID: 59106
	[Nullable(2)]
	private Action<bool> Callback;
}
