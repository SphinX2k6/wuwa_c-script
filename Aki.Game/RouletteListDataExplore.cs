using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RecallQuest.Model;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;

// Token: 0x02001E94 RID: 7828
[NullableContext(1)]
[Nullable(0)]
public class RouletteListDataExplore : RouletteListDataBase
{
	// Token: 0x17001D85 RID: 7557
	// (get) Token: 0x06013511 RID: 79121 RVA: 0x005A3742 File Offset: 0x005A1942
	public override ERouletteType RouletteType
	{
		get
		{
			return ERouletteType.Explore;
		}
	}

	// Token: 0x17001D86 RID: 7558
	// (get) Token: 0x06013512 RID: 79122 RVA: 0x005A3745 File Offset: 0x005A1945
	public override ERoulettePriority Priority
	{
		get
		{
			return ERoulettePriority.Explore;
		}
	}

	// Token: 0x06013513 RID: 79123 RVA: 0x005A374C File Offset: 0x005A194C
	public RouletteListDataExplore()
	{
		this.DefaultExtraItemIdProxy = new NormalExtraItemIdProxy(this);
		this.ActiveExtraItemIdProxy = this.DefaultExtraItemIdProxy;
	}

	// Token: 0x06013514 RID: 79124 RVA: 0x005A3879 File Offset: 0x005A1A79
	[NullableContext(2)]
	public void SetExtraItemIdProxy(IExtraItemIdProxy proxy)
	{
		this.ActiveExtraItemIdProxy = (proxy ?? this.DefaultExtraItemIdProxy);
	}

	// Token: 0x06013515 RID: 79125 RVA: 0x005A388C File Offset: 0x005A1A8C
	public IExtraItemIdProxy GetExtraItemIdProxy()
	{
		return this.ActiveExtraItemIdProxy;
	}

	// Token: 0x06013516 RID: 79126 RVA: 0x005A3894 File Offset: 0x005A1A94
	public override List<int> GetRouletteIdList()
	{
		if (this.IsRouletteReplace())
		{
			return this.RouletteIdListReplace;
		}
		return this.RouletteIdListServer;
	}

	// Token: 0x06013517 RID: 79127 RVA: 0x005A38AB File Offset: 0x005A1AAB
	public override int GetExtraItemId()
	{
		if (this.IsRouletteReplace())
		{
			return this.ExtraItemIdReplace;
		}
		return this.ActiveExtraItemIdProxy.GetExtraItemId();
	}

	// Token: 0x06013518 RID: 79128 RVA: 0x005A38C7 File Offset: 0x005A1AC7
	public override int GetEquipExploreSkillId()
	{
		return this.EquipExploreSkillIdServer;
	}

	// Token: 0x06013519 RID: 79129 RVA: 0x005A38CF File Offset: 0x005A1ACF
	public override void Init()
	{
		this.InitExploreRouletteReplaceConfig();
		this.OnAddEvents();
	}

	// Token: 0x0601351A RID: 79130 RVA: 0x005A38DD File Offset: 0x005A1ADD
	public override void Clear()
	{
		this.OnRemoveEvents();
	}

	// Token: 0x0601351B RID: 79131 RVA: 0x005A38E8 File Offset: 0x005A1AE8
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

	// Token: 0x0601351C RID: 79132 RVA: 0x005A39DE File Offset: 0x005A1BDE
	public override bool IsActivate()
	{
		return true;
	}

	// Token: 0x0601351D RID: 79133 RVA: 0x005A39E1 File Offset: 0x005A1BE1
	private void OnAddEvents()
	{
		EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
	}

	// Token: 0x0601351E RID: 79134 RVA: 0x005A39FF File Offset: 0x005A1BFF
	private void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
	}

	// Token: 0x0601351F RID: 79135 RVA: 0x005A3A1D File Offset: 0x005A1C1D
	public override bool IsRouletteReplace()
	{
		return this.ReplaceId != null;
	}

	// Token: 0x06013520 RID: 79136 RVA: 0x005A3A2F File Offset: 0x005A1C2F
	public bool SetExtraItemIdReplace(int itemId)
	{
		if (!this.IsRouletteReplace())
		{
			return false;
		}
		this.ExtraItemIdReplace = itemId;
		return true;
	}

	// Token: 0x06013521 RID: 79137 RVA: 0x005A3A43 File Offset: 0x005A1C43
	public override bool IsRouletteOpen()
	{
		return FunctionModel.Instance.IsOpen(10026);
	}

	// Token: 0x06013522 RID: 79138 RVA: 0x005A3A54 File Offset: 0x005A1C54
	public override bool IsMainRouletteCanOpenView(bool checkTips)
	{
		return RouletteModel.Instance.IsExploreRouletteOpen(checkTips);
	}

	// Token: 0x06013523 RID: 79139 RVA: 0x005A3A61 File Offset: 0x005A1C61
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

	// Token: 0x06013524 RID: 79140 RVA: 0x005A3A84 File Offset: 0x005A1C84
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

	// Token: 0x06013525 RID: 79141 RVA: 0x005A3B1A File Offset: 0x005A1D1A
	public override RouletteMainViewProxyBase GetRouletteMainViewProxy()
	{
		return new RouletteMainViewProxy();
	}

	// Token: 0x06013526 RID: 79142 RVA: 0x005A3B21 File Offset: 0x005A1D21
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

	// Token: 0x06013527 RID: 79143 RVA: 0x005A3B2C File Offset: 0x005A1D2C
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

	// Token: 0x06013528 RID: 79144 RVA: 0x005A3CF8 File Offset: 0x005A1EF8
	private void OnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
		this.StopListenRelatedTags();
		this.ListenRelatedTags(newEntity);
	}

	// Token: 0x06013529 RID: 79145 RVA: 0x005A3D08 File Offset: 0x005A1F08
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

	// Token: 0x0601352A RID: 79146 RVA: 0x005A3D98 File Offset: 0x005A1F98
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

	// Token: 0x0601352B RID: 79147 RVA: 0x005A3E20 File Offset: 0x005A2020
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

	// Token: 0x0601352C RID: 79148 RVA: 0x005A3E78 File Offset: 0x005A2078
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

	// Token: 0x0601352D RID: 79149 RVA: 0x005A3EB8 File Offset: 0x005A20B8
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
		int[] rouletteSkillIdListArray = replaceConfigById.Value.GetRouletteSkillIdListArray();
		int num3 = 8;
		if (num3 > rouletteSkillIdListArray.Length)
		{
			num3 = rouletteSkillIdListArray.Length;
		}
		List<int> list = new List<int>(num3);
		for (int i = 0; i < num3; i++)
		{
			list.Add(rouletteSkillIdListArray[i]);
		}
		this.RouletteIdListReplace.AddRange(list);
		int count = this.RouletteIdListReplace.Count;
		for (int j = 0; j < 8 - count; j++)
		{
			this.RouletteIdListReplace.Add(0);
		}
		int? extraItemIdReplaceOverride = this.ActiveExtraItemIdProxy.GetExtraItemIdReplaceOverride();
		int? num4 = new int?(extraItemIdReplaceOverride ?? replaceConfigById.Value.RouletteItemId);
		if (extraItemIdReplaceOverride == null && num4 != null && num4.Value != 0 && InventoryModel.Instance.GetItemCountByConfigId(num4.Value, 0) <= 0)
		{
			num4 = new int?(0);
		}
		this.ExtraItemIdReplace = num4.GetValueOrDefault();
		this.RecordEquipExploreSkillId = this.EquipExploreSkillIdServer;
		int? num5 = new int?(replaceConfigById.Value.ReplaceSkillId);
		if (num5 != null && num5.Value != 0 && base.IsFirstExplorePriority() && RecallQuestModel.Instance.CacheRecallExploreSkillId == null)
		{
			CharacterExploreModel.Instance.SetExploreSkillId(num5.Value, EExploreSkillLayer.Roulette, "ActiveReplaceConfig");
			RouletteController.Instance.ExploreSkillSetRequest(num5.Value, null, true);
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Phantom;
		ELogAuthor author = ELogAuthor.YYZ;
		string message = "[ExploreRoulette] 进入替换模式";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ReplaceId", this.ReplaceId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ReplaceSkillId", num5);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ReplaceItemId", num4);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("RestoreSkillId", this.RecordEquipExploreSkillId);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
	}

	// Token: 0x0601352E RID: 79150 RVA: 0x005A413C File Offset: 0x005A233C
	private void DisActiveReplaceConfig()
	{
		if (this.ReplaceId == null)
		{
			return;
		}
		this.ReplaceId = null;
		int recordEquipExploreSkillId = this.RecordEquipExploreSkillId;
		if (recordEquipExploreSkillId != 0 && base.IsFirstExplorePriority() && RecallQuestModel.Instance.CacheRecallExploreSkillId == null)
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

	// Token: 0x0601352F RID: 79151 RVA: 0x005A41D7 File Offset: 0x005A23D7
	private bool CheckIsSpecialItem()
	{
		return this.GetExtraItemId() != 0 && SpecialItemController.Instance.IsSpecialItem(this.GetExtraItemId());
	}

	// Token: 0x06013530 RID: 79152 RVA: 0x005A41F4 File Offset: 0x005A23F4
	private List<AssemblyGridData> CreateAllAssemblyDataExplore()
	{
		List<AssemblyExploreGridData> list = new List<AssemblyExploreGridData>();
		foreach (KeyValuePair<int, ExploreTools> keyValuePair in RouletteModel.Instance.UnlockExploreSkillDataMap)
		{
			int key = keyValuePair.Key;
			ExploreTools value = keyValuePair.Value;
			if (NoLinq.Contains<int>(value.GetRouletteTypeBytes(), (int)this.RouletteType) && value.CanAssemblyShow)
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
		return new List<AssemblyGridData>(list);
	}

	// Token: 0x06013531 RID: 79153 RVA: 0x005A4320 File Offset: 0x005A2520
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
			return new List<AssemblyGridData>(list);
		}
		foreach (CommonItemData commonItemData2 in InventoryModel.Instance.GetCommonItemByItemType(InventoryDefine.EItemType.Common))
		{
			int itemBuffType = commonItemData2.GetConfig().As<ItemInfo>().Value.ItemBuffType;
			if (NoLinq.Contains<int>(intArrayConfig, itemBuffType))
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
		return new List<AssemblyGridData>(list);
	}

	// Token: 0x0400A593 RID: 42387
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

	// Token: 0x0400A594 RID: 42388
	[Nullable(2)]
	private EntityHandle RelatedTagEntityHandle;

	// Token: 0x0400A595 RID: 42389
	private readonly List<int> RelatedTagIdPriorityList = new List<int>();

	// Token: 0x0400A596 RID: 42390
	private readonly List<bool> RelatedTagIdExistPriorityList = new List<bool>();

	// Token: 0x0400A597 RID: 42391
	private readonly Dictionary<int, int> ReplaceTagId2ReplaceId = new Dictionary<int, int>();

	// Token: 0x0400A598 RID: 42392
	private int? ReplaceId;

	// Token: 0x0400A599 RID: 42393
	private readonly List<int> RouletteIdListReplace = new List<int>();

	// Token: 0x0400A59A RID: 42394
	private int ExtraItemIdReplace;

	// Token: 0x0400A59B RID: 42395
	private int RecordEquipExploreSkillId;

	// Token: 0x0400A59C RID: 42396
	private readonly NormalExtraItemIdProxy DefaultExtraItemIdProxy;

	// Token: 0x0400A59D RID: 42397
	private IExtraItemIdProxy ActiveExtraItemIdProxy;
}
