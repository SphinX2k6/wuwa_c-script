using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A67 RID: 2663
	public static class ENoRenderPortalTypeExtensions
	{
		// Token: 0x06003AE2 RID: 15074 RVA: 0x00097F9C File Offset: 0x0009619C
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

		// Token: 0x06003AE3 RID: 15075 RVA: 0x00097FC4 File Offset: 0x000961C4
		public static ENoRenderPortalType FromString(string name)
		{
			ENoRenderPortalType result;
			if (!ENoRenderPortalTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ENoRenderPortalType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003AE4 RID: 15076 RVA: 0x00097FED File Offset: 0x000961ED
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

		// Token: 0x06003AE5 RID: 15077 RVA: 0x00098012 File Offset: 0x00096212
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Static"
			};
		}

		// Token: 0x06003AE6 RID: 15078 RVA: 0x00098022 File Offset: 0x00096222
		public static ENoRenderPortalType[] GetValues()
		{
			return new ENoRenderPortalType[1];
		}

		// Token: 0x06003AE7 RID: 15079 RVA: 0x0009802A File Offset: 0x0009622A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Static"
			};
		}
	}
}
