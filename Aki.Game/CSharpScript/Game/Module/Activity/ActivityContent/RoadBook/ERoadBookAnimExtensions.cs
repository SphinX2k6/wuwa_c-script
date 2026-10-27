using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x020061FD RID: 25085
	public static class ERoadBookAnimExtensions
	{
		// Token: 0x0603F4A9 RID: 259241 RVA: 0x00F4B5A0 File Offset: 0x00F497A0
		public static string ToEnumString(this ERoadBookAnim value)
		{
			string result;
			if (value != ERoadBookAnim.AniOpen)
			{
				if (value != ERoadBookAnim.AniClose)
				{
					result = value.ToString();
				}
				else
				{
					result = "AniClose";
				}
			}
			else
			{
				result = "AniOpen";
			}
			return result;
		}

		// Token: 0x0603F4AA RID: 259242 RVA: 0x00F4B5D8 File Offset: 0x00F497D8
		public static ERoadBookAnim FromString(string name)
		{
			ERoadBookAnim result;
			if (!ERoadBookAnimExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERoadBookAnim 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0603F4AB RID: 259243 RVA: 0x00F4B601 File Offset: 0x00F49801
		public static bool TryFromString(string name, out ERoadBookAnim value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERoadBookAnim.AniOpen;
				return false;
			}
			if (name == "AniOpen")
			{
				value = ERoadBookAnim.AniOpen;
				return true;
			}
			if (!(name == "AniClose"))
			{
				value = ERoadBookAnim.AniOpen;
				return false;
			}
			value = ERoadBookAnim.AniClose;
			return true;
		}

		// Token: 0x0603F4AC RID: 259244 RVA: 0x00F4B63A File Offset: 0x00F4983A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"AniOpen",
				"AniClose"
			};
		}

		// Token: 0x0603F4AD RID: 259245 RVA: 0x00F4B652 File Offset: 0x00F49852
		public static ERoadBookAnim[] GetValues()
		{
			return new ERoadBookAnim[]
			{
				ERoadBookAnim.AniOpen,
				ERoadBookAnim.AniClose
			};
		}

		// Token: 0x0603F4AE RID: 259246 RVA: 0x00F4B65E File Offset: 0x00F4985E
		public static string[] GetNames()
		{
			return new string[]
			{
				"AniOpen",
				"AniClose"
			};
		}
	}
}
