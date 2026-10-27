using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002369 RID: 9065
	public static class EJigsawShapeExtensions
	{
		// Token: 0x0600C5D7 RID: 50647 RVA: 0x001CED04 File Offset: 0x001CCF04
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

		// Token: 0x0600C5D8 RID: 50648 RVA: 0x001CED3C File Offset: 0x001CCF3C
		public static EJigsawShape FromString(string name)
		{
			EJigsawShape result;
			if (!EJigsawShapeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EJigsawShape 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C5D9 RID: 50649 RVA: 0x001CED65 File Offset: 0x001CCF65
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

		// Token: 0x0600C5DA RID: 50650 RVA: 0x001CED9E File Offset: 0x001CCF9E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Circle",
				"Rectangle"
			};
		}

		// Token: 0x0600C5DB RID: 50651 RVA: 0x001CEDB6 File Offset: 0x001CCFB6
		public static EJigsawShape[] GetValues()
		{
			return new EJigsawShape[]
			{
				EJigsawShape.Circle,
				EJigsawShape.Rectangle
			};
		}

		// Token: 0x0600C5DC RID: 50652 RVA: 0x001CEDC2 File Offset: 0x001CCFC2
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
