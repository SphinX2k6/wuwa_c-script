using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078E2 RID: 30946
	public class ISingleAxisSpringArmSoftZoneConfigT
	{
		// Token: 0x1700E319 RID: 58137
		// (get) Token: 0x060367DF RID: 223199 RVA: 0x0074BB2A File Offset: 0x00749D2A
		// (set) Token: 0x060367E0 RID: 223200 RVA: 0x0074BB32 File Offset: 0x00749D32
		public float MaxOffsetDistance { get; set; }

		// Token: 0x1700E31A RID: 58138
		// (get) Token: 0x060367E1 RID: 223201 RVA: 0x0074BB3B File Offset: 0x00749D3B
		// (set) Token: 0x060367E2 RID: 223202 RVA: 0x0074BB43 File Offset: 0x00749D43
		public float MinOffsetDistance { get; set; }

		// Token: 0x1700E31B RID: 58139
		// (get) Token: 0x060367E3 RID: 223203 RVA: 0x0074BB4C File Offset: 0x00749D4C
		// (set) Token: 0x060367E4 RID: 223204 RVA: 0x0074BB54 File Offset: 0x00749D54
		public float MaxInterpolationSpeed { get; set; }

		// Token: 0x1700E31C RID: 58140
		// (get) Token: 0x060367E5 RID: 223205 RVA: 0x0074BB5D File Offset: 0x00749D5D
		// (set) Token: 0x060367E6 RID: 223206 RVA: 0x0074BB65 File Offset: 0x00749D65
		public float MinInterpolationSpeed { get; set; }

		// Token: 0x1700E31D RID: 58141
		// (get) Token: 0x060367E7 RID: 223207 RVA: 0x0074BB6E File Offset: 0x00749D6E
		// (set) Token: 0x060367E8 RID: 223208 RVA: 0x0074BB76 File Offset: 0x00749D76
		public byte NullMask { get; set; }

		// Token: 0x060367E9 RID: 223209 RVA: 0x0074BB7F File Offset: 0x00749D7F
		public ISingleAxisSpringArmSoftZoneConfigT()
		{
			this.MaxOffsetDistance = 0f;
			this.MinOffsetDistance = 0f;
			this.MaxInterpolationSpeed = 0f;
			this.MinInterpolationSpeed = 0f;
			this.NullMask = 0;
		}
	}
}
