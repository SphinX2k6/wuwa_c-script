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

// Token: 0x02001EB2 RID: 7858
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class RouletteModel : ModelBase
{
	// Token: 0x06013647 RID: 79431 RVA: 0x005A8A24 File Offset: 0x005A6C24
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

	// Token: 0x06013648 RID: 79432 RVA: 0x005A8AB5 File Offset: 0x005A6CB5
	public bool IsFunctionRouletteOpen()
	{
		return FunctionModel.Instance.IsOpen(10056);
	}

	// Token: 0x06013649 RID: 79433 RVA: 0x005A8AC6 File Offset: 0x005A6CC6
	protected override bool OnInit()
	{
		this.InitAllRouletteListData();
		this.InitFunctionData();
		this.AddEvents();
		this.OnSettingExploreSkillIdList.Clear();
		return true;
	}

	// Token: 0x0601364A RID: 79434 RVA: 0x005A8AE6 File Offset: 0x005A6CE6
	protected override bool OnClear()
	{
		this.ClearAllRouletteListData();
		this.RemoveEvents();
		return true;
	}

	// Token: 0x0601364B RID: 79435 RVA: 0x005A8AF8 File Offset: 0x005A6CF8
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

	// Token: 0x0601364C RID: 79436 RVA: 0x005A8B9D File Offset: 0x005A6D9D
	protected void AddEvents()
	{
		EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenSet, this.UnlockFunction1);
		EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, this.UnlockFunction2);
	}

	// Token: 0x0601364D RID: 79437 RVA: 0x005A8BCB File Offset: 0x005A6DCB
	protected void RemoveEvents()
	{
		EventSystem.Instance.Remove<EFunctionType, bool>(EEventName.OnFunctionOpenSet, this.UnlockFunction1);
		EventSystem.Instance.Remove<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, this.UnlockFunction2);
	}

	// Token: 0x0601364E RID: 79438 RVA: 0x005A8BFC File Offset: 0x005A6DFC
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

	// Token: 0x0601364F RID: 79439 RVA: 0x005A8C88 File Offset: 0x005A6E88
	public RouletteListDataBase GetCurrentExploreRouletteListData()
	{
		return this.GetActivatedRouletteList()[0];
	}

	// Token: 0x06013650 RID: 79440 RVA: 0x005A8C96 File Offset: 0x005A6E96
	public RouletteListDataBase GetCurrentFunctionRouletteListData()
	{
		return this.RouletteListDataMap[ERouletteType.Function];
	}

	// Token: 0x06013651 RID: 79441 RVA: 0x005A8CA4 File Offset: 0x005A6EA4
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

	// Token: 0x06013652 RID: 79442 RVA: 0x005A8D40 File Offset: 0x005A6F40
	private void ClearAllRouletteListData()
	{
		foreach (RouletteListDataBase rouletteListDataBase in this.RouletteListDataMap.Values)
		{
			rouletteListDataBase.Clear();
		}
		this.RouletteListDataMap.Clear();
	}

	// Token: 0x17001D8D RID: 7565
	// (get) Token: 0x06013653 RID: 79443 RVA: 0x005A8DA0 File Offset: 0x005A6FA0
	// (set) Token: 0x06013654 RID: 79444 RVA: 0x005A8DA8 File Offset: 0x005A6FA8
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

	// Token: 0x17001D8E RID: 7566
	// (get) Token: 0x06013655 RID: 79445 RVA: 0x005A8E14 File Offset: 0x005A7014
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

	// Token: 0x06013656 RID: 79446 RVA: 0x005A8EB4 File Offset: 0x005A70B4
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

	// Token: 0x06013657 RID: 79447 RVA: 0x005A8F98 File Offset: 0x005A7198
	public ExploreTools? GetExploreDataBySkillId(int skillId)
	{
		ExploreTools value;
		if (this.UnlockExploreSkillDataMap.TryGetValue(skillId, out value))
		{
			return new ExploreTools?(value);
		}
		return null;
	}

	// Token: 0x06013658 RID: 79448 RVA: 0x005A8FC8 File Offset: 0x005A71C8
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

	// Token: 0x06013659 RID: 79449 RVA: 0x005A901C File Offset: 0x005A721C
	public void CreateAllUnlockExploreSkill(IEnumerable<int> idList)
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

	// Token: 0x0601365A RID: 79450 RVA: 0x005A9098 File Offset: 0x005A7298
	public FuncMenuWheel? GetFuncDataByFuncId(int id)
	{
		FuncMenuWheel value;
		if (this.UnlockFunctionDataMap.TryGetValue(id, out value))
		{
			return new FuncMenuWheel?(value);
		}
		return null;
	}

	// Token: 0x0601365B RID: 79451 RVA: 0x005A90C8 File Offset: 0x005A72C8
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

	// Token: 0x0601365C RID: 79452 RVA: 0x005A9150 File Offset: 0x005A7350
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

	// Token: 0x0601365D RID: 79453 RVA: 0x005A9194 File Offset: 0x005A7394
	private void CloseFunction(int funcId)
	{
		this.UnlockFunctionDataMap.Remove(funcId);
	}

	// Token: 0x17001D8F RID: 7567
	// (get) Token: 0x0601365E RID: 79454 RVA: 0x005A91A3 File Offset: 0x005A73A3
	public int CurrentEquipItemId
	{
		get
		{
			return this.RouletteListDataMap[ERouletteType.Explore].GetExtraItemId();
		}
	}

	// Token: 0x17001D90 RID: 7568
	// (get) Token: 0x0601365F RID: 79455 RVA: 0x005A91B6 File Offset: 0x005A73B6
	public bool IsEquipItemSelectOn
	{
		get
		{
			return this.CurrentExploreSkillId == 3001;
		}
	}

	// Token: 0x17001D91 RID: 7569
	// (get) Token: 0x06013660 RID: 79456 RVA: 0x005A91C8 File Offset: 0x005A73C8
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

	// Token: 0x06013661 RID: 79457 RVA: 0x005A9210 File Offset: 0x005A7410
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

	// Token: 0x06013662 RID: 79458 RVA: 0x005A9288 File Offset: 0x005A7488
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

	// Token: 0x06013663 RID: 79459 RVA: 0x005A9360 File Offset: 0x005A7560
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

	// Token: 0x06013664 RID: 79460 RVA: 0x005A93E4 File Offset: 0x005A75E4
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

	// Token: 0x06013665 RID: 79461 RVA: 0x005A9429 File Offset: 0x005A7629
	public bool IsExploreSkillHasSetNum(int exploreSkillId)
	{
		return exploreSkillId - 1010 <= 2 || exploreSkillId == 1018;
	}

	// Token: 0x06013666 RID: 79462 RVA: 0x005A9440 File Offset: 0x005A7640
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

	// Token: 0x06013667 RID: 79463 RVA: 0x005A9538 File Offset: 0x005A7738
	public bool IsEquipItemInBuffCd()
	{
		return this.IsEquipItemSelectOn && this.CurrentEquipItemId != 0 && BuffItemConfig.Instance.IsBuffItem(this.CurrentEquipItemId) && BuffItemModel.Instance.GetBuffItemRemainCdTime(this.CurrentEquipItemId) - TimeUtil.Instance.TimeDeviation > 0.0;
	}

	// Token: 0x06013668 RID: 79464 RVA: 0x005A9593 File Offset: 0x005A7793
	public bool IsEquippedItemBanReqUse()
	{
		return this.IsEquipItemSelectOn && SpecialItemController.Instance.IsSpecialItem(this.CurrentEquipItemId) && !SpecialItemController.Instance.AllowReqUseSpecialItem(this.CurrentEquipItemId);
	}

	// Token: 0x06013669 RID: 79465 RVA: 0x005A95C6 File Offset: 0x005A77C6
	public void SaveNewItemList()
	{
		NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.RouletteAssemblyItemRedDot);
		EventSystem.Instance.Emit(EEventName.RouletteRefreshNew);
	}

	// Token: 0x0601366A RID: 79466 RVA: 0x005A95E4 File Offset: 0x005A77E4
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

	// Token: 0x0601366B RID: 79467 RVA: 0x005A9609 File Offset: 0x005A7809
	public bool TryRemoveNewItem(int id)
	{
		return id != 0 && NewFlagModel.Instance.RemoveNewFlag(ELocalStoragePlayerKey.RouletteAssemblyItemRedDot, id);
	}

	// Token: 0x0601366C RID: 79468 RVA: 0x005A961C File Offset: 0x005A781C
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

	// Token: 0x0601366D RID: 79469 RVA: 0x005A96E4 File Offset: 0x005A78E4
	public unsafe void UpdateRouletteData(IReadOnlyList<ExploreSkillRoulette> exploreList)
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

	// Token: 0x0601366E RID: 79470 RVA: 0x005A9804 File Offset: 0x005A7A04
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

	// Token: 0x0601366F RID: 79471 RVA: 0x005A98F8 File Offset: 0x005A7AF8
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

	// Token: 0x06013670 RID: 79472 RVA: 0x005A99A4 File Offset: 0x005A7BA4
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

	// Token: 0x06013671 RID: 79473 RVA: 0x005A9A01 File Offset: 0x005A7C01
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

	// Token: 0x06013672 RID: 79474 RVA: 0x005A9A2C File Offset: 0x005A7C2C
	public int GetRouletteSelectConfig()
	{
		return LocalStorage.GetGlobal<int?>(ELocalStorageGlobalKey.GamepadRouletteSelectConfig, null).GetValueOrDefault(1);
	}

	// Token: 0x06013673 RID: 79475 RVA: 0x005A9A52 File Offset: 0x005A7C52
	public void SaveRouletteSelectConfig(int config)
	{
		LocalStorage.SetGlobal<int>(ELocalStorageGlobalKey.GamepadRouletteSelectConfig, config);
	}

	// Token: 0x06013674 RID: 79476 RVA: 0x005A9A60 File Offset: 0x005A7C60
	public ERouletteType GetRouletteActionOpenConfig(ERouletteActionType actionType)
	{
		ERouletteType erouletteType = (actionType == ERouletteActionType.Action1) ? ERouletteType.Explore : ERouletteType.Function;
		if (!Info.Instance.IsInGamepad())
		{
			return erouletteType;
		}
		return LocalStorage.GetPlayer<ERouletteType?>((actionType == ERouletteActionType.Action1) ? ELocalStoragePlayerKey.RouletteAction01OpenConfig : ELocalStoragePlayerKey.RouletteAction02OpenConfig, null).GetValueOrDefault(erouletteType);
	}

	// Token: 0x06013675 RID: 79477 RVA: 0x005A9AA5 File Offset: 0x005A7CA5
	public void SaveRouletteActionOpenConfig(ERouletteActionType actionType, ERouletteType type)
	{
		LocalStorage.SetPlayer<ERouletteType>((actionType == ERouletteActionType.Action1) ? ELocalStoragePlayerKey.RouletteAction01OpenConfig : ELocalStoragePlayerKey.RouletteAction02OpenConfig, type);
	}

	// Token: 0x06013676 RID: 79478 RVA: 0x005A9AB8 File Offset: 0x005A7CB8
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

	// Token: 0x06013677 RID: 79479 RVA: 0x005A9B80 File Offset: 0x005A7D80
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

	// Token: 0x06013678 RID: 79480 RVA: 0x005A9C6C File Offset: 0x005A7E6C
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

	// Token: 0x06013679 RID: 79481 RVA: 0x005A9D08 File Offset: 0x005A7F08
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

	// Token: 0x17001D92 RID: 7570
	// (get) Token: 0x0601367A RID: 79482 RVA: 0x005A9E14 File Offset: 0x005A8014
	public static RouletteModel Instance
	{
		get
		{
			return RouletteModel._Instance;
		}
	}

	// Token: 0x0601367B RID: 79483 RVA: 0x005A9E1B File Offset: 0x005A801B
	public static RouletteModel GetOrCreateInstance()
	{
		if (RouletteModel._Instance == null)
		{
			RouletteModel.CreateInstance();
		}
		return RouletteModel._Instance;
	}

	// Token: 0x0601367C RID: 79484 RVA: 0x005A9E2F File Offset: 0x005A802F
	public static bool CreateInstance()
	{
		if (RouletteModel._Instance != null)
		{
			return true;
		}
		RouletteModel._Instance = new RouletteModel();
		return true;
	}

	// Token: 0x0601367D RID: 79485 RVA: 0x005A9E45 File Offset: 0x005A8045
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601367E RID: 79486 RVA: 0x005A9E47 File Offset: 0x005A8047
	public static void ResetStaticDefaultValue()
	{
		RouletteModel._Instance = null;
	}

	// Token: 0x0601367F RID: 79487 RVA: 0x005A9E4F File Offset: 0x005A804F
	static RouletteModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RouletteModel.CreateStaticDefaultValue), new Action(RouletteModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400A61B RID: 42523
	public Dictionary<ERouletteType, RouletteListDataBase> RouletteListDataMap = new Dictionary<ERouletteType, RouletteListDataBase>();

	// Token: 0x0400A61C RID: 42524
	private int EquipExploreSkillId;

	// Token: 0x0400A61D RID: 42525
	public List<int> OnSettingExploreSkillIdList = new List<int>();

	// Token: 0x0400A61E RID: 42526
	public Dictionary<int, ExploreTools> UnlockExploreSkillDataMap = new Dictionary<int, ExploreTools>();

	// Token: 0x0400A61F RID: 42527
	private readonly Dictionary<int, int> FuncOpenIdMap = new Dictionary<int, int>();

	// Token: 0x0400A620 RID: 42528
	public Dictionary<int, FuncMenuWheel> UnlockFunctionDataMap = new Dictionary<int, FuncMenuWheel>();

	// Token: 0x0400A621 RID: 42529
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

	// Token: 0x0400A622 RID: 42530
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

	// Token: 0x0400A623 RID: 42531
	private readonly InputKeyDisplayData InputKeyDisplayDataRef = new InputKeyDisplayData();

	// Token: 0x0400A624 RID: 42532
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

	// Token: 0x0400A625 RID: 42533
	[Nullable(2)]
	private static RouletteModel _Instance;
}
