using System;

namespace CSharpScript.Game.Module.Skin
{
	// Token: 0x02003B95 RID: 15253
	public static class ESkinSpineAnimationExtensions
	{
		// Token: 0x06027167 RID: 160103 RVA: 0x00AEFB78 File Offset: 0x00AEDD78
		public static string ToEnumString(this ESkinSpineAnimation value)
		{
			string result;
			if (value == ESkinSpineAnimation.Idle)
			{
				result = "idle";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06027168 RID: 160104 RVA: 0x00AEFBA0 File Offset: 0x00AEDDA0
		public static ESkinSpineAnimation FromString(string name)
		{
			ESkinSpineAnimation result;
			if (!ESkinSpineAnimationExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESkinSpineAnimation 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06027169 RID: 160105 RVA: 0x00AEFBC9 File Offset: 0x00AEDDC9
		public static bool TryFromString(string name, out ESkinSpineAnimation value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESkinSpineAnimation.Idle;
				return false;
			}
			if (name == "idle")
			{
				value = ESkinSpineAnimation.Idle;
				return true;
			}
			value = ESkinSpineAnimation.Idle;
			return false;
		}

		// Token: 0x0602716A RID: 160106 RVA: 0x00AEFBEE File Offset: 0x00AEDDEE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"idle"
			};
		}

		// Token: 0x0602716B RID: 160107 RVA: 0x00AEFBFE File Offset: 0x00AEDDFE
		public static ESkinSpineAnimation[] GetValues()
		{
			return new ESkinSpineAnimation[1];
		}

		// Token: 0x0602716C RID: 160108 RVA: 0x00AEFC06 File Offset: 0x00AEDE06
		public static string[] GetNames()
		{
			return new string[]
			{
				"Idle"
			};
		}
	}
}
