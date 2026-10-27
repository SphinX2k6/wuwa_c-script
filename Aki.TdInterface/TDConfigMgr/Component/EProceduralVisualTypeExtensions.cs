using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009E0 RID: 2528
	public static class EProceduralVisualTypeExtensions
	{
		// Token: 0x06003821 RID: 14369 RVA: 0x000918C0 File Offset: 0x0008FAC0
		public static string ToEnumString(this EProceduralVisualType value)
		{
			string result;
			if (value != EProceduralVisualType.LookAt)
			{
				if (value != EProceduralVisualType.SearchlightRotate)
				{
					result = value.ToString();
				}
				else
				{
					result = "SearchlightRotate";
				}
			}
			else
			{
				result = "LookAt";
			}
			return result;
		}

		// Token: 0x06003822 RID: 14370 RVA: 0x000918F8 File Offset: 0x0008FAF8
		public static EProceduralVisualType FromString(string name)
		{
			EProceduralVisualType result;
			if (!EProceduralVisualTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EProceduralVisualType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003823 RID: 14371 RVA: 0x00091921 File Offset: 0x0008FB21
		public static bool TryFromString(string name, out EProceduralVisualType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EProceduralVisualType.LookAt;
				return false;
			}
			if (name == "LookAt")
			{
				value = EProceduralVisualType.LookAt;
				return true;
			}
			if (!(name == "SearchlightRotate"))
			{
				value = EProceduralVisualType.LookAt;
				return false;
			}
			value = EProceduralVisualType.SearchlightRotate;
			return true;
		}

		// Token: 0x06003824 RID: 14372 RVA: 0x0009195A File Offset: 0x0008FB5A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LookAt",
				"SearchlightRotate"
			};
		}

		// Token: 0x06003825 RID: 14373 RVA: 0x00091972 File Offset: 0x0008FB72
		public static EProceduralVisualType[] GetValues()
		{
			return new EProceduralVisualType[]
			{
				EProceduralVisualType.LookAt,
				EProceduralVisualType.SearchlightRotate
			};
		}

		// Token: 0x06003826 RID: 14374 RVA: 0x0009197E File Offset: 0x0008FB7E
		public static string[] GetNames()
		{
			return new string[]
			{
				"LookAt",
				"SearchlightRotate"
			};
		}
	}
}
