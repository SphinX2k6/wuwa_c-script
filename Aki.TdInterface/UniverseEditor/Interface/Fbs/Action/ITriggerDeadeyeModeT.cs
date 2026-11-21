using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C69 RID: 31849
	public class ITriggerDeadeyeModeT
	{
		// Token: 0x1700EE6B RID: 61035
		// (get) Token: 0x060396AF RID: 235183 RVA: 0x007C07D6 File Offset: 0x007BE9D6
		// (set) Token: 0x060396B0 RID: 235184 RVA: 0x007C07DE File Offset: 0x007BE9DE
		public IDeadeyeFollowShooterConfigT FollowShooterConfig { get; set; }

		// Token: 0x1700EE6C RID: 61036
		// (get) Token: 0x060396B1 RID: 235185 RVA: 0x007C07E7 File Offset: 0x007BE9E7
		// (set) Token: 0x060396B2 RID: 235186 RVA: 0x007C07EF File Offset: 0x007BE9EF
		public List<int> FocusOnTags { get; set; }

		// Token: 0x1700EE6D RID: 61037
		// (get) Token: 0x060396B3 RID: 235187 RVA: 0x007C07F8 File Offset: 0x007BE9F8
		// (set) Token: 0x060396B4 RID: 235188 RVA: 0x007C0800 File Offset: 0x007BEA00
		public float FocusRadius { get; set; }

		// Token: 0x1700EE6E RID: 61038
		// (get) Token: 0x060396B5 RID: 235189 RVA: 0x007C0809 File Offset: 0x007BEA09
		// (set) Token: 0x060396B6 RID: 235190 RVA: 0x007C0811 File Offset: 0x007BEA11
		public float TimeScale { get; set; }

		// Token: 0x1700EE6F RID: 61039
		// (get) Token: 0x060396B7 RID: 235191 RVA: 0x007C081A File Offset: 0x007BEA1A
		// (set) Token: 0x060396B8 RID: 235192 RVA: 0x007C0822 File Offset: 0x007BEA22
		public float TimeScaleTransitionTime { get; set; }

		// Token: 0x1700EE70 RID: 61040
		// (get) Token: 0x060396B9 RID: 235193 RVA: 0x007C082B File Offset: 0x007BEA2B
		// (set) Token: 0x060396BA RID: 235194 RVA: 0x007C0833 File Offset: 0x007BEA33
		public IDeadeyeFadeOutConfigT FadeOutConfig { get; set; }

		// Token: 0x1700EE71 RID: 61041
		// (get) Token: 0x060396BB RID: 235195 RVA: 0x007C083C File Offset: 0x007BEA3C
		// (set) Token: 0x060396BC RID: 235196 RVA: 0x007C0844 File Offset: 0x007BEA44
		public IDeadeyeEnergyConfigT EnergyConfig { get; set; }

		// Token: 0x1700EE72 RID: 61042
		// (get) Token: 0x060396BD RID: 235197 RVA: 0x007C084D File Offset: 0x007BEA4D
		// (set) Token: 0x060396BE RID: 235198 RVA: 0x007C0855 File Offset: 0x007BEA55
		public IDeadeyeCameraConfigT DefaultLookAt { get; set; }

		// Token: 0x1700EE73 RID: 61043
		// (get) Token: 0x060396BF RID: 235199 RVA: 0x007C085E File Offset: 0x007BEA5E
		// (set) Token: 0x060396C0 RID: 235200 RVA: 0x007C0866 File Offset: 0x007BEA66
		public IDeadEyeEffectConfigT EffectConfig { get; set; }

		// Token: 0x1700EE74 RID: 61044
		// (get) Token: 0x060396C1 RID: 235201 RVA: 0x007C086F File Offset: 0x007BEA6F
		// (set) Token: 0x060396C2 RID: 235202 RVA: 0x007C0877 File Offset: 0x007BEA77
		public string FinishSendSelfEvent { get; set; }

		// Token: 0x1700EE75 RID: 61045
		// (get) Token: 0x060396C3 RID: 235203 RVA: 0x007C0880 File Offset: 0x007BEA80
		// (set) Token: 0x060396C4 RID: 235204 RVA: 0x007C0888 File Offset: 0x007BEA88
		public byte NullMask { get; set; }

		// Token: 0x060396C5 RID: 235205 RVA: 0x007C0894 File Offset: 0x007BEA94
		public ITriggerDeadeyeModeT()
		{
			this.FollowShooterConfig = null;
			this.FocusOnTags = null;
			this.FocusRadius = 0f;
			this.TimeScale = 0f;
			this.TimeScaleTransitionTime = 0f;
			this.FadeOutConfig = null;
			this.EnergyConfig = null;
			this.DefaultLookAt = null;
			this.EffectConfig = null;
			this.FinishSendSelfEvent = null;
			this.NullMask = 0;
		}
	}
}
