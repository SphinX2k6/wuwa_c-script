using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02000E17 RID: 3607
[NullableContext(1)]
[Nullable(0)]
public class SelectablePropDataUtil : IStaticVariableResetter
{
	// Token: 0x060091C0 RID: 37312 RVA: 0x002B9832 File Offset: 0x002B7A32
	static SelectablePropDataUtil()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SelectablePropDataUtil.CreateStaticDefaultValue), new Action(SelectablePropDataUtil.ResetStaticDefaultValue));
	}

	// Token: 0x060091C1 RID: 37313 RVA: 0x002B9851 File Offset: 0x002B7A51
	public static void CreateStaticDefaultValue()
	{
		SelectablePropDataUtil.TickIntervalTimeInternal = null;
		SelectablePropDataUtil.TickMaxTimeInternal = null;
		SelectablePropDataUtil.TickMinTimeInternal = null;
	}

	// Token: 0x060091C2 RID: 37314 RVA: 0x002B9874 File Offset: 0x002B7A74
	public static void ResetStaticDefaultValue()
	{
		SelectablePropDataUtil.TickIntervalTimeInternal = null;
		SelectablePropDataUtil.TickMaxTimeInternal = null;
		SelectablePropDataUtil.TickMinTimeInternal = null;
	}

	// Token: 0x17000FFA RID: 4090
	// (get) Token: 0x060091C3 RID: 37315 RVA: 0x002B9897 File Offset: 0x002B7A97
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

	// Token: 0x17000FFB RID: 4091
	// (get) Token: 0x060091C4 RID: 37316 RVA: 0x002B98BE File Offset: 0x002B7ABE
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

	// Token: 0x17000FFC RID: 4092
	// (get) Token: 0x060091C5 RID: 37317 RVA: 0x002B98E5 File Offset: 0x002B7AE5
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

	// Token: 0x060091C6 RID: 37318 RVA: 0x002B990C File Offset: 0x002B7B0C
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

	// Token: 0x060091C7 RID: 37319 RVA: 0x002B9964 File Offset: 0x002B7B64
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

	// Token: 0x060091C8 RID: 37320 RVA: 0x002B99E8 File Offset: 0x002B7BE8
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

	// Token: 0x060091C9 RID: 37321 RVA: 0x002B9A5C File Offset: 0x002B7C5C
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

	// Token: 0x060091CA RID: 37322 RVA: 0x002B9AB4 File Offset: 0x002B7CB4
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

	// Token: 0x04005645 RID: 22085
	private static int? TickMaxTimeInternal;

	// Token: 0x04005646 RID: 22086
	private static int? TickMinTimeInternal;

	// Token: 0x04005647 RID: 22087
	private static int? TickIntervalTimeInternal;
}
