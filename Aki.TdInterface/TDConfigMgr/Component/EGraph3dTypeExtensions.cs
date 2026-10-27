using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000954 RID: 2388
	public static class EGraph3dTypeExtensions
	{
		// Token: 0x060035AB RID: 13739 RVA: 0x0008BEF4 File Offset: 0x0008A0F4
		public static string ToEnumString(this EGraph3dType value)
		{
			string result;
			if (value == EGraph3dType.Normal)
			{
				result = "Normal";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x060035AC RID: 13740 RVA: 0x0008BF1C File Offset: 0x0008A11C
		public static EGraph3dType FromString(string name)
		{
			EGraph3dType result;
			if (!EGraph3dTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGraph3dType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060035AD RID: 13741 RVA: 0x0008BF45 File Offset: 0x0008A145
		public static bool TryFromString(string name, out EGraph3dType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EGraph3dType.Normal;
				return false;
			}
			if (name == "Normal")
			{
				value = EGraph3dType.Normal;
				return true;
			}
			value = EGraph3dType.Normal;
			return false;
		}

		// Token: 0x060035AE RID: 13742 RVA: 0x0008BF6A File Offset: 0x0008A16A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Normal"
			};
		}

		// Token: 0x060035AF RID: 13743 RVA: 0x0008BF7A File Offset: 0x0008A17A
		public static EGraph3dType[] GetValues()
		{
			return new EGraph3dType[1];
		}

		// Token: 0x060035B0 RID: 13744 RVA: 0x0008BF82 File Offset: 0x0008A182
		public static string[] GetNames()
		{
			return new string[]
			{
				"Normal"
			};
		}
	}
}
