using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006811 RID: 26641
	public class IFlowerSeaEscapeT
	{
		// Token: 0x1700C5B9 RID: 50617
		// (get) Token: 0x0602E65A RID: 190042 RVA: 0x00654EBD File Offset: 0x006530BD
		// (set) Token: 0x0602E65B RID: 190043 RVA: 0x00654EC5 File Offset: 0x006530C5
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700C5BA RID: 50618
		// (get) Token: 0x0602E65C RID: 190044 RVA: 0x00654ECE File Offset: 0x006530CE
		// (set) Token: 0x0602E65D RID: 190045 RVA: 0x00654ED6 File Offset: 0x006530D6
		public int EndAreaEntityId { get; set; }

		// Token: 0x1700C5BB RID: 50619
		// (get) Token: 0x0602E65E RID: 190046 RVA: 0x00654EDF File Offset: 0x006530DF
		// (set) Token: 0x0602E65F RID: 190047 RVA: 0x00654EE7 File Offset: 0x006530E7
		public string ConfigDa { get; set; }

		// Token: 0x1700C5BC RID: 50620
		// (get) Token: 0x0602E660 RID: 190048 RVA: 0x00654EF0 File Offset: 0x006530F0
		// (set) Token: 0x0602E661 RID: 190049 RVA: 0x00654EF8 File Offset: 0x006530F8
		public string SpreadingState { get; set; }

		// Token: 0x1700C5BD RID: 50621
		// (get) Token: 0x0602E662 RID: 190050 RVA: 0x00654F01 File Offset: 0x00653101
		// (set) Token: 0x0602E663 RID: 190051 RVA: 0x00654F09 File Offset: 0x00653109
		public string PausedState { get; set; }

		// Token: 0x1700C5BE RID: 50622
		// (get) Token: 0x0602E664 RID: 190052 RVA: 0x00654F12 File Offset: 0x00653112
		// (set) Token: 0x0602E665 RID: 190053 RVA: 0x00654F1A File Offset: 0x0065311A
		public string ResetState { get; set; }

		// Token: 0x0602E666 RID: 190054 RVA: 0x00654F23 File Offset: 0x00653123
		public IFlowerSeaEscapeT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.EndAreaEntityId = 0;
			this.ConfigDa = null;
			this.SpreadingState = null;
			this.PausedState = null;
			this.ResetState = null;
		}
	}
}
