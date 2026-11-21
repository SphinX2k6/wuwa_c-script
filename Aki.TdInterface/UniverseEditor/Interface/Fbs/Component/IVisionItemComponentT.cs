using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200615B RID: 24923
	public class IVisionItemComponentT
	{
		// Token: 0x1700B9A9 RID: 47529
		// (get) Token: 0x0602A4E0 RID: 173280 RVA: 0x005C5930 File Offset: 0x005C3B30
		// (set) Token: 0x0602A4E1 RID: 173281 RVA: 0x005C5938 File Offset: 0x005C3B38
		public bool Disabled { get; set; }

		// Token: 0x1700B9AA RID: 47530
		// (get) Token: 0x0602A4E2 RID: 173282 RVA: 0x005C5941 File Offset: 0x005C3B41
		// (set) Token: 0x0602A4E3 RID: 173283 RVA: 0x005C5949 File Offset: 0x005C3B49
		public byte NullMask { get; set; }

		// Token: 0x0602A4E4 RID: 173284 RVA: 0x005C5952 File Offset: 0x005C3B52
		public IVisionItemComponentT()
		{
			this.Disabled = false;
			this.NullMask = 0;
		}
	}
}
