using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005149 RID: 20809
	public class IMechConditionT
	{
		// Token: 0x17009526 RID: 38182
		// (get) Token: 0x06020BD1 RID: 134097 RVA: 0x004890F2 File Offset: 0x004872F2
		// (set) Token: 0x06020BD2 RID: 134098 RVA: 0x004890FA File Offset: 0x004872FA
		public EMechConditionType Type { get; set; }

		// Token: 0x06020BD3 RID: 134099 RVA: 0x00489103 File Offset: 0x00487303
		public IMechConditionT()
		{
			this.Type = EMechConditionType.PlayerInMech;
		}
	}
}
