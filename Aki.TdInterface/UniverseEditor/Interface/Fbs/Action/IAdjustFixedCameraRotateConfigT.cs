using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067B8 RID: 26552
	public class IAdjustFixedCameraRotateConfigT
	{
		// Token: 0x1700C247 RID: 49735
		// (get) Token: 0x0602D35D RID: 185181 RVA: 0x0062FAE4 File Offset: 0x0062DCE4
		// (set) Token: 0x0602D35E RID: 185182 RVA: 0x0062FAEC File Offset: 0x0062DCEC
		public float YawLimitMin { get; set; }

		// Token: 0x1700C248 RID: 49736
		// (get) Token: 0x0602D35F RID: 185183 RVA: 0x0062FAF5 File Offset: 0x0062DCF5
		// (set) Token: 0x0602D360 RID: 185184 RVA: 0x0062FAFD File Offset: 0x0062DCFD
		public float YawLimitMax { get; set; }

		// Token: 0x1700C249 RID: 49737
		// (get) Token: 0x0602D361 RID: 185185 RVA: 0x0062FB06 File Offset: 0x0062DD06
		// (set) Token: 0x0602D362 RID: 185186 RVA: 0x0062FB0E File Offset: 0x0062DD0E
		public float PitchLimitMin { get; set; }

		// Token: 0x1700C24A RID: 49738
		// (get) Token: 0x0602D363 RID: 185187 RVA: 0x0062FB17 File Offset: 0x0062DD17
		// (set) Token: 0x0602D364 RID: 185188 RVA: 0x0062FB1F File Offset: 0x0062DD1F
		public float PitchLimitMax { get; set; }

		// Token: 0x1700C24B RID: 49739
		// (get) Token: 0x0602D365 RID: 185189 RVA: 0x0062FB28 File Offset: 0x0062DD28
		// (set) Token: 0x0602D366 RID: 185190 RVA: 0x0062FB30 File Offset: 0x0062DD30
		public float YawRotateSpeed { get; set; }

		// Token: 0x1700C24C RID: 49740
		// (get) Token: 0x0602D367 RID: 185191 RVA: 0x0062FB39 File Offset: 0x0062DD39
		// (set) Token: 0x0602D368 RID: 185192 RVA: 0x0062FB41 File Offset: 0x0062DD41
		public float PitchRotateSpeed { get; set; }

		// Token: 0x0602D369 RID: 185193 RVA: 0x0062FB4C File Offset: 0x0062DD4C
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
