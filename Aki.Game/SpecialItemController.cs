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

// Token: 0x0200201E RID: 8222
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class SpecialItemController : UiControllerBase
{
	// Token: 0x060101CD RID: 65997 RVA: 0x003EC1F8 File Offset: 0x003EA3F8
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

	// Token: 0x060101CE RID: 65998 RVA: 0x003EC2E0 File Offset: 0x003EA4E0
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

	// Token: 0x060101CF RID: 65999 RVA: 0x003EC3C7 File Offset: 0x003EA5C7
	protected override bool OnInit()
	{
		base.PauseTick();
		return true;
	}

	// Token: 0x060101D0 RID: 66000 RVA: 0x003EC3D0 File Offset: 0x003EA5D0
	protected override void OnTick(float delta)
	{
		base.PauseTick();
		this.RefreshSpecialItemAllowReqUse();
	}

	// Token: 0x060101D1 RID: 66001 RVA: 0x003EC3E0 File Offset: 0x003EA5E0
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

	// Token: 0x060101D2 RID: 66002 RVA: 0x003EC460 File Offset: 0x003EA660
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

	// Token: 0x060101D3 RID: 66003 RVA: 0x003EC558 File Offset: 0x003EA758
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

	// Token: 0x060101D4 RID: 66004 RVA: 0x003EC590 File Offset: 0x003EA790
	public bool IsSpecialItem(int configId)
	{
		if (configId == 0)
		{
			return false;
		}
		ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(configId);
		return itemConfig != null && itemConfig.GetValueOrDefault().SpecialItem;
	}

	// Token: 0x060101D5 RID: 66005 RVA: 0x003EC5D0 File Offset: 0x003EA7D0
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

	// Token: 0x060101D6 RID: 66006 RVA: 0x003EC6E0 File Offset: 0x003EA8E0
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

	// Token: 0x060101D7 RID: 66007 RVA: 0x003EC73C File Offset: 0x003EA93C
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

	// Token: 0x060101D8 RID: 66008 RVA: 0x003EC84C File Offset: 0x003EAA4C
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

	// Token: 0x060101D9 RID: 66009 RVA: 0x003EC96C File Offset: 0x003EAB6C
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

	// Token: 0x060101DA RID: 66010 RVA: 0x003EC9C0 File Offset: 0x003EABC0
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

	// Token: 0x060101DB RID: 66011 RVA: 0x003ECA20 File Offset: 0x003EAC20
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

	// Token: 0x060101DC RID: 66012 RVA: 0x003ECA8D File Offset: 0x003EAC8D
	private void EquipAndSwitchSpecialItem(int configId, bool needSwitch)
	{
		this.EquipSpecialItem(configId, needSwitch, true, EExploreSkillLayer.Roulette);
	}

	// Token: 0x060101DD RID: 66013 RVA: 0x003ECA9A File Offset: 0x003EAC9A
	private void OnUnEquipSpecialItem(int configId)
	{
		this.UnEquipSpecialItem(configId);
	}

	// Token: 0x060101DE RID: 66014 RVA: 0x003ECAA4 File Offset: 0x003EACA4
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

	// Token: 0x060101DF RID: 66015 RVA: 0x003ECC64 File Offset: 0x003EAE64
	public void UnEquipSpecialItem(int configId)
	{
		int? equipSpecialItemId = SpecialItemModel.Instance.GetEquipSpecialItemId();
		if (equipSpecialItemId.GetValueOrDefault() == configId & equipSpecialItemId != null)
		{
			RouletteController.Instance.SaveExploreRouletteExtraItemId(0, null);
		}
	}

	// Token: 0x060101E0 RID: 66016 RVA: 0x003ECCA0 File Offset: 0x003EAEA0
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

	// Token: 0x060101E1 RID: 66017 RVA: 0x003ECCE8 File Offset: 0x003EAEE8
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

	// Token: 0x060101E2 RID: 66018 RVA: 0x003ECD48 File Offset: 0x003EAF48
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

	// Token: 0x170013B0 RID: 5040
	// (get) Token: 0x060101E3 RID: 66019 RVA: 0x003ECD9F File Offset: 0x003EAF9F
	public static SpecialItemController Instance
	{
		get
		{
			return SpecialItemController._Instance;
		}
	}

	// Token: 0x060101E4 RID: 66020 RVA: 0x003ECDA6 File Offset: 0x003EAFA6
	public static SpecialItemController GetOrCreateInstance()
	{
		if (SpecialItemController._Instance == null)
		{
			SpecialItemController.CreateInstance();
		}
		return SpecialItemController._Instance;
	}

	// Token: 0x060101E5 RID: 66021 RVA: 0x003ECDBA File Offset: 0x003EAFBA
	public static bool CreateInstance()
	{
		if (SpecialItemController._Instance != null)
		{
			return true;
		}
		SpecialItemController._Instance = new SpecialItemController();
		return true;
	}

	// Token: 0x060101E6 RID: 66022 RVA: 0x003ECDD0 File Offset: 0x003EAFD0
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060101E7 RID: 66023 RVA: 0x003ECDD2 File Offset: 0x003EAFD2
	public static void ResetStaticDefaultValue()
	{
		SpecialItemController._Instance = null;
	}

	// Token: 0x060101E8 RID: 66024 RVA: 0x003ECDDA File Offset: 0x003EAFDA
	static SpecialItemController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SpecialItemController.CreateStaticDefaultValue), new Action(SpecialItemController.ResetStaticDefaultValue));
	}

	// Token: 0x04007745 RID: 30533
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

	// Token: 0x04007746 RID: 30534
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

	// Token: 0x04007747 RID: 30535
	[Nullable(2)]
	private static SpecialItemController _Instance;
}
