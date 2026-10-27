using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Extension;
using UnrealEngine;

// Token: 0x02003316 RID: 13078
[NullableContext(1)]
[Nullable(0)]
public class ModelAssetSkillManager : IStaticVariableResetter
{
	// Token: 0x0601C7D6 RID: 116694 RVA: 0x007FE181 File Offset: 0x007FC381
	static ModelAssetSkillManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ModelAssetSkillManager.CreateStaticDefaultValue), new Action(ModelAssetSkillManager.ResetStaticDefaultValue));
	}

	// Token: 0x0601C7D7 RID: 116695 RVA: 0x007FE1A0 File Offset: 0x007FC3A0
	public ModelAssetSkillManager(ModelAssetElement modelAssetElement)
	{
		this.ModelAssetElement = modelAssetElement;
	}

	// Token: 0x0601C7D8 RID: 116696 RVA: 0x007FE1BC File Offset: 0x007FC3BC
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

	// Token: 0x1700277D RID: 10109
	// (get) Token: 0x0601C7D9 RID: 116697 RVA: 0x007FE2FC File Offset: 0x007FC4FC
	private static Stat AddSkillStat1
	{
		get
		{
			return ModelAssetSkillManager._addSkillStat1;
		}
	}

	// Token: 0x0601C7DA RID: 116698 RVA: 0x007FE304 File Offset: 0x007FC504
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

	// Token: 0x0601C7DB RID: 116699 RVA: 0x007FE3AB File Offset: 0x007FC5AB
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

	// Token: 0x0601C7DC RID: 116700 RVA: 0x007FE3D9 File Offset: 0x007FC5D9
	public static void CreateStaticDefaultValue()
	{
		ModelAssetSkillManager._addSkillStat1 = Stat.Create("Preload.AddSkill.NewObject", "", "");
	}

	// Token: 0x0601C7DD RID: 116701 RVA: 0x007FE3F4 File Offset: 0x007FC5F4
	public static void ResetStaticDefaultValue()
	{
		ModelAssetSkillManager._addSkillStat1 = null;
	}

	// Token: 0x0400E251 RID: 57937
	public readonly ModelAssetElement ModelAssetElement;

	// Token: 0x0400E252 RID: 57938
	[Nullable(new byte[]
	{
		2,
		0,
		1
	})]
	private Dictionary<int, OneOf<PreloadSkillSaveData, EntitySkillPreload>> SkillPreloadMap;

	// Token: 0x0400E253 RID: 57939
	public Dictionary<int, AssetElement> SkillAssetMap = new Dictionary<int, AssetElement>();

	// Token: 0x0400E254 RID: 57940
	[Nullable(2)]
	private UHoldPreloadObject HoldAssetObject;

	// Token: 0x0400E255 RID: 57941
	[Nullable(2)]
	private static Stat _addSkillStat1;
}
