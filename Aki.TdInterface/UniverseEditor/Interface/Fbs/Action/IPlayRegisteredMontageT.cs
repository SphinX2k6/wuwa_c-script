using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D36 RID: 27958
	public class IPlayRegisteredMontageT
	{
		// Token: 0x1700D059 RID: 53337
		// (get) Token: 0x06031563 RID: 202083 RVA: 0x006B116C File Offset: 0x006AF36C
		// (set) Token: 0x06031564 RID: 202084 RVA: 0x006B1174 File Offset: 0x006AF374
		public int EntityId { get; set; }

		// Token: 0x1700D05A RID: 53338
		// (get) Token: 0x06031565 RID: 202085 RVA: 0x006B117D File Offset: 0x006AF37D
		// (set) Token: 0x06031566 RID: 202086 RVA: 0x006B1185 File Offset: 0x006AF385
		public int MontageId { get; set; }

		// Token: 0x1700D05B RID: 53339
		// (get) Token: 0x06031567 RID: 202087 RVA: 0x006B118E File Offset: 0x006AF38E
		// (set) Token: 0x06031568 RID: 202088 RVA: 0x006B1196 File Offset: 0x006AF396
		public bool IsOverlayMontage { get; set; }

		// Token: 0x1700D05C RID: 53340
		// (get) Token: 0x06031569 RID: 202089 RVA: 0x006B119F File Offset: 0x006AF39F
		// (set) Token: 0x0603156A RID: 202090 RVA: 0x006B11A7 File Offset: 0x006AF3A7
		public bool IsAbpMontage { get; set; }

		// Token: 0x1700D05D RID: 53341
		// (get) Token: 0x0603156B RID: 202091 RVA: 0x006B11B0 File Offset: 0x006AF3B0
		// (set) Token: 0x0603156C RID: 202092 RVA: 0x006B11B8 File Offset: 0x006AF3B8
		public int FaceExpressionId { get; set; }

		// Token: 0x1700D05E RID: 53342
		// (get) Token: 0x0603156D RID: 202093 RVA: 0x006B11C1 File Offset: 0x006AF3C1
		// (set) Token: 0x0603156E RID: 202094 RVA: 0x006B11C9 File Offset: 0x006AF3C9
		public float LoopDuration { get; set; }

		// Token: 0x1700D05F RID: 53343
		// (get) Token: 0x0603156F RID: 202095 RVA: 0x006B11D2 File Offset: 0x006AF3D2
		// (set) Token: 0x06031570 RID: 202096 RVA: 0x006B11DA File Offset: 0x006AF3DA
		public int RepeatTimes { get; set; }

		// Token: 0x1700D060 RID: 53344
		// (get) Token: 0x06031571 RID: 202097 RVA: 0x006B11E3 File Offset: 0x006AF3E3
		// (set) Token: 0x06031572 RID: 202098 RVA: 0x006B11EB File Offset: 0x006AF3EB
		public bool KeepMontageWhenEnd { get; set; }

		// Token: 0x1700D061 RID: 53345
		// (get) Token: 0x06031573 RID: 202099 RVA: 0x006B11F4 File Offset: 0x006AF3F4
		// (set) Token: 0x06031574 RID: 202100 RVA: 0x006B11FC File Offset: 0x006AF3FC
		public bool KeepMontageAfterFlow { get; set; }

		// Token: 0x1700D062 RID: 53346
		// (get) Token: 0x06031575 RID: 202101 RVA: 0x006B1205 File Offset: 0x006AF405
		// (set) Token: 0x06031576 RID: 202102 RVA: 0x006B120D File Offset: 0x006AF40D
		public byte NullMask { get; set; }

		// Token: 0x06031577 RID: 202103 RVA: 0x006B1218 File Offset: 0x006AF418
		public IPlayRegisteredMontageT()
		{
			this.EntityId = 0;
			this.MontageId = 0;
			this.IsOverlayMontage = false;
			this.IsAbpMontage = false;
			this.FaceExpressionId = 0;
			this.LoopDuration = 0f;
			this.RepeatTimes = 0;
			this.KeepMontageWhenEnd = false;
			this.KeepMontageAfterFlow = false;
			this.NullMask = 0;
		}
	}
}
