using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02002886 RID: 10374
[NullableContext(2)]
[Nullable(0)]
public class EntityAssetElement
{
	// Token: 0x0601A4BA RID: 107706 RVA: 0x008243C0 File Offset: 0x008225C0
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

	// Token: 0x17002B14 RID: 11028
	// (get) Token: 0x0601A4BB RID: 107707 RVA: 0x00824468 File Offset: 0x00822668
	// (set) Token: 0x0601A4BC RID: 107708 RVA: 0x00824470 File Offset: 0x00822670
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

	// Token: 0x17002B15 RID: 11029
	// (get) Token: 0x0601A4BD RID: 107709 RVA: 0x00824479 File Offset: 0x00822679
	// (set) Token: 0x0601A4BE RID: 107710 RVA: 0x00824481 File Offset: 0x00822681
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

	// Token: 0x17002B16 RID: 11030
	// (get) Token: 0x0601A4BF RID: 107711 RVA: 0x0082448A File Offset: 0x0082268A
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

	// Token: 0x17002B17 RID: 11031
	// (get) Token: 0x0601A4C0 RID: 107712 RVA: 0x0082449D File Offset: 0x0082269D
	// (set) Token: 0x0601A4C1 RID: 107713 RVA: 0x008244A5 File Offset: 0x008226A5
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

	// Token: 0x0601A4C2 RID: 107714 RVA: 0x008244B0 File Offset: 0x008226B0
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

	// Token: 0x0601A4C3 RID: 107715 RVA: 0x00824560 File Offset: 0x00822760
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

	// Token: 0x0601A4C4 RID: 107716 RVA: 0x00824588 File Offset: 0x00822788
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

	// Token: 0x0601A4C5 RID: 107717 RVA: 0x008245F8 File Offset: 0x008227F8
	public void ClearCallback()
	{
		this.Callbacks = null;
	}

	// Token: 0x0601A4C6 RID: 107718 RVA: 0x00824604 File Offset: 0x00822804
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

	// Token: 0x0601A4C7 RID: 107719 RVA: 0x00824682 File Offset: 0x00822882
	public void PrintDebugInfo()
	{
	}

	// Token: 0x0400E6F1 RID: 59121
	[Nullable(0)]
	public UniTask<ELoadResultType>? Promise;

	// Token: 0x0400E6F2 RID: 59122
	[Nullable(1)]
	public AssetElement MainAsset;

	// Token: 0x0400E6F3 RID: 59123
	[Nullable(1)]
	public FightAssetManager FightAssetManager;

	// Token: 0x0400E6F4 RID: 59124
	public EntityHandle EntityHandle;

	// Token: 0x0400E6F5 RID: 59125
	public CreatureDataComponent CreatureDataComponent;

	// Token: 0x0400E6F6 RID: 59126
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<Action<ELoadResultType>> Callbacks;

	// Token: 0x0400E6F7 RID: 59127
	public readonly ResourceSystem.EResourceLoadPriority LoadPriority = ResourceSystem.EResourceLoadPriority.Default;

	// Token: 0x0400E6F8 RID: 59128
	public bool HasMorphAssets;

	// Token: 0x0400E6F9 RID: 59129
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public HashSet<string> MorphAssetsPaths;

	// Token: 0x0400E6FA RID: 59130
	[Nullable(1)]
	public List<int> CharacterLoadTypeList = new List<int>();

	// Token: 0x0400E6FB RID: 59131
	private ELoadResultType LoadStateInternal;

	// Token: 0x0400E6FC RID: 59132
	private bool CollectMinorAssetInternal;

	// Token: 0x0400E6FD RID: 59133
	private string BlueprintClassPathInternal;

	// Token: 0x0400E6FE RID: 59134
	public bool IsDestroy;
}
