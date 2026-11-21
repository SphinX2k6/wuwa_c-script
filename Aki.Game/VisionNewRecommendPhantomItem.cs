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

// Token: 0x020019BD RID: 6589
public class VisionNewRecommendPhantomItem : UiPanelBase
{
	// Token: 0x06010420 RID: 66592 RVA: 0x004BF874 File Offset: 0x004BDA74
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

	// Token: 0x06010421 RID: 66593 RVA: 0x004BF98C File Offset: 0x004BDB8C
	protected override UniTask OnBeforeStartAsync()
	{
		VisionNewRecommendPhantomItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionNewRecommendPhantomItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010422 RID: 66594 RVA: 0x004BF9CF File Offset: 0x004BDBCF
	protected override void OnStart()
	{
		base.GetItem(4).SetUIActive(false);
	}

	// Token: 0x06010423 RID: 66595 RVA: 0x004BF9DE File Offset: 0x004BDBDE
	public void Reset()
	{
		base.GetItem(0).SetUIActive(false);
	}

	// Token: 0x06010424 RID: 66596 RVA: 0x004BF9ED File Offset: 0x004BDBED
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

	// Token: 0x06010425 RID: 66597 RVA: 0x004BFA24 File Offset: 0x004BDC24
	private void RefreshQualitySprite()
	{
		PhantomItem? phantomItemById = PhantomBattleConfig.Instance.GetPhantomItemById(this.CurrentData.PhantomId);
		string phantomQualityBgSprite = PhantomBattleConfig.Instance.GetPhantomQualityBgSprite(phantomItemById.Value.QualityId);
		this.SetSpriteByPath(phantomQualityBgSprite, base.GetSprite(1), false, null, null);
	}

	// Token: 0x06010426 RID: 66598 RVA: 0x004BFA7C File Offset: 0x004BDC7C
	private void RefreshSuitElement()
	{
		PhantomFetterGroup fetterGroupById = PhantomBattleConfig.Instance.GetFetterGroupById(this.CurrentData.FetterGroupId);
		this.VisionFetterSuitItem.Update(new PhantomFetterGroup?(fetterGroupById));
	}

	// Token: 0x06010427 RID: 66599 RVA: 0x004BFAB0 File Offset: 0x004BDCB0
	private void RefreshTextureIcon()
	{
		CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(this.CurrentData.PhantomId);
		base.SetTextureByPath(itemConfigData.IconMiddle, base.GetTexture(2), null, null);
	}

	// Token: 0x06010428 RID: 66600 RVA: 0x004BFAF0 File Offset: 0x004BDCF0
	private void RefreshCostText()
	{
		base.GetText(7).SetText(this.CurrentData.Cost.ToString(), true);
	}

	// Token: 0x06010429 RID: 66601 RVA: 0x004BFB0F File Offset: 0x004BDD0F
	private void RefreshLevelText()
	{
		base.GetText(9).SetText("+" + this.CurrentData.Level.ToString(), true);
	}

	// Token: 0x0601042A RID: 66602 RVA: 0x004BFB3C File Offset: 0x004BDD3C
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
		ItemController.Instance.OpenItemTipsByItemId(phantomId, true, null, false);
	}

	// Token: 0x04009012 RID: 36882
	[Nullable(2)]
	private VisionNewRecommendPhantomItemData CurrentData;

	// Token: 0x04009013 RID: 36883
	[Nullable(2)]
	private VisionFetterSuitItem VisionFetterSuitItem;

	// Token: 0x02007BEF RID: 31727
	private enum EPhantomItem
	{
		// Token: 0x04028227 RID: 164391
		Item,
		// Token: 0x04028228 RID: 164392
		QualitySprite,
		// Token: 0x04028229 RID: 164393
		TextureIcon,
		// Token: 0x0402822A RID: 164394
		ElementItem,
		// Token: 0x0402822B RID: 164395
		RoleItem,
		// Token: 0x0402822C RID: 164396
		RoleLightSprite,
		// Token: 0x0402822D RID: 164397
		RoleTexture,
		// Token: 0x0402822E RID: 164398
		CostText,
		// Token: 0x0402822F RID: 164399
		Button,
		// Token: 0x04028230 RID: 164400
		TextLevel
	}
}
