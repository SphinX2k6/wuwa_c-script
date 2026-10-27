using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200233D RID: 9021
	public static class EFixedLookAtTargetTypeExtensions
	{
		// Token: 0x0600C511 RID: 50449 RVA: 0x001CC460 File Offset: 0x001CA660
		public static string ToEnumString(this EFixedLookAtTargetType value)
		{
			string result;
			if (value == EFixedLookAtTargetType.RangeEntity)
			{
				result = "RangeEntity";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600C512 RID: 50450 RVA: 0x001CC488 File Offset: 0x001CA688
		public static EFixedLookAtTargetType FromString(string name)
		{
			EFixedLookAtTargetType result;
			if (!EFixedLookAtTargetTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFixedLookAtTargetType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C513 RID: 50451 RVA: 0x001CC4B1 File Offset: 0x001CA6B1
		public static bool TryFromString(string name, out EFixedLookAtTargetType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EFixedLookAtTargetType.RangeEntity;
				return false;
			}
			if (name == "RangeEntity")
			{
				value = EFixedLookAtTargetType.RangeEntity;
				return true;
			}
			value = EFixedLookAtTargetType.RangeEntity;
			return false;
		}

		// Token: 0x0600C514 RID: 50452 RVA: 0x001CC4D6 File Offset: 0x001CA6D6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"RangeEntity"
			};
		}

		// Token: 0x0600C515 RID: 50453 RVA: 0x001CC4E6 File Offset: 0x001CA6E6
		public static EFixedLookAtTargetType[] GetValues()
		{
			return new EFixedLookAtTargetType[1];
		}

		// Token: 0x0600C516 RID: 50454 RVA: 0x001CC4EE File Offset: 0x001CA6EE
		public static string[] GetNames()
		{
			return new string[]
			{
				"RangeEntity"
			};
		}
	}
}
