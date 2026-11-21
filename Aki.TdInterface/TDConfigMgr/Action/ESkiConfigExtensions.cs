using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026B8 RID: 9912
	public static class ESkiConfigExtensions
	{
		// Token: 0x0600D596 RID: 54678 RVA: 0x001F0A94 File Offset: 0x001EEC94
		public static string ToEnumString(this ESkiConfig value)
		{
			string result;
			switch (value)
			{
			case ESkiConfig.Open:
				result = "Open";
				break;
			case ESkiConfig.Close:
				result = "Close";
				break;
			case ESkiConfig.Accelerate:
				result = "Accelerate";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D597 RID: 54679 RVA: 0x001F0ADC File Offset: 0x001EECDC
		public static ESkiConfig FromString(string name)
		{
			ESkiConfig result;
			if (!ESkiConfigExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESkiConfig 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D598 RID: 54680 RVA: 0x001F0B08 File Offset: 0x001EED08
		public static bool TryFromString(string name, out ESkiConfig value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESkiConfig.Open;
				return false;
			}
			if (name == "Open")
			{
				value = ESkiConfig.Open;
				return true;
			}
			if (name == "Close")
			{
				value = ESkiConfig.Close;
				return true;
			}
			if (!(name == "Accelerate"))
			{
				value = ESkiConfig.Open;
				return false;
			}
			value = ESkiConfig.Accelerate;
			return true;
		}

		// Token: 0x0600D599 RID: 54681 RVA: 0x001F0B5E File Offset: 0x001EED5E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Open",
				"Close",
				"Accelerate"
			};
		}

		// Token: 0x0600D59A RID: 54682 RVA: 0x001F0B7E File Offset: 0x001EED7E
		public static ESkiConfig[] GetValues()
		{
			return new ESkiConfig[]
			{
				ESkiConfig.Open,
				ESkiConfig.Close,
				ESkiConfig.Accelerate
			};
		}

		// Token: 0x0600D59B RID: 54683 RVA: 0x001F0B8E File Offset: 0x001EED8E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Open",
				"Close",
				"Accelerate"
			};
		}
	}
}
