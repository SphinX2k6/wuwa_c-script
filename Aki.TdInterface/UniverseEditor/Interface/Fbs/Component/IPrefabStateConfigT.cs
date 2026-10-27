using System;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200577F RID: 22399
	public class IPrefabStateConfigT
	{
		// Token: 0x1700A714 RID: 42772
		// (get) Token: 0x060258C9 RID: 153801 RVA: 0x0052E0A4 File Offset: 0x0052C2A4
		// (set) Token: 0x060258CA RID: 153802 RVA: 0x0052E0AC File Offset: 0x0052C2AC
		public int LevelTag { get; set; }

		// Token: 0x1700A715 RID: 42773
		// (get) Token: 0x060258CB RID: 153803 RVA: 0x0052E0B5 File Offset: 0x0052C2B5
		// (set) Token: 0x060258CC RID: 153804 RVA: 0x0052E0BD File Offset: 0x0052C2BD
		public ESceneInteractionState SceneInteractionState { get; set; }

		// Token: 0x060258CD RID: 153805 RVA: 0x0052E0C6 File Offset: 0x0052C2C6
		public IPrefabStateConfigT()
		{
			this.LevelTag = 0;
			this.SceneInteractionState = ESceneInteractionState.State1;
		}
	}
}
