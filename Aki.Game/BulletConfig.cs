using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;

// Token: 0x02002301 RID: 8961
[NullableContext(1)]
[Nullable(0)]
public class BulletConfig : ConfigBase
{
	// Token: 0x0601617B RID: 90491 RVA: 0x0066BE60 File Offset: 0x0066A060
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

	// Token: 0x0601617C RID: 90492 RVA: 0x0066BF2C File Offset: 0x0066A12C
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
			if (bulletDataCacheInfo.BulletDataSourceMap.GetValueOrDefault(key) == table)
			{
				bulletDataCacheInfo.BulletDataMap.Remove(key);
				bulletDataCacheInfo.BulletDataSourceMap.Remove(key);
			}
		}
		if (bulletDataCacheInfo.BulletDataMap.Count <= 0)
		{
			this.ExtraBulletCacheMap.Remove(entityId);
		}
	}

	// Token: 0x0601617D RID: 90493 RVA: 0x0066BFDC File Offset: 0x0066A1DC
	public void ClearBulletDataCache()
	{
		this.SelfBulletCacheMap.Clear();
		this.ExtraBulletCacheMap.Clear();
		BulletConfig.ClearCache(this.GameplayCommonBulletCache);
		BulletConfig.ClearCache(this.GlobalCommonBulletCache);
		this.EntityMap.Clear();
	}

	// Token: 0x0601617E RID: 90494 RVA: 0x0066C018 File Offset: 0x0066A218
	[return: Nullable(2)]
	public BulletDataMain GetBulletData(Entity owner, string bulletDataName, bool errorEnable = true)
	{
		BulletDataMain result;
		try
		{
			int id = owner.Id;
			BaseSkillComponent component = owner.GetComponent<BaseSkillComponent>();
			if (component == null)
			{
				result = this.ResolveCommonOnlyBulletData(owner, bulletDataName, errorEnable);
			}
			else
			{
				ValueTuple<int?, bool> valueTuple = this.ResolveModelIdWithSource(id, owner);
				int? item = valueTuple.Item1;
				bool item2 = valueTuple.Item2;
				if (item == null)
				{
					BulletConfig.LogBulletNotFound(owner, bulletDataName, errorEnable, "子弹数据未找到!");
					result = null;
				}
				else
				{
					ResolvedBulletDataMain resolvedBulletDataMain = null;
					try
					{
						resolvedBulletDataMain = component.FindBulletDataMain(bulletDataName);
					}
					finally
					{
					}
					if (resolvedBulletDataMain == null)
					{
						BulletConfig.LogBulletNotFound(owner, bulletDataName, errorEnable, "子弹数据未找到!");
						result = null;
					}
					else if (GlobalData.IsPlayInEditor)
					{
						result = BulletConfig.CreateBulletData(resolvedBulletDataMain.Info, bulletDataName, BulletConfig.IsCommonSource(resolvedBulletDataMain.SourceType) ? 0 : item.Value);
					}
					else
					{
						BulletDataCacheInfo orCreateResolvedCache = this.GetOrCreateResolvedCache(resolvedBulletDataMain.SourceType, id, item.Value);
						BulletDataMain cachedBulletData = BulletConfig.GetCachedBulletData(orCreateResolvedCache, bulletDataName, resolvedBulletDataMain.SourceTable);
						if (cachedBulletData != null)
						{
							if (resolvedBulletDataMain.SourceType == EResolvedDataSourceType.Self && !item2)
							{
								this.RegisterSelfCacheEntity(orCreateResolvedCache, id, item.Value);
							}
							result = cachedBulletData;
						}
						else
						{
							BulletDataMain bulletDataMain = BulletConfig.CreateBulletData(resolvedBulletDataMain.Info, bulletDataName, BulletConfig.IsCommonSource(resolvedBulletDataMain.SourceType) ? 0 : item.Value);
							if (bulletDataMain == null)
							{
								result = null;
							}
							else
							{
								orCreateResolvedCache.BulletDataMap[bulletDataName] = bulletDataMain;
								orCreateResolvedCache.BulletDataSourceMap[bulletDataName] = resolvedBulletDataMain.SourceTable;
								if (resolvedBulletDataMain.SourceType == EResolvedDataSourceType.Self && !item2)
								{
									this.RegisterSelfCacheEntity(orCreateResolvedCache, id, item.Value);
								}
								result = bulletDataMain;
							}
						}
					}
				}
			}
		}
		finally
		{
		}
		return result;
	}

	// Token: 0x0601617F RID: 90495 RVA: 0x0066C1D0 File Offset: 0x0066A3D0
	[return: Nullable(2)]
	private BulletDataMain ResolveCommonOnlyBulletData(Entity owner, string bulletDataName, bool errorEnable)
	{
		ResolvedBulletDataMain resolvedBulletDataMain = BulletDataTableRepository.FindCommonBulletDataMain(bulletDataName);
		if (resolvedBulletDataMain == null)
		{
			BulletConfig.LogBulletNotFound(owner, bulletDataName, errorEnable, "子弹数据未找到!");
			return null;
		}
		if (GlobalData.IsPlayInEditor)
		{
			return BulletConfig.CreateBulletData(resolvedBulletDataMain.Info, bulletDataName, 0);
		}
		BulletDataCacheInfo orCreateResolvedCache = this.GetOrCreateResolvedCache(resolvedBulletDataMain.SourceType, 0, 0);
		BulletDataMain cachedBulletData = BulletConfig.GetCachedBulletData(orCreateResolvedCache, bulletDataName, resolvedBulletDataMain.SourceTable);
		if (cachedBulletData != null)
		{
			return cachedBulletData;
		}
		BulletDataMain bulletDataMain = BulletConfig.CreateBulletData(resolvedBulletDataMain.Info, bulletDataName, 0);
		if (bulletDataMain == null)
		{
			return null;
		}
		orCreateResolvedCache.BulletDataMap[bulletDataName] = bulletDataMain;
		orCreateResolvedCache.BulletDataSourceMap[bulletDataName] = resolvedBulletDataMain.SourceTable;
		return bulletDataMain;
	}

	// Token: 0x06016180 RID: 90496 RVA: 0x0066C260 File Offset: 0x0066A460
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

	// Token: 0x06016181 RID: 90497 RVA: 0x0066C2E0 File Offset: 0x0066A4E0
	private BulletDataCacheInfo GetOrCreateResolvedCache(EResolvedDataSourceType sourceType, int entityId, int modelId)
	{
		switch (sourceType)
		{
		case EResolvedDataSourceType.Extra:
			return BulletConfig.GetOrCreateCache(this.ExtraBulletCacheMap, entityId);
		case EResolvedDataSourceType.Self:
			return BulletConfig.GetOrCreateCache(this.SelfBulletCacheMap, modelId);
		case EResolvedDataSourceType.GameplayCommon:
			return this.GameplayCommonBulletCache;
		case EResolvedDataSourceType.GlobalCommon:
			return this.GlobalCommonBulletCache;
		default:
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 1);
			defaultInterpolatedStringHandler.AppendLiteral("未知的子弹配置来源: ");
			defaultInterpolatedStringHandler.AppendFormatted<EResolvedDataSourceType>(sourceType);
			throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		}
	}

	// Token: 0x06016182 RID: 90498 RVA: 0x0066C358 File Offset: 0x0066A558
	private static BulletDataCacheInfo GetOrCreateCache(Dictionary<int, BulletDataCacheInfo> cacheMap, int cacheKey)
	{
		BulletDataCacheInfo bulletDataCacheInfo;
		if (!cacheMap.TryGetValue(cacheKey, out bulletDataCacheInfo))
		{
			bulletDataCacheInfo = new BulletDataCacheInfo();
			cacheMap[cacheKey] = bulletDataCacheInfo;
		}
		return bulletDataCacheInfo;
	}

	// Token: 0x06016183 RID: 90499 RVA: 0x0066C37F File Offset: 0x0066A57F
	private static void ClearCache(BulletDataCacheInfo cacheInfo)
	{
		cacheInfo.BulletDataMap.Clear();
		cacheInfo.BulletDataSourceMap.Clear();
		cacheInfo.EntityCount = 0;
	}

	// Token: 0x06016184 RID: 90500 RVA: 0x0066C39E File Offset: 0x0066A59E
	private static bool IsCommonSource(EResolvedDataSourceType sourceType)
	{
		return sourceType == EResolvedDataSourceType.GameplayCommon || sourceType == EResolvedDataSourceType.GlobalCommon;
	}

	// Token: 0x06016185 RID: 90501 RVA: 0x0066C3AA File Offset: 0x0066A5AA
	[return: Nullable(2)]
	private static BulletDataMain GetCachedBulletData(BulletDataCacheInfo cacheInfo, string rowName, UDataTable sourceTable)
	{
		if (cacheInfo.BulletDataSourceMap.GetValueOrDefault(rowName) != sourceTable)
		{
			return null;
		}
		return cacheInfo.BulletDataMap.GetValueOrDefault(rowName);
	}

	// Token: 0x06016186 RID: 90502 RVA: 0x0066C3C9 File Offset: 0x0066A5C9
	private void RegisterSelfCacheEntity(BulletDataCacheInfo cacheInfo, int entityId, int modelId)
	{
		this.EntityMap[entityId] = modelId;
		cacheInfo.EntityCount++;
	}

	// Token: 0x06016187 RID: 90503 RVA: 0x0066C3E8 File Offset: 0x0066A5E8
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

	// Token: 0x06016188 RID: 90504 RVA: 0x0066C438 File Offset: 0x0066A638
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

	// Token: 0x06016189 RID: 90505 RVA: 0x0066C480 File Offset: 0x0066A680
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

	// Token: 0x0601618A RID: 90506 RVA: 0x0066C4C8 File Offset: 0x0066A6C8
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

	// Token: 0x0601618B RID: 90507 RVA: 0x0066C504 File Offset: 0x0066A704
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

	// Token: 0x0601618C RID: 90508 RVA: 0x0066C604 File Offset: 0x0066A804
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
			BulletDataCacheInfo value = new BulletDataCacheInfo();
			this.ExtraBulletCacheMap[entityId] = value;
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

	// Token: 0x0601618D RID: 90509 RVA: 0x0066C6D0 File Offset: 0x0066A8D0
	[NullableContext(2)]
	public void CancelExtraPreload(int entityId, UDataTable table)
	{
		BulletConfig.<>c__DisplayClass30_0 CS$<>8__locals1;
		CS$<>8__locals1.entityId = entityId;
		CS$<>8__locals1.table = table;
		if (CS$<>8__locals1.table == null)
		{
			return;
		}
		for (int i = this.PreloadBulletConfigs.Count - 1; i >= 0; i--)
		{
			if (BulletConfig.<CancelExtraPreload>g__IsTarget|30_0(this.PreloadBulletConfigs[i], ref CS$<>8__locals1))
			{
				this.PreloadBulletConfigs.RemoveAt(i);
			}
		}
		if (BulletConfig.<CancelExtraPreload>g__IsTarget|30_0(this.CurPreloadBulletConfig, ref CS$<>8__locals1))
		{
			this.CurPreloadBulletConfig.CurIndex = this.CurPreloadBulletConfig.RowNames.Length;
		}
	}

	// Token: 0x0601618E RID: 90510 RVA: 0x0066C756 File Offset: 0x0066A956
	private void AddPreloadBulletConfig(PreloadBulletConfig preloadBulletConfig)
	{
		if (this.CurPreloadBulletConfig != null)
		{
			this.PreloadBulletConfigs.Add(preloadBulletConfig);
			return;
		}
		this.CurPreloadBulletConfig = preloadBulletConfig;
	}

	// Token: 0x0601618F RID: 90511 RVA: 0x0066C774 File Offset: 0x0066A974
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

	// Token: 0x06016190 RID: 90512 RVA: 0x0066C818 File Offset: 0x0066AA18
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
		preloadTargetCache.BulletDataSourceMap[text] = config.DataTable;
		config.CurIndex++;
	}

	// Token: 0x06016191 RID: 90513 RVA: 0x0066C968 File Offset: 0x0066AB68
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

	// Token: 0x06016192 RID: 90514 RVA: 0x0066C9B2 File Offset: 0x0066ABB2
	[return: Nullable(2)]
	private SReBulletDataMain GetPreloadRowData(PreloadBulletConfig config, string rowName)
	{
		return DataTableUtil.GetDataTableRow<SReBulletDataMain>(config.DataTable, rowName);
	}

	// Token: 0x06016193 RID: 90515 RVA: 0x0066C9C0 File Offset: 0x0066ABC0
	public void ClearPreload()
	{
		this.CurPreloadBulletConfig = null;
		this.PreloadBulletConfigs.Clear();
	}

	// Token: 0x06016194 RID: 90516 RVA: 0x0066C9D4 File Offset: 0x0066ABD4
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
			if (!this.GlobalCommonBulletCache.BulletDataMap.ContainsKey(text) || this.GlobalCommonBulletCache.BulletDataSourceMap.GetValueOrDefault(text) != commonBulletDataTable)
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
						this.GlobalCommonBulletCache.BulletDataMap[text] = bulletDataMain;
						this.GlobalCommonBulletCache.BulletDataSourceMap[text] = commonBulletDataTable;
					}
				}
			}
		}
	}

	// Token: 0x1700217D RID: 8573
	// (get) Token: 0x06016195 RID: 90517 RVA: 0x0066CAB7 File Offset: 0x0066ACB7
	public static BulletConfig Instance
	{
		get
		{
			return BulletConfig._Instance;
		}
	}

	// Token: 0x06016196 RID: 90518 RVA: 0x0066CABE File Offset: 0x0066ACBE
	public static BulletConfig GetOrCreateInstance()
	{
		if (BulletConfig._Instance == null)
		{
			BulletConfig.CreateInstance();
		}
		return BulletConfig._Instance;
	}

	// Token: 0x06016197 RID: 90519 RVA: 0x0066CAD2 File Offset: 0x0066ACD2
	public static bool CreateInstance()
	{
		if (BulletConfig._Instance != null)
		{
			return true;
		}
		BulletConfig._Instance = new BulletConfig();
		return true;
	}

	// Token: 0x06016198 RID: 90520 RVA: 0x0066CAE8 File Offset: 0x0066ACE8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06016199 RID: 90521 RVA: 0x0066CAEA File Offset: 0x0066ACEA
	public static void ResetStaticDefaultValue()
	{
		BulletConfig._Instance = null;
	}

	// Token: 0x0601619A RID: 90522 RVA: 0x0066CAF2 File Offset: 0x0066ACF2
	static BulletConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BulletConfig.CreateStaticDefaultValue), new Action(BulletConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0601619C RID: 90524 RVA: 0x0066CBE9 File Offset: 0x0066ADE9
	[NullableContext(2)]
	[CompilerGenerated]
	internal static bool <CancelExtraPreload>g__IsTarget|30_0(PreloadBulletConfig config, ref BulletConfig.<>c__DisplayClass30_0 A_1)
	{
		return config != null && config.Source == EBulletPreloadSource.Extra && config.EntityId == A_1.entityId && config.DataTable == A_1.table;
	}

	// Token: 0x0400B975 RID: 47477
	private readonly Stat PreloadStat = Stat.Create("BulletConfig.Preload", "", "");

	// Token: 0x0400B976 RID: 47478
	private readonly Stat TickPreloadStat = Stat.Create("BulletConfig.TickPreload", "", "");

	// Token: 0x0400B977 RID: 47479
	private readonly Stat GetBulletDataStat = Stat.Create("BulletConfig.GetBulletData", "", "");

	// Token: 0x0400B978 RID: 47480
	private readonly Stat ResolveBulletDataSourceStat = Stat.Create("BulletConfig.ResolveBulletDataSource", "", "");

	// Token: 0x0400B979 RID: 47481
	private readonly Dictionary<int, BulletDataCacheInfo> SelfBulletCacheMap = new Dictionary<int, BulletDataCacheInfo>();

	// Token: 0x0400B97A RID: 47482
	private readonly Dictionary<int, BulletDataCacheInfo> ExtraBulletCacheMap = new Dictionary<int, BulletDataCacheInfo>();

	// Token: 0x0400B97B RID: 47483
	private readonly BulletDataCacheInfo GameplayCommonBulletCache = new BulletDataCacheInfo();

	// Token: 0x0400B97C RID: 47484
	private readonly BulletDataCacheInfo GlobalCommonBulletCache = new BulletDataCacheInfo();

	// Token: 0x0400B97D RID: 47485
	private readonly Dictionary<int, int> EntityMap = new Dictionary<int, int>();

	// Token: 0x0400B97E RID: 47486
	private readonly List<PreloadBulletConfig> PreloadBulletConfigs = new List<PreloadBulletConfig>();

	// Token: 0x0400B97F RID: 47487
	[Nullable(2)]
	private PreloadBulletConfig CurPreloadBulletConfig;

	// Token: 0x0400B980 RID: 47488
	[StaticVariableRuleIgnore]
	private static readonly string[] CommonPreloadWhitelist = new string[]
	{
		"100121",
		"100122"
	};

	// Token: 0x0400B981 RID: 47489
	[Nullable(2)]
	private static BulletConfig _Instance;
}
