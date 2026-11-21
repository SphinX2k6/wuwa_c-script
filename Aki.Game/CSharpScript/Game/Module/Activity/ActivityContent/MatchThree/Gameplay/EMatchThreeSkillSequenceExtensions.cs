using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x02005445 RID: 21573
	public static class EMatchThreeSkillSequenceExtensions
	{
		// Token: 0x060358D7 RID: 219351 RVA: 0x00EF4E0C File Offset: 0x00EF300C
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

		// Token: 0x060358D8 RID: 219352 RVA: 0x00EF4E44 File Offset: 0x00EF3044
		public static EMatchThreeSkillSequence FromString(string name)
		{
			EMatchThreeSkillSequence result;
			if (!EMatchThreeSkillSequenceExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMatchThreeSkillSequence 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060358D9 RID: 219353 RVA: 0x00EF4E6D File Offset: 0x00EF306D
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

		// Token: 0x060358DA RID: 219354 RVA: 0x00EF4EA6 File Offset: 0x00EF30A6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Get",
				"Get2"
			};
		}

		// Token: 0x060358DB RID: 219355 RVA: 0x00EF4EBE File Offset: 0x00EF30BE
		public static EMatchThreeSkillSequence[] GetValues()
		{
			return new EMatchThreeSkillSequence[]
			{
				EMatchThreeSkillSequence.Ultimate,
				EMatchThreeSkillSequence.Small
			};
		}

		// Token: 0x060358DC RID: 219356 RVA: 0x00EF4ECA File Offset: 0x00EF30CA
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
