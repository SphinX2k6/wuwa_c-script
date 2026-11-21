using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076A6 RID: 30374
	public class ISceneActorEventT
	{
		// Token: 0x1700DED7 RID: 57047
		// (get) Token: 0x06035487 RID: 218247 RVA: 0x007260CE File Offset: 0x007242CE
		// (set) Token: 0x06035488 RID: 218248 RVA: 0x007260D6 File Offset: 0x007242D6
		public ESceneActorEventType Type { get; set; }

		// Token: 0x06035489 RID: 218249 RVA: 0x007260DF File Offset: 0x007242DF
		public ISceneActorEventT()
		{
			this.Type = ESceneActorEventType.PlayMusicPlants;
		}
	}
}
