using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200522C RID: 21036
	public class IFanComponentT
	{
		// Token: 0x17009A1B RID: 39451
		// (get) Token: 0x06022355 RID: 140117 RVA: 0x004BF0EF File Offset: 0x004BD2EF
		// (set) Token: 0x06022356 RID: 140118 RVA: 0x004BF0F7 File Offset: 0x004BD2F7
		public bool Disabled { get; set; }

		// Token: 0x17009A1C RID: 39452
		// (get) Token: 0x06022357 RID: 140119 RVA: 0x004BF100 File Offset: 0x004BD300
		// (set) Token: 0x06022358 RID: 140120 RVA: 0x004BF108 File Offset: 0x004BD308
		public EFanGearType GearType { get; set; }

		// Token: 0x17009A1D RID: 39453
		// (get) Token: 0x06022359 RID: 140121 RVA: 0x004BF111 File Offset: 0x004BD311
		// (set) Token: 0x0602235A RID: 140122 RVA: 0x004BF119 File Offset: 0x004BD319
		public TFanInteractOptionUnion InteractType { get; set; }

		// Token: 0x17009A1E RID: 39454
		// (get) Token: 0x0602235B RID: 140123 RVA: 0x004BF122 File Offset: 0x004BD322
		// (set) Token: 0x0602235C RID: 140124 RVA: 0x004BF12A File Offset: 0x004BD32A
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17009A1F RID: 39455
		// (get) Token: 0x0602235D RID: 140125 RVA: 0x004BF133 File Offset: 0x004BD333
		// (set) Token: 0x0602235E RID: 140126 RVA: 0x004BF13B File Offset: 0x004BD33B
		public string RotateActor { get; set; }

		// Token: 0x17009A20 RID: 39456
		// (get) Token: 0x0602235F RID: 140127 RVA: 0x004BF144 File Offset: 0x004BD344
		// (set) Token: 0x06022360 RID: 140128 RVA: 0x004BF14C File Offset: 0x004BD34C
		public string OffsetActor { get; set; }

		// Token: 0x17009A21 RID: 39457
		// (get) Token: 0x06022361 RID: 140129 RVA: 0x004BF155 File Offset: 0x004BD355
		// (set) Token: 0x06022362 RID: 140130 RVA: 0x004BF15D File Offset: 0x004BD35D
		public int CirclePerRound { get; set; }

		// Token: 0x17009A22 RID: 39458
		// (get) Token: 0x06022363 RID: 140131 RVA: 0x004BF166 File Offset: 0x004BD366
		// (set) Token: 0x06022364 RID: 140132 RVA: 0x004BF16E File Offset: 0x004BD36E
		public int InitCircle { get; set; }

		// Token: 0x17009A23 RID: 39459
		// (get) Token: 0x06022365 RID: 140133 RVA: 0x004BF177 File Offset: 0x004BD377
		// (set) Token: 0x06022366 RID: 140134 RVA: 0x004BF17F File Offset: 0x004BD37F
		public int TargetEntityId { get; set; }

		// Token: 0x17009A24 RID: 39460
		// (get) Token: 0x06022367 RID: 140135 RVA: 0x004BF188 File Offset: 0x004BD388
		// (set) Token: 0x06022368 RID: 140136 RVA: 0x004BF190 File Offset: 0x004BD390
		public IFanEffectConfigT EffectConfig { get; set; }

		// Token: 0x17009A25 RID: 39461
		// (get) Token: 0x06022369 RID: 140137 RVA: 0x004BF199 File Offset: 0x004BD399
		// (set) Token: 0x0602236A RID: 140138 RVA: 0x004BF1A1 File Offset: 0x004BD3A1
		public List<IFanStateEffectT> EffectByState { get; set; }

		// Token: 0x17009A26 RID: 39462
		// (get) Token: 0x0602236B RID: 140139 RVA: 0x004BF1AA File Offset: 0x004BD3AA
		// (set) Token: 0x0602236C RID: 140140 RVA: 0x004BF1B2 File Offset: 0x004BD3B2
		public byte NullMask { get; set; }

		// Token: 0x0602236D RID: 140141 RVA: 0x004BF1BC File Offset: 0x004BD3BC
		public IFanComponentT()
		{
			this.Disabled = false;
			this.GearType = EFanGearType.ReboundPlateGear;
			this.InteractType = null;
			this.Condition = null;
			this.RotateActor = null;
			this.OffsetActor = null;
			this.CirclePerRound = 0;
			this.InitCircle = 0;
			this.TargetEntityId = 0;
			this.EffectConfig = null;
			this.EffectByState = null;
			this.NullMask = 0;
		}
	}
}
