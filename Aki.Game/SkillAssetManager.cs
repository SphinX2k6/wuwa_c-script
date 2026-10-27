using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02003311 RID: 13073
[NullableContext(1)]
[Nullable(0)]
public class SkillAssetManager : IStaticVariableResetter
{
	// Token: 0x0601C7AD RID: 116653 RVA: 0x007FD617 File Offset: 0x007FB817
	static SkillAssetManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SkillAssetManager.CreateStaticDefaultValue), new Action(SkillAssetManager.ResetStaticDefaultValue));
	}

	// Token: 0x0601C7AE RID: 116654 RVA: 0x007FD636 File Offset: 0x007FB836
	public SkillAssetManager(FightAssetManager fightAssetManager)
	{
		this.FightAssetManager = fightAssetManager;
	}

	// Token: 0x0601C7AF RID: 116655 RVA: 0x007FD650 File Offset: 0x007FB850
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

	// Token: 0x0601C7B0 RID: 116656 RVA: 0x007FD94C File Offset: 0x007FBB4C
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

	// Token: 0x0601C7B1 RID: 116657 RVA: 0x007FD983 File Offset: 0x007FBB83
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

	// Token: 0x17002776 RID: 10102
	// (get) Token: 0x0601C7B2 RID: 116658 RVA: 0x007FD991 File Offset: 0x007FBB91
	private static Stat AddSkillStat1
	{
		get
		{
			return SkillAssetManager._addSkillStat1;
		}
	}

	// Token: 0x0601C7B3 RID: 116659 RVA: 0x007FD998 File Offset: 0x007FBB98
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

	// Token: 0x0601C7B4 RID: 116660 RVA: 0x007FDA40 File Offset: 0x007FBC40
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

	// Token: 0x0601C7B5 RID: 116661 RVA: 0x007FDA7F File Offset: 0x007FBC7F
	[NullableContext(2)]
	public AssetElement GetSkill(int skillId)
	{
		return this.SkillAssetMap.GetValueOrDefault(skillId);
	}

	// Token: 0x0601C7B6 RID: 116662 RVA: 0x007FDA90 File Offset: 0x007FBC90
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

	// Token: 0x0601C7B7 RID: 116663 RVA: 0x007FDB00 File Offset: 0x007FBD00
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

	// Token: 0x0601C7B8 RID: 116664 RVA: 0x007FDB7C File Offset: 0x007FBD7C
	public static void CreateStaticDefaultValue()
	{
		SkillAssetManager._addSkillStat1 = Stat.Create("Preload.AddSkill.NewObject", "", "");
	}

	// Token: 0x0601C7B9 RID: 116665 RVA: 0x007FDB97 File Offset: 0x007FBD97
	public static void ResetStaticDefaultValue()
	{
		SkillAssetManager._addSkillStat1 = null;
	}

	// Token: 0x0400E232 RID: 57906
	public readonly FightAssetManager FightAssetManager;

	// Token: 0x0400E233 RID: 57907
	[Nullable(new byte[]
	{
		2,
		1,
		0,
		1
	})]
	private Dictionary<int, List<OneOf<PreloadSkillSaveData, EntitySkillPreload>>> EntitySkillPreloadMap;

	// Token: 0x0400E234 RID: 57908
	public Dictionary<int, AssetElement> SkillAssetMap = new Dictionary<int, AssetElement>();

	// Token: 0x0400E235 RID: 57909
	[Nullable(2)]
	private UHoldPreloadObject HoldAssetObject;

	// Token: 0x0400E236 RID: 57910
	[Nullable(2)]
	private static Stat _addSkillStat1;
}
