using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009AE RID: 2478
	public static class ENoiseRemovalBoarderShapeExtensions
	{
		// Token: 0x06003740 RID: 14144 RVA: 0x0008FBB0 File Offset: 0x0008DDB0
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

		// Token: 0x06003741 RID: 14145 RVA: 0x0008FBE8 File Offset: 0x0008DDE8
		public static ENoiseRemovalBoarderShape FromString(string name)
		{
			ENoiseRemovalBoarderShape result;
			if (!ENoiseRemovalBoarderShapeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ENoiseRemovalBoarderShape 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003742 RID: 14146 RVA: 0x0008FC11 File Offset: 0x0008DE11
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

		// Token: 0x06003743 RID: 14147 RVA: 0x0008FC4A File Offset: 0x0008DE4A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Box",
				"Sphere"
			};
		}

		// Token: 0x06003744 RID: 14148 RVA: 0x0008FC62 File Offset: 0x0008DE62
		public static ENoiseRemovalBoarderShape[] GetValues()
		{
			return new ENoiseRemovalBoarderShape[]
			{
				ENoiseRemovalBoarderShape.Box,
				ENoiseRemovalBoarderShape.Sphere
			};
		}

		// Token: 0x06003745 RID: 14149 RVA: 0x0008FC6E File Offset: 0x0008DE6E
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
