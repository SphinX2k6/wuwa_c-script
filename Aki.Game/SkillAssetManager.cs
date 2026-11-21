using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02002883 RID: 10371
[NullableContext(1)]
[Nullable(0)]
public class SkillAssetManager : IStaticVariableResetter
{
	// Token: 0x0601A4A6 RID: 107686 RVA: 0x00823B83 File Offset: 0x00821D83
	static SkillAssetManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SkillAssetManager.CreateStaticDefaultValue), new Action(SkillAssetManager.ResetStaticDefaultValue));
	}

	// Token: 0x0601A4A7 RID: 107687 RVA: 0x00823BA2 File Offset: 0x00821DA2
	public SkillAssetManager(FightAssetManager fightAssetManager)
	{
		this.FightAssetManager = fightAssetManager;
	}

	// Token: 0x0601A4A8 RID: 107688 RVA: 0x00823BBC File Offset: 0x00821DBC
	[return: Nullable(new byte[]
	{
		1,
		1,
		0,
		1
	})]
	private Dictionary<int, List<OneOf<PreloadSkillSaveData, EntitySkillPreload>>> EnsureEntitySkillPreloadMap()
	{
		if (this.EntitySkillPreloadMap == null)
		{
			this.EntitySkillPreloadMap = new Dictionary<int, List<OneOf<PreloadSkillSaveData, EntitySkillPreload>>>();
			string text = null;
			if (this.FightAssetManager.EntityAssetElement.IsT1)
			{
				text = this.FightAssetManager.EntityAssetElement.AsT1.BlueprintClassPath;
			}
			else if (this.FightAssetManager.EntityAssetElement.IsT2)
			{
				text = this.FightAssetManager.EntityAssetElement.AsT2.BlueprintClassPath;
			}
			if (!string.IsNullOrEmpty(text))
			{
				OneOf<List<PreloadSkillSaveData>, IReadOnlyList<EntitySkillPreload>>? skillPreloadData = PreloadModelNew.Instance.GetSkillPreloadData(text);
				if (skillPreloadData != null && skillPreloadData.GetValueOrDefault().IsT1)
				{
					using (List<PreloadSkillSaveData>.Enumerator enumerator = skillPreloadData.Value.AsT1.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							PreloadSkillSaveData preloadSkillSaveData = enumerator.Current;
							this.AddEntitySkillPreloadToMap(preloadSkillSaveData.SkillId, preloadSkillSaveData);
						}
						goto IL_155;
					}
				}
				if (skillPreloadData != null && skillPreloadData.GetValueOrDefault().IsT2)
				{
					foreach (EntitySkillPreload value in skillPreloadData.Value.AsT2)
					{
						this.AddEntitySkillPreloadToMap(value.SkillId, value);
					}
				}
			}
			IL_155:
			OneOf<EntityAssetElement, PbEntityAssetElement> entityAssetElement = this.FightAssetManager.EntityAssetElement;
			if (entityAssetElement.IsT1)
			{
				EntityAssetElement asT = entityAssetElement.AsT1;
				if (asT.HasMorphAssets && asT.MorphAssetsPaths != null)
				{
					foreach (string bpPath in asT.MorphAssetsPaths)
					{
						OneOf<List<PreloadSkillSaveData>, IReadOnlyList<EntitySkillPreload>>? skillPreloadData2 = PreloadModelNew.Instance.GetSkillPreloadData(bpPath);
						if (skillPreloadData2 != null && skillPreloadData2.GetValueOrDefault().IsT1)
						{
							using (List<PreloadSkillSaveData>.Enumerator enumerator = skillPreloadData2.Value.AsT1.GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									PreloadSkillSaveData preloadSkillSaveData2 = enumerator.Current;
									this.AddEntitySkillPreloadToMap(preloadSkillSaveData2.SkillId, preloadSkillSaveData2);
								}
								continue;
							}
						}
						if (skillPreloadData2 != null && skillPreloadData2.GetValueOrDefault().IsT2)
						{
							foreach (EntitySkillPreload value2 in skillPreloadData2.Value.AsT2)
							{
								this.AddEntitySkillPreloadToMap(value2.SkillId, value2);
							}
						}
					}
				}
			}
		}
		return this.EntitySkillPreloadMap;
	}

	// Token: 0x0601A4A9 RID: 107689 RVA: 0x00823EB8 File Offset: 0x008220B8
	private void AddEntitySkillPreloadToMap(int skillId, [Nullable(new byte[]
	{
		0,
		1
	})] OneOf<PreloadSkillSaveData, EntitySkillPreload> value)
	{
		List<OneOf<PreloadSkillSaveData, EntitySkillPreload>> list;
		if (!this.EntitySkillPreloadMap.TryGetValue(skillId, out list))
		{
			list = new List<OneOf<PreloadSkillSaveData, EntitySkillPreload>>();
			this.EntitySkillPreloadMap[skillId] = list;
		}
		list.Add(value);
	}

	// Token: 0x0601A4AA RID: 107690 RVA: 0x00823EEF File Offset: 0x008220EF
	[return: Nullable(new byte[]
	{
		2,
		0,
		1
	})]
	public IReadOnlyList<OneOf<PreloadSkillSaveData, EntitySkillPreload>> GetEntitySkillPreloadBucket(int skillId)
	{
		return this.EnsureEntitySkillPreloadMap().GetValueOrDefault(skillId);
	}

	// Token: 0x17002B13 RID: 11027
	// (get) Token: 0x0601A4AB RID: 107691 RVA: 0x00823EFD File Offset: 0x008220FD
	private static Stat AddSkillStat1
	{
		get
		{
			return SkillAssetManager._addSkillStat1;
		}
	}

	// Token: 0x0601A4AC RID: 107692 RVA: 0x00823F04 File Offset: 0x00822104
	[NullableContext(2)]
	public bool AddSkill(int skillId, AssetElement assetElement)
	{
		if (this.HoldAssetObject == null)
		{
			this.HoldAssetObject = new UHoldPreloadObject(GlobalData.GameInstance, null, EObjectFlags.RF_NoFlags);
		}
		this.SkillAssetMap.ContainsKey(skillId);
		if (assetElement == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "[预加载] assetElement无效，添加技能失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SkillId", skillId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		this.SkillAssetMap[skillId] = assetElement;
		assetElement.AddObjectCallback = delegate(UObject @object, string path)
		{
			ELoadResultType eloadResultType = ELoadResultType.None;
			if (this.FightAssetManager.EntityAssetElement.IsT1)
			{
				eloadResultType = this.FightAssetManager.EntityAssetElement.AsT1.LoadState;
			}
			else if (this.FightAssetManager.EntityAssetElement.IsT2)
			{
				eloadResultType = this.FightAssetManager.EntityAssetElement.AsT2.LoadState;
			}
			if (eloadResultType == ELoadResultType.Destroy)
			{
				return;
			}
			this.HoldAssetObject.AddEntityAsset(skillId, @object);
		};
		return true;
	}

	// Token: 0x0601A4AD RID: 107693 RVA: 0x00823FAC File Offset: 0x008221AC
	public bool RemoveSkill(int skillId)
	{
		AssetElement assetElement;
		if (!this.SkillAssetMap.Remove(skillId, out assetElement))
		{
			return false;
		}
		assetElement.SetPromiseResult(ELoadResultType.Destroy);
		UHoldPreloadObject holdAssetObject = this.HoldAssetObject;
		if (holdAssetObject != null)
		{
			holdAssetObject.RemoveEntityAssets(skillId);
		}
		return true;
	}

	// Token: 0x0601A4AE RID: 107694 RVA: 0x00823FEB File Offset: 0x008221EB
	[NullableContext(2)]
	public AssetElement GetSkill(int skillId)
	{
		return this.SkillAssetMap.GetValueOrDefault(skillId);
	}

	// Token: 0x0601A4AF RID: 107695 RVA: 0x00823FFC File Offset: 0x008221FC
	public void ResetForLoadTypeChange()
	{
		Dictionary<int, List<OneOf<PreloadSkillSaveData, EntitySkillPreload>>> entitySkillPreloadMap = this.EntitySkillPreloadMap;
		if (entitySkillPreloadMap != null)
		{
			entitySkillPreloadMap.Clear();
		}
		foreach (int skillId in new List<int>(this.SkillAssetMap.Keys))
		{
			this.RemoveSkill(skillId);
		}
	}

	// Token: 0x0601A4B0 RID: 107696 RVA: 0x0082406C File Offset: 0x0082226C
	public void Clear()
	{
		foreach (KeyValuePair<int, AssetElement> keyValuePair in this.SkillAssetMap)
		{
			keyValuePair.Value.SetPromiseResult(ELoadResultType.Destroy);
		}
		this.SkillAssetMap.Clear();
		UHoldPreloadObject holdAssetObject = this.HoldAssetObject;
		if (holdAssetObject == null)
		{
			return;
		}
		holdAssetObject.Clear();
	}

	// Token: 0x0601A4B1 RID: 107697 RVA: 0x008240E8 File Offset: 0x008222E8
	public static void CreateStaticDefaultValue()
	{
		SkillAssetManager._addSkillStat1 = Stat.Create("Preload.AddSkill.NewObject", "", "");
	}

	// Token: 0x0601A4B2 RID: 107698 RVA: 0x00824103 File Offset: 0x00822303
	public static void ResetStaticDefaultValue()
	{
		SkillAssetManager._addSkillStat1 = null;
	}

	// Token: 0x0400E6E3 RID: 59107
	public readonly FightAssetManager FightAssetManager;

	// Token: 0x0400E6E4 RID: 59108
	[Nullable(new byte[]
	{
		2,
		1,
		0,
		1
	})]
	private Dictionary<int, List<OneOf<PreloadSkillSaveData, EntitySkillPreload>>> EntitySkillPreloadMap;

	// Token: 0x0400E6E5 RID: 59109
	public Dictionary<int, AssetElement> SkillAssetMap = new Dictionary<int, AssetElement>();

	// Token: 0x0400E6E6 RID: 59110
	[Nullable(2)]
	private UHoldPreloadObject HoldAssetObject;

	// Token: 0x0400E6E7 RID: 59111
	[Nullable(2)]
	private static Stat _addSkillStat1;
}
