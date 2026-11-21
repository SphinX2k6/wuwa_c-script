using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EE5 RID: 20197
	public class ICheckFinishLoadingT
	{
		// Token: 0x17009036 RID: 36918
		// (get) Token: 0x0601F5AE RID: 128430 RVA: 0x0045E66F File Offset: 0x0045C86F
		// (set) Token: 0x0601F5AF RID: 128431 RVA: 0x0045E677 File Offset: 0x0045C877
		public ECondition Type { get; set; }

		// Token: 0x17009037 RID: 36919
		// (get) Token: 0x0601F5B0 RID: 128432 RVA: 0x0045E680 File Offset: 0x0045C880
		// (set) Token: 0x0601F5B1 RID: 128433 RVA: 0x0045E688 File Offset: 0x0045C888
		public IAllPlayerTypeT CheckTarget { get; set; }

		// Token: 0x0601F5B2 RID: 128434 RVA: 0x0045E691 File Offset: 0x0045C891
		public ICheckFinishLoadingT()
		{
			this.Type = ECondition.CompareVar;
			this.CheckTarget = null;
		}
	}
}
