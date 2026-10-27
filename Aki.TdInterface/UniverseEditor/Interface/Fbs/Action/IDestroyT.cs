using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200657D RID: 25981
	public class IDestroyT
	{
		// Token: 0x1700C104 RID: 49412
		// (get) Token: 0x0602D124 RID: 184612 RVA: 0x0062F084 File Offset: 0x0062D284
		// (set) Token: 0x0602D125 RID: 184613 RVA: 0x0062F08C File Offset: 0x0062D28C
		public bool DelayDestroy { get; set; }

		// Token: 0x1700C105 RID: 49413
		// (get) Token: 0x0602D126 RID: 184614 RVA: 0x0062F095 File Offset: 0x0062D295
		// (set) Token: 0x0602D127 RID: 184615 RVA: 0x0062F09D File Offset: 0x0062D29D
		public byte NullMask { get; set; }

		// Token: 0x0602D128 RID: 184616 RVA: 0x0062F0A6 File Offset: 0x0062D2A6
		public IDestroyT()
		{
			this.DelayDestroy = false;
			this.NullMask = 0;
		}
	}
}
