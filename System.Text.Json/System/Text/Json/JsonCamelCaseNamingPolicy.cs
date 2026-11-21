using System;

namespace System.Text.Json
{
	// Token: 0x0200000D RID: 13
	internal sealed class JsonCamelCaseNamingPolicy : JsonNamingPolicy
	{
		// Token: 0x060001C1 RID: 449 RVA: 0x0000517C File Offset: 0x0000337C
		public override string ConvertName(string name)
		{
			if (string.IsNullOrEmpty(name2) || !char.IsUpper(name2[0]))
			{
				return name2;
			}
			return string.Create<string>(name2.Length, name2, delegate(Span<char> chars, string name)
			{
				name.CopyTo(chars);
				JsonCamelCaseNamingPolicy.FixCasing(chars);
			});
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x000051CC File Offset: 0x000033CC
		private unsafe static void FixCasing(Span<char> chars)
		{
			int num = 0;
			while (num < chars.Length && (num != 1 || char.IsUpper(*chars[num])))
			{
				bool flag = num + 1 < chars.Length;
				if (num > 0 && flag && !char.IsUpper(*chars[num + 1]))
				{
					if (*chars[num + 1] == ' ')
					{
						*chars[num] = char.ToLowerInvariant(*chars[num]);
						return;
					}
					break;
				}
				else
				{
					*chars[num] = char.ToLowerInvariant(*chars[num]);
					num++;
				}
			}
		}
	}
}
