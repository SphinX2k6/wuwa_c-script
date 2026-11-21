using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200567D RID: 22141
	public class IEffectSplineCreationModeT
	{
		// Token: 0x17009F30 RID: 40752
		// (get) Token: 0x060236A0 RID: 145056 RVA: 0x004DF05A File Offset: 0x004DD25A
		// (set) Token: 0x060236A1 RID: 145057 RVA: 0x004DF062 File Offset: 0x004DD262
		public EEffectSplineCreateMode Type { get; set; }

		// Token: 0x060236A2 RID: 145058 RVA: 0x004DF06B File Offset: 0x004DD26B
		public IEffectSplineCreationModeT()
		{
			this.Type = EEffectSplineCreateMode.WholeLine;
		}
	}
}
