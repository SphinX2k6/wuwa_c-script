using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006956 RID: 26966
	public class IChangeEntityPrefabPerformanceT
	{
		// Token: 0x1700C67B RID: 50811
		// (get) Token: 0x0602E394 RID: 189332 RVA: 0x006502C2 File Offset: 0x0064E4C2
		// (set) Token: 0x0602E395 RID: 189333 RVA: 0x006502CA File Offset: 0x0064E4CA
		public EChangeEntityPrefabPerformanceType Type { get; set; }

		// Token: 0x0602E396 RID: 189334 RVA: 0x006502D3 File Offset: 0x0064E4D3
		public IChangeEntityPrefabPerformanceT()
		{
			this.Type = EChangeEntityPrefabPerformanceType.Target;
		}
	}
}
