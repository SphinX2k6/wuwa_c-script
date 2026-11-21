using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001972 RID: 6514
public class VisionAssembleItem : UiPanelBase
{
	// Token: 0x0601012F RID: 65839 RVA: 0x004AF450 File Offset: 0x004AD650
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
			new ValueTuple<int, Type>(8, typeof(UUIItem))
		};
	}

	// Token: 0x06010130 RID: 65840 RVA: 0x004AF530 File Offset: 0x004AD730
	protected override UniTask OnBeforeStartAsync()
	{
		VisionAssembleItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionAssembleItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010131 RID: 65841 RVA: 0x004AF573 File Offset: 0x004AD773
	public void Reset()
	{
		base.GetItem(0).SetUIActive(false);
	}

	// Token: 0x06010132 RID: 65842 RVA: 0x004AF582 File Offset: 0x004AD782
	public void Update(int visionId)
	{
		base.GetItem(0).SetUIActive(true);
		this.RefreshQualitySprite(visionId);
		this.RefreshSuitElement(visionId);
		this.RefreshTextureIcon(visionId);
		this.SetRoleHead(visionId);
		this.RefreshCostText(visionId);
	}

	// Token: 0x06010133 RID: 65843 RVA: 0x004AF5B4 File Offset: 0x004AD7B4
	public void SetRoleHead(int visionId)
	{
		int? phantomEquipOnRoleId = PhantomBattleModel.Instance.GetPhantomEquipOnRoleId(visionId);
		if (phantomEquipOnRoleId == null)
		{
			base.GetItem(4).SetUIActive(false);
			base.GetItem(8).SetUIActive(false);
			return;
		}
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(phantomEquipOnRoleId.Value);
		if (RoleModel.Instance.IsMainRole(roleConfig.Value.Id))
		{
			this.VisionAssembleMainRoleHeadItem.Refresh(visionId);
			base.GetItem(4).SetUIActive(false);
			base.GetItem(8).SetUIActive(true);
			return;
		}
		this.RefreshRoleItem(visionId);
		base.GetItem(4).SetUIActive(true);
		base.GetItem(8).SetUIActive(false);
	}

	// Token: 0x06010134 RID: 65844 RVA: 0x004AF668 File Offset: 0x004AD868
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

	// Token: 0x06010135 RID: 65845 RVA: 0x004AF6D8 File Offset: 0x004AD8D8
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

	// Token: 0x06010136 RID: 65846 RVA: 0x004AF780 File Offset: 0x004AD980
	private void RefreshQualitySprite(int visionId)
	{
		int quality = PhantomBattleModel.Instance.GetPhantomBattleData(visionId).GetQuality();
		string phantomQualityBgSprite = PhantomBattleConfig.Instance.GetPhantomQualityBgSprite(quality);
		this.SetSpriteByPath(phantomQualityBgSprite, base.GetSprite(1), false, null, null);
	}

	// Token: 0x06010137 RID: 65847 RVA: 0x004AF7C4 File Offset: 0x004AD9C4
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

	// Token: 0x06010138 RID: 65848 RVA: 0x004AF81C File Offset: 0x004ADA1C
	private void RefreshSuitElement(int visionId)
	{
		PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(visionId);
		PhantomFetterGroup fetterGroupById = PhantomBattleConfig.Instance.GetFetterGroupById(phantomBattleData.GetFetterGroupId());
		this.VisionFetterSuitItem.Update(new PhantomFetterGroup?(fetterGroupById));
	}

	// Token: 0x06010139 RID: 65849 RVA: 0x004AF858 File Offset: 0x004ADA58
	private void RefreshTextureIcon(int visionId)
	{
		PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(visionId);
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(phantomBattleData.GetConfigId(true));
		base.SetTextureByPath(itemConfigData.IconMiddle, base.GetTexture(2), null, null);
	}

	// Token: 0x0601013A RID: 65850 RVA: 0x004AF8A0 File Offset: 0x004ADAA0
	private void RefreshCostText(int visionId)
	{
		PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(visionId);
		base.GetText(7).SetText(phantomBattleData.GetCost().ToString(), true);
	}

	// Token: 0x04008EAE RID: 36526
	[Nullable(2)]
	private VisionFetterSuitItem VisionFetterSuitItem;

	// Token: 0x04008EAF RID: 36527
	[Nullable(2)]
	private VisionAssembleMainRoleHeadItem VisionAssembleMainRoleHeadItem;

	// Token: 0x02007B8A RID: 31626
	private enum EComponent
	{
		// Token: 0x04028035 RID: 163893
		Item,
		// Token: 0x04028036 RID: 163894
		QualitySprite,
		// Token: 0x04028037 RID: 163895
		TextureIcon,
		// Token: 0x04028038 RID: 163896
		ElementItem,
		// Token: 0x04028039 RID: 163897
		RoleItem,
		// Token: 0x0402803A RID: 163898
		RoleLightSprite,
		// Token: 0x0402803B RID: 163899
		RoleTexture,
		// Token: 0x0402803C RID: 163900
		CostText,
		// Token: 0x0402803D RID: 163901
		UiItem_ItemRoverElement
	}
}
