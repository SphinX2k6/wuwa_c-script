using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074BB RID: 29883
	public class IUniversalToneT
	{
		// Token: 0x1700E2D6 RID: 58070
		// (get) Token: 0x0603654E RID: 222542 RVA: 0x007623EE File Offset: 0x007605EE
		// (set) Token: 0x0603654F RID: 222543 RVA: 0x007623F6 File Offset: 0x007605F6
		public int UniversalToneId { get; set; }

		// Token: 0x1700E2D7 RID: 58071
		// (get) Token: 0x06036550 RID: 222544 RVA: 0x007623FF File Offset: 0x007605FF
		// (set) Token: 0x06036551 RID: 222545 RVA: 0x00762407 File Offset: 0x00760607
		public int TimberId { get; set; }

		// Token: 0x1700E2D8 RID: 58072
		// (get) Token: 0x06036552 RID: 222546 RVA: 0x00762410 File Offset: 0x00760610
		// (set) Token: 0x06036553 RID: 222547 RVA: 0x00762418 File Offset: 0x00760618
		public byte NullMask { get; set; }

		// Token: 0x06036554 RID: 222548 RVA: 0x00762421 File Offset: 0x00760621
		public IUniversalToneT()
		{
			this.UniversalToneId = 0;
			this.TimberId = 0;
			this.NullMask = 0;
		}
	}
}
