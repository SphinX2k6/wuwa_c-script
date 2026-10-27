using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F25 RID: 28453
	public class ISceneActorMusicLightsEventT
	{
		// Token: 0x1700D380 RID: 54144
		// (get) Token: 0x06032451 RID: 205905 RVA: 0x006CA46A File Offset: 0x006C866A
		// (set) Token: 0x06032452 RID: 205906 RVA: 0x006CA472 File Offset: 0x006C8672
		public ESceneActorEventType Type { get; set; }

		// Token: 0x06032453 RID: 205907 RVA: 0x006CA47B File Offset: 0x006C867B
		public ISceneActorMusicLightsEventT()
		{
			this.Type = ESceneActorEventType.PlayMusicPlants;
		}
	}
}
