using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005683 RID: 22147
	public class IEffectSplineEquidistantPointModeT
	{
		// Token: 0x17009F36 RID: 40758
		// (get) Token: 0x060236C2 RID: 145090 RVA: 0x004DF37C File Offset: 0x004DD57C
		// (set) Token: 0x060236C3 RID: 145091 RVA: 0x004DF384 File Offset: 0x004DD584
		public EEffectSplineCreateMode Type { get; set; }

		// Token: 0x17009F37 RID: 40759
		// (get) Token: 0x060236C4 RID: 145092 RVA: 0x004DF38D File Offset: 0x004DD58D
		// (set) Token: 0x060236C5 RID: 145093 RVA: 0x004DF395 File Offset: 0x004DD595
		public int Space { get; set; }

		// Token: 0x060236C6 RID: 145094 RVA: 0x004DF39E File Offset: 0x004DD59E
		public IEffectSplineEquidistantPointModeT()
		{
			this.Type = EEffectSplineCreateMode.WholeLine;
			this.Space = 0;
		}
	}
}
