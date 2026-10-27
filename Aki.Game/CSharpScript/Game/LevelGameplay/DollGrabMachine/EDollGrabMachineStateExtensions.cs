using System;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006ED0 RID: 28368
	public static class EDollGrabMachineStateExtensions
	{
		// Token: 0x060451DB RID: 283099 RVA: 0x01117650 File Offset: 0x01115850
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

		// Token: 0x060451DC RID: 283100 RVA: 0x01117698 File Offset: 0x01115898
		public static EDollGrabMachineState FromString(string name)
		{
			EDollGrabMachineState result;
			if (!EDollGrabMachineStateExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDollGrabMachineState 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060451DD RID: 283101 RVA: 0x011176C4 File Offset: 0x011158C4
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

		// Token: 0x060451DE RID: 283102 RVA: 0x0111771A File Offset: 0x0111591A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"InActive",
				"WaitingCountDown",
				"Active"
			};
		}

		// Token: 0x060451DF RID: 283103 RVA: 0x0111773A File Offset: 0x0111593A
		public static EDollGrabMachineState[] GetValues()
		{
			return new EDollGrabMachineState[]
			{
				EDollGrabMachineState.InActive,
				EDollGrabMachineState.WaitingCountDown,
				EDollGrabMachineState.Active
			};
		}

		// Token: 0x060451E0 RID: 283104 RVA: 0x0111774A File Offset: 0x0111594A
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
