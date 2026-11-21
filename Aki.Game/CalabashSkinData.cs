using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Skin;

// Token: 0x02001FB9 RID: 8121
[NullableContext(1)]
[Nullable(0)]
public class CalabashSkinData
{
	// Token: 0x17001E32 RID: 7730
	// (get) Token: 0x0601427C RID: 82556 RVA: 0x005E1F88 File Offset: 0x005E0188
	public int SkinId { get; }

	// Token: 0x0601427D RID: 82557 RVA: 0x005E1F90 File Offset: 0x005E0190
	public CalabashSkinData(int skinId)
	{
		this.SkinId = skinId;
	}

	// Token: 0x17001E33 RID: 7731
	// (get) Token: 0x0601427E RID: 82558 RVA: 0x005E1F9F File Offset: 0x005E019F
	public bool IsEmptyData
	{
		get
		{
			return this.SkinId == 0;
		}
	}

	// Token: 0x17001E34 RID: 7732
	// (get) Token: 0x0601427F RID: 82559 RVA: 0x005E1FAC File Offset: 0x005E01AC
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

	// Token: 0x17001E35 RID: 7733
	// (get) Token: 0x06014280 RID: 82560 RVA: 0x005E1FF4 File Offset: 0x005E01F4
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

	// Token: 0x06014281 RID: 82561 RVA: 0x005E2023 File Offset: 0x005E0223
	public bool GetIsLock()
	{
		return !this.IsEmptyData && InventoryModel.Instance.GetItemCountByConfigId(this.SkinId, 0) <= 0;
	}

	// Token: 0x06014282 RID: 82562 RVA: 0x005E2048 File Offset: 0x005E0248
	public bool IsCurrentEquipSkinId()
	{
		int currentEquipSkinId = CalabashSkinModel.Instance.GetCurrentEquipSkinId();
		return this.SkinId == currentEquipSkinId;
	}

	// Token: 0x17001E36 RID: 7734
	// (get) Token: 0x06014283 RID: 82563 RVA: 0x005E206C File Offset: 0x005E026C
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

	// Token: 0x17001E37 RID: 7735
	// (get) Token: 0x06014284 RID: 82564 RVA: 0x005E20A4 File Offset: 0x005E02A4
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

	// Token: 0x17001E38 RID: 7736
	// (get) Token: 0x06014285 RID: 82565 RVA: 0x005E20DC File Offset: 0x005E02DC
	public bool IsNew
	{
		get
		{
			return !this.IsEmptyData && NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.CalabashSkinRedDot, this.SkinId);
		}
	}
}
