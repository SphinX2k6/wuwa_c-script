using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EB8 RID: 20152
	public class ICheckEntitiesExistT
	{
		// Token: 0x17008FC3 RID: 36803
		// (get) Token: 0x0601F3E9 RID: 127977 RVA: 0x0045AE15 File Offset: 0x00459015
		// (set) Token: 0x0601F3EA RID: 127978 RVA: 0x0045AE1D File Offset: 0x0045901D
		public ECondition Type { get; set; }

		// Token: 0x17008FC4 RID: 36804
		// (get) Token: 0x0601F3EB RID: 127979 RVA: 0x0045AE26 File Offset: 0x00459026
		// (set) Token: 0x0601F3EC RID: 127980 RVA: 0x0045AE2E File Offset: 0x0045902E
		public List<int> EntityIds { get; set; }

		// Token: 0x17008FC5 RID: 36805
		// (get) Token: 0x0601F3ED RID: 127981 RVA: 0x0045AE37 File Offset: 0x00459037
		// (set) Token: 0x0601F3EE RID: 127982 RVA: 0x0045AE3F File Offset: 0x0045903F
		public bool IsExist { get; set; }

		// Token: 0x17008FC6 RID: 36806
		// (get) Token: 0x0601F3EF RID: 127983 RVA: 0x0045AE48 File Offset: 0x00459048
		// (set) Token: 0x0601F3F0 RID: 127984 RVA: 0x0045AE50 File Offset: 0x00459050
		public bool IsFinishLoading { get; set; }

		// Token: 0x17008FC7 RID: 36807
		// (get) Token: 0x0601F3F1 RID: 127985 RVA: 0x0045AE59 File Offset: 0x00459059
		// (set) Token: 0x0601F3F2 RID: 127986 RVA: 0x0045AE61 File Offset: 0x00459061
		public byte NullMask { get; set; }

		// Token: 0x0601F3F3 RID: 127987 RVA: 0x0045AE6A File Offset: 0x0045906A
		public ICheckEntitiesExistT()
		{
			this.Type = ECondition.CompareVar;
			this.EntityIds = null;
			this.IsExist = false;
			this.IsFinishLoading = false;
			this.NullMask = 0;
		}
	}
}
