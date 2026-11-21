using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002762 RID: 10082
	public static class EWaitInteractNpcMontageWaitTypeExtensions
	{
		// Token: 0x0600D893 RID: 55443 RVA: 0x001FA514 File Offset: 0x001F8714
		public static string ToEnumString(this EWaitInteractNpcMontageWaitType value)
		{
			string result;
			if (value != EWaitInteractNpcMontageWaitType.WaitForMontage)
			{
				if (value != EWaitInteractNpcMontageWaitType.WaitForMontageLoop)
				{
					result = value.ToString();
				}
				else
				{
					result = "WaitForMontageLoop";
				}
			}
			else
			{
				result = "WaitForMontage";
			}
			return result;
		}

		// Token: 0x0600D894 RID: 55444 RVA: 0x001FA54C File Offset: 0x001F874C
		public static EWaitInteractNpcMontageWaitType FromString(string name)
		{
			EWaitInteractNpcMontageWaitType result;
			if (!EWaitInteractNpcMontageWaitTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EWaitInteractNpcMontageWaitType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D895 RID: 55445 RVA: 0x001FA575 File Offset: 0x001F8775
		public static bool TryFromString(string name, out EWaitInteractNpcMontageWaitType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EWaitInteractNpcMontageWaitType.WaitForMontage;
				return false;
			}
			if (name == "WaitForMontage")
			{
				value = EWaitInteractNpcMontageWaitType.WaitForMontage;
				return true;
			}
			if (!(name == "WaitForMontageLoop"))
			{
				value = EWaitInteractNpcMontageWaitType.WaitForMontage;
				return false;
			}
			value = EWaitInteractNpcMontageWaitType.WaitForMontageLoop;
			return true;
		}

		// Token: 0x0600D896 RID: 55446 RVA: 0x001FA5AE File Offset: 0x001F87AE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"WaitForMontage",
				"WaitForMontageLoop"
			};
		}

		// Token: 0x0600D897 RID: 55447 RVA: 0x001FA5C6 File Offset: 0x001F87C6
		public static EWaitInteractNpcMontageWaitType[] GetValues()
		{
			return new EWaitInteractNpcMontageWaitType[]
			{
				EWaitInteractNpcMontageWaitType.WaitForMontage,
				EWaitInteractNpcMontageWaitType.WaitForMontageLoop
			};
		}

		// Token: 0x0600D898 RID: 55448 RVA: 0x001FA5D2 File Offset: 0x001F87D2
		public static string[] GetNames()
		{
			return new string[]
			{
				"WaitForMontage",
				"WaitForMontageLoop"
			};
		}
	}
}
