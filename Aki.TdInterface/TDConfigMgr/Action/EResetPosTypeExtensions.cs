using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002686 RID: 9862
	public static class EResetPosTypeExtensions
	{
		// Token: 0x0600D4B5 RID: 54453 RVA: 0x001EE604 File Offset: 0x001EC804
		public static string ToEnumString(this EResetPosType value)
		{
			string result;
			if (value != EResetPosType.PosEntity)
			{
				if (value != EResetPosType.ResetPoint)
				{
					result = value.ToString();
				}
				else
				{
					result = "ResetPoint";
				}
			}
			else
			{
				result = "PosEntity";
			}
			return result;
		}

		// Token: 0x0600D4B6 RID: 54454 RVA: 0x001EE63C File Offset: 0x001EC83C
		public static EResetPosType FromString(string name)
		{
			EResetPosType result;
			if (!EResetPosTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EResetPosType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D4B7 RID: 54455 RVA: 0x001EE665 File Offset: 0x001EC865
		public static bool TryFromString(string name, out EResetPosType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EResetPosType.PosEntity;
				return false;
			}
			if (name == "PosEntity")
			{
				value = EResetPosType.PosEntity;
				return true;
			}
			if (!(name == "ResetPoint"))
			{
				value = EResetPosType.PosEntity;
				return false;
			}
			value = EResetPosType.ResetPoint;
			return true;
		}

		// Token: 0x0600D4B8 RID: 54456 RVA: 0x001EE69E File Offset: 0x001EC89E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"PosEntity",
				"ResetPoint"
			};
		}

		// Token: 0x0600D4B9 RID: 54457 RVA: 0x001EE6B6 File Offset: 0x001EC8B6
		public static EResetPosType[] GetValues()
		{
			return new EResetPosType[]
			{
				EResetPosType.PosEntity,
				EResetPosType.ResetPoint
			};
		}

		// Token: 0x0600D4BA RID: 54458 RVA: 0x001EE6C2 File Offset: 0x001EC8C2
		public static string[] GetNames()
		{
			return new string[]
			{
				"PosEntity",
				"ResetPoint"
			};
		}
	}
}
