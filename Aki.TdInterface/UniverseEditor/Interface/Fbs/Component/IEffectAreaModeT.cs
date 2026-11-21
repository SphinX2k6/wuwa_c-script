using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005674 RID: 22132
	public class IEffectAreaModeT
	{
		// Token: 0x17009F22 RID: 40738
		// (get) Token: 0x06023658 RID: 144984 RVA: 0x004DE762 File Offset: 0x004DC962
		// (set) Token: 0x06023659 RID: 144985 RVA: 0x004DE76A File Offset: 0x004DC96A
		public EEffectAreaType Type { get; set; }

		// Token: 0x0602365A RID: 144986 RVA: 0x004DE773 File Offset: 0x004DC973
		public IEffectAreaModeT()
		{
			this.Type = EEffectAreaType.BuffArea;
		}
	}
}
