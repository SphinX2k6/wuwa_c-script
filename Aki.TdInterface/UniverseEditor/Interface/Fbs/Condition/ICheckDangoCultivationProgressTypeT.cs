using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E76 RID: 20086
	public class ICheckDangoCultivationProgressTypeT
	{
		// Token: 0x17008F41 RID: 36673
		// (get) Token: 0x0601F1CB RID: 127435 RVA: 0x0045745E File Offset: 0x0045565E
		// (set) Token: 0x0601F1CC RID: 127436 RVA: 0x00457466 File Offset: 0x00455666
		public ECheckDangoCultivationProgressType Type { get; set; }

		// Token: 0x0601F1CD RID: 127437 RVA: 0x0045746F File Offset: 0x0045566F
		public ICheckDangoCultivationProgressTypeT()
		{
			this.Type = ECheckDangoCultivationProgressType.CountDangoOverTargetLevel;
		}
	}
}
