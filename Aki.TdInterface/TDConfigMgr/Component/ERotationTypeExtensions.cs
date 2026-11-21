using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AC1 RID: 2753
	public static class ERotationTypeExtensions
	{
		// Token: 0x06003C77 RID: 15479 RVA: 0x0009B1A4 File Offset: 0x000993A4
		public static string ToEnumString(this ERotationType value)
		{
			string result;
			if (value != ERotationType.Relative)
			{
				if (value != ERotationType.Absolute)
				{
					result = value.ToString();
				}
				else
				{
					result = "Absolute";
				}
			}
			else
			{
				result = "Relative";
			}
			return result;
		}

		// Token: 0x06003C78 RID: 15480 RVA: 0x0009B1DC File Offset: 0x000993DC
		public static ERotationType FromString(string name)
		{
			ERotationType result;
			if (!ERotationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERotationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003C79 RID: 15481 RVA: 0x0009B205 File Offset: 0x00099405
		public static bool TryFromString(string name, out ERotationType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERotationType.Relative;
				return false;
			}
			if (name == "Relative")
			{
				value = ERotationType.Relative;
				return true;
			}
			if (!(name == "Absolute"))
			{
				value = ERotationType.Relative;
				return false;
			}
			value = ERotationType.Absolute;
			return true;
		}

		// Token: 0x06003C7A RID: 15482 RVA: 0x0009B23E File Offset: 0x0009943E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Relative",
				"Absolute"
			};
		}

		// Token: 0x06003C7B RID: 15483 RVA: 0x0009B256 File Offset: 0x00099456
		public static ERotationType[] GetValues()
		{
			return new ERotationType[]
			{
				ERotationType.Relative,
				ERotationType.Absolute
			};
		}

		// Token: 0x06003C7C RID: 15484 RVA: 0x0009B262 File Offset: 0x00099462
		public static string[] GetNames()
		{
			return new string[]
			{
				"Relative",
				"Absolute"
			};
		}
	}
}
