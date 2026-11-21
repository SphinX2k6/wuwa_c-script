using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CBD RID: 27837
	public class IEnableAllPlayerOperationT
	{
		// Token: 0x1700CC34 RID: 52276
		// (get) Token: 0x0602FFAC RID: 196524 RVA: 0x00687AE6 File Offset: 0x00685CE6
		// (set) Token: 0x0602FFAD RID: 196525 RVA: 0x00687AEE File Offset: 0x00685CEE
		public EPlayerOperationType Type { get; set; }

		// Token: 0x1700CC35 RID: 52277
		// (get) Token: 0x0602FFAE RID: 196526 RVA: 0x00687AF7 File Offset: 0x00685CF7
		// (set) Token: 0x0602FFAF RID: 196527 RVA: 0x00687AFF File Offset: 0x00685CFF
		public bool IsUiFadeEffect { get; set; }

		// Token: 0x1700CC36 RID: 52278
		// (get) Token: 0x0602FFB0 RID: 196528 RVA: 0x00687B08 File Offset: 0x00685D08
		// (set) Token: 0x0602FFB1 RID: 196529 RVA: 0x00687B10 File Offset: 0x00685D10
		public byte NullMask { get; set; }

		// Token: 0x0602FFB2 RID: 196530 RVA: 0x00687B19 File Offset: 0x00685D19
		public IEnableAllPlayerOperationT()
		{
			this.Type = EPlayerOperationType.EnableAll;
			this.IsUiFadeEffect = false;
			this.NullMask = 0;
		}
	}
}
