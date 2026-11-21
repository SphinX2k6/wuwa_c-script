using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076AF RID: 30383
	public class ISceneActorMusicPlantsEventT
	{
		// Token: 0x1700DEDF RID: 57055
		// (get) Token: 0x060354BB RID: 218299 RVA: 0x0072654A File Offset: 0x0072474A
		// (set) Token: 0x060354BC RID: 218300 RVA: 0x00726552 File Offset: 0x00724752
		public ESceneActorEventType Type { get; set; }

		// Token: 0x060354BD RID: 218301 RVA: 0x0072655B File Offset: 0x0072475B
		public ISceneActorMusicPlantsEventT()
		{
			this.Type = ESceneActorEventType.PlayMusicPlants;
		}
	}
}
