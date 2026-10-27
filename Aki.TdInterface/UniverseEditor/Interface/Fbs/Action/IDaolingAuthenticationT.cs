using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006535 RID: 25909
	public class IDaolingAuthenticationT
	{
		// Token: 0x1700C09A RID: 49306
		// (get) Token: 0x0602CF29 RID: 184105 RVA: 0x0062BE9E File Offset: 0x0062A09E
		// (set) Token: 0x0602CF2A RID: 184106 RVA: 0x0062BEA6 File Offset: 0x0062A0A6
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x0602CF2B RID: 184107 RVA: 0x0062BEAF File Offset: 0x0062A0AF
		public IDaolingAuthenticationT()
		{
			this.Type = ESimpleGameplayType.Cipher;
		}
	}
}
