using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x020017DC RID: 6108
[NullableContext(1)]
[Nullable(0)]
public class RoleOrnamentData
{
	// Token: 0x0600EF10 RID: 61200 RVA: 0x004631C6 File Offset: 0x004613C6
	public RoleOrnamentData(int id)
	{
		this.Id = id;
	}

	// Token: 0x0600EF11 RID: 61201 RVA: 0x004631D8 File Offset: 0x004613D8
	public Ornament GetOrnamentConfig()
	{
		return RoleConfig.Instance.GetOrnamentConfig(this.Id).Value;
	}

	// Token: 0x0600EF12 RID: 61202 RVA: 0x004631FD File Offset: 0x004613FD
	public ItemConfig GetItemConfig()
	{
		return InventoryConfig.Instance.GetItemConfigData(this.Id);
	}

	// Token: 0x0600EF13 RID: 61203 RVA: 0x0046320F File Offset: 0x0046140F
	public int GetId()
	{
		return this.Id;
	}

	// Token: 0x0600EF14 RID: 61204 RVA: 0x00463218 File Offset: 0x00461418
	public int[] GetRoleSkinIds()
	{
		return NoLinq.ToArray<int>(this.GetOrnamentConfig().RoleSkinIdsIter());
	}

	// Token: 0x0600EF15 RID: 61205 RVA: 0x00463238 File Offset: 0x00461438
	public int GetGroupId()
	{
		return this.GetOrnamentConfig().OrGroupId;
	}

	// Token: 0x0600EF16 RID: 61206 RVA: 0x00463253 File Offset: 0x00461453
	public string GetName()
	{
		return this.GetItemConfig().Name;
	}

	// Token: 0x0600EF17 RID: 61207 RVA: 0x00463260 File Offset: 0x00461460
	public string GetTitleName()
	{
		return this.GetName();
	}

	// Token: 0x0600EF18 RID: 61208 RVA: 0x00463268 File Offset: 0x00461468
	public string GetTypeDescription()
	{
		return this.GetItemConfig().TypeDescription;
	}

	// Token: 0x0600EF19 RID: 61209 RVA: 0x00463278 File Offset: 0x00461478
	public string GetSubTitle()
	{
		return this.GetOrnamentConfig().ShopPreviewSubTitle;
	}

	// Token: 0x0600EF1A RID: 61210 RVA: 0x00463293 File Offset: 0x00461493
	public string GetBgDescription()
	{
		return this.GetItemConfig().BgDescription ?? "";
	}

	// Token: 0x0600EF1B RID: 61211 RVA: 0x004632A9 File Offset: 0x004614A9
	public int GetQuality()
	{
		return this.GetItemConfig().QualityId;
	}

	// Token: 0x0600EF1C RID: 61212 RVA: 0x004632B6 File Offset: 0x004614B6
	public bool IsOwn()
	{
		return RoleOrnamentModel.Instance.IsOwnOrnament(this.Id);
	}

	// Token: 0x0600EF1D RID: 61213 RVA: 0x004632C8 File Offset: 0x004614C8
	public int GetSortIndex()
	{
		return this.GetItemConfig().SortIndex;
	}

	// Token: 0x0600EF1E RID: 61214 RVA: 0x004632D8 File Offset: 0x004614D8
	public string GetBuyPreviewQualityBgPath()
	{
		return ConfigQualityInfoById.GetConfig(this.GetQuality(), true).Value.RoleSkinQualityBg;
	}

	// Token: 0x0600EF1F RID: 61215 RVA: 0x00463304 File Offset: 0x00461504
	public string GetPreviewTextureInBuyView()
	{
		return this.GetOrnamentConfig().PreviewTextureInBuyView;
	}

	// Token: 0x0600EF20 RID: 61216 RVA: 0x00463320 File Offset: 0x00461520
	public string GetPreviewTextureInPayShop()
	{
		return this.GetOrnamentConfig().PreviewTextureInPayShop;
	}

	// Token: 0x0600EF21 RID: 61217 RVA: 0x0046333C File Offset: 0x0046153C
	public string GetPreviewTextureInPop()
	{
		return this.GetOrnamentConfig().PopPreviewTexture;
	}

	// Token: 0x04008725 RID: 34597
	private readonly int Id;
}
