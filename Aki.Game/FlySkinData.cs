using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Skin;

// Token: 0x02002A1C RID: 10780
[NullableContext(1)]
[Nullable(0)]
public class FlySkinData
{
	// Token: 0x0601660C RID: 91660 RVA: 0x005A9B08 File Offset: 0x005A7D08
	public FlySkinData(int itemId)
	{
		this.ItemId = itemId;
		this.FlySkinConfig = SkinConfig.Instance.GetFlySkinConfig(this.ItemId).Value;
	}

	// Token: 0x0601660D RID: 91661 RVA: 0x005A9B47 File Offset: 0x005A7D47
	[NullableContext(2)]
	public ItemConfig GetItemConfig()
	{
		return InventoryConfig.Instance.GetItemConfigData(this.ItemId);
	}

	// Token: 0x0601660E RID: 91662 RVA: 0x005A9B59 File Offset: 0x005A7D59
	public int GetItemId()
	{
		return this.ItemId;
	}

	// Token: 0x0601660F RID: 91663 RVA: 0x005A9B61 File Offset: 0x005A7D61
	public string GetName()
	{
		return this.GetItemConfig().Name;
	}

	// Token: 0x06016610 RID: 91664 RVA: 0x005A9B6E File Offset: 0x005A7D6E
	public string GetDesc()
	{
		return this.GetItemConfig().BgDescription;
	}

	// Token: 0x06016611 RID: 91665 RVA: 0x005A9B7B File Offset: 0x005A7D7B
	public int GetQuality()
	{
		return this.GetItemConfig().QualityId;
	}

	// Token: 0x06016612 RID: 91666 RVA: 0x005A9B88 File Offset: 0x005A7D88
	public bool IsLocked()
	{
		return this.IsLock;
	}

	// Token: 0x06016613 RID: 91667 RVA: 0x005A9B90 File Offset: 0x005A7D90
	public void UnlockSkin()
	{
		this.IsLock = false;
	}

	// Token: 0x06016614 RID: 91668 RVA: 0x005A9B99 File Offset: 0x005A7D99
	public int GetItemCount()
	{
		return (!this.IsLocked()) ? 1 : 0;
	}

	// Token: 0x06016615 RID: 91669 RVA: 0x005A9BA4 File Offset: 0x005A7DA4
	public FlySkinConfig GetFlySkinConfig()
	{
		return this.FlySkinConfig;
	}

	// Token: 0x06016616 RID: 91670 RVA: 0x005A9BAC File Offset: 0x005A7DAC
	public int GetUiMeshId()
	{
		return this.FlySkinConfig.ModelId;
	}

	// Token: 0x06016617 RID: 91671 RVA: 0x005A9BC8 File Offset: 0x005A7DC8
	public string GetTitleName()
	{
		return this.GetFlySkinConfig().Name;
	}

	// Token: 0x06016618 RID: 91672 RVA: 0x005A9BE4 File Offset: 0x005A7DE4
	public string GetSubTitle()
	{
		return this.GetFlySkinConfig().TypeDescription;
	}

	// Token: 0x06016619 RID: 91673 RVA: 0x005A9C00 File Offset: 0x005A7E00
	public int GetSkinGrade()
	{
		return this.GetFlySkinConfig().SkinGrade;
	}

	// Token: 0x0601661A RID: 91674 RVA: 0x005A9C1C File Offset: 0x005A7E1C
	public string GetPreviewTextureInPayShop()
	{
		return this.GetFlySkinConfig().PreviewTextureInPayShop;
	}

	// Token: 0x0601661B RID: 91675 RVA: 0x005A9C38 File Offset: 0x005A7E38
	public string GetPreviewTextureInBuyView()
	{
		return this.GetFlySkinConfig().PreviewTextureInBuyView;
	}

	// Token: 0x0601661C RID: 91676 RVA: 0x005A9C54 File Offset: 0x005A7E54
	public string GetPreviewTextureInPop()
	{
		return this.GetFlySkinConfig().PreviewTextureInPop;
	}

	// Token: 0x0601661D RID: 91677 RVA: 0x005A9C70 File Offset: 0x005A7E70
	public string GetBuyPreviewQualityBgPath()
	{
		return ConfigQualityInfoById.GetConfig(this.GetQuality(), true).Value.RoleSkinQualityBg;
	}

	// Token: 0x0601661E RID: 91678 RVA: 0x005A9C9C File Offset: 0x005A7E9C
	public string GetObtainFrameColor1()
	{
		return this.GetFlySkinConfig().SkinObtainColor1;
	}

	// Token: 0x0601661F RID: 91679 RVA: 0x005A9CB8 File Offset: 0x005A7EB8
	public string GetObtainFrameColor2()
	{
		return this.GetFlySkinConfig().SkinObtainColor2;
	}

	// Token: 0x06016620 RID: 91680 RVA: 0x005A9CD4 File Offset: 0x005A7ED4
	public string GetTextureInSkinObtainView()
	{
		return this.GetFlySkinConfig().SkinObtainImage;
	}

	// Token: 0x06016621 RID: 91681 RVA: 0x005A9CEF File Offset: 0x005A7EEF
	public bool GetHasNewFlag()
	{
		return NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.RoleSkinRedDot, this.GetItemId());
	}

	// Token: 0x0400A68A RID: 42634
	public readonly int ItemId;

	// Token: 0x0400A68B RID: 42635
	private readonly FlySkinConfig FlySkinConfig;

	// Token: 0x0400A68C RID: 42636
	private bool IsLock = true;
}
