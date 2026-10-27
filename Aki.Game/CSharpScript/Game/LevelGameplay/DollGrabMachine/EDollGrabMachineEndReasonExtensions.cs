using System;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006ED2 RID: 28370
	public static class EDollGrabMachineEndReasonExtensions
	{
		// Token: 0x060451E4 RID: 283108 RVA: 0x011177A8 File Offset: 0x011159A8
		public static string ToEnumString(this EDollGrabMachineEndReason value)
		{
			string result;
			switch (value)
			{
			case EDollGrabMachineEndReason.TimeUp:
				result = "TimeUp";
				break;
			case EDollGrabMachineEndReason.GetAll:
				result = "GetAll";
				break;
			case EDollGrabMachineEndReason.Exit:
				result = "Exit";
				break;
			case EDollGrabMachineEndReason.Exception:
				result = "Exception";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x060451E5 RID: 283109 RVA: 0x011177FC File Offset: 0x011159FC
		public static EDollGrabMachineEndReason FromString(string name)
		{
			EDollGrabMachineEndReason result;
			if (!EDollGrabMachineEndReasonExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDollGrabMachineEndReason 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060451E6 RID: 283110 RVA: 0x01117828 File Offset: 0x01115A28
		public static bool TryFromString(string name, out EDollGrabMachineEndReason value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDollGrabMachineEndReason.TimeUp;
				return false;
			}
			if (name == "TimeUp")
			{
				value = EDollGrabMachineEndReason.TimeUp;
				return true;
			}
			if (name == "GetAll")
			{
				value = EDollGrabMachineEndReason.GetAll;
				return true;
			}
			if (name == "Exit")
			{
				value = EDollGrabMachineEndReason.Exit;
				return true;
			}
			if (!(name == "Exception"))
			{
				value = EDollGrabMachineEndReason.TimeUp;
				return false;
			}
			value = EDollGrabMachineEndReason.Exception;
			return true;
		}

		// Token: 0x060451E7 RID: 283111 RVA: 0x01117890 File Offset: 0x01115A90
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"TimeUp",
				"GetAll",
				"Exit",
				"Exception"
			};
		}

		// Token: 0x060451E8 RID: 283112 RVA: 0x011178B8 File Offset: 0x01115AB8
		public static EDollGrabMachineEndReason[] GetValues()
		{
			return new EDollGrabMachineEndReason[]
			{
				EDollGrabMachineEndReason.TimeUp,
				EDollGrabMachineEndReason.GetAll,
				EDollGrabMachineEndReason.Exit,
				EDollGrabMachineEndReason.Exception
			};
		}

		// Token: 0x060451E9 RID: 283113 RVA: 0x011178CB File Offset: 0x01115ACB
		public static string[] GetNames()
		{
			return new string[]
			{
				"TimeUp",
				"GetAll",
				"Exit",
				"Exception"
			};
		}
	}
}
