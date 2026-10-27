using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002499 RID: 9369
	public static class EVehicleControlTypeExtensions
	{
		// Token: 0x0600CB2F RID: 52015 RVA: 0x001DE9B0 File Offset: 0x001DCBB0
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

		// Token: 0x0600CB30 RID: 52016 RVA: 0x001DE9E8 File Offset: 0x001DCBE8
		public static EVehicleControlType FromString(string name)
		{
			EVehicleControlType result;
			if (!EVehicleControlTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVehicleControlType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CB31 RID: 52017 RVA: 0x001DEA11 File Offset: 0x001DCC11
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

		// Token: 0x0600CB32 RID: 52018 RVA: 0x001DEA4A File Offset: 0x001DCC4A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"EnterPathMoving",
				"ExitPathMoving"
			};
		}

		// Token: 0x0600CB33 RID: 52019 RVA: 0x001DEA62 File Offset: 0x001DCC62
		public static EVehicleControlType[] GetValues()
		{
			return new EVehicleControlType[]
			{
				EVehicleControlType.EnterPathMoving,
				EVehicleControlType.ExitPathMoving
			};
		}

		// Token: 0x0600CB34 RID: 52020 RVA: 0x001DEA6E File Offset: 0x001DCC6E
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
