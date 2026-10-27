using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001F1F RID: 7967
[NullableContext(2)]
[Nullable(0)]
public class StrengthUnitData
{
	// Token: 0x0600F56E RID: 62830 RVA: 0x003B3378 File Offset: 0x003B1578
	public StrengthItemInfo EnableStrengthItem(EStrengthItemType itemType)
	{
		StrengthItemInfo strengthItemInfo;
		if (this.InfoMap.TryGetValue(itemType, out strengthItemInfo))
		{
			if (strengthItemInfo.Enable)
			{
				return null;
			}
			strengthItemInfo.Enable = true;
			return strengthItemInfo;
		}
		else
		{
			StrengthItemConfig config;
			if (!this.ConfigMap.TryGetValue(itemType, out config))
			{
				return null;
			}
			strengthItemInfo = new StrengthItemInfo(itemType, config)
			{
				Enable = true
			};
			this.InfoMap[itemType] = strengthItemInfo;
			return strengthItemInfo;
		}
	}

	// Token: 0x0600F56F RID: 62831 RVA: 0x003B33D8 File Offset: 0x003B15D8
	public StrengthItemInfo DisableStrengthItem(EStrengthItemType itemType)
	{
		StrengthItemInfo strengthItemInfo;
		if (!this.InfoMap.TryGetValue(itemType, out strengthItemInfo))
		{
			return null;
		}
		if (!strengthItemInfo.Enable)
		{
			return null;
		}
		strengthItemInfo.Enable = false;
		return strengthItemInfo;
	}

	// Token: 0x0600F570 RID: 62832 RVA: 0x003B340C File Offset: 0x003B160C
	public StrengthItemInfo DestroyStrengthItem(EStrengthItemType itemType)
	{
		StrengthItemInfo result;
		if (!this.InfoMap.TryGetValue(itemType, out result))
		{
			return null;
		}
		this.InfoMap.Remove(itemType);
		return result;
	}

	// Token: 0x0400717A RID: 29050
	[Nullable(1)]
	public readonly Dictionary<EStrengthItemType, StrengthItemConfig> ConfigMap = new Dictionary<EStrengthItemType, StrengthItemConfig>
	{
		{
			EStrengthItemType.Default,
			new StrengthItemConfig(1, 1, typeof(StrengthItem), false)
		},
		{
			EStrengthItemType.MotorcycleFly,
			new StrengthItemConfig(1, 102, typeof(FlyStrengthItemForMotorcycle), true)
		},
		{
			EStrengthItemType.StrengthForAimisi,
			new StrengthItemConfig(1, 201, typeof(StrengthItemForAimisi), true)
		},
		{
			EStrengthItemType.Fly,
			new StrengthItemConfig(2, 2, typeof(FlyStrengthItem), true)
		},
		{
			EStrengthItemType.Motorcycle,
			new StrengthItemConfig(2, 101, typeof(MotorcycleStrengthItem), true)
		},
		{
			EStrengthItemType.QingXiaoFly,
			new StrengthItemConfig(2, 201, typeof(FlyStrengthItemForQingXiao), true)
		}
	};

	// Token: 0x0400717B RID: 29051
	[Nullable(1)]
	public readonly Dictionary<EStrengthItemType, StrengthItemInfo> InfoMap = new Dictionary<EStrengthItemType, StrengthItemInfo>();
}
