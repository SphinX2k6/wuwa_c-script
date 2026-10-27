using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using UnrealEngine;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000192 RID: 402
	[NullableContext(1)]
	[Nullable(0)]
	public static class SdkServerEncodeHelper
	{
		// Token: 0x06000AD1 RID: 2769 RVA: 0x0004529C File Offset: 0x0004349C
		public static string MarkData(params object[] keyValPairs)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			for (int i = 0; i < keyValPairs.Length; i += 2)
			{
				if (i + 1 < keyValPairs.Length && keyValPairs[i] != null && keyValPairs[i + 1] != null)
				{
					dictionary[keyValPairs[i].ToString()] = keyValPairs[i + 1];
				}
			}
			return SdkServerEncodeHelper.MarkDataFlag(dictionary);
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x000452EC File Offset: 0x000434EC
		private static string MarkDataFlag(Dictionary<string, object> paramsMap)
		{
			string text = UKuroStaticLibrary.Base64EncodeWithConvertToUTF8(JsonSerializer.Serialize<Dictionary<string, object>>(paramsMap, null));
			string result;
			if (text.Length > 42)
			{
				char[] array = text.ToCharArray();
				SdkServerEncodeHelper.ChangeArray(array, new int[]
				{
					1,
					33,
					10,
					42,
					18,
					50,
					19,
					51
				});
				result = new string(array);
			}
			else
			{
				result = text;
			}
			return result;
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x0004533C File Offset: 0x0004353C
		private static void ChangeArray(char[] chars, params int[] index)
		{
			for (int i = 0; i < index.Length; i += 2)
			{
				int num = index[i];
				int num2 = index[i + 1];
				if (num >= 0 && num < chars.Length && num2 >= 0 && num2 < chars.Length)
				{
					char c = chars[num];
					chars[num] = chars[num2];
					chars[num2] = c;
				}
			}
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x00045384 File Offset: 0x00043584
		public static string MarkSign(string appKey, params string[] keyVal)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			for (int i = 0; i < keyVal.Length; i += 2)
			{
				if (i + 1 < keyVal.Length && keyVal[i] != null && keyVal[i + 1] != null)
				{
					dictionary[keyVal[i]] = keyVal[i + 1];
				}
			}
			return SdkServerEncodeHelper.MarkSignFlag(appKey, dictionary);
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x000453D0 File Offset: 0x000435D0
		private static string MarkSignFlag(string appKey, Dictionary<string, string> paramsMap)
		{
			List<string> list = new List<string>();
			foreach (string text in paramsMap.Keys)
			{
				if (text != "sign")
				{
					list.Add(text);
				}
			}
			list.Sort();
			string text2 = "";
			for (int i = 0; i < list.Count; i++)
			{
				string text3 = list[i];
				string text4 = paramsMap[text3];
				if (text3.Length > 0)
				{
					text2 = string.Concat(new string[]
					{
						text2,
						text3,
						"=",
						text4,
						"&"
					});
				}
			}
			text2 += appKey;
			return UKuroStaticLibrary.Md5HashAnsiString(text2);
		}
	}
}
