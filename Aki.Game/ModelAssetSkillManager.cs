using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Extension;
using UnrealEngine;

// Token: 0x02002888 RID: 10376
[NullableContext(1)]
[Nullable(0)]
public class ModelAssetSkillManager : IStaticVariableResetter
{
	// Token: 0x0601A4CF RID: 107727 RVA: 0x008246ED File Offset: 0x008228ED
	static ModelAssetSkillManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ModelAssetSkillManager.CreateStaticDefaultValue), new Action(ModelAssetSkillManager.ResetStaticDefaultValue));
	}

	// Token: 0x0601A4D0 RID: 107728 RVA: 0x0082470C File Offset: 0x0082290C
	public ModelAssetSkillManager(ModelAssetElement modelAssetElement)
	{
		this.ModelAssetElement = modelAssetElement;
	}

	// Token: 0x0601A4D1 RID: 107729 RVA: 0x00824728 File Offset: 0x00822928
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public OneOf<PreloadSkillSaveData, EntitySkillPreload>? GetEntitySkillPreload(int skillId)
	{
		if (this.SkillPreloadMap == null)
		{
			this.SkillPreloadMap = new Dictionary<int, OneOf<PreloadSkillSaveData, EntitySkillPreload>>();
			string blueprintClassPath = this.ModelAssetElement.BlueprintClassPath;
			if (!string.IsNullOrEmpty(blueprintClassPath))
			{
				OneOf<List<PreloadSkillSaveData>, IReadOnlyList<EntitySkillPreload>>? skillPreloadData = PreloadModelNew.Instance.GetSkillPreloadData(blueprintClassPath);
				if (skillPreloadData != null)
				{
					if (skillPreloadData.Value.IsT1)
					{
						using (List<PreloadSkillSaveData>.Enumerator enumerator = skillPreloadData.Value.AsT1.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								PreloadSkillSaveData preloadSkillSaveData = enumerator.Current;
								this.SkillPreloadMap[preloadSkillSaveData.SkillId] = preloadSkillSaveData;
							}
							goto IL_10A;
						}
					}
					if (skillPreloadData.Value.IsT2)
					{
						foreach (EntitySkillPreload value in skillPreloadData.Value.AsT2)
						{
							this.SkillPreloadMap[value.SkillId] = value;
						}
					}
				}
			}
		}
		IL_10A:
		return this.SkillPreloadMap.GetValueOrNull(skillId);
	}

	// Token: 0x17002B1A RID: 11034
	// (get) Token: 0x0601A4D2 RID: 107730 RVA: 0x00824868 File Offset: 0x00822A68
	private static Stat AddSkillStat1
	{
		get
		{
			return ModelAssetSkillManager._addSkillStat1;
		}
	}

	// Token: 0x0601A4D3 RID: 107731 RVA: 0x00824870 File Offset: 0x00822A70
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
			if (this.ModelAssetElement.IsDestroy)
			{
				return;
			}
			this.HoldAssetObject.AddEntityAsset(skillId, @object);
		};
		return true;
	}

	// Token: 0x0601A4D4 RID: 107732 RVA: 0x00824917 File Offset: 0x00822B17
	public void Clear()
	{
		Dictionary<int, OneOf<PreloadSkillSaveData, EntitySkillPreload>> skillPreloadMap = this.SkillPreloadMap;
		if (skillPreloadMap != null)
		{
			skillPreloadMap.Clear();
		}
		this.SkillAssetMap.Clear();
		UHoldPreloadObject holdAssetObject = this.HoldAssetObject;
		if (holdAssetObject == null)
		{
			return;
		}
		holdAssetObject.Clear();
	}

	// Token: 0x0601A4D5 RID: 107733 RVA: 0x00824945 File Offset: 0x00822B45
	public static void CreateStaticDefaultValue()
	{
		ModelAssetSkillManager._addSkillStat1 = Stat.Create("Preload.AddSkill.NewObject", "", "");
	}

	// Token: 0x0601A4D6 RID: 107734 RVA: 0x00824960 File Offset: 0x00822B60
	public static void ResetStaticDefaultValue()
	{
		ModelAssetSkillManager._addSkillStat1 = null;
	}

	// Token: 0x0400E702 RID: 59138
	public readonly ModelAssetElement ModelAssetElement;

	// Token: 0x0400E703 RID: 59139
	[Nullable(new byte[]
	{
		2,
		0,
		1
	})]
	private Dictionary<int, OneOf<PreloadSkillSaveData, EntitySkillPreload>> SkillPreloadMap;

	// Token: 0x0400E704 RID: 59140
	public Dictionary<int, AssetElement> SkillAssetMap = new Dictionary<int, AssetElement>();

	// Token: 0x0400E705 RID: 59141
	[Nullable(2)]
	private UHoldPreloadObject HoldAssetObject;

	// Token: 0x0400E706 RID: 59142
	[Nullable(2)]
	private static Stat _addSkillStat1;
}
