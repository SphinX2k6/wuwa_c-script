using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002373 RID: 9075
	public static class ELockStateExtensions
	{
		// Token: 0x0600C604 RID: 50692 RVA: 0x001D02E4 File Offset: 0x001CE4E4
		public static string ToEnumString(this ELockState value)
		{
			string result;
			if (value != ELockState.Lock)
			{
				if (value != ELockState.Unlock)
				{
					result = value.ToString();
				}
				else
				{
					result = "Unlock";
				}
			}
			else
			{
				result = "Lock";
			}
			return result;
		}

		// Token: 0x0600C605 RID: 50693 RVA: 0x001D031C File Offset: 0x001CE51C
		public static ELockState FromString(string name)
		{
			ELockState result;
			if (!ELockStateExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELockState 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C606 RID: 50694 RVA: 0x001D0345 File Offset: 0x001CE545
		public static bool TryFromString(string name, out ELockState value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ELockState.Lock;
				return false;
			}
			if (name == "Lock")
			{
				value = ELockState.Lock;
				return true;
			}
			if (!(name == "Unlock"))
			{
				value = ELockState.Lock;
				return false;
			}
			value = ELockState.Unlock;
			return true;
		}

		// Token: 0x0600C607 RID: 50695 RVA: 0x001D037E File Offset: 0x001CE57E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Lock",
				"Unlock"
			};
		}

		// Token: 0x0600C608 RID: 50696 RVA: 0x001D0396 File Offset: 0x001CE596
		public static ELockState[] GetValues()
		{
			return new ELockState[]
			{
				ELockState.Lock,
				ELockState.Unlock
			};
		}

		// Token: 0x0600C609 RID: 50697 RVA: 0x001D03A2 File Offset: 0x001CE5A2
		public static string[] GetNames()
		{
			return new string[]
			{
				"Lock",
				"Unlock"
			};
		}
	}
}
