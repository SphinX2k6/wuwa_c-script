using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A30 RID: 27184
	public class IClientExecEntityPrefabActionT
	{
		// Token: 0x1700C7CC RID: 51148
		// (get) Token: 0x0602EA1F RID: 191007 RVA: 0x0065BA9D File Offset: 0x00659C9D
		// (set) Token: 0x0602EA20 RID: 191008 RVA: 0x0065BAA5 File Offset: 0x00659CA5
		public IClientModifyEntityPrefabParamsT Option { get; set; }

		// Token: 0x0602EA21 RID: 191009 RVA: 0x0065BAAE File Offset: 0x00659CAE
		public IClientExecEntityPrefabActionT()
		{
			this.Option = null;
		}
	}
}
