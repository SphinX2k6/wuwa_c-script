using System;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02006975 RID: 26997
	public class IFauxPhysicsFreeRotateParam : IFauxPhysicsRotateParam
	{
		// Token: 0x1700981C RID: 38940
		// (get) Token: 0x06043342 RID: 275266 RVA: 0x01062466 File Offset: 0x01060666
		// (set) Token: 0x06043343 RID: 275267 RVA: 0x0106246E File Offset: 0x0106066E
		public EFauxPhysicsRotateParam Type { get; set; }

		// Token: 0x1700981D RID: 38941
		// (get) Token: 0x06043344 RID: 275268 RVA: 0x01062477 File Offset: 0x01060677
		// (set) Token: 0x06043345 RID: 275269 RVA: 0x0106247F File Offset: 0x0106067F
		public FVector? Origin { get; set; }

		// Token: 0x1700981E RID: 38942
		// (get) Token: 0x06043346 RID: 275270 RVA: 0x01062488 File Offset: 0x01060688
		// (set) Token: 0x06043347 RID: 275271 RVA: 0x01062490 File Offset: 0x01060690
		public FVector? RelativeOffset { get; set; }

		// Token: 0x1700981F RID: 38943
		// (get) Token: 0x06043348 RID: 275272 RVA: 0x01062499 File Offset: 0x01060699
		// (set) Token: 0x06043349 RID: 275273 RVA: 0x010624A1 File Offset: 0x010606A1
		public FVector? Force { get; set; }

		// Token: 0x17009820 RID: 38944
		// (get) Token: 0x0604334A RID: 275274 RVA: 0x010624AA File Offset: 0x010606AA
		// (set) Token: 0x0604334B RID: 275275 RVA: 0x010624B2 File Offset: 0x010606B2
		public FVector? Impulse { get; set; }

		// Token: 0x17009821 RID: 38945
		// (get) Token: 0x0604334C RID: 275276 RVA: 0x010624BB File Offset: 0x010606BB
		// (set) Token: 0x0604334D RID: 275277 RVA: 0x010624C3 File Offset: 0x010606C3
		public FVector? Movement { get; set; }
	}
}
