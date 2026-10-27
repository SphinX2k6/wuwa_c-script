using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200541D RID: 21533
	public class IInitStateBarrierLockT
	{
		// Token: 0x17009E66 RID: 40550
		// (get) Token: 0x060235DD RID: 144861 RVA: 0x004E4EDE File Offset: 0x004E30DE
		// (set) Token: 0x060235DE RID: 144862 RVA: 0x004E4EE6 File Offset: 0x004E30E6
		public EInitStateType Type { get; set; }

		// Token: 0x060235DF RID: 144863 RVA: 0x004E4EEF File Offset: 0x004E30EF
		public IInitStateBarrierLockT()
		{
			this.Type = EInitStateType.Birth;
		}
	}
}
