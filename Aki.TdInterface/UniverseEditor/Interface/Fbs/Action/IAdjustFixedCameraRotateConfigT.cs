using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006153 RID: 24915
	public class IAdjustFixedCameraRotateConfigT
	{
		// Token: 0x1700B8D7 RID: 47319
		// (get) Token: 0x0602AC64 RID: 175204 RVA: 0x005E5908 File Offset: 0x005E3B08
		// (set) Token: 0x0602AC65 RID: 175205 RVA: 0x005E5910 File Offset: 0x005E3B10
		public float YawLimitMin { get; set; }

		// Token: 0x1700B8D8 RID: 47320
		// (get) Token: 0x0602AC66 RID: 175206 RVA: 0x005E5919 File Offset: 0x005E3B19
		// (set) Token: 0x0602AC67 RID: 175207 RVA: 0x005E5921 File Offset: 0x005E3B21
		public float YawLimitMax { get; set; }

		// Token: 0x1700B8D9 RID: 47321
		// (get) Token: 0x0602AC68 RID: 175208 RVA: 0x005E592A File Offset: 0x005E3B2A
		// (set) Token: 0x0602AC69 RID: 175209 RVA: 0x005E5932 File Offset: 0x005E3B32
		public float PitchLimitMin { get; set; }

		// Token: 0x1700B8DA RID: 47322
		// (get) Token: 0x0602AC6A RID: 175210 RVA: 0x005E593B File Offset: 0x005E3B3B
		// (set) Token: 0x0602AC6B RID: 175211 RVA: 0x005E5943 File Offset: 0x005E3B43
		public float PitchLimitMax { get; set; }

		// Token: 0x1700B8DB RID: 47323
		// (get) Token: 0x0602AC6C RID: 175212 RVA: 0x005E594C File Offset: 0x005E3B4C
		// (set) Token: 0x0602AC6D RID: 175213 RVA: 0x005E5954 File Offset: 0x005E3B54
		public float YawRotateSpeed { get; set; }

		// Token: 0x1700B8DC RID: 47324
		// (get) Token: 0x0602AC6E RID: 175214 RVA: 0x005E595D File Offset: 0x005E3B5D
		// (set) Token: 0x0602AC6F RID: 175215 RVA: 0x005E5965 File Offset: 0x005E3B65
		public float PitchRotateSpeed { get; set; }

		// Token: 0x0602AC70 RID: 175216 RVA: 0x005E5970 File Offset: 0x005E3B70
		public IAdjustFixedCameraRotateConfigT()
		{
			this.YawLimitMin = 0f;
			this.YawLimitMax = 0f;
			this.PitchLimitMin = 0f;
			this.PitchLimitMax = 0f;
			this.YawRotateSpeed = 0f;
			this.PitchRotateSpeed = 0f;
		}
	}
}
