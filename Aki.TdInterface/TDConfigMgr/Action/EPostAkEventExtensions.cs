using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023DB RID: 9179
	public static class EPostAkEventExtensions
	{
		// Token: 0x0600C7D8 RID: 51160 RVA: 0x001D40CC File Offset: 0x001D22CC
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

		// Token: 0x0600C7D9 RID: 51161 RVA: 0x001D4120 File Offset: 0x001D2320
		public static EPostAkEvent FromString(string name)
		{
			EPostAkEvent result;
			if (!EPostAkEventExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPostAkEvent 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C7DA RID: 51162 RVA: 0x001D414C File Offset: 0x001D234C
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

		// Token: 0x0600C7DB RID: 51163 RVA: 0x001D41B4 File Offset: 0x001D23B4
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

		// Token: 0x0600C7DC RID: 51164 RVA: 0x001D41DC File Offset: 0x001D23DC
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

		// Token: 0x0600C7DD RID: 51165 RVA: 0x001D41EF File Offset: 0x001D23EF
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
