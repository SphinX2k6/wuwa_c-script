using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043EC RID: 17388
	public class IPlotHandBookNodeT
	{
		// Token: 0x170077CD RID: 30669
		// (get) Token: 0x06018B4F RID: 101199 RVA: 0x00385A59 File Offset: 0x00383C59
		// (set) Token: 0x06018B50 RID: 101200 RVA: 0x00385A61 File Offset: 0x00383C61
		public string TidTip { get; set; }

		// Token: 0x170077CE RID: 30670
		// (get) Token: 0x06018B51 RID: 101201 RVA: 0x00385A6A File Offset: 0x00383C6A
		// (set) Token: 0x06018B52 RID: 101202 RVA: 0x00385A72 File Offset: 0x00383C72
		public IFlowStateIndexT Flow { get; set; }

		// Token: 0x170077CF RID: 30671
		// (get) Token: 0x06018B53 RID: 101203 RVA: 0x00385A7B File Offset: 0x00383C7B
		// (set) Token: 0x06018B54 RID: 101204 RVA: 0x00385A83 File Offset: 0x00383C83
		public bool IsHideUi { get; set; }

		// Token: 0x06018B55 RID: 101205 RVA: 0x00385A8C File Offset: 0x00383C8C
		public IPlotHandBookNodeT()
		{
			this.TidTip = null;
			this.Flow = null;
			this.IsHideUi = false;
		}
	}
}
