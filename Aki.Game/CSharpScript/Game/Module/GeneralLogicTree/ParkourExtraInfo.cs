using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.GeneralLogicTree
{
	// Token: 0x02004994 RID: 18836
	public class ParkourExtraInfo : GeneralLogicTreeNodeExtraInfo
	{
		// Token: 0x0602F2EE RID: 193262 RVA: 0x00D267DE File Offset: 0x00D249DE
		public ParkourExtraInfo()
		{
			this.Type = EExtraInfoType.Parkour;
		}

		// Token: 0x040190A2 RID: 102562
		[Nullable(2)]
		public Dictionary<int, int> TotalScore;
	}
}
