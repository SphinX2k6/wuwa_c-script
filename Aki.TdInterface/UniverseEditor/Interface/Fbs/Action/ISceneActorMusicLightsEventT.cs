using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076AC RID: 30380
	public class ISceneActorMusicLightsEventT
	{
		// Token: 0x1700DEDC RID: 57052
		// (get) Token: 0x060354A9 RID: 218281 RVA: 0x007263D2 File Offset: 0x007245D2
		// (set) Token: 0x060354AA RID: 218282 RVA: 0x007263DA File Offset: 0x007245DA
		public ESceneActorEventType Type { get; set; }

		// Token: 0x060354AB RID: 218283 RVA: 0x007263E3 File Offset: 0x007245E3
		public ISceneActorMusicLightsEventT()
		{
			this.Type = ESceneActorEventType.PlayMusicPlants;
		}
	}
}
