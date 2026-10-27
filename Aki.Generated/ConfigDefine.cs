using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;

namespace Aki.Config
{
	// Token: 0x02000008 RID: 8
	public static class ConfigDefine
	{
		// Token: 0x06000035 RID: 53 RVA: 0x0005B25C File Offset: 0x0005945C
		[return: Nullable(2)]
		public unsafe static string GetLangLocalText(string tableName, int textKey)
		{
			if (tableName != null)
			{
				switch (tableName.Length)
				{
				case 7:
					if (tableName == "Speaker")
					{
						return ConfigSpeakerLang.GetLocalText(textKey, null);
					}
					break;
				case 8:
					if (tableName == "FlowText")
					{
						return ConfigFlowTextLang.GetLocalText(textKey, null);
					}
					break;
				case 9:
					if (tableName == "MultiText")
					{
						return ConfigMultiTextLang.GetLocalText(textKey, null);
					}
					break;
				case 11:
					if (tableName == "CommonParam")
					{
						return ConfigCommonParamLang.GetLocalText(textKey, null);
					}
					break;
				case 12:
				{
					char c = tableName[0];
					if (c != 'H')
					{
						if (c == 'S')
						{
							if (tableName == "SubtitleText")
							{
								return ConfigSubtitleTextLang.GetLocalText(textKey, null);
							}
						}
					}
					else if (tableName == "HotPatchText")
					{
						return ConfigHotPatchTextLang.GetLocalText(textKey, null);
					}
					break;
				}
				case 14:
				{
					char c = tableName[0];
					if (c != 'C')
					{
						if (c == 'M')
						{
							if (tableName == "MonsterDisplay")
							{
								return ConfigMonsterDisplayLang.GetLocalText(textKey, null);
							}
						}
					}
					else if (tableName == "CustomSequence")
					{
						return ConfigCustomSequenceLang.GetLocalText(textKey, null);
					}
					break;
				}
				case 16:
					if (tableName == "OccupationConfig")
					{
						return ConfigOccupationConfigLang.GetLocalText(textKey, null);
					}
					break;
				}
			}
			ILog instance = Log.Instance;
			ELogModule module = ELogModule.Config;
			ELogAuthor author = ELogAuthor.LRX;
			string message = "查询多语言配置失败, 没有被定义的表!";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("表名", tableName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("文本Key", textKey);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
	}
}
