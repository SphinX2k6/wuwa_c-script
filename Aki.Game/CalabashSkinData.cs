using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Skin;

// Token: 0x02002A3E RID: 10814
[NullableContext(1)]
[Nullable(0)]
public class CalabashSkinData
{
	// Token: 0x17001DDA RID: 7642
	// (get) Token: 0x0601685B RID: 92251 RVA: 0x005B5E20 File Offset: 0x005B4020
	public int SkinId { get; }

	// Token: 0x0601685C RID: 92252 RVA: 0x005B5E28 File Offset: 0x005B4028
	public CalabashSkinData(int skinId)
	{
		this.SkinId = skinId;
	}

	// Token: 0x17001DDB RID: 7643
	// (get) Token: 0x0601685D RID: 92253 RVA: 0x005B5E37 File Offset: 0x005B4037
	public bool IsEmptyData
	{
		get
		{
			return this.SkinId == 0;
		}
	}

	// Token: 0x17001DDC RID: 7644
	// (get) Token: 0x0601685E RID: 92254 RVA: 0x005B5E44 File Offset: 0x005B4044
	public int? QualityId
	{
		get
		{
			if (this.IsEmptyData)
			{
				return null;
			}
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(this.SkinId);
			if (itemConfigData == null)
			{
				return null;
			}
			return new int?(itemConfigData.QualityId);
		}
	}

	// Token: 0x17001DDD RID: 7645
	// (get) Token: 0x0601685F RID: 92255 RVA: 0x005B5E8C File Offset: 0x005B408C
	public int SortIndex
	{
		get
		{
			if (this.IsEmptyData)
			{
				return 0;
			}
			return SkinConfig.Instance.GetCalabashSkinConfig(this.SkinId).SortIndex;
		}
	}

	// Token: 0x06016860 RID: 92256 RVA: 0x005B5EBB File Offset: 0x005B40BB
	public bool GetIsLock()
	{
		return !this.IsEmptyData && InventoryModel.Instance.GetItemCountByConfigId(this.SkinId, 0) <= 0;
	}

	// Token: 0x06016861 RID: 92257 RVA: 0x005B5EE0 File Offset: 0x005B40E0
	public bool IsCurrentEquipSkinId()
	{
		int currentEquipSkinId = CalabashSkinModel.Instance.GetCurrentEquipSkinId();
		return this.SkinId == currentEquipSkinId;
	}

	// Token: 0x17001DDE RID: 7646
	// (get) Token: 0x06016862 RID: 92258 RVA: 0x005B5F04 File Offset: 0x005B4104
	public string Name
	{
		get
		{
			if (this.IsEmptyData)
			{
				return SkinConfig.Instance.GetDefaultCalabashSkinName();
			}
			return SkinConfig.Instance.GetCalabashSkinConfig(this.SkinId).Name;
		}
	}

	// Token: 0x17001DDF RID: 7647
	// (get) Token: 0x06016863 RID: 92259 RVA: 0x005B5F3C File Offset: 0x005B413C
	public string Description
	{
		get
		{
			if (this.IsEmptyData)
			{
				return SkinConfig.Instance.GetDefaultCalabashSkinDescription();
			}
			return SkinConfig.Instance.GetCalabashSkinConfig(this.SkinId).BgDescription;
		}
	}

	// Token: 0x17001DE0 RID: 7648
	// (get) Token: 0x06016864 RID: 92260 RVA: 0x005B5F74 File Offset: 0x005B4174
	public bool IsNew
	{
		get
		{
			return !this.IsEmptyData && NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.CalabashSkinRedDot, this.SkinId);
		}
	}
}
