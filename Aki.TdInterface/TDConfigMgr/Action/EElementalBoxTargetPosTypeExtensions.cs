using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002584 RID: 9604
	public static class EElementalBoxTargetPosTypeExtensions
	{
		// Token: 0x0600D02C RID: 53292 RVA: 0x001E2958 File Offset: 0x001E0B58
		public static string ToEnumString(this EElementalBoxTargetPosType value)
		{
			string result;
			if (value != EElementalBoxTargetPosType.PrefabElementalBoxTargetPos)
			{
				if (value != EElementalBoxTargetPosType.RelativePos)
				{
					result = value.ToString();
				}
				else
				{
					result = "RelativePos";
				}
			}
			else
			{
				result = "PrefabElementalBoxTargetPos";
			}
			return result;
		}

		// Token: 0x0600D02D RID: 53293 RVA: 0x001E2990 File Offset: 0x001E0B90
		public static EElementalBoxTargetPosType FromString(string name)
		{
			EElementalBoxTargetPosType result;
			if (!EElementalBoxTargetPosTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EElementalBoxTargetPosType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D02E RID: 53294 RVA: 0x001E29B9 File Offset: 0x001E0BB9
		public static bool TryFromString(string name, out EElementalBoxTargetPosType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EElementalBoxTargetPosType.PrefabElementalBoxTargetPos;
				return false;
			}
			if (name == "PrefabElementalBoxTargetPos")
			{
				value = EElementalBoxTargetPosType.PrefabElementalBoxTargetPos;
				return true;
			}
			if (!(name == "RelativePos"))
			{
				value = EElementalBoxTargetPosType.PrefabElementalBoxTargetPos;
				return false;
			}
			value = EElementalBoxTargetPosType.RelativePos;
			return true;
		}

		// Token: 0x0600D02F RID: 53295 RVA: 0x001E29F2 File Offset: 0x001E0BF2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"PrefabElementalBoxTargetPos",
				"RelativePos"
			};
		}

		// Token: 0x0600D030 RID: 53296 RVA: 0x001E2A0A File Offset: 0x001E0C0A
		public static EElementalBoxTargetPosType[] GetValues()
		{
			return new EElementalBoxTargetPosType[]
			{
				EElementalBoxTargetPosType.PrefabElementalBoxTargetPos,
				EElementalBoxTargetPosType.RelativePos
			};
		}

		// Token: 0x0600D031 RID: 53297 RVA: 0x001E2A16 File Offset: 0x001E0C16
		public static string[] GetNames()
		{
			return new string[]
			{
				"PrefabElementalBoxTargetPos",
				"RelativePos"
			};
		}
	}
}
