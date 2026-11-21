using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004170 RID: 16752
	public class ICheckPlayerInputBaseT
	{
		// Token: 0x17007185 RID: 29061
		// (get) Token: 0x060170DF RID: 94431 RVA: 0x00349876 File Offset: 0x00347A76
		// (set) Token: 0x060170E0 RID: 94432 RVA: 0x0034987E File Offset: 0x00347A7E
		public ECheckPlayerInputType Type { get; set; }

		// Token: 0x060170E1 RID: 94433 RVA: 0x00349887 File Offset: 0x00347A87
		public ICheckPlayerInputBaseT()
		{
			this.Type = ECheckPlayerInputType.PressButton;
		}
	}
}
