using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055C9 RID: 21961
	public class ICycleModeTypeT
	{
		// Token: 0x17009D3A RID: 40250
		// (get) Token: 0x06022F11 RID: 143121 RVA: 0x004CF50E File Offset: 0x004CD70E
		// (set) Token: 0x06022F12 RID: 143122 RVA: 0x004CF516 File Offset: 0x004CD716
		public EPatrolCycleMode Type { get; set; }

		// Token: 0x06022F13 RID: 143123 RVA: 0x004CF51F File Offset: 0x004CD71F
		public ICycleModeTypeT()
		{
			this.Type = EPatrolCycleMode.Loop;
		}
	}
}
