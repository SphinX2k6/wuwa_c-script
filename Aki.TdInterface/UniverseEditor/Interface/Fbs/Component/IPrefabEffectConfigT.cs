using System;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200577C RID: 22396
	public class IPrefabEffectConfigT
	{
		// Token: 0x1700A70F RID: 42767
		// (get) Token: 0x060258B3 RID: 153779 RVA: 0x0052DEA4 File Offset: 0x0052C0A4
		// (set) Token: 0x060258B4 RID: 153780 RVA: 0x0052DEAC File Offset: 0x0052C0AC
		public int LevelTag { get; set; }

		// Token: 0x1700A710 RID: 42768
		// (get) Token: 0x060258B5 RID: 153781 RVA: 0x0052DEB5 File Offset: 0x0052C0B5
		// (set) Token: 0x060258B6 RID: 153782 RVA: 0x0052DEBD File Offset: 0x0052C0BD
		public ESceneInteractionEffectState SceneInteractionEffectState { get; set; }

		// Token: 0x060258B7 RID: 153783 RVA: 0x0052DEC6 File Offset: 0x0052C0C6
		public IPrefabEffectConfigT()
		{
			this.LevelTag = 0;
			this.SceneInteractionEffectState = ESceneInteractionEffectState.Effect0;
		}
	}
}
