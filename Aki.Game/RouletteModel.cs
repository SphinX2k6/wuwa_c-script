using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;

// Token: 0x02002937 RID: 10551
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class RouletteModel : ModelBase
{
	// Token: 0x06015C42 RID: 89154 RVA: 0x0057D9E4 File Offset: 0x0057BBE4
	public bool IsExploreRouletteOpen(bool checkTips = false)
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		object obj;
		if (getCurrentEntity == null)
		{
			obj = null;
		}
		else
		{
			WorldEntity entity = getCurrentEntity.Entity;
			obj = ((entity != null) ? entity.GetComponent<BaseTagComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 != null && obj2.HasAnyTag(this.GetExploreRouletteBanTagIds()))
		{
			if (checkTips)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("ExploreToolCantOpen", Array.Empty<object>());
			}
			return false;
		}
		if (!LevelFuncFlagModel.Instance.GetFuncFlagEnable(ELevelFuncFlagId.ExploreSkillRoulette))
		{
			if (checkTips)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("ExploreToolCantOpen", Array.Empty<object>());
			}
			return false;
		}
		return FunctionModel.Instance.IsOpen(10026);
	}

	// Token: 0x06015C43 RID: 89155 RVA: 0x0057DA75 File Offset: 0x0057BC75
	public bool IsFunctionRouletteOpen()
	{
		return FunctionModel.Instance.IsOpen(10056);
	}

	// Token: 0x06015C44 RID: 89156 RVA: 0x0057DA86 File Offset: 0x0057BC86
	protected override bool OnInit()
	{
		this.InitAllRouletteListData();
		this.InitFunctionData();
		this.AddEvents();
		this.OnSettingExploreSkillIdList.Clear();
		return true;
	}

	// Token: 0x06015C45 RID: 89157 RVA: 0x0057DAA6 File Offset: 0x0057BCA6
	protected override bool OnClear()
	{
		this.ClearAllRouletteListData();
		this.RemoveEvents();
		return true;
	}

	// Token: 0x06015C46 RID: 89158 RVA: 0x0057DAB8 File Offset: 0x0057BCB8
	public List<int> GetExploreRouletteBanTagIds()
	{
		IReadOnlyList<ExploreRoulette> exploreRouletteConfig = RouletteConfig.Instance.GetExploreRouletteConfig();
		List<int> list = new List<int>();
		if (exploreRouletteConfig.Count == 0)
		{
			return list;
		}
		for (int i = 0; i < exploreRouletteConfig[0].BanTagsLength; i++)
		{
			string text = exploreRouletteConfig[0].BanTags(i);
			int? num = new int?(GameplayTagUtils.GetTagIdByName(text));
			if (num == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Phantom;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "探索工具轮盘禁用Tag不存在,请检查配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("tagName", text);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				list.Add(num.Value);
			}
		}
		return list;
	}

	// Token: 0x06015C47 RID: 89159 RVA: 0x0057DB5D File Offset: 0x0057BD5D
	protected void AddEvents()
	{
		EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenSet, this.UnlockFunction1);
		EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, this.UnlockFunction2);
	}

	// Token: 0x06015C48 RID: 89160 RVA: 0x0057DB8B File Offset: 0x0057BD8B
	protected void RemoveEvents()
	{
		EventSystem.Instance.Remove<EFunctionType, bool>(EEventName.OnFunctionOpenSet, this.UnlockFunction1);
		EventSystem.Instance.Remove<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, this.UnlockFunction2);
	}

	// Token: 0x06015C49 RID: 89161 RVA: 0x0057DBBC File Offset: 0x0057BDBC
	public List<RouletteListDataBase> GetActivatedRouletteList()
	{
		List<RouletteListDataBase> list = new List<RouletteListDataBase>();
		foreach (RouletteListDataBase rouletteListDataBase in this.RouletteListDataMap.Values)
		{
			if (rouletteListDataBase.IsActivate())
			{
				list.Add(rouletteListDataBase);
			}
		}
		list.Sort((RouletteListDataBase a, RouletteListDataBase b) => a.Priority - b.Priority);
		return list;
	}

	// Token: 0x06015C4A RID: 89162 RVA: 0x0057DC48 File Offset: 0x0057BE48
	public RouletteListDataBase GetCurrentExploreRouletteListData()
	{
		return this.GetActivatedRouletteList()[0];
	}

	// Token: 0x06015C4B RID: 89163 RVA: 0x0057DC56 File Offset: 0x0057BE56
	public RouletteListDataBase GetCurrentFunctionRouletteListData()
	{
		return this.RouletteListDataMap[ERouletteType.Function];
	}

	// Token: 0x06015C4C RID: 89164 RVA: 0x0057DC64 File Offset: 0x0057BE64
	private void InitAllRouletteListData()
	{
		this.RouletteListDataMap.Clear();
		RouletteListDataExplore value = new RouletteListDataExplore();
		this.RouletteListDataMap[ERouletteType.Explore] = value;
		RouletteListDataFunc value2 = new RouletteListDataFunc();
		this.RouletteListDataMap[ERouletteType.Function] = value2;
		RouletteListDataMotor value3 = new RouletteListDataMotor();
		this.RouletteListDataMap[ERouletteType.Motor] = value3;
		foreach (RouletteListDataBase rouletteListDataBase in this.RouletteListDataMap.Values)
		{
			rouletteListDataBase.Init();
		}
	}

	// Token: 0x06015C4D RID: 89165 RVA: 0x0057DD00 File Offset: 0x0057BF00
	private void ClearAllRouletteListData()
	{
		foreach (RouletteListDataBase rouletteListDataBase in this.RouletteListDataMap.Values)
		{
			rouletteListDataBase.Clear();
		}
		this.RouletteListDataMap.Clear();
	}

	// Token: 0x17001D33 RID: 7475
	// (get) Token: 0x06015C4E RID: 89166 RVA: 0x0057DD60 File Offset: 0x0057BF60
	// (set) Token: 0x06015C4F RID: 89167 RVA: 0x0057DD68 File Offset: 0x0057BF68
	public int CurrentExploreSkillId
	{
		get
		{
			return this.EquipExploreSkillId;
		}
		set
		{
			if (this.EquipExploreSkillId == value)
			{
				return;
			}
			this.EquipExploreSkillId = value;
			this.SendExploreToolSwitchLogData(this.EquipExploreSkillId);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Phantom;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "设置新探索技能Id成功";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", this.EquipExploreSkillId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			EventSystem.Instance.Emit(EEventName.OnChangeSelectedExploreId);
		}
	}

	// Token: 0x17001D34 RID: 7476
	// (get) Token: 0x06015C50 RID: 89168 RVA: 0x0057DDD4 File Offset: 0x0057BFD4
	[Nullable(2)]
	public string CurrentExploreSkillIcon
	{
		[NullableContext(2)]
		get
		{
			if (this.EquipExploreSkillId == 0)
			{
				return null;
			}
			if (this.IsEquipItemSelectOn)
			{
				if (this.CurrentEquipItemId == 0)
				{
					return null;
				}
				ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(this.CurrentEquipItemId);
				if (itemConfig == null)
				{
					return null;
				}
				return itemConfig.GetValueOrDefault().Icon;
			}
			else
			{
				ExploreTools exploreTools;
				if (this.UnlockExploreSkillDataMap.TryGetValue(this.EquipExploreSkillId, out exploreTools))
				{
					return exploreTools.BattleViewIcon;
				}
				ExploreTools? exploreConfigById = RouletteConfig.Instance.GetExploreConfigById(this.EquipExploreSkillId);
				if (exploreConfigById == null)
				{
					return null;
				}
				return exploreConfigById.GetValueOrDefault().BattleViewIcon;
			}
		}
	}

	// Token: 0x06015C51 RID: 89169 RVA: 0x0057DE74 File Offset: 0x0057C074
	public unsafe void RecoverEquipExploreSkillId()
	{
		foreach (RouletteListDataBase rouletteListDataBase in this.GetActivatedRouletteList())
		{
			int equipExploreSkillId = rouletteListDataBase.GetEquipExploreSkillId();
			if (equipExploreSkillId != 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Phantom;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "还原当前状态装备探索技能Id";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("启用轮盘类型", rouletteListDataBase.RouletteType);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SkillId", equipExploreSkillId);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				CharacterExploreModel.Instance.SetExploreSkillId(equipExploreSkillId, EExploreSkillLayer.Roulette, "RecoverEquipExploreSkillId");
				RouletteController.Instance.ExploreSkillSetRequest(equipExploreSkillId, null, false);
				break;
			}
		}
	}

	// Token: 0x06015C52 RID: 89170 RVA: 0x0057DF58 File Offset: 0x0057C158
	public ExploreTools? GetExploreDataBySkillId(int skillId)
	{
		ExploreTools value;
		if (this.UnlockExploreSkillDataMap.TryGetValue(skillId, out value))
		{
			return new ExploreTools?(value);
		}
		return null;
	}

	// Token: 0x06015C53 RID: 89171 RVA: 0x0057DF88 File Offset: 0x0057C188
	public void UnlockExploreSkill(int id, bool isNew = true)
	{
		ExploreTools? exploreConfigById = RouletteConfig.Instance.GetExploreConfigById(id);
		if (exploreConfigById != null)
		{
			this.UnlockExploreSkillDataMap[id] = exploreConfigById.Value;
		}
		if (isNew)
		{
			this.TryAddNewItem(id);
			EventSystem.Instance.Emit<int>(EEventName.AddExploreVisionSkill, id);
		}
	}

	// Token: 0x06015C54 RID: 89172 RVA: 0x0057DFDC File Offset: 0x0057C1DC
	public void CreateAllUnlockExploreSkill(List<int> idList)
	{
		this.UnlockExploreSkillDataMap.Clear();
		foreach (int id in idList)
		{
			this.UnlockExploreSkill(id, false);
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Phantom;
		ELogAuthor author = ELogAuthor.YYZ;
		string message = "设置当前解锁的探索技能";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("技能列表", idList);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x06015C55 RID: 89173 RVA: 0x0057E060 File Offset: 0x0057C260
	public FuncMenuWheel? GetFuncDataByFuncId(int id)
	{
		FuncMenuWheel value;
		if (this.UnlockFunctionDataMap.TryGetValue(id, out value))
		{
			return new FuncMenuWheel?(value);
		}
		return null;
	}

	// Token: 0x06015C56 RID: 89174 RVA: 0x0057E090 File Offset: 0x0057C290
	private void InitFunctionData()
	{
		IReadOnlyList<FuncMenuWheel> allFuncConfig = RouletteConfig.Instance.GetAllFuncConfig();
		if (allFuncConfig != null)
		{
			foreach (FuncMenuWheel value in allFuncConfig)
			{
				if (value.UnlockCondition > 0)
				{
					this.FuncOpenIdMap[value.UnlockCondition] = value.FuncId;
				}
				else
				{
					this.UnlockFunctionDataMap[value.FuncId] = value;
				}
			}
		}
	}

	// Token: 0x06015C57 RID: 89175 RVA: 0x0057E118 File Offset: 0x0057C318
	private void OpenFunction(int funcId)
	{
		FuncMenuWheel? funcConfigById = RouletteConfig.Instance.GetFuncConfigById(funcId);
		if (funcConfigById == null)
		{
			return;
		}
		if (!this.UnlockFunctionDataMap.ContainsKey(funcId))
		{
			this.UnlockFunctionDataMap[funcId] = funcConfigById.Value;
		}
	}

	// Token: 0x06015C58 RID: 89176 RVA: 0x0057E15C File Offset: 0x0057C35C
	private void CloseFunction(int funcId)
	{
		this.UnlockFunctionDataMap.Remove(funcId);
	}

	// Token: 0x17001D35 RID: 7477
	// (get) Token: 0x06015C59 RID: 89177 RVA: 0x0057E16B File Offset: 0x0057C36B
	public int CurrentEquipItemId
	{
		get
		{
			return this.RouletteListDataMap[ERouletteType.Explore].GetExtraItemId();
		}
	}

	// Token: 0x17001D36 RID: 7478
	// (get) Token: 0x06015C5A RID: 89178 RVA: 0x0057E17E File Offset: 0x0057C37E
	public bool IsEquipItemSelectOn
	{
		get
		{
			return this.CurrentExploreSkillId == 3001;
		}
	}

	// Token: 0x17001D37 RID: 7479
	// (get) Token: 0x06015C5B RID: 89179 RVA: 0x0057E190 File Offset: 0x0057C390
	public InventoryDefine.EItemType? EquipItemType
	{
		get
		{
			if (this.CurrentEquipItemId == 0)
			{
				return null;
			}
			if (SpecialItemConfig.Instance.GetConfig(this.CurrentEquipItemId) != null)
			{
				return new InventoryDefine.EItemType?(InventoryDefine.EItemType.SpecialItem);
			}
			return new InventoryDefine.EItemType?(InventoryDefine.EItemType.Common);
		}
	}

	// Token: 0x06015C5C RID: 89180 RVA: 0x0057E1D8 File Offset: 0x0057C3D8
	public bool IsExploreSkillHasNumBySkillData(ExploreTools skillData)
	{
		if (skillData.SkillType != 5)
		{
			Dictionary<int, int> dictionary = skillData.Cost();
			return dictionary != null && dictionary.Count > 0;
		}
		TrapDefenseItem? trapDefenseItemByExploreToolId = TrapDefenseConfig.Instance.GetTrapDefenseItemByExploreToolId(skillData.PhantomSkillId);
		if (trapDefenseItemByExploreToolId == null)
		{
			return false;
		}
		TrapDefenseModel instance = TrapDefenseModel.Instance;
		return ((instance != null) ? instance.BattleInventoryData.GetItemData(trapDefenseItemByExploreToolId.Value.Id) : null) != null;
	}

	// Token: 0x06015C5D RID: 89181 RVA: 0x0057E250 File Offset: 0x0057C450
	public int GetExploreSkillShowNumBySkillData(ExploreTools skillData)
	{
		if (skillData.SkillType != 5)
		{
			Dictionary<int, int> dictionary = skillData.Cost();
			if (dictionary != null && dictionary.Count > 0 && dictionary.Count > 0)
			{
				int itemConfigId = 0;
				using (Dictionary<int, int>.KeyCollection.Enumerator enumerator = dictionary.Keys.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						itemConfigId = enumerator.Current;
					}
				}
				return InventoryModel.Instance.GetItemCountByConfigId(itemConfigId, 0);
			}
			return 0;
		}
		else
		{
			TrapDefenseItem? trapDefenseItemByExploreToolId = TrapDefenseConfig.Instance.GetTrapDefenseItemByExploreToolId(skillData.PhantomSkillId);
			if (trapDefenseItemByExploreToolId == null)
			{
				return 0;
			}
			TrapDefenseModel instance = TrapDefenseModel.Instance;
			TrapDefenseBattleItemData trapDefenseBattleItemData = (instance != null) ? instance.BattleInventoryData.GetItemData(trapDefenseItemByExploreToolId.Value.Id) : null;
			if (trapDefenseBattleItemData == null)
			{
				return 0;
			}
			return trapDefenseBattleItemData.InventoryCount;
		}
	}

	// Token: 0x06015C5E RID: 89182 RVA: 0x0057E328 File Offset: 0x0057C528
	public bool IsExploreSkillHasNum()
	{
		if (!this.IsEquipItemSelectOn)
		{
			ExploreTools skillData;
			return this.UnlockExploreSkillDataMap.TryGetValue(this.CurrentExploreSkillId, out skillData) && this.GetExploreSkillShowNumBySkillData(skillData) > 0;
		}
		if (this.CurrentEquipItemId == 0)
		{
			return false;
		}
		if (this.EquipItemType.GetValueOrDefault() == InventoryDefine.EItemType.Common)
		{
			return true;
		}
		SpecialItem? config = SpecialItemConfig.Instance.GetConfig(this.CurrentEquipItemId);
		return config != null && config.GetValueOrDefault().NeedShowNum;
	}

	// Token: 0x06015C5F RID: 89183 RVA: 0x0057E3AC File Offset: 0x0057C5AC
	public int GetExploreSkillShowNum()
	{
		if (this.IsEquipItemSelectOn)
		{
			return InventoryModel.Instance.GetCommonItemCount(this.CurrentEquipItemId, 0);
		}
		ExploreTools skillData;
		if (!this.UnlockExploreSkillDataMap.TryGetValue(this.CurrentExploreSkillId, out skillData))
		{
			return 0;
		}
		return this.GetExploreSkillShowNumBySkillData(skillData);
	}

	// Token: 0x06015C60 RID: 89184 RVA: 0x0057E3F1 File Offset: 0x0057C5F1
	public bool IsExploreSkillHasSetNum(int exploreSkillId)
	{
		return exploreSkillId - 1010 <= 2 || exploreSkillId == 1018;
	}

	// Token: 0x06015C61 RID: 89185 RVA: 0x0057E408 File Offset: 0x0057C608
	[NullableContext(0)]
	public ValueTuple<int, int> GetExploreSkillShowSetNumById(ERouletteExploreId exploreSkillId)
	{
		switch (exploreSkillId)
		{
		case ERouletteExploreId.临时传送:
		{
			int? toolPlaceLimit = MapExploreToolModel.Instance.GetToolPlaceLimit(exploreSkillId);
			return new ValueTuple<int, int>(MapExploreToolModel.Instance.GetToolPlaceNum(exploreSkillId).GetValueOrDefault(), toolPlaceLimit.GetValueOrDefault());
		}
		case ERouletteExploreId.声匣探测:
		{
			int? toolPlaceLimit2 = MapExploreToolModel.Instance.GetToolPlaceLimit(exploreSkillId);
			return new ValueTuple<int, int>(MapExploreToolModel.Instance.GetToolPlaceNum(exploreSkillId).GetValueOrDefault(), toolPlaceLimit2.GetValueOrDefault());
		}
		case ERouletteExploreId.物资探测:
		{
			int? toolPlaceLimit3 = MapExploreToolModel.Instance.GetToolPlaceLimit(exploreSkillId);
			return new ValueTuple<int, int>(MapExploreToolModel.Instance.GetToolPlaceNum(exploreSkillId).GetValueOrDefault(), toolPlaceLimit3.GetValueOrDefault());
		}
		default:
		{
			if (exploreSkillId != ERouletteExploreId.捕鱼诱饵)
			{
				return new ValueTuple<int, int>(0, 0);
			}
			int? num = new int?(FishingModel.Instance.GetTempFishingPointLimit());
			int? num2 = new int?(FishingModel.Instance.GetTempFishingPointNum());
			return new ValueTuple<int, int>(num2.GetValueOrDefault(), num.GetValueOrDefault());
		}
		}
	}

	// Token: 0x06015C62 RID: 89186 RVA: 0x0057E500 File Offset: 0x0057C700
	public bool IsEquipItemInBuffCd()
	{
		return this.IsEquipItemSelectOn && this.CurrentEquipItemId != 0 && BuffItemConfig.Instance.IsBuffItem(this.CurrentEquipItemId) && BuffItemModel.Instance.GetBuffItemRemainCdTime(this.CurrentEquipItemId) - TimeUtil.Instance.TimeDeviation > 0.0;
	}

	// Token: 0x06015C63 RID: 89187 RVA: 0x0057E55B File Offset: 0x0057C75B
	public bool IsEquippedItemBanReqUse()
	{
		return this.IsEquipItemSelectOn && SpecialItemController.Instance.IsSpecialItem(this.CurrentEquipItemId) && !SpecialItemController.Instance.AllowReqUseSpecialItem(this.CurrentEquipItemId);
	}

	// Token: 0x06015C64 RID: 89188 RVA: 0x0057E58E File Offset: 0x0057C78E
	public void SaveNewItemList()
	{
		NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.RouletteAssemblyItemRedDot);
		EventSystem.Instance.Emit(EEventName.RouletteRefreshNew);
	}

	// Token: 0x06015C65 RID: 89189 RVA: 0x0057E5AC File Offset: 0x0057C7AC
	public bool TryAddNewItem(int id)
	{
		if (id == 0)
		{
			return false;
		}
		NewFlagModel.Instance.AddNewFlag(ELocalStoragePlayerKey.RouletteAssemblyItemRedDot, id);
		EventSystem.Instance.Emit(EEventName.RouletteRefreshNew);
		return true;
	}

	// Token: 0x06015C66 RID: 89190 RVA: 0x0057E5D1 File Offset: 0x0057C7D1
	public bool TryRemoveNewItem(int id)
	{
		return id != 0 && NewFlagModel.Instance.RemoveNewFlag(ELocalStoragePlayerKey.RouletteAssemblyItemRedDot, id);
	}

	// Token: 0x06015C67 RID: 89191 RVA: 0x0057E5E4 File Offset: 0x0057C7E4
	public bool CheckHasAnyNewItem()
	{
		foreach (KeyValuePair<int, ExploreTools> keyValuePair in this.UnlockExploreSkillDataMap)
		{
			int key = keyValuePair.Key;
			ExploreTools value = keyValuePair.Value;
			if (value.CanAssemblyShow)
			{
				bool flag = false;
				foreach (int key2 in value.GetRouletteTypeArray())
				{
					RouletteListDataBase rouletteListDataBase;
					if (this.RouletteListDataMap.TryGetValue((ERouletteType)key2, out rouletteListDataBase) && rouletteListDataBase.IsRouletteOpen())
					{
						flag = true;
						break;
					}
				}
				if (flag && NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.RouletteAssemblyItemRedDot, key))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06015C68 RID: 89192 RVA: 0x0057E6AC File Offset: 0x0057C8AC
	public unsafe void UpdateRouletteData(List<ExploreSkillRoulette> exploreList)
	{
		if (exploreList.Count == 0)
		{
			Log.Instance.Info(ELogModule.Phantom, ELogAuthor.YYZ, "当前不存在保存的轮盘数据", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		for (int i = 0; i < exploreList.Count; i++)
		{
			RouletteListDataBase rouletteListDataBase;
			if (this.RouletteListDataMap.TryGetValue((ERouletteType)i, out rouletteListDataBase))
			{
				rouletteListDataBase.UpdateData(exploreList[i]);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Phantom;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "轮盘列表数据";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Type", i);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("List", rouletteListDataBase.RouletteIdListServer);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ItemId", rouletteListDataBase.ExtraItemIdServer);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("EquipId", rouletteListDataBase.EquipExploreSkillIdServer);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			}
		}
		EventSystem.Instance.Emit(EEventName.OnRouletteSaveDataChange);
		this.TryEquipActivateRouletteExploreSkillId();
	}

	// Token: 0x06015C69 RID: 89193 RVA: 0x0057E7CC File Offset: 0x0057C9CC
	public unsafe void UpdateRouletteDataByType(int type, ExploreSkillRoulette rouletteDataList)
	{
		RouletteListDataBase rouletteListDataBase;
		if (this.RouletteListDataMap.TryGetValue((ERouletteType)type, out rouletteListDataBase))
		{
			rouletteListDataBase.UpdateData(rouletteDataList);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Phantom;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "轮盘列表数据";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Type", type);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("List", rouletteListDataBase.RouletteIdListServer);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ItemId", rouletteListDataBase.ExtraItemIdServer);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("EquipId", rouletteListDataBase.EquipExploreSkillIdServer);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			if (this.GetCurrentExploreRouletteListData().RouletteType == (ERouletteType)type)
			{
				RouletteController.RefreshExploreSkillButton();
			}
		}
		EventSystem.Instance.Emit(EEventName.OnRouletteSaveDataChange);
		this.TryEquipActivateRouletteExploreSkillId();
	}

	// Token: 0x06015C6A RID: 89194 RVA: 0x0057E8C0 File Offset: 0x0057CAC0
	private unsafe void TryEquipActivateRouletteExploreSkillId()
	{
		RouletteListDataBase currentExploreRouletteListData = this.GetCurrentExploreRouletteListData();
		int equipExploreSkillId = currentExploreRouletteListData.GetEquipExploreSkillId();
		if (equipExploreSkillId == 0)
		{
			return;
		}
		if (equipExploreSkillId == this.CurrentExploreSkillId)
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Phantom;
		ELogAuthor author = ELogAuthor.YYZ;
		string message = "TryEquipActivateRoulette";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Type", currentExploreRouletteListData.RouletteType);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EquipId", equipExploreSkillId);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		CharacterExploreModel.Instance.SetExploreSkillId(equipExploreSkillId, EExploreSkillLayer.Roulette, "TryEquipActivateRouletteExploreSkillId");
		RouletteController.Instance.ExploreSkillSetRequest(equipExploreSkillId, null, true);
	}

	// Token: 0x06015C6B RID: 89195 RVA: 0x0057E96C File Offset: 0x0057CB6C
	public string GetRouletteKeyRichText(string actionName)
	{
		string result = "";
		this.InputKeyDisplayDataRef.Reset();
		if (!InputSettingsManager.Instance.GetActionKeyDisplayData(this.InputKeyDisplayDataRef, actionName))
		{
			return result;
		}
		string[] displayKeyIconPathList = this.InputKeyDisplayDataRef.GetDisplayKeyIconPathList(0);
		if (displayKeyIconPathList == null || displayKeyIconPathList.Length == 0)
		{
			return result;
		}
		return "<texture=" + displayKeyIconPathList[0] + ">";
	}

	// Token: 0x06015C6C RID: 89196 RVA: 0x0057E9C9 File Offset: 0x0057CBC9
	public string GetRouletteMainAction(string actionName)
	{
		if (!InputSettingsManager.Instance.GetActionKeyDisplayData(this.InputKeyDisplayDataRef, actionName))
		{
			return actionName;
		}
		if (this.InputKeyDisplayDataRef.IsCombination)
		{
			return "组合主键";
		}
		return actionName;
	}

	// Token: 0x06015C6D RID: 89197 RVA: 0x0057E9F4 File Offset: 0x0057CBF4
	public int GetRouletteSelectConfig()
	{
		return LocalStorage.GetGlobal<int?>(ELocalStorageGlobalKey.GamepadRouletteSelectConfig, null).GetValueOrDefault(1);
	}

	// Token: 0x06015C6E RID: 89198 RVA: 0x0057EA1A File Offset: 0x0057CC1A
	public void SaveRouletteSelectConfig(int config)
	{
		LocalStorage.SetGlobal<int>(ELocalStorageGlobalKey.GamepadRouletteSelectConfig, config);
	}

	// Token: 0x06015C6F RID: 89199 RVA: 0x0057EA28 File Offset: 0x0057CC28
	public ERouletteType GetRouletteActionOpenConfig(ERouletteActionType actionType)
	{
		ERouletteType erouletteType = (actionType == ERouletteActionType.Action1) ? ERouletteType.Explore : ERouletteType.Function;
		if (!Info.Instance.IsInGamepad())
		{
			return erouletteType;
		}
		return LocalStorage.GetPlayer<ERouletteType?>((actionType == ERouletteActionType.Action1) ? ELocalStoragePlayerKey.RouletteAction01OpenConfig : ELocalStoragePlayerKey.RouletteAction02OpenConfig, null).GetValueOrDefault(erouletteType);
	}

	// Token: 0x06015C70 RID: 89200 RVA: 0x0057EA6D File Offset: 0x0057CC6D
	public void SaveRouletteActionOpenConfig(ERouletteActionType actionType, ERouletteType type)
	{
		LocalStorage.SetPlayer<ERouletteType>((actionType == ERouletteActionType.Action1) ? ELocalStoragePlayerKey.RouletteAction01OpenConfig : ELocalStoragePlayerKey.RouletteAction02OpenConfig, type);
	}

	// Token: 0x06015C71 RID: 89201 RVA: 0x0057EA80 File Offset: 0x0057CC80
	private void SendExploreToolSwitchLogData(int id)
	{
		ExploreToolSwitchLogData exploreToolSwitchLogData = new ExploreToolSwitchLogData();
		ExploreTools? exploreConfigById = RouletteConfig.Instance.GetExploreConfigById(id);
		if (exploreConfigById == null)
		{
			return;
		}
		List<ExploreToolAuthorizationLogData> list = new List<ExploreToolAuthorizationLogData>();
		foreach (KeyValuePair<int, int> keyValuePair in exploreConfigById.Value.Authorization())
		{
			int key = keyValuePair.Key;
			int value = keyValuePair.Value;
			if (InventoryModel.Instance.GetItemCountByConfigId(value, 0) > 0)
			{
				ExploreToolAuthorizationLogData item = new ExploreToolAuthorizationLogData(key, value);
				list.Add(item);
			}
		}
		exploreToolSwitchLogData.o_new_authorization = list;
		exploreToolSwitchLogData.i_explore_tool_id = id;
		LogReportController.Instance.LogReport(exploreToolSwitchLogData);
	}

	// Token: 0x06015C72 RID: 89202 RVA: 0x0057EB48 File Offset: 0x0057CD48
	public void SendExploreToolEquipLogData(int id, int operationType, int rouletteType, int? itemId = null)
	{
		ExploreToolEquipLogData exploreToolEquipLogData = new ExploreToolEquipLogData();
		ExploreTools? exploreConfigById = RouletteConfig.Instance.GetExploreConfigById(id);
		if (exploreConfigById == null)
		{
			return;
		}
		List<ExploreToolAuthorizationLogData> list = new List<ExploreToolAuthorizationLogData>();
		foreach (KeyValuePair<int, int> keyValuePair in exploreConfigById.Value.Authorization())
		{
			int key = keyValuePair.Key;
			int value = keyValuePair.Value;
			if (InventoryModel.Instance.GetItemCountByConfigId(value, 0) > 0)
			{
				ExploreToolAuthorizationLogData item = new ExploreToolAuthorizationLogData(key, value);
				list.Add(item);
			}
		}
		exploreToolEquipLogData.o_new_authorization = list;
		exploreToolEquipLogData.i_explore_tool_id = id;
		exploreToolEquipLogData.i_operation = operationType;
		exploreToolEquipLogData.i_roulette_id = rouletteType;
		if (itemId != null)
		{
			exploreToolEquipLogData.i_item_id = itemId.Value;
		}
		LogReportController.Instance.LogReport(exploreToolEquipLogData);
	}

	// Token: 0x06015C73 RID: 89203 RVA: 0x0057EC34 File Offset: 0x0057CE34
	public void SendExploreToolItemUseLogData(int id)
	{
		ExploreToolItemUseLogData exploreToolItemUseLogData = new ExploreToolItemUseLogData();
		global::Vector actorLocationProxy = Global.BaseCharacter.CharacterActorComponent.ActorLocationProxy;
		exploreToolItemUseLogData.i_area_id = AreaModel.Instance.AreaInfo.Value.AreaId;
		exploreToolItemUseLogData.i_father_area_id = AreaModel.Instance.AreaInfo.Value.Father;
		exploreToolItemUseLogData.f_pos_x = (float)actorLocationProxy.X;
		exploreToolItemUseLogData.f_pos_y = (float)actorLocationProxy.Y;
		exploreToolItemUseLogData.f_pos_z = (float)actorLocationProxy.Z;
		exploreToolItemUseLogData.i_item_id = id;
		LogReportController.Instance.LogReport(exploreToolItemUseLogData);
	}

	// Token: 0x06015C74 RID: 89204 RVA: 0x0057ECD0 File Offset: 0x0057CED0
	public void TrySendExploreToolGeneralUseLogData(int exploreSkillId, int skillId = 0, int entityConfigId = 0)
	{
		ExploreTools? exploreConfigById = RouletteConfig.Instance.GetExploreConfigById(exploreSkillId);
		if (exploreConfigById == null || !exploreConfigById.Value.InputLogReport)
		{
			return;
		}
		string text = "1026_" + exploreSkillId.ToString();
		ExploreToolGeneralUseLogData exploreToolGeneralUseLogData = new ExploreToolGeneralUseLogData();
		global::Vector actorLocationProxy = Global.BaseCharacter.CharacterActorComponent.ActorLocationProxy;
		exploreToolGeneralUseLogData.event_id = text;
		exploreToolGeneralUseLogData.i_area_id = AreaModel.Instance.AreaInfo.Value.AreaId;
		exploreToolGeneralUseLogData.i_father_area_id = AreaModel.Instance.AreaInfo.Value.Father;
		exploreToolGeneralUseLogData.f_pos_x = (float)actorLocationProxy.X;
		exploreToolGeneralUseLogData.f_pos_y = (float)actorLocationProxy.Y;
		exploreToolGeneralUseLogData.f_pos_z = (float)actorLocationProxy.Z;
		exploreToolGeneralUseLogData.i_skill_id = skillId;
		exploreToolGeneralUseLogData.i_entity_configId = entityConfigId;
		if (LogReportModel.Instance.GetTimerAssemblyLogData(text) == null)
		{
			LogReportModel.Instance.SetTimerAssemblyLogData(text, new ExploreToolAssemblyLogData(exploreSkillId.ToString()));
		}
		LogReportController.Instance.UnitLogReport(exploreToolGeneralUseLogData);
	}

	// Token: 0x17001D38 RID: 7480
	// (get) Token: 0x06015C75 RID: 89205 RVA: 0x0057EDDC File Offset: 0x0057CFDC
	public static RouletteModel Instance
	{
		get
		{
			return RouletteModel._Instance;
		}
	}

	// Token: 0x06015C76 RID: 89206 RVA: 0x0057EDE3 File Offset: 0x0057CFE3
	public static RouletteModel GetOrCreateInstance()
	{
		if (RouletteModel._Instance == null)
		{
			RouletteModel.CreateInstance();
		}
		return RouletteModel._Instance;
	}

	// Token: 0x06015C77 RID: 89207 RVA: 0x0057EDF7 File Offset: 0x0057CFF7
	public static bool CreateInstance()
	{
		if (RouletteModel._Instance != null)
		{
			return true;
		}
		RouletteModel._Instance = new RouletteModel();
		return true;
	}

	// Token: 0x06015C78 RID: 89208 RVA: 0x0057EE0D File Offset: 0x0057D00D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06015C79 RID: 89209 RVA: 0x0057EE0F File Offset: 0x0057D00F
	public static void ResetStaticDefaultValue()
	{
		RouletteModel._Instance = null;
	}

	// Token: 0x06015C7A RID: 89210 RVA: 0x0057EE17 File Offset: 0x0057D017
	static RouletteModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RouletteModel.CreateStaticDefaultValue), new Action(RouletteModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400A230 RID: 41520
	public Dictionary<ERouletteType, RouletteListDataBase> RouletteListDataMap = new Dictionary<ERouletteType, RouletteListDataBase>();

	// Token: 0x0400A231 RID: 41521
	private int EquipExploreSkillId;

	// Token: 0x0400A232 RID: 41522
	public List<int> OnSettingExploreSkillIdList = new List<int>();

	// Token: 0x0400A233 RID: 41523
	public Dictionary<int, ExploreTools> UnlockExploreSkillDataMap = new Dictionary<int, ExploreTools>();

	// Token: 0x0400A234 RID: 41524
	private readonly Dictionary<int, int> FuncOpenIdMap = new Dictionary<int, int>();

	// Token: 0x0400A235 RID: 41525
	public Dictionary<int, FuncMenuWheel> UnlockFunctionDataMap = new Dictionary<int, FuncMenuWheel>();

	// Token: 0x0400A236 RID: 41526
	private readonly Action<EFunctionType, bool> UnlockFunction1 = delegate(EFunctionType funcOpenId, bool isOpen)
	{
		int funcId;
		if (RouletteModel.Instance.FuncOpenIdMap.TryGetValue((int)funcOpenId, out funcId))
		{
			if (isOpen)
			{
				RouletteModel.Instance.OpenFunction(funcId);
				return;
			}
			RouletteModel.Instance.CloseFunction(funcId);
		}
	};

	// Token: 0x0400A237 RID: 41527
	private readonly Action<EFunctionType, bool> UnlockFunction2 = delegate(EFunctionType funcOpenId, bool isOpen)
	{
		int funcId;
		if (RouletteModel.Instance.FuncOpenIdMap.TryGetValue((int)funcOpenId, out funcId))
		{
			if (isOpen)
			{
				RouletteModel.Instance.OpenFunction(funcId);
				return;
			}
			RouletteModel.Instance.CloseFunction(funcId);
		}
	};

	// Token: 0x0400A238 RID: 41528
	private readonly InputKeyDisplayData InputKeyDisplayDataRef = new InputKeyDisplayData();

	// Token: 0x0400A239 RID: 41529
	public readonly Dictionary<ERouletteActionType, string> GetRouletteActionName = new Dictionary<ERouletteActionType, string>
	{
		{
			ERouletteActionType.Action1,
			"幻象探索选择界面"
		},
		{
			ERouletteActionType.Action2,
			"轮盘2"
		}
	};

	// Token: 0x0400A23A RID: 41530
	[Nullable(2)]
	private static RouletteModel _Instance;
}
