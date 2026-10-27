using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B2D RID: 19245
	public class ICheckSpringFestivalGuessJokerFirstCompleteT
	{
		// Token: 0x17008B9E RID: 35742
		// (get) Token: 0x0601E480 RID: 124032 RVA: 0x0043E6CC File Offset: 0x0043C8CC
		// (set) Token: 0x0601E481 RID: 124033 RVA: 0x0043E6D4 File Offset: 0x0043C8D4
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x17008B9F RID: 35743
		// (get) Token: 0x0601E482 RID: 124034 RVA: 0x0043E6DD File Offset: 0x0043C8DD
		// (set) Token: 0x0601E483 RID: 124035 RVA: 0x0043E6E5 File Offset: 0x0043C8E5
		public int LevelId { get; set; }

		// Token: 0x0601E484 RID: 124036 RVA: 0x0043E6EE File Offset: 0x0043C8EE
		public ICheckSpringFestivalGuessJokerFirstCompleteT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
			this.LevelId = 0;
		}
	}
}
