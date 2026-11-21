using System;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006050 RID: 24656
	public static class EDollGrabMachineStateExtensions
	{
		// Token: 0x0603B384 RID: 242564 RVA: 0x010C13E0 File Offset: 0x010BF5E0
		public static string ToEnumString(this EDollGrabMachineState value)
		{
			string result;
			switch (value)
			{
			case EDollGrabMachineState.InActive:
				result = "InActive";
				break;
			case EDollGrabMachineState.WaitingCountDown:
				result = "WaitingCountDown";
				break;
			case EDollGrabMachineState.Active:
				result = "Active";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0603B385 RID: 242565 RVA: 0x010C1428 File Offset: 0x010BF628
		public static EDollGrabMachineState FromString(string name)
		{
			EDollGrabMachineState result;
			if (!EDollGrabMachineStateExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDollGrabMachineState 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0603B386 RID: 242566 RVA: 0x010C1454 File Offset: 0x010BF654
		public static bool TryFromString(string name, out EDollGrabMachineState value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDollGrabMachineState.InActive;
				return false;
			}
			if (name == "InActive")
			{
				value = EDollGrabMachineState.InActive;
				return true;
			}
			if (name == "WaitingCountDown")
			{
				value = EDollGrabMachineState.WaitingCountDown;
				return true;
			}
			if (!(name == "Active"))
			{
				value = EDollGrabMachineState.InActive;
				return false;
			}
			value = EDollGrabMachineState.Active;
			return true;
		}

		// Token: 0x0603B387 RID: 242567 RVA: 0x010C14AA File Offset: 0x010BF6AA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"InActive",
				"WaitingCountDown",
				"Active"
			};
		}

		// Token: 0x0603B388 RID: 242568 RVA: 0x010C14CA File Offset: 0x010BF6CA
		public static EDollGrabMachineState[] GetValues()
		{
			return new EDollGrabMachineState[]
			{
				EDollGrabMachineState.InActive,
				EDollGrabMachineState.WaitingCountDown,
				EDollGrabMachineState.Active
			};
		}

		// Token: 0x0603B389 RID: 242569 RVA: 0x010C14DA File Offset: 0x010BF6DA
		public static string[] GetNames()
		{
			return new string[]
			{
				"InActive",
				"WaitingCountDown",
				"Active"
			};
		}
	}
}
