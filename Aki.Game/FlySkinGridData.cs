using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Skin;

// Token: 0x02002A4F RID: 10831
[NullableContext(1)]
[Nullable(0)]
public class FlySkinGridData
{
	// Token: 0x17001DF0 RID: 7664
	// (get) Token: 0x060168F1 RID: 92401 RVA: 0x005B7925 File Offset: 0x005B5B25
	public bool IsEmptyData
	{
		get
		{
			return this.SkinId == 0;
		}
	}

	// Token: 0x060168F2 RID: 92402 RVA: 0x005B7930 File Offset: 0x005B5B30
	public FlySkinGridData(int skinId, int roleDataId, EFlySkinType skinType, FlySkinConfig? skinConfig = null)
	{
		this.SkinId = skinId;
		this.RoleDataId = roleDataId;
		this.SkinType = skinType;
		this.SkinConfig = skinConfig;
	}

	// Token: 0x060168F3 RID: 92403 RVA: 0x005B7955 File Offset: 0x005B5B55
	public bool GetIsLock()
	{
		return !this.IsEmptyData && InventoryModel.Instance.GetItemCountByConfigId(this.SkinId, 0) <= 0;
	}

	// Token: 0x060168F4 RID: 92404 RVA: 0x005B7978 File Offset: 0x005B5B78
	public bool IsCurrentEquipSkinId()
	{
		return FlySkinModel.Instance.GetRoleEquipFlySkinId(this.RoleDataId, this.SkinType) == this.SkinId;
	}

	// Token: 0x060168F5 RID: 92405 RVA: 0x005B7998 File Offset: 0x005B5B98
	public string GetName()
	{
		if (this.IsEmptyData)
		{
			return CSharpScript.Game.Module.Skin.SkinConfig.Instance.GetDefaultFlySkinName(this.SkinType);
		}
		return this.SkinConfig.Value.Name;
	}

	// Token: 0x060168F6 RID: 92406 RVA: 0x005B79D4 File Offset: 0x005B5BD4
	public string GetTypeDescription()
	{
		if (this.IsEmptyData)
		{
			return CSharpScript.Game.Module.Skin.SkinConfig.Instance.GetDefaultFlySkinTypeDescription(this.SkinType);
		}
		return this.SkinConfig.Value.TypeDescription;
	}

	// Token: 0x060168F7 RID: 92407 RVA: 0x005B7A10 File Offset: 0x005B5C10
	public string GetDescription()
	{
		if (this.IsEmptyData)
		{
			return CSharpScript.Game.Module.Skin.SkinConfig.Instance.GetDefaultFlySkinDescription(this.SkinType);
		}
		return this.SkinConfig.Value.BgDescription;
	}

	// Token: 0x060168F8 RID: 92408 RVA: 0x005B7A4C File Offset: 0x005B5C4C
	public int GetModelId()
	{
		if (this.IsEmptyData)
		{
			return CSharpScript.Game.Module.Skin.SkinConfig.Instance.GetDefaultFlySkinModelId(this.SkinType);
		}
		return this.SkinConfig.Value.ModelId;
	}

	// Token: 0x060168F9 RID: 92409 RVA: 0x005B7A88 File Offset: 0x005B5C88
	public string GetStandAnimPath()
	{
		if (this.IsEmptyData)
		{
			return CSharpScript.Game.Module.Skin.SkinConfig.Instance.GetDefaultFlySkinStandAnimPath(this.SkinType);
		}
		return this.SkinConfig.Value.StandAnim;
	}

	// Token: 0x060168FA RID: 92410 RVA: 0x005B7AC1 File Offset: 0x005B5CC1
	public bool GetIsNew()
	{
		return !this.IsEmptyData && NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.FlySkinRedDot, this.SkinId);
	}

	// Token: 0x0400A778 RID: 42872
	public readonly int SkinId;

	// Token: 0x0400A779 RID: 42873
	public readonly int RoleDataId;

	// Token: 0x0400A77A RID: 42874
	public readonly EFlySkinType SkinType;

	// Token: 0x0400A77B RID: 42875
	public readonly FlySkinConfig? SkinConfig;
}
