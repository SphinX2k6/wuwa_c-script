using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006249 RID: 25161
	public class IBvbPlayDialogT
	{
		// Token: 0x1700BB87 RID: 48007
		// (get) Token: 0x0602B63A RID: 177722 RVA: 0x005F9002 File Offset: 0x005F7202
		// (set) Token: 0x0602B63B RID: 177723 RVA: 0x005F900A File Offset: 0x005F720A
		public EBvbPlayDialogType DialogType { get; set; }

		// Token: 0x0602B63C RID: 177724 RVA: 0x005F9013 File Offset: 0x005F7213
		public IBvbPlayDialogT()
		{
			this.DialogType = EBvbPlayDialogType.DungeonBegin;
		}
	}
}
