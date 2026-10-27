using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007476 RID: 29814
	public class ITriggerDeadeyeModeT
	{
		// Token: 0x1700E24E RID: 57934
		// (get) Token: 0x060362C6 RID: 221894 RVA: 0x0075DAAA File Offset: 0x0075BCAA
		// (set) Token: 0x060362C7 RID: 221895 RVA: 0x0075DAB2 File Offset: 0x0075BCB2
		public IDeadeyeFollowShooterConfigT FollowShooterConfig { get; set; }

		// Token: 0x1700E24F RID: 57935
		// (get) Token: 0x060362C8 RID: 221896 RVA: 0x0075DABB File Offset: 0x0075BCBB
		// (set) Token: 0x060362C9 RID: 221897 RVA: 0x0075DAC3 File Offset: 0x0075BCC3
		public List<int> FocusOnTags { get; set; }

		// Token: 0x1700E250 RID: 57936
		// (get) Token: 0x060362CA RID: 221898 RVA: 0x0075DACC File Offset: 0x0075BCCC
		// (set) Token: 0x060362CB RID: 221899 RVA: 0x0075DAD4 File Offset: 0x0075BCD4
		public float FocusRadius { get; set; }

		// Token: 0x1700E251 RID: 57937
		// (get) Token: 0x060362CC RID: 221900 RVA: 0x0075DADD File Offset: 0x0075BCDD
		// (set) Token: 0x060362CD RID: 221901 RVA: 0x0075DAE5 File Offset: 0x0075BCE5
		public float TimeScale { get; set; }

		// Token: 0x1700E252 RID: 57938
		// (get) Token: 0x060362CE RID: 221902 RVA: 0x0075DAEE File Offset: 0x0075BCEE
		// (set) Token: 0x060362CF RID: 221903 RVA: 0x0075DAF6 File Offset: 0x0075BCF6
		public float TimeScaleTransitionTime { get; set; }

		// Token: 0x1700E253 RID: 57939
		// (get) Token: 0x060362D0 RID: 221904 RVA: 0x0075DAFF File Offset: 0x0075BCFF
		// (set) Token: 0x060362D1 RID: 221905 RVA: 0x0075DB07 File Offset: 0x0075BD07
		public IDeadeyeFadeOutConfigT FadeOutConfig { get; set; }

		// Token: 0x1700E254 RID: 57940
		// (get) Token: 0x060362D2 RID: 221906 RVA: 0x0075DB10 File Offset: 0x0075BD10
		// (set) Token: 0x060362D3 RID: 221907 RVA: 0x0075DB18 File Offset: 0x0075BD18
		public IDeadeyeEnergyConfigT EnergyConfig { get; set; }

		// Token: 0x1700E255 RID: 57941
		// (get) Token: 0x060362D4 RID: 221908 RVA: 0x0075DB21 File Offset: 0x0075BD21
		// (set) Token: 0x060362D5 RID: 221909 RVA: 0x0075DB29 File Offset: 0x0075BD29
		public IDeadeyeCameraConfigT DefaultLookAt { get; set; }

		// Token: 0x1700E256 RID: 57942
		// (get) Token: 0x060362D6 RID: 221910 RVA: 0x0075DB32 File Offset: 0x0075BD32
		// (set) Token: 0x060362D7 RID: 221911 RVA: 0x0075DB3A File Offset: 0x0075BD3A
		public IDeadEyeEffectConfigT EffectConfig { get; set; }

		// Token: 0x1700E257 RID: 57943
		// (get) Token: 0x060362D8 RID: 221912 RVA: 0x0075DB43 File Offset: 0x0075BD43
		// (set) Token: 0x060362D9 RID: 221913 RVA: 0x0075DB4B File Offset: 0x0075BD4B
		public string FinishSendSelfEvent { get; set; }

		// Token: 0x1700E258 RID: 57944
		// (get) Token: 0x060362DA RID: 221914 RVA: 0x0075DB54 File Offset: 0x0075BD54
		// (set) Token: 0x060362DB RID: 221915 RVA: 0x0075DB5C File Offset: 0x0075BD5C
		public byte NullMask { get; set; }

		// Token: 0x060362DC RID: 221916 RVA: 0x0075DB68 File Offset: 0x0075BD68
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
