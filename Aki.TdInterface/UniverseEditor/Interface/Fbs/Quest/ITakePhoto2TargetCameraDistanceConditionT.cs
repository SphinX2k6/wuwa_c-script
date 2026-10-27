using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004194 RID: 16788
	public class ITakePhoto2TargetCameraDistanceConditionT
	{
		// Token: 0x1700770B RID: 30475
		// (get) Token: 0x06018B31 RID: 101169 RVA: 0x0038E8A2 File Offset: 0x0038CAA2
		// (set) Token: 0x06018B32 RID: 101170 RVA: 0x0038E8AA File Offset: 0x0038CAAA
		public int MaxDistance { get; set; }

		// Token: 0x06018B33 RID: 101171 RVA: 0x0038E8B3 File Offset: 0x0038CAB3
		public ITakePhoto2TargetCameraDistanceConditionT()
		{
			this.MaxDistance = 0;
		}
	}
}
