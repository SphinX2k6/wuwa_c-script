using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A09 RID: 2569
	public static class EGridShapeExtensions
	{
		// Token: 0x0600393B RID: 14651 RVA: 0x00093F24 File Offset: 0x00092124
		public static string ToEnumString(this EGridShape value)
		{
			string result;
			if (value != EGridShape.Vertical)
			{
				if (value != EGridShape.Horizontal)
				{
					result = value.ToString();
				}
				else
				{
					result = "Horizontal";
				}
			}
			else
			{
				result = "Vertical";
			}
			return result;
		}

		// Token: 0x0600393C RID: 14652 RVA: 0x00093F5C File Offset: 0x0009215C
		public static EGridShape FromString(string name)
		{
			EGridShape result;
			if (!EGridShapeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGridShape 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600393D RID: 14653 RVA: 0x00093F85 File Offset: 0x00092185
		public static bool TryFromString(string name, out EGridShape value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EGridShape.Vertical;
				return false;
			}
			if (name == "Vertical")
			{
				value = EGridShape.Vertical;
				return true;
			}
			if (!(name == "Horizontal"))
			{
				value = EGridShape.Vertical;
				return false;
			}
			value = EGridShape.Horizontal;
			return true;
		}

		// Token: 0x0600393E RID: 14654 RVA: 0x00093FBE File Offset: 0x000921BE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Vertical",
				"Horizontal"
			};
		}

		// Token: 0x0600393F RID: 14655 RVA: 0x00093FD6 File Offset: 0x000921D6
		public static EGridShape[] GetValues()
		{
			return new EGridShape[]
			{
				EGridShape.Vertical,
				EGridShape.Horizontal
			};
		}

		// Token: 0x06003940 RID: 14656 RVA: 0x00093FE2 File Offset: 0x000921E2
		public static string[] GetNames()
		{
			return new string[]
			{
				"Vertical",
				"Horizontal"
			};
		}
	}
}
