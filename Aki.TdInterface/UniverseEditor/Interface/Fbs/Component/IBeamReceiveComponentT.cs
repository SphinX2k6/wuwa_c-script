using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F11 RID: 20241
	public class IBeamReceiveComponentT
	{
		// Token: 0x170091BC RID: 37308
		// (get) Token: 0x06020004 RID: 131076 RVA: 0x004742FA File Offset: 0x004724FA
		// (set) Token: 0x06020005 RID: 131077 RVA: 0x00474302 File Offset: 0x00472502
		public bool Disabled { get; set; }

		// Token: 0x170091BD RID: 37309
		// (get) Token: 0x06020006 RID: 131078 RVA: 0x0047430B File Offset: 0x0047250B
		// (set) Token: 0x06020007 RID: 131079 RVA: 0x00474313 File Offset: 0x00472513
		public string ReceiveTarget { get; set; }

		// Token: 0x170091BE RID: 37310
		// (get) Token: 0x06020008 RID: 131080 RVA: 0x0047431C File Offset: 0x0047251C
		// (set) Token: 0x06020009 RID: 131081 RVA: 0x00474324 File Offset: 0x00472524
		public float Duration { get; set; }

		// Token: 0x170091BF RID: 37311
		// (get) Token: 0x0602000A RID: 131082 RVA: 0x0047432D File Offset: 0x0047252D
		// (set) Token: 0x0602000B RID: 131083 RVA: 0x00474335 File Offset: 0x00472535
		public IConditionGroupT ReceiveCondition { get; set; }

		// Token: 0x170091C0 RID: 37312
		// (get) Token: 0x0602000C RID: 131084 RVA: 0x0047433E File Offset: 0x0047253E
		// (set) Token: 0x0602000D RID: 131085 RVA: 0x00474346 File Offset: 0x00472546
		public List<IActionInfoT> BeginActions { get; set; }

		// Token: 0x170091C1 RID: 37313
		// (get) Token: 0x0602000E RID: 131086 RVA: 0x0047434F File Offset: 0x0047254F
		// (set) Token: 0x0602000F RID: 131087 RVA: 0x00474357 File Offset: 0x00472557
		public List<IActionInfoT> CompleteActions { get; set; }

		// Token: 0x170091C2 RID: 37314
		// (get) Token: 0x06020010 RID: 131088 RVA: 0x00474360 File Offset: 0x00472560
		// (set) Token: 0x06020011 RID: 131089 RVA: 0x00474368 File Offset: 0x00472568
		public List<IActionInfoT> StopActions { get; set; }

		// Token: 0x170091C3 RID: 37315
		// (get) Token: 0x06020012 RID: 131090 RVA: 0x00474371 File Offset: 0x00472571
		// (set) Token: 0x06020013 RID: 131091 RVA: 0x00474379 File Offset: 0x00472579
		public byte NullMask { get; set; }

		// Token: 0x06020014 RID: 131092 RVA: 0x00474384 File Offset: 0x00472584
		public IBeamReceiveComponentT()
		{
			this.Disabled = false;
			this.ReceiveTarget = null;
			this.Duration = 0f;
			this.ReceiveCondition = null;
			this.BeginActions = null;
			this.CompleteActions = null;
			this.StopActions = null;
			this.NullMask = 0;
		}
	}
}
