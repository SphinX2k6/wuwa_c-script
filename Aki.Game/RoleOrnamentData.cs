using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x020022F8 RID: 8952
[NullableContext(1)]
[Nullable(0)]
public class RoleOrnamentData
{
	// Token: 0x06011A78 RID: 72312 RVA: 0x004564FA File Offset: 0x004546FA
	public RoleOrnamentData(int id)
	{
		this.Id = id;
	}

	// Token: 0x06011A79 RID: 72313 RVA: 0x0045650C File Offset: 0x0045470C
	public Ornament GetOrnamentConfig()
	{
		return RoleConfig.Instance.GetOrnamentConfig(this.Id).Value;
	}

	// Token: 0x06011A7A RID: 72314 RVA: 0x00456531 File Offset: 0x00454731
	public ItemConfig GetItemConfig()
	{
		return InventoryConfig.Instance.GetItemConfigData(this.Id);
	}

	// Token: 0x06011A7B RID: 72315 RVA: 0x00456543 File Offset: 0x00454743
	public int GetId()
	{
		return this.Id;
	}

	// Token: 0x06011A7C RID: 72316 RVA: 0x0045654C File Offset: 0x0045474C
	public int[] GetRoleSkinIds()
	{
		return this.GetOrnamentConfig().RoleSkinIdsIter().ToArray<int>();
	}

	// Token: 0x06011A7D RID: 72317 RVA: 0x0045656C File Offset: 0x0045476C
	public int GetGroupId()
	{
		return this.GetOrnamentConfig().OrGroupId;
	}

	// Token: 0x06011A7E RID: 72318 RVA: 0x00456587 File Offset: 0x00454787
	public string GetName()
	{
		return this.GetItemConfig().Name;
	}

	// Token: 0x06011A7F RID: 72319 RVA: 0x00456594 File Offset: 0x00454794
	public string GetTitleName()
	{
		return this.GetName();
	}

	// Token: 0x06011A80 RID: 72320 RVA: 0x0045659C File Offset: 0x0045479C
	public string GetTypeDescription()
	{
		return this.GetItemConfig().TypeDescription;
	}

	// Token: 0x06011A81 RID: 72321 RVA: 0x004565AC File Offset: 0x004547AC
	public string GetSubTitle()
	{
		return this.GetOrnamentConfig().ShopPreviewSubTitle;
	}

	// Token: 0x06011A82 RID: 72322 RVA: 0x004565C7 File Offset: 0x004547C7
	public string GetBgDescription()
	{
		return this.GetItemConfig().BgDescription ?? "";
	}

	// Token: 0x06011A83 RID: 72323 RVA: 0x004565DD File Offset: 0x004547DD
	public int GetQuality()
	{
		return this.GetItemConfig().QualityId;
	}

	// Token: 0x06011A84 RID: 72324 RVA: 0x004565EA File Offset: 0x004547EA
	public bool IsOwn()
	{
		return RoleOrnamentModel.Instance.IsOwnOrnament(this.Id);
	}

	// Token: 0x06011A85 RID: 72325 RVA: 0x004565FC File Offset: 0x004547FC
	public int GetSortIndex()
	{
		return this.GetItemConfig().SortIndex;
	}

	// Token: 0x06011A86 RID: 72326 RVA: 0x0045660C File Offset: 0x0045480C
	public string GetBuyPreviewQualityBgPath()
	{
		return ConfigQualityInfoById.GetConfig(this.GetQuality(), true).Value.RoleSkinQualityBg;
	}

	// Token: 0x06011A87 RID: 72327 RVA: 0x00456638 File Offset: 0x00454838
	public string GetPreviewTextureInBuyView()
	{
		return this.GetOrnamentConfig().PreviewTextureInBuyView;
	}

	// Token: 0x06011A88 RID: 72328 RVA: 0x00456654 File Offset: 0x00454854
	public string GetPreviewTextureInPayShop()
	{
		return this.GetOrnamentConfig().PreviewTextureInPayShop;
	}

	// Token: 0x06011A89 RID: 72329 RVA: 0x00456670 File Offset: 0x00454870
	public string GetPreviewTextureInPop()
	{
		return this.GetOrnamentConfig().PopPreviewTexture;
	}

	// Token: 0x040085E7 RID: 34279
	private readonly int Id;
}
