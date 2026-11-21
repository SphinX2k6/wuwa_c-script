using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A5D RID: 2653
	public static class ENavMeshSourceTypeExtensions
	{
		// Token: 0x06003AB5 RID: 15029 RVA: 0x00097634 File Offset: 0x00095834
		public static string ToEnumString(this ENavMeshSourceType value)
		{
			string result;
			if (value == ENavMeshSourceType.AkiEntitySource)
			{
				result = "AkiEntitySource";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003AB6 RID: 15030 RVA: 0x0009765C File Offset: 0x0009585C
		public static ENavMeshSourceType FromString(string name)
		{
			ENavMeshSourceType result;
			if (!ENavMeshSourceTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ENavMeshSourceType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003AB7 RID: 15031 RVA: 0x00097685 File Offset: 0x00095885
		public static bool TryFromString(string name, out ENavMeshSourceType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ENavMeshSourceType.AkiEntitySource;
				return false;
			}
			if (name == "AkiEntitySource")
			{
				value = ENavMeshSourceType.AkiEntitySource;
				return true;
			}
			value = ENavMeshSourceType.AkiEntitySource;
			return false;
		}

		// Token: 0x06003AB8 RID: 15032 RVA: 0x000976AA File Offset: 0x000958AA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"AkiEntitySource"
			};
		}

		// Token: 0x06003AB9 RID: 15033 RVA: 0x000976BA File Offset: 0x000958BA
		public static ENavMeshSourceType[] GetValues()
		{
			return new ENavMeshSourceType[1];
		}

		// Token: 0x06003ABA RID: 15034 RVA: 0x000976C2 File Offset: 0x000958C2
		public static string[] GetNames()
		{
			return new string[]
			{
				"AkiEntitySource"
			};
		}
	}
}
