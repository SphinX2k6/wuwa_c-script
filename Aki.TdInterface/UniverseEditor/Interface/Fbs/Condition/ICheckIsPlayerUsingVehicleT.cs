using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F66 RID: 20326
	public class ICheckIsPlayerUsingVehicleT
	{
		// Token: 0x17009145 RID: 37189
		// (get) Token: 0x0601FA27 RID: 129575 RVA: 0x00466385 File Offset: 0x00464585
		// (set) Token: 0x0601FA28 RID: 129576 RVA: 0x0046638D File Offset: 0x0046458D
		public EVehicleConditionType Type { get; set; }

		// Token: 0x17009146 RID: 37190
		// (get) Token: 0x0601FA29 RID: 129577 RVA: 0x00466396 File Offset: 0x00464596
		// (set) Token: 0x0601FA2A RID: 129578 RVA: 0x0046639E File Offset: 0x0046459E
		public EVehicleType VehicleType { get; set; }

		// Token: 0x17009147 RID: 37191
		// (get) Token: 0x0601FA2B RID: 129579 RVA: 0x004663A7 File Offset: 0x004645A7
		// (set) Token: 0x0601FA2C RID: 129580 RVA: 0x004663AF File Offset: 0x004645AF
		public bool CheckType { get; set; }

		// Token: 0x17009148 RID: 37192
		// (get) Token: 0x0601FA2D RID: 129581 RVA: 0x004663B8 File Offset: 0x004645B8
		// (set) Token: 0x0601FA2E RID: 129582 RVA: 0x004663C0 File Offset: 0x004645C0
		public TOnlinePlayerConditionTargetUnion OnlinePlayerConditionTargetOption { get; set; }

		// Token: 0x17009149 RID: 37193
		// (get) Token: 0x0601FA2F RID: 129583 RVA: 0x004663C9 File Offset: 0x004645C9
		// (set) Token: 0x0601FA30 RID: 129584 RVA: 0x004663D1 File Offset: 0x004645D1
		public byte NullMask { get; set; }

		// Token: 0x0601FA31 RID: 129585 RVA: 0x004663DA File Offset: 0x004645DA
		public ICheckIsPlayerUsingVehicleT()
		{
			this.Type = EVehicleConditionType.UsingVehicle;
			this.VehicleType = EVehicleType.Gongduola;
			this.CheckType = false;
			this.OnlinePlayerConditionTargetOption = null;
			this.NullMask = 0;
		}
	}
}
