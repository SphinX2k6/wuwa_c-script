using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005029 RID: 20521
	public class ICheckSystemStateConditionT
	{
		// Token: 0x170092D9 RID: 37593
		// (get) Token: 0x060200D1 RID: 131281 RVA: 0x0047275F File Offset: 0x0047095F
		// (set) Token: 0x060200D2 RID: 131282 RVA: 0x00472767 File Offset: 0x00470967
		public ECondition Type { get; set; }

		// Token: 0x170092DA RID: 37594
		// (get) Token: 0x060200D3 RID: 131283 RVA: 0x00472770 File Offset: 0x00470970
		// (set) Token: 0x060200D4 RID: 131284 RVA: 0x00472778 File Offset: 0x00470978
		public TCheckSystemStateUnion Config { get; set; }

		// Token: 0x060200D5 RID: 131285 RVA: 0x00472781 File Offset: 0x00470981
		public ICheckSystemStateConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Config = null;
		}
	}
}
