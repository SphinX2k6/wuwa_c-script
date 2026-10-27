using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F28 RID: 28456
	public class ISceneActorMusicPlantsEventT
	{
		// Token: 0x1700D383 RID: 54147
		// (get) Token: 0x06032463 RID: 205923 RVA: 0x006CA5E2 File Offset: 0x006C87E2
		// (set) Token: 0x06032464 RID: 205924 RVA: 0x006CA5EA File Offset: 0x006C87EA
		public ESceneActorEventType Type { get; set; }

		// Token: 0x06032465 RID: 205925 RVA: 0x006CA5F3 File Offset: 0x006C87F3
		public ISceneActorMusicPlantsEventT()
		{
			this.Type = ESceneActorEventType.PlayMusicPlants;
		}
	}
}
