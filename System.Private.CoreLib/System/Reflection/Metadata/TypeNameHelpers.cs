using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Reflection.Metadata
{
	// Token: 0x02000796 RID: 1942
	internal static class TypeNameHelpers
	{
		// Token: 0x06007BB7 RID: 31671 RVA: 0x00123A30 File Offset: 0x00121C30
		internal static string Unescape(string name)
		{
			int num = name.IndexOf('\\');
			if (num < 0)
			{
				return name;
			}
			return TypeNameHelpers.<Unescape>g__Unescape|1_0(name, num);
		}

		// Token: 0x06007BB8 RID: 31672 RVA: 0x00123A54 File Offset: 0x00121C54
		[CompilerGenerated]
		internal unsafe static string <Unescape>g__Unescape|1_0(string name, int indexOfEscapeCharacter)
		{
			Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)128], 64);
			ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
			valueStringBuilder.EnsureCapacity(name.Length);
			valueStringBuilder.Append(name.AsSpan(0, indexOfEscapeCharacter));
			int i = indexOfEscapeCharacter;
			while (i < name.Length)
			{
				char c = name[i++];
				if (c != '\\')
				{
					valueStringBuilder.Append(c);
				}
				else if (i < name.Length && name[i] == '\\')
				{
					valueStringBuilder.Append(c);
					i++;
				}
			}
			return valueStringBuilder.ToString();
		}
	}
}
