using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005486 RID: 21638
	public class IIntervalSplineSpawnAllActorAudioT
	{
		// Token: 0x17009F58 RID: 40792
		// (get) Token: 0x060239C5 RID: 145861 RVA: 0x004EC99D File Offset: 0x004EAB9D
		// (set) Token: 0x060239C6 RID: 145862 RVA: 0x004EC9A5 File Offset: 0x004EABA5
		public EIntervalSplineSpawnAudioConfigType Type { get; set; }

		// Token: 0x17009F59 RID: 40793
		// (get) Token: 0x060239C7 RID: 145863 RVA: 0x004EC9AE File Offset: 0x004EABAE
		// (set) Token: 0x060239C8 RID: 145864 RVA: 0x004EC9B6 File Offset: 0x004EABB6
		public string AkEvent { get; set; }

		// Token: 0x17009F5A RID: 40794
		// (get) Token: 0x060239C9 RID: 145865 RVA: 0x004EC9BF File Offset: 0x004EABBF
		// (set) Token: 0x060239CA RID: 145866 RVA: 0x004EC9C7 File Offset: 0x004EABC7
		public IVectorInfoT Offset { get; set; }

		// Token: 0x060239CB RID: 145867 RVA: 0x004EC9D0 File Offset: 0x004EABD0
		public IIntervalSplineSpawnAllActorAudioT()
		{
			this.Type = EIntervalSplineSpawnAudioConfigType.AllActorAddAudio;
			this.AkEvent = null;
			this.Offset = null;
		}
	}
}
