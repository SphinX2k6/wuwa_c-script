using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069DF RID: 27103
	public class ICipherGameplayT
	{
		// Token: 0x1700C769 RID: 51049
		// (get) Token: 0x0602E7FB RID: 190459 RVA: 0x00657F3F File Offset: 0x0065613F
		// (set) Token: 0x0602E7FC RID: 190460 RVA: 0x00657F47 File Offset: 0x00656147
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700C76A RID: 51050
		// (get) Token: 0x0602E7FD RID: 190461 RVA: 0x00657F50 File Offset: 0x00656150
		// (set) Token: 0x0602E7FE RID: 190462 RVA: 0x00657F58 File Offset: 0x00656158
		public string CipherId { get; set; }

		// Token: 0x0602E7FF RID: 190463 RVA: 0x00657F61 File Offset: 0x00656161
		public ICipherGameplayT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.CipherId = null;
		}
	}
}
