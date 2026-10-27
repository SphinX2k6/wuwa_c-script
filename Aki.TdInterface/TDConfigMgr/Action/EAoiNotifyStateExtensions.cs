using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022A1 RID: 8865
	public static class EAoiNotifyStateExtensions
	{
		// Token: 0x0600C253 RID: 49747 RVA: 0x001C64D8 File Offset: 0x001C46D8
		public static string ToEnumString(this EAoiNotifyState value)
		{
			string result;
			if (value != EAoiNotifyState.Open)
			{
				if (value != EAoiNotifyState.Close)
				{
					result = value.ToString();
				}
				else
				{
					result = "Close";
				}
			}
			else
			{
				result = "Open";
			}
			return result;
		}

		// Token: 0x0600C254 RID: 49748 RVA: 0x001C6510 File Offset: 0x001C4710
		public static EAoiNotifyState FromString(string name)
		{
			EAoiNotifyState result;
			if (!EAoiNotifyStateExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAoiNotifyState 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C255 RID: 49749 RVA: 0x001C6539 File Offset: 0x001C4739
		public static bool TryFromString(string name, out EAoiNotifyState value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAoiNotifyState.Open;
				return false;
			}
			if (name == "Open")
			{
				value = EAoiNotifyState.Open;
				return true;
			}
			if (!(name == "Close"))
			{
				value = EAoiNotifyState.Open;
				return false;
			}
			value = EAoiNotifyState.Close;
			return true;
		}

		// Token: 0x0600C256 RID: 49750 RVA: 0x001C6572 File Offset: 0x001C4772
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Open",
				"Close"
			};
		}

		// Token: 0x0600C257 RID: 49751 RVA: 0x001C658A File Offset: 0x001C478A
		public static EAoiNotifyState[] GetValues()
		{
			return new EAoiNotifyState[]
			{
				EAoiNotifyState.Open,
				EAoiNotifyState.Close
			};
		}

		// Token: 0x0600C258 RID: 49752 RVA: 0x001C6596 File Offset: 0x001C4796
		public static string[] GetNames()
		{
			return new string[]
			{
				"Open",
				"Close"
			};
		}
	}
}
