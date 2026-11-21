using System;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006052 RID: 24658
	public static class EDollGrabMachineEndReasonExtensions
	{
		// Token: 0x0603B38D RID: 242573 RVA: 0x010C1538 File Offset: 0x010BF738
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

		// Token: 0x0603B38E RID: 242574 RVA: 0x010C158C File Offset: 0x010BF78C
		public static EDollGrabMachineEndReason FromString(string name)
		{
			EDollGrabMachineEndReason result;
			if (!EDollGrabMachineEndReasonExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDollGrabMachineEndReason 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0603B38F RID: 242575 RVA: 0x010C15B8 File Offset: 0x010BF7B8
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

		// Token: 0x0603B390 RID: 242576 RVA: 0x010C1620 File Offset: 0x010BF820
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

		// Token: 0x0603B391 RID: 242577 RVA: 0x010C1648 File Offset: 0x010BF848
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

		// Token: 0x0603B392 RID: 242578 RVA: 0x010C165B File Offset: 0x010BF85B
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
