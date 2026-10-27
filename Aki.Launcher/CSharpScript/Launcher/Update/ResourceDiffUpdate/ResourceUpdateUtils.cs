using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate
{
	// Token: 0x020000A4 RID: 164
	public class ResourceUpdateUtils
	{
		// Token: 0x060005A6 RID: 1446 RVA: 0x00032EF0 File Offset: 0x000310F0
		[NullableContext(1)]
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
