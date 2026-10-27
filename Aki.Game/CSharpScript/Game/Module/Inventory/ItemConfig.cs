using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.Entity.Struct;
using CSharpScript.Game.Module.RoleUi;
using Google.FlatBuffers;

namespace CSharpScript.Game.Module.Inventory
{
	// Token: 0x02005833 RID: 22579
	[NullableContext(1)]
	[Nullable(0)]
	public class ItemConfig
	{
		// Token: 0x060395D8 RID: 234968 RVA: 0x00D9B854 File Offset: 0x00D99A54
		public void Refresh(IFlatbufferObject config, InventoryDefine.EItemDataType type, int itemId)
		{
			this.Id = itemId;
			if (config is ItemInfo)
			{
				ItemInfo itemInfo = (ItemInfo)config;
				if (type == InventoryDefine.EItemDataType.InfrastructureItem)
				{
					this.Icon = itemInfo.Icon;
					this.QualityId = itemInfo.QualityId;
					this.AttributesDescription = itemInfo.AttributesDescription;
					this.RefreshInfrastructureItemConfig(itemInfo);
					return;
				}
				ItemInfo config2 = itemInfo;
				this.Icon = config2.Icon;
				this.QualityId = config2.QualityId;
				this.AttributesDescription = config2.AttributesDescription;
				this.RefreshItemConfig(config2);
				return;
			}
			else
			{
				if (config is PhantomItem)
				{
					PhantomItem config3 = (PhantomItem)config;
					this.Icon = config3.Icon;
					this.QualityId = config3.QualityId;
					this.AttributesDescription = config3.AttributesDescription;
					this.RefreshPhantomConfig(config3);
					return;
				}
				if (config is WeaponConf)
				{
					WeaponConf config4 = (WeaponConf)config;
					this.Icon = config4.Icon;
					this.QualityId = config4.QualityId;
					this.AttributesDescription = config4.AttributesDescription;
					this.RefreshWeaponConfig(config4);
					return;
				}
				if (config is RoleInfo)
				{
					RoleInfo config5 = (RoleInfo)config;
					this.Icon = config5.Icon;
					this.QualityId = config5.QualityId;
					this.AttributesDescription = config5.AttributesDescription;
					this.RefreshRoleConfig(config5);
					return;
				}
				if (config is BackgroundCard)
				{
					BackgroundCard config6 = (BackgroundCard)config;
					this.Icon = config6.Icon;
					this.QualityId = config6.QualityId;
					this.AttributesDescription = config6.AttributesDescription;
					this.RefreshCardConfig(config6);
					return;
				}
				if (config is PreviewItem)
				{
					PreviewItem config7 = (PreviewItem)config;
					this.Icon = config7.Icon;
					this.QualityId = config7.QualityId;
					this.AttributesDescription = config7.AttributesDescription;
					this.RefreshPreviewItem(config7);
					return;
				}
				if (config is RogueCurrency)
				{
					RogueCurrency config8 = (RogueCurrency)config;
					this.Icon = config8.Icon;
					this.QualityId = config8.QualityId;
					this.AttributesDescription = config8.AttributesDescription;
					this.RefreshRogueCurrency(config8);
					return;
				}
				if (config is RogueResCurrency)
				{
					RogueResCurrency config9 = (RogueResCurrency)config;
					this.Icon = config9.Icon;
					this.QualityId = config9.QualityId;
					this.AttributesDescription = config9.AttributesDescription;
					this.RefreshRogueResCurrency(config9);
					return;
				}
				if (config is RoleSkin)
				{
					RoleSkin config10 = (RoleSkin)config;
					this.Icon = config10.Icon;
					this.QualityId = config10.QualityId;
					this.AttributesDescription = config10.AttributesDescription;
					this.RefreshRoleSkinConfig(config10);
					return;
				}
				if (config is WeaponSkin)
				{
					WeaponSkin config11 = (WeaponSkin)config;
					this.Icon = config11.Icon;
					this.QualityId = config11.QualityId;
					this.AttributesDescription = config11.AttributesDescription;
					this.RefreshWeaponSkinConfig(config11);
					return;
				}
				if (config is FlySkinConfig)
				{
					FlySkinConfig config12 = (FlySkinConfig)config;
					this.Icon = config12.Icon;
					this.QualityId = config12.QualityId;
					this.AttributesDescription = config12.AttributesDescription;
					this.RefreshFlySkinConfig(config12);
					return;
				}
				if (config is PlayerHeadRe)
				{
					PlayerHeadRe config13 = (PlayerHeadRe)config;
					this.Icon = config13.Icon;
					this.QualityId = config13.QualityId;
					this.AttributesDescription = config13.AttributesDescription;
					this.RefreshPlayerHeadConfig(config13);
					return;
				}
				if (config is AbyssItem)
				{
					AbyssItem config14 = (AbyssItem)config;
					this.Icon = config14.Icon;
					this.QualityId = config14.QualityId;
					this.AttributesDescription = config14.AttributesDescription;
					this.RefreshAbyssItemConfig(config14);
					return;
				}
				if (config is PhantomBattleCard)
				{
					PhantomBattleCard config15 = (PhantomBattleCard)config;
					this.Icon = config15.Icon;
					this.QualityId = config15.QualityId;
					this.AttributesDescription = config15.AttributesDescription;
					this.RefreshPhantomArenaCardConfig(config15);
					return;
				}
				if (config is PhantomBattleBadge)
				{
					PhantomBattleBadge config16 = (PhantomBattleBadge)config;
					this.Icon = config16.Icon;
					this.QualityId = config16.QualityId;
					this.AttributesDescription = config16.AttributesDescription;
					this.RefreshPhantomArenaBadgeConfig(config16);
					return;
				}
				if (config is HonamiStoryItem)
				{
					HonamiStoryItem config17 = (HonamiStoryItem)config;
					this.Icon = config17.Icon;
					this.QualityId = config17.QualityId;
					this.AttributesDescription = config17.AttributesDescription;
					this.RefreshHonamiStoryItemConfig(config17);
					return;
				}
				if (config is HonamiStoryWeapon)
				{
					HonamiStoryWeapon config18 = (HonamiStoryWeapon)config;
					this.Icon = config18.Icon;
					this.QualityId = config18.QualityId;
					this.AttributesDescription = config18.AttributesDescription;
					this.RefreshHonamiStoryWeaponConfig(config18);
					return;
				}
				if (config is CalabashSkin)
				{
					CalabashSkin config19 = (CalabashSkin)config;
					this.Icon = config19.Icon;
					this.QualityId = config19.QualityId;
					this.AttributesDescription = config19.AttributesDescription;
					this.RefreshCalabashSkinConfig(config19);
					return;
				}
				if (config is MotorFrame)
				{
					MotorFrame config20 = (MotorFrame)config;
					this.Icon = config20.Icon;
					this.QualityId = config20.QualityId;
					this.AttributesDescription = config20.AttributesDescription;
					this.RefreshMotorFrameConfig(config20);
					return;
				}
				if (config is MotorSticker)
				{
					MotorSticker config21 = (MotorSticker)config;
					this.Icon = config21.Icon;
					this.QualityId = config21.QualityId;
					this.AttributesDescription = config21.AttributesDescription;
					this.RefreshMotorStickerConfig(config21);
					return;
				}
				if (config is MotorDecorations)
				{
					MotorDecorations config22 = (MotorDecorations)config;
					this.Icon = config22.Icon;
					this.QualityId = config22.QualityId;
					this.AttributesDescription = config22.AttributesDescription;
					this.RefreshMotorDecorationConfig(config22);
					return;
				}
				if (config is MotorSkin)
				{
					MotorSkin config23 = (MotorSkin)config;
					this.Icon = config23.Icon;
					this.QualityId = config23.QualityId;
					this.AttributesDescription = config23.AttributesDescription;
					this.RefreshMotorSkinConfig(config23);
					return;
				}
				if (config is ChatDialog)
				{
					ChatDialog config24 = (ChatDialog)config;
					this.Icon = config24.Icon;
					this.QualityId = config24.QualityId;
					this.AttributesDescription = config24.AttributesDescription;
					this.RefreshPhoneChatDialogShowConfig(config24);
					return;
				}
				if (config is ChatBg)
				{
					ChatBg config25 = (ChatBg)config;
					this.Icon = config25.Icon;
					this.QualityId = config25.QualityId;
					this.AttributesDescription = config25.AttributesDescription;
					this.RefreshPhoneChatBackGroundConfig(config25);
					return;
				}
				if (config is ChatTheme)
				{
					ChatTheme config26 = (ChatTheme)config;
					this.Icon = config26.Icon;
					this.QualityId = config26.QualityId;
					this.AttributesDescription = config26.AttributesDescription;
					this.RefreshPhoneChatThemeConfig(config26);
					return;
				}
				if (config is ChatCharm)
				{
					ChatCharm config27 = (ChatCharm)config;
					this.Icon = config27.Icon;
					this.QualityId = config27.QualityId;
					this.AttributesDescription = config27.AttributesDescription;
					this.RefreshPhoneChatCharmConfig(config27);
					return;
				}
				if (config is Furniture)
				{
					Furniture config28 = (Furniture)config;
					this.Icon = config28.Icon;
					this.QualityId = config28.QualityId;
					this.AttributesDescription = config28.AttributesDescription;
					this.RefreshFurnitureConfig(config28);
					return;
				}
				if (config is PinballRoleConfig)
				{
					PinballRoleConfig config29 = (PinballRoleConfig)config;
					this.Icon = config29.Icon;
					this.QualityId = config29.QualityId;
					this.AttributesDescription = config29.AttributesDescription;
					this.RefreshPinballRoleConfig(config29);
					return;
				}
				if (config is PinballWeaponConfig)
				{
					PinballWeaponConfig config30 = (PinballWeaponConfig)config;
					this.Icon = config30.Icon;
					this.QualityId = config30.QualityId;
					this.AttributesDescription = config30.AttributesDescription;
					this.RefreshPinballWeaponConfig(config30);
					return;
				}
				if (config is DangoBrawlRole)
				{
					DangoBrawlRole config31 = (DangoBrawlRole)config;
					this.Icon = config31.Icon;
					this.QualityId = config31.QualityId;
					this.AttributesDescription = config31.AttributesDescription;
					this.RefreshDangoBrawlRoleConfig(config31);
					return;
				}
				if (config is Ornament)
				{
					Ornament config32 = (Ornament)config;
					this.Icon = config32.Icon;
					this.QualityId = config32.QualityId;
					this.AttributesDescription = config32.AttributesDescription;
					this.RefreshOrnamentConfig(config32);
					return;
				}
				if (config is RoverRogueCurrency)
				{
					RoverRogueCurrency config33 = (RoverRogueCurrency)config;
					this.Icon = config33.Icon;
					this.QualityId = config33.QualityId;
					this.AttributesDescription = config33.AttributesDescription;
					this.RefreshRoverRogueCurrency(config33);
				}
				return;
			}
		}

		// Token: 0x060395D9 RID: 234969 RVA: 0x00D9C180 File Offset: 0x00D9A380
		private unsafe void RefreshItemConfig(ItemInfo config)
		{
			this.ItemDataType = InventoryDefine.EItemDataType.CommonItem;
			this.ItemType = new InventoryDefine.EItemType?((InventoryDefine.EItemType)config.ItemType);
			this.MainTypeId = (InventoryDefine.EItemMainTypeId)config.MainTypeId;
			this.Name = config.Name;
			this.ItemBuffType = config.ItemBuffType;
			this.ShowInBag = config.ShowInBag;
			this.ObtainedShowDescription = config.ObtainedShowDescription;
			int num = *config.GetShowTypesBytes()[0];
			if (num != 0)
			{
				ItemShowType? itemShowTypeConfig = InventoryConfig.Instance.GetItemShowTypeConfig(num);
				if (itemShowTypeConfig != null)
				{
					this.TypeDescription = itemShowTypeConfig.Value.Name;
				}
			}
			else
			{
				this.TypeDescription = null;
			}
			this.BgDescription = config.BgDescription;
			this.IconMiddle = config.IconMiddle;
			this.IconSmall = config.IconSmall;
			this.Mesh = config.Mesh;
			this.ItemAccess = config.GetItemAccessArray();
			this.RedDotDisableRule = (InventoryDefine.ERedDotDisableRule)config.RedDotDisableRule;
			this.Parameters.Clear();
			int parametersLength = config.ParametersLength;
			for (int i = 0; i < parametersLength; i++)
			{
				DicIntInt? dicIntInt = config.Parameters(i);
				this.Parameters[dicIntInt.Value.Key] = dicIntInt.Value.Value;
			}
			this.SortIndex = config.SortIndex;
			this.ShowTypes = config.GetShowTypesArray();
			this.ExpiredConvertItemMap = config.ConvertItems();
			SpecialItemConfig instance = SpecialItemConfig.Instance;
			SpecialItem? specialItem = (instance != null) ? instance.GetConfig(this.Id) : null;
			if (((specialItem != null) ? specialItem.GetValueOrDefault().PreviewModelId : 0) > 0)
			{
				this.PreviewType = ESkipName.SkipToSummonShowView;
				this.ShowPreview = true;
			}
		}

		// Token: 0x060395DA RID: 234970 RVA: 0x00D9C350 File Offset: 0x00D9A550
		private void RefreshPhantomConfig(PhantomItem config)
		{
			this.ItemDataType = InventoryDefine.EItemDataType.PhantomItem;
			this.ItemType = new InventoryDefine.EItemType?(InventoryDefine.EItemType.Phantom);
			this.MainTypeId = InventoryDefine.EItemMainTypeId.Phantom;
			this.Name = config.MonsterName;
			this.TypeDescription = config.TypeDescription;
			this.IconMiddle = config.IconMiddle;
			this.IconSmall = config.IconSmall;
			this.Mesh = config.Mesh;
			this.ItemAccess = config.GetItemAccessArray();
			this.Parameters.Clear();
			this.SortIndex = config.SortIndex;
			this.RedDotDisableRule = (InventoryDefine.ERedDotDisableRule)config.RedDotDisableRule;
			this.ItemBuffType = 0;
			this.ShowInBag = config.ShowInBag;
			this.ObtainedShowDescription = config.ObtainedShowDescription;
			this.IconBig = config.IconBig;
		}

		// Token: 0x060395DB RID: 234971 RVA: 0x00D9C41C File Offset: 0x00D9A61C
		private void RefreshRogueCurrency(RogueCurrency config)
		{
			this.ItemDataType = InventoryDefine.EItemDataType.RogueCurrency;
			this.QualityId = config.QualityId;
			this.ItemType = new InventoryDefine.EItemType?(InventoryDefine.EItemType.RogueCurrency);
			this.MainTypeId = InventoryDefine.EItemMainTypeId.Common;
			this.TypeDescription = config.TypeDescription;
			this.BgDescription = config.BgDescription;
			this.IconMiddle = config.IconMiddle;
			this.IconSmall = config.IconSmall;
			this.ItemAccess = config.GetItemAccessArray();
			this.Parameters.Clear();
			this.SortIndex = config.SortIndex;
			this.RedDotDisableRule = (InventoryDefine.ERedDotDisableRule)config.RedDotDisableRule;
			this.ItemBuffType = 0;
			this.Name = config.Title;
			this.ShowInBag = config.ShowInBag;
			this.ObtainedShowDescription = config.ObtainedShowDescription;
		}

		// Token: 0x060395DC RID: 234972 RVA: 0x00D9C4E8 File Offset: 0x00D9A6E8
		private void RefreshRogueResCurrency(RogueResCurrency config)
		{
			this.ItemDataType = InventoryDefine.EItemDataType.RogueResCurrency;
			this.QualityId = config.QualityId;
			this.ItemType = new InventoryDefine.EItemType?(InventoryDefine.EItemType.RogueCurrency);
			this.MainTypeId = InventoryDefine.EItemMainTypeId.Common;
			this.TypeDescription = config.TypeDescription;
			this.BgDescription = config.BgDescription;
			this.IconMiddle = config.IconMiddle;
			this.IconSmall = config.IconSmall;
			this.ItemAccess = config.GetItemAccessArray();
			this.Parameters.Clear();
			this.SortIndex = config.SortIndex;
			this.RedDotDisableRule = (InventoryDefine.ERedDotDisableRule)config.RedDotDisableRule;
			this.ItemBuffType = 0;
			this.Name = config.Title;
			this.ShowInBag = config.ShowInBag;
			this.ObtainedShowDescription = config.ObtainedShowDescription;
		}

		// Token: 0x060395DD RID: 234973 RVA: 0x00D9C5B4 File Offset: 0x00D9A7B4
		private void RefreshWeaponConfig(WeaponConf config)
		{
			this.ItemDataType = InventoryDefine.EItemDataType.WeaponItem;
			this.ItemType = new InventoryDefine.EItemType?(InventoryDefine.EItemType.Weapon);
			this.MainTypeId = InventoryDefine.EItemMainTypeId.Weapon;
			this.Name = config.WeaponName;
			this.TypeDescription = config.TypeDescription;
			this.BgDescription = config.BgDescription;
			this.IconMiddle = config.IconMiddle;
			this.IconSmall = config.IconSmall;
			this.Mesh = config.Mesh;
			this.ItemAccess = config.GetItemAccessArray();
			this.Parameters.Clear();
			this.SortIndex = config.SortIndex;
			this.RedDotDisableRule = (InventoryDefine.ERedDotDisableRule)config.RedDotDisableRule;
			this.ItemBuffType = 0;
			this.ShowInBag = config.ShowInBag;
			this.ObtainedShowDescription = config.ObtainedShowDescription;
			this.IconBig = config.IconBig;
		}

		// Token: 0x060395DE RID: 234974 RVA: 0x00D9C68C File Offset: 0x00D9A88C
		private void RefreshFlySkinConfig(FlySkinConfig config)
		{
			this.ItemDataType = InventoryDefine.EItemDataType.FlySkinItem;
			this.QualityId = config.QualityId;
			this.ItemType = new InventoryDefine.EItemType?(InventoryDefine.EItemType.FlySkin);
			this.MainTypeId = InventoryDefine.EItemMainTypeId.Common;
			this.Name = config.Name;
			this.TypeDescription = config.TypeDescription;
			this.BgDescription = config.BgDescription;
			this.IconMiddle = config.IconMiddle;
			this.IconSmall = config.IconSmall;
			this.Mesh = config.Mesh;
			this.ItemAccess = config.GetItemAccessArray();
			this.Parameters.Clear();
			this.SortIndex = config.SortIndex;
			this.RedDotDisableRule = (InventoryDefine.ERedDotDisableRule)config.RedDotDisableRule;
			this.ShowInBag = config.ShowInBag;
			this.ObtainedShowDescription = config.ObtainedShowDescription;
		}

		// Token: 0x060395DF RID: 234975 RVA: 0x00D9C75C File Offset: 0x00D9A95C
		private void RefreshWeaponSkinConfig(WeaponSkin config)
		{
			this.ItemDataType = InventoryDefine.EItemDataType.WeaponSkinItem;
			this.ItemType = new InventoryDefine.EItemType?(InventoryDefine.EItemType.WeaponSkin);
			this.MainTypeId = InventoryDefine.EItemMainTypeId.Common;
			this.Name = config.Name;
			this.TypeDescription = config.TypeDescription;
			this.BgDescription = config.BgDescription;
			this.IconMiddle = config.IconMiddle;
			this.IconSmall = config.IconSmall;
			this.Mesh = config.Mesh;
			this.ItemAccess = config.GetItemAccessArray();
			this.Parameters.Clear();
			this.SortIndex = config.SortIndex;
			this.RedDotDisableRule = (InventoryDefine.ERedDotDisableRule)config.RedDotDisableRule;
			this.ShowInBag = config.ShowInBag;
			this.ObtainedShowDescription = config.ObtainedShowDescription;
		}

		// Token: 0x060395E0 RID: 234976 RVA: 0x00D9C820 File Offset: 0x00D9AA20
		private void RefreshPlayerHeadConfig(PlayerHeadRe config)
		{
			this.ItemDataType = InventoryDefine.EItemDataType.PlayerHeadItem;
			this.ItemType = new InventoryDefine.EItemType?(InventoryDefine.EItemType.PlayerHead);
			this.MainTypeId = InventoryDefine.EItemMainTypeId.Common;
			this.Name = config.Name;
			this.TypeDescription = config.TypeDescription;
			this.BgDescription = config.BgDescription;
			this.IconMiddle = config.IconMiddle;
			this.IconSmall = config.IconSmall;
			this.ItemAccess = config.GetItemAccessArray();
			this.Parameters.Clear();
			this.SortIndex = config.SortIndex;
			this.RedDotDisableRule = (InventoryDefine.ERedDotDisableRule)config.RedDotDisableRule;
			this.ShowInBag = config.ShowInBag;
			this.ObtainedShowDescription = config.ObtainedShowDescription;
		}

		// Token: 0x060395E1 RID: 234977 RVA: 0x00D9C8D8 File Offset: 0x00D9AAD8
		private void RefreshRoleSkinConfig(RoleSkin config)
		{
			this.ItemDataType = InventoryDefine.EItemDataType.RoleSkinItem;
			this.ItemType = new InventoryDefine.EItemType?(InventoryDefine.EItemType.RoleSkin);
			this.MainTypeId = InventoryDefine.EItemMainTypeId.Common;
			this.Name = config.Name;
			this.TypeDescription = config.TypeDescription;
			this.BgDescription = config.BgDescription;
			this.IconMiddle = config.IconMiddle;
			this.IconSmall = config.IconSmall;
			this.ItemAccess = config.GetItemAccessArray();
			this.Parameters.Clear();
			this.SortIndex = config.SortIndex;
			this.RedDotDisableRule = (InventoryDefine.ERedDotDisableRule)config.RedDotDisableRule;
			this.ShowInBag = config.ShowInBag;
			this.ObtainedShowDescription = config.ObtainedShowDescription;
		}

		// Token: 0x060395E2 RID: 234978 RVA: 0x00D9C990 File Offset: 0x00D9AB90
		private void RefreshAbyssItemConfig(AbyssItem config)
		{
			this.ItemDataType = InventoryDefine.EItemDataType.DangoAbyssItem;
			this.ItemType = new InventoryDefine.EItemType?(InventoryDefine.EItemType.AbyssItem);
			this.MainTypeId = InventoryDefine.EItemMainTypeId.Common;
			this.Name = config.Name;
			this.TypeDescription = config.TypeDescription;
			this.BgDescription = config.BgDescription;
			this.IconMiddle = config.IconMiddle;
			this.IconSmall = config.IconSmall;
			this.ItemAccess = null;
			this.Parameters.Clear();
			this.SortIndex = 0;
			this.RedDotDisableRule = InventoryDefine.ERedDotDisableRule.None;
			this.ShowInBag = true;
			this.ObtainedShowDescription = "";
			this.AttributesDescription = config.AttributesDescription;
			AbyssQuality? abyssQualityById = DangoAbyssConfig.Instance.GetAbyssQualityById(config.QualityId);
			this.Mesh = (((abyssQualityById != null) ? abyssQualityById.GetValueOrDefault().Mesh : null) ?? "");
		}

		// Token: 0x060395E3 RID: 234979 RVA: 0x00D9CA78 File Offset: 0x00D9AC78
		private void RefreshRoleConfig(RoleInfo config)
		{
			SModelConfig modelConfig = ModelUtil.GetModelConfig(config.MeshId);
			this.ItemDataType = InventoryDefine.EItemDataType.RoleItem;
			this.ItemType = null;
			this.MainTypeId = InventoryDefine.EItemMainTypeId.Common;
			this.Name = config.Name;
			this.TypeDescription = null;
			this.BgDescription = null;
			this.IconMiddle = config.RoleHeadIconBig;
			this.IconSmall = config.RoleHeadIcon;
			this.Icon = config.RoleHeadIconLarge;
			this.Mesh = ((modelConfig != null) ? modelConfig.网格体.ToAssetPathName() : null);
			this.ItemAccess = null;
			this.Parameters.Clear();
			this.SortIndex = 0;
			this.RedDotDisableRule = (InventoryDefine.ERedDotDisableRule)config.RedDotDisableRule;
			this.ItemBuffType = 0;
			this.ShowInBag = config.ShowInBag;
			this.ObtainedShowDescription = config.ObtainedShowDescription;
		}

		// Token: 0x060395E4 RID: 234980 RVA: 0x00D9CB4C File Offset: 0x00D9AD4C
		private void RefreshCardConfig(BackgroundCard config)
		{
			this.ItemDataType = InventoryDefine.EItemDataType.CardItem;
			this.ItemType = new InventoryDefine.EItemType?(InventoryDefine.EItemType.Card);
			this.MainTypeId = InventoryDefine.EItemMainTypeId.Card;
			this.Name = config.Title;
			this.TypeDescription = config.TypeDescription;
			this.BgDescription = config.BgDescription;
			this.IconMiddle = config.IconMiddle;
			this.IconSmall = config.IconSmall;
			this.Mesh = null;
			this.ItemAccess = config.GetItemAccessArray();
			this.Parameters.Clear();
			this.SortIndex = 0;
			this.RedDotDisableRule = (InventoryDefine.ERedDotDisableRule)config.RedDotDisableRule;
			this.ItemBuffType = 0;
			this.ShowInBag = config.ShowInBag;
			this.ObtainedShowDescription = config.ObtainedShowDescription;
		}

		// Token: 0x060395E5 RID: 234981 RVA: 0x00D9CC0C File Offset: 0x00D9AE0C
		private void RefreshPreviewItem(PreviewItem config)
		{
			this.ItemDataType = InventoryDefine.EItemDataType.PreviewItem;
			this.ItemType = new InventoryDefine.EItemType?(InventoryDefine.EItemType.Phantom);
			this.MainTypeId = InventoryDefine.EItemMainTypeId.Phantom;
			this.Name = config.Name;
			int num = config.ShowTypes(0);
			if (num != 0)
			{
				ItemShowType? itemShowTypeConfig = InventoryConfig.Instance.GetItemShowTypeConfig(num);
				if (itemShowTypeConfig != null)
				{
					this.TypeDescription = itemShowTypeConfig.Value.Name;
				}
			}
			else
			{
				this.TypeDescription = null;
			}
			this.BgDescription = config.BgDescription;
			this.IconMiddle = config.IconMiddle;
			this.IconSmall = config.IconSmall;
			this.Mesh = null;
			this.ItemAccess = config.GetPreviewItemAccessArray();
			this.Parameters.Clear();
			this.SortIndex = 0;
			this.RedDotDisableRule = InventoryDefine.ERedDotDisableRule.None;
			this.ItemBuffType = 0;
			this.ShowTypes = config.GetShowTypesArray();
			this.IconBig = config.IconBig;
		}

		// Token: 0x060395E6 RID: 234982 RVA: 0x00D9CCF8 File Offset: 0x00D9AEF8
		private void RefreshPhantomArenaCardConfig(PhantomBattleCard config)
		{
			this.ItemDataType = InventoryDefine.EItemDataType.PhantomArenaCard;
			this.ItemType = new InventoryDefine.EItemType?(InventoryDefine.EItemType.PhantomArenaCard);
			this.MainTypeId = InventoryDefine.EItemMainTypeId.Common;
			this.Name = config.Name;
			this.TypeDescription = config.TypeDescription;
			this.BgDescription = config.BgDescription;
			this.IconMiddle = config.IconMiddle;
			this.IconSmall = config.IconSmall;
			this.ItemAccess = null;
			this.Parameters.Clear();
			this.SortIndex = 0;
			this.RedDotDisableRule = InventoryDefine.ERedDotDisableRule.None;
			this.ShowInBag = config.ShowInBag;
			this.ObtainedShowDescription = "";
			this.AttributesDescription = config.AttributesDescription;
		}

		// Token: 0x060395E7 RID: 234983 RVA: 0x00D9CDAC File Offset: 0x00D9AFAC
		private void RefreshPhantomArenaBadgeConfig(PhantomBattleBadge config)
		{
			this.ItemDataType = InventoryDefine.EItemDataType.PhantomArenaBadge;
			this.ItemType = new InventoryDefine.EItemType?(InventoryDefine.EItemType.PhantomArenaBadge);
			this.MainTypeId = InventoryDefine.EItemMainTypeId.Common;
			this.Name = config.Name;
			this.TypeDescription = config.TypeDescription;
			this.BgDescription = config.BgDescription;
			this.IconMiddle = config.IconMiddle;
			this.IconSmall = config.IconSmall;
			this.ItemAccess = null;
			this.Parameters.Clear();
			this.SortIndex = 0;
			this.RedDotDisableRule = InventoryDefine.ERedDotDisableRule.None;
			this.ShowInBag = config.ShowInBag;
			this.ObtainedShowDescription = "";
			this.AttributesDescription = config.AttributesDescription;
		}

		// Token: 0x060395E8 RID: 234984 RVA: 0x00D9CE60 File Offset: 0x00D9B060
		private void RefreshHonamiStoryItemConfig(HonamiStoryItem config)
		{
			this.ItemDataType = InventoryDefine.EItemDataType.HonamiStoryItem;
			this.ItemType = new InventoryDefine.EItemType?(InventoryDefine.EItemType.HonamiStoryItem);
			this.MainTypeId = InventoryDefine.EItemMainTypeId.Common;
			this.Name = config.Name;
			this.TypeDescription = config.TypeDescription;
			this.BgDescription = config.BgDescription;
			this.IconMiddle = config.IconMiddle;
			this.IconSmall = config.IconSmall;
			this.ItemAccess = null;
			this.Parameters.Clear();
			this.SortIndex = 0;
			this.RedDotDisableRule = InventoryDefine.ERedDotDisableRule.None;
			this.ShowInBag = true;
			this.ObtainedShowDescription = "";
			this.AttributesDescription = config.AttributesDescription;
			this.Mesh = config.Mesh;
		}

		// Token: 0x060395E9 RID: 234985 RVA: 0x00D9CF18 File Offset: 0x00D9B118
		private void RefreshHonamiStoryWeaponConfig(HonamiStoryWeapon config)
		{
			this.ItemDataType = InventoryDefine.EItemDataType.HonamiStoryWeapon;
			this.ItemType = new InventoryDefine.EItemType?(InventoryDefine.EItemType.HonamiStoryWeapon);
			this.MainTypeId = InventoryDefine.EItemMainTypeId.Common;
			this.Name = config.Name;
			int attributesDescriptionArgsLength = config.AttributesDescriptionArgsLength;
			string[] array = new string[attributesDescriptionArgsLength];
			for (int i = 0; i < attributesDescriptionArgsLength; i++)
			{
				array[i] = config.AttributesDescriptionArgs(i);
			}
			this.AttributesDescriptionArgs = array;
			this.TypeDescription = config.TypeDescription;
		}

		// Token: 0x060395EA RID: 234986 RVA: 0x00D9CF88 File Offset: 0x00D9B188
		private void RefreshCalabashSkinConfig(CalabashSkin config)
		{
			this.ItemDataType = InventoryDefine.EItemDataType.CalabashSkinItem;
			this.ItemType = new InventoryDefine.EItemType?(InventoryDefine.EItemType.CalabashSkin);
			this.MainTypeId = InventoryDefine.EItemMainTypeId.Common;
			this.Name = config.Name;
			this.TypeDescription = config.TypeDescription;
			this.BgDescription = config.BgDescription;
			this.IconMiddle = config.IconMiddle;
			this.IconSmall = config.IconSmall;
			this.Mesh = null;
			this.ItemAccess = config.GetItemAccessArray();
			this.Parameters.Clear();
			this.SortIndex = config.SortIndex;
			this.RedDotDisableRule = (InventoryDefine.ERedDotDisableRule)config.RedDotDisableRule;
			this.ShowInBag = config.ShowInBag;
			this.ObtainedShowDescription = config.ObtainedShowDescription;
		}

		// Token: 0x060395EB RID: 234987 RVA: 0x00D9D048 File Offset: 0x00D9B248
		private unsafe void RefreshInfrastructureItemConfig(ItemInfo config)
		{
			this.ItemDataType = InventoryDefine.EItemDataType.InfrastructureItem;
			this.ItemType = new InventoryDefine.EItemType?(InventoryDefine.EItemType.InfrastructureItem);
			this.MainTypeId = InventoryDefine.EItemMainTypeId.Common;
			this.Name = config.Name;
			int num = *config.GetShowTypesBytes()[0];
			if (num != 0)
			{
				ItemShowType? itemShowTypeConfig = InventoryConfig.Instance.GetItemShowTypeConfig(num);
				if (itemShowTypeConfig != null)
				{
					this.TypeDescription = itemShowTypeConfig.Value.Name;
				}
			}
			else
			{
				this.TypeDescription = null;
			}
			this.BgDescription = config.BgDescription;
			this.IconMiddle = config.IconMiddle;
			this.IconSmall = config.IconSmall;
			this.Mesh = null;
		}

		// Token: 0x060395EC RID: 234988 RVA: 0x00D9D0F8 File Offset: 0x00D9B2F8
		private void RefreshMotorFrameConfig(MotorFrame config)
		{
			this.ItemDataType = InventoryDefine.EItemDataType.MotorFrameItem;
			this.ItemType = new InventoryDefine.EItemType?(InventoryDefine.EItemType.MotorFrame);
			this.MainTypeId = InventoryDefine.EItemMainTypeId.Common;
			this.Name = config.Title;
			this.TypeDescription = config.TypeDescription;
			this.Icon = config.Icon;
			this.IconMiddle = config.IconMiddle;
			this.IconSmall = config.IconSmall;
			this.ItemAccess = config.GetItemAccessArray();
			this.ShowInBag = config.ShowInBag;
			this.ObtainedShowDescription = config.ObtainedShowDescription;
			this.Mesh = null;
			this.IconBig = config.IconBig;
		}

		// Token: 0x060395ED RID: 234989 RVA: 0x00D9D1A0 File Offset: 0x00D9B3A0
		private void RefreshMotorStickerConfig(MotorSticker config)
		{
			this.ItemDataType = InventoryDefine.EItemDataType.MotorStickerItem;
			this.ItemType = new InventoryDefine.EItemType?(InventoryDefine.EItemType.MotorSticker);
			this.MainTypeId = InventoryDefine.EItemMainTypeId.Common;
			this.Name = config.Title;
			this.TypeDescription = config.TypeDescription;
			this.Icon = config.Icon;
			this.IconMiddle = config.IconMiddle;
			this.IconSmall = config.IconSmall;
			this.ItemAccess = config.GetItemAccessArray();
			this.ShowInBag = config.ShowInBag;
			this.ObtainedShowDescription = config.ObtainedShowDescription;
			this.Mesh = null;
		}

		// Token: 0x060395EE RID: 234990 RVA: 0x00D9D238 File Offset: 0x00D9B438
		private void RefreshMotorDecorationConfig(MotorDecorations config)
		{
			this.ItemDataType = InventoryDefine.EItemDataType.MotorDecorationItem;
			this.ItemType = new InventoryDefine.EItemType?(InventoryDefine.EItemType.MotorDecoration);
			this.MainTypeId = InventoryDefine.EItemMainTypeId.Common;
			this.Name = config.Title;
			this.TypeDescription = config.TypeDescription;
			this.Icon = config.Icon;
			this.IconMiddle = config.IconMiddle;
			this.IconSmall = config.IconSmall;
			this.ItemAccess = config.GetItemAccessArray();
			this.ShowInBag = config.ShowInBag;
			this.ObtainedShowDescription = config.ObtainedShowDescription;
			this.Mesh = null;
		}

		// Token: 0x060395EF RID: 234991 RVA: 0x00D9D2D0 File Offset: 0x00D9B4D0
		private void RefreshMotorSkinConfig(MotorSkin config)
		{
			this.ItemDataType = InventoryDefine.EItemDataType.MotorSkinItem;
			this.ItemType = new InventoryDefine.EItemType?(InventoryDefine.EItemType.MotorSkin);
			this.MainTypeId = InventoryDefine.EItemMainTypeId.Common;
			this.Name = config.Name;
			this.TypeDescription = config.TypeDescription;
			this.Icon = config.Icon;
			this.IconBig = config.IconBig;
			this.IconMiddle = config.IconMiddle;
			this.IconSmall = config.IconSmall;
			this.ItemAccess = config.GetItemAccessArray();
			this.ShowInBag = config.ShowInBag;
			this.ObtainedShowDescription = config.ObtainedShowDescription;
			this.Mesh = null;
		}

		// Token: 0x060395F0 RID: 234992 RVA: 0x00D9D378 File Offset: 0x00D9B578
		private void RefreshPhoneChatDialogShowConfig(ChatDialog config)
		{
			this.ItemDataType = InventoryDefine.EItemDataType.PhoneChatDialog;
			this.ItemType = new InventoryDefine.EItemType?(InventoryDefine.EItemType.PhoneChatDialog);
			this.MainTypeId = InventoryDefine.EItemMainTypeId.Common;
			this.PreviewType = ESkipName.SkipToPhoneMsgSetting;
			this.Name = config.Name;
			this.Icon = config.Icon;
			this.IconMiddle = config.IconMiddle;
			this.IconSmall = config.IconSmall;
			this.TypeDescription = config.TypeDescription;
			this.AttributesDescription = config.AttributesDescription;
			this.BgDescription = config.BgDescription;
			this.ItemAccess = config.GetItemAccessArray();
			this.Parameters.Clear();
			this.SortIndex = 0;
			this.RedDotDisableRule = InventoryDefine.ERedDotDisableRule.None;
			this.ShowInBag = true;
			this.ObtainedShowDescription = "";
			this.ShowPreview = true;
		}

		// Token: 0x060395F1 RID: 234993 RVA: 0x00D9D448 File Offset: 0x00D9B648
		private void RefreshPhoneChatBackGroundConfig(ChatBg config)
		{
			this.ItemDataType = InventoryDefine.EItemDataType.PhoneChatBackGround;
			this.ItemType = new InventoryDefine.EItemType?(InventoryDefine.EItemType.PhoneChatBackGround);
			this.MainTypeId = InventoryDefine.EItemMainTypeId.Common;
			this.PreviewType = ESkipName.SkipToPhoneMsgSetting;
			this.Name = config.Name;
			this.Icon = config.Icon;
			this.IconMiddle = config.IconMiddle;
			this.IconSmall = config.IconSmall;
			this.TypeDescription = config.TypeDescription;
			this.AttributesDescription = config.AttributesDescription;
			this.BgDescription = config.BgDescription;
			this.ItemAccess = config.GetItemAccessArray();
			this.Parameters.Clear();
			this.SortIndex = 0;
			this.RedDotDisableRule = InventoryDefine.ERedDotDisableRule.None;
			this.ShowInBag = true;
			this.ObtainedShowDescription = "";
			this.ShowPreview = true;
		}

		// Token: 0x060395F2 RID: 234994 RVA: 0x00D9D518 File Offset: 0x00D9B718
		private void RefreshPhoneChatThemeConfig(ChatTheme config)
		{
			this.ItemDataType = InventoryDefine.EItemDataType.PhoneChatTheme;
			this.ItemType = new InventoryDefine.EItemType?(InventoryDefine.EItemType.PhoneChatTheme);
			this.MainTypeId = InventoryDefine.EItemMainTypeId.Common;
			this.PreviewType = ESkipName.SkipToPhoneMsgSetting;
			this.Name = config.Name;
			this.Icon = config.Icon;
			this.IconMiddle = config.IconMiddle;
			this.IconSmall = config.IconSmall;
			this.TypeDescription = config.TypeDescription;
			this.AttributesDescription = config.AttributesDescription;
			this.BgDescription = config.BgDescription;
			this.ItemAccess = config.GetItemAccessArray();
			this.Parameters.Clear();
			this.SortIndex = 0;
			this.RedDotDisableRule = InventoryDefine.ERedDotDisableRule.None;
			this.ShowInBag = true;
			this.ObtainedShowDescription = "";
			this.ShowPreview = true;
		}

		// Token: 0x060395F3 RID: 234995 RVA: 0x00D9D5E8 File Offset: 0x00D9B7E8
		private void RefreshPhoneChatCharmConfig(ChatCharm config)
		{
			this.ItemDataType = InventoryDefine.EItemDataType.PhoneChatCharm;
			this.ItemType = new InventoryDefine.EItemType?(InventoryDefine.EItemType.PhoneChatCharm);
			this.MainTypeId = InventoryDefine.EItemMainTypeId.Common;
			this.PreviewType = ESkipName.SkipToPhoneMsgSetting;
			this.Name = config.Name;
			this.Icon = config.Icon;
			this.IconMiddle = config.IconMiddle;
			this.IconSmall = config.IconSmall;
			this.TypeDescription = config.TypeDescription;
			this.AttributesDescription = config.AttributesDescription;
			this.BgDescription = config.BgDescription;
			this.ItemAccess = config.GetItemAccessArray();
			this.Parameters.Clear();
			this.SortIndex = 0;
			this.RedDotDisableRule = InventoryDefine.ERedDotDisableRule.None;
			this.ShowInBag = true;
			this.ObtainedShowDescription = "";
			this.ShowPreview = true;
		}

		// Token: 0x060395F4 RID: 234996 RVA: 0x00D9D6B8 File Offset: 0x00D9B8B8
		private void RefreshFurnitureConfig(Furniture config)
		{
			this.ItemDataType = InventoryDefine.EItemDataType.FurnitureItem;
			this.ItemType = new InventoryDefine.EItemType?(InventoryDefine.EItemType.Furniture);
			this.MainTypeId = InventoryDefine.EItemMainTypeId.Common;
			this.Name = config.Name;
			this.Icon = config.Icon;
			this.IconMiddle = config.IconMiddle;
			this.IconSmall = config.Icon;
			this.Mesh = null;
			this.Parameters.Clear();
			this.SortIndex = 0;
			this.ItemBuffType = 0;
			this.ShowInBag = false;
		}

		// Token: 0x060395F5 RID: 234997 RVA: 0x00D9D740 File Offset: 0x00D9B940
		private void RefreshPinballRoleConfig(PinballRoleConfig config)
		{
			this.ItemDataType = InventoryDefine.EItemDataType.PinballRoleItem;
			this.ItemType = new InventoryDefine.EItemType?(InventoryDefine.EItemType.PinballRole);
			this.MainTypeId = InventoryDefine.EItemMainTypeId.Common;
			RoleInfo? roleInfo;
			this.Name = (((RoleConfig.Instance.GetRoleConfig(config.RoleId) != null) ? roleInfo.GetValueOrDefault().Name : null) ?? "");
		}

		// Token: 0x060395F6 RID: 234998 RVA: 0x00D9D7A5 File Offset: 0x00D9B9A5
		private void RefreshPinballWeaponConfig(PinballWeaponConfig config)
		{
			this.ItemDataType = InventoryDefine.EItemDataType.PinballWeaponItem;
			this.ItemType = new InventoryDefine.EItemType?(InventoryDefine.EItemType.PinballWeapon);
			this.MainTypeId = InventoryDefine.EItemMainTypeId.Common;
			this.Name = config.Name;
			this.QualityId = config.QualityId;
		}

		// Token: 0x060395F7 RID: 234999 RVA: 0x00D9D7DD File Offset: 0x00D9B9DD
		private void RefreshDangoBrawlRoleConfig(DangoBrawlRole config)
		{
			this.ItemDataType = InventoryDefine.EItemDataType.DangoBrawlRoleItem;
			this.ItemType = new InventoryDefine.EItemType?(InventoryDefine.EItemType.DangoBrawlRole);
			this.MainTypeId = InventoryDefine.EItemMainTypeId.Common;
			this.Name = config.Name;
			this.QualityId = config.QualityId;
		}

		// Token: 0x060395F8 RID: 235000 RVA: 0x00D9D818 File Offset: 0x00D9BA18
		private void RefreshOrnamentConfig(Ornament config)
		{
			this.ItemDataType = InventoryDefine.EItemDataType.OrnamentItem;
			this.ItemType = new InventoryDefine.EItemType?(InventoryDefine.EItemType.Ornament);
			this.MainTypeId = InventoryDefine.EItemMainTypeId.Common;
			this.PreviewType = ESkipName.SkipToRoleOrnamentId;
			this.Name = config.Name;
			this.TypeDescription = config.TypeDescription;
			this.BgDescription = config.BgDescription;
			this.IconMiddle = config.IconMiddle;
			this.IconSmall = config.IconSmall;
			this.ItemAccess = config.GetItemAccessArray();
			this.Parameters.Clear();
			this.SortIndex = 0;
			this.RedDotDisableRule = (InventoryDefine.ERedDotDisableRule)config.RedDotDisableRule;
			this.ShowInBag = config.ShowInBag;
			this.ObtainedShowDescription = config.ObtainedShowDescription;
			this.ShowPreview = true;
		}

		// Token: 0x060395F9 RID: 235001 RVA: 0x00D9D8D8 File Offset: 0x00D9BAD8
		private void RefreshRoverRogueCurrency(RoverRogueCurrency config)
		{
			this.ItemDataType = InventoryDefine.EItemDataType.RoverRogueCurrency;
			this.QualityId = config.QualityId;
			this.ItemType = new InventoryDefine.EItemType?(InventoryDefine.EItemType.RogueCurrency);
			this.MainTypeId = InventoryDefine.EItemMainTypeId.Common;
			this.TypeDescription = config.TypeDescription;
			this.BgDescription = config.BgDescription;
			this.IconMiddle = config.IconMiddle;
			this.IconSmall = config.IconSmall;
			this.ItemAccess = config.GetItemAccessArray();
			this.Parameters.Clear();
			this.SortIndex = 0;
			this.RedDotDisableRule = InventoryDefine.ERedDotDisableRule.None;
			this.ItemBuffType = 0;
			this.Name = config.Title;
			this.ShowInBag = false;
			this.ObtainedShowDescription = config.ObtainedShowDescription;
		}

		// Token: 0x0401E022 RID: 122914
		public int Id;

		// Token: 0x0401E023 RID: 122915
		public InventoryDefine.EItemDataType ItemDataType;

		// Token: 0x0401E024 RID: 122916
		public InventoryDefine.EItemType? ItemType;

		// Token: 0x0401E025 RID: 122917
		public InventoryDefine.EItemMainTypeId MainTypeId = InventoryDefine.EItemMainTypeId.Common;

		// Token: 0x0401E026 RID: 122918
		public string Name = "";

		// Token: 0x0401E027 RID: 122919
		[Nullable(2)]
		public string TypeDescription;

		// Token: 0x0401E028 RID: 122920
		public string AttributesDescription = "";

		// Token: 0x0401E029 RID: 122921
		public string[] AttributesDescriptionArgs = Array.Empty<string>();

		// Token: 0x0401E02A RID: 122922
		public string ObtainedShowDescription = "";

		// Token: 0x0401E02B RID: 122923
		[Nullable(2)]
		public string BgDescription;

		// Token: 0x0401E02C RID: 122924
		public bool ShowInBag;

		// Token: 0x0401E02D RID: 122925
		public string Icon = "";

		// Token: 0x0401E02E RID: 122926
		[Nullable(2)]
		public string IconBig;

		// Token: 0x0401E02F RID: 122927
		[Nullable(2)]
		public string IconMiddle;

		// Token: 0x0401E030 RID: 122928
		[Nullable(2)]
		public string IconSmall;

		// Token: 0x0401E031 RID: 122929
		[Nullable(2)]
		public string Mesh;

		// Token: 0x0401E032 RID: 122930
		public int QualityId;

		// Token: 0x0401E033 RID: 122931
		[Nullable(2)]
		public int[] ItemAccess = Array.Empty<int>();

		// Token: 0x0401E034 RID: 122932
		public int SortIndex;

		// Token: 0x0401E035 RID: 122933
		public InventoryDefine.ERedDotDisableRule RedDotDisableRule;

		// Token: 0x0401E036 RID: 122934
		public Dictionary<int, int> Parameters = new Dictionary<int, int>();

		// Token: 0x0401E037 RID: 122935
		public Dictionary<int, int> ExpiredConvertItemMap = new Dictionary<int, int>();

		// Token: 0x0401E038 RID: 122936
		public int ItemBuffType;

		// Token: 0x0401E039 RID: 122937
		public int[] ShowTypes = Array.Empty<int>();

		// Token: 0x0401E03A RID: 122938
		public ESkipName PreviewType = ESkipName.NoSkip;

		// Token: 0x0401E03B RID: 122939
		public bool ShowPreview;
	}
}
