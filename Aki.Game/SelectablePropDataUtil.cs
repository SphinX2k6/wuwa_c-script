using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

// Token: 0x0200195A RID: 6490
[NullableContext(1)]
[Nullable(0)]
public class SelectablePropDataUtil : IStaticVariableResetter
{
	// Token: 0x0600BDBD RID: 48573 RVA: 0x002AE9EE File Offset: 0x002ACBEE
	static SelectablePropDataUtil()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SelectablePropDataUtil.CreateStaticDefaultValue), new Action(SelectablePropDataUtil.ResetStaticDefaultValue));
	}

	// Token: 0x0600BDBE RID: 48574 RVA: 0x002AEA0D File Offset: 0x002ACC0D
	public static void CreateStaticDefaultValue()
	{
		SelectablePropDataUtil.TickIntervalTimeInternal = null;
		SelectablePropDataUtil.TickMaxTimeInternal = null;
		SelectablePropDataUtil.TickMinTimeInternal = null;
	}

	// Token: 0x0600BDBF RID: 48575 RVA: 0x002AEA30 File Offset: 0x002ACC30
	public static void ResetStaticDefaultValue()
	{
		SelectablePropDataUtil.TickIntervalTimeInternal = null;
		SelectablePropDataUtil.TickMaxTimeInternal = null;
		SelectablePropDataUtil.TickMinTimeInternal = null;
	}

	// Token: 0x17000FD6 RID: 4054
	// (get) Token: 0x0600BDC0 RID: 48576 RVA: 0x002AEA53 File Offset: 0x002ACC53
	public static int TickMaxTime
	{
		get
		{
			if (SelectablePropDataUtil.TickMaxTimeInternal == null)
			{
				SelectablePropDataUtil.TickMaxTimeInternal = CommonConfig.Instance.GetSelectablePropItemTickMaxTime();
			}
			return SelectablePropDataUtil.TickMaxTimeInternal.Value;
		}
	}

	// Token: 0x17000FD7 RID: 4055
	// (get) Token: 0x0600BDC1 RID: 48577 RVA: 0x002AEA7A File Offset: 0x002ACC7A
	public static int TickMinTime
	{
		get
		{
			if (SelectablePropDataUtil.TickMinTimeInternal == null)
			{
				SelectablePropDataUtil.TickMinTimeInternal = CommonConfig.Instance.GetSelectablePropItemTickMinTime();
			}
			return SelectablePropDataUtil.TickMinTimeInternal.Value;
		}
	}

	// Token: 0x17000FD8 RID: 4056
	// (get) Token: 0x0600BDC2 RID: 48578 RVA: 0x002AEAA1 File Offset: 0x002ACCA1
	public static int TickInternalTime
	{
		get
		{
			if (SelectablePropDataUtil.TickIntervalTimeInternal == null)
			{
				SelectablePropDataUtil.TickIntervalTimeInternal = CommonConfig.Instance.GetSelectablePropItemTickIntervalTime();
			}
			return SelectablePropDataUtil.TickIntervalTimeInternal.Value;
		}
	}

	// Token: 0x0600BDC3 RID: 48579 RVA: 0x002AEAC8 File Offset: 0x002ACCC8
	[return: Nullable(2)]
	public static SelectablePropData GetSelectablePropData(ItemDataBase itemData)
	{
		InventoryDefine.EItemDataType itemDataType = itemData.GetItemDataType();
		if (itemDataType == InventoryDefine.EItemDataType.WeaponItem)
		{
			return SelectablePropDataUtil.WeaponPropData(itemData.GetUniqueId());
		}
		if (itemDataType == InventoryDefine.EItemDataType.PhantomItem)
		{
			return SelectablePropDataUtil.PhantomPropData(itemData.GetUniqueId(), itemData.GetCount());
		}
		if (itemDataType == InventoryDefine.EItemDataType.DangoAbyssItem)
		{
			return SelectablePropDataUtil.DangoAbyssItemPropData(itemData);
		}
		return SelectablePropDataUtil.MaterialPropData(itemData.GetConfigId(), itemData.GetCount());
	}

	// Token: 0x0600BDC4 RID: 48580 RVA: 0x002AEB20 File Offset: 0x002ACD20
	protected static SelectablePropData WeaponPropData(int incId)
	{
		SelectablePropData selectablePropData = new SelectablePropData();
		WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(incId);
		if (weaponDataByIncId == null)
		{
			return selectablePropData;
		}
		selectablePropData.IncId = incId;
		selectablePropData.ItemId = weaponDataByIncId.GetItemId();
		selectablePropData.ItemDataType = InventoryDefine.EItemDataType.WeaponItem;
		selectablePropData.ResonanceLevel = weaponDataByIncId.GetResonanceLevel();
		selectablePropData.LevelText = TextConfig.Instance.GetTextById("LevelShow").Replace("{0}", weaponDataByIncId.GetLevel().ToString());
		selectablePropData.RoleId = weaponDataByIncId.GetRoleId();
		return selectablePropData;
	}

	// Token: 0x0600BDC5 RID: 48581 RVA: 0x002AEBA4 File Offset: 0x002ACDA4
	[NullableContext(2)]
	protected static SelectablePropData PhantomPropData(int incId, int count)
	{
		PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(incId);
		if (phantomBattleData == null)
		{
			return null;
		}
		return new SelectablePropData
		{
			IncId = incId,
			ItemId = phantomBattleData.GetConfigId(false),
			ItemDataType = InventoryDefine.EItemDataType.PhantomItem,
			LevelText = TextConfig.Instance.GetTextById("LevelShow").Replace("{0}", phantomBattleData.GetPhantomLevel().ToString()),
			Count = count
		};
	}

	// Token: 0x0600BDC6 RID: 48582 RVA: 0x002AEC18 File Offset: 0x002ACE18
	[return: Nullable(2)]
	protected static SelectablePropData DangoAbyssItemPropData(ItemDataBase itemData)
	{
		AbyssPluginItemInfo pluginItemInfoById = DangoAbyssModel.Instance.GetPluginItemInfoById(itemData.GetUniqueId());
		if (pluginItemInfoById == null)
		{
			return null;
		}
		return new SelectablePropData
		{
			IncId = itemData.GetUniqueId(),
			ItemId = itemData.GetConfigId(),
			ItemDataType = itemData.GetItemDataType(),
			RoleId = pluginItemInfoById.GetRoleId()
		};
	}

	// Token: 0x0600BDC7 RID: 48583 RVA: 0x002AEC70 File Offset: 0x002ACE70
	protected static SelectablePropData MaterialPropData(int configId, int count)
	{
		return new SelectablePropData
		{
			IncId = 0,
			LevelText = count.ToString(),
			ItemDataType = InventoryDefine.EItemDataType.CommonItem,
			ItemId = configId,
			Count = count
		};
	}

	// Token: 0x04005598 RID: 21912
	private static int? TickMaxTimeInternal;

	// Token: 0x04005599 RID: 21913
	private static int? TickMinTimeInternal;

	// Token: 0x0400559A RID: 21914
	private static int? TickIntervalTimeInternal;
}
