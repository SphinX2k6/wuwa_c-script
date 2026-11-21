using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200266E RID: 9838
	public static class EPlayMovieProgramSpecialConfigTypeExtensions
	{
		// Token: 0x0600D449 RID: 54345 RVA: 0x001ED6C0 File Offset: 0x001EB8C0
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

		// Token: 0x0600D44A RID: 54346 RVA: 0x001ED6E8 File Offset: 0x001EB8E8
		public static EPlayMovieProgramSpecialConfigType FromString(string name)
		{
			EPlayMovieProgramSpecialConfigType result;
			if (!EPlayMovieProgramSpecialConfigTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPlayMovieProgramSpecialConfigType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D44B RID: 54347 RVA: 0x001ED711 File Offset: 0x001EB911
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

		// Token: 0x0600D44C RID: 54348 RVA: 0x001ED736 File Offset: 0x001EB936
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Mp4UiReplaceMaterial"
			};
		}

		// Token: 0x0600D44D RID: 54349 RVA: 0x001ED746 File Offset: 0x001EB946
		public static EPlayMovieProgramSpecialConfigType[] GetValues()
		{
			return new EPlayMovieProgramSpecialConfigType[1];
		}

		// Token: 0x0600D44E RID: 54350 RVA: 0x001ED74E File Offset: 0x001EB94E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Mp4UiReplaceMaterial"
			};
		}
	}
}
