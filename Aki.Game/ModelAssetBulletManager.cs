using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003317 RID: 13079
[NullableContext(1)]
[Nullable(0)]
public class ModelAssetBulletManager : IStaticVariableResetter
{
	// Token: 0x0601C7DE RID: 116702 RVA: 0x007FE3FC File Offset: 0x007FC5FC
	static ModelAssetBulletManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ModelAssetBulletManager.CreateStaticDefaultValue), new Action(ModelAssetBulletManager.ResetStaticDefaultValue));
	}

	// Token: 0x0601C7DF RID: 116703 RVA: 0x007FE41B File Offset: 0x007FC61B
	public ModelAssetBulletManager(ModelAssetElement modelAssetElement)
	{
		this.ModelAssetElement = modelAssetElement;
	}

	// Token: 0x1700277E RID: 10110
	// (get) Token: 0x0601C7E0 RID: 116704 RVA: 0x007FE452 File Offset: 0x007FC652
	private static Stat AddAssetStat1
	{
		get
		{
			return ModelAssetBulletManager._addAssetStat1;
		}
	}

	// Token: 0x0601C7E1 RID: 116705 RVA: 0x007FE45C File Offset: 0x007FC65C
	public bool AddAsset(long id, AssetElement assetElement)
	{
		ModelAssetBulletManager.<>c__DisplayClass11_0 CS$<>8__locals1 = new ModelAssetBulletManager.<>c__DisplayClass11_0();
		CS$<>8__locals1.<>4__this = this;
		if (this.HoldAssetObject == null)
		{
			this.HoldAssetObject = new UHoldPreloadObject(GlobalData.GameInstance, null, EObjectFlags.RF_NoFlags);
		}
		if (this.ValueMapping.ContainsKey(id))
		{
			return false;
		}
		if (assetElement == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "[预加载] assetElement无效，添加失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		ModelAssetBulletManager.<>c__DisplayClass11_0 CS$<>8__locals2 = CS$<>8__locals1;
		int num = this.Key + 1;
		this.Key = num;
		CS$<>8__locals2.newKey = num;
		this.ValueMapping[id] = CS$<>8__locals1.newKey;
		this.IndexMapping[CS$<>8__locals1.newKey] = id;
		this.AssetMap[CS$<>8__locals1.newKey] = assetElement;
		assetElement.AddObjectCallback = delegate(UObject @object, string path)
		{
			if (CS$<>8__locals1.<>4__this.ModelAssetElement.IsDestroy)
			{
				return;
			}
			CS$<>8__locals1.<>4__this.HoldAssetObject.AddEntityAsset(CS$<>8__locals1.newKey, @object);
		};
		return true;
	}

	// Token: 0x0601C7E2 RID: 116706 RVA: 0x007FE530 File Offset: 0x007FC730
	public void Clear()
	{
		this.Key = -1;
		this.ValueMapping.Clear();
		this.IndexMapping.Clear();
		this.AssetMap.Clear();
		UHoldPreloadObject holdAssetObject = this.HoldAssetObject;
		if (holdAssetObject == null)
		{
			return;
		}
		holdAssetObject.Clear();
	}

	// Token: 0x0601C7E3 RID: 116707 RVA: 0x007FE56A File Offset: 0x007FC76A
	public static void CreateStaticDefaultValue()
	{
		ModelAssetBulletManager._addAssetStat1 = Stat.Create("Preload.AddStat1.NewObject", "", "");
	}

	// Token: 0x0601C7E4 RID: 116708 RVA: 0x007FE585 File Offset: 0x007FC785
	public static void ResetStaticDefaultValue()
	{
		ModelAssetBulletManager._addAssetStat1 = null;
	}

	// Token: 0x0400E256 RID: 57942
	public readonly ModelAssetElement ModelAssetElement;

	// Token: 0x0400E257 RID: 57943
	public Dictionary<long, int> ValueMapping = new Dictionary<long, int>();

	// Token: 0x0400E258 RID: 57944
	public Dictionary<int, long> IndexMapping = new Dictionary<int, long>();

	// Token: 0x0400E259 RID: 57945
	public Dictionary<int, AssetElement> AssetMap = new Dictionary<int, AssetElement>();

	// Token: 0x0400E25A RID: 57946
	[Nullable(2)]
	private UHoldPreloadObject HoldAssetObject;

	// Token: 0x0400E25B RID: 57947
	private int Key = -1;

	// Token: 0x0400E25C RID: 57948
	[Nullable(2)]
	private static Stat _addAssetStat1;
}
