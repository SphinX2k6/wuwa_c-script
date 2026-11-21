using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x02005447 RID: 21575
	public static class EMatchThreeSkillSequenceEventExtensions
	{
		// Token: 0x060358E0 RID: 219360 RVA: 0x00EF4F20 File Offset: 0x00EF3120
		public static string ToEnumString(this EMatchThreeSkillSequenceEvent value)
		{
			string result;
			if (value == EMatchThreeSkillSequenceEvent.Up)
			{
				result = "Up";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x060358E1 RID: 219361 RVA: 0x00EF4F48 File Offset: 0x00EF3148
		public static EMatchThreeSkillSequenceEvent FromString(string name)
		{
			EMatchThreeSkillSequenceEvent result;
			if (!EMatchThreeSkillSequenceEventExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMatchThreeSkillSequenceEvent 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060358E2 RID: 219362 RVA: 0x00EF4F71 File Offset: 0x00EF3171
		public static bool TryFromString(string name, out EMatchThreeSkillSequenceEvent value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMatchThreeSkillSequenceEvent.Up;
				return false;
			}
			if (name == "Up")
			{
				value = EMatchThreeSkillSequenceEvent.Up;
				return true;
			}
			value = EMatchThreeSkillSequenceEvent.Up;
			return false;
		}

		// Token: 0x060358E3 RID: 219363 RVA: 0x00EF4F96 File Offset: 0x00EF3196
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Up"
			};
		}

		// Token: 0x060358E4 RID: 219364 RVA: 0x00EF4FA6 File Offset: 0x00EF31A6
		public static EMatchThreeSkillSequenceEvent[] GetValues()
		{
			return new EMatchThreeSkillSequenceEvent[1];
		}

		// Token: 0x060358E5 RID: 219365 RVA: 0x00EF4FAE File Offset: 0x00EF31AE
		public static string[] GetNames()
		{
			return new string[]
			{
				"Up"
			};
		}
	}
}
