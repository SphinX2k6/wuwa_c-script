using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000918 RID: 2328
	public static class EConveyorBeltMoveTypeExtensions
	{
		// Token: 0x0600349D RID: 13469 RVA: 0x00089C1C File Offset: 0x00087E1C
		public static string ToEnumString(this EConveyorBeltMoveType value)
		{
			string result;
			if (value == EConveyorBeltMoveType.FixSpeed)
			{
				result = "FixSpeed";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600349E RID: 13470 RVA: 0x00089C44 File Offset: 0x00087E44
		public static EConveyorBeltMoveType FromString(string name)
		{
			EConveyorBeltMoveType result;
			if (!EConveyorBeltMoveTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EConveyorBeltMoveType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600349F RID: 13471 RVA: 0x00089C6D File Offset: 0x00087E6D
		public static bool TryFromString(string name, out EConveyorBeltMoveType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EConveyorBeltMoveType.FixSpeed;
				return false;
			}
			if (name == "FixSpeed")
			{
				value = EConveyorBeltMoveType.FixSpeed;
				return true;
			}
			value = EConveyorBeltMoveType.FixSpeed;
			return false;
		}

		// Token: 0x060034A0 RID: 13472 RVA: 0x00089C92 File Offset: 0x00087E92
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FixSpeed"
			};
		}

		// Token: 0x060034A1 RID: 13473 RVA: 0x00089CA2 File Offset: 0x00087EA2
		public static EConveyorBeltMoveType[] GetValues()
		{
			return new EConveyorBeltMoveType[1];
		}

		// Token: 0x060034A2 RID: 13474 RVA: 0x00089CAA File Offset: 0x00087EAA
		public static string[] GetNames()
		{
			return new string[]
			{
				"FixSpeed"
			};
		}
	}
}
