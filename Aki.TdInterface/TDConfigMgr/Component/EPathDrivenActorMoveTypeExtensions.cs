using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009C4 RID: 2500
	public static class EPathDrivenActorMoveTypeExtensions
	{
		// Token: 0x060037A3 RID: 14243 RVA: 0x00090A2C File Offset: 0x0008EC2C
		public static string ToEnumString(this EPathDrivenActorMoveType value)
		{
			string result;
			if (value == EPathDrivenActorMoveType.Spline)
			{
				result = "Spline";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x060037A4 RID: 14244 RVA: 0x00090A54 File Offset: 0x0008EC54
		public static EPathDrivenActorMoveType FromString(string name)
		{
			EPathDrivenActorMoveType result;
			if (!EPathDrivenActorMoveTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPathDrivenActorMoveType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060037A5 RID: 14245 RVA: 0x00090A7D File Offset: 0x0008EC7D
		public static bool TryFromString(string name, out EPathDrivenActorMoveType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPathDrivenActorMoveType.Spline;
				return false;
			}
			if (name == "Spline")
			{
				value = EPathDrivenActorMoveType.Spline;
				return true;
			}
			value = EPathDrivenActorMoveType.Spline;
			return false;
		}

		// Token: 0x060037A6 RID: 14246 RVA: 0x00090AA2 File Offset: 0x0008ECA2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Spline"
			};
		}

		// Token: 0x060037A7 RID: 14247 RVA: 0x00090AB2 File Offset: 0x0008ECB2
		public static EPathDrivenActorMoveType[] GetValues()
		{
			return new EPathDrivenActorMoveType[1];
		}

		// Token: 0x060037A8 RID: 14248 RVA: 0x00090ABA File Offset: 0x0008ECBA
		public static string[] GetNames()
		{
			return new string[]
			{
				"Spline"
			};
		}
	}
}
