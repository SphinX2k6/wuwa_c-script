using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Skin;

// Token: 0x02002A1E RID: 10782
[NullableContext(1)]
[Nullable(0)]
public class MotorSkinData
{
	// Token: 0x06016632 RID: 91698 RVA: 0x005A9E80 File Offset: 0x005A8080
	public MotorSkinData(int itemId)
	{
		this.ItemId = itemId;
		this.MotorSkinShow = SkinConfig.Instance.GetMotorSkinShowConfig(this.ItemId);
	}

	// Token: 0x06016633 RID: 91699 RVA: 0x005A9EA8 File Offset: 0x005A80A8
	public string GetName()
	{
		return ((this.MotorSkinShow != null) ? this.MotorSkinShow.GetValueOrDefault().Name : null) ?? "";
	}

	// Token: 0x06016634 RID: 91700 RVA: 0x005A9EDD File Offset: 0x005A80DD
	public int GetItemId()
	{
		return this.ItemId;
	}

	// Token: 0x06016635 RID: 91701 RVA: 0x005A9EE5 File Offset: 0x005A80E5
	public int GetQualityA()
	{
		return 1;
	}

	// Token: 0x06016636 RID: 91702 RVA: 0x005A9EE8 File Offset: 0x005A80E8
	public int GetQualityB()
	{
		return 1;
	}

	// Token: 0x06016637 RID: 91703 RVA: 0x005A9EEB File Offset: 0x005A80EB
	public MotorSkinShow? GetMotorSkinShow()
	{
		return this.MotorSkinShow;
	}

	// Token: 0x06016638 RID: 91704 RVA: 0x005A9EF4 File Offset: 0x005A80F4
	public string GetPreviewTextureInPayShop()
	{
		return ((this.MotorSkinShow != null) ? this.MotorSkinShow.GetValueOrDefault().Icon : null) ?? "";
	}

	// Token: 0x06016639 RID: 91705 RVA: 0x005A9F29 File Offset: 0x005A8129
	public bool GetHasNewFlag()
	{
		return NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.RoleSkinRedDot, this.GetItemId());
	}

	// Token: 0x0400A691 RID: 42641
	public readonly int ItemId;

	// Token: 0x0400A692 RID: 42642
	private readonly MotorSkinShow? MotorSkinShow;
}
