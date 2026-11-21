using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EAC RID: 20140
	public class ICheckEnterTriggerDirTypeT
	{
		// Token: 0x17008FB0 RID: 36784
		// (get) Token: 0x0601F38D RID: 127885 RVA: 0x0045A37A File Offset: 0x0045857A
		// (set) Token: 0x0601F38E RID: 127886 RVA: 0x0045A382 File Offset: 0x00458582
		public ECheckEnterTriggerDirType Type { get; set; }

		// Token: 0x0601F38F RID: 127887 RVA: 0x0045A38B File Offset: 0x0045858B
		public ICheckEnterTriggerDirTypeT()
		{
			this.Type = ECheckEnterTriggerDirType.ForwardAngle;
		}
	}
}
