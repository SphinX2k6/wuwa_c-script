using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005443 RID: 21571
	public class IBeamReceiveComponentT
	{
		// Token: 0x1700993E RID: 39230
		// (get) Token: 0x06021D74 RID: 138612 RVA: 0x004AA68E File Offset: 0x004A888E
		// (set) Token: 0x06021D75 RID: 138613 RVA: 0x004AA696 File Offset: 0x004A8896
		public bool Disabled { get; set; }

		// Token: 0x1700993F RID: 39231
		// (get) Token: 0x06021D76 RID: 138614 RVA: 0x004AA69F File Offset: 0x004A889F
		// (set) Token: 0x06021D77 RID: 138615 RVA: 0x004AA6A7 File Offset: 0x004A88A7
		public string ReceiveTarget { get; set; }

		// Token: 0x17009940 RID: 39232
		// (get) Token: 0x06021D78 RID: 138616 RVA: 0x004AA6B0 File Offset: 0x004A88B0
		// (set) Token: 0x06021D79 RID: 138617 RVA: 0x004AA6B8 File Offset: 0x004A88B8
		public float Duration { get; set; }

		// Token: 0x17009941 RID: 39233
		// (get) Token: 0x06021D7A RID: 138618 RVA: 0x004AA6C1 File Offset: 0x004A88C1
		// (set) Token: 0x06021D7B RID: 138619 RVA: 0x004AA6C9 File Offset: 0x004A88C9
		public IConditionGroupT ReceiveCondition { get; set; }

		// Token: 0x17009942 RID: 39234
		// (get) Token: 0x06021D7C RID: 138620 RVA: 0x004AA6D2 File Offset: 0x004A88D2
		// (set) Token: 0x06021D7D RID: 138621 RVA: 0x004AA6DA File Offset: 0x004A88DA
		public List<IActionInfoT> BeginActions { get; set; }

		// Token: 0x17009943 RID: 39235
		// (get) Token: 0x06021D7E RID: 138622 RVA: 0x004AA6E3 File Offset: 0x004A88E3
		// (set) Token: 0x06021D7F RID: 138623 RVA: 0x004AA6EB File Offset: 0x004A88EB
		public List<IActionInfoT> CompleteActions { get; set; }

		// Token: 0x17009944 RID: 39236
		// (get) Token: 0x06021D80 RID: 138624 RVA: 0x004AA6F4 File Offset: 0x004A88F4
		// (set) Token: 0x06021D81 RID: 138625 RVA: 0x004AA6FC File Offset: 0x004A88FC
		public List<IActionInfoT> StopActions { get; set; }

		// Token: 0x17009945 RID: 39237
		// (get) Token: 0x06021D82 RID: 138626 RVA: 0x004AA705 File Offset: 0x004A8905
		// (set) Token: 0x06021D83 RID: 138627 RVA: 0x004AA70D File Offset: 0x004A890D
		public byte NullMask { get; set; }

		// Token: 0x06021D84 RID: 138628 RVA: 0x004AA718 File Offset: 0x004A8918
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
