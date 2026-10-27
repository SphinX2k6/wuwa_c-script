using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.PreWarm
{
	// Token: 0x020062C2 RID: 25282
	public static class EActivityPreWarmHexColorExtensions
	{
		// Token: 0x0603F957 RID: 260439 RVA: 0x00F617F0 File Offset: 0x00F5F9F0
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

		// Token: 0x0603F958 RID: 260440 RVA: 0x00F61838 File Offset: 0x00F5FA38
		public static EActivityPreWarmHexColor FromString(string name)
		{
			EActivityPreWarmHexColor result;
			if (!EActivityPreWarmHexColorExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EActivityPreWarmHexColor 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0603F959 RID: 260441 RVA: 0x00F61864 File Offset: 0x00F5FA64
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

		// Token: 0x0603F95A RID: 260442 RVA: 0x00F618BA File Offset: 0x00F5FABA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"#50282AFF",
				"#0F855D66",
				"#BE7A3766"
			};
		}

		// Token: 0x0603F95B RID: 260443 RVA: 0x00F618DA File Offset: 0x00F5FADA
		public static EActivityPreWarmHexColor[] GetValues()
		{
			return new EActivityPreWarmHexColor[]
			{
				EActivityPreWarmHexColor.Red,
				EActivityPreWarmHexColor.Green,
				EActivityPreWarmHexColor.Brown
			};
		}

		// Token: 0x0603F95C RID: 260444 RVA: 0x00F618EA File Offset: 0x00F5FAEA
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
