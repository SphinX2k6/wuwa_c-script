using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002295 RID: 8853
	public static class EActorVisibilityPlayModeExtensions
	{
		// Token: 0x0600C21D RID: 49693 RVA: 0x001C5B64 File Offset: 0x001C3D64
		public static string ToEnumString(this EActorVisibilityPlayMode value)
		{
			string result;
			if (value != EActorVisibilityPlayMode.FadeIn)
			{
				if (value != EActorVisibilityPlayMode.FadeOut)
				{
					result = value.ToString();
				}
				else
				{
					result = "FadeOut";
				}
			}
			else
			{
				result = "FadeIn";
			}
			return result;
		}

		// Token: 0x0600C21E RID: 49694 RVA: 0x001C5B9C File Offset: 0x001C3D9C
		public static EActorVisibilityPlayMode FromString(string name)
		{
			EActorVisibilityPlayMode result;
			if (!EActorVisibilityPlayModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EActorVisibilityPlayMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C21F RID: 49695 RVA: 0x001C5BC5 File Offset: 0x001C3DC5
		public static bool TryFromString(string name, out EActorVisibilityPlayMode value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EActorVisibilityPlayMode.FadeIn;
				return false;
			}
			if (name == "FadeIn")
			{
				value = EActorVisibilityPlayMode.FadeIn;
				return true;
			}
			if (!(name == "FadeOut"))
			{
				value = EActorVisibilityPlayMode.FadeIn;
				return false;
			}
			value = EActorVisibilityPlayMode.FadeOut;
			return true;
		}

		// Token: 0x0600C220 RID: 49696 RVA: 0x001C5BFE File Offset: 0x001C3DFE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FadeIn",
				"FadeOut"
			};
		}

		// Token: 0x0600C221 RID: 49697 RVA: 0x001C5C16 File Offset: 0x001C3E16
		public static EActorVisibilityPlayMode[] GetValues()
		{
			return new EActorVisibilityPlayMode[]
			{
				EActorVisibilityPlayMode.FadeIn,
				EActorVisibilityPlayMode.FadeOut
			};
		}

		// Token: 0x0600C222 RID: 49698 RVA: 0x001C5C22 File Offset: 0x001C3E22
		public static string[] GetNames()
		{
			return new string[]
			{
				"FadeIn",
				"FadeOut"
			};
		}
	}
}
