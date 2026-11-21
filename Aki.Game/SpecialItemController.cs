using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;
using CSharpScript.Game.Ui;

// Token: 0x020014F1 RID: 5361
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class SpecialItemController : UiControllerBase
{
	// Token: 0x0600D635 RID: 54837 RVA: 0x003F87F0 File Offset: 0x003F69F0
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnItemUse, new Action<int, int>(this.OnItemUse));
		EventSystem.Instance.Add<int, int>(EEventName.OnSpecialItemUse, new Action<int, int>(this.OnSpecialItemUse));
		EventSystem.Instance.Add<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemNotify, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddSpecialItem));
		EventSystem.Instance.Add<int?>(EEventName.OnSpecialItemUpdate, new Action<int?>(this.OnSpecialItemUpdate));
		EventSystem.Instance.Add<int, bool>(EEventName.EquipAndSwitchSpecialItem, new Action<int, bool>(this.EquipAndSwitchSpecialItem));
		EventSystem.Instance.Add<int>(EEventName.UnEquipSpecialItem, new Action<int>(this.OnUnEquipSpecialItem));
		EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		EventSystem.Instance.Add(EEventName.ChangeModeFinish, this.OnChangeModeFinish);
	}

	// Token: 0x0600D636 RID: 54838 RVA: 0x003F88D8 File Offset: 0x003F6AD8
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnItemUse, new Action<int, int>(this.OnItemUse));
		EventSystem.Instance.Remove(EEventName.OnSpecialItemUse, new Action<int, int>(this.OnSpecialItemUse));
		EventSystem.Instance.Remove(EEventName.OnAddCommonItemNotify, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddSpecialItem));
		EventSystem.Instance.Remove(EEventName.OnSpecialItemUpdate, new Action<int?>(this.OnSpecialItemUpdate));
		EventSystem.Instance.Remove(EEventName.EquipAndSwitchSpecialItem, new Action<int, bool>(this.EquipAndSwitchSpecialItem));
		EventSystem.Instance.Remove(EEventName.UnEquipSpecialItem, new Action<int>(this.OnUnEquipSpecialItem));
		EventSystem.Instance.Remove(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		EventSystem.Instance.Remove(EEventName.ChangeModeFinish, this.OnChangeModeFinish);
	}

	// Token: 0x0600D637 RID: 54839 RVA: 0x003F89BF File Offset: 0x003F6BBF
	protected override bool OnInit()
	{
		base.PauseTick();
		return true;
	}

	// Token: 0x0600D638 RID: 54840 RVA: 0x003F89C8 File Offset: 0x003F6BC8
	protected override void OnTick(float delta)
	{
		base.PauseTick();
		this.RefreshSpecialItemAllowReqUse();
	}

	// Token: 0x0600D639 RID: 54841 RVA: 0x003F89D8 File Offset: 0x003F6BD8
	[NullableContext(2)]
	private void RecordToRefreshSpecialItemAllowReqUse(int configId, EntityHandle entityHandle)
	{
		foreach (ValueTuple<int, EntityHandle> valueTuple in this.RecordListForRefreshSpecialItemAllowReqUse)
		{
			if (valueTuple.Item1 == configId && object.Equals(valueTuple.Item2, entityHandle))
			{
				return;
			}
		}
		this.RecordListForRefreshSpecialItemAllowReqUse.Add(new ValueTuple<int, EntityHandle>(configId, entityHandle));
		base.ResumeTick();
	}

	// Token: 0x0600D63A RID: 54842 RVA: 0x003F8A58 File Offset: 0x003F6C58
	private unsafe void RefreshSpecialItemAllowReqUse()
	{
		if (this.RecordListForRefreshSpecialItemAllowReqUse.Count == 0)
		{
			return;
		}
		if (this.RecordListForRefreshSpecialItemAllowReqUse.Count > 4)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Item;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "RefreshSpecialItemAllowReqUse单Tick派发次数过多，可能存在性能问题";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Count", this.RecordListForRefreshSpecialItemAllowReqUse.Count);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("List", this.RecordListForRefreshSpecialItemAllowReqUse);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		List<ValueTuple<int, EntityHandle>> recordListForRefreshSpecialItemAllowReqUse = this.RecordListForRefreshSpecialItemAllowReqUse;
		this.RecordListForRefreshSpecialItemAllowReqUse = new List<ValueTuple<int, EntityHandle>>();
		foreach (ValueTuple<int, EntityHandle> valueTuple in recordListForRefreshSpecialItemAllowReqUse)
		{
			int item = valueTuple.Item1;
			EntityHandle item2 = valueTuple.Item2;
			EventSystem.Instance.Emit<int, EntityHandle>(EEventName.OnRefreshSpecialItemAllowReqUse, item, item2);
		}
	}

	// Token: 0x0600D63B RID: 54843 RVA: 0x003F8B50 File Offset: 0x003F6D50
	private void OnSpecialItemUpdate(int? configId)
	{
		if (configId == null)
		{
			this.StopListenSpecialItemRelatedTags();
			return;
		}
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		this.ListenSpecialItemRelatedTags(configId.Value, getCurrentEntity);
	}

	// Token: 0x0600D63C RID: 54844 RVA: 0x003F8B88 File Offset: 0x003F6D88
	public bool IsSpecialItem(int configId)
	{
		if (configId == 0)
		{
			return false;
		}
		ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(configId);
		return itemConfig != null && itemConfig.GetValueOrDefault().SpecialItem;
	}

	// Token: 0x0600D63D RID: 54845 RVA: 0x003F8BC8 File Offset: 0x003F6DC8
	public bool AllowReqUseSpecialItem(int configId)
	{
		SpecialItem? config = SpecialItemConfig.Instance.GetConfig(configId);
		if (config == null)
		{
			return false;
		}
		if (!config.Value.UseInstance && GameModeController.Instance.IsInInstance())
		{
			return false;
		}
		if (!config.Value.UseInMultiMode && GameModeModel.Instance.IsMulti)
		{
			return false;
		}
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		BaseTagComponent baseTagComponent;
		if (getCurrentEntity == null)
		{
			baseTagComponent = null;
		}
		else
		{
			WorldEntity entity = getCurrentEntity.Entity;
			baseTagComponent = ((entity != null) ? entity.GetComponent<BaseTagComponent>() : null);
		}
		BaseTagComponent baseTagComponent2 = baseTagComponent;
		if (baseTagComponent2 == null)
		{
			return config.Value.AllowTags().Length == 0;
		}
		string[] array = config.Value.AllowTags();
		for (int i = 0; i < array.Length; i++)
		{
			int tagIdByName = GameplayTagUtils.GetTagIdByName(array[i]);
			if (!baseTagComponent2.HasTag(tagIdByName))
			{
				return false;
			}
		}
		array = config.Value.BanTags();
		for (int i = 0; i < array.Length; i++)
		{
			int tagIdByName2 = GameplayTagUtils.GetTagIdByName(array[i]);
			if (baseTagComponent2.HasTag(tagIdByName2))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600D63E RID: 54846 RVA: 0x003F8CD8 File Offset: 0x003F6ED8
	private void OnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
		int? tagWatchedItemId = SpecialItemModel.Instance.TagWatchedItemId;
		if (tagWatchedItemId != null)
		{
			int? num = tagWatchedItemId;
			int num2 = 0;
			if (!(num.GetValueOrDefault() == num2 & num != null))
			{
				this.StopListenSpecialItemRelatedTags();
				this.ListenSpecialItemRelatedTags(tagWatchedItemId.Value, newEntity);
				this.RecordToRefreshSpecialItemAllowReqUse(tagWatchedItemId.Value, newEntity);
				return;
			}
		}
	}

	// Token: 0x0600D63F RID: 54847 RVA: 0x003F8D34 File Offset: 0x003F6F34
	[NullableContext(2)]
	public void ListenSpecialItemRelatedTags(int configId, EntityHandle entityHandle)
	{
		if (!this.IsSpecialItem(configId))
		{
			return;
		}
		SpecialItem? config = SpecialItemConfig.Instance.GetConfig(configId);
		if (config == null)
		{
			return;
		}
		BaseTagComponent baseTagComponent;
		if (entityHandle == null)
		{
			baseTagComponent = null;
		}
		else
		{
			WorldEntity entity = entityHandle.Entity;
			baseTagComponent = ((entity != null) ? entity.GetComponent<BaseTagComponent>() : null);
		}
		BaseTagComponent baseTagComponent2 = baseTagComponent;
		this.StopListenSpecialItemRelatedTags();
		string[] array = config.Value.AllowTags();
		for (int i = 0; i < array.Length; i++)
		{
			int tagIdByName = GameplayTagUtils.GetTagIdByName(array[i]);
			if (baseTagComponent2 != null)
			{
				baseTagComponent2.AddTagAddOrRemoveListener(tagIdByName, new BaseTagComponent.TTagSwitchedCallback(this.OnSpecialItemRelatedTagAddOrRemove), null);
			}
			SpecialItemModel.Instance.WatchedAllowTagIds.Add(tagIdByName);
		}
		array = config.Value.BanTags();
		for (int i = 0; i < array.Length; i++)
		{
			int tagIdByName2 = GameplayTagUtils.GetTagIdByName(array[i]);
			if (baseTagComponent2 != null)
			{
				baseTagComponent2.AddTagAddOrRemoveListener(tagIdByName2, new BaseTagComponent.TTagSwitchedCallback(this.OnSpecialItemRelatedTagAddOrRemove), null);
			}
			SpecialItemModel.Instance.WatchedBanTagIds.Add(tagIdByName2);
		}
		SpecialItemModel.Instance.TagWatchedItemId = new int?(configId);
		SpecialItemModel.Instance.TagWatchedEntityHandle = entityHandle;
	}

	// Token: 0x0600D640 RID: 54848 RVA: 0x003F8E44 File Offset: 0x003F7044
	public void StopListenSpecialItemRelatedTags()
	{
		SpecialItemModel instance = SpecialItemModel.Instance;
		BaseTagComponent baseTagComponent;
		if (instance == null)
		{
			baseTagComponent = null;
		}
		else
		{
			EntityHandle tagWatchedEntityHandle = instance.TagWatchedEntityHandle;
			if (tagWatchedEntityHandle == null)
			{
				baseTagComponent = null;
			}
			else
			{
				WorldEntity entity = tagWatchedEntityHandle.Entity;
				baseTagComponent = ((entity != null) ? entity.GetComponent<BaseTagComponent>() : null);
			}
		}
		BaseTagComponent baseTagComponent2 = baseTagComponent;
		if (baseTagComponent2 != null)
		{
			foreach (int tagId in SpecialItemModel.Instance.WatchedAllowTagIds)
			{
				baseTagComponent2.RemoveTagAddOrRemoveListener(tagId, new BaseTagComponent.TTagSwitchedCallback(this.OnSpecialItemRelatedTagAddOrRemove));
			}
		}
		SpecialItemModel.Instance.WatchedAllowTagIds.Clear();
		if (baseTagComponent2 != null)
		{
			foreach (int tagId2 in SpecialItemModel.Instance.WatchedBanTagIds)
			{
				baseTagComponent2.RemoveTagAddOrRemoveListener(tagId2, new BaseTagComponent.TTagSwitchedCallback(this.OnSpecialItemRelatedTagAddOrRemove));
			}
		}
		SpecialItemModel.Instance.WatchedBanTagIds.Clear();
		SpecialItemModel.Instance.TagWatchedItemId = new int?(0);
		SpecialItemModel.Instance.TagWatchedEntityHandle = null;
	}

	// Token: 0x0600D641 RID: 54849 RVA: 0x003F8F64 File Offset: 0x003F7164
	private void OnSpecialItemRelatedTagAddOrRemove(int tagId, bool tagExist)
	{
		int? tagWatchedItemId = SpecialItemModel.Instance.TagWatchedItemId;
		EntityHandle tagWatchedEntityHandle = SpecialItemModel.Instance.TagWatchedEntityHandle;
		if (tagWatchedItemId != null)
		{
			int? num = tagWatchedItemId;
			int num2 = 0;
			if (!(num.GetValueOrDefault() == num2 & num != null))
			{
				this.RecordToRefreshSpecialItemAllowReqUse(tagWatchedItemId.Value, tagWatchedEntityHandle);
			}
		}
	}

	// Token: 0x0600D642 RID: 54850 RVA: 0x003F8FB8 File Offset: 0x003F71B8
	private void OnAddSpecialItem(IReadOnlyList<IProto_NormalItem> itemList)
	{
		foreach (IProto_NormalItem proto_NormalItem in itemList)
		{
			if (this.IsSpecialItem(proto_NormalItem.Id))
			{
				this.EquipSpecialItem(proto_NormalItem.Id, true, true, EExploreSkillLayer.Roulette);
			}
		}
	}

	// Token: 0x0600D643 RID: 54851 RVA: 0x003F9018 File Offset: 0x003F7218
	private void OnSpecialItemUse(int configId, int useCount)
	{
		if (!this.IsSpecialItem(configId))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Item;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "特殊道具不存在,请检查是否配置t.特殊道具";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", configId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (!SpecialItemDefine.SpecialItemIdSet.Contains((SpecialItemDefine.ESpecialItemType)configId))
		{
			return;
		}
		SpecialItemLogicBase specialItemLogic = SpecialItemModel.Instance.GetSpecialItemLogic((SpecialItemDefine.ESpecialItemType)configId);
		if (specialItemLogic.CheckUseCondition())
		{
			specialItemLogic.OnUse();
		}
	}

	// Token: 0x0600D644 RID: 54852 RVA: 0x003F9085 File Offset: 0x003F7285
	private void EquipAndSwitchSpecialItem(int configId, bool needSwitch)
	{
		this.EquipSpecialItem(configId, needSwitch, true, EExploreSkillLayer.Roulette);
	}

	// Token: 0x0600D645 RID: 54853 RVA: 0x003F9092 File Offset: 0x003F7292
	private void OnUnEquipSpecialItem(int configId)
	{
		this.UnEquipSpecialItem(configId);
	}

	// Token: 0x0600D646 RID: 54854 RVA: 0x003F909C File Offset: 0x003F729C
	public unsafe bool EquipSpecialItem(int configId, bool needSwitch = true, bool needTips = true, EExploreSkillLayer layer = EExploreSkillLayer.Roulette)
	{
		if (!RouletteModel.Instance.IsExploreRouletteOpen(false))
		{
			return false;
		}
		SpecialItem? config = SpecialItemConfig.Instance.GetConfig(configId);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Item;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "特殊道具不存在,请检查是否配置t.特殊道具";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", configId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		if (config.Value.SpecialItemType != 0)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Item;
			ELogAuthor author2 = ELogAuthor.YYZ;
			string message2 = "特殊道具配置类型无法装备";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", configId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SpecialItemType", config.Value.SpecialItemType);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		if (InventoryModel.Instance.GetItemCountByConfigId(configId, 0) <= 0)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Item;
			ELogAuthor author3 = ELogAuthor.YYZ;
			string message3 = "背包中没有对应特殊道具,无法切换";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Id", configId);
			instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return false;
		}
		int? equipSpecialItemId = SpecialItemModel.Instance.GetEquipSpecialItemId();
		int configId2 = configId;
		if (!(equipSpecialItemId.GetValueOrDefault() == configId2 & equipSpecialItemId != null))
		{
			RouletteController.Instance.SaveExploreRouletteExtraItemId(configId, delegate(bool success)
			{
				if (!success)
				{
					return;
				}
				if (needSwitch)
				{
					RouletteController.Instance.EquipItemSetRequest(configId, null, layer);
				}
				if (needTips)
				{
					ScrollingTipsController.Instance.ShowTipsById("ItemEquiped", Array.Empty<object>());
				}
			});
			return true;
		}
		if (needSwitch)
		{
			RouletteController.Instance.EquipItemSetRequest(configId, null, layer);
		}
		return true;
	}

	// Token: 0x0600D647 RID: 54855 RVA: 0x003F925C File Offset: 0x003F745C
	public void UnEquipSpecialItem(int configId)
	{
		int? equipSpecialItemId = SpecialItemModel.Instance.GetEquipSpecialItemId();
		if (equipSpecialItemId.GetValueOrDefault() == configId & equipSpecialItemId != null)
		{
			RouletteController.Instance.SaveExploreRouletteExtraItemId(0, null);
		}
	}

	// Token: 0x0600D648 RID: 54856 RVA: 0x003F9298 File Offset: 0x003F7498
	public bool AutoEquipOrUnEquipSpecialItem(int configId)
	{
		int? equipSpecialItemId = SpecialItemModel.Instance.GetEquipSpecialItemId();
		int? num = equipSpecialItemId;
		bool flag = configId == num.GetValueOrDefault() & num != null;
		if (flag)
		{
			this.UnEquipSpecialItem(configId);
		}
		else
		{
			this.EquipSpecialItem(configId, true, true, EExploreSkillLayer.Roulette);
		}
		return !flag;
	}

	// Token: 0x0600D649 RID: 54857 RVA: 0x003F92E0 File Offset: 0x003F74E0
	private void OnItemUse(int configId, int useCount)
	{
		ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(configId);
		if (itemConfig.Value.Parameters().Count == 0)
		{
			return;
		}
		if (!this.IsSpecialItem(configId))
		{
			return;
		}
		int exploreSkillId;
		if (itemConfig.Value.Parameters().TryGetValue(21, out exploreSkillId))
		{
			this.HandleItemUseExploreSkill(configId, useCount, exploreSkillId);
		}
	}

	// Token: 0x0600D64A RID: 54858 RVA: 0x003F9340 File Offset: 0x003F7540
	private void HandleItemUseExploreSkill(int configId, int useCount, int exploreSkillId)
	{
		WorldEntity entity = SceneTeamModel.Instance.GetCurrentEntity.Entity;
		if (entity == null || !entity.Valid)
		{
			return;
		}
		CharacterSkillComponent component = entity.GetComponent<CharacterSkillComponent>();
		if (!component.Valid)
		{
			return;
		}
		component.BeginSkillAsync(exploreSkillId, new SkillParam
		{
			Reason = "Explore skill item: UseSkill"
		});
	}

	// Token: 0x170013DD RID: 5085
	// (get) Token: 0x0600D64B RID: 54859 RVA: 0x003F9397 File Offset: 0x003F7597
	public static SpecialItemController Instance
	{
		get
		{
			return SpecialItemController._Instance;
		}
	}

	// Token: 0x0600D64C RID: 54860 RVA: 0x003F939E File Offset: 0x003F759E
	public static SpecialItemController GetOrCreateInstance()
	{
		if (SpecialItemController._Instance == null)
		{
			SpecialItemController.CreateInstance();
		}
		return SpecialItemController._Instance;
	}

	// Token: 0x0600D64D RID: 54861 RVA: 0x003F93B2 File Offset: 0x003F75B2
	public static bool CreateInstance()
	{
		if (SpecialItemController._Instance != null)
		{
			return true;
		}
		SpecialItemController._Instance = new SpecialItemController();
		return true;
	}

	// Token: 0x0600D64E RID: 54862 RVA: 0x003F93C8 File Offset: 0x003F75C8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D64F RID: 54863 RVA: 0x003F93CA File Offset: 0x003F75CA
	public static void ResetStaticDefaultValue()
	{
		SpecialItemController._Instance = null;
	}

	// Token: 0x0600D650 RID: 54864 RVA: 0x003F93D2 File Offset: 0x003F75D2
	static SpecialItemController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SpecialItemController.CreateStaticDefaultValue), new Action(SpecialItemController.ResetStaticDefaultValue));
	}

	// Token: 0x0400782E RID: 30766
	[TupleElementNames(new string[]
	{
		"ConfigId",
		"EntityHandle"
	})]
	[Nullable(new byte[]
	{
		1,
		0,
		2
	})]
	private List<ValueTuple<int, EntityHandle>> RecordListForRefreshSpecialItemAllowReqUse = new List<ValueTuple<int, EntityHandle>>();

	// Token: 0x0400782F RID: 30767
	private readonly Action OnChangeModeFinish = delegate()
	{
		int? tagWatchedItemId = SpecialItemModel.Instance.TagWatchedItemId;
		EntityHandle tagWatchedEntityHandle = SpecialItemModel.Instance.TagWatchedEntityHandle;
		if (tagWatchedItemId != null)
		{
			int? num = tagWatchedItemId;
			int num2 = 0;
			if (!(num.GetValueOrDefault() == num2 & num != null))
			{
				SpecialItemController.Instance.RecordToRefreshSpecialItemAllowReqUse(tagWatchedItemId.Value, tagWatchedEntityHandle);
			}
		}
	};

	// Token: 0x04007830 RID: 30768
	[Nullable(2)]
	private static SpecialItemController _Instance;
}
