using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200273C RID: 10044
	public static class EVehicleControlTypeExtensions
	{
		// Token: 0x0600D7E8 RID: 55272 RVA: 0x001F8B78 File Offset: 0x001F6D78
		public static string ToEnumString(this EVehicleControlType value)
		{
			string result;
			if (value != EVehicleControlType.EnterPathMoving)
			{
				if (value != EVehicleControlType.ExitPathMoving)
				{
					result = value.ToString();
				}
				else
				{
					result = "ExitPathMoving";
				}
			}
			else
			{
				result = "EnterPathMoving";
			}
			return result;
		}

		// Token: 0x0600D7E9 RID: 55273 RVA: 0x001F8BB0 File Offset: 0x001F6DB0
		public static EVehicleControlType FromString(string name)
		{
			EVehicleControlType result;
			if (!EVehicleControlTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVehicleControlType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D7EA RID: 55274 RVA: 0x001F8BD9 File Offset: 0x001F6DD9
		public static bool TryFromString(string name, out EVehicleControlType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EVehicleControlType.EnterPathMoving;
				return false;
			}
			if (name == "EnterPathMoving")
			{
				value = EVehicleControlType.EnterPathMoving;
				return true;
			}
			if (!(name == "ExitPathMoving"))
			{
				value = EVehicleControlType.EnterPathMoving;
				return false;
			}
			value = EVehicleControlType.ExitPathMoving;
			return true;
		}

		// Token: 0x0600D7EB RID: 55275 RVA: 0x001F8C12 File Offset: 0x001F6E12
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"EnterPathMoving",
				"ExitPathMoving"
			};
		}

		// Token: 0x0600D7EC RID: 55276 RVA: 0x001F8C2A File Offset: 0x001F6E2A
		public static EVehicleControlType[] GetValues()
		{
			return new EVehicleControlType[]
			{
				EVehicleControlType.EnterPathMoving,
				EVehicleControlType.ExitPathMoving
			};
		}

		// Token: 0x0600D7ED RID: 55277 RVA: 0x001F8C36 File Offset: 0x001F6E36
		public static string[] GetNames()
		{
			return new string[]
			{
				"EnterPathMoving",
				"ExitPathMoving"
			};
		}
	}
}
