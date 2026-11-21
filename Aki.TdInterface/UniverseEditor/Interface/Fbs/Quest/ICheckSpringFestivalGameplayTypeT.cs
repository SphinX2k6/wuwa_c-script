using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200417F RID: 16767
	public class ICheckSpringFestivalGameplayTypeT
	{
		// Token: 0x1700719D RID: 29085
		// (get) Token: 0x0601714B RID: 94539 RVA: 0x0034A512 File Offset: 0x00348712
		// (set) Token: 0x0601714C RID: 94540 RVA: 0x0034A51A File Offset: 0x0034871A
		public ESpringFestivalGameplayType Type { get; set; }

		// Token: 0x0601714D RID: 94541 RVA: 0x0034A523 File Offset: 0x00348723
		public ICheckSpringFestivalGameplayTypeT()
		{
			this.Type = ESpringFestivalGameplayType.MixDrinks;
		}
	}
}
