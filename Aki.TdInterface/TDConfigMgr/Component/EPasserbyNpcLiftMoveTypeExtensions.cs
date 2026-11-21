using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A79 RID: 2681
	public static class EPasserbyNpcLiftMoveTypeExtensions
	{
		// Token: 0x06003B33 RID: 15155 RVA: 0x00098B64 File Offset: 0x00096D64
		public static string ToEnumString(this EPasserbyNpcLiftMoveType value)
		{
			string result;
			if (value == EPasserbyNpcLiftMoveType.RideLiftLeaveOnArrival)
			{
				result = "RideLiftLeaveOnArrival";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003B34 RID: 15156 RVA: 0x00098B8C File Offset: 0x00096D8C
		public static EPasserbyNpcLiftMoveType FromString(string name)
		{
			EPasserbyNpcLiftMoveType result;
			if (!EPasserbyNpcLiftMoveTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPasserbyNpcLiftMoveType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003B35 RID: 15157 RVA: 0x00098BB5 File Offset: 0x00096DB5
		public static bool TryFromString(string name, out EPasserbyNpcLiftMoveType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPasserbyNpcLiftMoveType.RideLiftLeaveOnArrival;
				return false;
			}
			if (name == "RideLiftLeaveOnArrival")
			{
				value = EPasserbyNpcLiftMoveType.RideLiftLeaveOnArrival;
				return true;
			}
			value = EPasserbyNpcLiftMoveType.RideLiftLeaveOnArrival;
			return false;
		}

		// Token: 0x06003B36 RID: 15158 RVA: 0x00098BDA File Offset: 0x00096DDA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"RideLiftLeaveOnArrival"
			};
		}

		// Token: 0x06003B37 RID: 15159 RVA: 0x00098BEA File Offset: 0x00096DEA
		public static EPasserbyNpcLiftMoveType[] GetValues()
		{
			return new EPasserbyNpcLiftMoveType[1];
		}

		// Token: 0x06003B38 RID: 15160 RVA: 0x00098BF2 File Offset: 0x00096DF2
		public static string[] GetNames()
		{
			return new string[]
			{
				"RideLiftLeaveOnArrival"
			};
		}
	}
}
