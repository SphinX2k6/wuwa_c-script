using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004ECC RID: 20172
	public class IAudioControlTypeT
	{
		// Token: 0x170090D2 RID: 37074
		// (get) Token: 0x0601FCB1 RID: 130225 RVA: 0x0046CE7E File Offset: 0x0046B07E
		// (set) Token: 0x0601FCB2 RID: 130226 RVA: 0x0046CE86 File Offset: 0x0046B086
		public EAudioControlType Type { get; set; }

		// Token: 0x0601FCB3 RID: 130227 RVA: 0x0046CE8F File Offset: 0x0046B08F
		public IAudioControlTypeT()
		{
			this.Type = EAudioControlType.Gramophone;
		}
	}
}
