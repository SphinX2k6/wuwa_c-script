using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x02005324 RID: 21284
	public class MowingRiskInBattleRecordData
	{
		// Token: 0x06034FBC RID: 217020 RVA: 0x00ED1B5D File Offset: 0x00ECFD5D
		public void Clear()
		{
			this.BasicBuffRecord.Clear();
			this.ProgressPanelBasicBuffCountRecord = 0;
		}

		// Token: 0x0401BFF7 RID: 114679
		[Nullable(1)]
		public HashSet<int> BasicBuffRecord = new HashSet<int>();

		// Token: 0x0401BFF8 RID: 114680
		public int ProgressPanelBasicBuffCountRecord;
	}
}
