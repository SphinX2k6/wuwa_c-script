using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200587E RID: 22654
	public class IGrabComponentT
	{
		// Token: 0x1700A42E RID: 42030
		// (get) Token: 0x06024BC2 RID: 150466 RVA: 0x0050BBA5 File Offset: 0x00509DA5
		// (set) Token: 0x06024BC3 RID: 150467 RVA: 0x0050BBAD File Offset: 0x00509DAD
		public bool Disabled { get; set; }

		// Token: 0x1700A42F RID: 42031
		// (get) Token: 0x06024BC4 RID: 150468 RVA: 0x0050BBB6 File Offset: 0x00509DB6
		// (set) Token: 0x06024BC5 RID: 150469 RVA: 0x0050BBBE File Offset: 0x00509DBE
		public IVectorInfoT GrabPos { get; set; }

		// Token: 0x1700A430 RID: 42032
		// (get) Token: 0x06024BC6 RID: 150470 RVA: 0x0050BBC7 File Offset: 0x00509DC7
		// (set) Token: 0x06024BC7 RID: 150471 RVA: 0x0050BBCF File Offset: 0x00509DCF
		public int ThrowPow { get; set; }

		// Token: 0x1700A431 RID: 42033
		// (get) Token: 0x06024BC8 RID: 150472 RVA: 0x0050BBD8 File Offset: 0x00509DD8
		// (set) Token: 0x06024BC9 RID: 150473 RVA: 0x0050BBE0 File Offset: 0x00509DE0
		public int ThrowHight { get; set; }

		// Token: 0x1700A432 RID: 42034
		// (get) Token: 0x06024BCA RID: 150474 RVA: 0x0050BBE9 File Offset: 0x00509DE9
		// (set) Token: 0x06024BCB RID: 150475 RVA: 0x0050BBF1 File Offset: 0x00509DF1
		public byte NullMask { get; set; }

		// Token: 0x06024BCC RID: 150476 RVA: 0x0050BBFA File Offset: 0x00509DFA
		public IGrabComponentT()
		{
			this.Disabled = false;
			this.GrabPos = null;
			this.ThrowPow = 0;
			this.ThrowHight = 0;
			this.NullMask = 0;
		}
	}
}
