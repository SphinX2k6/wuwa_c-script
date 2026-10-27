using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200588F RID: 22671
	public class IRotatorComponentT
	{
		// Token: 0x1700A99F RID: 43423
		// (get) Token: 0x0602636A RID: 156522 RVA: 0x005449DB File Offset: 0x00542BDB
		// (set) Token: 0x0602636B RID: 156523 RVA: 0x005449E3 File Offset: 0x00542BE3
		public bool Disabled { get; set; }

		// Token: 0x1700A9A0 RID: 43424
		// (get) Token: 0x0602636C RID: 156524 RVA: 0x005449EC File Offset: 0x00542BEC
		// (set) Token: 0x0602636D RID: 156525 RVA: 0x005449F4 File Offset: 0x00542BF4
		public string Content { get; set; }

		// Token: 0x1700A9A1 RID: 43425
		// (get) Token: 0x0602636E RID: 156526 RVA: 0x005449FD File Offset: 0x00542BFD
		// (set) Token: 0x0602636F RID: 156527 RVA: 0x00544A05 File Offset: 0x00542C05
		public string Icon { get; set; }

		// Token: 0x1700A9A2 RID: 43426
		// (get) Token: 0x06026370 RID: 156528 RVA: 0x00544A0E File Offset: 0x00542C0E
		// (set) Token: 0x06026371 RID: 156529 RVA: 0x00544A16 File Offset: 0x00542C16
		public IVectorInfoT RotatorSpeed { get; set; }

		// Token: 0x1700A9A3 RID: 43427
		// (get) Token: 0x06026372 RID: 156530 RVA: 0x00544A1F File Offset: 0x00542C1F
		// (set) Token: 0x06026373 RID: 156531 RVA: 0x00544A27 File Offset: 0x00542C27
		public IVectorInfoT LocationOffset { get; set; }

		// Token: 0x1700A9A4 RID: 43428
		// (get) Token: 0x06026374 RID: 156532 RVA: 0x00544A30 File Offset: 0x00542C30
		// (set) Token: 0x06026375 RID: 156533 RVA: 0x00544A38 File Offset: 0x00542C38
		public IVectorInfoT RotationOffset { get; set; }

		// Token: 0x1700A9A5 RID: 43429
		// (get) Token: 0x06026376 RID: 156534 RVA: 0x00544A41 File Offset: 0x00542C41
		// (set) Token: 0x06026377 RID: 156535 RVA: 0x00544A49 File Offset: 0x00542C49
		public IVectorInfoT RotationMapping { get; set; }

		// Token: 0x1700A9A6 RID: 43430
		// (get) Token: 0x06026378 RID: 156536 RVA: 0x00544A52 File Offset: 0x00542C52
		// (set) Token: 0x06026379 RID: 156537 RVA: 0x00544A5A File Offset: 0x00542C5A
		public bool IsLocalSpace { get; set; }

		// Token: 0x1700A9A7 RID: 43431
		// (get) Token: 0x0602637A RID: 156538 RVA: 0x00544A63 File Offset: 0x00542C63
		// (set) Token: 0x0602637B RID: 156539 RVA: 0x00544A6B File Offset: 0x00542C6B
		public int EntityId { get; set; }

		// Token: 0x1700A9A8 RID: 43432
		// (get) Token: 0x0602637C RID: 156540 RVA: 0x00544A74 File Offset: 0x00542C74
		// (set) Token: 0x0602637D RID: 156541 RVA: 0x00544A7C File Offset: 0x00542C7C
		public bool IsRotatorSelf { get; set; }

		// Token: 0x1700A9A9 RID: 43433
		// (get) Token: 0x0602637E RID: 156542 RVA: 0x00544A85 File Offset: 0x00542C85
		// (set) Token: 0x0602637F RID: 156543 RVA: 0x00544A8D File Offset: 0x00542C8D
		public IEventRotatorT InteractAction { get; set; }

		// Token: 0x1700A9AA RID: 43434
		// (get) Token: 0x06026380 RID: 156544 RVA: 0x00544A96 File Offset: 0x00542C96
		// (set) Token: 0x06026381 RID: 156545 RVA: 0x00544A9E File Offset: 0x00542C9E
		public bool IsLockZ { get; set; }

		// Token: 0x1700A9AB RID: 43435
		// (get) Token: 0x06026382 RID: 156546 RVA: 0x00544AA7 File Offset: 0x00542CA7
		// (set) Token: 0x06026383 RID: 156547 RVA: 0x00544AAF File Offset: 0x00542CAF
		public bool IsRecovery { get; set; }

		// Token: 0x1700A9AC RID: 43436
		// (get) Token: 0x06026384 RID: 156548 RVA: 0x00544AB8 File Offset: 0x00542CB8
		// (set) Token: 0x06026385 RID: 156549 RVA: 0x00544AC0 File Offset: 0x00542CC0
		public byte NullMask { get; set; }

		// Token: 0x06026386 RID: 156550 RVA: 0x00544ACC File Offset: 0x00542CCC
		public IRotatorComponentT()
		{
			this.Disabled = false;
			this.Content = null;
			this.Icon = null;
			this.RotatorSpeed = null;
			this.LocationOffset = null;
			this.RotationOffset = null;
			this.RotationMapping = null;
			this.IsLocalSpace = false;
			this.EntityId = 0;
			this.IsRotatorSelf = false;
			this.InteractAction = null;
			this.IsLockZ = false;
			this.IsRecovery = false;
			this.NullMask = 0;
		}
	}
}
