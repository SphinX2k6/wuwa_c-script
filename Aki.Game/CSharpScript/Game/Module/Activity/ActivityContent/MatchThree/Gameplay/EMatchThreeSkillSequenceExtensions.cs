using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x020064C7 RID: 25799
	public static class EMatchThreeSkillSequenceExtensions
	{
		// Token: 0x06040C13 RID: 265235 RVA: 0x00FADDC4 File Offset: 0x00FABFC4
		public static string ToEnumString(this EMatchThreeSkillSequence value)
		{
			string result;
			if (value != EMatchThreeSkillSequence.Ultimate)
			{
				if (value != EMatchThreeSkillSequence.Small)
				{
					result = value.ToString();
				}
				else
				{
					result = "Get2";
				}
			}
			else
			{
				result = "Get";
			}
			return result;
		}

		// Token: 0x06040C14 RID: 265236 RVA: 0x00FADDFC File Offset: 0x00FABFFC
		public static EMatchThreeSkillSequence FromString(string name)
		{
			EMatchThreeSkillSequence result;
			if (!EMatchThreeSkillSequenceExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMatchThreeSkillSequence 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06040C15 RID: 265237 RVA: 0x00FADE25 File Offset: 0x00FAC025
		public static bool TryFromString(string name, out EMatchThreeSkillSequence value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMatchThreeSkillSequence.Ultimate;
				return false;
			}
			if (name == "Get")
			{
				value = EMatchThreeSkillSequence.Ultimate;
				return true;
			}
			if (!(name == "Get2"))
			{
				value = EMatchThreeSkillSequence.Ultimate;
				return false;
			}
			value = EMatchThreeSkillSequence.Small;
			return true;
		}

		// Token: 0x06040C16 RID: 265238 RVA: 0x00FADE5E File Offset: 0x00FAC05E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Get",
				"Get2"
			};
		}

		// Token: 0x06040C17 RID: 265239 RVA: 0x00FADE76 File Offset: 0x00FAC076
		public static EMatchThreeSkillSequence[] GetValues()
		{
			return new EMatchThreeSkillSequence[]
			{
				EMatchThreeSkillSequence.Ultimate,
				EMatchThreeSkillSequence.Small
			};
		}

		// Token: 0x06040C18 RID: 265240 RVA: 0x00FADE82 File Offset: 0x00FAC082
		public static string[] GetNames()
		{
			return new string[]
			{
				"Ultimate",
				"Small"
			};
		}
	}
}
