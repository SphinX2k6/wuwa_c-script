using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02003314 RID: 13076
[NullableContext(2)]
[Nullable(0)]
public class EntityAssetElement
{
	// Token: 0x0601C7C1 RID: 116673 RVA: 0x007FDE54 File Offset: 0x007FC054
	[NullableContext(1)]
	public EntityAssetElement(EntityHandle handle)
	{
		this.MainAsset = new AssetElement(this);
		this.FightAssetManager = new FightAssetManager(this);
		this.EntityHandle = handle;
		this.CreatureDataComponent = handle.Entity.GetComponent<CreatureDataComponent>();
		if (PreloadModelNew.Instance.LoadingNeedWaitEntitySet.Contains(handle.Id))
		{
			this.LoadPriority = ResourceSystem.EResourceLoadPriority.Preload;
		}
		else if (this.CreatureDataComponent.IsRole())
		{
			this.LoadPriority = ResourceSystem.EResourceLoadPriority.Preload;
		}
		handle.Priority = (ResourceSystem.EResourceLoadPriority)Math.Max((int)this.LoadPriority, (int)handle.Priority);
	}

	// Token: 0x17002777 RID: 10103
	// (get) Token: 0x0601C7C2 RID: 116674 RVA: 0x007FDEFC File Offset: 0x007FC0FC
	// (set) Token: 0x0601C7C3 RID: 116675 RVA: 0x007FDF04 File Offset: 0x007FC104
	public ELoadResultType LoadState
	{
		get
		{
			return this.LoadStateInternal;
		}
		set
		{
			this.LoadStateInternal = value;
		}
	}

	// Token: 0x17002778 RID: 10104
	// (get) Token: 0x0601C7C4 RID: 116676 RVA: 0x007FDF0D File Offset: 0x007FC10D
	// (set) Token: 0x0601C7C5 RID: 116677 RVA: 0x007FDF15 File Offset: 0x007FC115
	public bool CollectMinorAsset
	{
		get
		{
			return this.CollectMinorAssetInternal;
		}
		set
		{
			this.CollectMinorAssetInternal = value;
		}
	}

	// Token: 0x17002779 RID: 10105
	// (get) Token: 0x0601C7C6 RID: 116678 RVA: 0x007FDF1E File Offset: 0x007FC11E
	public Entity Entity
	{
		get
		{
			EntityHandle entityHandle = this.EntityHandle;
			if (entityHandle == null)
			{
				return null;
			}
			return entityHandle.Entity;
		}
	}

	// Token: 0x1700277A RID: 10106
	// (get) Token: 0x0601C7C7 RID: 116679 RVA: 0x007FDF31 File Offset: 0x007FC131
	// (set) Token: 0x0601C7C8 RID: 116680 RVA: 0x007FDF39 File Offset: 0x007FC139
	public string BlueprintClassPath
	{
		get
		{
			return this.BlueprintClassPathInternal;
		}
		set
		{
			this.BlueprintClassPathInternal = value;
		}
	}

	// Token: 0x0601C7C9 RID: 116681 RVA: 0x007FDF44 File Offset: 0x007FC144
	[NullableContext(1)]
	public void SetCharacterLoadTypes(IReadOnlyList<ECharacterLoadType> loadTypes)
	{
		bool flag = this.CharacterLoadTypeList.Count == loadTypes.Count;
		if (flag)
		{
			for (int i = 0; i < loadTypes.Count; i++)
			{
				if (this.CharacterLoadTypeList[i] != (int)loadTypes[i])
				{
					flag = false;
					break;
				}
			}
		}
		if (flag)
		{
			return;
		}
		this.CharacterLoadTypeList.Clear();
		foreach (ECharacterLoadType item in loadTypes)
		{
			this.CharacterLoadTypeList.Add((int)item);
		}
		this.FightAssetManager.SkillAssetManager.ResetForLoadTypeChange();
	}

	// Token: 0x0601C7CA RID: 116682 RVA: 0x007FDFF4 File Offset: 0x007FC1F4
	[NullableContext(1)]
	public void AddCallback(Action<ELoadResultType> callback)
	{
		if (callback == null)
		{
			return;
		}
		if (this.Callbacks == null)
		{
			this.Callbacks = new List<Action<ELoadResultType>>();
		}
		this.Callbacks.Add(callback);
	}

	// Token: 0x0601C7CB RID: 116683 RVA: 0x007FE01C File Offset: 0x007FC21C
	public void DoCallback(ELoadResultType result)
	{
		if (this.Callbacks == null || this.Callbacks.Count == 0)
		{
			return;
		}
		foreach (Action<ELoadResultType> action in this.Callbacks)
		{
			action(result);
		}
		this.Callbacks = null;
	}

	// Token: 0x0601C7CC RID: 116684 RVA: 0x007FE08C File Offset: 0x007FC28C
	public void ClearCallback()
	{
		this.Callbacks = null;
	}

	// Token: 0x0601C7CD RID: 116685 RVA: 0x007FE098 File Offset: 0x007FC298
	public void Clear()
	{
		UHoldPreloadObject holdPreloadObject = PreloadModelNew.Instance.HoldPreloadObject;
		EntityHandle entityHandle = this.EntityHandle;
		holdPreloadObject.RemoveEntityAssets((entityHandle != null) ? entityHandle.Id : 0);
		this.FightAssetManager.Clear();
		this.BlueprintClassPathInternal = null;
		this.EntityHandle = null;
		this.CreatureDataComponent = null;
		this.CharacterLoadTypeList.Clear();
		this.CollectMinorAssetInternal = false;
		if (this.Callbacks != null)
		{
			this.DoCallback(ELoadResultType.Destroy);
		}
		this.Callbacks = null;
		this.IsDestroy = true;
	}

	// Token: 0x0601C7CE RID: 116686 RVA: 0x007FE116 File Offset: 0x007FC316
	public void PrintDebugInfo()
	{
	}

	// Token: 0x0400E240 RID: 57920
	[Nullable(0)]
	public UniTask<ELoadResultType>? Promise;

	// Token: 0x0400E241 RID: 57921
	[Nullable(1)]
	public AssetElement MainAsset;

	// Token: 0x0400E242 RID: 57922
	[Nullable(1)]
	public FightAssetManager FightAssetManager;

	// Token: 0x0400E243 RID: 57923
	public EntityHandle EntityHandle;

	// Token: 0x0400E244 RID: 57924
	public CreatureDataComponent CreatureDataComponent;

	// Token: 0x0400E245 RID: 57925
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<Action<ELoadResultType>> Callbacks;

	// Token: 0x0400E246 RID: 57926
	public readonly ResourceSystem.EResourceLoadPriority LoadPriority = ResourceSystem.EResourceLoadPriority.Default;

	// Token: 0x0400E247 RID: 57927
	public bool HasMorphAssets;

	// Token: 0x0400E248 RID: 57928
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public HashSet<string> MorphAssetsPaths;

	// Token: 0x0400E249 RID: 57929
	[Nullable(1)]
	public List<int> CharacterLoadTypeList = new List<int>();

	// Token: 0x0400E24A RID: 57930
	private ELoadResultType LoadStateInternal;

	// Token: 0x0400E24B RID: 57931
	private bool CollectMinorAssetInternal;

	// Token: 0x0400E24C RID: 57932
	private string BlueprintClassPathInternal;

	// Token: 0x0400E24D RID: 57933
	public bool IsDestroy;
}
