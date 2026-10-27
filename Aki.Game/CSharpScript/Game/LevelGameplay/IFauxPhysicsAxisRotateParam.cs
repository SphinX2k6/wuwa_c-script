using System;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02006974 RID: 26996
	public class IFauxPhysicsAxisRotateParam : IFauxPhysicsRotateParam
	{
		// Token: 0x17009812 RID: 38930
		// (get) Token: 0x0604332D RID: 275245 RVA: 0x010623B4 File Offset: 0x010605B4
		// (set) Token: 0x0604332E RID: 275246 RVA: 0x010623BC File Offset: 0x010605BC
		public FVector? LocalRotationAxis { get; set; }

		// Token: 0x17009813 RID: 38931
		// (get) Token: 0x0604332F RID: 275247 RVA: 0x010623C5 File Offset: 0x010605C5
		// (set) Token: 0x06043330 RID: 275248 RVA: 0x010623CD File Offset: 0x010605CD
		public float? AngularForceRadians { get; set; }

		// Token: 0x17009814 RID: 38932
		// (get) Token: 0x06043331 RID: 275249 RVA: 0x010623D6 File Offset: 0x010605D6
		// (set) Token: 0x06043332 RID: 275250 RVA: 0x010623DE File Offset: 0x010605DE
		public float? AngularImpulseRadians { get; set; }

		// Token: 0x17009815 RID: 38933
		// (get) Token: 0x06043333 RID: 275251 RVA: 0x010623E7 File Offset: 0x010605E7
		// (set) Token: 0x06043334 RID: 275252 RVA: 0x010623EF File Offset: 0x010605EF
		public float? AngleMovementRadians { get; set; }

		// Token: 0x17009816 RID: 38934
		// (get) Token: 0x06043335 RID: 275253 RVA: 0x010623F8 File Offset: 0x010605F8
		// (set) Token: 0x06043336 RID: 275254 RVA: 0x01062400 File Offset: 0x01060600
		public EFauxPhysicsRotateParam Type { get; set; }

		// Token: 0x17009817 RID: 38935
		// (get) Token: 0x06043337 RID: 275255 RVA: 0x01062409 File Offset: 0x01060609
		// (set) Token: 0x06043338 RID: 275256 RVA: 0x01062411 File Offset: 0x01060611
		public FVector? Origin { get; set; }

		// Token: 0x17009818 RID: 38936
		// (get) Token: 0x06043339 RID: 275257 RVA: 0x0106241A File Offset: 0x0106061A
		// (set) Token: 0x0604333A RID: 275258 RVA: 0x01062422 File Offset: 0x01060622
		public FVector? RelativeOffset { get; set; }

		// Token: 0x17009819 RID: 38937
		// (get) Token: 0x0604333B RID: 275259 RVA: 0x0106242B File Offset: 0x0106062B
		// (set) Token: 0x0604333C RID: 275260 RVA: 0x01062433 File Offset: 0x01060633
		public FVector? Force { get; set; }

		// Token: 0x1700981A RID: 38938
		// (get) Token: 0x0604333D RID: 275261 RVA: 0x0106243C File Offset: 0x0106063C
		// (set) Token: 0x0604333E RID: 275262 RVA: 0x01062444 File Offset: 0x01060644
		public FVector? Impulse { get; set; }

		// Token: 0x1700981B RID: 38939
		// (get) Token: 0x0604333F RID: 275263 RVA: 0x0106244D File Offset: 0x0106064D
		// (set) Token: 0x06043340 RID: 275264 RVA: 0x01062455 File Offset: 0x01060655
		public FVector? Movement { get; set; }
	}
}
