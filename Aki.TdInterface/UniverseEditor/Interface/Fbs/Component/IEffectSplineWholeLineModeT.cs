using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005686 RID: 22150
	public class IEffectSplineWholeLineModeT
	{
		// Token: 0x17009F3A RID: 40762
		// (get) Token: 0x060236D6 RID: 145110 RVA: 0x004DF51A File Offset: 0x004DD71A
		// (set) Token: 0x060236D7 RID: 145111 RVA: 0x004DF522 File Offset: 0x004DD722
		public EEffectSplineCreateMode Type { get; set; }

		// Token: 0x060236D8 RID: 145112 RVA: 0x004DF52B File Offset: 0x004DD72B
		public IEffectSplineWholeLineModeT()
		{
			this.Type = EEffectSplineCreateMode.WholeLine;
		}
	}
}
