using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023D7 RID: 9175
	public static class EPlayMovieProgramSpecialConfigTypeExtensions
	{
		// Token: 0x0600C7C6 RID: 51142 RVA: 0x001D3F14 File Offset: 0x001D2114
		public static string ToEnumString(this EPlayMovieProgramSpecialConfigType value)
		{
			string result;
			if (value == EPlayMovieProgramSpecialConfigType.Mp4UiReplaceMaterial)
			{
				result = "Mp4UiReplaceMaterial";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600C7C7 RID: 51143 RVA: 0x001D3F3C File Offset: 0x001D213C
		public static EPlayMovieProgramSpecialConfigType FromString(string name)
		{
			EPlayMovieProgramSpecialConfigType result;
			if (!EPlayMovieProgramSpecialConfigTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPlayMovieProgramSpecialConfigType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C7C8 RID: 51144 RVA: 0x001D3F65 File Offset: 0x001D2165
		public static bool TryFromString(string name, out EPlayMovieProgramSpecialConfigType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPlayMovieProgramSpecialConfigType.Mp4UiReplaceMaterial;
				return false;
			}
			if (name == "Mp4UiReplaceMaterial")
			{
				value = EPlayMovieProgramSpecialConfigType.Mp4UiReplaceMaterial;
				return true;
			}
			value = EPlayMovieProgramSpecialConfigType.Mp4UiReplaceMaterial;
			return false;
		}

		// Token: 0x0600C7C9 RID: 51145 RVA: 0x001D3F8A File Offset: 0x001D218A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Mp4UiReplaceMaterial"
			};
		}

		// Token: 0x0600C7CA RID: 51146 RVA: 0x001D3F9A File Offset: 0x001D219A
		public static EPlayMovieProgramSpecialConfigType[] GetValues()
		{
			return new EPlayMovieProgramSpecialConfigType[1];
		}

		// Token: 0x0600C7CB RID: 51147 RVA: 0x001D3FA2 File Offset: 0x001D21A2
		public static string[] GetNames()
		{
			return new string[]
			{
				"Mp4UiReplaceMaterial"
			};
		}
	}
}
