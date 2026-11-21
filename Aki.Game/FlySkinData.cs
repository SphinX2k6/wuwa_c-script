using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Skin;

// Token: 0x02001F97 RID: 8087
[NullableContext(1)]
[Nullable(0)]
public class FlySkinData
{
	// Token: 0x06014012 RID: 81938 RVA: 0x005D4AE4 File Offset: 0x005D2CE4
	public FlySkinData(int itemId)
	{
		this.ItemId = itemId;
		this.FlySkinConfig = SkinConfig.Instance.GetFlySkinConfig(this.ItemId).Value;
	}

	// Token: 0x06014013 RID: 81939 RVA: 0x005D4B23 File Offset: 0x005D2D23
	[NullableContext(2)]
	public ItemConfig GetItemConfig()
	{
		return InventoryConfig.Instance.GetItemConfigData(this.ItemId);
	}

	// Token: 0x06014014 RID: 81940 RVA: 0x005D4B35 File Offset: 0x005D2D35
	public int GetItemId()
	{
		return this.ItemId;
	}

	// Token: 0x06014015 RID: 81941 RVA: 0x005D4B3D File Offset: 0x005D2D3D
	public string GetName()
	{
		return this.GetItemConfig().Name;
	}

	// Token: 0x06014016 RID: 81942 RVA: 0x005D4B4A File Offset: 0x005D2D4A
	public string GetDesc()
	{
		return this.GetItemConfig().BgDescription;
	}

	// Token: 0x06014017 RID: 81943 RVA: 0x005D4B57 File Offset: 0x005D2D57
	public int GetQuality()
	{
		return this.GetItemConfig().QualityId;
	}

	// Token: 0x06014018 RID: 81944 RVA: 0x005D4B64 File Offset: 0x005D2D64
	public bool IsLocked()
	{
		return this.IsLock;
	}

	// Token: 0x06014019 RID: 81945 RVA: 0x005D4B6C File Offset: 0x005D2D6C
	public void UnlockSkin()
	{
		this.IsLock = false;
	}

	// Token: 0x0601401A RID: 81946 RVA: 0x005D4B75 File Offset: 0x005D2D75
	public int GetItemCount()
	{
		return (!this.IsLocked()) ? 1 : 0;
	}

	// Token: 0x0601401B RID: 81947 RVA: 0x005D4B80 File Offset: 0x005D2D80
	public FlySkinConfig GetFlySkinConfig()
	{
		return this.FlySkinConfig;
	}

	// Token: 0x0601401C RID: 81948 RVA: 0x005D4B88 File Offset: 0x005D2D88
	public int GetUiMeshId()
	{
		return this.FlySkinConfig.ModelId;
	}

	// Token: 0x0601401D RID: 81949 RVA: 0x005D4BA4 File Offset: 0x005D2DA4
	public string GetTitleName()
	{
		return this.GetFlySkinConfig().Name;
	}

	// Token: 0x0601401E RID: 81950 RVA: 0x005D4BC0 File Offset: 0x005D2DC0
	public string GetSubTitle()
	{
		return this.GetFlySkinConfig().TypeDescription;
	}

	// Token: 0x0601401F RID: 81951 RVA: 0x005D4BDC File Offset: 0x005D2DDC
	public int GetSkinGrade()
	{
		return this.GetFlySkinConfig().SkinGrade;
	}

	// Token: 0x06014020 RID: 81952 RVA: 0x005D4BF8 File Offset: 0x005D2DF8
	public string GetPreviewTextureInPayShop()
	{
		return this.GetFlySkinConfig().PreviewTextureInPayShop;
	}

	// Token: 0x06014021 RID: 81953 RVA: 0x005D4C14 File Offset: 0x005D2E14
	public string GetPreviewTextureInBuyView()
	{
		return this.GetFlySkinConfig().PreviewTextureInBuyView;
	}

	// Token: 0x06014022 RID: 81954 RVA: 0x005D4C30 File Offset: 0x005D2E30
	public string GetPreviewTextureInPop()
	{
		return this.GetFlySkinConfig().PreviewTextureInPop;
	}

	// Token: 0x06014023 RID: 81955 RVA: 0x005D4C4C File Offset: 0x005D2E4C
	public string GetBuyPreviewQualityBgPath()
	{
		return ConfigQualityInfoById.GetConfig(this.GetQuality(), true).Value.RoleSkinQualityBg;
	}

	// Token: 0x06014024 RID: 81956 RVA: 0x005D4C78 File Offset: 0x005D2E78
	public string GetObtainFrameColor1()
	{
		return this.GetFlySkinConfig().SkinObtainColor1;
	}

	// Token: 0x06014025 RID: 81957 RVA: 0x005D4C94 File Offset: 0x005D2E94
	public string GetObtainFrameColor2()
	{
		return this.GetFlySkinConfig().SkinObtainColor2;
	}

	// Token: 0x06014026 RID: 81958 RVA: 0x005D4CB0 File Offset: 0x005D2EB0
	public string GetTextureInSkinObtainView()
	{
		return this.GetFlySkinConfig().SkinObtainImage;
	}

	// Token: 0x06014027 RID: 81959 RVA: 0x005D4CCB File Offset: 0x005D2ECB
	public bool GetHasNewFlag()
	{
		return NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.RoleSkinRedDot, this.GetItemId());
	}

	// Token: 0x0400AA73 RID: 43635
	public readonly int ItemId;

	// Token: 0x0400AA74 RID: 43636
	private readonly FlySkinConfig FlySkinConfig;

	// Token: 0x0400AA75 RID: 43637
	private bool IsLock = true;
}
