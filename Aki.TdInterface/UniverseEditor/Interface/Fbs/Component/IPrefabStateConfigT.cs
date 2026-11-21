using System;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D86 RID: 23942
	public class IPrefabStateConfigT
	{
		// Token: 0x1700B038 RID: 45112
		// (get) Token: 0x06027DE9 RID: 163305 RVA: 0x00574230 File Offset: 0x00572430
		// (set) Token: 0x06027DEA RID: 163306 RVA: 0x00574238 File Offset: 0x00572438
		public int LevelTag { get; set; }

		// Token: 0x1700B039 RID: 45113
		// (get) Token: 0x06027DEB RID: 163307 RVA: 0x00574241 File Offset: 0x00572441
		// (set) Token: 0x06027DEC RID: 163308 RVA: 0x00574249 File Offset: 0x00572449
		public ESceneInteractionState SceneInteractionState { get; set; }

		// Token: 0x06027DED RID: 163309 RVA: 0x00574252 File Offset: 0x00572452
		public IPrefabStateConfigT()
		{
			this.LevelTag = 0;
			this.SceneInteractionState = ESceneInteractionState.State1;
		}
	}
}
