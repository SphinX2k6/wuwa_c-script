using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012AC RID: 4780
	public static class ETrackTypeExtensions
	{
		// Token: 0x06006BAD RID: 27565 RVA: 0x001030BC File Offset: 0x001012BC
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

		// Token: 0x06006BAE RID: 27566 RVA: 0x0010311C File Offset: 0x0010131C
		public static ETrackType FromString(string name)
		{
			ETrackType result;
			if (!ETrackTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETrackType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006BAF RID: 27567 RVA: 0x00103148 File Offset: 0x00101348
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

		// Token: 0x06006BB0 RID: 27568 RVA: 0x001031C2 File Offset: 0x001013C2
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

		// Token: 0x06006BB1 RID: 27569 RVA: 0x001031F2 File Offset: 0x001013F2
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

		// Token: 0x06006BB2 RID: 27570 RVA: 0x00103205 File Offset: 0x00101405
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
