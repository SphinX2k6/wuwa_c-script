using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024BD RID: 9405
	public static class EWaitInteractNpcMontageWaitTypeExtensions
	{
		// Token: 0x0600CBD1 RID: 52177 RVA: 0x001E0280 File Offset: 0x001DE480
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

		// Token: 0x0600CBD2 RID: 52178 RVA: 0x001E02B8 File Offset: 0x001DE4B8
		public static EWaitInteractNpcMontageWaitType FromString(string name)
		{
			EWaitInteractNpcMontageWaitType result;
			if (!EWaitInteractNpcMontageWaitTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EWaitInteractNpcMontageWaitType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CBD3 RID: 52179 RVA: 0x001E02E1 File Offset: 0x001DE4E1
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

		// Token: 0x0600CBD4 RID: 52180 RVA: 0x001E031A File Offset: 0x001DE51A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"WaitForMontage",
				"WaitForMontageLoop"
			};
		}

		// Token: 0x0600CBD5 RID: 52181 RVA: 0x001E0332 File Offset: 0x001DE532
		public static EWaitInteractNpcMontageWaitType[] GetValues()
		{
			return new EWaitInteractNpcMontageWaitType[]
			{
				EWaitInteractNpcMontageWaitType.WaitForMontage,
				EWaitInteractNpcMontageWaitType.WaitForMontageLoop
			};
		}

		// Token: 0x0600CBD6 RID: 52182 RVA: 0x001E033E File Offset: 0x001DE53E
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
