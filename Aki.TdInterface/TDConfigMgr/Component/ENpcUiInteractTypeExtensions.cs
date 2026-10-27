using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009BA RID: 2490
	public static class ENpcUiInteractTypeExtensions
	{
		// Token: 0x06003776 RID: 14198 RVA: 0x00090304 File Offset: 0x0008E504
		public static string ToEnumString(this ENpcUiInteractType value)
		{
			string result;
			switch (value)
			{
			case ENpcUiInteractType.HandInItem:
				result = "HandInItem";
				break;
			case ENpcUiInteractType.Shop:
				result = "Shop";
				break;
			case ENpcUiInteractType.AntiqueShop:
				result = "AntiqueShop";
				break;
			case ENpcUiInteractType.ChengXiaoShanShop:
				result = "ChengXiaoShanShop";
				break;
			case ENpcUiInteractType.Gramophone:
				result = "Gramophone";
				break;
			case ENpcUiInteractType.SoundBox3:
				result = "SoundBox3";
				break;
			case ENpcUiInteractType.SunSpirit:
				result = "SunSpirit";
				break;
			case ENpcUiInteractType.ShopNew:
				result = "ShopNew";
				break;
			case ENpcUiInteractType.VillageInfr:
				result = "VillageInfr";
				break;
			case ENpcUiInteractType.SoundBox35:
				result = "SoundBox35";
				break;
			case ENpcUiInteractType.DollGrabDelivery:
				result = "DollGrabDelivery";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003777 RID: 14199 RVA: 0x000903AC File Offset: 0x0008E5AC
		public static ENpcUiInteractType FromString(string name)
		{
			ENpcUiInteractType result;
			if (!ENpcUiInteractTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ENpcUiInteractType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003778 RID: 14200 RVA: 0x000903D8 File Offset: 0x0008E5D8
		public static bool TryFromString(string name, out ENpcUiInteractType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ENpcUiInteractType.HandInItem;
				return false;
			}
			if (name != null)
			{
				int length = name.Length;
				switch (length)
				{
				case 4:
					if (name == "Shop")
					{
						value = ENpcUiInteractType.Shop;
						return true;
					}
					break;
				case 5:
				case 6:
				case 8:
					break;
				case 7:
					if (name == "ShopNew")
					{
						value = ENpcUiInteractType.ShopNew;
						return true;
					}
					break;
				case 9:
				{
					char c = name[1];
					if (c != 'o')
					{
						if (c == 'u')
						{
							if (name == "SunSpirit")
							{
								value = ENpcUiInteractType.SunSpirit;
								return true;
							}
						}
					}
					else if (name == "SoundBox3")
					{
						value = ENpcUiInteractType.SoundBox3;
						return true;
					}
					break;
				}
				case 10:
				{
					char c = name[0];
					if (c != 'G')
					{
						if (c != 'H')
						{
							if (c == 'S')
							{
								if (name == "SoundBox35")
								{
									value = ENpcUiInteractType.SoundBox35;
									return true;
								}
							}
						}
						else if (name == "HandInItem")
						{
							value = ENpcUiInteractType.HandInItem;
							return true;
						}
					}
					else if (name == "Gramophone")
					{
						value = ENpcUiInteractType.Gramophone;
						return true;
					}
					break;
				}
				case 11:
				{
					char c = name[0];
					if (c != 'A')
					{
						if (c == 'V')
						{
							if (name == "VillageInfr")
							{
								value = ENpcUiInteractType.VillageInfr;
								return true;
							}
						}
					}
					else if (name == "AntiqueShop")
					{
						value = ENpcUiInteractType.AntiqueShop;
						return true;
					}
					break;
				}
				default:
					if (length != 16)
					{
						if (length == 17)
						{
							if (name == "ChengXiaoShanShop")
							{
								value = ENpcUiInteractType.ChengXiaoShanShop;
								return true;
							}
						}
					}
					else if (name == "DollGrabDelivery")
					{
						value = ENpcUiInteractType.DollGrabDelivery;
						return true;
					}
					break;
				}
			}
			value = ENpcUiInteractType.HandInItem;
			return false;
		}

		// Token: 0x06003779 RID: 14201 RVA: 0x0009058C File Offset: 0x0008E78C
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"HandInItem",
				"Shop",
				"AntiqueShop",
				"ChengXiaoShanShop",
				"Gramophone",
				"SoundBox3",
				"SunSpirit",
				"ShopNew",
				"VillageInfr",
				"SoundBox35",
				"DollGrabDelivery"
			};
		}

		// Token: 0x0600377A RID: 14202 RVA: 0x000905FA File Offset: 0x0008E7FA
		public static ENpcUiInteractType[] GetValues()
		{
			return new ENpcUiInteractType[]
			{
				ENpcUiInteractType.HandInItem,
				ENpcUiInteractType.Shop,
				ENpcUiInteractType.AntiqueShop,
				ENpcUiInteractType.ChengXiaoShanShop,
				ENpcUiInteractType.Gramophone,
				ENpcUiInteractType.SoundBox3,
				ENpcUiInteractType.SunSpirit,
				ENpcUiInteractType.ShopNew,
				ENpcUiInteractType.VillageInfr,
				ENpcUiInteractType.SoundBox35,
				ENpcUiInteractType.DollGrabDelivery
			};
		}

		// Token: 0x0600377B RID: 14203 RVA: 0x00090610 File Offset: 0x0008E810
		public static string[] GetNames()
		{
			return new string[]
			{
				"HandInItem",
				"Shop",
				"AntiqueShop",
				"ChengXiaoShanShop",
				"Gramophone",
				"SoundBox3",
				"SunSpirit",
				"ShopNew",
				"VillageInfr",
				"SoundBox35",
				"DollGrabDelivery"
			};
		}
	}
}
