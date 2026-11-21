using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057A9 RID: 22441
	public class IFightInteractComponentT
	{
		// Token: 0x1700A243 RID: 41539
		// (get) Token: 0x0602439D RID: 148381 RVA: 0x004FAE67 File Offset: 0x004F9067
		// (set) Token: 0x0602439E RID: 148382 RVA: 0x004FAE6F File Offset: 0x004F906F
		public bool Disabled { get; set; }

		// Token: 0x1700A244 RID: 41540
		// (get) Token: 0x0602439F RID: 148383 RVA: 0x004FAE78 File Offset: 0x004F9078
		// (set) Token: 0x060243A0 RID: 148384 RVA: 0x004FAE80 File Offset: 0x004F9080
		public int LockRange { get; set; }

		// Token: 0x1700A245 RID: 41541
		// (get) Token: 0x060243A1 RID: 148385 RVA: 0x004FAE89 File Offset: 0x004F9089
		// (set) Token: 0x060243A2 RID: 148386 RVA: 0x004FAE91 File Offset: 0x004F9091
		public IVectorInfoT LockOffset { get; set; }

		// Token: 0x1700A246 RID: 41542
		// (get) Token: 0x060243A3 RID: 148387 RVA: 0x004FAE9A File Offset: 0x004F909A
		// (set) Token: 0x060243A4 RID: 148388 RVA: 0x004FAEA2 File Offset: 0x004F90A2
		public bool DisableLock { get; set; }

		// Token: 0x1700A247 RID: 41543
		// (get) Token: 0x060243A5 RID: 148389 RVA: 0x004FAEAB File Offset: 0x004F90AB
		// (set) Token: 0x060243A6 RID: 148390 RVA: 0x004FAEB3 File Offset: 0x004F90B3
		public IAutoLockControlT LockControl { get; set; }

		// Token: 0x1700A248 RID: 41544
		// (get) Token: 0x060243A7 RID: 148391 RVA: 0x004FAEBC File Offset: 0x004F90BC
		// (set) Token: 0x060243A8 RID: 148392 RVA: 0x004FAEC4 File Offset: 0x004F90C4
		public byte NullMask { get; set; }

		// Token: 0x060243A9 RID: 148393 RVA: 0x004FAECD File Offset: 0x004F90CD
		public IFightInteractComponentT()
		{
			this.Disabled = false;
			this.LockRange = 0;
			this.LockOffset = null;
			this.DisableLock = false;
			this.LockControl = null;
			this.NullMask = 0;
		}
	}
}
