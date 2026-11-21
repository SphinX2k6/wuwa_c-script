using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058DA RID: 22746
	public class IGroupFinishDestroyT
	{
		// Token: 0x1700A4F2 RID: 42226
		// (get) Token: 0x06024F0A RID: 151306 RVA: 0x0051255F File Offset: 0x0051075F
		// (set) Token: 0x06024F0B RID: 151307 RVA: 0x00512567 File Offset: 0x00510767
		public EGroupFinishConfig Type { get; set; }

		// Token: 0x1700A4F3 RID: 42227
		// (get) Token: 0x06024F0C RID: 151308 RVA: 0x00512570 File Offset: 0x00510770
		// (set) Token: 0x06024F0D RID: 151309 RVA: 0x00512578 File Offset: 0x00510778
		public IEntityStateT SwitchSpecifiedStatus { get; set; }

		// Token: 0x06024F0E RID: 151310 RVA: 0x00512581 File Offset: 0x00510781
		public IGroupFinishDestroyT()
		{
			this.Type = EGroupFinishConfig.Silence;
			this.SwitchSpecifiedStatus = null;
		}
	}
}
