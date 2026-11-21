using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200719F RID: 29087
	public class IMechBehaviorConfigT
	{
		// Token: 0x1700D506 RID: 54534
		// (get) Token: 0x06032961 RID: 207201 RVA: 0x006D5F97 File Offset: 0x006D4197
		// (set) Token: 0x06032962 RID: 207202 RVA: 0x006D5F9F File Offset: 0x006D419F
		public TMechStuntConfigUnion StuntConfig { get; set; }

		// Token: 0x1700D507 RID: 54535
		// (get) Token: 0x06032963 RID: 207203 RVA: 0x006D5FA8 File Offset: 0x006D41A8
		// (set) Token: 0x06032964 RID: 207204 RVA: 0x006D5FB0 File Offset: 0x006D41B0
		public IVectorInfoT TargetPos { get; set; }

		// Token: 0x1700D508 RID: 54536
		// (get) Token: 0x06032965 RID: 207205 RVA: 0x006D5FB9 File Offset: 0x006D41B9
		// (set) Token: 0x06032966 RID: 207206 RVA: 0x006D5FC1 File Offset: 0x006D41C1
		public bool CanInterrupt { get; set; }

		// Token: 0x1700D509 RID: 54537
		// (get) Token: 0x06032967 RID: 207207 RVA: 0x006D5FCA File Offset: 0x006D41CA
		// (set) Token: 0x06032968 RID: 207208 RVA: 0x006D5FD2 File Offset: 0x006D41D2
		public byte NullMask { get; set; }

		// Token: 0x06032969 RID: 207209 RVA: 0x006D5FDB File Offset: 0x006D41DB
		public IMechBehaviorConfigT()
		{
			this.StuntConfig = null;
			this.TargetPos = null;
			this.CanInterrupt = false;
			this.NullMask = 0;
		}
	}
}
