using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Skin;

// Token: 0x02001FCA RID: 8138
[NullableContext(1)]
[Nullable(0)]
public class FlySkinGridData
{
	// Token: 0x17001E48 RID: 7752
	// (get) Token: 0x06014312 RID: 82706 RVA: 0x005E3A69 File Offset: 0x005E1C69
	public bool IsEmptyData
	{
		get
		{
			return this.SkinId == 0;
		}
	}

	// Token: 0x06014313 RID: 82707 RVA: 0x005E3A74 File Offset: 0x005E1C74
	public FlySkinGridData(int skinId, int roleDataId, EFlySkinType skinType, FlySkinConfig? skinConfig = null)
	{
		this.SkinId = skinId;
		this.RoleDataId = roleDataId;
		this.SkinType = skinType;
		this.SkinConfig = skinConfig;
	}

	// Token: 0x06014314 RID: 82708 RVA: 0x005E3A99 File Offset: 0x005E1C99
	public bool GetIsLock()
	{
		return !this.IsEmptyData && InventoryModel.Instance.GetItemCountByConfigId(this.SkinId, 0) <= 0;
	}

	// Token: 0x06014315 RID: 82709 RVA: 0x005E3ABC File Offset: 0x005E1CBC
	public bool IsCurrentEquipSkinId()
	{
		return FlySkinModel.Instance.GetRoleEquipFlySkinId(this.RoleDataId, this.SkinType) == this.SkinId;
	}

	// Token: 0x06014316 RID: 82710 RVA: 0x005E3ADC File Offset: 0x005E1CDC
	public string GetName()
	{
		if (this.IsEmptyData)
		{
			return CSharpScript.Game.Module.Skin.SkinConfig.Instance.GetDefaultFlySkinName(this.SkinType);
		}
		return this.SkinConfig.Value.Name;
	}

	// Token: 0x06014317 RID: 82711 RVA: 0x005E3B18 File Offset: 0x005E1D18
	public string GetTypeDescription()
	{
		if (this.IsEmptyData)
		{
			return CSharpScript.Game.Module.Skin.SkinConfig.Instance.GetDefaultFlySkinTypeDescription(this.SkinType);
		}
		return this.SkinConfig.Value.TypeDescription;
	}

	// Token: 0x06014318 RID: 82712 RVA: 0x005E3B54 File Offset: 0x005E1D54
	public string GetDescription()
	{
		if (this.IsEmptyData)
		{
			return CSharpScript.Game.Module.Skin.SkinConfig.Instance.GetDefaultFlySkinDescription(this.SkinType);
		}
		return this.SkinConfig.Value.BgDescription;
	}

	// Token: 0x06014319 RID: 82713 RVA: 0x005E3B90 File Offset: 0x005E1D90
	public int GetModelId()
	{
		if (this.IsEmptyData)
		{
			return CSharpScript.Game.Module.Skin.SkinConfig.Instance.GetDefaultFlySkinModelId(this.SkinType);
		}
		return this.SkinConfig.Value.ModelId;
	}

	// Token: 0x0601431A RID: 82714 RVA: 0x005E3BCC File Offset: 0x005E1DCC
	public string GetStandAnimPath()
	{
		if (this.IsEmptyData)
		{
			return CSharpScript.Game.Module.Skin.SkinConfig.Instance.GetDefaultFlySkinStandAnimPath(this.SkinType);
		}
		return this.SkinConfig.Value.StandAnim;
	}

	// Token: 0x0601431B RID: 82715 RVA: 0x005E3C05 File Offset: 0x005E1E05
	public bool GetIsNew()
	{
		return !this.IsEmptyData && NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.FlySkinRedDot, this.SkinId);
	}

	// Token: 0x0400AB7C RID: 43900
	public readonly int SkinId;

	// Token: 0x0400AB7D RID: 43901
	public readonly int RoleDataId;

	// Token: 0x0400AB7E RID: 43902
	public readonly EFlySkinType SkinType;

	// Token: 0x0400AB7F RID: 43903
	public readonly FlySkinConfig? SkinConfig;
}
