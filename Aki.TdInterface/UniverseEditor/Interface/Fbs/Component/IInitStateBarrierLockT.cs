using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059A3 RID: 22947
	public class IInitStateBarrierLockT
	{
		// Token: 0x1700A6A0 RID: 42656
		// (get) Token: 0x06025695 RID: 153237 RVA: 0x00521F0A File Offset: 0x0052010A
		// (set) Token: 0x06025696 RID: 153238 RVA: 0x00521F12 File Offset: 0x00520112
		public EInitStateType Type { get; set; }

		// Token: 0x06025697 RID: 153239 RVA: 0x00521F1B File Offset: 0x0052011B
		public IInitStateBarrierLockT()
		{
			this.Type = EInitStateType.Birth;
		}
	}
}
