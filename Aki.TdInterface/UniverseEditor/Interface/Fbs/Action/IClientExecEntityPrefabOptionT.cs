using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A33 RID: 27187
	public class IClientExecEntityPrefabOptionT
	{
		// Token: 0x1700C7CF RID: 51151
		// (get) Token: 0x0602EA31 RID: 191025 RVA: 0x0065BC2A File Offset: 0x00659E2A
		// (set) Token: 0x0602EA32 RID: 191026 RVA: 0x0065BC32 File Offset: 0x00659E32
		public EClientExecEntityPrefabOption Type { get; set; }

		// Token: 0x0602EA33 RID: 191027 RVA: 0x0065BC3B File Offset: 0x00659E3B
		public IClientExecEntityPrefabOptionT()
		{
			this.Type = EClientExecEntityPrefabOption.ModifyPrefabParams;
		}
	}
}
