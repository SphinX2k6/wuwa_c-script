using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005154 RID: 20820
	public class IEntityAttachTargetT
	{
		// Token: 0x170097DB RID: 38875
		// (get) Token: 0x060219BC RID: 137660 RVA: 0x004AA17F File Offset: 0x004A837F
		// (set) Token: 0x060219BD RID: 137661 RVA: 0x004AA187 File Offset: 0x004A8387
		public EAttachType Type { get; set; }

		// Token: 0x170097DC RID: 38876
		// (get) Token: 0x060219BE RID: 137662 RVA: 0x004AA190 File Offset: 0x004A8390
		// (set) Token: 0x060219BF RID: 137663 RVA: 0x004AA198 File Offset: 0x004A8398
		public int EntityId { get; set; }

		// Token: 0x170097DD RID: 38877
		// (get) Token: 0x060219C0 RID: 137664 RVA: 0x004AA1A1 File Offset: 0x004A83A1
		// (set) Token: 0x060219C1 RID: 137665 RVA: 0x004AA1A9 File Offset: 0x004A83A9
		public string AttachPoint { get; set; }

		// Token: 0x170097DE RID: 38878
		// (get) Token: 0x060219C2 RID: 137666 RVA: 0x004AA1B2 File Offset: 0x004A83B2
		// (set) Token: 0x060219C3 RID: 137667 RVA: 0x004AA1BA File Offset: 0x004A83BA
		public IVectorInfoT PosOffset { get; set; }

		// Token: 0x060219C4 RID: 137668 RVA: 0x004AA1C3 File Offset: 0x004A83C3
		public IEntityAttachTargetT()
		{
			this.Type = EAttachType.Actor;
			this.EntityId = 0;
			this.AttachPoint = null;
			this.PosOffset = null;
		}
	}
}
