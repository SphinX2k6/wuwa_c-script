using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009B2 RID: 2482
	public static class ENoRenderPortalTypeExtensions
	{
		// Token: 0x06003752 RID: 14162 RVA: 0x0008FEA8 File Offset: 0x0008E0A8
		public static string ToEnumString(this ENoRenderPortalType value)
		{
			string result;
			if (value == ENoRenderPortalType.Static)
			{
				result = "Static";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003753 RID: 14163 RVA: 0x0008FED0 File Offset: 0x0008E0D0
		public static ENoRenderPortalType FromString(string name)
		{
			ENoRenderPortalType result;
			if (!ENoRenderPortalTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ENoRenderPortalType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003754 RID: 14164 RVA: 0x0008FEF9 File Offset: 0x0008E0F9
		public static bool TryFromString(string name, out ENoRenderPortalType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ENoRenderPortalType.Static;
				return false;
			}
			if (name == "Static")
			{
				value = ENoRenderPortalType.Static;
				return true;
			}
			value = ENoRenderPortalType.Static;
			return false;
		}

		// Token: 0x06003755 RID: 14165 RVA: 0x0008FF1E File Offset: 0x0008E11E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Static"
			};
		}

		// Token: 0x06003756 RID: 14166 RVA: 0x0008FF2E File Offset: 0x0008E12E
		public static ENoRenderPortalType[] GetValues()
		{
			return new ENoRenderPortalType[1];
		}

		// Token: 0x06003757 RID: 14167 RVA: 0x0008FF36 File Offset: 0x0008E136
		public static string[] GetNames()
		{
			return new string[]
			{
				"Static"
			};
		}
	}
}
