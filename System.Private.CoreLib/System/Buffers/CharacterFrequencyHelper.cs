using System;
using System.Runtime.CompilerServices;

namespace System.Buffers
{
	// Token: 0x02000381 RID: 897
	internal static class CharacterFrequencyHelper
	{
		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x06003C10 RID: 15376 RVA: 0x000C8434 File Offset: 0x000C6634
		public static ReadOnlySpan<float> AsciiFrequency
		{
			get
			{
				return RuntimeHelpers.CreateSpan<float>(fieldof(<PrivateImplementationDetails>.5D646AEB081BEE0F259E3A845D42AB0EE6FF2990921FF45A2321EEF650F547594).FieldHandle);
			}
		}

		// Token: 0x06003C11 RID: 15377 RVA: 0x000C8440 File Offset: 0x000C6640
		public static void GetSingleStringMultiCharacterOffsets(string value, bool ignoreCase, out int ch2Offset, out int ch3Offset)
		{
			ch2Offset = CharacterFrequencyHelper.IndexOfAsciiCharWithLowestFrequency(value, ignoreCase, -1);
			ch3Offset = 0;
			if (ch2Offset < 0)
			{
				ch2Offset = value.Length - 1;
			}
			if (value.Length > 2)
			{
				ch3Offset = CharacterFrequencyHelper.IndexOfAsciiCharWithLowestFrequency(value, ignoreCase, ch2Offset);
				if (ch3Offset < 0)
				{
					if (ignoreCase)
					{
						ch3Offset = 0;
					}
					else
					{
						ch3Offset = value.Length - 1;
						if (ch2Offset == ch3Offset)
						{
							ch2Offset--;
						}
					}
				}
			}
			if (ch3Offset > 0 && ch3Offset < ch2Offset)
			{
				int num = ch3Offset;
				int num2 = ch2Offset;
				ch2Offset = num;
				ch3Offset = num2;
			}
		}

		// Token: 0x06003C12 RID: 15378 RVA: 0x000C84C4 File Offset: 0x000C66C4
		private unsafe static int IndexOfAsciiCharWithLowestFrequency(ReadOnlySpan<char> span, bool ignoreCase, int excludeIndex = -1)
		{
			float num = float.MaxValue;
			int result = -1;
			for (int i = 1; i < span.Length; i++)
			{
				if (i != excludeIndex)
				{
					char c = (char)(*span[i]);
					if (char.IsAscii(c))
					{
						float num2 = *CharacterFrequencyHelper.AsciiFrequency[(int)c];
						if (ignoreCase)
						{
							num2 += *CharacterFrequencyHelper.AsciiFrequency[(int)(c ^ ' ')];
						}
						if (i <= 2)
						{
							num2 *= 1.5f;
						}
						if (num2 <= num)
						{
							num = num2;
							result = i;
						}
					}
				}
			}
			return result;
		}
	}
}
