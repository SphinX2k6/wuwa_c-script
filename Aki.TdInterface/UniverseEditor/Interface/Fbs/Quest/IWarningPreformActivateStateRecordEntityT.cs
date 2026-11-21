using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046EC RID: 18156
	public class IWarningPreformActivateStateRecordEntityT
	{
		// Token: 0x17007F34 RID: 32564
		// (get) Token: 0x0601AB69 RID: 109417 RVA: 0x003CC053 File Offset: 0x003CA253
		// (set) Token: 0x0601AB6A RID: 109418 RVA: 0x003CC05B File Offset: 0x003CA25B
		public EWarningPreformType Type { get; set; }

		// Token: 0x17007F35 RID: 32565
		// (get) Token: 0x0601AB6B RID: 109419 RVA: 0x003CC064 File Offset: 0x003CA264
		// (set) Token: 0x0601AB6C RID: 109420 RVA: 0x003CC06C File Offset: 0x003CA26C
		public List<int> TargetEntityIds { get; set; }

		// Token: 0x0601AB6D RID: 109421 RVA: 0x003CC075 File Offset: 0x003CA275
		public IWarningPreformActivateStateRecordEntityT()
		{
			this.Type = EWarningPreformType.FadeInScreen;
			this.TargetEntityIds = null;
		}
	}
}
