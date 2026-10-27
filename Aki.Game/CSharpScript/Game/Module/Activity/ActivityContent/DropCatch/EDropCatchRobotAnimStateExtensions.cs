using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020066CC RID: 26316
	public static class EDropCatchRobotAnimStateExtensions
	{
		// Token: 0x06041CE9 RID: 269545 RVA: 0x00FF5DC4 File Offset: 0x00FF3FC4
		public static string ToEnumString(this EDropCatchRobotAnimState value)
		{
			string result;
			switch (value)
			{
			case EDropCatchRobotAnimState.HappyLeft:
				result = "happy_R";
				break;
			case EDropCatchRobotAnimState.HappyRight:
				result = "happy_L";
				break;
			case EDropCatchRobotAnimState.IdleLeft:
				result = "idle_R";
				break;
			case EDropCatchRobotAnimState.IdleRight:
				result = "idle_L";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06041CEA RID: 269546 RVA: 0x00FF5E18 File Offset: 0x00FF4018
		public static EDropCatchRobotAnimState FromString(string name)
		{
			EDropCatchRobotAnimState result;
			if (!EDropCatchRobotAnimStateExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDropCatchRobotAnimState 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06041CEB RID: 269547 RVA: 0x00FF5E44 File Offset: 0x00FF4044
		public static bool TryFromString(string name, out EDropCatchRobotAnimState value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDropCatchRobotAnimState.HappyLeft;
				return false;
			}
			if (name == "happy_R")
			{
				value = EDropCatchRobotAnimState.HappyLeft;
				return true;
			}
			if (name == "happy_L")
			{
				value = EDropCatchRobotAnimState.HappyRight;
				return true;
			}
			if (name == "idle_R")
			{
				value = EDropCatchRobotAnimState.IdleLeft;
				return true;
			}
			if (!(name == "idle_L"))
			{
				value = EDropCatchRobotAnimState.HappyLeft;
				return false;
			}
			value = EDropCatchRobotAnimState.IdleRight;
			return true;
		}

		// Token: 0x06041CEC RID: 269548 RVA: 0x00FF5EAC File Offset: 0x00FF40AC
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"happy_R",
				"happy_L",
				"idle_R",
				"idle_L"
			};
		}

		// Token: 0x06041CED RID: 269549 RVA: 0x00FF5ED4 File Offset: 0x00FF40D4
		public static EDropCatchRobotAnimState[] GetValues()
		{
			return new EDropCatchRobotAnimState[]
			{
				EDropCatchRobotAnimState.HappyLeft,
				EDropCatchRobotAnimState.HappyRight,
				EDropCatchRobotAnimState.IdleLeft,
				EDropCatchRobotAnimState.IdleRight
			};
		}

		// Token: 0x06041CEE RID: 269550 RVA: 0x00FF5EE7 File Offset: 0x00FF40E7
		public static string[] GetNames()
		{
			return new string[]
			{
				"HappyLeft",
				"HappyRight",
				"IdleLeft",
				"IdleRight"
			};
		}
	}
}
