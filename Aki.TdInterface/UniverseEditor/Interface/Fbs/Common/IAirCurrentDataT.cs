using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D0E RID: 23822
	public class IAirCurrentDataT
	{
		// Token: 0x1700B27E RID: 45694
		// (get) Token: 0x06028B11 RID: 166673 RVA: 0x00596F35 File Offset: 0x00595135
		// (set) Token: 0x06028B12 RID: 166674 RVA: 0x00596F3D File Offset: 0x0059513D
		public EAreaFunctionType Type { get; set; }

		// Token: 0x1700B27F RID: 45695
		// (get) Token: 0x06028B13 RID: 166675 RVA: 0x00596F46 File Offset: 0x00595146
		// (set) Token: 0x06028B14 RID: 166676 RVA: 0x00596F4E File Offset: 0x0059514E
		public float ExitEffectHeight { get; set; }

		// Token: 0x1700B280 RID: 45696
		// (get) Token: 0x06028B15 RID: 166677 RVA: 0x00596F57 File Offset: 0x00595157
		// (set) Token: 0x06028B16 RID: 166678 RVA: 0x00596F5F File Offset: 0x0059515F
		public float EffectiveHeight { get; set; }

		// Token: 0x1700B281 RID: 45697
		// (get) Token: 0x06028B17 RID: 166679 RVA: 0x00596F68 File Offset: 0x00595168
		// (set) Token: 0x06028B18 RID: 166680 RVA: 0x00596F70 File Offset: 0x00595170
		public float FallTeleportHeight { get; set; }

		// Token: 0x1700B282 RID: 45698
		// (get) Token: 0x06028B19 RID: 166681 RVA: 0x00596F79 File Offset: 0x00595179
		// (set) Token: 0x06028B1A RID: 166682 RVA: 0x00596F81 File Offset: 0x00595181
		public int FallTeleportTransitionConfigId { get; set; }

		// Token: 0x1700B283 RID: 45699
		// (get) Token: 0x06028B1B RID: 166683 RVA: 0x00596F8A File Offset: 0x0059518A
		// (set) Token: 0x06028B1C RID: 166684 RVA: 0x00596F92 File Offset: 0x00595192
		public float TopTeleportHeight { get; set; }

		// Token: 0x1700B284 RID: 45700
		// (get) Token: 0x06028B1D RID: 166685 RVA: 0x00596F9B File Offset: 0x0059519B
		// (set) Token: 0x06028B1E RID: 166686 RVA: 0x00596FA3 File Offset: 0x005951A3
		public IMotorAirCurrentConfigT Motor { get; set; }

		// Token: 0x1700B285 RID: 45701
		// (get) Token: 0x06028B1F RID: 166687 RVA: 0x00596FAC File Offset: 0x005951AC
		// (set) Token: 0x06028B20 RID: 166688 RVA: 0x00596FB4 File Offset: 0x005951B4
		public ICharacterAirCurrentConfigT Character { get; set; }

		// Token: 0x1700B286 RID: 45702
		// (get) Token: 0x06028B21 RID: 166689 RVA: 0x00596FBD File Offset: 0x005951BD
		// (set) Token: 0x06028B22 RID: 166690 RVA: 0x00596FC5 File Offset: 0x005951C5
		public byte NullMask { get; set; }

		// Token: 0x06028B23 RID: 166691 RVA: 0x00596FD0 File Offset: 0x005951D0
		public IAirCurrentDataT()
		{
			this.Type = EAreaFunctionType.AirCurrent;
			this.ExitEffectHeight = 0f;
			this.EffectiveHeight = 0f;
			this.FallTeleportHeight = 0f;
			this.FallTeleportTransitionConfigId = 0;
			this.TopTeleportHeight = 0f;
			this.Motor = null;
			this.Character = null;
			this.NullMask = 0;
		}
	}
}
