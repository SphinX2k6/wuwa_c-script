using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005067 RID: 20583
	public class ICycleModeTypeT
	{
		// Token: 0x17009554 RID: 38228
		// (get) Token: 0x06020FD7 RID: 135127 RVA: 0x0049585A File Offset: 0x00493A5A
		// (set) Token: 0x06020FD8 RID: 135128 RVA: 0x00495862 File Offset: 0x00493A62
		public EPatrolCycleMode Type { get; set; }

		// Token: 0x06020FD9 RID: 135129 RVA: 0x0049586B File Offset: 0x00493A6B
		public ICycleModeTypeT()
		{
			this.Type = EPatrolCycleMode.Loop;
		}
	}
}
