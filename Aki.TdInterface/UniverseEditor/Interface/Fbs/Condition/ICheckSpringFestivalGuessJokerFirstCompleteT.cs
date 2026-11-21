using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005014 RID: 20500
	public class ICheckSpringFestivalGuessJokerFirstCompleteT
	{
		// Token: 0x170092AE RID: 37550
		// (get) Token: 0x0602000B RID: 131083 RVA: 0x00470E78 File Offset: 0x0046F078
		// (set) Token: 0x0602000C RID: 131084 RVA: 0x00470E80 File Offset: 0x0046F080
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x170092AF RID: 37551
		// (get) Token: 0x0602000D RID: 131085 RVA: 0x00470E89 File Offset: 0x0046F089
		// (set) Token: 0x0602000E RID: 131086 RVA: 0x00470E91 File Offset: 0x0046F091
		public int LevelId { get; set; }

		// Token: 0x0602000F RID: 131087 RVA: 0x00470E9A File Offset: 0x0046F09A
		public ICheckSpringFestivalGuessJokerFirstCompleteT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
			this.LevelId = 0;
		}
	}
}
