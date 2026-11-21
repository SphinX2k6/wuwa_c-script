using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059DB RID: 23003
	[NullableContext(1)]
	[Nullable(0)]
	public static class SolarSchoolPopupData
	{
		// Token: 0x06038A9D RID: 232093 RVA: 0x00FDB8DC File Offset: 0x00FD9ADC
		public static string GetFavorLevelTextKey(int level)
		{
			string result;
			if (level > 1)
			{
				if (level != 2)
				{
					if (level != 3)
					{
						result = "SolarSchool_humanitiesClassFavor_4";
					}
					else
					{
						result = "SolarSchool_humanitiesClassFavor_3";
					}
				}
				else
				{
					result = "SolarSchool_humanitiesClassFavor_2";
				}
			}
			else
			{
				result = "SolarSchool_humanitiesClassFavor_1";
			}
			return result;
		}

		// Token: 0x06038A9E RID: 232094 RVA: 0x00FDB918 File Offset: 0x00FD9B18
		public unsafe static string GetFavorLevelIcon(int level, ESolarSchoolFavorIconSize size)
		{
			bool flag = size == ESolarSchoolFavorIconSize.Large;
			string resourceId;
			switch (level)
			{
			case 1:
				resourceId = (flag ? "T_SolarSchoolInfoFriendSongGray01" : "T_SolarSchoolInfoFriendSongGray02");
				break;
			case 2:
				resourceId = (flag ? "T_SolarSchoolInfoFriendSongGreen01" : "T_SolarSchoolInfoFriendSongGreen02");
				break;
			case 3:
				resourceId = (flag ? "T_SolarSchoolInfoFriendSongBlue01" : "T_SolarSchoolInfoFriendSongBlue02");
				break;
			case 4:
				resourceId = (flag ? "T_SolarSchoolInfoFriendSongPink01" : "T_SolarSchoolInfoFriendSongPink02");
				break;
			default:
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[SolarSchool] 好感等级没有对应图标";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("level", level);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("size", size);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return string.Empty;
			}
			}
			return UiResourceConfig.Instance.GetResourcePath(resourceId);
		}
	}
}
