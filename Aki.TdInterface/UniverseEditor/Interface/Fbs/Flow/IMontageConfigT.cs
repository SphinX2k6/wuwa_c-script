using System;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004BA8 RID: 19368
	public class IMontageConfigT
	{
		// Token: 0x1700891E RID: 35102
		// (get) Token: 0x0601D8E2 RID: 121058 RVA: 0x00426417 File Offset: 0x00424617
		// (set) Token: 0x0601D8E3 RID: 121059 RVA: 0x0042641F File Offset: 0x0042461F
		public int Id { get; set; }

		// Token: 0x1700891F RID: 35103
		// (get) Token: 0x0601D8E4 RID: 121060 RVA: 0x00426428 File Offset: 0x00424628
		// (set) Token: 0x0601D8E5 RID: 121061 RVA: 0x00426430 File Offset: 0x00424630
		public string ActionMontage { get; set; }

		// Token: 0x17008920 RID: 35104
		// (get) Token: 0x0601D8E6 RID: 121062 RVA: 0x00426439 File Offset: 0x00424639
		// (set) Token: 0x0601D8E7 RID: 121063 RVA: 0x00426441 File Offset: 0x00424641
		public string ExpressionMontage { get; set; }

		// Token: 0x17008921 RID: 35105
		// (get) Token: 0x0601D8E8 RID: 121064 RVA: 0x0042644A File Offset: 0x0042464A
		// (set) Token: 0x0601D8E9 RID: 121065 RVA: 0x00426452 File Offset: 0x00424652
		public string MouthSequence { get; set; }

		// Token: 0x17008922 RID: 35106
		// (get) Token: 0x0601D8EA RID: 121066 RVA: 0x0042645B File Offset: 0x0042465B
		// (set) Token: 0x0601D8EB RID: 121067 RVA: 0x00426463 File Offset: 0x00424663
		public string InitState { get; set; }

		// Token: 0x17008923 RID: 35107
		// (get) Token: 0x0601D8EC RID: 121068 RVA: 0x0042646C File Offset: 0x0042466C
		// (set) Token: 0x0601D8ED RID: 121069 RVA: 0x00426474 File Offset: 0x00424674
		public string EndState { get; set; }

		// Token: 0x17008924 RID: 35108
		// (get) Token: 0x0601D8EE RID: 121070 RVA: 0x0042647D File Offset: 0x0042467D
		// (set) Token: 0x0601D8EF RID: 121071 RVA: 0x00426485 File Offset: 0x00424685
		public bool DisableBlinkCurve { get; set; }

		// Token: 0x17008925 RID: 35109
		// (get) Token: 0x0601D8F0 RID: 121072 RVA: 0x0042648E File Offset: 0x0042468E
		// (set) Token: 0x0601D8F1 RID: 121073 RVA: 0x00426496 File Offset: 0x00424696
		public string MaleVariant { get; set; }

		// Token: 0x17008926 RID: 35110
		// (get) Token: 0x0601D8F2 RID: 121074 RVA: 0x0042649F File Offset: 0x0042469F
		// (set) Token: 0x0601D8F3 RID: 121075 RVA: 0x004264A7 File Offset: 0x004246A7
		public byte NullMask { get; set; }

		// Token: 0x0601D8F4 RID: 121076 RVA: 0x004264B0 File Offset: 0x004246B0
		public IMontageConfigT()
		{
			this.Id = 0;
			this.ActionMontage = null;
			this.ExpressionMontage = null;
			this.MouthSequence = null;
			this.InitState = null;
			this.EndState = null;
			this.DisableBlinkCurve = false;
			this.MaleVariant = null;
			this.NullMask = 0;
		}
	}
}
