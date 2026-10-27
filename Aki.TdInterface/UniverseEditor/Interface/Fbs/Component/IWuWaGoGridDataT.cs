using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BAE RID: 23470
	public class IWuWaGoGridDataT
	{
		// Token: 0x1700B159 RID: 45401
		// (get) Token: 0x0602831D RID: 164637 RVA: 0x00586132 File Offset: 0x00584332
		// (set) Token: 0x0602831E RID: 164638 RVA: 0x0058613A File Offset: 0x0058433A
		public EGridShape GridShape { get; set; }

		// Token: 0x1700B15A RID: 45402
		// (get) Token: 0x0602831F RID: 164639 RVA: 0x00586143 File Offset: 0x00584343
		// (set) Token: 0x06028320 RID: 164640 RVA: 0x0058614B File Offset: 0x0058434B
		public IVectorInfoT Position { get; set; }

		// Token: 0x1700B15B RID: 45403
		// (get) Token: 0x06028321 RID: 164641 RVA: 0x00586154 File Offset: 0x00584354
		// (set) Token: 0x06028322 RID: 164642 RVA: 0x0058615C File Offset: 0x0058435C
		public IVectorInfoT Rotation { get; set; }

		// Token: 0x1700B15C RID: 45404
		// (get) Token: 0x06028323 RID: 164643 RVA: 0x00586165 File Offset: 0x00584365
		// (set) Token: 0x06028324 RID: 164644 RVA: 0x0058616D File Offset: 0x0058436D
		public IWuWaGoGridLinkDataT GridLinkData { get; set; }

		// Token: 0x1700B15D RID: 45405
		// (get) Token: 0x06028325 RID: 164645 RVA: 0x00586176 File Offset: 0x00584376
		// (set) Token: 0x06028326 RID: 164646 RVA: 0x0058617E File Offset: 0x0058437E
		public IVectorInfoT AttachedGridCenter { get; set; }

		// Token: 0x06028327 RID: 164647 RVA: 0x00586187 File Offset: 0x00584387
		public IWuWaGoGridDataT()
		{
			this.GridShape = EGridShape.Vertical;
			this.Position = null;
			this.Rotation = null;
			this.GridLinkData = new IWuWaGoGridLinkDataT();
			this.AttachedGridCenter = null;
		}
	}
}
