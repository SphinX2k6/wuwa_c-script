using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AA3 RID: 15011
	public class ILightPlateParamsT
	{
		// Token: 0x170066E4 RID: 26340
		// (get) Token: 0x06014630 RID: 83504 RVA: 0x002F9359 File Offset: 0x002F7559
		// (set) Token: 0x06014631 RID: 83505 RVA: 0x002F9361 File Offset: 0x002F7561
		public EParamsPreset Type { get; set; }

		// Token: 0x170066E5 RID: 26341
		// (get) Token: 0x06014632 RID: 83506 RVA: 0x002F936A File Offset: 0x002F756A
		// (set) Token: 0x06014633 RID: 83507 RVA: 0x002F9372 File Offset: 0x002F7572
		public float RayCastingDetectDis { get; set; }

		// Token: 0x170066E6 RID: 26342
		// (get) Token: 0x06014634 RID: 83508 RVA: 0x002F937B File Offset: 0x002F757B
		// (set) Token: 0x06014635 RID: 83509 RVA: 0x002F9383 File Offset: 0x002F7583
		public float MaxDegreeAngle { get; set; }

		// Token: 0x170066E7 RID: 26343
		// (get) Token: 0x06014636 RID: 83510 RVA: 0x002F938C File Offset: 0x002F758C
		// (set) Token: 0x06014637 RID: 83511 RVA: 0x002F9394 File Offset: 0x002F7594
		public float ReturnSpeedDegreePerSecond { get; set; }

		// Token: 0x170066E8 RID: 26344
		// (get) Token: 0x06014638 RID: 83512 RVA: 0x002F939D File Offset: 0x002F759D
		// (set) Token: 0x06014639 RID: 83513 RVA: 0x002F93A5 File Offset: 0x002F75A5
		public float FollowSpeedDegreePerSecond { get; set; }

		// Token: 0x170066E9 RID: 26345
		// (get) Token: 0x0601463A RID: 83514 RVA: 0x002F93AE File Offset: 0x002F75AE
		// (set) Token: 0x0601463B RID: 83515 RVA: 0x002F93B6 File Offset: 0x002F75B6
		public float MinActiveRadius { get; set; }

		// Token: 0x170066EA RID: 26346
		// (get) Token: 0x0601463C RID: 83516 RVA: 0x002F93BF File Offset: 0x002F75BF
		// (set) Token: 0x0601463D RID: 83517 RVA: 0x002F93C7 File Offset: 0x002F75C7
		public float MaxActiveRadius { get; set; }

		// Token: 0x170066EB RID: 26347
		// (get) Token: 0x0601463E RID: 83518 RVA: 0x002F93D0 File Offset: 0x002F75D0
		// (set) Token: 0x0601463F RID: 83519 RVA: 0x002F93D8 File Offset: 0x002F75D8
		public bool EnableLightPlate { get; set; }

		// Token: 0x170066EC RID: 26348
		// (get) Token: 0x06014640 RID: 83520 RVA: 0x002F93E1 File Offset: 0x002F75E1
		// (set) Token: 0x06014641 RID: 83521 RVA: 0x002F93E9 File Offset: 0x002F75E9
		public List<int> IgnoreEntities { get; set; }

		// Token: 0x170066ED RID: 26349
		// (get) Token: 0x06014642 RID: 83522 RVA: 0x002F93F2 File Offset: 0x002F75F2
		// (set) Token: 0x06014643 RID: 83523 RVA: 0x002F93FA File Offset: 0x002F75FA
		public bool DoNotNeedRayCasting { get; set; }

		// Token: 0x170066EE RID: 26350
		// (get) Token: 0x06014644 RID: 83524 RVA: 0x002F9403 File Offset: 0x002F7603
		// (set) Token: 0x06014645 RID: 83525 RVA: 0x002F940B File Offset: 0x002F760B
		public bool MultiPlateMode { get; set; }

		// Token: 0x170066EF RID: 26351
		// (get) Token: 0x06014646 RID: 83526 RVA: 0x002F9414 File Offset: 0x002F7614
		// (set) Token: 0x06014647 RID: 83527 RVA: 0x002F941C File Offset: 0x002F761C
		public bool LockCollisionMode { get; set; }

		// Token: 0x170066F0 RID: 26352
		// (get) Token: 0x06014648 RID: 83528 RVA: 0x002F9425 File Offset: 0x002F7625
		// (set) Token: 0x06014649 RID: 83529 RVA: 0x002F942D File Offset: 0x002F762D
		public byte NullMask { get; set; }

		// Token: 0x0601464A RID: 83530 RVA: 0x002F9438 File Offset: 0x002F7638
		public ILightPlateParamsT()
		{
			this.Type = EParamsPreset.Decal;
			this.RayCastingDetectDis = 0f;
			this.MaxDegreeAngle = 0f;
			this.ReturnSpeedDegreePerSecond = 0f;
			this.FollowSpeedDegreePerSecond = 0f;
			this.MinActiveRadius = 0f;
			this.MaxActiveRadius = 0f;
			this.EnableLightPlate = false;
			this.IgnoreEntities = null;
			this.DoNotNeedRayCasting = false;
			this.MultiPlateMode = false;
			this.LockCollisionMode = false;
			this.NullMask = 0;
		}
	}
}
