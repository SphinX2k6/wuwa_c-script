using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200115F RID: 4447
public class GachaShareOnePanel : UiPanelBase
{
	// Token: 0x0600B163 RID: 45411 RVA: 0x003476C4 File Offset: 0x003458C4
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

	// Token: 0x0600B164 RID: 45412 RVA: 0x0034778C File Offset: 0x0034598C
	protected override void OnStart()
	{
		this.StarLayout = new SimpleGenericLayout(base.GetHorizontalLayout(1));
		this.Refresh(this.OpenParam as GachaResult);
	}

	// Token: 0x0600B165 RID: 45413 RVA: 0x003477B4 File Offset: 0x003459B4
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

	// Token: 0x04006666 RID: 26214
	[Nullable(2)]
	private SimpleGenericLayout StarLayout;

	// Token: 0x0200740C RID: 29708
	private enum EComponent
	{
		// Token: 0x04025C7A RID: 154746
		TextureBg,
		// Token: 0x04025C7B RID: 154747
		StarLayout,
		// Token: 0x04025C7C RID: 154748
		StarItem,
		// Token: 0x04025C7D RID: 154749
		TxtName,
		// Token: 0x04025C7E RID: 154750
		WeaponElementBg,
		// Token: 0x04025C7F RID: 154751
		TextureElement,
		// Token: 0x04025C80 RID: 154752
		TxtDesc,
		// Token: 0x04025C81 RID: 154753
		SpriteWeapon
	}
}
