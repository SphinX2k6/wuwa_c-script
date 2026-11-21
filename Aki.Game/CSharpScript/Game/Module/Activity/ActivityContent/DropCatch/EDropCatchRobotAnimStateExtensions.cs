using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x0200561C RID: 22044
	public static class EDropCatchRobotAnimStateExtensions
	{
		// Token: 0x06036835 RID: 223285 RVA: 0x00F371C8 File Offset: 0x00F353C8
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

		// Token: 0x06036836 RID: 223286 RVA: 0x00F3721C File Offset: 0x00F3541C
		public static EDropCatchRobotAnimState FromString(string name)
		{
			EDropCatchRobotAnimState result;
			if (!EDropCatchRobotAnimStateExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDropCatchRobotAnimState 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06036837 RID: 223287 RVA: 0x00F37248 File Offset: 0x00F35448
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

		// Token: 0x06036838 RID: 223288 RVA: 0x00F372B0 File Offset: 0x00F354B0
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

		// Token: 0x06036839 RID: 223289 RVA: 0x00F372D8 File Offset: 0x00F354D8
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

		// Token: 0x0603683A RID: 223290 RVA: 0x00F372EB File Offset: 0x00F354EB
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
