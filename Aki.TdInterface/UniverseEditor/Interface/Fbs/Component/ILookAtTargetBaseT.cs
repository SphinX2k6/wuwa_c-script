using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A96 RID: 23190
	public class ILookAtTargetBaseT
	{
		// Token: 0x1700A903 RID: 43267
		// (get) Token: 0x0602603D RID: 155709 RVA: 0x00535D8E File Offset: 0x00533F8E
		// (set) Token: 0x0602603E RID: 155710 RVA: 0x00535D96 File Offset: 0x00533F96
		public ELookAtTargetType Type { get; set; }

		// Token: 0x0602603F RID: 155711 RVA: 0x00535D9F File Offset: 0x00533F9F
		public ILookAtTargetBaseT()
		{
			this.Type = ELookAtTargetType.Entity;
		}
	}
}
