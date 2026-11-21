using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057FA RID: 22522
	public class IFollowDecorationConfigT
	{
		// Token: 0x1700A2FD RID: 41725
		// (get) Token: 0x060246C8 RID: 149192 RVA: 0x005015B6 File Offset: 0x004FF7B6
		// (set) Token: 0x060246C9 RID: 149193 RVA: 0x005015BE File Offset: 0x004FF7BE
		public EFollowDecorationType Type { get; set; }

		// Token: 0x060246CA RID: 149194 RVA: 0x005015C7 File Offset: 0x004FF7C7
		public IFollowDecorationConfigT()
		{
			this.Type = EFollowDecorationType.Chair;
		}
	}
}
