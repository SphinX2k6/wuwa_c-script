using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200631E RID: 25374
	public class IChangeSelfEntityPrefabPerformanceT
	{
		// Token: 0x1700BD6B RID: 48491
		// (get) Token: 0x0602BE43 RID: 179779 RVA: 0x00608E4B File Offset: 0x0060704B
		// (set) Token: 0x0602BE44 RID: 179780 RVA: 0x00608E53 File Offset: 0x00607053
		public EChangeEntityPrefabPerformanceType Type { get; set; }

		// Token: 0x1700BD6C RID: 48492
		// (get) Token: 0x0602BE45 RID: 179781 RVA: 0x00608E5C File Offset: 0x0060705C
		// (set) Token: 0x0602BE46 RID: 179782 RVA: 0x00608E64 File Offset: 0x00607064
		public string PerformanceTag { get; set; }

		// Token: 0x0602BE47 RID: 179783 RVA: 0x00608E6D File Offset: 0x0060706D
		public IChangeSelfEntityPrefabPerformanceT()
		{
			this.Type = EChangeEntityPrefabPerformanceType.Target;
			this.PerformanceTag = null;
		}
	}
}
