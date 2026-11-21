using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073BF RID: 29631
	public class IOverrideLookAtTypeT
	{
		// Token: 0x1700D9B1 RID: 55729
		// (get) Token: 0x06033D50 RID: 212304 RVA: 0x006FDBBA File Offset: 0x006FBDBA
		// (set) Token: 0x06033D51 RID: 212305 RVA: 0x006FDBC2 File Offset: 0x006FBDC2
		public EOverrideLookAtType Type { get; set; }

		// Token: 0x06033D52 RID: 212306 RVA: 0x006FDBCB File Offset: 0x006FBDCB
		public IOverrideLookAtTypeT()
		{
			this.Type = EOverrideLookAtType.CheckFlowLookAt;
		}
	}
}
