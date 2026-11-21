using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Skin;

// Token: 0x02001F99 RID: 8089
[NullableContext(1)]
[Nullable(0)]
public class MotorSkinData
{
	// Token: 0x06014038 RID: 81976 RVA: 0x005D4E5C File Offset: 0x005D305C
	public MotorSkinData(int itemId)
	{
		this.ItemId = itemId;
		this.MotorSkinShow = SkinConfig.Instance.GetMotorSkinShowConfig(this.ItemId);
	}

	// Token: 0x06014039 RID: 81977 RVA: 0x005D4E84 File Offset: 0x005D3084
	public string GetName()
	{
		return ((this.MotorSkinShow != null) ? this.MotorSkinShow.GetValueOrDefault().Name : null) ?? "";
	}

	// Token: 0x0601403A RID: 81978 RVA: 0x005D4EB9 File Offset: 0x005D30B9
	public int GetItemId()
	{
		return this.ItemId;
	}

	// Token: 0x0601403B RID: 81979 RVA: 0x005D4EC1 File Offset: 0x005D30C1
	public int GetQualityA()
	{
		return 1;
	}

	// Token: 0x0601403C RID: 81980 RVA: 0x005D4EC4 File Offset: 0x005D30C4
	public int GetQualityB()
	{
		return 1;
	}

	// Token: 0x0601403D RID: 81981 RVA: 0x005D4EC7 File Offset: 0x005D30C7
	public MotorSkinShow? GetMotorSkinShow()
	{
		return this.MotorSkinShow;
	}

	// Token: 0x0601403E RID: 81982 RVA: 0x005D4ED0 File Offset: 0x005D30D0
	public string GetPreviewTextureInPayShop()
	{
		return ((this.MotorSkinShow != null) ? this.MotorSkinShow.GetValueOrDefault().Icon : null) ?? "";
	}

	// Token: 0x0601403F RID: 81983 RVA: 0x005D4F05 File Offset: 0x005D3105
	public bool GetHasNewFlag()
	{
		return NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.RoleSkinRedDot, this.GetItemId());
	}

	// Token: 0x0400AA7A RID: 43642
	public readonly int ItemId;

	// Token: 0x0400AA7B RID: 43643
	private readonly MotorSkinShow? MotorSkinShow;
}
