using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200123E RID: 4670
	public static class EFastReturnPosTypeExtensions
	{
		// Token: 0x060069BE RID: 27070 RVA: 0x000FD65C File Offset: 0x000FB85C
		public static string ToEnumString(this EFastReturnPosType value)
		{
			string result;
			if (value != EFastReturnPosType.EntityPos)
			{
				if (value != EFastReturnPosType.GravityEntityPos)
				{
					result = value.ToString();
				}
				else
				{
					result = "GravityEntityPos";
				}
			}
			else
			{
				result = "EntityPos";
			}
			return result;
		}

		// Token: 0x060069BF RID: 27071 RVA: 0x000FD694 File Offset: 0x000FB894
		public static EFastReturnPosType FromString(string name)
		{
			EFastReturnPosType result;
			if (!EFastReturnPosTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFastReturnPosType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060069C0 RID: 27072 RVA: 0x000FD6BD File Offset: 0x000FB8BD
		public static bool TryFromString(string name, out EFastReturnPosType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EFastReturnPosType.EntityPos;
				return false;
			}
			if (name == "EntityPos")
			{
				value = EFastReturnPosType.EntityPos;
				return true;
			}
			if (!(name == "GravityEntityPos"))
			{
				value = EFastReturnPosType.EntityPos;
				return false;
			}
			value = EFastReturnPosType.GravityEntityPos;
			return true;
		}

		// Token: 0x060069C1 RID: 27073 RVA: 0x000FD6F6 File Offset: 0x000FB8F6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"EntityPos",
				"GravityEntityPos"
			};
		}

		// Token: 0x060069C2 RID: 27074 RVA: 0x000FD70E File Offset: 0x000FB90E
		public static EFastReturnPosType[] GetValues()
		{
			return new EFastReturnPosType[]
			{
				EFastReturnPosType.EntityPos,
				EFastReturnPosType.GravityEntityPos
			};
		}

		// Token: 0x060069C3 RID: 27075 RVA: 0x000FD71A File Offset: 0x000FB91A
		public static string[] GetNames()
		{
			return new string[]
			{
				"EntityPos",
				"GravityEntityPos"
			};
		}
	}
}
