using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020013E1 RID: 5089
[NullableContext(2)]
[Nullable(0)]
public class StrengthUnitData
{
	// Token: 0x0600C98D RID: 51597 RVA: 0x003BEE64 File Offset: 0x003BD064
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

	// Token: 0x0600C98E RID: 51598 RVA: 0x003BEEC4 File Offset: 0x003BD0C4
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

	// Token: 0x0600C98F RID: 51599 RVA: 0x003BEEF8 File Offset: 0x003BD0F8
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

	// Token: 0x0400725B RID: 29275
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

	// Token: 0x0400725C RID: 29276
	[Nullable(1)]
	public readonly Dictionary<EStrengthItemType, StrengthItemInfo> InfoMap = new Dictionary<EStrengthItemType, StrengthItemInfo>();
}
