using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E97 RID: 20119
	public class ICheckDropCatchGameplayCompleteLevelT
	{
		// Token: 0x17008F82 RID: 36738
		// (get) Token: 0x0601F2D3 RID: 127699 RVA: 0x00458FE0 File Offset: 0x004571E0
		// (set) Token: 0x0601F2D4 RID: 127700 RVA: 0x00458FE8 File Offset: 0x004571E8
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x17008F83 RID: 36739
		// (get) Token: 0x0601F2D5 RID: 127701 RVA: 0x00458FF1 File Offset: 0x004571F1
		// (set) Token: 0x0601F2D6 RID: 127702 RVA: 0x00458FF9 File Offset: 0x004571F9
		public int LevelId { get; set; }

		// Token: 0x0601F2D7 RID: 127703 RVA: 0x00459002 File Offset: 0x00457202
		public ICheckDropCatchGameplayCompleteLevelT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
			this.LevelId = 0;
		}
	}
}
