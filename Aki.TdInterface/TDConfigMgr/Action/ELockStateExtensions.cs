using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025FC RID: 9724
	public static class ELockStateExtensions
	{
		// Token: 0x0600D248 RID: 53832 RVA: 0x001E92B8 File Offset: 0x001E74B8
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

		// Token: 0x0600D249 RID: 53833 RVA: 0x001E92F0 File Offset: 0x001E74F0
		public static ELockState FromString(string name)
		{
			ELockState result;
			if (!ELockStateExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELockState 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D24A RID: 53834 RVA: 0x001E9319 File Offset: 0x001E7519
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

		// Token: 0x0600D24B RID: 53835 RVA: 0x001E9352 File Offset: 0x001E7552
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Lock",
				"Unlock"
			};
		}

		// Token: 0x0600D24C RID: 53836 RVA: 0x001E936A File Offset: 0x001E756A
		public static ELockState[] GetValues()
		{
			return new ELockState[]
			{
				ELockState.Lock,
				ELockState.Unlock
			};
		}

		// Token: 0x0600D24D RID: 53837 RVA: 0x001E9376 File Offset: 0x001E7576
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
