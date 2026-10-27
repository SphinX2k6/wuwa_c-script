using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DF2 RID: 15858
	public class IEnableSystemConfigT
	{
		// Token: 0x17006D9E RID: 28062
		// (get) Token: 0x060162C7 RID: 90823 RVA: 0x00333F4A File Offset: 0x0033214A
		// (set) Token: 0x060162C8 RID: 90824 RVA: 0x00333F52 File Offset: 0x00332152
		public EEnableSystemType Type { get; set; }

		// Token: 0x060162C9 RID: 90825 RVA: 0x00333F5B File Offset: 0x0033215B
		public IEnableSystemConfigT()
		{
			this.Type = EEnableSystemType.GradingSystem;
		}
	}
}
