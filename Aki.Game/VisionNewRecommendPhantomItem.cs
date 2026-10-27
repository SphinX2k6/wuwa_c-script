using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020024D6 RID: 9430
public class VisionNewRecommendPhantomItem : UiPanelBase
{
	// Token: 0x06012F61 RID: 77665 RVA: 0x004B1C74 File Offset: 0x004AFE74
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUISprite)),
			new ValueTuple<int, Type>(6, typeof(UUITexture)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(9, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(8, new Action(this.OnClickPhantomItem))
		};
	}

	// Token: 0x06012F62 RID: 77666 RVA: 0x004B1D8C File Offset: 0x004AFF8C
	protected override UniTask OnBeforeStartAsync()
	{
		VisionNewRecommendPhantomItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionNewRecommendPhantomItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012F63 RID: 77667 RVA: 0x004B1DCF File Offset: 0x004AFFCF
	protected override void OnStart()
	{
		base.GetItem(4).SetUIActive(false);
	}

	// Token: 0x06012F64 RID: 77668 RVA: 0x004B1DDE File Offset: 0x004AFFDE
	public void Reset()
	{
		base.GetItem(0).SetUIActive(false);
	}

	// Token: 0x06012F65 RID: 77669 RVA: 0x004B1DED File Offset: 0x004AFFED
	[NullableContext(1)]
	public void Update(VisionNewRecommendPhantomItemData data)
	{
		this.CurrentData = data;
		base.GetItem(0).SetUIActive(true);
		this.RefreshQualitySprite();
		this.RefreshSuitElement();
		this.RefreshTextureIcon();
		this.RefreshCostText();
		this.RefreshLevelText();
	}

	// Token: 0x06012F66 RID: 77670 RVA: 0x004B1E24 File Offset: 0x004B0024
	private void RefreshQualitySprite()
	{
		PhantomItem? phantomItemById = PhantomBattleConfig.Instance.GetPhantomItemById(this.CurrentData.PhantomId);
		string phantomQualityBgSprite = PhantomBattleConfig.Instance.GetPhantomQualityBgSprite(phantomItemById.Value.QualityId);
		this.SetSpriteByPath(phantomQualityBgSprite, base.GetSprite(1), false, null, null);
	}

	// Token: 0x06012F67 RID: 77671 RVA: 0x004B1E7C File Offset: 0x004B007C
	private void RefreshSuitElement()
	{
		PhantomFetterGroup fetterGroupById = PhantomBattleConfig.Instance.GetFetterGroupById(this.CurrentData.FetterGroupId);
		this.VisionFetterSuitItem.Update(new PhantomFetterGroup?(fetterGroupById));
	}

	// Token: 0x06012F68 RID: 77672 RVA: 0x004B1EB0 File Offset: 0x004B00B0
	private void RefreshTextureIcon()
	{
		CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(this.CurrentData.PhantomId);
		base.SetTextureByPath(itemConfigData.IconMiddle, base.GetTexture(2), null, null);
	}

	// Token: 0x06012F69 RID: 77673 RVA: 0x004B1EF0 File Offset: 0x004B00F0
	private void RefreshCostText()
	{
		base.GetText(7).SetText(this.CurrentData.Cost.ToString(), true);
	}

	// Token: 0x06012F6A RID: 77674 RVA: 0x004B1F0F File Offset: 0x004B010F
	private void RefreshLevelText()
	{
		base.GetText(9).SetText("+" + this.CurrentData.Level.ToString(), true);
	}

	// Token: 0x06012F6B RID: 77675 RVA: 0x004B1F3C File Offset: 0x004B013C
	private void OnClickPhantomItem()
	{
		if (this.CurrentData == null)
		{
			return;
		}
		int phantomId = this.CurrentData.PhantomId;
		int uniqueId = this.CurrentData.UniqueId;
		if (uniqueId > 0)
		{
			ItemController.Instance.OpenItemTipsByItemUid(uniqueId, phantomId, true, null);
			return;
		}
		ItemController.Instance.OpenItemTipsByItemId(phantomId, true, null);
	}

	// Token: 0x04008EC8 RID: 36552
	[Nullable(2)]
	private VisionNewRecommendPhantomItemData CurrentData;

	// Token: 0x04008EC9 RID: 36553
	[Nullable(2)]
	private VisionFetterSuitItem VisionFetterSuitItem;

	// Token: 0x02008A66 RID: 35430
	private enum EPhantomItem
	{
		// Token: 0x0402CF09 RID: 184073
		Item,
		// Token: 0x0402CF0A RID: 184074
		QualitySprite,
		// Token: 0x0402CF0B RID: 184075
		TextureIcon,
		// Token: 0x0402CF0C RID: 184076
		ElementItem,
		// Token: 0x0402CF0D RID: 184077
		RoleItem,
		// Token: 0x0402CF0E RID: 184078
		RoleLightSprite,
		// Token: 0x0402CF0F RID: 184079
		RoleTexture,
		// Token: 0x0402CF10 RID: 184080
		CostText,
		// Token: 0x0402CF11 RID: 184081
		Button,
		// Token: 0x0402CF12 RID: 184082
		TextLevel
	}
}
