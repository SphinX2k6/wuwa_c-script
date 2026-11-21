using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009C5 RID: 2501
	public static class EConveyorBeltMoveTypeExtensions
	{
		// Token: 0x06003809 RID: 14345 RVA: 0x0009179C File Offset: 0x0008F99C
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

		// Token: 0x0600380A RID: 14346 RVA: 0x000917C4 File Offset: 0x0008F9C4
		public static EConveyorBeltMoveType FromString(string name)
		{
			EConveyorBeltMoveType result;
			if (!EConveyorBeltMoveTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EConveyorBeltMoveType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600380B RID: 14347 RVA: 0x000917ED File Offset: 0x0008F9ED
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

		// Token: 0x0600380C RID: 14348 RVA: 0x00091812 File Offset: 0x0008FA12
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FixSpeed"
			};
		}

		// Token: 0x0600380D RID: 14349 RVA: 0x00091822 File Offset: 0x0008FA22
		public static EConveyorBeltMoveType[] GetValues()
		{
			return new EConveyorBeltMoveType[1];
		}

		// Token: 0x0600380E RID: 14350 RVA: 0x0009182A File Offset: 0x0008FA2A
		public static string[] GetNames()
		{
			return new string[]
			{
				"FixSpeed"
			};
		}
	}
}
