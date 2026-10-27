using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009BC RID: 2492
	public static class EPasserbyNpcMoveTypeExtensions
	{
		// Token: 0x0600377F RID: 14207 RVA: 0x000906BC File Offset: 0x0008E8BC
		public static string ToEnumString(this EPasserbyNpcMoveType value)
		{
			string result;
			if (value == EPasserbyNpcMoveType.Spline)
			{
				result = "Spline";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003780 RID: 14208 RVA: 0x000906E4 File Offset: 0x0008E8E4
		public static EPasserbyNpcMoveType FromString(string name)
		{
			EPasserbyNpcMoveType result;
			if (!EPasserbyNpcMoveTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPasserbyNpcMoveType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003781 RID: 14209 RVA: 0x0009070D File Offset: 0x0008E90D
		public static bool TryFromString(string name, out EPasserbyNpcMoveType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPasserbyNpcMoveType.Spline;
				return false;
			}
			if (name == "Spline")
			{
				value = EPasserbyNpcMoveType.Spline;
				return true;
			}
			value = EPasserbyNpcMoveType.Spline;
			return false;
		}

		// Token: 0x06003782 RID: 14210 RVA: 0x00090732 File Offset: 0x0008E932
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Spline"
			};
		}

		// Token: 0x06003783 RID: 14211 RVA: 0x00090742 File Offset: 0x0008E942
		public static EPasserbyNpcMoveType[] GetValues()
		{
			return new EPasserbyNpcMoveType[1];
		}

		// Token: 0x06003784 RID: 14212 RVA: 0x0009074A File Offset: 0x0008E94A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Spline"
			};
		}
	}
}
