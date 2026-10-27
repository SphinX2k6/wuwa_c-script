using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005510 RID: 21776
	public class ILookAtTargetBaseT
	{
		// Token: 0x1700A0C9 RID: 41161
		// (get) Token: 0x06023F83 RID: 147331 RVA: 0x004F8C6A File Offset: 0x004F6E6A
		// (set) Token: 0x06023F84 RID: 147332 RVA: 0x004F8C72 File Offset: 0x004F6E72
		public ELookAtTargetType Type { get; set; }

		// Token: 0x06023F85 RID: 147333 RVA: 0x004F8C7B File Offset: 0x004F6E7B
		public ILookAtTargetBaseT()
		{
			this.Type = ELookAtTargetType.Entity;
		}
	}
}
