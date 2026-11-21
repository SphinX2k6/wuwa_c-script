using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002884 RID: 10372
[NullableContext(1)]
[Nullable(0)]
public class BulletAssetManager
{
	// Token: 0x0601A4B3 RID: 107699 RVA: 0x0082410B File Offset: 0x0082230B
	public BulletAssetManager(FightAssetManager fightAssetManager)
	{
		this.FightAssetManager = fightAssetManager;
	}

	// Token: 0x0601A4B4 RID: 107700 RVA: 0x00824144 File Offset: 0x00822344
	[NullableContext(2)]
	public bool AddBullet(long bulletId, AssetElement assetElement)
	{
		BulletAssetManager.<>c__DisplayClass7_0 CS$<>8__locals1 = new BulletAssetManager.<>c__DisplayClass7_0();
		CS$<>8__locals1.<>4__this = this;
		if (this.HoldAssetObject == null)
		{
			this.HoldAssetObject = new UHoldPreloadObject(GlobalData.GameInstance, null, EObjectFlags.RF_NoFlags);
		}
		if (this.BulletMapping.ContainsKey(bulletId))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "[预加载] 重复添加子弹";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("BulletId", bulletId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		if (assetElement == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.World;
			ELogAuthor author2 = ELogAuthor.LFJW;
			string message2 = "[预加载] assetElement无效，添加子弹失败";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("bulletId", bulletId);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return false;
		}
		BulletAssetManager.<>c__DisplayClass7_0 CS$<>8__locals2 = CS$<>8__locals1;
		int num = this.Key + 1;
		this.Key = num;
		CS$<>8__locals2.newKey = num;
		this.BulletMapping[bulletId] = CS$<>8__locals1.newKey;
		this.IndexMapping[CS$<>8__locals1.newKey] = bulletId;
		this.BulletAssetMap[CS$<>8__locals1.newKey] = assetElement;
		assetElement.AddObjectCallback = delegate(UObject @object, string path)
		{
			ELoadResultType eloadResultType = ELoadResultType.None;
			if (CS$<>8__locals1.<>4__this.FightAssetManager.EntityAssetElement.IsT1)
			{
				eloadResultType = CS$<>8__locals1.<>4__this.FightAssetManager.EntityAssetElement.AsT1.LoadState;
			}
			else if (CS$<>8__locals1.<>4__this.FightAssetManager.EntityAssetElement.IsT2)
			{
				eloadResultType = CS$<>8__locals1.<>4__this.FightAssetManager.EntityAssetElement.AsT2.LoadState;
			}
			if (eloadResultType == ELoadResultType.Destroy)
			{
				return;
			}
			CS$<>8__locals1.<>4__this.HoldAssetObject.AddEntityAsset(CS$<>8__locals1.newKey, @object);
		};
		return true;
	}

	// Token: 0x0601A4B5 RID: 107701 RVA: 0x00824244 File Offset: 0x00822444
	[NullableContext(2)]
	public AssetElement GetBullet(long bulletId)
	{
		int key;
		if (!this.BulletMapping.TryGetValue(bulletId, out key))
		{
			return null;
		}
		return this.BulletAssetMap.GetValueOrDefault(key);
	}

	// Token: 0x0601A4B6 RID: 107702 RVA: 0x00824270 File Offset: 0x00822470
	public bool RemoveBullet(long bulletId)
	{
		int num;
		if (!this.BulletMapping.TryGetValue(bulletId, out num))
		{
			return false;
		}
		AssetElement assetElement;
		if (this.BulletAssetMap.TryGetValue(num, out assetElement))
		{
			assetElement.SetPromiseResult(ELoadResultType.Destroy);
		}
		this.IndexMapping.Remove(num);
		this.BulletMapping.Remove(bulletId);
		this.BulletAssetMap.Remove(num);
		UHoldPreloadObject holdAssetObject = this.HoldAssetObject;
		if (holdAssetObject != null)
		{
			holdAssetObject.RemoveEntityAssets(num);
		}
		return true;
	}

	// Token: 0x0601A4B7 RID: 107703 RVA: 0x008242E8 File Offset: 0x008224E8
	public void Clear()
	{
		foreach (KeyValuePair<int, AssetElement> keyValuePair in this.BulletAssetMap)
		{
			keyValuePair.Value.SetPromiseResult(ELoadResultType.Destroy);
		}
		this.Key = -1;
		this.BulletMapping.Clear();
		this.IndexMapping.Clear();
		this.BulletAssetMap.Clear();
		UHoldPreloadObject holdAssetObject = this.HoldAssetObject;
		if (holdAssetObject == null)
		{
			return;
		}
		holdAssetObject.Clear();
	}

	// Token: 0x0400E6E8 RID: 59112
	public readonly FightAssetManager FightAssetManager;

	// Token: 0x0400E6E9 RID: 59113
	public Dictionary<long, int> BulletMapping = new Dictionary<long, int>();

	// Token: 0x0400E6EA RID: 59114
	public Dictionary<int, long> IndexMapping = new Dictionary<int, long>();

	// Token: 0x0400E6EB RID: 59115
	public Dictionary<int, AssetElement> BulletAssetMap = new Dictionary<int, AssetElement>();

	// Token: 0x0400E6EC RID: 59116
	[Nullable(2)]
	private UHoldPreloadObject HoldAssetObject;

	// Token: 0x0400E6ED RID: 59117
	private int Key = -1;
}
