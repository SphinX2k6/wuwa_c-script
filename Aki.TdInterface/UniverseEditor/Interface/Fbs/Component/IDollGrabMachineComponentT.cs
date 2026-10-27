using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050A3 RID: 20643
	public class IDollGrabMachineComponentT
	{
		// Token: 0x170095FA RID: 38394
		// (get) Token: 0x06021275 RID: 135797 RVA: 0x0049B585 File Offset: 0x00499785
		// (set) Token: 0x06021276 RID: 135798 RVA: 0x0049B58D File Offset: 0x0049978D
		public bool Disabled { get; set; }

		// Token: 0x170095FB RID: 38395
		// (get) Token: 0x06021277 RID: 135799 RVA: 0x0049B596 File Offset: 0x00499796
		// (set) Token: 0x06021278 RID: 135800 RVA: 0x0049B59E File Offset: 0x0049979E
		public EDollGrabShowcaseBelongType BelongType { get; set; }

		// Token: 0x170095FC RID: 38396
		// (get) Token: 0x06021279 RID: 135801 RVA: 0x0049B5A7 File Offset: 0x004997A7
		// (set) Token: 0x0602127A RID: 135802 RVA: 0x0049B5AF File Offset: 0x004997AF
		public float TimeLimit { get; set; }

		// Token: 0x170095FD RID: 38397
		// (get) Token: 0x0602127B RID: 135803 RVA: 0x0049B5B8 File Offset: 0x004997B8
		// (set) Token: 0x0602127C RID: 135804 RVA: 0x0049B5C0 File Offset: 0x004997C0
		public float PlayCost { get; set; }

		// Token: 0x170095FE RID: 38398
		// (get) Token: 0x0602127D RID: 135805 RVA: 0x0049B5C9 File Offset: 0x004997C9
		// (set) Token: 0x0602127E RID: 135806 RVA: 0x0049B5D1 File Offset: 0x004997D1
		public List<IDollGrabItemT> Items { get; set; }

		// Token: 0x170095FF RID: 38399
		// (get) Token: 0x0602127F RID: 135807 RVA: 0x0049B5DA File Offset: 0x004997DA
		// (set) Token: 0x06021280 RID: 135808 RVA: 0x0049B5E2 File Offset: 0x004997E2
		public IDollGrabInfiniteModeDataT InfiniteModeData { get; set; }

		// Token: 0x17009600 RID: 38400
		// (get) Token: 0x06021281 RID: 135809 RVA: 0x0049B5EB File Offset: 0x004997EB
		// (set) Token: 0x06021282 RID: 135810 RVA: 0x0049B5F3 File Offset: 0x004997F3
		public string AkEvent { get; set; }

		// Token: 0x17009601 RID: 38401
		// (get) Token: 0x06021283 RID: 135811 RVA: 0x0049B5FC File Offset: 0x004997FC
		// (set) Token: 0x06021284 RID: 135812 RVA: 0x0049B604 File Offset: 0x00499804
		public byte NullMask { get; set; }

		// Token: 0x06021285 RID: 135813 RVA: 0x0049B610 File Offset: 0x00499810
		public IDollGrabMachineComponentT()
		{
			this.Disabled = false;
			this.BelongType = EDollGrabShowcaseBelongType.LandOfXuanfang;
			this.TimeLimit = 0f;
			this.PlayCost = 0f;
			this.Items = null;
			this.InfiniteModeData = null;
			this.AkEvent = null;
			this.NullMask = 0;
		}
	}
}
