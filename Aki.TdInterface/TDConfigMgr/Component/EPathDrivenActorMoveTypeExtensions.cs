using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A85 RID: 2693
	public static class EPathDrivenActorMoveTypeExtensions
	{
		// Token: 0x06003B69 RID: 15209 RVA: 0x000990FC File Offset: 0x000972FC
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

		// Token: 0x06003B6A RID: 15210 RVA: 0x00099124 File Offset: 0x00097324
		public static EPathDrivenActorMoveType FromString(string name)
		{
			EPathDrivenActorMoveType result;
			if (!EPathDrivenActorMoveTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPathDrivenActorMoveType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003B6B RID: 15211 RVA: 0x0009914D File Offset: 0x0009734D
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

		// Token: 0x06003B6C RID: 15212 RVA: 0x00099172 File Offset: 0x00097372
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Spline"
			};
		}

		// Token: 0x06003B6D RID: 15213 RVA: 0x00099182 File Offset: 0x00097382
		public static EPathDrivenActorMoveType[] GetValues()
		{
			return new EPathDrivenActorMoveType[1];
		}

		// Token: 0x06003B6E RID: 15214 RVA: 0x0009918A File Offset: 0x0009738A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Spline"
			};
		}
	}
}
