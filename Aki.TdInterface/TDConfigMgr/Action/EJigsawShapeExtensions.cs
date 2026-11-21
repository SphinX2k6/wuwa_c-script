using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025DE RID: 9694
	public static class EJigsawShapeExtensions
	{
		// Token: 0x0600D1C1 RID: 53697 RVA: 0x001E6FE4 File Offset: 0x001E51E4
		public static string ToEnumString(this EJigsawShape value)
		{
			string result;
			if (value != EJigsawShape.Circle)
			{
				if (value != EJigsawShape.Rectangle)
				{
					result = value.ToString();
				}
				else
				{
					result = "Rectangle";
				}
			}
			else
			{
				result = "Circle";
			}
			return result;
		}

		// Token: 0x0600D1C2 RID: 53698 RVA: 0x001E701C File Offset: 0x001E521C
		public static EJigsawShape FromString(string name)
		{
			EJigsawShape result;
			if (!EJigsawShapeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EJigsawShape 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D1C3 RID: 53699 RVA: 0x001E7045 File Offset: 0x001E5245
		public static bool TryFromString(string name, out EJigsawShape value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EJigsawShape.Circle;
				return false;
			}
			if (name == "Circle")
			{
				value = EJigsawShape.Circle;
				return true;
			}
			if (!(name == "Rectangle"))
			{
				value = EJigsawShape.Circle;
				return false;
			}
			value = EJigsawShape.Rectangle;
			return true;
		}

		// Token: 0x0600D1C4 RID: 53700 RVA: 0x001E707E File Offset: 0x001E527E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Circle",
				"Rectangle"
			};
		}

		// Token: 0x0600D1C5 RID: 53701 RVA: 0x001E7096 File Offset: 0x001E5296
		public static EJigsawShape[] GetValues()
		{
			return new EJigsawShape[]
			{
				EJigsawShape.Circle,
				EJigsawShape.Rectangle
			};
		}

		// Token: 0x0600D1C6 RID: 53702 RVA: 0x001E70A2 File Offset: 0x001E52A2
		public static string[] GetNames()
		{
			return new string[]
			{
				"Circle",
				"Rectangle"
			};
		}
	}
}
