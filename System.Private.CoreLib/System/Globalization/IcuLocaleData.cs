using System;
using System.Runtime.CompilerServices;

namespace System.Globalization
{
	// Token: 0x020002FA RID: 762
	internal static class IcuLocaleData
	{
		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x0600376F RID: 14191 RVA: 0x000B5EE0 File Offset: 0x000B40E0
		private unsafe static ReadOnlySpan<byte> CultureNames
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.DC23228F0B3106524845148F546F99D1CA867B3CB043B96731BBC3C46DF4368B), 3388);
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06003770 RID: 14192 RVA: 0x000B5EF1 File Offset: 0x000B40F1
		private unsafe static ReadOnlySpan<byte> LocalesNamesIndexes
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.F7F034FC00313E03A8B464F5FE1942A0B2B7BB8351261C33F57B9BF578019079), 1728);
			}
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06003771 RID: 14193 RVA: 0x000B5F02 File Offset: 0x000B4102
		private unsafe static ReadOnlySpan<byte> ThreeLetterWindowsLanguageName
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.34BD8788EDDCC8C1E949E4A15BBC2B499FBEE6D9FF10DD82EB3042F1D964740B), 2592);
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06003772 RID: 14194 RVA: 0x000B5F13 File Offset: 0x000B4113
		private unsafe static ReadOnlySpan<byte> NameIndexToNumericData
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.3A2A62DD9288C777284B5B71FB3EFB59CFDF6BF81068A16795E6155DB8BFA701), 15552);
			}
		}

		// Token: 0x06003773 RID: 14195 RVA: 0x000B5F24 File Offset: 0x000B4124
		internal unsafe static int GetLocaleDataNumericPart(string cultureName, IcuLocaleDataParts part)
		{
			int num = IcuLocaleData.SearchCultureName(cultureName);
			if (num < 0)
			{
				return -1;
			}
			ReadOnlySpan<byte> readOnlySpan = IcuLocaleData.NameIndexToNumericData.Slice(num * 18, 18);
			int result;
			switch (part)
			{
			case IcuLocaleDataParts.Lcid:
				result = ((int)(*readOnlySpan[2]) | (int)(*readOnlySpan[1]) << 8 | (int)(*readOnlySpan[0]) << 16);
				break;
			case IcuLocaleDataParts.AnsiCodePage:
				result = ((*readOnlySpan[4] & 240) >> 4 | (int)(*readOnlySpan[3] & byte.MaxValue) << 4);
				break;
			case IcuLocaleDataParts.OemCodePage:
				result = ((int)(*readOnlySpan[5]) | (int)(*readOnlySpan[4] & 15) << 8);
				break;
			case IcuLocaleDataParts.MacCodePage:
				result = ((int)(*readOnlySpan[7]) | (int)(*readOnlySpan[6]) << 8);
				break;
			case IcuLocaleDataParts.EbcdicCodePage:
				result = ((int)(*readOnlySpan[9]) | (int)(*readOnlySpan[8]) << 8);
				break;
			case IcuLocaleDataParts.GeoId:
				result = ((int)(*readOnlySpan[13]) | (int)(*readOnlySpan[12]) << 8 | (int)(*readOnlySpan[11]) << 16 | (int)(*readOnlySpan[10]) << 24);
				break;
			case IcuLocaleDataParts.DigitSubstitutionOrListSeparator:
				result = IcuLocaleData.<GetLocaleDataNumericPart>g__ResolveDigitListSeparator|24_1((int)(*readOnlySpan[14]));
				break;
			case IcuLocaleDataParts.SpecificLocaleIndex:
				result = IcuLocaleData.<GetLocaleDataNumericPart>g__ResolveIndex|24_0((*readOnlySpan[16] & 240) >> 4 | (int)(*readOnlySpan[15] & byte.MaxValue) << 4);
				break;
			case IcuLocaleDataParts.ConsoleLocaleIndex:
				result = IcuLocaleData.<GetLocaleDataNumericPart>g__ResolveIndex|24_0((int)(*readOnlySpan[17]) | (int)(*readOnlySpan[16] & 15) << 8);
				break;
			default:
				result = -1;
				break;
			}
			return result;
		}

		// Token: 0x06003774 RID: 14196 RVA: 0x000B60C4 File Offset: 0x000B42C4
		internal static string GetThreeLetterWindowsLanguageName(string cultureName)
		{
			int num = IcuLocaleData.SearchCultureName(cultureName);
			if (num < 0)
			{
				return null;
			}
			return IcuLocaleData.GetString(IcuLocaleData.ThreeLetterWindowsLanguageName.Slice(num * 3, 3));
		}

		// Token: 0x06003775 RID: 14197 RVA: 0x000B60F4 File Offset: 0x000B42F4
		private static string GetLocaleDataMappedCulture(string cultureName, IcuLocaleDataParts part)
		{
			int localeDataNumericPart = IcuLocaleData.GetLocaleDataNumericPart(cultureName, part);
			if (localeDataNumericPart < 0)
			{
				return "";
			}
			return IcuLocaleData.GetString(IcuLocaleData.GetCultureName(localeDataNumericPart));
		}

		// Token: 0x06003776 RID: 14198 RVA: 0x000B611E File Offset: 0x000B431E
		internal static string GetSpecificCultureName(string cultureName)
		{
			return IcuLocaleData.GetLocaleDataMappedCulture(cultureName, IcuLocaleDataParts.SpecificLocaleIndex);
		}

		// Token: 0x06003777 RID: 14199 RVA: 0x000B6127 File Offset: 0x000B4327
		internal static string GetConsoleUICulture(string cultureName)
		{
			return IcuLocaleData.GetLocaleDataMappedCulture(cultureName, IcuLocaleDataParts.ConsoleLocaleIndex);
		}

		// Token: 0x06003778 RID: 14200 RVA: 0x000B6130 File Offset: 0x000B4330
		private unsafe static int SearchCultureName(string name)
		{
			if (name.Length > 14)
			{
				return -1;
			}
			int length = name.Length;
			Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)length], length);
			for (int i = 0; i < name.Length; i++)
			{
				char c = name[i];
				*span[i] = (char.IsAsciiLetterUpper(c) ? ((byte)(c | ' ')) : ((byte)c));
			}
			ReadOnlySpan<byte> other = span;
			int j = 0;
			int num = 863;
			while (j <= num)
			{
				int num2 = j + (num - j >> 1);
				int num3 = IcuLocaleData.GetCultureName(num2).SequenceCompareTo(other);
				if (num3 == 0)
				{
					return num2;
				}
				if (num3 < 0)
				{
					j = num2 + 1;
				}
				else
				{
					num = num2 - 1;
				}
			}
			return ~j;
		}

		// Token: 0x06003779 RID: 14201 RVA: 0x000B61E4 File Offset: 0x000B43E4
		private unsafe static ReadOnlySpan<byte> GetCultureName(int localeNameIndice)
		{
			ReadOnlySpan<byte> localesNamesIndexes = IcuLocaleData.LocalesNamesIndexes;
			int num = localeNameIndice * 2;
			int num2 = (int)(*localesNamesIndexes[num]);
			int num3 = (int)(*localesNamesIndexes[num + 1]);
			int start = num2 << 4 | num3 >> 4;
			int length = num3 & 15;
			return IcuLocaleData.CultureNames.Slice(start, length);
		}

		// Token: 0x0600377A RID: 14202 RVA: 0x000B6230 File Offset: 0x000B4430
		private unsafe static string GetString(ReadOnlySpan<byte> buffer)
		{
			string text = string.FastAllocateString(buffer.Length);
			Span<char> span = new Span<char>(text.GetRawStringData(), buffer.Length);
			for (int i = 0; i < buffer.Length; i++)
			{
				*span[i] = (char)(*buffer[i]);
			}
			return text;
		}

		// Token: 0x0600377B RID: 14203 RVA: 0x000B6282 File Offset: 0x000B4482
		[CompilerGenerated]
		internal static int <GetLocaleDataNumericPart>g__ResolveIndex|24_0(int value)
		{
			if (value != 4095)
			{
				return value;
			}
			return -1;
		}

		// Token: 0x0600377C RID: 14204 RVA: 0x000B628F File Offset: 0x000B448F
		[CompilerGenerated]
		internal static int <GetLocaleDataNumericPart>g__ResolveDigitListSeparator|24_1(int value)
		{
			return (value & 240) << 12 | (value & 15);
		}
	}
}
