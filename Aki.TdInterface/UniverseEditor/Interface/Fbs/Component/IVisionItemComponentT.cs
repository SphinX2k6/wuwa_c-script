using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B45 RID: 23365
	public class IVisionItemComponentT
	{
		// Token: 0x1700B061 RID: 45153
		// (get) Token: 0x06027F1C RID: 163612 RVA: 0x0057DEA0 File Offset: 0x0057C0A0
		// (set) Token: 0x06027F1D RID: 163613 RVA: 0x0057DEA8 File Offset: 0x0057C0A8
		public bool Disabled { get; set; }

		// Token: 0x1700B062 RID: 45154
		// (get) Token: 0x06027F1E RID: 163614 RVA: 0x0057DEB1 File Offset: 0x0057C0B1
		// (set) Token: 0x06027F1F RID: 163615 RVA: 0x0057DEB9 File Offset: 0x0057C0B9
		public byte NullMask { get; set; }

		// Token: 0x06027F20 RID: 163616 RVA: 0x0057DEC2 File Offset: 0x0057C0C2
		public IVisionItemComponentT()
		{
			this.Disabled = false;
			this.NullMask = 0;
		}
	}
}
