using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x020064CF RID: 25807
	public static class EMatchThreeRoleSpineAnimExtensions
	{
		// Token: 0x06040C37 RID: 265271 RVA: 0x00FAED90 File Offset: 0x00FACF90
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

		// Token: 0x06040C38 RID: 265272 RVA: 0x00FAEDE4 File Offset: 0x00FACFE4
		public static EMatchThreeRoleSpineAnim FromString(string name)
		{
			EMatchThreeRoleSpineAnim result;
			if (!EMatchThreeRoleSpineAnimExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMatchThreeRoleSpineAnim 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06040C39 RID: 265273 RVA: 0x00FAEE10 File Offset: 0x00FAD010
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

		// Token: 0x06040C3A RID: 265274 RVA: 0x00FAEE78 File Offset: 0x00FAD078
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

		// Token: 0x06040C3B RID: 265275 RVA: 0x00FAEEA0 File Offset: 0x00FAD0A0
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

		// Token: 0x06040C3C RID: 265276 RVA: 0x00FAEEB3 File Offset: 0x00FAD0B3
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
