using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.PreWarm
{
	// Token: 0x02005240 RID: 21056
	public static class EActivityPreWarmHexColorExtensions
	{
		// Token: 0x06034618 RID: 214552 RVA: 0x00EA874C File Offset: 0x00EA694C
		public static string ToEnumString(this EActivityPreWarmHexColor value)
		{
			string result;
			switch (value)
			{
			case EActivityPreWarmHexColor.Red:
				result = "#50282AFF";
				break;
			case EActivityPreWarmHexColor.Green:
				result = "#0F855D66";
				break;
			case EActivityPreWarmHexColor.Brown:
				result = "#BE7A3766";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06034619 RID: 214553 RVA: 0x00EA8794 File Offset: 0x00EA6994
		public static EActivityPreWarmHexColor FromString(string name)
		{
			EActivityPreWarmHexColor result;
			if (!EActivityPreWarmHexColorExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EActivityPreWarmHexColor 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0603461A RID: 214554 RVA: 0x00EA87C0 File Offset: 0x00EA69C0
		public static bool TryFromString(string name, out EActivityPreWarmHexColor value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EActivityPreWarmHexColor.Red;
				return false;
			}
			if (name == "#50282AFF")
			{
				value = EActivityPreWarmHexColor.Red;
				return true;
			}
			if (name == "#0F855D66")
			{
				value = EActivityPreWarmHexColor.Green;
				return true;
			}
			if (!(name == "#BE7A3766"))
			{
				value = EActivityPreWarmHexColor.Red;
				return false;
			}
			value = EActivityPreWarmHexColor.Brown;
			return true;
		}

		// Token: 0x0603461B RID: 214555 RVA: 0x00EA8816 File Offset: 0x00EA6A16
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"#50282AFF",
				"#0F855D66",
				"#BE7A3766"
			};
		}

		// Token: 0x0603461C RID: 214556 RVA: 0x00EA8836 File Offset: 0x00EA6A36
		public static EActivityPreWarmHexColor[] GetValues()
		{
			return new EActivityPreWarmHexColor[]
			{
				EActivityPreWarmHexColor.Red,
				EActivityPreWarmHexColor.Green,
				EActivityPreWarmHexColor.Brown
			};
		}

		// Token: 0x0603461D RID: 214557 RVA: 0x00EA8846 File Offset: 0x00EA6A46
		public static string[] GetNames()
		{
			return new string[]
			{
				"Red",
				"Green",
				"Brown"
			};
		}
	}
}
