using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate
{
	// Token: 0x020000A7 RID: 167
	[NullableContext(1)]
	[Nullable(0)]
	public class ResourceUpdateUtils
	{
		// Token: 0x060005BD RID: 1469 RVA: 0x00034558 File Offset: 0x00032758
		internal static string FormatLogList<[Nullable(2)] T>([Nullable(new byte[]
		{
			2,
			1
		})] IEnumerable<T> values)
		{
			if (values != null)
			{
				return "[" + string.Join<T>(",", values) + "]";
			}
			return "null";
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00034580 File Offset: 0x00032780
		public static HashSet<int> ParseMp4FinishQuestFlagToSet([Nullable(2)] List<uint> flags)
		{
			HashSet<int> hashSet = new HashSet<int>();
			if (flags == null || flags.Count == 0)
			{
				return hashSet;
			}
			for (int i = 0; i < flags.Count; i++)
			{
				uint num = flags[i];
				if (num != 0U)
				{
					for (int j = 0; j < 32; j++)
					{
						if ((num >> j & 1U) == 1U)
						{
							int item = i * 32 + j + 1;
							hashSet.Add(item);
						}
					}
				}
			}
			return hashSet;
		}
	}
}
