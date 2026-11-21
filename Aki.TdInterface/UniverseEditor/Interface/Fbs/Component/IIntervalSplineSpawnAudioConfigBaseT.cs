using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A0F RID: 23055
	public class IIntervalSplineSpawnAudioConfigBaseT
	{
		// Token: 0x1700A797 RID: 42903
		// (get) Token: 0x06025A93 RID: 154259 RVA: 0x00529BF6 File Offset: 0x00527DF6
		// (set) Token: 0x06025A94 RID: 154260 RVA: 0x00529BFE File Offset: 0x00527DFE
		public EIntervalSplineSpawnAudioConfigType Type { get; set; }

		// Token: 0x06025A95 RID: 154261 RVA: 0x00529C07 File Offset: 0x00527E07
		public IIntervalSplineSpawnAudioConfigBaseT()
		{
			this.Type = EIntervalSplineSpawnAudioConfigType.AllActorAddAudio;
		}
	}
}
