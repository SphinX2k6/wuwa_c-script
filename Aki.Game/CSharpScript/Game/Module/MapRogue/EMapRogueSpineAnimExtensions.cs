using System;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02005640 RID: 22080
	public static class EMapRogueSpineAnimExtensions
	{
		// Token: 0x0603823B RID: 229947 RVA: 0x00D4C490 File Offset: 0x00D4A690
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

		// Token: 0x0603823C RID: 229948 RVA: 0x00D4C4E4 File Offset: 0x00D4A6E4
		public static EMapRogueSpineAnim FromString(string name)
		{
			EMapRogueSpineAnim result;
			if (!EMapRogueSpineAnimExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMapRogueSpineAnim 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0603823D RID: 229949 RVA: 0x00D4C510 File Offset: 0x00D4A710
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

		// Token: 0x0603823E RID: 229950 RVA: 0x00D4C578 File Offset: 0x00D4A778
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

		// Token: 0x0603823F RID: 229951 RVA: 0x00D4C5A0 File Offset: 0x00D4A7A0
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

		// Token: 0x06038240 RID: 229952 RVA: 0x00D4C5B3 File Offset: 0x00D4A7B3
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
