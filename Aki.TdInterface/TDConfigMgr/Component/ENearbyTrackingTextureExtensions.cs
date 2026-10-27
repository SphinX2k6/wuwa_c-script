using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009AA RID: 2474
	public static class ENearbyTrackingTextureExtensions
	{
		// Token: 0x0600372E RID: 14126 RVA: 0x0008F64C File Offset: 0x0008D84C
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

		// Token: 0x0600372F RID: 14127 RVA: 0x0008F6F4 File Offset: 0x0008D8F4
		public static ENearbyTrackingTexture FromString(string name)
		{
			ENearbyTrackingTexture result;
			if (!ENearbyTrackingTextureExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ENearbyTrackingTexture 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003730 RID: 14128 RVA: 0x0008F720 File Offset: 0x0008D920
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

		// Token: 0x06003731 RID: 14129 RVA: 0x0008F8F8 File Offset: 0x0008DAF8
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

		// Token: 0x06003732 RID: 14130 RVA: 0x0008F966 File Offset: 0x0008DB66
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

		// Token: 0x06003733 RID: 14131 RVA: 0x0008F97C File Offset: 0x0008DB7C
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
