using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x0200697D RID: 27005
	[NullableContext(1)]
	[Nullable(0)]
	public class SpawnDestructibleActorWithTrackCapability
	{
		// Token: 0x1700982B RID: 38955
		// (get) Token: 0x06043366 RID: 275302 RVA: 0x0106259B File Offset: 0x0106079B
		// (set) Token: 0x06043367 RID: 275303 RVA: 0x010625A3 File Offset: 0x010607A3
		public string KuroDestructibleAsset { get; set; }

		// Token: 0x1700982C RID: 38956
		// (get) Token: 0x06043368 RID: 275304 RVA: 0x010625AC File Offset: 0x010607AC
		// (set) Token: 0x06043369 RID: 275305 RVA: 0x010625B4 File Offset: 0x010607B4
		public string KuroDestructibleDestructionAsset { get; set; }

		// Token: 0x1700982D RID: 38957
		// (get) Token: 0x0604336A RID: 275306 RVA: 0x010625BD File Offset: 0x010607BD
		// (set) Token: 0x0604336B RID: 275307 RVA: 0x010625C5 File Offset: 0x010607C5
		public FTransformDouble StartTransform { get; set; }

		// Token: 0x1700982E RID: 38958
		// (get) Token: 0x0604336C RID: 275308 RVA: 0x010625CE File Offset: 0x010607CE
		// (set) Token: 0x0604336D RID: 275309 RVA: 0x010625D6 File Offset: 0x010607D6
		public float TrackSpeed { get; set; }

		// Token: 0x1700982F RID: 38959
		// (get) Token: 0x0604336E RID: 275310 RVA: 0x010625DF File Offset: 0x010607DF
		// (set) Token: 0x0604336F RID: 275311 RVA: 0x010625E7 File Offset: 0x010607E7
		public ETrackMethod TrackMethod { get; set; }

		// Token: 0x17009830 RID: 38960
		// (get) Token: 0x06043370 RID: 275312 RVA: 0x010625F0 File Offset: 0x010607F0
		// (set) Token: 0x06043371 RID: 275313 RVA: 0x010625F8 File Offset: 0x010607F8
		public float TrackPredictionFactor { get; set; }

		// Token: 0x17009831 RID: 38961
		// (get) Token: 0x06043372 RID: 275314 RVA: 0x01062601 File Offset: 0x01060801
		// (set) Token: 0x06043373 RID: 275315 RVA: 0x01062609 File Offset: 0x01060809
		public float StopTrackTargetDistance { get; set; }

		// Token: 0x17009832 RID: 38962
		// (get) Token: 0x06043374 RID: 275316 RVA: 0x01062612 File Offset: 0x01060812
		// (set) Token: 0x06043375 RID: 275317 RVA: 0x0106261A File Offset: 0x0106081A
		[Nullable(2)]
		public APawn TargetToTrack { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17009833 RID: 38963
		// (get) Token: 0x06043376 RID: 275318 RVA: 0x01062623 File Offset: 0x01060823
		// (set) Token: 0x06043377 RID: 275319 RVA: 0x0106262B File Offset: 0x0106082B
		public FTransform ModelTransform { get; set; }

		// Token: 0x17009834 RID: 38964
		// (get) Token: 0x06043378 RID: 275320 RVA: 0x01062634 File Offset: 0x01060834
		// (set) Token: 0x06043379 RID: 275321 RVA: 0x0106263C File Offset: 0x0106083C
		public IFauxPhysicsRotateParam RotateParam { get; set; }

		// Token: 0x17009835 RID: 38965
		// (get) Token: 0x0604337A RID: 275322 RVA: 0x01062645 File Offset: 0x01060845
		// (set) Token: 0x0604337B RID: 275323 RVA: 0x0106264D File Offset: 0x0106084D
		public int DamageAmount { get; set; }

		// Token: 0x17009836 RID: 38966
		// (get) Token: 0x0604337C RID: 275324 RVA: 0x01062656 File Offset: 0x01060856
		// (set) Token: 0x0604337D RID: 275325 RVA: 0x0106265E File Offset: 0x0106085E
		public int? HitBuff { get; set; }

		// Token: 0x17009837 RID: 38967
		// (get) Token: 0x0604337E RID: 275326 RVA: 0x01062667 File Offset: 0x01060867
		// (set) Token: 0x0604337F RID: 275327 RVA: 0x0106266F File Offset: 0x0106086F
		public int? RevertMaxHp { get; set; }
	}
}
