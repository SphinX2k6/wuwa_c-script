using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F1F RID: 28447
	public class ISceneActorEventT
	{
		// Token: 0x1700D37B RID: 54139
		// (get) Token: 0x0603242F RID: 205871 RVA: 0x006CA166 File Offset: 0x006C8366
		// (set) Token: 0x06032430 RID: 205872 RVA: 0x006CA16E File Offset: 0x006C836E
		public ESceneActorEventType Type { get; set; }

		// Token: 0x06032431 RID: 205873 RVA: 0x006CA177 File Offset: 0x006C8377
		public ISceneActorEventT()
		{
			this.Type = ESceneActorEventType.PlayMusicPlants;
		}
	}
}
