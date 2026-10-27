using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002315 RID: 8981
	public static class EElementalBoxTargetPosTypeExtensions
	{
		// Token: 0x0600C45D RID: 50269 RVA: 0x001CAA90 File Offset: 0x001C8C90
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

		// Token: 0x0600C45E RID: 50270 RVA: 0x001CAAC8 File Offset: 0x001C8CC8
		public static EElementalBoxTargetPosType FromString(string name)
		{
			EElementalBoxTargetPosType result;
			if (!EElementalBoxTargetPosTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EElementalBoxTargetPosType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C45F RID: 50271 RVA: 0x001CAAF1 File Offset: 0x001C8CF1
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

		// Token: 0x0600C460 RID: 50272 RVA: 0x001CAB2A File Offset: 0x001C8D2A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"PrefabElementalBoxTargetPos",
				"RelativePos"
			};
		}

		// Token: 0x0600C461 RID: 50273 RVA: 0x001CAB42 File Offset: 0x001C8D42
		public static EElementalBoxTargetPosType[] GetValues()
		{
			return new EElementalBoxTargetPosType[]
			{
				EElementalBoxTargetPosType.PrefabElementalBoxTargetPos,
				EElementalBoxTargetPosType.RelativePos
			};
		}

		// Token: 0x0600C462 RID: 50274 RVA: 0x001CAB4E File Offset: 0x001C8D4E
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
