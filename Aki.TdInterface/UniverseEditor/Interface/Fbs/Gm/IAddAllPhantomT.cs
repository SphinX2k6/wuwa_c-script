using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004631 RID: 17969
	public class IAddAllPhantomT
	{
		// Token: 0x17007F86 RID: 32646
		// (get) Token: 0x0601B371 RID: 111473 RVA: 0x003DFEB2 File Offset: 0x003DE0B2
		// (set) Token: 0x0601B372 RID: 111474 RVA: 0x003DFEBA File Offset: 0x003DE0BA
		public EGmCommand Type { get; set; }

		// Token: 0x0601B373 RID: 111475 RVA: 0x003DFEC3 File Offset: 0x003DE0C3
		public IAddAllPhantomT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
