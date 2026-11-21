using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Roverlike;
using CSharpScript.Game.Module.RoleUi;
using Google.FlatBuffers;

namespace CSharpScript.Game.Module.Inventory
{
	// Token: 0x02004806 RID: 18438
	[NullableContext(2)]
	[Nullable(0)]
	[Config(0)]
	public class InventoryConfig : ConfigBase
	{
		// Token: 0x0602E4B8 RID: 189624 RVA: 0x00CE9138 File Offset: 0x00CE7338
		public InventoryConfig()
		{
			this.Lru = new Lru<int, ItemConfig>(256, new Func<int, ItemConfig>(this.GetItemConfigDataRef), null);
		}

		// Token: 0x0602E4B9 RID: 189625 RVA: 0x00CE91A3 File Offset: 0x00CE73A3
		public IReadOnlyList<ItemMainType> GetAllMainTypeConfig()
		{
			return ConfigItemMainTypeAll.GetConfigList(true);
		}

		// Token: 0x0602E4BA RID: 189626 RVA: 0x00CE91AB File Offset: 0x00CE73AB
		public ItemMainType? GetItemMainTypeConfig(int itemTypeId)
		{
			return ConfigItemMainTypeById.GetConfig(itemTypeId, true);
		}

		// Token: 0x0602E4BB RID: 189627 RVA: 0x00CE91B4 File Offset: 0x00CE73B4
		public int? GetItemMainTypeFilterSortUseWayId(int itemTypeId)
		{
			ItemMainType? itemMainTypeConfig = this.GetItemMainTypeConfig(itemTypeId);
			if (itemMainTypeConfig == null)
			{
				return null;
			}
			return new int?(itemMainTypeConfig.Value.UseWayId);
		}

		// Token: 0x0602E4BC RID: 189628 RVA: 0x00CE91F0 File Offset: 0x00CE73F0
		public AccessPath? GetAccessPathConfig(int accessPathId)
		{
			return ConfigAccessPathById.GetConfig(accessPathId, true);
		}

		// Token: 0x0602E4BD RID: 189629 RVA: 0x00CE91F9 File Offset: 0x00CE73F9
		public QualityInfo? GetItemQualityConfig(int qualityId)
		{
			return ConfigQualityInfoById.GetConfig(qualityId, true);
		}

		// Token: 0x0602E4BE RID: 189630 RVA: 0x00CE9204 File Offset: 0x00CE7404
		public ItemConfig GetItemConfigData(int configId)
		{
			ItemConfig itemConfig = this.Lru.Get(configId);
			if (itemConfig != null)
			{
				this.Lru.Put(itemConfig);
				return itemConfig;
			}
			itemConfig = this.Lru.Create(configId);
			if (itemConfig == null)
			{
				return null;
			}
			this.Lru.Put(itemConfig);
			return itemConfig;
		}

		// Token: 0x0602E4BF RID: 189631 RVA: 0x00CE9250 File Offset: 0x00CE7450
		public string GetItemConfigValueByParam(int configId, string param, [Nullable(1)] string tag)
		{
			ItemConfig itemConfigDataRef = this.GetItemConfigDataRef(configId);
			if (itemConfigDataRef == null || param == null)
			{
				return null;
			}
			if (param == "Icon")
			{
				return itemConfigDataRef.Icon;
			}
			if (param == "IconMiddle")
			{
				return itemConfigDataRef.IconMiddle;
			}
			if (param == "IconSmall")
			{
				return itemConfigDataRef.IconSmall;
			}
			if (!(param == "IconBig"))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiImageSetting;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "配置的表格字段查询到的资源路径不是字符串类型";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("配置的表格字段", tag);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return itemConfigDataRef.IconBig;
		}

		// Token: 0x0602E4C0 RID: 189632 RVA: 0x00CE92EC File Offset: 0x00CE74EC
		private ItemConfig GetItemConfigDataRef(int configId)
		{
			IFlatbufferObject flatbufferObject = null;
			InventoryDefine.EItemDataType itemDataTypeByConfigId = this.GetItemDataTypeByConfigId(new int?(configId));
			switch (itemDataTypeByConfigId)
			{
			case InventoryDefine.EItemDataType.CommonItem:
				flatbufferObject = this.GetItemConfig(configId);
				break;
			case InventoryDefine.EItemDataType.RoleItem:
				flatbufferObject = RoleConfig.Instance.GetRoleConfig(configId);
				break;
			case InventoryDefine.EItemDataType.WeaponItem:
				flatbufferObject = this.GetWeaponItemConfig(configId);
				break;
			case InventoryDefine.EItemDataType.PhantomItem:
				flatbufferObject = this.GetPhantomItemConfig(configId);
				break;
			case InventoryDefine.EItemDataType.PhantomCustomize:
			{
				PhantomCustomizeItem? phantomCustomizeItemConfig = this.GetPhantomCustomizeItemConfig(configId);
				if (phantomCustomizeItemConfig != null)
				{
					if (phantomCustomizeItemConfig.Value.SkinItemId > 0)
					{
						flatbufferObject = this.GetPhantomItemConfig(phantomCustomizeItemConfig.Value.SkinItemId);
					}
					else
					{
						flatbufferObject = this.GetPhantomItemConfig(phantomCustomizeItemConfig.Value.PhantomId);
					}
				}
				break;
			}
			case InventoryDefine.EItemDataType.VirtualItem:
				flatbufferObject = this.GetItemConfig(configId);
				break;
			case InventoryDefine.EItemDataType.CardItem:
				flatbufferObject = ConfigBackgroundCardById.GetConfig(configId, true);
				break;
			case InventoryDefine.EItemDataType.PreviewItem:
				flatbufferObject = this.GetPreviewItemConfig(configId);
				break;
			case InventoryDefine.EItemDataType.RogueCurrency:
				flatbufferObject = ConfigRogueCurrencyById.GetConfig(configId, true);
				break;
			case InventoryDefine.EItemDataType.RogueResCurrency:
				flatbufferObject = ConfigRogueResCurrencyById.GetConfig(configId, true);
				break;
			case InventoryDefine.EItemDataType.WeaponSkinItem:
				flatbufferObject = ConfigWeaponSkinById.GetConfig(configId, true);
				break;
			case InventoryDefine.EItemDataType.RoleSkinItem:
				flatbufferObject = ConfigRoleSkinById.GetConfig(configId, true);
				break;
			case InventoryDefine.EItemDataType.PlayerHeadItem:
				flatbufferObject = ConfigPlayerHeadReById.GetConfig(configId, true);
				break;
			case InventoryDefine.EItemDataType.DangoAbyssItem:
				flatbufferObject = ConfigAbyssItemById.GetConfig(configId, true);
				break;
			case InventoryDefine.EItemDataType.FlySkinItem:
				flatbufferObject = ConfigFlySkinConfigById.GetConfig(configId, true);
				break;
			case InventoryDefine.EItemDataType.PhantomArenaCard:
				flatbufferObject = ConfigPhantomBattleCardById.GetConfig(configId, true);
				break;
			case InventoryDefine.EItemDataType.PhantomArenaBadge:
				flatbufferObject = ConfigPhantomBattleBadgeById.GetConfig(configId, true);
				break;
			case InventoryDefine.EItemDataType.HonamiStoryItem:
				flatbufferObject = ConfigHonamiStoryItemById.GetConfig(configId, true);
				break;
			case InventoryDefine.EItemDataType.CalabashSkinItem:
				flatbufferObject = ConfigCalabashSkinById.GetConfig(configId, true);
				break;
			case InventoryDefine.EItemDataType.HonamiStoryWeapon:
				flatbufferObject = ConfigHonamiStoryWeaponById.GetConfig(configId, true);
				break;
			case InventoryDefine.EItemDataType.InfrastructureItem:
				flatbufferObject = this.GetItemConfig(configId);
				break;
			case InventoryDefine.EItemDataType.MotorStickerItem:
				flatbufferObject = ConfigMotorStickerById.GetConfig(configId, true);
				break;
			case InventoryDefine.EItemDataType.PhoneChatDialog:
				flatbufferObject = ConfigChatDialogById.GetConfig(configId, true);
				break;
			case InventoryDefine.EItemDataType.PhoneChatBackGround:
				flatbufferObject = ConfigChatBgById.GetConfig(configId, true);
				break;
			case InventoryDefine.EItemDataType.PhoneChatTheme:
				flatbufferObject = ConfigChatThemeById.GetConfig(configId, true);
				break;
			case InventoryDefine.EItemDataType.PhoneChatCharm:
				flatbufferObject = ConfigChatCharmById.GetConfig(configId, true);
				break;
			case InventoryDefine.EItemDataType.FurnitureItem:
				flatbufferObject = ConfigFurnitureById.GetConfig(configId, true);
				break;
			case InventoryDefine.EItemDataType.MotorFrameItem:
				flatbufferObject = ConfigMotorFrameById.GetConfig(configId, true);
				break;
			case InventoryDefine.EItemDataType.MotorDecorationItem:
				flatbufferObject = ConfigMotorDecorationsById.GetConfig(configId, true);
				break;
			case InventoryDefine.EItemDataType.MotorSkinItem:
				flatbufferObject = ConfigMotorSkinById.GetConfig(configId, true);
				break;
			case InventoryDefine.EItemDataType.OrnamentItem:
				flatbufferObject = ConfigOrnamentById.GetConfig(configId, true);
				break;
			case InventoryDefine.EItemDataType.PinballRoleItem:
				flatbufferObject = ConfigPinballRoleConfigById.GetConfig(configId, true);
				break;
			case InventoryDefine.EItemDataType.PinballWeaponItem:
				flatbufferObject = ConfigPinballWeaponConfigById.GetConfig(configId, true);
				break;
			case InventoryDefine.EItemDataType.RoverRogueCurrency:
				flatbufferObject = RoverlikeConfig.Instance.GetCurrencyConfig(configId);
				break;
			case InventoryDefine.EItemDataType.DangoBrawlRoleItem:
				flatbufferObject = ConfigDangoBrawlRoleById.GetConfig(configId, true);
				break;
			}
			if (flatbufferObject == null)
			{
				return null;
			}
			ItemConfig itemConfig = new ItemConfig();
			itemConfig.Refresh(flatbufferObject, itemDataTypeByConfigId, configId);
			return itemConfig;
		}

		// Token: 0x0602E4C1 RID: 189633 RVA: 0x00CE9668 File Offset: 0x00CE7868
		public InventoryDefine.EItemDataType GetItemDataTypeByConfigId(int? configId)
		{
			if (configId == null)
			{
				return InventoryDefine.EItemDataType.CommonItem;
			}
			if (this.ErrorPhantomSpecialIdList == null)
			{
				this.ErrorPhantomSpecialIdList = this.GetErrorPhantomSpecialIdList();
			}
			bool flag = false;
			if (this.ErrorPhantomSpecialIdList != null)
			{
				for (int i = 0; i < this.ErrorPhantomSpecialIdList.Count; i++)
				{
					if (this.ErrorPhantomSpecialIdList[i] == configId.Value)
					{
						flag = true;
						break;
					}
				}
			}
			if (flag)
			{
				return InventoryDefine.EItemDataType.PhantomCustomize;
			}
			int? num = configId;
			int num2 = InventoryDefine.weaponIdRange[0];
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				num = configId;
				num2 = InventoryDefine.weaponIdRange[1];
				if (num.GetValueOrDefault() <= num2 & num != null)
				{
					return InventoryDefine.EItemDataType.WeaponItem;
				}
			}
			num = configId;
			num2 = InventoryDefine.phantomIdRange[0];
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				num = configId;
				num2 = InventoryDefine.phantomIdRange[1];
				if (num.GetValueOrDefault() <= num2 & num != null)
				{
					return InventoryDefine.EItemDataType.PhantomItem;
				}
			}
			num = configId;
			num2 = InventoryDefine.phantomSpecificIdRange[0];
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				num = configId;
				num2 = InventoryDefine.phantomSpecificIdRange[1];
				if (num.GetValueOrDefault() <= num2 & num != null)
				{
					return InventoryDefine.EItemDataType.PhantomCustomize;
				}
			}
			num = configId;
			num2 = InventoryDefine.roleIdRange[0];
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				num = configId;
				num2 = InventoryDefine.roleIdRange[1];
				if (num.GetValueOrDefault() <= num2 & num != null)
				{
					return InventoryDefine.EItemDataType.RoleItem;
				}
			}
			num = configId;
			num2 = InventoryDefine.virtualIdRange[0];
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				num = configId;
				num2 = InventoryDefine.virtualIdRange[1];
				if (num.GetValueOrDefault() <= num2 & num != null)
				{
					return InventoryDefine.EItemDataType.VirtualItem;
				}
			}
			num = configId;
			num2 = InventoryDefine.cardIdRange[0];
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				num = configId;
				num2 = InventoryDefine.cardIdRange[1];
				if (num.GetValueOrDefault() <= num2 & num != null)
				{
					return InventoryDefine.EItemDataType.CardItem;
				}
			}
			num = configId;
			num2 = InventoryDefine.previewItemIdRange[0];
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				num = configId;
				num2 = InventoryDefine.previewItemIdRange[1];
				if (num.GetValueOrDefault() <= num2 & num != null)
				{
					return InventoryDefine.EItemDataType.PreviewItem;
				}
			}
			num = configId;
			num2 = InventoryDefine.rogueCurrencyIdRange[0];
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				num = configId;
				num2 = InventoryDefine.rogueCurrencyIdRange[1];
				if (num.GetValueOrDefault() <= num2 & num != null)
				{
					return InventoryDefine.EItemDataType.RogueCurrency;
				}
			}
			num = configId;
			num2 = InventoryDefine.rogueResCurrencyIdRange[0];
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				num = configId;
				num2 = InventoryDefine.rogueResCurrencyIdRange[1];
				if (num.GetValueOrDefault() <= num2 & num != null)
				{
					return InventoryDefine.EItemDataType.RogueResCurrency;
				}
			}
			num = configId;
			num2 = InventoryDefine.roverRogueCurrencyIdRange[0];
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				num = configId;
				num2 = InventoryDefine.roverRogueCurrencyIdRange[1];
				if (num.GetValueOrDefault() <= num2 & num != null)
				{
					return InventoryDefine.EItemDataType.RoverRogueCurrency;
				}
			}
			num = configId;
			num2 = InventoryDefine.dangoBrawlRoleIdRange[0];
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				num = configId;
				num2 = InventoryDefine.dangoBrawlRoleIdRange[1];
				if (num.GetValueOrDefault() <= num2 & num != null)
				{
					return InventoryDefine.EItemDataType.DangoBrawlRoleItem;
				}
			}
			num = configId;
			num2 = InventoryDefine.weaponSkinIdRange[0];
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				num = configId;
				num2 = InventoryDefine.weaponSkinIdRange[1];
				if (num.GetValueOrDefault() < num2 & num != null)
				{
					return InventoryDefine.EItemDataType.WeaponSkinItem;
				}
			}
			num = configId;
			num2 = InventoryDefine.roleSkinIdRange[0];
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				num = configId;
				num2 = InventoryDefine.roleSkinIdRange[1];
				if (num.GetValueOrDefault() < num2 & num != null)
				{
					return InventoryDefine.EItemDataType.RoleSkinItem;
				}
			}
			num = configId;
			num2 = InventoryDefine.playerHeadRange[0];
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				num = configId;
				num2 = InventoryDefine.playerHeadRange[1];
				if (num.GetValueOrDefault() < num2 & num != null)
				{
					return InventoryDefine.EItemDataType.PlayerHeadItem;
				}
			}
			num = configId;
			num2 = InventoryDefine.DangoAbyssItemRange[0];
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				num = configId;
				num2 = InventoryDefine.DangoAbyssItemRange[1];
				if (num.GetValueOrDefault() < num2 & num != null)
				{
					return InventoryDefine.EItemDataType.DangoAbyssItem;
				}
			}
			num = configId;
			num2 = InventoryDefine.flySkinIdRange[0];
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				num = configId;
				num2 = InventoryDefine.flySkinIdRange[1];
				if (num.GetValueOrDefault() < num2 & num != null)
				{
					return InventoryDefine.EItemDataType.FlySkinItem;
				}
			}
			num = configId;
			num2 = InventoryDefine.PhantomArenaCardItemRange[0];
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				num = configId;
				num2 = InventoryDefine.PhantomArenaCardItemRange[1];
				if (num.GetValueOrDefault() < num2 & num != null)
				{
					return InventoryDefine.EItemDataType.PhantomArenaCard;
				}
			}
			num = configId;
			num2 = InventoryDefine.PhantomArenaBadgeItemRange[0];
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				num = configId;
				num2 = InventoryDefine.PhantomArenaBadgeItemRange[1];
				if (num.GetValueOrDefault() < num2 & num != null)
				{
					return InventoryDefine.EItemDataType.PhantomArenaBadge;
				}
			}
			num = configId;
			num2 = InventoryDefine.HonamiStoryItemRange[0];
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				num = configId;
				num2 = InventoryDefine.HonamiStoryItemRange[1];
				if (num.GetValueOrDefault() <= num2 & num != null)
				{
					return InventoryDefine.EItemDataType.HonamiStoryItem;
				}
			}
			num = configId;
			num2 = InventoryDefine.HonamiStoryWeaponRange[0];
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				num = configId;
				num2 = InventoryDefine.HonamiStoryWeaponRange[1];
				if (num.GetValueOrDefault() <= num2 & num != null)
				{
					return InventoryDefine.EItemDataType.HonamiStoryWeapon;
				}
			}
			num = configId;
			num2 = InventoryDefine.calabashSkinIdRange[0];
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				num = configId;
				num2 = InventoryDefine.calabashSkinIdRange[1];
				if (num.GetValueOrDefault() < num2 & num != null)
				{
					return InventoryDefine.EItemDataType.CalabashSkinItem;
				}
			}
			num = configId;
			num2 = InventoryDefine.InfrastructureItemRange[0];
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				num = configId;
				num2 = InventoryDefine.InfrastructureItemRange[1];
				if (num.GetValueOrDefault() < num2 & num != null)
				{
					return InventoryDefine.EItemDataType.InfrastructureItem;
				}
			}
			num = configId;
			num2 = InventoryDefine.MotorFrameItemRange[0];
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				num = configId;
				num2 = InventoryDefine.MotorFrameItemRange[1];
				if (num.GetValueOrDefault() < num2 & num != null)
				{
					return InventoryDefine.EItemDataType.MotorFrameItem;
				}
			}
			num = configId;
			num2 = InventoryDefine.MotorStickerItemRange[0];
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				num = configId;
				num2 = InventoryDefine.MotorStickerItemRange[1];
				if (num.GetValueOrDefault() < num2 & num != null)
				{
					return InventoryDefine.EItemDataType.MotorStickerItem;
				}
			}
			num = configId;
			num2 = InventoryDefine.MotorDecorationItemRange[0];
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				num = configId;
				num2 = InventoryDefine.MotorDecorationItemRange[1];
				if (num.GetValueOrDefault() < num2 & num != null)
				{
					return InventoryDefine.EItemDataType.MotorDecorationItem;
				}
			}
			num = configId;
			num2 = InventoryDefine.MotorSkinItemRange[0];
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				num = configId;
				num2 = InventoryDefine.MotorSkinItemRange[1];
				if (num.GetValueOrDefault() < num2 & num != null)
				{
					return InventoryDefine.EItemDataType.MotorSkinItem;
				}
			}
			num = configId;
			num2 = InventoryDefine.PhoneChatDialogItemRange[0];
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				num = configId;
				num2 = InventoryDefine.PhoneChatDialogItemRange[1];
				if (num.GetValueOrDefault() < num2 & num != null)
				{
					return InventoryDefine.EItemDataType.PhoneChatDialog;
				}
			}
			num = configId;
			num2 = InventoryDefine.PhoneChatBackGroundItemRange[0];
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				num = configId;
				num2 = InventoryDefine.PhoneChatBackGroundItemRange[1];
				if (num.GetValueOrDefault() < num2 & num != null)
				{
					return InventoryDefine.EItemDataType.PhoneChatBackGround;
				}
			}
			num = configId;
			num2 = InventoryDefine.PhoneChatThemeItemRange[0];
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				num = configId;
				num2 = InventoryDefine.PhoneChatThemeItemRange[1];
				if (num.GetValueOrDefault() <= num2 & num != null)
				{
					return InventoryDefine.EItemDataType.PhoneChatTheme;
				}
			}
			num = configId;
			num2 = InventoryDefine.PhoneChatCharmItemRange[0];
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				num = configId;
				num2 = InventoryDefine.PhoneChatCharmItemRange[1];
				if (num.GetValueOrDefault() <= num2 & num != null)
				{
					return InventoryDefine.EItemDataType.PhoneChatCharm;
				}
			}
			num = configId;
			num2 = InventoryDefine.FurnitureItemRange[0];
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				num = configId;
				num2 = InventoryDefine.FurnitureItemRange[1];
				if (num.GetValueOrDefault() < num2 & num != null)
				{
					return InventoryDefine.EItemDataType.FurnitureItem;
				}
			}
			num = configId;
			num2 = InventoryDefine.OrnamentItemRange[0];
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				num = configId;
				num2 = InventoryDefine.OrnamentItemRange[1];
				if (num.GetValueOrDefault() < num2 & num != null)
				{
					return InventoryDefine.EItemDataType.OrnamentItem;
				}
			}
			num = configId;
			num2 = InventoryDefine.PinballRoleItemRange[0];
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				num = configId;
				num2 = InventoryDefine.PinballRoleItemRange[1];
				if (num.GetValueOrDefault() < num2 & num != null)
				{
					return InventoryDefine.EItemDataType.PinballRoleItem;
				}
			}
			num = configId;
			num2 = InventoryDefine.PinballWeaponItemRange[0];
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				num = configId;
				num2 = InventoryDefine.PinballWeaponItemRange[1];
				if (num.GetValueOrDefault() < num2 & num != null)
				{
					return InventoryDefine.EItemDataType.PinballWeaponItem;
				}
			}
			return InventoryDefine.EItemDataType.CommonItem;
		}

		// Token: 0x0602E4C2 RID: 189634 RVA: 0x00CE9FBC File Offset: 0x00CE81BC
		public ItemInfo? GetItemConfig(int itemConfigId)
		{
			return ConfigItemInfoById.GetConfig(itemConfigId, true);
		}

		// Token: 0x0602E4C3 RID: 189635 RVA: 0x00CE9FC5 File Offset: 0x00CE81C5
		public PreviewItem? GetPreviewItemConfig(int itemConfigId)
		{
			return ConfigPreviewItemById.GetConfig(itemConfigId, true);
		}

		// Token: 0x0602E4C4 RID: 189636 RVA: 0x00CE9FCE File Offset: 0x00CE81CE
		public WeaponConf? GetWeaponItemConfig(int configId)
		{
			return ConfigWeaponConfByItemId.GetConfig(configId, true);
		}

		// Token: 0x0602E4C5 RID: 189637 RVA: 0x00CE9FD7 File Offset: 0x00CE81D7
		public PhantomItem? GetPhantomItemConfig(int configId)
		{
			return ConfigPhantomItemByItemId.GetConfig(configId, true);
		}

		// Token: 0x0602E4C6 RID: 189638 RVA: 0x00CE9FE0 File Offset: 0x00CE81E0
		public PhantomCustomizeItem? GetPhantomCustomizeItemConfig(int configId)
		{
			return ConfigPhantomCustomizeItemByItemId.GetConfig(configId, true);
		}

		// Token: 0x0602E4C7 RID: 189639 RVA: 0x00CE9FEC File Offset: 0x00CE81EC
		public IReadOnlyList<PhantomItem> GetPhantomItemConfigListByMonsterId(int monsterId)
		{
			IReadOnlyList<PhantomItem> configList = ConfigPhantomItemByMonsterId.GetConfigList(monsterId, true);
			if (configList == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Config;
				ELogAuthor author = ELogAuthor.ZJC;
				string message = "表格查询不到配置ID";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MonsterId", monsterId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return configList;
		}

		// Token: 0x0602E4C8 RID: 189640 RVA: 0x00CEA02E File Offset: 0x00CE822E
		public BackgroundCard? GetCardItemConfig(int configId)
		{
			return ConfigBackgroundCardById.GetConfig(configId, true);
		}

		// Token: 0x0602E4C9 RID: 189641 RVA: 0x00CEA037 File Offset: 0x00CE8237
		public IReadOnlyList<int> GetErrorPhantomSpecialIdList()
		{
			return ConfigCommonParamById.GetIntArrayConfig("SpecialPhantomCustomizeItem");
		}

		// Token: 0x0602E4CA RID: 189642 RVA: 0x00CEA043 File Offset: 0x00CE8243
		public IReadOnlyList<PackageCapacity> GetAllPackageConfig()
		{
			return ConfigPackageCapacityAll.GetConfigList(true);
		}

		// Token: 0x0602E4CB RID: 189643 RVA: 0x00CEA04B File Offset: 0x00CE824B
		public PackageCapacity? GetPackageConfig(int packageConfigId)
		{
			return ConfigPackageCapacityByPackageId.GetConfig(packageConfigId, true);
		}

		// Token: 0x0602E4CC RID: 189644 RVA: 0x00CEA054 File Offset: 0x00CE8254
		public TypeInfo? GetItemTypeConfig(int itemType)
		{
			return ConfigTypeInfoById.GetConfig(itemType, true);
		}

		// Token: 0x0602E4CD RID: 189645 RVA: 0x00CEA05D File Offset: 0x00CE825D
		public ItemShowType? GetItemShowTypeConfig(int showItemType)
		{
			return ConfigItemShowTypeById.GetConfig(showItemType, true);
		}

		// Token: 0x0602E4CE RID: 189646 RVA: 0x00CEA066 File Offset: 0x00CE8266
		public PlayerTitle? GetPlayerTitleItemConfig(int configId)
		{
			return ConfigPlayerTitleById.GetConfig(configId, true);
		}

		// Token: 0x0602E4CF RID: 189647 RVA: 0x00CEA070 File Offset: 0x00CE8270
		public TItemQualityConfig GetItemQualityByItemIdAndQuality(int? configId, int qualityId)
		{
			if (configId == null)
			{
				QualityInfo? itemQualityConfig = InventoryConfig.Instance.GetItemQualityConfig(qualityId);
				if (itemQualityConfig == null)
				{
					return null;
				}
				return itemQualityConfig.GetValueOrDefault();
			}
			else
			{
				InventoryDefine.EItemDataType itemDataTypeByConfigId = this.GetItemDataTypeByConfigId(new int?(configId.Value));
				if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.HonamiStoryItem)
				{
					HonamiStoryItemQuality? honamiStoryQuality = HonamiStoryConfig.Instance.GetHonamiStoryQuality(qualityId);
					if (honamiStoryQuality == null)
					{
						return null;
					}
					return honamiStoryQuality.GetValueOrDefault();
				}
				else if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.DangoAbyssItem)
				{
					AbyssQuality? abyssQualityById = DangoAbyssConfig.Instance.GetAbyssQualityById(qualityId);
					if (abyssQualityById == null)
					{
						return null;
					}
					return abyssQualityById.GetValueOrDefault();
				}
				else
				{
					QualityInfo? itemQualityConfig = InventoryConfig.Instance.GetItemQualityConfig(qualityId);
					if (itemQualityConfig == null)
					{
						return null;
					}
					return itemQualityConfig.GetValueOrDefault();
				}
			}
		}

		// Token: 0x0602E4D0 RID: 189648 RVA: 0x00CEA134 File Offset: 0x00CE8334
		[NullableContext(1)]
		[return: Nullable(2)]
		public TItemQualityConfig GetItemQualityByConfig(ItemConfig config)
		{
			int qualityId = config.QualityId;
			InventoryDefine.EItemType? itemType = config.ItemType;
			if (itemType.GetValueOrDefault() == InventoryDefine.EItemType.HonamiStoryItem)
			{
				HonamiStoryItemQuality? honamiStoryQuality = HonamiStoryConfig.Instance.GetHonamiStoryQuality(qualityId);
				if (honamiStoryQuality == null)
				{
					return null;
				}
				return honamiStoryQuality.GetValueOrDefault();
			}
			else if (itemType.GetValueOrDefault() == InventoryDefine.EItemType.AbyssItem)
			{
				AbyssQuality? abyssQualityById = DangoAbyssConfig.Instance.GetAbyssQualityById(qualityId);
				if (abyssQualityById == null)
				{
					return null;
				}
				return abyssQualityById.GetValueOrDefault();
			}
			else
			{
				QualityInfo? itemQualityConfig = InventoryConfig.Instance.GetItemQualityConfig(qualityId);
				if (itemQualityConfig == null)
				{
					return null;
				}
				return itemQualityConfig.GetValueOrDefault();
			}
		}

		// Token: 0x0602E4D1 RID: 189649 RVA: 0x00CEA1D4 File Offset: 0x00CE83D4
		public int GetPhantomFusionThreshold()
		{
			return ConfigCommonParamById.GetIntConfig("PhantomFusionThreshold").GetValueOrDefault(1000);
		}

		// Token: 0x0602E4D2 RID: 189650 RVA: 0x00CEA1F8 File Offset: 0x00CE83F8
		public int GetPhantomDiscardThreshold()
		{
			return ConfigCommonParamById.GetIntConfig("PhantomDiscardThreshold").GetValueOrDefault(2500);
		}

		// Token: 0x0602E4D3 RID: 189651 RVA: 0x00CEA21C File Offset: 0x00CE841C
		protected override bool OnClear()
		{
			this.CommonItemConfigMap.Clear();
			this.WeaponItemConfigMap.Clear();
			this.PhantomItemConfigMap.Clear();
			this.Lru.Clear();
			return true;
		}

		// Token: 0x17005DF7 RID: 24055
		// (get) Token: 0x0602E4D4 RID: 189652 RVA: 0x00CEA24B File Offset: 0x00CE844B
		[Nullable(1)]
		public static InventoryConfig Instance
		{
			[NullableContext(1)]
			get
			{
				return InventoryConfig._Instance;
			}
		}

		// Token: 0x0602E4D5 RID: 189653 RVA: 0x00CEA252 File Offset: 0x00CE8452
		[NullableContext(1)]
		public static InventoryConfig GetOrCreateInstance()
		{
			if (InventoryConfig._Instance == null)
			{
				InventoryConfig.CreateInstance();
			}
			return InventoryConfig._Instance;
		}

		// Token: 0x0602E4D6 RID: 189654 RVA: 0x00CEA266 File Offset: 0x00CE8466
		public static bool CreateInstance()
		{
			if (InventoryConfig._Instance != null)
			{
				return true;
			}
			InventoryConfig._Instance = new InventoryConfig();
			return true;
		}

		// Token: 0x0602E4D7 RID: 189655 RVA: 0x00CEA27C File Offset: 0x00CE847C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E4D8 RID: 189656 RVA: 0x00CEA27E File Offset: 0x00CE847E
		public static void ResetStaticDefaultValue()
		{
			InventoryConfig._Instance = null;
		}

		// Token: 0x0602E4D9 RID: 189657 RVA: 0x00CEA286 File Offset: 0x00CE8486
		static InventoryConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InventoryConfig.CreateStaticDefaultValue), new Action(InventoryConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04018A7D RID: 100989
		private IReadOnlyList<int> ErrorPhantomSpecialIdList;

		// Token: 0x04018A7E RID: 100990
		[Nullable(1)]
		private readonly Dictionary<int, ItemInfo> CommonItemConfigMap = new Dictionary<int, ItemInfo>();

		// Token: 0x04018A7F RID: 100991
		[Nullable(1)]
		private readonly Dictionary<int, WeaponConf> WeaponItemConfigMap = new Dictionary<int, WeaponConf>();

		// Token: 0x04018A80 RID: 100992
		[Nullable(1)]
		private readonly Dictionary<int, PhantomItem> PhantomItemConfigMap = new Dictionary<int, PhantomItem>();

		// Token: 0x04018A81 RID: 100993
		[Nullable(1)]
		private readonly Stat StatGetItemConfigData = Stat.Create("GetItemConfigData", "", "");

		// Token: 0x04018A82 RID: 100994
		[Nullable(1)]
		private readonly Lru<int, ItemConfig> Lru;

		// Token: 0x04018A83 RID: 100995
		private const int ITEM_LRU_SIZE = 256;

		// Token: 0x04018A84 RID: 100996
		private static InventoryConfig _Instance;
	}
}
