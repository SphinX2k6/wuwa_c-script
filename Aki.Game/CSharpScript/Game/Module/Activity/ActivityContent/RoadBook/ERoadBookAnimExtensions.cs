using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x0200517B RID: 20859
	public static class ERoadBookAnimExtensions
	{
		// Token: 0x0603416A RID: 213354 RVA: 0x00E924F8 File Offset: 0x00E906F8
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

		// Token: 0x0603416B RID: 213355 RVA: 0x00E92530 File Offset: 0x00E90730
		public static ERoadBookAnim FromString(string name)
		{
			ERoadBookAnim result;
			if (!ERoadBookAnimExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERoadBookAnim 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0603416C RID: 213356 RVA: 0x00E92559 File Offset: 0x00E90759
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

		// Token: 0x0603416D RID: 213357 RVA: 0x00E92592 File Offset: 0x00E90792
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"AniOpen",
				"AniClose"
			};
		}

		// Token: 0x0603416E RID: 213358 RVA: 0x00E925AA File Offset: 0x00E907AA
		public static ERoadBookAnim[] GetValues()
		{
			return new ERoadBookAnim[]
			{
				ERoadBookAnim.AniOpen,
				ERoadBookAnim.AniClose
			};
		}

		// Token: 0x0603416F RID: 213359 RVA: 0x00E925B6 File Offset: 0x00E907B6
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
