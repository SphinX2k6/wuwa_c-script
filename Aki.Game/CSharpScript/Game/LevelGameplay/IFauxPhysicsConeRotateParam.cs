using System;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02006976 RID: 26998
	public class IFauxPhysicsConeRotateParam : IFauxPhysicsRotateParam
	{
		// Token: 0x17009822 RID: 38946
		// (get) Token: 0x0604334F RID: 275279 RVA: 0x010624D4 File Offset: 0x010606D4
		// (set) Token: 0x06043350 RID: 275280 RVA: 0x010624DC File Offset: 0x010606DC
		private FVector? LocalConeDirection { get; set; }

		// Token: 0x17009823 RID: 38947
		// (get) Token: 0x06043351 RID: 275281 RVA: 0x010624E5 File Offset: 0x010606E5
		// (set) Token: 0x06043352 RID: 275282 RVA: 0x010624ED File Offset: 0x010606ED
		private float? ConeAngle { get; set; }

		// Token: 0x17009824 RID: 38948
		// (get) Token: 0x06043353 RID: 275283 RVA: 0x010624F6 File Offset: 0x010606F6
		// (set) Token: 0x06043354 RID: 275284 RVA: 0x010624FE File Offset: 0x010606FE
		public EFauxPhysicsRotateParam Type { get; set; }

		// Token: 0x17009825 RID: 38949
		// (get) Token: 0x06043355 RID: 275285 RVA: 0x01062507 File Offset: 0x01060707
		// (set) Token: 0x06043356 RID: 275286 RVA: 0x0106250F File Offset: 0x0106070F
		public FVector? Origin { get; set; }

		// Token: 0x17009826 RID: 38950
		// (get) Token: 0x06043357 RID: 275287 RVA: 0x01062518 File Offset: 0x01060718
		// (set) Token: 0x06043358 RID: 275288 RVA: 0x01062520 File Offset: 0x01060720
		public FVector? RelativeOffset { get; set; }

		// Token: 0x17009827 RID: 38951
		// (get) Token: 0x06043359 RID: 275289 RVA: 0x01062529 File Offset: 0x01060729
		// (set) Token: 0x0604335A RID: 275290 RVA: 0x01062531 File Offset: 0x01060731
		public FVector? Force { get; set; }

		// Token: 0x17009828 RID: 38952
		// (get) Token: 0x0604335B RID: 275291 RVA: 0x0106253A File Offset: 0x0106073A
		// (set) Token: 0x0604335C RID: 275292 RVA: 0x01062542 File Offset: 0x01060742
		public FVector? Impulse { get; set; }

		// Token: 0x17009829 RID: 38953
		// (get) Token: 0x0604335D RID: 275293 RVA: 0x0106254B File Offset: 0x0106074B
		// (set) Token: 0x0604335E RID: 275294 RVA: 0x01062553 File Offset: 0x01060753
		public FVector? Movement { get; set; }
	}
}
