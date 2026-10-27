using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009A8 RID: 2472
	public static class ENavMeshSourceTypeExtensions
	{
		// Token: 0x06003725 RID: 14117 RVA: 0x0008F570 File Offset: 0x0008D770
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

		// Token: 0x06003726 RID: 14118 RVA: 0x0008F598 File Offset: 0x0008D798
		public static ENavMeshSourceType FromString(string name)
		{
			ENavMeshSourceType result;
			if (!ENavMeshSourceTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ENavMeshSourceType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003727 RID: 14119 RVA: 0x0008F5C1 File Offset: 0x0008D7C1
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

		// Token: 0x06003728 RID: 14120 RVA: 0x0008F5E6 File Offset: 0x0008D7E6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"AkiEntitySource"
			};
		}

		// Token: 0x06003729 RID: 14121 RVA: 0x0008F5F6 File Offset: 0x0008D7F6
		public static ENavMeshSourceType[] GetValues()
		{
			return new ENavMeshSourceType[1];
		}

		// Token: 0x0600372A RID: 14122 RVA: 0x0008F5FE File Offset: 0x0008D7FE
		public static string[] GetNames()
		{
			return new string[]
			{
				"AkiEntitySource"
			};
		}
	}
}
