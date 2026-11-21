using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200698F RID: 27023
	public class IChangeSelfEntityPrefabPerformanceT
	{
		// Token: 0x1700C6F5 RID: 50933
		// (get) Token: 0x0602E5AC RID: 189868 RVA: 0x00653E57 File Offset: 0x00652057
		// (set) Token: 0x0602E5AD RID: 189869 RVA: 0x00653E5F File Offset: 0x0065205F
		public EChangeEntityPrefabPerformanceType Type { get; set; }

		// Token: 0x1700C6F6 RID: 50934
		// (get) Token: 0x0602E5AE RID: 189870 RVA: 0x00653E68 File Offset: 0x00652068
		// (set) Token: 0x0602E5AF RID: 189871 RVA: 0x00653E70 File Offset: 0x00652070
		public string PerformanceTag { get; set; }

		// Token: 0x0602E5B0 RID: 189872 RVA: 0x00653E79 File Offset: 0x00652079
		public IChangeSelfEntityPrefabPerformanceT()
		{
			this.Type = EChangeEntityPrefabPerformanceType.Target;
			this.PerformanceTag = null;
		}
	}
}
