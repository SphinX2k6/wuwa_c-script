using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02004BE7 RID: 19431
	[NullableContext(1)]
	public interface IBossPilingLevelDetailInfo
	{
		// Token: 0x1700616F RID: 24943
		// (get) Token: 0x060307E7 RID: 198631
		// (set) Token: 0x060307E8 RID: 198632
		bool IsFirst { get; set; }

		// Token: 0x17006170 RID: 24944
		// (get) Token: 0x060307E9 RID: 198633
		// (set) Token: 0x060307EA RID: 198634
		List<BossPilingLevelDescInfo> LevelList { get; set; }
	}
}
