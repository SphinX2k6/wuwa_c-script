using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200686B RID: 26731
	public class IGamePadInteractVibrationT
	{
		// Token: 0x1700C693 RID: 50835
		// (get) Token: 0x0602E9EF RID: 190959 RVA: 0x0065BC8E File Offset: 0x00659E8E
		// (set) Token: 0x0602E9F0 RID: 190960 RVA: 0x0065BC96 File Offset: 0x00659E96
		public string LongPressingEffect { get; set; }

		// Token: 0x1700C694 RID: 50836
		// (get) Token: 0x0602E9F1 RID: 190961 RVA: 0x0065BC9F File Offset: 0x00659E9F
		// (set) Token: 0x0602E9F2 RID: 190962 RVA: 0x0065BCA7 File Offset: 0x00659EA7
		public string LongPressFinishedEffect { get; set; }

		// Token: 0x0602E9F3 RID: 190963 RVA: 0x0065BCB0 File Offset: 0x00659EB0
		public IGamePadInteractVibrationT()
		{
			this.LongPressingEffect = null;
			this.LongPressFinishedEffect = null;
		}
	}
}
