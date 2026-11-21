using System;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D83 RID: 23939
	public class IPrefabEffectConfigT
	{
		// Token: 0x1700B033 RID: 45107
		// (get) Token: 0x06027DD3 RID: 163283 RVA: 0x00574030 File Offset: 0x00572230
		// (set) Token: 0x06027DD4 RID: 163284 RVA: 0x00574038 File Offset: 0x00572238
		public int LevelTag { get; set; }

		// Token: 0x1700B034 RID: 45108
		// (get) Token: 0x06027DD5 RID: 163285 RVA: 0x00574041 File Offset: 0x00572241
		// (set) Token: 0x06027DD6 RID: 163286 RVA: 0x00574049 File Offset: 0x00572249
		public ESceneInteractionEffectState SceneInteractionEffectState { get; set; }

		// Token: 0x06027DD7 RID: 163287 RVA: 0x00574052 File Offset: 0x00572252
		public IPrefabEffectConfigT()
		{
			this.LevelTag = 0;
			this.SceneInteractionEffectState = ESceneInteractionEffectState.Effect0;
		}
	}
}
