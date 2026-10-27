using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001CA0 RID: 7328
public class GachaShareOnePanel : UiPanelBase
{
	// Token: 0x0600DD4D RID: 56653 RVA: 0x0033C278 File Offset: 0x0033A478
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUITexture)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUISprite))
		};
	}

	// Token: 0x0600DD4E RID: 56654 RVA: 0x0033C340 File Offset: 0x0033A540
	protected override void OnStart()
	{
		this.StarLayout = new SimpleGenericLayout(base.GetHorizontalLayout(1));
		this.Refresh(this.OpenParam as GachaResult);
	}

	// Token: 0x0600DD4F RID: 56655 RVA: 0x0033C368 File Offset: 0x0033A568
	[NullableContext(1)]
	public void Refresh(GachaResult gachaResult)
	{
		if (gachaResult == null || gachaResult.Proto_GachaReward == null)
		{
			return;
		}
		int itemId = gachaResult.Proto_GachaReward.ItemId;
		GaChaShare? config = ConfigGaChaShareById.GetConfig(itemId, true);
		if (config == null)
		{
			return;
		}
		base.SetTextureByPath(config.Value.SharePic, base.GetTexture(0), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), config.Value.Desc, Array.Empty<object>());
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
		if (itemConfigData == null)
		{
			return;
		}
		this.StarLayout.RebuildLayout(itemConfigData.QualityId);
		base.GetText(3).ShowTextNew(itemConfigData.Name);
		UUITexture texture = base.GetTexture(5);
		UUISprite sprite = base.GetSprite(7);
		InventoryDefine.EItemDataType itemIdType = GachaConfig.Instance.GetItemIdType(itemId);
		base.GetItem(4).SetUIActive(itemIdType == InventoryDefine.EItemDataType.WeaponItem);
		texture.SetUIActive(itemIdType == InventoryDefine.EItemDataType.RoleItem);
		sprite.SetUIActive(itemIdType != InventoryDefine.EItemDataType.RoleItem);
		if (itemIdType == InventoryDefine.EItemDataType.RoleItem)
		{
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(itemId);
			if (roleConfig == null)
			{
				return;
			}
			int elementId = roleConfig.Value.ElementId;
			ElementInfo? elementConfig = CommonConfig.Instance.GetElementConfig(elementId);
			if (elementConfig == null)
			{
				return;
			}
			base.SetTextureByPath(elementConfig.Value.Icon, texture, null, null);
			texture.SetColor(FColor.FromHex(elementConfig.Value.ElementColor));
			return;
		}
		else
		{
			WeaponConf? weaponConfigByItemId = WeaponConfig.Instance.GetWeaponConfigByItemId(itemId);
			if (weaponConfigByItemId == null)
			{
				return;
			}
			string weaponIconPath = WeaponConfig.Instance.GetWeaponIconPath(weaponConfigByItemId.Value.WeaponType);
			if (!string.IsNullOrEmpty(weaponIconPath))
			{
				this.SetSpriteByPath(weaponIconPath, sprite, false, null, null);
			}
			return;
		}
	}

	// Token: 0x04006595 RID: 26005
	[Nullable(2)]
	private SimpleGenericLayout StarLayout;

	// Token: 0x02008285 RID: 33413
	private enum EComponent
	{
		// Token: 0x0402A95C RID: 174428
		TextureBg,
		// Token: 0x0402A95D RID: 174429
		StarLayout,
		// Token: 0x0402A95E RID: 174430
		StarItem,
		// Token: 0x0402A95F RID: 174431
		TxtName,
		// Token: 0x0402A960 RID: 174432
		WeaponElementBg,
		// Token: 0x0402A961 RID: 174433
		TextureElement,
		// Token: 0x0402A962 RID: 174434
		TxtDesc,
		// Token: 0x0402A963 RID: 174435
		SpriteWeapon
	}
}
