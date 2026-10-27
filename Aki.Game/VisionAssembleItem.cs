using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200248C RID: 9356
public class VisionAssembleItem : UiPanelBase
{
	// Token: 0x06012C76 RID: 76918 RVA: 0x004A1CE8 File Offset: 0x0049FEE8
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
			new ValueTuple<int, Type>(7, typeof(UUIText))
		};
	}

	// Token: 0x06012C77 RID: 76919 RVA: 0x004A1DB0 File Offset: 0x0049FFB0
	protected override UniTask OnBeforeStartAsync()
	{
		VisionAssembleItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionAssembleItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012C78 RID: 76920 RVA: 0x004A1DF3 File Offset: 0x0049FFF3
	public void Reset()
	{
		base.GetItem(0).SetUIActive(false);
	}

	// Token: 0x06012C79 RID: 76921 RVA: 0x004A1E02 File Offset: 0x004A0002
	public void Update(int visionId)
	{
		base.GetItem(0).SetUIActive(true);
		this.RefreshQualitySprite(visionId);
		this.RefreshSuitElement(visionId);
		this.RefreshTextureIcon(visionId);
		this.RefreshRoleItem(visionId);
		this.RefreshCostText(visionId);
	}

	// Token: 0x06012C7A RID: 76922 RVA: 0x004A1E34 File Offset: 0x004A0034
	private void RefreshRoleItem(int visionId)
	{
		int? phantomEquipOnRoleId = PhantomBattleModel.Instance.GetPhantomEquipOnRoleId(visionId);
		if (phantomEquipOnRoleId == null)
		{
			base.GetItem(4).SetUIActive(false);
			return;
		}
		if (RoleModel.Instance.GetRoleDataById(phantomEquipOnRoleId.Value, true) == null)
		{
			base.GetItem(4).SetUIActive(false);
			return;
		}
		base.GetItem(4).SetUIActive(true);
		this.RefreshLightSprite(visionId);
		this.RefreshRoleTexture(visionId);
	}

	// Token: 0x06012C7B RID: 76923 RVA: 0x004A1EA4 File Offset: 0x004A00A4
	private void RefreshRoleTexture(int visionId)
	{
		UUITexture roleTexture = base.GetTexture(6);
		int? phantomEquipOnRoleId = PhantomBattleModel.Instance.GetPhantomEquipOnRoleId(visionId);
		RoleDataBase roleDataBase = (phantomEquipOnRoleId != null) ? RoleModel.Instance.GetRoleDataById(phantomEquipOnRoleId.Value, true) : null;
		if (roleDataBase == null)
		{
			roleTexture.SetUIActive(false);
			return;
		}
		int roleSkinId = roleDataBase.GetRoleSkinId();
		string card = SkinConfig.Instance.GetRoleSkinConfig(roleSkinId).Value.Card;
		base.SetRoleSkinIcon(card, roleTexture, roleSkinId, null, delegate(bool _)
		{
			roleTexture.SetUIActive(true);
		});
	}

	// Token: 0x06012C7C RID: 76924 RVA: 0x004A1F4C File Offset: 0x004A014C
	private void RefreshQualitySprite(int visionId)
	{
		int quality = PhantomBattleModel.Instance.GetPhantomBattleData(visionId).GetQuality();
		string phantomQualityBgSprite = PhantomBattleConfig.Instance.GetPhantomQualityBgSprite(quality);
		this.SetSpriteByPath(phantomQualityBgSprite, base.GetSprite(1), false, null, null);
	}

	// Token: 0x06012C7D RID: 76925 RVA: 0x004A1F90 File Offset: 0x004A0190
	private void RefreshLightSprite(int visionId)
	{
		string resourcePath;
		if (PhantomBattleModel.Instance.CheckPhantomIsMain(visionId))
		{
			resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_ItemHeadBg1");
		}
		else
		{
			resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_ItemHeadBg2");
		}
		this.SetSpriteByPath(resourcePath, base.GetSprite(5), false, null, null);
	}

	// Token: 0x06012C7E RID: 76926 RVA: 0x004A1FE8 File Offset: 0x004A01E8
	private void RefreshSuitElement(int visionId)
	{
		PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(visionId);
		PhantomFetterGroup fetterGroupById = PhantomBattleConfig.Instance.GetFetterGroupById(phantomBattleData.GetFetterGroupId());
		this.VisionFetterSuitItem.Update(new PhantomFetterGroup?(fetterGroupById));
	}

	// Token: 0x06012C7F RID: 76927 RVA: 0x004A2024 File Offset: 0x004A0224
	private void RefreshTextureIcon(int visionId)
	{
		PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(visionId);
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(phantomBattleData.GetConfigId(true));
		base.SetTextureByPath(itemConfigData.IconMiddle, base.GetTexture(2), null, null);
	}

	// Token: 0x06012C80 RID: 76928 RVA: 0x004A206C File Offset: 0x004A026C
	private void RefreshCostText(int visionId)
	{
		PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(visionId);
		base.GetText(7).SetText(phantomBattleData.GetCost().ToString(), true);
	}

	// Token: 0x04008D67 RID: 36199
	[Nullable(2)]
	private VisionFetterSuitItem VisionFetterSuitItem;

	// Token: 0x02008A03 RID: 35331
	private enum EComponent
	{
		// Token: 0x0402CD1F RID: 183583
		Item,
		// Token: 0x0402CD20 RID: 183584
		QualitySprite,
		// Token: 0x0402CD21 RID: 183585
		TextureIcon,
		// Token: 0x0402CD22 RID: 183586
		ElementItem,
		// Token: 0x0402CD23 RID: 183587
		RoleItem,
		// Token: 0x0402CD24 RID: 183588
		RoleLightSprite,
		// Token: 0x0402CD25 RID: 183589
		RoleTexture,
		// Token: 0x0402CD26 RID: 183590
		CostText
	}
}
