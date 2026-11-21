using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B94 RID: 27540
	public class IDaemonHackT
	{
		// Token: 0x1700CA22 RID: 51746
		// (get) Token: 0x0602F67B RID: 194171 RVA: 0x00677DB3 File Offset: 0x00675FB3
		// (set) Token: 0x0602F67C RID: 194172 RVA: 0x00677DBB File Offset: 0x00675FBB
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700CA23 RID: 51747
		// (get) Token: 0x0602F67D RID: 194173 RVA: 0x00677DC4 File Offset: 0x00675FC4
		// (set) Token: 0x0602F67E RID: 194174 RVA: 0x00677DCC File Offset: 0x00675FCC
		public List<int> Ids { get; set; }

		// Token: 0x1700CA24 RID: 51748
		// (get) Token: 0x0602F67F RID: 194175 RVA: 0x00677DD5 File Offset: 0x00675FD5
		// (set) Token: 0x0602F680 RID: 194176 RVA: 0x00677DDD File Offset: 0x00675FDD
		public bool FinishOnClose { get; set; }

		// Token: 0x1700CA25 RID: 51749
		// (get) Token: 0x0602F681 RID: 194177 RVA: 0x00677DE6 File Offset: 0x00675FE6
		// (set) Token: 0x0602F682 RID: 194178 RVA: 0x00677DEE File Offset: 0x00675FEE
		public byte NullMask { get; set; }

		// Token: 0x0602F683 RID: 194179 RVA: 0x00677DF7 File Offset: 0x00675FF7
		public IDaemonHackT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.Ids = null;
			this.FinishOnClose = false;
			this.NullMask = 0;
		}
	}
}
