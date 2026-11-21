using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002889 RID: 10377
[NullableContext(1)]
[Nullable(0)]
public class ModelAssetBulletManager : IStaticVariableResetter
{
	// Token: 0x0601A4D7 RID: 107735 RVA: 0x00824968 File Offset: 0x00822B68
	static ModelAssetBulletManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ModelAssetBulletManager.CreateStaticDefaultValue), new Action(ModelAssetBulletManager.ResetStaticDefaultValue));
	}

	// Token: 0x0601A4D8 RID: 107736 RVA: 0x00824987 File Offset: 0x00822B87
	public ModelAssetBulletManager(ModelAssetElement modelAssetElement)
	{
		this.ModelAssetElement = modelAssetElement;
	}

	// Token: 0x17002B1B RID: 11035
	// (get) Token: 0x0601A4D9 RID: 107737 RVA: 0x008249BE File Offset: 0x00822BBE
	private static Stat AddAssetStat1
	{
		get
		{
			return ModelAssetBulletManager._addAssetStat1;
		}
	}

	// Token: 0x0601A4DA RID: 107738 RVA: 0x008249C8 File Offset: 0x00822BC8
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

	// Token: 0x0601A4DB RID: 107739 RVA: 0x00824A9C File Offset: 0x00822C9C
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

	// Token: 0x0601A4DC RID: 107740 RVA: 0x00824AD6 File Offset: 0x00822CD6
	public static void CreateStaticDefaultValue()
	{
		ModelAssetBulletManager._addAssetStat1 = Stat.Create("Preload.AddStat1.NewObject", "", "");
	}

	// Token: 0x0601A4DD RID: 107741 RVA: 0x00824AF1 File Offset: 0x00822CF1
	public static void ResetStaticDefaultValue()
	{
		ModelAssetBulletManager._addAssetStat1 = null;
	}

	// Token: 0x0400E707 RID: 59143
	public readonly ModelAssetElement ModelAssetElement;

	// Token: 0x0400E708 RID: 59144
	public Dictionary<long, int> ValueMapping = new Dictionary<long, int>();

	// Token: 0x0400E709 RID: 59145
	public Dictionary<int, long> IndexMapping = new Dictionary<int, long>();

	// Token: 0x0400E70A RID: 59146
	public Dictionary<int, AssetElement> AssetMap = new Dictionary<int, AssetElement>();

	// Token: 0x0400E70B RID: 59147
	[Nullable(2)]
	private UHoldPreloadObject HoldAssetObject;

	// Token: 0x0400E70C RID: 59148
	private int Key = -1;

	// Token: 0x0400E70D RID: 59149
	[Nullable(2)]
	private static Stat _addAssetStat1;
}
