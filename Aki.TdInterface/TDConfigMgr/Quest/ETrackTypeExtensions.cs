using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013F2 RID: 5106
	public static class ETrackTypeExtensions
	{
		// Token: 0x0600721B RID: 29211 RVA: 0x00111084 File Offset: 0x0010F284
		public static string ToEnumString(this ETrackType value)
		{
			string result;
			switch (value)
			{
			case ETrackType.Locations:
				result = "Locations";
				break;
			case ETrackType.Entities:
				result = "Entities";
				break;
			case ETrackType.CaptureVisions:
				result = "CaptureVisions";
				break;
			case ETrackType.EntityGroup:
				result = "EntityGroup";
				break;
			case ETrackType.LevelPlay:
				result = "LevelPlay";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600721C RID: 29212 RVA: 0x001110E4 File Offset: 0x0010F2E4
		public static ETrackType FromString(string name)
		{
			ETrackType result;
			if (!ETrackTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETrackType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600721D RID: 29213 RVA: 0x00111110 File Offset: 0x0010F310
		public static bool TryFromString(string name, out ETrackType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETrackType.Locations;
				return false;
			}
			if (name == "Locations")
			{
				value = ETrackType.Locations;
				return true;
			}
			if (name == "Entities")
			{
				value = ETrackType.Entities;
				return true;
			}
			if (name == "CaptureVisions")
			{
				value = ETrackType.CaptureVisions;
				return true;
			}
			if (name == "EntityGroup")
			{
				value = ETrackType.EntityGroup;
				return true;
			}
			if (!(name == "LevelPlay"))
			{
				value = ETrackType.Locations;
				return false;
			}
			value = ETrackType.LevelPlay;
			return true;
		}

		// Token: 0x0600721E RID: 29214 RVA: 0x0011118A File Offset: 0x0010F38A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Locations",
				"Entities",
				"CaptureVisions",
				"EntityGroup",
				"LevelPlay"
			};
		}

		// Token: 0x0600721F RID: 29215 RVA: 0x001111BA File Offset: 0x0010F3BA
		public static ETrackType[] GetValues()
		{
			return new ETrackType[]
			{
				ETrackType.Locations,
				ETrackType.Entities,
				ETrackType.CaptureVisions,
				ETrackType.EntityGroup,
				ETrackType.LevelPlay
			};
		}

		// Token: 0x06007220 RID: 29216 RVA: 0x001111CD File Offset: 0x0010F3CD
		public static string[] GetNames()
		{
			return new string[]
			{
				"Locations",
				"Entities",
				"CaptureVisions",
				"EntityGroup",
				"LevelPlay"
			};
		}
	}
}
