using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200644C RID: 25676
	public class ICollectT
	{
		// Token: 0x1700BF25 RID: 48933
		// (get) Token: 0x0602C704 RID: 182020 RVA: 0x0061883C File Offset: 0x00616A3C
		// (set) Token: 0x0602C705 RID: 182021 RVA: 0x00618844 File Offset: 0x00616A44
		public int TargetEntity { get; set; }

		// Token: 0x1700BF26 RID: 48934
		// (get) Token: 0x0602C706 RID: 182022 RVA: 0x0061884D File Offset: 0x00616A4D
		// (set) Token: 0x0602C707 RID: 182023 RVA: 0x00618855 File Offset: 0x00616A55
		public byte NullMask { get; set; }

		// Token: 0x0602C708 RID: 182024 RVA: 0x0061885E File Offset: 0x00616A5E
		public ICollectT()
		{
			this.TargetEntity = 0;
			this.NullMask = 0;
		}
	}
}
