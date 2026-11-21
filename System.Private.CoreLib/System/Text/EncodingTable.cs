using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Text
{
	// Token: 0x0200022D RID: 557
	internal static class EncodingTable
	{
		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06002AA2 RID: 10914 RVA: 0x00085019 File Offset: 0x00083219
		private static ReadOnlySpan<int> EncodingNameIndices
		{
			get
			{
				return RuntimeHelpers.CreateSpan<int>(fieldof(<PrivateImplementationDetails>.AEB31B4AC5951D8327BBC52024D5BF6C8008599AE0E643DEDF384FC64895ADB84).FieldHandle);
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06002AA3 RID: 10915 RVA: 0x00085025 File Offset: 0x00083225
		private static ReadOnlySpan<ushort> CodePagesByName
		{
			get
			{
				return RuntimeHelpers.CreateSpan<ushort>(fieldof(<PrivateImplementationDetails>.84E999175BD7682C7A3A26821DDD45BB815A526199CF0F94660B714915552EA02).FieldHandle);
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06002AA4 RID: 10916 RVA: 0x00085031 File Offset: 0x00083231
		private static ReadOnlySpan<ushort> MappedCodePages
		{
			get
			{
				return RuntimeHelpers.CreateSpan<ushort>(fieldof(<PrivateImplementationDetails>.13609487BF326F585BE04A8B117F695C17EBF5631C270987F781ADFE707D2D592).FieldHandle);
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06002AA5 RID: 10917 RVA: 0x0008503D File Offset: 0x0008323D
		private static ReadOnlySpan<int> UiFamilyCodePages
		{
			get
			{
				return RuntimeHelpers.CreateSpan<int>(fieldof(<PrivateImplementationDetails>.EBA5A6C61DF8CF35895906D12660044546F04B595234F96E032C96FD5304834E4).FieldHandle);
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06002AA6 RID: 10918 RVA: 0x00085049 File Offset: 0x00083249
		private static ReadOnlySpan<int> WebNameIndices
		{
			get
			{
				return RuntimeHelpers.CreateSpan<int>(fieldof(<PrivateImplementationDetails>.E6EEA459FF94C0CD0B9F08949CD34858F87A278DBD2C862ED1A488E25D906E3C4).FieldHandle);
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06002AA7 RID: 10919 RVA: 0x00085055 File Offset: 0x00083255
		private static ReadOnlySpan<uint> Flags
		{
			get
			{
				return RuntimeHelpers.CreateSpan<uint>(fieldof(<PrivateImplementationDetails>.6F1E66789CFDC4B47F399E6AEEC35360E4F0ACEF3FEAFB7BF4F1FF4A413C2B504).FieldHandle);
			}
		}

		// Token: 0x06002AA8 RID: 10920 RVA: 0x00085064 File Offset: 0x00083264
		internal static int GetCodePageFromName(string name)
		{
			ArgumentNullException.ThrowIfNull(name, "name");
			object obj = EncodingTable.s_nameToCodePage[name];
			if (obj != null)
			{
				return (int)obj;
			}
			int num = EncodingTable.InternalGetCodePageFromName(name);
			EncodingTable.s_nameToCodePage[name] = num;
			return num;
		}

		// Token: 0x06002AA9 RID: 10921 RVA: 0x000850AC File Offset: 0x000832AC
		private unsafe static int InternalGetCodePageFromName(string name)
		{
			int i = 0;
			int num = EncodingTable.EncodingNameIndices.Length - 2;
			ReadOnlySpan<char> readOnlySpan = name.ToLowerInvariant().AsSpan();
			while (num - i > 3)
			{
				int num2 = (num - i) / 2 + i;
				int num3 = string.CompareOrdinal(readOnlySpan, "ansi_x3.4-1968ansi_x3.4-1986asciicp367cp819csasciicsisolatin1csunicode11utf7ibm367ibm819iso-10646-ucs-2iso-8859-1iso-ir-100iso-ir-6iso646-usiso8859-1iso_646.irv:1991iso_8859-1iso_8859-1:1987l1latin1ucs-2unicodeunicode-1-1-utf-7unicode-1-1-utf-8unicode-2-0-utf-7unicode-2-0-utf-8unicodefffeusus-asciiutf-16utf-16beutf-16leutf-32utf-32beutf-32leutf-7utf-8x-unicode-1-1-utf-7x-unicode-1-1-utf-8x-unicode-2-0-utf-7x-unicode-2-0-utf-8".AsSpan(*EncodingTable.EncodingNameIndices[num2], *EncodingTable.EncodingNameIndices[num2 + 1] - *EncodingTable.EncodingNameIndices[num2]));
				if (num3 == 0)
				{
					return (int)(*EncodingTable.CodePagesByName[num2]);
				}
				if (num3 < 0)
				{
					num = num2;
				}
				else
				{
					i = num2;
				}
			}
			while (i <= num)
			{
				if (readOnlySpan.SequenceEqual("ansi_x3.4-1968ansi_x3.4-1986asciicp367cp819csasciicsisolatin1csunicode11utf7ibm367ibm819iso-10646-ucs-2iso-8859-1iso-ir-100iso-ir-6iso646-usiso8859-1iso_646.irv:1991iso_8859-1iso_8859-1:1987l1latin1ucs-2unicodeunicode-1-1-utf-7unicode-1-1-utf-8unicode-2-0-utf-7unicode-2-0-utf-8unicodefffeusus-asciiutf-16utf-16beutf-16leutf-32utf-32beutf-32leutf-7utf-8x-unicode-1-1-utf-7x-unicode-1-1-utf-8x-unicode-2-0-utf-7x-unicode-2-0-utf-8".AsSpan(*EncodingTable.EncodingNameIndices[i], *EncodingTable.EncodingNameIndices[i + 1] - *EncodingTable.EncodingNameIndices[i])))
				{
					return (int)(*EncodingTable.CodePagesByName[i]);
				}
				i++;
			}
			throw new ArgumentException(SR.Format(SR.Argument_EncodingNotSupported, name), "name");
		}

		// Token: 0x06002AAA RID: 10922 RVA: 0x000851C4 File Offset: 0x000833C4
		internal unsafe static EncodingInfo[] GetEncodings()
		{
			ReadOnlySpan<ushort> mappedCodePages = EncodingTable.MappedCodePages;
			EncodingInfo[] array = new EncodingInfo[LocalAppContextSwitches.EnableUnsafeUTF7Encoding ? mappedCodePages.Length : (mappedCodePages.Length - 1)];
			string text = "utf-16utf-16BEutf-32utf-32BEus-asciiiso-8859-1utf-7utf-8";
			ReadOnlySpan<int> webNameIndices = EncodingTable.WebNameIndices;
			int num = 0;
			for (int i = 0; i < mappedCodePages.Length; i++)
			{
				int num2 = (int)(*mappedCodePages[i]);
				if (num2 != 65000 || LocalAppContextSwitches.EnableUnsafeUTF7Encoding)
				{
					EncodingInfo[] array2 = array;
					int num3 = num++;
					int codePage = num2;
					string text2 = text;
					int num4 = *webNameIndices[i];
					array2[num3] = new EncodingInfo(codePage, text2.Substring(num4, *webNameIndices[i + 1] - num4), EncodingTable.GetDisplayName(num2));
				}
			}
			return array;
		}

		// Token: 0x06002AAB RID: 10923 RVA: 0x00085274 File Offset: 0x00083474
		internal unsafe static EncodingInfo[] GetEncodings(Dictionary<int, EncodingInfo> encodingInfoList)
		{
			ReadOnlySpan<ushort> mappedCodePages = EncodingTable.MappedCodePages;
			string text = "utf-16utf-16BEutf-32utf-32BEus-asciiiso-8859-1utf-7utf-8";
			ReadOnlySpan<int> webNameIndices = EncodingTable.WebNameIndices;
			for (int i = 0; i < mappedCodePages.Length; i++)
			{
				int num = (int)(*mappedCodePages[i]);
				if (!encodingInfoList.ContainsKey(num) && (num != 65000 || LocalAppContextSwitches.EnableUnsafeUTF7Encoding))
				{
					int key = num;
					int codePage = num;
					string text2 = text;
					int num2 = *webNameIndices[i];
					encodingInfoList[key] = new EncodingInfo(codePage, text2.Substring(num2, *webNameIndices[i + 1] - num2), EncodingTable.GetDisplayName(num));
				}
			}
			if (!LocalAppContextSwitches.EnableUnsafeUTF7Encoding)
			{
				encodingInfoList.Remove(65000);
			}
			EncodingInfo[] array = new EncodingInfo[encodingInfoList.Count];
			int num3 = 0;
			foreach (KeyValuePair<int, EncodingInfo> keyValuePair in encodingInfoList)
			{
				array[num3++] = keyValuePair.Value;
			}
			return array;
		}

		// Token: 0x06002AAC RID: 10924 RVA: 0x00085378 File Offset: 0x00083578
		internal static CodePageDataItem GetCodePageDataItem(int codePage)
		{
			if (EncodingTable.s_codePageToCodePageData == null)
			{
				Interlocked.CompareExchange<CodePageDataItem[]>(ref EncodingTable.s_codePageToCodePageData, new CodePageDataItem[EncodingTable.MappedCodePages.Length], null);
			}
			int num;
			if (codePage <= 12001)
			{
				if (codePage <= 1201)
				{
					if (codePage == 1200)
					{
						num = 0;
						goto IL_A7;
					}
					if (codePage == 1201)
					{
						num = 1;
						goto IL_A7;
					}
				}
				else
				{
					if (codePage == 12000)
					{
						num = 2;
						goto IL_A7;
					}
					if (codePage == 12001)
					{
						num = 3;
						goto IL_A7;
					}
				}
			}
			else if (codePage <= 28591)
			{
				if (codePage == 20127)
				{
					num = 4;
					goto IL_A7;
				}
				if (codePage == 28591)
				{
					num = 5;
					goto IL_A7;
				}
			}
			else
			{
				if (codePage == 65000)
				{
					num = 6;
					goto IL_A7;
				}
				if (codePage == 65001)
				{
					num = 7;
					goto IL_A7;
				}
			}
			return null;
			IL_A7:
			CodePageDataItem codePageDataItem = EncodingTable.s_codePageToCodePageData[num];
			if (codePageDataItem == null)
			{
				Interlocked.CompareExchange<CodePageDataItem>(ref EncodingTable.s_codePageToCodePageData[num], EncodingTable.InternalGetCodePageDataItem(codePage, num), null);
				codePageDataItem = EncodingTable.s_codePageToCodePageData[num];
			}
			return codePageDataItem;
		}

		// Token: 0x06002AAD RID: 10925 RVA: 0x0008545C File Offset: 0x0008365C
		private unsafe static CodePageDataItem InternalGetCodePageDataItem(int codePage, int index)
		{
			int uiFamilyCodePage = *EncodingTable.UiFamilyCodePages[index];
			string text = "utf-16utf-16BEutf-32utf-32BEus-asciiiso-8859-1utf-7utf-8";
			int num = *EncodingTable.WebNameIndices[index];
			string text2 = text.Substring(num, *EncodingTable.WebNameIndices[index + 1] - num);
			string headerName = text2;
			string bodyName = text2;
			string displayName = EncodingTable.GetDisplayName(codePage);
			uint flags = *EncodingTable.Flags[index];
			return new CodePageDataItem(uiFamilyCodePage, text2, headerName, bodyName, displayName, flags);
		}

		// Token: 0x06002AAE RID: 10926 RVA: 0x000854D8 File Offset: 0x000836D8
		private static string GetDisplayName(int codePage)
		{
			if (codePage <= 12001)
			{
				if (codePage <= 1201)
				{
					if (codePage == 1200)
					{
						return SR.Globalization_cp_1200;
					}
					if (codePage == 1201)
					{
						return SR.Globalization_cp_1201;
					}
				}
				else
				{
					if (codePage == 12000)
					{
						return SR.Globalization_cp_12000;
					}
					if (codePage == 12001)
					{
						return SR.Globalization_cp_12001;
					}
				}
			}
			else if (codePage <= 28591)
			{
				if (codePage == 20127)
				{
					return SR.Globalization_cp_20127;
				}
				if (codePage == 28591)
				{
					return SR.Globalization_cp_28591;
				}
			}
			else
			{
				if (codePage == 65000)
				{
					return SR.Globalization_cp_65000;
				}
				if (codePage == 65001)
				{
					return SR.Globalization_cp_65001;
				}
			}
			return "";
		}

		// Token: 0x04000784 RID: 1924
		private static readonly Hashtable s_nameToCodePage = Hashtable.Synchronized(new Hashtable(StringComparer.OrdinalIgnoreCase));

		// Token: 0x04000785 RID: 1925
		private static CodePageDataItem[] s_codePageToCodePageData;
	}
}
