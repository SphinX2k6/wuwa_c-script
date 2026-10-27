using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AE8 RID: 15080
	public class ITargetTypeT
	{
		// Token: 0x17006772 RID: 26482
		// (get) Token: 0x060148C2 RID: 84162 RVA: 0x002FE05A File Offset: 0x002FC25A
		// (set) Token: 0x060148C3 RID: 84163 RVA: 0x002FE062 File Offset: 0x002FC262
		public ETargetType Type { get; set; }

		// Token: 0x060148C4 RID: 84164 RVA: 0x002FE06B File Offset: 0x002FC26B
		public ITargetTypeT()
		{
			this.Type = ETargetType.Player;
		}
	}
}
