using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005118 RID: 20760
	public class IEffectSplineCreationModeT
	{
		// Token: 0x17009743 RID: 38723
		// (get) Token: 0x0602174C RID: 137036 RVA: 0x004A50CE File Offset: 0x004A32CE
		// (set) Token: 0x0602174D RID: 137037 RVA: 0x004A50D6 File Offset: 0x004A32D6
		public EEffectSplineCreateMode Type { get; set; }

		// Token: 0x0602174E RID: 137038 RVA: 0x004A50DF File Offset: 0x004A32DF
		public IEffectSplineCreationModeT()
		{
			this.Type = EEffectSplineCreateMode.WholeLine;
		}
	}
}
