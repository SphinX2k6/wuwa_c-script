using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;

// Token: 0x02002919 RID: 10521
[NullableContext(1)]
[Nullable(0)]
public class RouletteListDataExplore : RouletteListDataBase
{
	// Token: 0x17001D2B RID: 7467
	// (get) Token: 0x06015B0D RID: 88845 RVA: 0x0057884E File Offset: 0x00576A4E
	public override ERouletteType RouletteType
	{
		get
		{
			return ERouletteType.Explore;
		}
	}

	// Token: 0x17001D2C RID: 7468
	// (get) Token: 0x06015B0E RID: 88846 RVA: 0x00578851 File Offset: 0x00576A51
	public override ERoulettePriority Priority
	{
		get
		{
			return ERoulettePriority.Explore;
		}
	}

	// Token: 0x06015B0F RID: 88847 RVA: 0x00578858 File Offset: 0x00576A58
	public RouletteListDataExplore()
	{
		this.DefaultExtraItemIdProxy = new NormalExtraItemIdProxy(this);
		this.ActiveExtraItemIdProxy = this.DefaultExtraItemIdProxy;
	}

	// Token: 0x06015B10 RID: 88848 RVA: 0x00578985 File Offset: 0x00576B85
	[NullableContext(2)]
	public void SetExtraItemIdProxy(IExtraItemIdProxy proxy)
	{
		this.ActiveExtraItemIdProxy = (proxy ?? this.DefaultExtraItemIdProxy);
	}

	// Token: 0x06015B11 RID: 88849 RVA: 0x00578998 File Offset: 0x00576B98
	public IExtraItemIdProxy GetExtraItemIdProxy()
	{
		return this.ActiveExtraItemIdProxy;
	}

	// Token: 0x06015B12 RID: 88850 RVA: 0x005789A0 File Offset: 0x00576BA0
	public override List<int> GetRouletteIdList()
	{
		if (this.IsRouletteReplace())
		{
			return this.RouletteIdListReplace;
		}
		return this.RouletteIdListServer;
	}

	// Token: 0x06015B13 RID: 88851 RVA: 0x005789B7 File Offset: 0x00576BB7
	public override int GetExtraItemId()
	{
		if (this.IsRouletteReplace())
		{
			return this.ExtraItemIdReplace;
		}
		return this.ActiveExtraItemIdProxy.GetExtraItemId();
	}

	// Token: 0x06015B14 RID: 88852 RVA: 0x005789D3 File Offset: 0x00576BD3
	public override int GetEquipExploreSkillId()
	{
		return this.EquipExploreSkillIdServer;
	}

	// Token: 0x06015B15 RID: 88853 RVA: 0x005789DB File Offset: 0x00576BDB
	public override void Init()
	{
		this.InitExploreRouletteReplaceConfig();
		this.OnAddEvents();
	}

	// Token: 0x06015B16 RID: 88854 RVA: 0x005789E9 File Offset: 0x00576BE9
	public override void Clear()
	{
		this.OnRemoveEvents();
	}

	// Token: 0x06015B17 RID: 88855 RVA: 0x005789F4 File Offset: 0x00576BF4
	public override void UpdateData(ExploreSkillRoulette exploreList)
	{
		this.RouletteIdListServer = exploreList.SkillIds.ToList<int>();
		bool flag = this.CheckIsSpecialItem();
		this.ExtraItemIdServer = exploreList.ExtraItemId;
		this.DefaultExtraItemIdProxy.ApplyServerSnapshot(this.ExtraItemIdServer);
		if (this.CheckIsSpecialItem())
		{
			EventSystem.Instance.Emit<int?>(EEventName.OnSpecialItemUpdate, new int?(this.GetExtraItemId()));
		}
		else if (flag)
		{
			EventSystem.Instance.Emit<int?>(EEventName.OnSpecialItemUpdate, null);
		}
		this.EquipExploreSkillIdServer = exploreList.ExploreSkill;
		if (this.ExtraItemIdServer == 0 && this.EquipExploreSkillIdServer == 3001)
		{
			IRouletteListSaveData rouletteListSaveData = base.GetRouletteListSaveData();
			rouletteListSaveData.EquipExploreSkillId = 3002;
			RouletteController.Instance.SaveRouletteDataRequest(rouletteListSaveData, null);
			return;
		}
		if (this.ExtraItemIdServer != 0 && this.EquipExploreSkillIdServer == 3002)
		{
			IRouletteListSaveData rouletteListSaveData2 = base.GetRouletteListSaveData();
			rouletteListSaveData2.EquipExploreSkillId = 3001;
			RouletteController.Instance.SaveRouletteDataRequest(rouletteListSaveData2, null);
		}
	}

	// Token: 0x06015B18 RID: 88856 RVA: 0x00578AEA File Offset: 0x00576CEA
	public override bool IsActivate()
	{
		return true;
	}

	// Token: 0x06015B19 RID: 88857 RVA: 0x00578AED File Offset: 0x00576CED
	private void OnAddEvents()
	{
		EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
	}

	// Token: 0x06015B1A RID: 88858 RVA: 0x00578B0B File Offset: 0x00576D0B
	private void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
	}

	// Token: 0x06015B1B RID: 88859 RVA: 0x00578B29 File Offset: 0x00576D29
	public override bool IsRouletteReplace()
	{
		return this.ReplaceId != null;
	}

	// Token: 0x06015B1C RID: 88860 RVA: 0x00578B3B File Offset: 0x00576D3B
	public bool SetExtraItemIdReplace(int itemId)
	{
		if (!this.IsRouletteReplace())
		{
			return false;
		}
		this.ExtraItemIdReplace = itemId;
		return true;
	}

	// Token: 0x06015B1D RID: 88861 RVA: 0x00578B4F File Offset: 0x00576D4F
	public override bool IsRouletteOpen()
	{
		return FunctionModel.Instance.IsOpen(10026);
	}

	// Token: 0x06015B1E RID: 88862 RVA: 0x00578B60 File Offset: 0x00576D60
	public override bool IsMainRouletteCanOpenView(bool checkTips)
	{
		return RouletteModel.Instance.IsExploreRouletteOpen(checkTips);
	}

	// Token: 0x06015B1F RID: 88863 RVA: 0x00578B6D File Offset: 0x00576D6D
	public override Dictionary<ERouletteGridType, List<AssemblyGridData>> CreateAssemblyGridData()
	{
		return new Dictionary<ERouletteGridType, List<AssemblyGridData>>
		{
			{
				ERouletteGridType.Explore,
				this.CreateAllAssemblyDataExplore()
			},
			{
				ERouletteGridType.EquipItem,
				this.CreateAllAssemblyDataEquipItem()
			}
		};
	}

	// Token: 0x06015B20 RID: 88864 RVA: 0x00578B90 File Offset: 0x00576D90
	public override int? GetRouletteGridId(int index, ERouletteGridType type, bool useDisplay)
	{
		if (type != ERouletteGridType.Explore)
		{
			if (type != ERouletteGridType.EquipItem)
			{
				return null;
			}
			if (useDisplay)
			{
				return new int?(this.GetExtraItemId());
			}
			return new int?(this.ExtraItemIdServer);
		}
		else if (useDisplay)
		{
			List<int> rouletteIdList = this.GetRouletteIdList();
			if (index >= 0 && index < rouletteIdList.Count)
			{
				return new int?(rouletteIdList[index]);
			}
			return null;
		}
		else
		{
			if (index >= 0 && index < this.RouletteIdListServer.Count)
			{
				return new int?(this.RouletteIdListServer[index]);
			}
			return null;
		}
	}

	// Token: 0x06015B21 RID: 88865 RVA: 0x00578C26 File Offset: 0x00576E26
	public override RouletteMainViewProxyBase GetRouletteMainViewProxy()
	{
		return new RouletteMainViewProxy();
	}

	// Token: 0x06015B22 RID: 88866 RVA: 0x00578C2D File Offset: 0x00576E2D
	[return: Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	public override List<ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>> GetRouletteDataMap()
	{
		return this.ExploreRouletteMap;
	}

	// Token: 0x06015B23 RID: 88867 RVA: 0x00578C38 File Offset: 0x00576E38
	private unsafe void InitExploreRouletteReplaceConfig()
	{
		this.ReplaceTagId2ReplaceId.Clear();
		this.RelatedTagIdPriorityList.Clear();
		this.RelatedTagIdExistPriorityList.Clear();
		IEnumerable<ExploreRouletteReplace> allReplaceConfig = RouletteConfig.Instance.GetAllReplaceConfig();
		List<IRouletteReplaceParam> list = new List<IRouletteReplaceParam>();
		foreach (ExploreRouletteReplace exploreRouletteReplace in allReplaceConfig)
		{
			for (int i = 0; i < exploreRouletteReplace.TagsInForceLength; i++)
			{
				string text = exploreRouletteReplace.TagsInForce(i);
				int tagIdByName = GameplayTagUtils.GetTagIdByName(text);
				if (tagIdByName == 0)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Phantom;
					ELogAuthor author = ELogAuthor.YYZ;
					string message = "[ExploreRoulette] 探索工具轮盘替换配置Tag不存在,请检查配置";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ReplaceId", exploreRouletteReplace.Id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("tagName", text);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				else
				{
					RouletteReplaceParam item = new RouletteReplaceParam
					{
						TagId = tagIdByName,
						SortId = exploreRouletteReplace.Priority,
						ReplaceId = exploreRouletteReplace.Id
					};
					list.Add(item);
					this.ReplaceTagId2ReplaceId.Add(tagIdByName, exploreRouletteReplace.Id);
				}
			}
		}
		list.Sort((IRouletteReplaceParam a, IRouletteReplaceParam b) => a.SortId - b.SortId);
		foreach (IRouletteReplaceParam rouletteReplaceParam in list)
		{
			this.RelatedTagIdPriorityList.Add(rouletteReplaceParam.TagId);
			this.RelatedTagIdExistPriorityList.Add(false);
		}
	}

	// Token: 0x06015B24 RID: 88868 RVA: 0x00578E04 File Offset: 0x00577004
	private void OnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
		this.StopListenRelatedTags();
		this.ListenRelatedTags(newEntity);
	}

	// Token: 0x06015B25 RID: 88869 RVA: 0x00578E14 File Offset: 0x00577014
	[NullableContext(2)]
	private void ListenRelatedTags(EntityHandle entityHandle)
	{
		RoleTagComponent roleTagComponent;
		if (entityHandle == null)
		{
			roleTagComponent = null;
		}
		else
		{
			WorldEntity entity = entityHandle.Entity;
			roleTagComponent = ((entity != null) ? entity.GetComponent<RoleTagComponent>() : null);
		}
		RoleTagComponent roleTagComponent2 = roleTagComponent;
		this.StopListenRelatedTags();
		List<int> relatedTagIdPriorityList = this.RelatedTagIdPriorityList;
		List<bool> relatedTagIdExistPriorityList = this.RelatedTagIdExistPriorityList;
		for (int i = 0; i < relatedTagIdPriorityList.Count; i++)
		{
			int tagId = relatedTagIdPriorityList[i];
			if (roleTagComponent2 != null)
			{
				roleTagComponent2.AddTagAddOrRemoveListener(tagId, new BaseTagComponent.TTagSwitchedCallback(this.OnRelatedTagAddOrRemove), null);
			}
			relatedTagIdExistPriorityList[i] = (roleTagComponent2 != null && roleTagComponent2.HasTag(tagId));
		}
		this.RelatedTagEntityHandle = entityHandle;
		this.RefreshReplaceConfig(relatedTagIdPriorityList, relatedTagIdExistPriorityList);
	}

	// Token: 0x06015B26 RID: 88870 RVA: 0x00578EA4 File Offset: 0x005770A4
	protected void StopListenRelatedTags()
	{
		EntityHandle relatedTagEntityHandle = this.RelatedTagEntityHandle;
		if (relatedTagEntityHandle == null)
		{
			return;
		}
		WorldEntity entity = relatedTagEntityHandle.Entity;
		RoleTagComponent roleTagComponent = (entity != null) ? entity.GetComponent<RoleTagComponent>() : null;
		if (roleTagComponent != null)
		{
			foreach (int tagId in this.RelatedTagIdPriorityList)
			{
				roleTagComponent.RemoveTagAddOrRemoveListener(tagId, new BaseTagComponent.TTagSwitchedCallback(this.OnRelatedTagAddOrRemove));
			}
		}
		this.RelatedTagEntityHandle = null;
	}

	// Token: 0x06015B27 RID: 88871 RVA: 0x00578F2C File Offset: 0x0057712C
	private void OnRelatedTagAddOrRemove(int tagId, bool tagExist)
	{
		EntityHandle relatedTagEntityHandle = this.RelatedTagEntityHandle;
		bool flag;
		if (relatedTagEntityHandle == null)
		{
			flag = (null != null);
		}
		else
		{
			WorldEntity entity = relatedTagEntityHandle.Entity;
			flag = (((entity != null) ? entity.GetComponent<RoleTagComponent>() : null) != null);
		}
		if (!flag)
		{
			return;
		}
		List<int> relatedTagIdPriorityList = this.RelatedTagIdPriorityList;
		List<bool> relatedTagIdExistPriorityList = this.RelatedTagIdExistPriorityList;
		int num = relatedTagIdPriorityList.IndexOf(tagId);
		if (num >= 0)
		{
			relatedTagIdExistPriorityList[num] = tagExist;
		}
		this.RefreshReplaceConfig(relatedTagIdPriorityList, relatedTagIdExistPriorityList);
	}

	// Token: 0x06015B28 RID: 88872 RVA: 0x00578F84 File Offset: 0x00577184
	private void RefreshReplaceConfig(List<int> tagIdList, List<bool> existList)
	{
		for (int i = 0; i < existList.Count; i++)
		{
			if (existList[i])
			{
				int tagId = tagIdList[i];
				this.ActiveReplaceConfig(tagId);
				return;
			}
		}
		this.DisActiveReplaceConfig();
	}

	// Token: 0x06015B29 RID: 88873 RVA: 0x00578FC4 File Offset: 0x005771C4
	private unsafe void ActiveReplaceConfig(int tagId)
	{
		int num;
		if (!this.ReplaceTagId2ReplaceId.TryGetValue(tagId, out num))
		{
			return;
		}
		int? replaceId = this.ReplaceId;
		int num2 = num;
		if (replaceId.GetValueOrDefault() == num2 & replaceId != null)
		{
			return;
		}
		this.ReplaceId = new int?(num);
		ExploreRouletteReplace? replaceConfigById = RouletteConfig.Instance.GetReplaceConfigById(num);
		if (replaceConfigById == null)
		{
			return;
		}
		this.RouletteIdListReplace.Clear();
		List<int> collection = replaceConfigById.Value.GetRouletteSkillIdListArray().Take(8).ToList<int>();
		this.RouletteIdListReplace.AddRange(collection);
		int count = this.RouletteIdListReplace.Count;
		for (int i = 0; i < 8 - count; i++)
		{
			this.RouletteIdListReplace.Add(0);
		}
		int? extraItemIdReplaceOverride = this.ActiveExtraItemIdProxy.GetExtraItemIdReplaceOverride();
		int? num3 = new int?(extraItemIdReplaceOverride ?? replaceConfigById.Value.RouletteItemId);
		if (extraItemIdReplaceOverride == null && num3 != null && num3.Value != 0 && InventoryModel.Instance.GetItemCountByConfigId(num3.Value, 0) <= 0)
		{
			num3 = new int?(0);
		}
		this.ExtraItemIdReplace = num3.GetValueOrDefault();
		this.RecordEquipExploreSkillId = this.EquipExploreSkillIdServer;
		int? num4 = new int?(replaceConfigById.Value.ReplaceSkillId);
		if (num4 != null && num4.Value != 0 && base.IsFirstExplorePriority())
		{
			CharacterExploreModel.Instance.SetExploreSkillId(num4.Value, EExploreSkillLayer.Roulette, "ActiveReplaceConfig");
			RouletteController.Instance.ExploreSkillSetRequest(num4.Value, null, true);
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Phantom;
		ELogAuthor author = ELogAuthor.YYZ;
		string message = "[ExploreRoulette] 进入替换模式";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ReplaceId", this.ReplaceId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ReplaceSkillId", num4);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ReplaceItemId", num3);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("RestoreSkillId", this.RecordEquipExploreSkillId);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
	}

	// Token: 0x06015B2A RID: 88874 RVA: 0x00579210 File Offset: 0x00577410
	private void DisActiveReplaceConfig()
	{
		if (this.ReplaceId == null)
		{
			return;
		}
		this.ReplaceId = null;
		int recordEquipExploreSkillId = this.RecordEquipExploreSkillId;
		if (recordEquipExploreSkillId != 0 && base.IsFirstExplorePriority())
		{
			CharacterExploreModel.Instance.SetExploreSkillId(recordEquipExploreSkillId, EExploreSkillLayer.Roulette, "DisActiveReplaceConfig");
			RouletteController.Instance.ExploreSkillSetRequest(recordEquipExploreSkillId, null, true);
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Phantom;
		ELogAuthor author = ELogAuthor.YYZ;
		string message = "[ExploreRoulette] 退出替换模式";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RestoreSkillId", recordEquipExploreSkillId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.RecordEquipExploreSkillId = 0;
	}

	// Token: 0x06015B2B RID: 88875 RVA: 0x0057929A File Offset: 0x0057749A
	private bool CheckIsSpecialItem()
	{
		return this.GetExtraItemId() != 0 && SpecialItemController.Instance.IsSpecialItem(this.GetExtraItemId());
	}

	// Token: 0x06015B2C RID: 88876 RVA: 0x005792B8 File Offset: 0x005774B8
	private List<AssemblyGridData> CreateAllAssemblyDataExplore()
	{
		List<AssemblyExploreGridData> list = new List<AssemblyExploreGridData>();
		foreach (KeyValuePair<int, ExploreTools> keyValuePair in RouletteModel.Instance.UnlockExploreSkillDataMap)
		{
			int key = keyValuePair.Key;
			ExploreTools value = keyValuePair.Value;
			if (value.GetRouletteTypeArray().Contains((int)this.RouletteType) && value.CanAssemblyShow)
			{
				AssemblyExploreGridData assemblyExploreGridData = new AssemblyExploreGridData();
				assemblyExploreGridData.GridType = ERouletteGridType.Explore;
				assemblyExploreGridData.IconPath = value.BackGround;
				assemblyExploreGridData.Name = value.Name;
				assemblyExploreGridData.Id = key;
				int? sort = value.GetSort((int)this.RouletteType);
				if (sort != null && sort.Value > 0)
				{
					assemblyExploreGridData.SortId = sort.Value;
				}
				else
				{
					assemblyExploreGridData.SortId = 0;
				}
				list.Add(assemblyExploreGridData);
			}
		}
		list.Sort((AssemblyExploreGridData a, AssemblyExploreGridData b) => a.SortId - b.SortId);
		return list.Cast<AssemblyGridData>().ToList<AssemblyGridData>();
	}

	// Token: 0x06015B2D RID: 88877 RVA: 0x005793E8 File Offset: 0x005775E8
	private List<AssemblyGridData> CreateAllAssemblyDataEquipItem()
	{
		List<AssemblyEquipItemGridData> list = new List<AssemblyEquipItemGridData>();
		foreach (CommonItemData commonItemData in InventoryModel.Instance.GetCommonItemByItemType(InventoryDefine.EItemType.SpecialItem))
		{
			SpecialItem? config = SpecialItemConfig.Instance.GetConfig(commonItemData.GetConfigId());
			if (config != null && config.Value.SpecialItemType == 0)
			{
				list.Add(new AssemblyEquipItemGridData
				{
					Id = commonItemData.GetConfigId(),
					GridType = ERouletteGridType.EquipItem,
					Name = commonItemData.GetConfig().As<ItemInfo>().Value.Name,
					ItemNum = commonItemData.GetCount(),
					ItemType = InventoryDefine.EItemType.SpecialItem,
					SortId = commonItemData.GetSortIndex(),
					QualityId = commonItemData.GetQuality()
				});
			}
		}
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("Roulette_EquipItem_ShowTypeList");
		if (intArrayConfig == null)
		{
			return list.Cast<AssemblyGridData>().ToList<AssemblyGridData>();
		}
		IReadOnlyList<int> source = intArrayConfig;
		foreach (CommonItemData commonItemData2 in InventoryModel.Instance.GetCommonItemByItemType(InventoryDefine.EItemType.Common))
		{
			int itemBuffType = commonItemData2.GetConfig().As<ItemInfo>().Value.ItemBuffType;
			if (source.Contains(itemBuffType))
			{
				list.Add(new AssemblyEquipItemGridData
				{
					Id = commonItemData2.GetConfigId(),
					GridType = ERouletteGridType.EquipItem,
					Name = commonItemData2.GetConfig().As<ItemInfo>().Value.Name,
					ItemNum = commonItemData2.GetCount(),
					ItemType = InventoryDefine.EItemType.Common,
					SortId = commonItemData2.GetSortIndex(),
					QualityId = commonItemData2.GetQuality()
				});
			}
		}
		return list.Cast<AssemblyGridData>().ToList<AssemblyGridData>();
	}

	// Token: 0x0400A1A8 RID: 41384
	[Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	private readonly List<ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>> ExploreRouletteMap = new List<ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>>
	{
		new ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>(new List<int>
		{
			1
		}, ERouletteComponentNode.RouletteItem1, ERouletteGridType.Explore),
		new ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>(new List<int>
		{
			2
		}, ERouletteComponentNode.RouletteItem2, ERouletteGridType.Explore),
		new ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>(new List<int>
		{
			3
		}, ERouletteComponentNode.RouletteItem3, ERouletteGridType.Explore),
		new ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>(new List<int>
		{
			4
		}, ERouletteComponentNode.RouletteItem4, ERouletteGridType.Explore),
		new ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>(new List<int>
		{
			5
		}, ERouletteComponentNode.RouletteItem5, ERouletteGridType.Explore),
		new ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>(new List<int>
		{
			6
		}, ERouletteComponentNode.RouletteItem6, ERouletteGridType.Explore),
		new ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>(new List<int>
		{
			7
		}, ERouletteComponentNode.RouletteItem7, ERouletteGridType.Explore),
		new ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>(new List<int>
		{
			8
		}, ERouletteComponentNode.RouletteItem8, ERouletteGridType.EquipItem)
	};

	// Token: 0x0400A1A9 RID: 41385
	[Nullable(2)]
	private EntityHandle RelatedTagEntityHandle;

	// Token: 0x0400A1AA RID: 41386
	private readonly List<int> RelatedTagIdPriorityList = new List<int>();

	// Token: 0x0400A1AB RID: 41387
	private readonly List<bool> RelatedTagIdExistPriorityList = new List<bool>();

	// Token: 0x0400A1AC RID: 41388
	private readonly Dictionary<int, int> ReplaceTagId2ReplaceId = new Dictionary<int, int>();

	// Token: 0x0400A1AD RID: 41389
	private int? ReplaceId;

	// Token: 0x0400A1AE RID: 41390
	private readonly List<int> RouletteIdListReplace = new List<int>();

	// Token: 0x0400A1AF RID: 41391
	private int ExtraItemIdReplace;

	// Token: 0x0400A1B0 RID: 41392
	private int RecordEquipExploreSkillId;

	// Token: 0x0400A1B1 RID: 41393
	private readonly NormalExtraItemIdProxy DefaultExtraItemIdProxy;

	// Token: 0x0400A1B2 RID: 41394
	private IExtraItemIdProxy ActiveExtraItemIdProxy;
}
