using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A63 RID: 2659
	public static class ENoiseRemovalBoarderShapeExtensions
	{
		// Token: 0x06003AD0 RID: 15056 RVA: 0x00097CA4 File Offset: 0x00095EA4
		public static string ToEnumString(this ENoiseRemovalBoarderShape value)
		{
			string result;
			if (value != ENoiseRemovalBoarderShape.Box)
			{
				if (value != ENoiseRemovalBoarderShape.Sphere)
				{
					result = value.ToString();
				}
				else
				{
					result = "Sphere";
				}
			}
			else
			{
				result = "Box";
			}
			return result;
		}

		// Token: 0x06003AD1 RID: 15057 RVA: 0x00097CDC File Offset: 0x00095EDC
		public static ENoiseRemovalBoarderShape FromString(string name)
		{
			ENoiseRemovalBoarderShape result;
			if (!ENoiseRemovalBoarderShapeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ENoiseRemovalBoarderShape 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003AD2 RID: 15058 RVA: 0x00097D05 File Offset: 0x00095F05
		public static bool TryFromString(string name, out ENoiseRemovalBoarderShape value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ENoiseRemovalBoarderShape.Box;
				return false;
			}
			if (name == "Box")
			{
				value = ENoiseRemovalBoarderShape.Box;
				return true;
			}
			if (!(name == "Sphere"))
			{
				value = ENoiseRemovalBoarderShape.Box;
				return false;
			}
			value = ENoiseRemovalBoarderShape.Sphere;
			return true;
		}

		// Token: 0x06003AD3 RID: 15059 RVA: 0x00097D3E File Offset: 0x00095F3E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Box",
				"Sphere"
			};
		}

		// Token: 0x06003AD4 RID: 15060 RVA: 0x00097D56 File Offset: 0x00095F56
		public static ENoiseRemovalBoarderShape[] GetValues()
		{
			return new ENoiseRemovalBoarderShape[]
			{
				ENoiseRemovalBoarderShape.Box,
				ENoiseRemovalBoarderShape.Sphere
			};
		}

		// Token: 0x06003AD5 RID: 15061 RVA: 0x00097D62 File Offset: 0x00095F62
		public static string[] GetNames()
		{
			return new string[]
			{
				"Box",
				"Sphere"
			};
		}
	}
}
