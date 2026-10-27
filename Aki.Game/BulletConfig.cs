using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;

// Token: 0x02002DA7 RID: 11687
[NullableContext(1)]
[Nullable(0)]
public class BulletConfig : ConfigBase
{
	// Token: 0x060188D6 RID: 100566 RVA: 0x00646018 File Offset: 0x00644218
	public unsafe void RemoveCacheBulletDataByEntityId(int entityId)
	{
		this.ExtraBulletCacheMap.Remove(entityId);
		int num;
		if (!this.EntityMap.TryGetValue(entityId, out num))
		{
			return;
		}
		this.EntityMap.Remove(entityId);
		BulletDataCacheInfo bulletDataCacheInfo;
		if (!this.SelfBulletCacheMap.TryGetValue(num, out bulletDataCacheInfo))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Bullet;
			ELogAuthor author = ELogAuthor.CFT;
			string message = "删除实体时，子弹缓存里没有对应的数据";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("entityId", entityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("modelId", num);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		bulletDataCacheInfo.EntityCount--;
		if (bulletDataCacheInfo.EntityCount == 0)
		{
			this.SelfBulletCacheMap.Remove(num);
		}
	}

	// Token: 0x060188D7 RID: 100567 RVA: 0x006460E4 File Offset: 0x006442E4
	[NullableContext(2)]
	public void RemoveEntityExtraBulletCacheByTable(int entityId, UDataTable table)
	{
		if (table == null)
		{
			return;
		}
		BulletDataCacheInfo bulletDataCacheInfo;
		if (!this.ExtraBulletCacheMap.TryGetValue(entityId, out bulletDataCacheInfo))
		{
			return;
		}
		List<string> list = new List<string>();
		DataTableUtil.GetDataTableAllRowNamesFromTable(table, list);
		foreach (string key in list)
		{
			bulletDataCacheInfo.BulletDataMap.Remove(key);
		}
		if (bulletDataCacheInfo.BulletDataMap.Count <= 0)
		{
			this.ExtraBulletCacheMap.Remove(entityId);
		}
	}

	// Token: 0x060188D8 RID: 100568 RVA: 0x00646178 File Offset: 0x00644378
	public void ClearBulletDataCache()
	{
		this.SelfBulletCacheMap.Clear();
		this.ExtraBulletCacheMap.Clear();
		this.CommonBulletCacheMap.Clear();
		this.EntityMap.Clear();
	}

	// Token: 0x060188D9 RID: 100569 RVA: 0x006461A8 File Offset: 0x006443A8
	[return: Nullable(2)]
	public BulletDataMain GetBulletData(Entity owner, string bulletDataName, bool errorEnable = true)
	{
		int id = owner.Id;
		ValueTuple<int?, bool> valueTuple = this.ResolveModelIdWithSource(id, owner);
		int? item = valueTuple.Item1;
		bool item2 = valueTuple.Item2;
		if (item == null)
		{
			BulletConfig.LogBulletNotFound(owner, bulletDataName, errorEnable, "子弹数据未找到!");
			return null;
		}
		BaseSkillComponent component = owner.GetComponent<BaseSkillComponent>();
		if (component == null)
		{
			BulletDataMain result;
			if (this.CommonBulletCacheMap.TryGetValue(bulletDataName, out result))
			{
				return result;
			}
			UDataTable commonBulletDataTable = BulletDataTableRepository.GetCommonBulletDataTable();
			object obj = (commonBulletDataTable == null) ? null : this.TryResolveFromCommonTables(new List<UDataTable>
			{
				commonBulletDataTable
			}, bulletDataName, item.Value);
			if (obj == null)
			{
				BulletConfig.LogBulletNotFound(owner, bulletDataName, errorEnable, "子弹数据未找到!");
			}
			return obj;
		}
		else
		{
			BulletDataCacheInfo bulletDataCacheInfo;
			BulletDataMain result2;
			if (this.ExtraBulletCacheMap.TryGetValue(id, out bulletDataCacheInfo) && bulletDataCacheInfo.BulletDataMap.TryGetValue(bulletDataName, out result2))
			{
				return result2;
			}
			FightDataTableSnapshot fightDataTableSnapshot = component.GetFightDataTableSnapshot(EFightDataTableKind.Bullet);
			BulletDataMain bulletDataMain = this.TryResolveFromExtraTables(fightDataTableSnapshot.ExtraTables, bulletDataName, item.Value, id);
			if (bulletDataMain != null)
			{
				return bulletDataMain;
			}
			BulletDataCacheInfo bulletDataCacheInfo2;
			this.SelfBulletCacheMap.TryGetValue(item.Value, out bulletDataCacheInfo2);
			BulletDataMain result3;
			if (bulletDataCacheInfo2 != null && bulletDataCacheInfo2.BulletDataMap.TryGetValue(bulletDataName, out result3))
			{
				if (!item2)
				{
					this.EntityMap[id] = item.Value;
					bulletDataCacheInfo2.EntityCount++;
				}
				return result3;
			}
			BulletDataMain bulletDataMain2 = this.TryResolveFromSelfTable(fightDataTableSnapshot.SelfTable, bulletDataName, item.Value, id, item2, bulletDataCacheInfo2);
			if (bulletDataMain2 != null)
			{
				return bulletDataMain2;
			}
			BulletDataMain result4;
			if (this.CommonBulletCacheMap.TryGetValue(bulletDataName, out result4))
			{
				return result4;
			}
			BulletDataMain bulletDataMain3 = this.TryResolveFromCommonTables(fightDataTableSnapshot.CommonTables, bulletDataName, item.Value);
			if (bulletDataMain3 != null)
			{
				return bulletDataMain3;
			}
			BulletConfig.LogBulletNotFound(owner, bulletDataName, errorEnable, "子弹数据未找到!");
			return null;
		}
	}

	// Token: 0x060188DA RID: 100570 RVA: 0x00646340 File Offset: 0x00644540
	private unsafe static void LogBulletNotFound(Entity owner, string bulletDataName, bool errorEnable, string message)
	{
		if (!errorEnable)
		{
			return;
		}
		BaseActorComponent baseActorComponent = owner.CheckGetComponent<BaseActorComponent>();
		AActor aactor = (baseActorComponent != null) ? baseActorComponent.Owner : null;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Bullet;
		ELogAuthor author = ELogAuthor.CFT;
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("角色:", (aactor != null) ? aactor.GetName() : null);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("子弹名称:", bulletDataName);
		instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x060188DB RID: 100571 RVA: 0x006463C0 File Offset: 0x006445C0
	[NullableContext(2)]
	private BulletDataMain TryResolveFromSelfTable(UDataTable selfTable, [Nullable(1)] string bulletDataName, int modelId, int entityId, bool isEntityMark, BulletDataCacheInfo existingSelfCache)
	{
		SReBulletDataMain dataTableRow = DataTableUtil.GetDataTableRow<SReBulletDataMain>(selfTable, bulletDataName);
		if (dataTableRow == null)
		{
			return null;
		}
		BulletDataMain bulletDataMain = BulletConfig.CreateBulletData(dataTableRow, bulletDataName, modelId);
		if (bulletDataMain == null)
		{
			return null;
		}
		if (GlobalData.IsPlayInEditor)
		{
			return bulletDataMain;
		}
		BulletDataCacheInfo bulletDataCacheInfo = existingSelfCache;
		if (bulletDataCacheInfo == null)
		{
			bulletDataCacheInfo = new BulletDataCacheInfo();
			bulletDataCacheInfo.DataTable = selfTable;
			this.SelfBulletCacheMap[modelId] = bulletDataCacheInfo;
		}
		bulletDataCacheInfo.BulletDataMap[bulletDataName] = bulletDataMain;
		if (!isEntityMark)
		{
			this.EntityMap[entityId] = modelId;
			bulletDataCacheInfo.EntityCount++;
		}
		return bulletDataMain;
	}

	// Token: 0x060188DC RID: 100572 RVA: 0x00646448 File Offset: 0x00644648
	[return: Nullable(2)]
	private BulletDataMain TryResolveFromExtraTables([Nullable(new byte[]
	{
		2,
		1
	})] IReadOnlyList<UDataTable> extraTables, string bulletDataName, int modelId, int entityId)
	{
		if (extraTables == null || extraTables.Count <= 0)
		{
			return null;
		}
		SReBulletDataMain sreBulletDataMain = BulletConfig.FindBulletRowInExtraTables(extraTables, bulletDataName);
		if (sreBulletDataMain == null)
		{
			return null;
		}
		BulletDataMain bulletDataMain = BulletConfig.CreateBulletData(sreBulletDataMain, bulletDataName, modelId);
		if (bulletDataMain == null)
		{
			return null;
		}
		if (GlobalData.IsPlayInEditor)
		{
			return bulletDataMain;
		}
		this.SetExtraBulletCache(entityId, bulletDataName, bulletDataMain);
		return bulletDataMain;
	}

	// Token: 0x060188DD RID: 100573 RVA: 0x00646498 File Offset: 0x00644698
	[return: Nullable(2)]
	private BulletDataMain TryResolveFromCommonTables([Nullable(new byte[]
	{
		2,
		1
	})] IReadOnlyList<UDataTable> commonTables, string bulletDataName, int modelId)
	{
		if (commonTables == null || commonTables.Count <= 0)
		{
			return null;
		}
		foreach (UDataTable table in commonTables)
		{
			SReBulletDataMain dataTableRow = DataTableUtil.GetDataTableRow<SReBulletDataMain>(table, bulletDataName);
			if (!(dataTableRow == null))
			{
				BulletDataMain bulletDataMain = BulletConfig.CreateBulletData(dataTableRow, bulletDataName, modelId);
				if (bulletDataMain != null)
				{
					if (GlobalData.IsPlayInEditor)
					{
						return bulletDataMain;
					}
					this.CommonBulletCacheMap[bulletDataName] = bulletDataMain;
					return bulletDataMain;
				}
			}
		}
		return null;
	}

	// Token: 0x060188DE RID: 100574 RVA: 0x00646524 File Offset: 0x00644724
	[return: Nullable(2)]
	private static SReBulletDataMain FindBulletRowInExtraTables(IReadOnlyList<UDataTable> extraTables, string rowName)
	{
		foreach (UDataTable table in extraTables)
		{
			SReBulletDataMain dataTableRow = DataTableUtil.GetDataTableRow<SReBulletDataMain>(table, rowName);
			if (dataTableRow != null)
			{
				return dataTableRow;
			}
		}
		return null;
	}

	// Token: 0x060188DF RID: 100575 RVA: 0x0064657C File Offset: 0x0064477C
	private void SetExtraBulletCache(int entityId, string rowName, BulletDataMain bulletData)
	{
		BulletDataCacheInfo bulletDataCacheInfo;
		if (!this.ExtraBulletCacheMap.TryGetValue(entityId, out bulletDataCacheInfo))
		{
			bulletDataCacheInfo = new BulletDataCacheInfo();
			this.ExtraBulletCacheMap[entityId] = bulletDataCacheInfo;
		}
		bulletDataCacheInfo.BulletDataMap[rowName] = bulletData;
	}

	// Token: 0x060188E0 RID: 100576 RVA: 0x006465BC File Offset: 0x006447BC
	[return: Nullable(2)]
	private static BulletDataMain CreateBulletData(SReBulletDataMain data, string bulletDataName, int modelId)
	{
		BulletDataMain bulletDataMain = new BulletDataMain(data, bulletDataName, BulletSpecialActionRegistry.GetOverrides(modelId, bulletDataName));
		if (!bulletDataMain.CheckValid())
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Bullet;
			Entity entity = null;
			string message = "子弹配置非法";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("", bulletDataName);
			instance.Error(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return bulletDataMain;
	}

	// Token: 0x060188E1 RID: 100577 RVA: 0x0064660C File Offset: 0x0064480C
	[NullableContext(2)]
	public SHitEffect GetBulletHitData(Entity owner, FName dataName)
	{
		if (FNameUtil.IsNothing(dataName))
		{
			return null;
		}
		string rowName = dataName.ToString();
		BaseSkillComponent baseSkillComponent = (owner != null) ? owner.GetComponent<BaseSkillComponent>() : null;
		if (baseSkillComponent == null)
		{
			return DataTableUtil.GetDataTableRow<SHitEffect>(HitEffectDataTableRepository.GetCommonHitEffectDataTable(), rowName);
		}
		return baseSkillComponent.GetHitEffectInfo(rowName);
	}

	// Token: 0x060188E2 RID: 100578 RVA: 0x00646654 File Offset: 0x00644854
	[NullableContext(2)]
	[return: TupleElementNames(new string[]
	{
		"CreatureDataComp",
		"ModelId"
	})]
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	private static ValueTuple<CreatureDataComponent, int?> GetCreatureDataAndModelId(int entityId, Entity owner = null)
	{
		CreatureDataComponent creatureDataComponent = ((owner != null) ? owner.CheckGetComponent<CreatureDataComponent>() : null) ?? EntitySystem.Instance.GetComponent<CreatureDataComponent>(entityId);
		return new ValueTuple<CreatureDataComponent, int?>(creatureDataComponent, (creatureDataComponent != null) ? new int?(creatureDataComponent.GetModelId()) : null);
	}

	// Token: 0x060188E3 RID: 100579 RVA: 0x0064669C File Offset: 0x0064489C
	[NullableContext(0)]
	[return: TupleElementNames(new string[]
	{
		"ModelId",
		"FromCache"
	})]
	private ValueTuple<int?, bool> ResolveModelIdWithSource(int entityId, [Nullable(2)] Entity owner = null)
	{
		int value;
		if (this.EntityMap.TryGetValue(entityId, out value))
		{
			return new ValueTuple<int?, bool>(new int?(value), true);
		}
		return new ValueTuple<int?, bool>(BulletConfig.GetCreatureDataAndModelId(entityId, owner).Item2, false);
	}

	// Token: 0x060188E4 RID: 100580 RVA: 0x006466D8 File Offset: 0x006448D8
	[NullableContext(2)]
	public void EnqueueSelfPreload(int entityId, UDataTable table)
	{
		if (GlobalData.IsPlayInEditor || table == null)
		{
			return;
		}
		ValueTuple<CreatureDataComponent, int?> creatureDataAndModelId = BulletConfig.GetCreatureDataAndModelId(entityId, null);
		CreatureDataComponent item = creatureDataAndModelId.Item1;
		int? item2 = creatureDataAndModelId.Item2;
		if (item == null || !item.IsRole())
		{
			return;
		}
		if (item2 == null || this.SelfBulletCacheMap.ContainsKey(item2.Value))
		{
			return;
		}
		List<string> list = new List<string>();
		DataTableUtil.GetDataTableAllRowNamesFromTable(table, list);
		if (list.Count <= 0)
		{
			return;
		}
		BulletDataCacheInfo bulletDataCacheInfo = new BulletDataCacheInfo();
		bulletDataCacheInfo.DataTable = table;
		if (CharacterModel.Instance.IsValid(entityId))
		{
			bulletDataCacheInfo.EntityCount = 1;
			this.EntityMap[entityId] = item2.Value;
		}
		this.SelfBulletCacheMap[item2.Value] = bulletDataCacheInfo;
		this.AddPreloadBulletConfig(new PreloadBulletConfig
		{
			Source = EBulletPreloadSource.Self,
			ModelId = item2.Value,
			EntityId = entityId,
			DataTable = table,
			RowNames = list.ToArray(),
			CurIndex = 0
		});
	}

	// Token: 0x060188E5 RID: 100581 RVA: 0x006467DC File Offset: 0x006449DC
	[NullableContext(2)]
	public void EnqueueExtraPreload(int entityId, UDataTable table)
	{
		if (GlobalData.IsPlayInEditor || table == null || !table.IsValid())
		{
			return;
		}
		ValueTuple<CreatureDataComponent, int?> creatureDataAndModelId = BulletConfig.GetCreatureDataAndModelId(entityId, null);
		CreatureDataComponent item = creatureDataAndModelId.Item1;
		int? item2 = creatureDataAndModelId.Item2;
		if (item == null || !item.IsRole())
		{
			return;
		}
		if (item2 == null)
		{
			return;
		}
		List<string> list = new List<string>();
		DataTableUtil.GetDataTableAllRowNamesFromTable(table, list);
		if (list.Count <= 0)
		{
			return;
		}
		if (!this.ExtraBulletCacheMap.ContainsKey(entityId))
		{
			BulletDataCacheInfo bulletDataCacheInfo = new BulletDataCacheInfo();
			bulletDataCacheInfo.DataTable = table;
			this.ExtraBulletCacheMap[entityId] = bulletDataCacheInfo;
		}
		this.AddPreloadBulletConfig(new PreloadBulletConfig
		{
			Source = EBulletPreloadSource.Extra,
			ModelId = item2.Value,
			EntityId = entityId,
			DataTable = table,
			RowNames = list.ToArray(),
			CurIndex = 0
		});
	}

	// Token: 0x060188E6 RID: 100582 RVA: 0x006468B0 File Offset: 0x00644AB0
	[NullableContext(2)]
	public void CancelExtraPreload(int entityId, UDataTable table)
	{
		BulletConfig.<>c__DisplayClass25_0 CS$<>8__locals1;
		CS$<>8__locals1.entityId = entityId;
		CS$<>8__locals1.table = table;
		if (CS$<>8__locals1.table == null)
		{
			return;
		}
		for (int i = this.PreloadBulletConfigs.Count - 1; i >= 0; i--)
		{
			if (BulletConfig.<CancelExtraPreload>g__IsTarget|25_0(this.PreloadBulletConfigs[i], ref CS$<>8__locals1))
			{
				this.PreloadBulletConfigs.RemoveAt(i);
			}
		}
		if (BulletConfig.<CancelExtraPreload>g__IsTarget|25_0(this.CurPreloadBulletConfig, ref CS$<>8__locals1))
		{
			this.CurPreloadBulletConfig.CurIndex = this.CurPreloadBulletConfig.RowNames.Length;
		}
	}

	// Token: 0x060188E7 RID: 100583 RVA: 0x00646936 File Offset: 0x00644B36
	private void AddPreloadBulletConfig(PreloadBulletConfig preloadBulletConfig)
	{
		if (this.CurPreloadBulletConfig != null)
		{
			this.PreloadBulletConfigs.Add(preloadBulletConfig);
			return;
		}
		this.CurPreloadBulletConfig = preloadBulletConfig;
	}

	// Token: 0x060188E8 RID: 100584 RVA: 0x00646954 File Offset: 0x00644B54
	public void TickPreload()
	{
		if (this.CurPreloadBulletConfig == null)
		{
			return;
		}
		if (this.CurPreloadBulletConfig.RowNames.Length <= this.CurPreloadBulletConfig.CurIndex)
		{
			if (this.PreloadBulletConfigs.Count == 0)
			{
				this.CurPreloadBulletConfig = null;
				return;
			}
			this.CurPreloadBulletConfig = this.PreloadBulletConfigs[this.PreloadBulletConfigs.Count - 1];
			this.PreloadBulletConfigs.RemoveAt(this.PreloadBulletConfigs.Count - 1);
			if (this.CurPreloadBulletConfig.RowNames.Length <= this.CurPreloadBulletConfig.CurIndex)
			{
				return;
			}
		}
		this.TickPreloadOne(this.CurPreloadBulletConfig);
	}

	// Token: 0x060188E9 RID: 100585 RVA: 0x006469F8 File Offset: 0x00644BF8
	private unsafe void TickPreloadOne(PreloadBulletConfig config)
	{
		string text = config.RowNames[config.CurIndex];
		BulletDataCacheInfo preloadTargetCache = this.GetPreloadTargetCache(config);
		if (preloadTargetCache == null)
		{
			config.CurIndex = config.RowNames.Length;
			return;
		}
		SReBulletDataMain preloadRowData = this.GetPreloadRowData(config, text);
		if (preloadRowData == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Bullet;
			ELogAuthor author = ELogAuthor.CFT;
			string message = "子弹配置为空";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("rowName", text);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("source", config.Source);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("modelId", config.ModelId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("index", config.CurIndex);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			config.CurIndex++;
			return;
		}
		BulletDataMain bulletDataMain = BulletConfig.CreateBulletData(preloadRowData, text, config.ModelId);
		if (bulletDataMain == null)
		{
			config.CurIndex++;
			return;
		}
		bulletDataMain.Preload();
		preloadTargetCache.BulletDataMap[text] = bulletDataMain;
		config.CurIndex++;
	}

	// Token: 0x060188EA RID: 100586 RVA: 0x00646B34 File Offset: 0x00644D34
	[return: Nullable(2)]
	private BulletDataCacheInfo GetPreloadTargetCache(PreloadBulletConfig config)
	{
		EBulletPreloadSource source = config.Source;
		if (source == EBulletPreloadSource.Self)
		{
			BulletDataCacheInfo result;
			this.SelfBulletCacheMap.TryGetValue(config.ModelId, out result);
			return result;
		}
		if (source != EBulletPreloadSource.Extra)
		{
			return null;
		}
		BulletDataCacheInfo result2;
		this.ExtraBulletCacheMap.TryGetValue(config.EntityId, out result2);
		return result2;
	}

	// Token: 0x060188EB RID: 100587 RVA: 0x00646B7E File Offset: 0x00644D7E
	[return: Nullable(2)]
	private SReBulletDataMain GetPreloadRowData(PreloadBulletConfig config, string rowName)
	{
		return DataTableUtil.GetDataTableRow<SReBulletDataMain>(config.DataTable, rowName);
	}

	// Token: 0x060188EC RID: 100588 RVA: 0x00646B8C File Offset: 0x00644D8C
	public void ClearPreload()
	{
		this.CurPreloadBulletConfig = null;
		this.PreloadBulletConfigs.Clear();
	}

	// Token: 0x060188ED RID: 100589 RVA: 0x00646BA0 File Offset: 0x00644DA0
	public void PreloadCommonWhitelist()
	{
		if (GlobalData.IsPlayInEditor)
		{
			return;
		}
		UDataTable commonBulletDataTable = BulletDataTableRepository.GetCommonBulletDataTable();
		if (commonBulletDataTable == null)
		{
			return;
		}
		foreach (string text in BulletConfig.CommonPreloadWhitelist)
		{
			if (!this.CommonBulletCacheMap.ContainsKey(text))
			{
				SReBulletDataMain dataTableRow = DataTableUtil.GetDataTableRow<SReBulletDataMain>(commonBulletDataTable, text);
				if (dataTableRow == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Bullet;
					ELogAuthor author = ELogAuthor.CFT;
					string message = "公共子弹白名单预热失败：全局公共子弹表中无对应行";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("rowName", text);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					BulletDataMain bulletDataMain = BulletConfig.CreateBulletData(dataTableRow, text, 0);
					if (bulletDataMain != null)
					{
						bulletDataMain.Preload();
						this.CommonBulletCacheMap[text] = bulletDataMain;
					}
				}
			}
		}
	}

	// Token: 0x17002122 RID: 8482
	// (get) Token: 0x060188EE RID: 100590 RVA: 0x00646C4E File Offset: 0x00644E4E
	public static BulletConfig Instance
	{
		get
		{
			return BulletConfig._Instance;
		}
	}

	// Token: 0x060188EF RID: 100591 RVA: 0x00646C55 File Offset: 0x00644E55
	public static BulletConfig GetOrCreateInstance()
	{
		if (BulletConfig._Instance == null)
		{
			BulletConfig.CreateInstance();
		}
		return BulletConfig._Instance;
	}

	// Token: 0x060188F0 RID: 100592 RVA: 0x00646C69 File Offset: 0x00644E69
	public static bool CreateInstance()
	{
		if (BulletConfig._Instance != null)
		{
			return true;
		}
		BulletConfig._Instance = new BulletConfig();
		return true;
	}

	// Token: 0x060188F1 RID: 100593 RVA: 0x00646C7F File Offset: 0x00644E7F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060188F2 RID: 100594 RVA: 0x00646C81 File Offset: 0x00644E81
	public static void ResetStaticDefaultValue()
	{
		BulletConfig._Instance = null;
	}

	// Token: 0x060188F3 RID: 100595 RVA: 0x00646C89 File Offset: 0x00644E89
	static BulletConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BulletConfig.CreateStaticDefaultValue), new Action(BulletConfig.ResetStaticDefaultValue));
	}

	// Token: 0x060188F5 RID: 100597 RVA: 0x00646D42 File Offset: 0x00644F42
	[NullableContext(2)]
	[CompilerGenerated]
	internal static bool <CancelExtraPreload>g__IsTarget|25_0(PreloadBulletConfig config, ref BulletConfig.<>c__DisplayClass25_0 A_1)
	{
		return config != null && config.Source == EBulletPreloadSource.Extra && config.EntityId == A_1.entityId && config.DataTable == A_1.table;
	}

	// Token: 0x0400B5FF RID: 46591
	private readonly Stat PreloadStat = Stat.Create("BulletConfigPreload", "", "");

	// Token: 0x0400B600 RID: 46592
	private readonly Stat TickPreloadStat = Stat.Create("BulletConfigTickPreload", "", "");

	// Token: 0x0400B601 RID: 46593
	private readonly Dictionary<int, BulletDataCacheInfo> SelfBulletCacheMap = new Dictionary<int, BulletDataCacheInfo>();

	// Token: 0x0400B602 RID: 46594
	private readonly Dictionary<int, BulletDataCacheInfo> ExtraBulletCacheMap = new Dictionary<int, BulletDataCacheInfo>();

	// Token: 0x0400B603 RID: 46595
	private readonly Dictionary<string, BulletDataMain> CommonBulletCacheMap = new Dictionary<string, BulletDataMain>();

	// Token: 0x0400B604 RID: 46596
	private readonly Dictionary<int, int> EntityMap = new Dictionary<int, int>();

	// Token: 0x0400B605 RID: 46597
	private readonly List<PreloadBulletConfig> PreloadBulletConfigs = new List<PreloadBulletConfig>();

	// Token: 0x0400B606 RID: 46598
	[Nullable(2)]
	private PreloadBulletConfig CurPreloadBulletConfig;

	// Token: 0x0400B607 RID: 46599
	[StaticVariableRuleIgnore]
	private static readonly string[] CommonPreloadWhitelist = new string[]
	{
		"100121",
		"100122"
	};

	// Token: 0x0400B608 RID: 46600
	[Nullable(2)]
	private static BulletConfig _Instance;
}
