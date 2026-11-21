using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B88 RID: 31624
	public class ITeleportTransitionInSeamlessTypeT
	{
		// Token: 0x1700ECC2 RID: 60610
		// (get) Token: 0x06038F52 RID: 233298 RVA: 0x007B2E9C File Offset: 0x007B109C
		// (set) Token: 0x06038F53 RID: 233299 RVA: 0x007B2EA4 File Offset: 0x007B10A4
		public ETeleportTransitionType Type { get; set; }

		// Token: 0x1700ECC3 RID: 60611
		// (get) Token: 0x06038F54 RID: 233300 RVA: 0x007B2EAD File Offset: 0x007B10AD
		// (set) Token: 0x06038F55 RID: 233301 RVA: 0x007B2EB5 File Offset: 0x007B10B5
		public string EffectDaPath { get; set; }

		// Token: 0x1700ECC4 RID: 60612
		// (get) Token: 0x06038F56 RID: 233302 RVA: 0x007B2EBE File Offset: 0x007B10BE
		// (set) Token: 0x06038F57 RID: 233303 RVA: 0x007B2EC6 File Offset: 0x007B10C6
		public float LeastTime { get; set; }

		// Token: 0x1700ECC5 RID: 60613
		// (get) Token: 0x06038F58 RID: 233304 RVA: 0x007B2ECF File Offset: 0x007B10CF
		// (set) Token: 0x06038F59 RID: 233305 RVA: 0x007B2ED7 File Offset: 0x007B10D7
		public float EffectExpandTime { get; set; }

		// Token: 0x1700ECC6 RID: 60614
		// (get) Token: 0x06038F5A RID: 233306 RVA: 0x007B2EE0 File Offset: 0x007B10E0
		// (set) Token: 0x06038F5B RID: 233307 RVA: 0x007B2EE8 File Offset: 0x007B10E8
		public float EffectCollapseTime { get; set; }

		// Token: 0x1700ECC7 RID: 60615
		// (get) Token: 0x06038F5C RID: 233308 RVA: 0x007B2EF1 File Offset: 0x007B10F1
		// (set) Token: 0x06038F5D RID: 233309 RVA: 0x007B2EF9 File Offset: 0x007B10F9
		public string SceneEffectDaPath { get; set; }

		// Token: 0x1700ECC8 RID: 60616
		// (get) Token: 0x06038F5E RID: 233310 RVA: 0x007B2F02 File Offset: 0x007B1102
		// (set) Token: 0x06038F5F RID: 233311 RVA: 0x007B2F0A File Offset: 0x007B110A
		public string TransitionWeatherDaPath { get; set; }

		// Token: 0x1700ECC9 RID: 60617
		// (get) Token: 0x06038F60 RID: 233312 RVA: 0x007B2F13 File Offset: 0x007B1113
		// (set) Token: 0x06038F61 RID: 233313 RVA: 0x007B2F1B File Offset: 0x007B111B
		public IFloorSettingsT FloorSettings { get; set; }

		// Token: 0x1700ECCA RID: 60618
		// (get) Token: 0x06038F62 RID: 233314 RVA: 0x007B2F24 File Offset: 0x007B1124
		// (set) Token: 0x06038F63 RID: 233315 RVA: 0x007B2F2C File Offset: 0x007B112C
		public bool IsTeleportInPlace { get; set; }

		// Token: 0x1700ECCB RID: 60619
		// (get) Token: 0x06038F64 RID: 233316 RVA: 0x007B2F35 File Offset: 0x007B1135
		// (set) Token: 0x06038F65 RID: 233317 RVA: 0x007B2F3D File Offset: 0x007B113D
		public List<EKeepMovementState> KeepMovementStates { get; set; }

		// Token: 0x1700ECCC RID: 60620
		// (get) Token: 0x06038F66 RID: 233318 RVA: 0x007B2F46 File Offset: 0x007B1146
		// (set) Token: 0x06038F67 RID: 233319 RVA: 0x007B2F4E File Offset: 0x007B114E
		public ISeamlessTeleportFinishConfigT SeamlessTeleportFinishConfig { get; set; }

		// Token: 0x1700ECCD RID: 60621
		// (get) Token: 0x06038F68 RID: 233320 RVA: 0x007B2F57 File Offset: 0x007B1157
		// (set) Token: 0x06038F69 RID: 233321 RVA: 0x007B2F5F File Offset: 0x007B115F
		public bool IsNormalStreamingLoad { get; set; }

		// Token: 0x1700ECCE RID: 60622
		// (get) Token: 0x06038F6A RID: 233322 RVA: 0x007B2F68 File Offset: 0x007B1168
		// (set) Token: 0x06038F6B RID: 233323 RVA: 0x007B2F70 File Offset: 0x007B1170
		public byte NullMask { get; set; }

		// Token: 0x06038F6C RID: 233324 RVA: 0x007B2F7C File Offset: 0x007B117C
		public ITeleportTransitionInSeamlessTypeT()
		{
			this.Type = ETeleportTransitionType.PlayMp4;
			this.EffectDaPath = null;
			this.LeastTime = 0f;
			this.EffectExpandTime = 0f;
			this.EffectCollapseTime = 0f;
			this.SceneEffectDaPath = null;
			this.TransitionWeatherDaPath = null;
			this.FloorSettings = null;
			this.IsTeleportInPlace = false;
			this.KeepMovementStates = null;
			this.SeamlessTeleportFinishConfig = null;
			this.IsNormalStreamingLoad = false;
			this.NullMask = 0;
		}
	}
}
