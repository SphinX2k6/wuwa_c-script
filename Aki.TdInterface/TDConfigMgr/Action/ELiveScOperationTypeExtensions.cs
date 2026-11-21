using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025F8 RID: 9720
	public static class ELiveScOperationTypeExtensions
	{
		// Token: 0x0600D236 RID: 53814 RVA: 0x001E8FC0 File Offset: 0x001E71C0
		public static string ToEnumString(this ELiveScOperationType value)
		{
			string result;
			if (value != ELiveScOperationType.Send)
			{
				if (value != ELiveScOperationType.Clear)
				{
					result = value.ToString();
				}
				else
				{
					result = "Clear";
				}
			}
			else
			{
				result = "Send";
			}
			return result;
		}

		// Token: 0x0600D237 RID: 53815 RVA: 0x001E8FF8 File Offset: 0x001E71F8
		public static ELiveScOperationType FromString(string name)
		{
			ELiveScOperationType result;
			if (!ELiveScOperationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELiveScOperationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D238 RID: 53816 RVA: 0x001E9021 File Offset: 0x001E7221
		public static bool TryFromString(string name, out ELiveScOperationType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ELiveScOperationType.Send;
				return false;
			}
			if (name == "Send")
			{
				value = ELiveScOperationType.Send;
				return true;
			}
			if (!(name == "Clear"))
			{
				value = ELiveScOperationType.Send;
				return false;
			}
			value = ELiveScOperationType.Clear;
			return true;
		}

		// Token: 0x0600D239 RID: 53817 RVA: 0x001E905A File Offset: 0x001E725A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Send",
				"Clear"
			};
		}

		// Token: 0x0600D23A RID: 53818 RVA: 0x001E9072 File Offset: 0x001E7272
		public static ELiveScOperationType[] GetValues()
		{
			return new ELiveScOperationType[]
			{
				ELiveScOperationType.Send,
				ELiveScOperationType.Clear
			};
		}

		// Token: 0x0600D23B RID: 53819 RVA: 0x001E907E File Offset: 0x001E727E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Send",
				"Clear"
			};
		}
	}
}
