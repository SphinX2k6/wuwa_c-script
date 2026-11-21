using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005884 RID: 22660
	public class IGramophoneAudioControlT
	{
		// Token: 0x1700A43C RID: 42044
		// (get) Token: 0x06024BF6 RID: 150518 RVA: 0x0050C186 File Offset: 0x0050A386
		// (set) Token: 0x06024BF7 RID: 150519 RVA: 0x0050C18E File Offset: 0x0050A38E
		public EAudioControlType Type { get; set; }

		// Token: 0x06024BF8 RID: 150520 RVA: 0x0050C197 File Offset: 0x0050A397
		public IGramophoneAudioControlT()
		{
			this.Type = EAudioControlType.Gramophone;
		}
	}
}
