using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A93 RID: 23187
	public class ILockConfigT
	{
		// Token: 0x1700A8FE RID: 43262
		// (get) Token: 0x06026027 RID: 155687 RVA: 0x00535BBE File Offset: 0x00533DBE
		// (set) Token: 0x06026028 RID: 155688 RVA: 0x00535BC6 File Offset: 0x00533DC6
		public bool IsInitLock { get; set; }

		// Token: 0x1700A8FF RID: 43263
		// (get) Token: 0x06026029 RID: 155689 RVA: 0x00535BCF File Offset: 0x00533DCF
		// (set) Token: 0x0602602A RID: 155690 RVA: 0x00535BD7 File Offset: 0x00533DD7
		public ELockType LockType { get; set; }

		// Token: 0x1700A900 RID: 43264
		// (get) Token: 0x0602602B RID: 155691 RVA: 0x00535BE0 File Offset: 0x00533DE0
		// (set) Token: 0x0602602C RID: 155692 RVA: 0x00535BE8 File Offset: 0x00533DE8
		public byte NullMask { get; set; }

		// Token: 0x0602602D RID: 155693 RVA: 0x00535BF1 File Offset: 0x00533DF1
		public ILockConfigT()
		{
			this.IsInitLock = false;
			this.LockType = ELockType.Default;
			this.NullMask = 0;
		}
	}
}
