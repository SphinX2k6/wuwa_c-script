using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026AA RID: 9898
	public static class ESetReviveTypeExtensions
	{
		// Token: 0x0600D557 RID: 54615 RVA: 0x001EF994 File Offset: 0x001EDB94
		public static string ToEnumString(this ESetReviveType value)
		{
			string result;
			if (value != ESetReviveType.Add)
			{
				if (value != ESetReviveType.Remove)
				{
					result = value.ToString();
				}
				else
				{
					result = "Remove";
				}
			}
			else
			{
				result = "Add";
			}
			return result;
		}

		// Token: 0x0600D558 RID: 54616 RVA: 0x001EF9CC File Offset: 0x001EDBCC
		public static ESetReviveType FromString(string name)
		{
			ESetReviveType result;
			if (!ESetReviveTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESetReviveType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D559 RID: 54617 RVA: 0x001EF9F5 File Offset: 0x001EDBF5
		public static bool TryFromString(string name, out ESetReviveType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESetReviveType.Add;
				return false;
			}
			if (name == "Add")
			{
				value = ESetReviveType.Add;
				return true;
			}
			if (!(name == "Remove"))
			{
				value = ESetReviveType.Add;
				return false;
			}
			value = ESetReviveType.Remove;
			return true;
		}

		// Token: 0x0600D55A RID: 54618 RVA: 0x001EFA2E File Offset: 0x001EDC2E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Add",
				"Remove"
			};
		}

		// Token: 0x0600D55B RID: 54619 RVA: 0x001EFA46 File Offset: 0x001EDC46
		public static ESetReviveType[] GetValues()
		{
			return new ESetReviveType[]
			{
				ESetReviveType.Add,
				ESetReviveType.Remove
			};
		}

		// Token: 0x0600D55C RID: 54620 RVA: 0x001EFA52 File Offset: 0x001EDC52
		public static string[] GetNames()
		{
			return new string[]
			{
				"Add",
				"Remove"
			};
		}
	}
}
