using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A0C RID: 23052
	public class IIntervalSplineSpawnAllActorAudioT
	{
		// Token: 0x1700A792 RID: 42898
		// (get) Token: 0x06025A7D RID: 154237 RVA: 0x00529A11 File Offset: 0x00527C11
		// (set) Token: 0x06025A7E RID: 154238 RVA: 0x00529A19 File Offset: 0x00527C19
		public EIntervalSplineSpawnAudioConfigType Type { get; set; }

		// Token: 0x1700A793 RID: 42899
		// (get) Token: 0x06025A7F RID: 154239 RVA: 0x00529A22 File Offset: 0x00527C22
		// (set) Token: 0x06025A80 RID: 154240 RVA: 0x00529A2A File Offset: 0x00527C2A
		public string AkEvent { get; set; }

		// Token: 0x1700A794 RID: 42900
		// (get) Token: 0x06025A81 RID: 154241 RVA: 0x00529A33 File Offset: 0x00527C33
		// (set) Token: 0x06025A82 RID: 154242 RVA: 0x00529A3B File Offset: 0x00527C3B
		public IVectorInfoT Offset { get; set; }

		// Token: 0x06025A83 RID: 154243 RVA: 0x00529A44 File Offset: 0x00527C44
		public IIntervalSplineSpawnAllActorAudioT()
		{
			this.Type = EIntervalSplineSpawnAudioConfigType.AllActorAddAudio;
			this.AkEvent = null;
			this.Offset = null;
		}
	}
}
