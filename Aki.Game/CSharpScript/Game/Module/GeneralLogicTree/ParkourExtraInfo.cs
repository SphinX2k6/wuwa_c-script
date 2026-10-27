using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.GeneralLogicTree
{
	// Token: 0x020059BB RID: 22971
	public class ParkourExtraInfo : GeneralLogicTreeNodeExtraInfo
	{
		// Token: 0x0603A3C7 RID: 238535 RVA: 0x00DD7306 File Offset: 0x00DD5506
		public ParkourExtraInfo()
		{
			this.Type = EExtraInfoType.Parkour;
		}

		// Token: 0x0401E603 RID: 124419
		[Nullable(2)]
		public Dictionary<int, int> TotalScore;
	}
}
