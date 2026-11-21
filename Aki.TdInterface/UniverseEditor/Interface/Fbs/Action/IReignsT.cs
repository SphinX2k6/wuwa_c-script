using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200759B RID: 30107
	public class IReignsT
	{
		// Token: 0x1700DD6F RID: 56687
		// (get) Token: 0x06034D0F RID: 216335 RVA: 0x00719F38 File Offset: 0x00718138
		// (set) Token: 0x06034D10 RID: 216336 RVA: 0x00719F40 File Offset: 0x00718140
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700DD70 RID: 56688
		// (get) Token: 0x06034D11 RID: 216337 RVA: 0x00719F49 File Offset: 0x00718149
		// (set) Token: 0x06034D12 RID: 216338 RVA: 0x00719F51 File Offset: 0x00718151
		public int ReignsId { get; set; }

		// Token: 0x06034D13 RID: 216339 RVA: 0x00719F5A File Offset: 0x0071815A
		public IReignsT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.ReignsId = 0;
		}
	}
}
