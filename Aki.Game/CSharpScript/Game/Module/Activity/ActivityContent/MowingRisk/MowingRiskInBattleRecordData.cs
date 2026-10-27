using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063A6 RID: 25510
	public class MowingRiskInBattleRecordData
	{
		// Token: 0x060402FB RID: 262907 RVA: 0x00F8AC25 File Offset: 0x00F88E25
		public void Clear()
		{
			this.BasicBuffRecord.Clear();
			this.ProgressPanelBasicBuffCountRecord = 0;
		}

		// Token: 0x040216C8 RID: 136904
		[Nullable(1)]
		public HashSet<int> BasicBuffRecord = new HashSet<int>();

		// Token: 0x040216C9 RID: 136905
		public int ProgressPanelBasicBuffCountRecord;
	}
}
