using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200137E RID: 4990
	public static class EFastReturnPosTypeExtensions
	{
		// Token: 0x06007011 RID: 28689 RVA: 0x0010B288 File Offset: 0x00109488
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

		// Token: 0x06007012 RID: 28690 RVA: 0x0010B2C0 File Offset: 0x001094C0
		public static EFastReturnPosType FromString(string name)
		{
			EFastReturnPosType result;
			if (!EFastReturnPosTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFastReturnPosType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06007013 RID: 28691 RVA: 0x0010B2E9 File Offset: 0x001094E9
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

		// Token: 0x06007014 RID: 28692 RVA: 0x0010B322 File Offset: 0x00109522
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"EntityPos",
				"GravityEntityPos"
			};
		}

		// Token: 0x06007015 RID: 28693 RVA: 0x0010B33A File Offset: 0x0010953A
		public static EFastReturnPosType[] GetValues()
		{
			return new EFastReturnPosType[]
			{
				EFastReturnPosType.EntityPos,
				EFastReturnPosType.GravityEntityPos
			};
		}

		// Token: 0x06007016 RID: 28694 RVA: 0x0010B346 File Offset: 0x00109546
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
