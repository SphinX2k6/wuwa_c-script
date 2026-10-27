using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BD8 RID: 19416
	public class ICondition2T
	{
		// Token: 0x17008D12 RID: 36114
		// (get) Token: 0x0601EA93 RID: 125587 RVA: 0x00449B4A File Offset: 0x00447D4A
		// (set) Token: 0x0601EA94 RID: 125588 RVA: 0x00449B52 File Offset: 0x00447D52
		public ECondition Type { get; set; }

		// Token: 0x0601EA95 RID: 125589 RVA: 0x00449B5B File Offset: 0x00447D5B
		public ICondition2T()
		{
			this.Type = ECondition.CompareVar;
		}
	}
}
