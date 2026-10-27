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

// Token: 0x02001715 RID: 5909
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class BuffItemControl : UiControllerBase
{
	// Token: 0x0600AA47 RID: 43591 RVA: 0x00263FD1 File Offset: 0x002621D1
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0600AA48 RID: 43592 RVA: 0x00263FD4 File Offset: 0x002621D4
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x0600AA49 RID: 43593 RVA: 0x00263FD7 File Offset: 0x002621D7
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.BuffItemNotify, new Action<IMessage, Net.CallbackStatus>(this.NotifyBuffItem));
		Net.Instance.Register(ENotifyMessageId.BuffItemUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.BuffItemUpdateNotify));
	}

	// Token: 0x0600AA4A RID: 43594 RVA: 0x00264011 File Offset: 0x00262211
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.BuffItemNotify);
		Net.Instance.UnRegister(ENotifyMessageId.BuffItemUpdateNotify);
	}

	// Token: 0x0600AA4B RID: 43595 RVA: 0x00264034 File Offset: 0x00262234
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

	// Token: 0x0600AA4C RID: 43596 RVA: 0x002640B4 File Offset: 0x002622B4
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

	// Token: 0x0600AA4D RID: 43597 RVA: 0x0026417C File Offset: 0x0026237C
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

	// Token: 0x0600AA4E RID: 43598 RVA: 0x00264260 File Offset: 0x00262460
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

	// Token: 0x0600AA4F RID: 43599 RVA: 0x0026436C File Offset: 0x0026256C
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

	// Token: 0x0600AA50 RID: 43600 RVA: 0x0026443C File Offset: 0x0026263C
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

	// Token: 0x0600AA51 RID: 43601 RVA: 0x0026451C File Offset: 0x0026271C
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

	// Token: 0x17000E05 RID: 3589
	// (get) Token: 0x0600AA52 RID: 43602 RVA: 0x0026464C File Offset: 0x0026284C
	public static BuffItemControl Instance
	{
		get
		{
			return BuffItemControl._Instance;
		}
	}

	// Token: 0x0600AA53 RID: 43603 RVA: 0x00264653 File Offset: 0x00262853
	public static BuffItemControl GetOrCreateInstance()
	{
		if (BuffItemControl._Instance == null)
		{
			BuffItemControl.CreateInstance();
		}
		return BuffItemControl._Instance;
	}

	// Token: 0x0600AA54 RID: 43604 RVA: 0x00264667 File Offset: 0x00262867
	public static bool CreateInstance()
	{
		if (BuffItemControl._Instance != null)
		{
			return true;
		}
		BuffItemControl._Instance = new BuffItemControl();
		return true;
	}

	// Token: 0x0600AA55 RID: 43605 RVA: 0x0026467D File Offset: 0x0026287D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600AA56 RID: 43606 RVA: 0x0026467F File Offset: 0x0026287F
	public static void ResetStaticDefaultValue()
	{
		BuffItemControl._Instance = null;
	}

	// Token: 0x0600AA57 RID: 43607 RVA: 0x00264687 File Offset: 0x00262887
	static BuffItemControl()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BuffItemControl.CreateStaticDefaultValue), new Action(BuffItemControl.ResetStaticDefaultValue));
	}

	// Token: 0x04004D4F RID: 19791
	private const int TRIAL_ROLE_ID = 10000;

	// Token: 0x04004D50 RID: 19792
	[Nullable(2)]
	private static BuffItemControl _Instance;
}
