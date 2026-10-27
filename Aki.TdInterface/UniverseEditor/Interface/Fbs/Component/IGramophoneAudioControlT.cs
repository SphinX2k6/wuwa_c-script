using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052FE RID: 21246
	public class IGramophoneAudioControlT
	{
		// Token: 0x17009C04 RID: 39940
		// (get) Token: 0x06022B42 RID: 142146 RVA: 0x004CF2B2 File Offset: 0x004CD4B2
		// (set) Token: 0x06022B43 RID: 142147 RVA: 0x004CF2BA File Offset: 0x004CD4BA
		public EAudioControlType Type { get; set; }

		// Token: 0x06022B44 RID: 142148 RVA: 0x004CF2C3 File Offset: 0x004CD4C3
		public IGramophoneAudioControlT()
		{
			this.Type = EAudioControlType.Gramophone;
		}
	}
}
