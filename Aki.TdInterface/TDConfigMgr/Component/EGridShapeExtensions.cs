using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000956 RID: 2390
	public static class EGridShapeExtensions
	{
		// Token: 0x060035B4 RID: 13748 RVA: 0x0008BFD0 File Offset: 0x0008A1D0
		public static string ToEnumString(this EGridShape value)
		{
			string result;
			if (value != EGridShape.Vertical)
			{
				if (value != EGridShape.Horizontal)
				{
					result = value.ToString();
				}
				else
				{
					result = "Horizontal";
				}
			}
			else
			{
				result = "Vertical";
			}
			return result;
		}

		// Token: 0x060035B5 RID: 13749 RVA: 0x0008C008 File Offset: 0x0008A208
		public static EGridShape FromString(string name)
		{
			EGridShape result;
			if (!EGridShapeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGridShape 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060035B6 RID: 13750 RVA: 0x0008C031 File Offset: 0x0008A231
		public static bool TryFromString(string name, out EGridShape value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EGridShape.Vertical;
				return false;
			}
			if (name == "Vertical")
			{
				value = EGridShape.Vertical;
				return true;
			}
			if (!(name == "Horizontal"))
			{
				value = EGridShape.Vertical;
				return false;
			}
			value = EGridShape.Horizontal;
			return true;
		}

		// Token: 0x060035B7 RID: 13751 RVA: 0x0008C06A File Offset: 0x0008A26A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Vertical",
				"Horizontal"
			};
		}

		// Token: 0x060035B8 RID: 13752 RVA: 0x0008C082 File Offset: 0x0008A282
		public static EGridShape[] GetValues()
		{
			return new EGridShape[]
			{
				EGridShape.Vertical,
				EGridShape.Horizontal
			};
		}

		// Token: 0x060035B9 RID: 13753 RVA: 0x0008C08E File Offset: 0x0008A28E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Vertical",
				"Horizontal"
			};
		}
	}
}
