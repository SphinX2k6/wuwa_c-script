using System;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02004616 RID: 17942
	public static class EMapRogueSpineAnimExtensions
	{
		// Token: 0x0602D139 RID: 184633 RVA: 0x00C9A1D8 File Offset: 0x00C983D8
		public static string ToEnumString(this EMapRogueSpineAnim value)
		{
			string result;
			switch (value)
			{
			case EMapRogueSpineAnim.Idle:
				result = "Idle";
				break;
			case EMapRogueSpineAnim.Move:
				result = "Run";
				break;
			case EMapRogueSpineAnim.Cheer:
				result = "Cheer";
				break;
			case EMapRogueSpineAnim.Fight:
				result = "Fight";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0602D13A RID: 184634 RVA: 0x00C9A22C File Offset: 0x00C9842C
		public static EMapRogueSpineAnim FromString(string name)
		{
			EMapRogueSpineAnim result;
			if (!EMapRogueSpineAnimExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMapRogueSpineAnim 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0602D13B RID: 184635 RVA: 0x00C9A258 File Offset: 0x00C98458
		public static bool TryFromString(string name, out EMapRogueSpineAnim value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMapRogueSpineAnim.Idle;
				return false;
			}
			if (name == "Idle")
			{
				value = EMapRogueSpineAnim.Idle;
				return true;
			}
			if (name == "Run")
			{
				value = EMapRogueSpineAnim.Move;
				return true;
			}
			if (name == "Cheer")
			{
				value = EMapRogueSpineAnim.Cheer;
				return true;
			}
			if (!(name == "Fight"))
			{
				value = EMapRogueSpineAnim.Idle;
				return false;
			}
			value = EMapRogueSpineAnim.Fight;
			return true;
		}

		// Token: 0x0602D13C RID: 184636 RVA: 0x00C9A2C0 File Offset: 0x00C984C0
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Idle",
				"Run",
				"Cheer",
				"Fight"
			};
		}

		// Token: 0x0602D13D RID: 184637 RVA: 0x00C9A2E8 File Offset: 0x00C984E8
		public static EMapRogueSpineAnim[] GetValues()
		{
			return new EMapRogueSpineAnim[]
			{
				EMapRogueSpineAnim.Idle,
				EMapRogueSpineAnim.Move,
				EMapRogueSpineAnim.Cheer,
				EMapRogueSpineAnim.Fight
			};
		}

		// Token: 0x0602D13E RID: 184638 RVA: 0x00C9A2FB File Offset: 0x00C984FB
		public static string[] GetNames()
		{
			return new string[]
			{
				"Idle",
				"Move",
				"Cheer",
				"Fight"
			};
		}
	}
}
