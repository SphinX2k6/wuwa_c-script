using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x0200544D RID: 21581
	public static class EMatchThreeRoleSpineAnimExtensions
	{
		// Token: 0x060358FB RID: 219387 RVA: 0x00EF5DD8 File Offset: 0x00EF3FD8
		public static string ToEnumString(this EMatchThreeRoleSpineAnim value)
		{
			string result;
			switch (value)
			{
			case EMatchThreeRoleSpineAnim.Idle:
				result = "idle";
				break;
			case EMatchThreeRoleSpineAnim.Start:
				result = "start";
				break;
			case EMatchThreeRoleSpineAnim.Skill1:
				result = "skill1";
				break;
			case EMatchThreeRoleSpineAnim.Skill2:
				result = "skill2";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x060358FC RID: 219388 RVA: 0x00EF5E2C File Offset: 0x00EF402C
		public static EMatchThreeRoleSpineAnim FromString(string name)
		{
			EMatchThreeRoleSpineAnim result;
			if (!EMatchThreeRoleSpineAnimExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMatchThreeRoleSpineAnim 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060358FD RID: 219389 RVA: 0x00EF5E58 File Offset: 0x00EF4058
		public static bool TryFromString(string name, out EMatchThreeRoleSpineAnim value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMatchThreeRoleSpineAnim.Idle;
				return false;
			}
			if (name == "idle")
			{
				value = EMatchThreeRoleSpineAnim.Idle;
				return true;
			}
			if (name == "start")
			{
				value = EMatchThreeRoleSpineAnim.Start;
				return true;
			}
			if (name == "skill1")
			{
				value = EMatchThreeRoleSpineAnim.Skill1;
				return true;
			}
			if (!(name == "skill2"))
			{
				value = EMatchThreeRoleSpineAnim.Idle;
				return false;
			}
			value = EMatchThreeRoleSpineAnim.Skill2;
			return true;
		}

		// Token: 0x060358FE RID: 219390 RVA: 0x00EF5EC0 File Offset: 0x00EF40C0
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"idle",
				"start",
				"skill1",
				"skill2"
			};
		}

		// Token: 0x060358FF RID: 219391 RVA: 0x00EF5EE8 File Offset: 0x00EF40E8
		public static EMatchThreeRoleSpineAnim[] GetValues()
		{
			return new EMatchThreeRoleSpineAnim[]
			{
				EMatchThreeRoleSpineAnim.Idle,
				EMatchThreeRoleSpineAnim.Start,
				EMatchThreeRoleSpineAnim.Skill1,
				EMatchThreeRoleSpineAnim.Skill2
			};
		}

		// Token: 0x06035900 RID: 219392 RVA: 0x00EF5EFB File Offset: 0x00EF40FB
		public static string[] GetNames()
		{
			return new string[]
			{
				"Idle",
				"Start",
				"Skill1",
				"Skill2"
			};
		}
	}
}
