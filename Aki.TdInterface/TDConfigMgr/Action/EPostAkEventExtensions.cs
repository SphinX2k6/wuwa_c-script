using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002672 RID: 9842
	public static class EPostAkEventExtensions
	{
		// Token: 0x0600D45B RID: 54363 RVA: 0x001ED878 File Offset: 0x001EBA78
		public static string ToEnumString(this EPostAkEvent value)
		{
			string result;
			switch (value)
			{
			case EPostAkEvent.Global:
				result = "Global";
				break;
			case EPostAkEvent.Target:
				result = "Target";
				break;
			case EPostAkEvent.Map:
				result = "Map";
				break;
			case EPostAkEvent.MusicSubtitle:
				result = "MusicSubtitle";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D45C RID: 54364 RVA: 0x001ED8CC File Offset: 0x001EBACC
		public static EPostAkEvent FromString(string name)
		{
			EPostAkEvent result;
			if (!EPostAkEventExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPostAkEvent 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D45D RID: 54365 RVA: 0x001ED8F8 File Offset: 0x001EBAF8
		public static bool TryFromString(string name, out EPostAkEvent value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPostAkEvent.Global;
				return false;
			}
			if (name == "Global")
			{
				value = EPostAkEvent.Global;
				return true;
			}
			if (name == "Target")
			{
				value = EPostAkEvent.Target;
				return true;
			}
			if (name == "Map")
			{
				value = EPostAkEvent.Map;
				return true;
			}
			if (!(name == "MusicSubtitle"))
			{
				value = EPostAkEvent.Global;
				return false;
			}
			value = EPostAkEvent.MusicSubtitle;
			return true;
		}

		// Token: 0x0600D45E RID: 54366 RVA: 0x001ED960 File Offset: 0x001EBB60
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Global",
				"Target",
				"Map",
				"MusicSubtitle"
			};
		}

		// Token: 0x0600D45F RID: 54367 RVA: 0x001ED988 File Offset: 0x001EBB88
		public static EPostAkEvent[] GetValues()
		{
			return new EPostAkEvent[]
			{
				EPostAkEvent.Global,
				EPostAkEvent.Target,
				EPostAkEvent.Map,
				EPostAkEvent.MusicSubtitle
			};
		}

		// Token: 0x0600D460 RID: 54368 RVA: 0x001ED99B File Offset: 0x001EBB9B
		public static string[] GetNames()
		{
			return new string[]
			{
				"Global",
				"Target",
				"Map",
				"MusicSubtitle"
			};
		}
	}
}
