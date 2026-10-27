using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Roverlike;
using CSharpScript.Game.Module.RoleUi;
using Google.FlatBuffers;

namespace CSharpScript.Game.Module.Inventory
{
	// Token: 0x0200582F RID: 22575
	[NullableContext(2)]
	[Nullable(0)]
	[Config(0)]
	public class InventoryConfig : ConfigBase
	{
		// Token: 0x060395A4 RID: 234916 RVA: 0x00D9A2A4 File Offset: 0x00D984A4
		public InventoryConfig()
		{
			this.Lru = new Lru<int, ItemConfig>(256, new Func<int, ItemConfig>(this.GetItemConfigDataRef), null);
		}

		// Token: 0x060395A5 RID: 234917 RVA: 0x00D9A30F File Offset: 0x00D9850F
		public IReadOnlyList<ItemMainType> GetAllMainTypeConfig()
		{
			return ConfigItemMainTypeAll.GetConfigList(true);
		}

		// Token: 0x060395A6 RID: 234918 RVA: 0x00D9A317 File Offset: 0x00D98517
		public ItemMainType? GetItemMainTypeConfig(int itemTypeId)
		{
			return ConfigItemMainTypeById.GetConfig(itemTypeId, true);
		}

		// Token: 0x060395A7 RID: 234919 RVA: 0x00D9A320 File Offset: 0x00D98520
		public int? GetItemMainTypeFilterSortUseWayId(int itemTypeId)
		{
			ItemMainType? itemMainTypeConfig = this.GetItemMainTypeConfig(itemTypeId);
			if (itemMainTypeConfig == null)
			{
				return null;
			}
			return new int?(itemMainTypeConfig.Value.UseWayId);
		}

		// Token: 0x060395A8 RID: 234920 RVA: 0x00D9A35C File Offset: 0x00D9855C
		public AccessPath? GetAccessPathConfig(int accessPathId)
		{
			return ConfigAccessPathById.GetConfig(accessPathId, true);
		}

		// Token: 0x060395A9 RID: 234921 RVA: 0x00D9A365 File Offset: 0x00D98565
		public QualityInfo? GetItemQualityConfig(int qualityId)
		{
			return ConfigQualityInfoById.GetConfig(qualityId, true);
		}

		// Token: 0x060395AA RID: 234922 RVA: 0x00D9A370 File Offset: 0x00D98570
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

		// Token: 0x060395AB RID: 234923 RVA: 0x00D9A3BC File Offset: 0x00D985BC
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

		// Token: 0x060395AC RID: 234924 RVA: 0x00D9A458 File Offset: 0x00D98658
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

		// Token: 0x060395AD RID: 234925 RVA: 0x00D9A7D4 File Offset: 0x00D989D4
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
			if (this.ErrorPhantomSpecialIdList != null && this.ErrorPhantomSpecialIdList.Contains(configId.Value))
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

		// Token: 0x060395AE RID: 234926 RVA: 0x00D9B108 File Offset: 0x00D99308
		public ItemInfo? GetItemConfig(int itemConfigId)
		{
			return ConfigItemInfoById.GetConfig(itemConfigId, true);
		}

		// Token: 0x060395AF RID: 234927 RVA: 0x00D9B111 File Offset: 0x00D99311
		public PreviewItem? GetPreviewItemConfig(int itemConfigId)
		{
			return ConfigPreviewItemById.GetConfig(itemConfigId, true);
		}

		// Token: 0x060395B0 RID: 234928 RVA: 0x00D9B11A File Offset: 0x00D9931A
		public WeaponConf? GetWeaponItemConfig(int configId)
		{
			return ConfigWeaponConfByItemId.GetConfig(configId, true);
		}

		// Token: 0x060395B1 RID: 234929 RVA: 0x00D9B123 File Offset: 0x00D99323
		public PhantomItem? GetPhantomItemConfig(int configId)
		{
			return ConfigPhantomItemByItemId.GetConfig(configId, true);
		}

		// Token: 0x060395B2 RID: 234930 RVA: 0x00D9B12C File Offset: 0x00D9932C
		public PhantomCustomizeItem? GetPhantomCustomizeItemConfig(int configId)
		{
			return ConfigPhantomCustomizeItemByItemId.GetConfig(configId, true);
		}

		// Token: 0x060395B3 RID: 234931 RVA: 0x00D9B138 File Offset: 0x00D99338
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

		// Token: 0x060395B4 RID: 234932 RVA: 0x00D9B17A File Offset: 0x00D9937A
		public BackgroundCard? GetCardItemConfig(int configId)
		{
			return ConfigBackgroundCardById.GetConfig(configId, true);
		}

		// Token: 0x060395B5 RID: 234933 RVA: 0x00D9B183 File Offset: 0x00D99383
		public IReadOnlyList<int> GetErrorPhantomSpecialIdList()
		{
			return ConfigCommonParamById.GetIntArrayConfig("SpecialPhantomCustomizeItem");
		}

		// Token: 0x060395B6 RID: 234934 RVA: 0x00D9B18F File Offset: 0x00D9938F
		public IReadOnlyList<PackageCapacity> GetAllPackageConfig()
		{
			return ConfigPackageCapacityAll.GetConfigList(true);
		}

		// Token: 0x060395B7 RID: 234935 RVA: 0x00D9B197 File Offset: 0x00D99397
		public PackageCapacity? GetPackageConfig(int packageConfigId)
		{
			return ConfigPackageCapacityByPackageId.GetConfig(packageConfigId, true);
		}

		// Token: 0x060395B8 RID: 234936 RVA: 0x00D9B1A0 File Offset: 0x00D993A0
		public TypeInfo? GetItemTypeConfig(int itemType)
		{
			return ConfigTypeInfoById.GetConfig(itemType, true);
		}

		// Token: 0x060395B9 RID: 234937 RVA: 0x00D9B1A9 File Offset: 0x00D993A9
		public ItemShowType? GetItemShowTypeConfig(int showItemType)
		{
			return ConfigItemShowTypeById.GetConfig(showItemType, true);
		}

		// Token: 0x060395BA RID: 234938 RVA: 0x00D9B1B2 File Offset: 0x00D993B2
		public PlayerTitle? GetPlayerTitleItemConfig(int configId)
		{
			return ConfigPlayerTitleById.GetConfig(configId, true);
		}

		// Token: 0x060395BB RID: 234939 RVA: 0x00D9B1BC File Offset: 0x00D993BC
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

		// Token: 0x060395BC RID: 234940 RVA: 0x00D9B280 File Offset: 0x00D99480
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

		// Token: 0x060395BD RID: 234941 RVA: 0x00D9B320 File Offset: 0x00D99520
		public int GetPhantomFusionThreshold()
		{
			return ConfigCommonParamById.GetIntConfig("PhantomFusionThreshold").GetValueOrDefault(1000);
		}

		// Token: 0x060395BE RID: 234942 RVA: 0x00D9B344 File Offset: 0x00D99544
		public int GetPhantomDiscardThreshold()
		{
			return ConfigCommonParamById.GetIntConfig("PhantomDiscardThreshold").GetValueOrDefault(2500);
		}

		// Token: 0x060395BF RID: 234943 RVA: 0x00D9B368 File Offset: 0x00D99568
		protected override bool OnClear()
		{
			this.CommonItemConfigMap.Clear();
			this.WeaponItemConfigMap.Clear();
			this.PhantomItemConfigMap.Clear();
			this.Lru.Clear();
			return true;
		}

		// Token: 0x17008A2D RID: 35373
		// (get) Token: 0x060395C0 RID: 234944 RVA: 0x00D9B397 File Offset: 0x00D99597
		[Nullable(1)]
		public static InventoryConfig Instance
		{
			[NullableContext(1)]
			get
			{
				return InventoryConfig._Instance;
			}
		}

		// Token: 0x060395C1 RID: 234945 RVA: 0x00D9B39E File Offset: 0x00D9959E
		[NullableContext(1)]
		public static InventoryConfig GetOrCreateInstance()
		{
			if (InventoryConfig._Instance == null)
			{
				InventoryConfig.CreateInstance();
			}
			return InventoryConfig._Instance;
		}

		// Token: 0x060395C2 RID: 234946 RVA: 0x00D9B3B2 File Offset: 0x00D995B2
		public static bool CreateInstance()
		{
			if (InventoryConfig._Instance != null)
			{
				return true;
			}
			InventoryConfig._Instance = new InventoryConfig();
			return true;
		}

		// Token: 0x060395C3 RID: 234947 RVA: 0x00D9B3C8 File Offset: 0x00D995C8
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060395C4 RID: 234948 RVA: 0x00D9B3CA File Offset: 0x00D995CA
		public static void ResetStaticDefaultValue()
		{
			InventoryConfig._Instance = null;
		}

		// Token: 0x060395C5 RID: 234949 RVA: 0x00D9B3D2 File Offset: 0x00D995D2
		static InventoryConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InventoryConfig.CreateStaticDefaultValue), new Action(InventoryConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401DFE4 RID: 122852
		private IReadOnlyList<int> ErrorPhantomSpecialIdList;

		// Token: 0x0401DFE5 RID: 122853
		[Nullable(1)]
		private readonly Dictionary<int, ItemInfo> CommonItemConfigMap = new Dictionary<int, ItemInfo>();

		// Token: 0x0401DFE6 RID: 122854
		[Nullable(1)]
		private readonly Dictionary<int, WeaponConf> WeaponItemConfigMap = new Dictionary<int, WeaponConf>();

		// Token: 0x0401DFE7 RID: 122855
		[Nullable(1)]
		private readonly Dictionary<int, PhantomItem> PhantomItemConfigMap = new Dictionary<int, PhantomItem>();

		// Token: 0x0401DFE8 RID: 122856
		[Nullable(1)]
		private readonly Stat StatGetItemConfigData = Stat.Create("GetItemConfigData", "", "");

		// Token: 0x0401DFE9 RID: 122857
		[Nullable(1)]
		private readonly Lru<int, ItemConfig> Lru;

		// Token: 0x0401DFEA RID: 122858
		private const int ITEM_LRU_SIZE = 256;

		// Token: 0x0401DFEB RID: 122859
		private static InventoryConfig _Instance;
	}
}
