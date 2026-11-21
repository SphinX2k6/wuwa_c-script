using System;
using System.Text;

namespace System.Reflection
{
	// Token: 0x0200078F RID: 1935
	internal static class AssemblyNameFormatter
	{
		// Token: 0x06007B8C RID: 31628 RVA: 0x00123148 File Offset: 0x00121348
		public unsafe static string ComputeDisplayName(string name, Version version, string cultureName, byte[] pkt, AssemblyNameFlags flags = AssemblyNameFlags.None, AssemblyContentType contentType = AssemblyContentType.Default, byte[] pk = null)
		{
			Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
			ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
			ref valueStringBuilder.AppendQuoted(name);
			if (version != null)
			{
				ushort num = (ushort)version.Major;
				if (num != 65535)
				{
					valueStringBuilder.Append(", Version=");
					valueStringBuilder.AppendSpanFormattable<ushort>(num, null, null);
					ushort num2 = (ushort)version.Minor;
					if (num2 != 65535)
					{
						valueStringBuilder.Append('.');
						valueStringBuilder.AppendSpanFormattable<ushort>(num2, null, null);
						ushort num3 = (ushort)version.Build;
						if (num3 != 65535)
						{
							valueStringBuilder.Append('.');
							valueStringBuilder.AppendSpanFormattable<ushort>(num3, null, null);
							ushort num4 = (ushort)version.Revision;
							if (num4 != 65535)
							{
								valueStringBuilder.Append('.');
								valueStringBuilder.AppendSpanFormattable<ushort>(num4, null, null);
							}
						}
					}
				}
			}
			if (cultureName != null)
			{
				if (cultureName.Length == 0)
				{
					cultureName = "neutral";
				}
				valueStringBuilder.Append(", Culture=");
				ref valueStringBuilder.AppendQuoted(cultureName);
			}
			byte[] array = pkt ?? pk;
			if (array != null)
			{
				if (pkt != null)
				{
					if (pkt.Length > 8)
					{
						throw new ArgumentException();
					}
					valueStringBuilder.Append(", PublicKeyToken=");
				}
				else
				{
					valueStringBuilder.Append(", PublicKey=");
				}
				if (array.Length == 0)
				{
					valueStringBuilder.Append("null");
				}
				else
				{
					HexConverter.EncodeToUtf16(array, valueStringBuilder.AppendSpan(array.Length * 2), HexConverter.Casing.Lower);
				}
			}
			if ((flags & AssemblyNameFlags.Retargetable) != AssemblyNameFlags.None)
			{
				valueStringBuilder.Append(", Retargetable=Yes");
			}
			if (contentType == AssemblyContentType.WindowsRuntime)
			{
				valueStringBuilder.Append(", ContentType=WindowsRuntime");
			}
			return valueStringBuilder.ToString();
		}

		// Token: 0x06007B8D RID: 31629 RVA: 0x001232DC File Offset: 0x001214DC
		private static void AppendQuoted(this ValueStringBuilder vsb, string s)
		{
			bool flag = false;
			ReadOnlySpan<char> span = s.AsSpan();
			if (s.Length != span.Trim().Length || span.IndexOfAny('"', '\'') >= 0)
			{
				flag = true;
			}
			if (flag)
			{
				vsb.Append('"');
			}
			int i = 0;
			while (i < s.Length)
			{
				char c = s[i];
				if (c <= '\'')
				{
					switch (c)
					{
					case '\t':
						vsb.Append("\\t");
						break;
					case '\n':
						vsb.Append("\\n");
						break;
					case '\v':
					case '\f':
						goto IL_BE;
					case '\r':
						vsb.Append("\\r");
						break;
					default:
						if (c != '"' && c != '\'')
						{
							goto IL_BE;
						}
						goto IL_8D;
					}
				}
				else
				{
					if (c == ',' || c == '=' || c == '\\')
					{
						goto IL_8D;
					}
					goto IL_BE;
				}
				IL_CB:
				i++;
				continue;
				IL_BE:
				vsb.Append(s[i]);
				goto IL_CB;
				IL_8D:
				vsb.Append('\\');
				goto IL_BE;
			}
			if (flag)
			{
				vsb.Append('"');
			}
		}
	}
}
