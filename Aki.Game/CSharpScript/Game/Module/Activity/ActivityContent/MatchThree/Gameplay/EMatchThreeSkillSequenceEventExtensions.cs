using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x020064C9 RID: 25801
	public static class EMatchThreeSkillSequenceEventExtensions
	{
		// Token: 0x06040C1C RID: 265244 RVA: 0x00FADED8 File Offset: 0x00FAC0D8
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

		// Token: 0x06040C1D RID: 265245 RVA: 0x00FADF00 File Offset: 0x00FAC100
		public static EMatchThreeSkillSequenceEvent FromString(string name)
		{
			EMatchThreeSkillSequenceEvent result;
			if (!EMatchThreeSkillSequenceEventExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMatchThreeSkillSequenceEvent 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06040C1E RID: 265246 RVA: 0x00FADF29 File Offset: 0x00FAC129
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

		// Token: 0x06040C1F RID: 265247 RVA: 0x00FADF4E File Offset: 0x00FAC14E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Up"
			};
		}

		// Token: 0x06040C20 RID: 265248 RVA: 0x00FADF5E File Offset: 0x00FAC15E
		public static EMatchThreeSkillSequenceEvent[] GetValues()
		{
			return new EMatchThreeSkillSequenceEvent[1];
		}

		// Token: 0x06040C21 RID: 265249 RVA: 0x00FADF66 File Offset: 0x00FAC166
		public static string[] GetNames()
		{
			return new string[]
			{
				"Up"
			};
		}
	}
}
