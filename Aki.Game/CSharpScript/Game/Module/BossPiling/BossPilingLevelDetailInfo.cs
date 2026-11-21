using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02004BE8 RID: 19432
	[NullableContext(1)]
	[Nullable(0)]
	public class BossPilingLevelDetailInfo : IBossPilingLevelDetailInfo
	{
		// Token: 0x17006171 RID: 24945
		// (get) Token: 0x060307EB RID: 198635 RVA: 0x00D8256A File Offset: 0x00D8076A
		// (set) Token: 0x060307EC RID: 198636 RVA: 0x00D82572 File Offset: 0x00D80772
		public bool IsFirst { get; set; }

		// Token: 0x17006172 RID: 24946
		// (get) Token: 0x060307ED RID: 198637 RVA: 0x00D8257B File Offset: 0x00D8077B
		// (set) Token: 0x060307EE RID: 198638 RVA: 0x00D82583 File Offset: 0x00D80783
		public List<BossPilingLevelDescInfo> LevelList { get; set; }
	}
}
