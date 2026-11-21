using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DB3 RID: 32179
	public class IVisualNovelPerformancePortraitEffectT
	{
		// Token: 0x1700F0FD RID: 61693
		// (get) Token: 0x0603A237 RID: 238135 RVA: 0x007D6838 File Offset: 0x007D4A38
		// (set) Token: 0x0603A238 RID: 238136 RVA: 0x007D6840 File Offset: 0x007D4A40
		public EVisualNovelPerformanceType Type { get; set; }

		// Token: 0x1700F0FE RID: 61694
		// (get) Token: 0x0603A239 RID: 238137 RVA: 0x007D6849 File Offset: 0x007D4A49
		// (set) Token: 0x0603A23A RID: 238138 RVA: 0x007D6851 File Offset: 0x007D4A51
		public float StartTime { get; set; }

		// Token: 0x1700F0FF RID: 61695
		// (get) Token: 0x0603A23B RID: 238139 RVA: 0x007D685A File Offset: 0x007D4A5A
		// (set) Token: 0x0603A23C RID: 238140 RVA: 0x007D6862 File Offset: 0x007D4A62
		public int WhoId { get; set; }

		// Token: 0x1700F100 RID: 61696
		// (get) Token: 0x0603A23D RID: 238141 RVA: 0x007D686B File Offset: 0x007D4A6B
		// (set) Token: 0x0603A23E RID: 238142 RVA: 0x007D6873 File Offset: 0x007D4A73
		public EVisualNovelPortraitEffectType EffectType { get; set; }

		// Token: 0x1700F101 RID: 61697
		// (get) Token: 0x0603A23F RID: 238143 RVA: 0x007D687C File Offset: 0x007D4A7C
		// (set) Token: 0x0603A240 RID: 238144 RVA: 0x007D6884 File Offset: 0x007D4A84
		public EVisualNovelAmplitude Amplitude { get; set; }

		// Token: 0x1700F102 RID: 61698
		// (get) Token: 0x0603A241 RID: 238145 RVA: 0x007D688D File Offset: 0x007D4A8D
		// (set) Token: 0x0603A242 RID: 238146 RVA: 0x007D6895 File Offset: 0x007D4A95
		public byte NullMask { get; set; }

		// Token: 0x0603A243 RID: 238147 RVA: 0x007D689E File Offset: 0x007D4A9E
		public IVisualNovelPerformancePortraitEffectT()
		{
			this.Type = EVisualNovelPerformanceType.Enter;
			this.StartTime = 0f;
			this.WhoId = 0;
			this.EffectType = EVisualNovelPortraitEffectType.Jump;
			this.Amplitude = EVisualNovelAmplitude.Small;
			this.NullMask = 0;
		}
	}
}
