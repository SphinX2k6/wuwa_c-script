using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006526 RID: 25894
	public class IDaemonHackT
	{
		// Token: 0x1700C090 RID: 49296
		// (get) Token: 0x0602CEDD RID: 184029 RVA: 0x0062B907 File Offset: 0x00629B07
		// (set) Token: 0x0602CEDE RID: 184030 RVA: 0x0062B90F File Offset: 0x00629B0F
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700C091 RID: 49297
		// (get) Token: 0x0602CEDF RID: 184031 RVA: 0x0062B918 File Offset: 0x00629B18
		// (set) Token: 0x0602CEE0 RID: 184032 RVA: 0x0062B920 File Offset: 0x00629B20
		public List<int> Ids { get; set; }

		// Token: 0x1700C092 RID: 49298
		// (get) Token: 0x0602CEE1 RID: 184033 RVA: 0x0062B929 File Offset: 0x00629B29
		// (set) Token: 0x0602CEE2 RID: 184034 RVA: 0x0062B931 File Offset: 0x00629B31
		public bool FinishOnClose { get; set; }

		// Token: 0x1700C093 RID: 49299
		// (get) Token: 0x0602CEE3 RID: 184035 RVA: 0x0062B93A File Offset: 0x00629B3A
		// (set) Token: 0x0602CEE4 RID: 184036 RVA: 0x0062B942 File Offset: 0x00629B42
		public byte NullMask { get; set; }

		// Token: 0x0602CEE5 RID: 184037 RVA: 0x0062B94B File Offset: 0x00629B4B
		public IDaemonHackT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.Ids = null;
			this.FinishOnClose = false;
			this.NullMask = 0;
		}
	}
}
