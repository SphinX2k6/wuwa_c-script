using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200250E RID: 9486
	public static class EAoiNotifyStateExtensions
	{
		// Token: 0x0600CE19 RID: 52761 RVA: 0x001DE1CC File Offset: 0x001DC3CC
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

		// Token: 0x0600CE1A RID: 52762 RVA: 0x001DE204 File Offset: 0x001DC404
		public static EAoiNotifyState FromString(string name)
		{
			EAoiNotifyState result;
			if (!EAoiNotifyStateExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAoiNotifyState 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CE1B RID: 52763 RVA: 0x001DE22D File Offset: 0x001DC42D
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

		// Token: 0x0600CE1C RID: 52764 RVA: 0x001DE266 File Offset: 0x001DC466
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Open",
				"Close"
			};
		}

		// Token: 0x0600CE1D RID: 52765 RVA: 0x001DE27E File Offset: 0x001DC47E
		public static EAoiNotifyState[] GetValues()
		{
			return new EAoiNotifyState[]
			{
				EAoiNotifyState.Open,
				EAoiNotifyState.Close
			};
		}

		// Token: 0x0600CE1E RID: 52766 RVA: 0x001DE28A File Offset: 0x001DC48A
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
