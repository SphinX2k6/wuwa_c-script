using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A5F RID: 2655
	public static class ENearbyTrackingTextureExtensions
	{
		// Token: 0x06003ABE RID: 15038 RVA: 0x00097710 File Offset: 0x00095910
		public static string ToEnumString(this ENearbyTrackingTexture value)
		{
			string result;
			switch (value)
			{
			case ENearbyTrackingTexture.BigTeleporter:
				result = "BigTeleporter";
				break;
			case ENearbyTrackingTexture.SmallTeleporter:
				result = "SmallTeleporter";
				break;
			case ENearbyTrackingTexture.TreasureBox:
				result = "TreasureBox";
				break;
			case ENearbyTrackingTexture.TeleControl:
				result = "TeleControl";
				break;
			case ENearbyTrackingTexture.PhantomBox:
				result = "PhantomBox";
				break;
			case ENearbyTrackingTexture.DungeonKey:
				result = "DungeonKey";
				break;
			case ENearbyTrackingTexture.FishingSpectrum:
				result = "FishingSpectrum";
				break;
			case ENearbyTrackingTexture.Gongduola:
				result = "Gongduola";
				break;
			case ENearbyTrackingTexture.Paver:
				result = "Paver";
				break;
			case ENearbyTrackingTexture.DaemonHack:
				result = "DaemonHack";
				break;
			case ENearbyTrackingTexture.GiantGift:
				result = "GiantGift";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003ABF RID: 15039 RVA: 0x000977B8 File Offset: 0x000959B8
		public static ENearbyTrackingTexture FromString(string name)
		{
			ENearbyTrackingTexture result;
			if (!ENearbyTrackingTextureExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ENearbyTrackingTexture 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003AC0 RID: 15040 RVA: 0x000977E4 File Offset: 0x000959E4
		public static bool TryFromString(string name, out ENearbyTrackingTexture value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ENearbyTrackingTexture.BigTeleporter;
				return false;
			}
			if (name != null)
			{
				switch (name.Length)
				{
				case 5:
					if (name == "Paver")
					{
						value = ENearbyTrackingTexture.Paver;
						return true;
					}
					break;
				case 9:
				{
					char c = name[1];
					if (c != 'i')
					{
						if (c == 'o')
						{
							if (name == "Gongduola")
							{
								value = ENearbyTrackingTexture.Gongduola;
								return true;
							}
						}
					}
					else if (name == "GiantGift")
					{
						value = ENearbyTrackingTexture.GiantGift;
						return true;
					}
					break;
				}
				case 10:
				{
					char c = name[1];
					if (c != 'a')
					{
						if (c != 'h')
						{
							if (c == 'u')
							{
								if (name == "DungeonKey")
								{
									value = ENearbyTrackingTexture.DungeonKey;
									return true;
								}
							}
						}
						else if (name == "PhantomBox")
						{
							value = ENearbyTrackingTexture.PhantomBox;
							return true;
						}
					}
					else if (name == "DaemonHack")
					{
						value = ENearbyTrackingTexture.DaemonHack;
						return true;
					}
					break;
				}
				case 11:
				{
					char c = name[1];
					if (c != 'e')
					{
						if (c == 'r')
						{
							if (name == "TreasureBox")
							{
								value = ENearbyTrackingTexture.TreasureBox;
								return true;
							}
						}
					}
					else if (name == "TeleControl")
					{
						value = ENearbyTrackingTexture.TeleControl;
						return true;
					}
					break;
				}
				case 13:
					if (name == "BigTeleporter")
					{
						value = ENearbyTrackingTexture.BigTeleporter;
						return true;
					}
					break;
				case 15:
				{
					char c = name[0];
					if (c != 'F')
					{
						if (c == 'S')
						{
							if (name == "SmallTeleporter")
							{
								value = ENearbyTrackingTexture.SmallTeleporter;
								return true;
							}
						}
					}
					else if (name == "FishingSpectrum")
					{
						value = ENearbyTrackingTexture.FishingSpectrum;
						return true;
					}
					break;
				}
				}
			}
			value = ENearbyTrackingTexture.BigTeleporter;
			return false;
		}

		// Token: 0x06003AC1 RID: 15041 RVA: 0x000979BC File Offset: 0x00095BBC
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"BigTeleporter",
				"SmallTeleporter",
				"TreasureBox",
				"TeleControl",
				"PhantomBox",
				"DungeonKey",
				"FishingSpectrum",
				"Gongduola",
				"Paver",
				"DaemonHack",
				"GiantGift"
			};
		}

		// Token: 0x06003AC2 RID: 15042 RVA: 0x00097A2A File Offset: 0x00095C2A
		public static ENearbyTrackingTexture[] GetValues()
		{
			return new ENearbyTrackingTexture[]
			{
				ENearbyTrackingTexture.BigTeleporter,
				ENearbyTrackingTexture.SmallTeleporter,
				ENearbyTrackingTexture.TreasureBox,
				ENearbyTrackingTexture.TeleControl,
				ENearbyTrackingTexture.PhantomBox,
				ENearbyTrackingTexture.DungeonKey,
				ENearbyTrackingTexture.FishingSpectrum,
				ENearbyTrackingTexture.Gongduola,
				ENearbyTrackingTexture.Paver,
				ENearbyTrackingTexture.DaemonHack,
				ENearbyTrackingTexture.GiantGift
			};
		}

		// Token: 0x06003AC3 RID: 15043 RVA: 0x00097A40 File Offset: 0x00095C40
		public static string[] GetNames()
		{
			return new string[]
			{
				"BigTeleporter",
				"SmallTeleporter",
				"TreasureBox",
				"TeleControl",
				"PhantomBox",
				"DungeonKey",
				"FishingSpectrum",
				"Gongduola",
				"Paver",
				"DaemonHack",
				"GiantGift"
			};
		}
	}
}
