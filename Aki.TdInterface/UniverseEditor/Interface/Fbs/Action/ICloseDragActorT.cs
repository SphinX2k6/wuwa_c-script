using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006419 RID: 25625
	public class ICloseDragActorT
	{
		// Token: 0x1700BECC RID: 48844
		// (get) Token: 0x0602C56F RID: 181615 RVA: 0x00615BD4 File Offset: 0x00613DD4
		// (set) Token: 0x0602C570 RID: 181616 RVA: 0x00615BDC File Offset: 0x00613DDC
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700BECD RID: 48845
		// (get) Token: 0x0602C571 RID: 181617 RVA: 0x00615BE5 File Offset: 0x00613DE5
		// (set) Token: 0x0602C572 RID: 181618 RVA: 0x00615BED File Offset: 0x00613DED
		public int TargetEntityId { get; set; }

		// Token: 0x0602C573 RID: 181619 RVA: 0x00615BF6 File Offset: 0x00613DF6
		public ICloseDragActorT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.TargetEntityId = 0;
		}
	}
}
