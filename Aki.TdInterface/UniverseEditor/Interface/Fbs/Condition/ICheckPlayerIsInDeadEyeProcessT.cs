using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AEE RID: 19182
	public class ICheckPlayerIsInDeadEyeProcessT
	{
		// Token: 0x17008B18 RID: 35608
		// (get) Token: 0x0601E24E RID: 123470 RVA: 0x0043A544 File Offset: 0x00438744
		// (set) Token: 0x0601E24F RID: 123471 RVA: 0x0043A54C File Offset: 0x0043874C
		public ECondition Type { get; set; }

		// Token: 0x17008B19 RID: 35609
		// (get) Token: 0x0601E250 RID: 123472 RVA: 0x0043A555 File Offset: 0x00438755
		// (set) Token: 0x0601E251 RID: 123473 RVA: 0x0043A55D File Offset: 0x0043875D
		public bool IsInDeadEyeProcess { get; set; }

		// Token: 0x0601E252 RID: 123474 RVA: 0x0043A566 File Offset: 0x00438766
		public ICheckPlayerIsInDeadEyeProcessT()
		{
			this.Type = ECondition.CompareVar;
			this.IsInDeadEyeProcess = false;
		}
	}
}
