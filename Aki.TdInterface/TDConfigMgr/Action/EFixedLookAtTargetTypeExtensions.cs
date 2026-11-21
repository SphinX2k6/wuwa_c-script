using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025AE RID: 9646
	public static class EFixedLookAtTargetTypeExtensions
	{
		// Token: 0x0600D0E9 RID: 53481 RVA: 0x001E4518 File Offset: 0x001E2718
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

		// Token: 0x0600D0EA RID: 53482 RVA: 0x001E4540 File Offset: 0x001E2740
		public static EFixedLookAtTargetType FromString(string name)
		{
			EFixedLookAtTargetType result;
			if (!EFixedLookAtTargetTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFixedLookAtTargetType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D0EB RID: 53483 RVA: 0x001E4569 File Offset: 0x001E2769
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

		// Token: 0x0600D0EC RID: 53484 RVA: 0x001E458E File Offset: 0x001E278E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"RangeEntity"
			};
		}

		// Token: 0x0600D0ED RID: 53485 RVA: 0x001E459E File Offset: 0x001E279E
		public static EFixedLookAtTargetType[] GetValues()
		{
			return new EFixedLookAtTargetType[1];
		}

		// Token: 0x0600D0EE RID: 53486 RVA: 0x001E45A6 File Offset: 0x001E27A6
		public static string[] GetNames()
		{
			return new string[]
			{
				"RangeEntity"
			};
		}
	}
}
