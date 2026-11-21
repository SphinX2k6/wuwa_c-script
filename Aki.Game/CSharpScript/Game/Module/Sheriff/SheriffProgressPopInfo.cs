using System;
using Aki.Config;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02003BFF RID: 15359
	public class SheriffProgressPopInfo : ISheriffProgressPopInfo
	{
		// Token: 0x17005072 RID: 20594
		// (get) Token: 0x060275BA RID: 161210 RVA: 0x00B0804C File Offset: 0x00B0624C
		// (set) Token: 0x060275BB RID: 161211 RVA: 0x00B08054 File Offset: 0x00B06254
		public SheriffProgress Progress { get; set; }

		// Token: 0x17005073 RID: 20595
		// (get) Token: 0x060275BC RID: 161212 RVA: 0x00B0805D File Offset: 0x00B0625D
		// (set) Token: 0x060275BD RID: 161213 RVA: 0x00B08065 File Offset: 0x00B06265
		public bool NeedAnim { get; set; }
	}
}
