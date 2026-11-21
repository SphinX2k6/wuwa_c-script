using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.DeadRevive;
using CSharpScript.Game.Ui;
using Google.Protobuf;
using Google.Protobuf.Collections;

// Token: 0x02000BCD RID: 3021
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class BuffItemControl : UiControllerBase
{
	// Token: 0x06007E2A RID: 32298 RVA: 0x0026E521 File Offset: 0x0026C721
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x06007E2B RID: 32299 RVA: 0x0026E524 File Offset: 0x0026C724
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x06007E2C RID: 32300 RVA: 0x0026E527 File Offset: 0x0026C727
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.BuffItemNotify, new Action<IMessage, Net.CallbackStatus>(this.NotifyBuffItem));
		Net.Instance.Register(ENotifyMessageId.BuffItemUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.BuffItemUpdateNotify));
	}

	// Token: 0x06007E2D RID: 32301 RVA: 0x0026E561 File Offset: 0x0026C761
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.BuffItemNotify);
		Net.Instance.UnRegister(ENotifyMessageId.BuffItemUpdateNotify);
	}

	// Token: 0x06007E2E RID: 32302 RVA: 0x0026E584 File Offset: 0x0026C784
	public void RequestUseBuffItem(int itemConfigId, int useCount, int useRoleConfigId)
	{
		BuffItemControl.<>c__DisplayClass5_0 CS$<>8__locals1 = new BuffItemControl.<>c__DisplayClass5_0();
		CS$<>8__locals1.useCount = useCount;
		BuffItemRequest buffItemRequest = BuffItemRequest.Create();
		buffItemRequest.ItemId = itemConfigId;
		buffItemRequest.Num = CS$<>8__locals1.useCount;
		buffItemRequest.RoleId = useRoleConfigId;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.BuffItem;
		ELogAuthor author = ELogAuthor.YYZ;
		string message = "[Inventory]客户端请求使用Buff道具";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("massage", buffItemRequest);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		Net.Instance.Call(ERequestMessageId.BuffItemRequest, buffItemRequest, new Action<IMessage, Net.CallbackStatus>(CS$<>8__locals1.<RequestUseBuffItem>g__responseBuffItem|0), 0);
	}

	// Token: 0x06007E2F RID: 32303 RVA: 0x0026E604 File Offset: 0x0026C804
	[NullableContext(2)]
	private void NotifyBuffItem(IMessage msg, Net.CallbackStatus _)
	{
		BuffItemNotify buffItemNotify = (BuffItemNotify)msg;
		RepeatedField<Aki.Protocol.BuffItem> itemBuffList = buffItemNotify.ItemBuffList;
		if (itemBuffList != null)
		{
			Log.Instance.Info(ELogModule.BuffItem, ELogAuthor.YYZ, "[Inventory]服务端通知Buff道具数据", default(ReadOnlySpan<ValueTuple<string, object>>));
			foreach (Aki.Protocol.BuffItem buffInfo in itemBuffList)
			{
				this.RefreshBuffItem(buffInfo);
			}
		}
		RepeatedField<EquipBuffItem> equipItemList = buffItemNotify.EquipItemList;
		if (equipItemList != null)
		{
			foreach (EquipBuffItem itemInfo in equipItemList)
			{
				this.RefreshEquipBuffItem(itemInfo, false);
			}
		}
	}

	// Token: 0x06007E30 RID: 32304 RVA: 0x0026E6CC File Offset: 0x0026C8CC
	[NullableContext(2)]
	private unsafe void BuffItemUpdateNotify(IMessage msg, Net.CallbackStatus _)
	{
		BuffItemUpdateNotify buffItemUpdateNotify = (BuffItemUpdateNotify)msg;
		if (buffItemUpdateNotify.BuffItem != null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BuffItem;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[Inventory]服务端通知Buff道具进入CD";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ItemId", buffItemUpdateNotify.BuffItem.ItemId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Cd", buffItemUpdateNotify.BuffItem.CdTime);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.RefreshBuffItem(buffItemUpdateNotify.BuffItem);
		}
		RepeatedField<EquipBuffItem> equipItemList = buffItemUpdateNotify.EquipItemList;
		if (equipItemList != null)
		{
			foreach (EquipBuffItem itemInfo in equipItemList)
			{
				this.RefreshEquipBuffItem(itemInfo, true);
			}
		}
	}

	// Token: 0x06007E31 RID: 32305 RVA: 0x0026E7B0 File Offset: 0x0026C9B0
	private void RefreshBuffItem(Aki.Protocol.BuffItem buffInfo)
	{
		int itemId = buffInfo.ItemId;
		if (itemId == 0)
		{
			return;
		}
		long cdTime = buffInfo.CdTime;
		BuffItemConfig instance = BuffItemConfig.Instance;
		BuffItemModel instance2 = BuffItemModel.Instance;
		Aki.Config.BuffItem? buffItemConfig = instance.GetBuffItemConfig(itemId);
		if (buffItemConfig == null)
		{
			Log instance3 = Log.Instance;
			ELogModule module = ELogModule.BuffItem;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[Inventory]服务端通知Buff道具进入CD时，s.属性奖励表中找不到对应Buff道具";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ItemId", buffInfo.ItemId);
			instance3.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		int publicCdGroup = buffItemConfig.Value.PublicCdGroup;
		if (publicCdGroup > 0)
		{
			IReadOnlyList<Aki.Config.BuffItem> buffItemConfigByPublicCdGroup = instance.GetBuffItemConfigByPublicCdGroup(publicCdGroup);
			BuffItemCdGroup? buffItemCdGroup = instance.GetBuffItemCdGroup(publicCdGroup);
			using (IEnumerator<Aki.Config.BuffItem> enumerator = buffItemConfigByPublicCdGroup.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Aki.Config.BuffItem buffItem = enumerator.Current;
					instance2.SetBuffItemCdTimeStamp(buffItem.Id, cdTime, buffItemCdGroup.Value.CoolDownTime);
				}
				return;
			}
		}
		instance2.SetBuffItemCdTimeStamp(itemId, cdTime, buffItemConfig.Value.Cd);
	}

	// Token: 0x06007E32 RID: 32306 RVA: 0x0026E8BC File Offset: 0x0026CABC
	private void RefreshEquipBuffItem(EquipBuffItem itemInfo, bool notifyUpdate = false)
	{
		int itemId = itemInfo.ItemId;
		bool equiped = itemInfo.Equiped;
		bool flag = BuffItemModel.Instance.IsEquippedBuffItem(itemId);
		if (notifyUpdate)
		{
			bool flag2 = !flag && equiped;
			bool flag3 = flag && !equiped;
			if ((flag2 || flag3) && UiManager.Instance.IsViewOpen(EUiViewName.InventoryView))
			{
				IReadOnlyList<BuffEquipItem> buffEquipItemByItemId = BuffItemConfig.Instance.GetBuffEquipItemByItemId(itemId);
				if (buffEquipItemByItemId.Count > 0)
				{
					string text = flag2 ? buffEquipItemByItemId[0].EquipTips : buffEquipItemByItemId[0].UnEquipTips;
					if (!StringUtils.IsEmpty(text))
					{
						ScrollingTipsController.Instance.ShowTipsByTextId(text, Array.Empty<object>());
					}
				}
			}
		}
		BuffItemModel.Instance.SetBuffEquipItem(itemId, equiped);
		EventSystem.Instance.Emit<int, bool>(EEventName.OnEquipBuffItemUpdate, itemId, equiped);
	}

	// Token: 0x06007E33 RID: 32307 RVA: 0x0026E98C File Offset: 0x0026CB8C
	public void InitializeAllUseBuffItemRoleFromPlayerFormationInstance(int useItemConfigId)
	{
		BuffItemModel instance = BuffItemModel.Instance;
		List<SceneTeamItem> teamItems = SceneTeamModel.Instance.GetTeamItems(true);
		for (int i = 0; i < teamItems.Count; i++)
		{
			SceneTeamItem sceneTeamItem = teamItems[i];
			if (sceneTeamItem.GetConfigId <= 10000)
			{
				int position = i + 1;
				int getConfigId = sceneTeamItem.GetConfigId;
				string roleName = RoleModel.Instance.GetRoleName(getConfigId, null);
				EntityHandle entityHandle = sceneTeamItem.EntityHandle;
				BaseAttributeComponent baseAttributeComponent;
				if (entityHandle == null)
				{
					baseAttributeComponent = null;
				}
				else
				{
					WorldEntity entity = entityHandle.Entity;
					baseAttributeComponent = ((entity != null) ? entity.GetComponent<BaseAttributeComponent>() : null);
				}
				BaseAttributeComponent baseAttributeComponent2 = baseAttributeComponent;
				int roleLevel = 0;
				int maxAttribute = 0;
				int currentAttribute = 0;
				if (baseAttributeComponent2 != null)
				{
					roleLevel = (int)baseAttributeComponent2.GetCurrentValue(EAttributeType.Lv);
					maxAttribute = (int)baseAttributeComponent2.GetCurrentValue(EAttributeType.LifeMax);
					currentAttribute = (int)baseAttributeComponent2.GetCurrentValue(EAttributeType.Life);
				}
				instance.NewUseBuffItemRoleData(roleName, position, getConfigId, roleLevel, currentAttribute, maxAttribute, useItemConfigId, entityHandle.Entity);
			}
		}
	}

	// Token: 0x06007E34 RID: 32308 RVA: 0x0026EA6C File Offset: 0x0026CC6C
	public bool TryUseResurrectionItem(int roleConfigId)
	{
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("use_buff_item_id_list");
		InventoryModel instance = InventoryModel.Instance;
		BuffItemModel instance2 = BuffItemModel.Instance;
		BuffItemConfig instance3 = BuffItemConfig.Instance;
		bool flag = true;
		bool flag2 = true;
		double num = 3.402823466E+38;
		foreach (int num2 in intArrayConfig)
		{
			if (instance.GetItemCountByConfigId(num2, 0) > 0 && instance3.IsResurrectionItem(num2))
			{
				flag = false;
				double buffItemRemainCdTime = instance2.GetBuffItemRemainCdTime(num2);
				if (buffItemRemainCdTime <= 0.0)
				{
					flag2 = false;
					ReviveItemData param = new ReviveItemData(roleConfigId, intArrayConfig, num2);
					if (!UiManager.Instance.IsViewShow(EUiViewName.UseReviveItemView))
					{
						UiManager.Instance.OpenView(EUiViewName.UseReviveItemView, param, null);
					}
					return true;
				}
				if (buffItemRemainCdTime < num)
				{
					num = buffItemRemainCdTime;
				}
			}
		}
		if (flag)
		{
			ScrollingTipsController.Instance.ShowTipsById("NotResurrectionItem", Array.Empty<object>());
		}
		else if (flag2)
		{
			ScrollingTipsController.Instance.ShowTipsById("AllResurrectionItemInCd", new object[]
			{
				num.ToString("0")
			});
		}
		return false;
	}

	// Token: 0x17000E26 RID: 3622
	// (get) Token: 0x06007E35 RID: 32309 RVA: 0x0026EB9C File Offset: 0x0026CD9C
	public static BuffItemControl Instance
	{
		get
		{
			return BuffItemControl._Instance;
		}
	}

	// Token: 0x06007E36 RID: 32310 RVA: 0x0026EBA3 File Offset: 0x0026CDA3
	public static BuffItemControl GetOrCreateInstance()
	{
		if (BuffItemControl._Instance == null)
		{
			BuffItemControl.CreateInstance();
		}
		return BuffItemControl._Instance;
	}

	// Token: 0x06007E37 RID: 32311 RVA: 0x0026EBB7 File Offset: 0x0026CDB7
	public static bool CreateInstance()
	{
		if (BuffItemControl._Instance != null)
		{
			return true;
		}
		BuffItemControl._Instance = new BuffItemControl();
		return true;
	}

	// Token: 0x06007E38 RID: 32312 RVA: 0x0026EBCD File Offset: 0x0026CDCD
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007E39 RID: 32313 RVA: 0x0026EBCF File Offset: 0x0026CDCF
	public static void ResetStaticDefaultValue()
	{
		BuffItemControl._Instance = null;
	}

	// Token: 0x06007E3A RID: 32314 RVA: 0x0026EBD7 File Offset: 0x0026CDD7
	static BuffItemControl()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BuffItemControl.CreateStaticDefaultValue), new Action(BuffItemControl.ResetStaticDefaultValue));
	}

	// Token: 0x04004DF7 RID: 19959
	private const int TRIAL_ROLE_ID = 10000;

	// Token: 0x04004DF8 RID: 19960
	[Nullable(2)]
	private static BuffItemControl _Instance;
}
