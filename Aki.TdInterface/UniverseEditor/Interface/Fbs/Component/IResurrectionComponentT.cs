using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Shape;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005865 RID: 22629
	public class IResurrectionComponentT
	{
		// Token: 0x1700A935 RID: 43317
		// (get) Token: 0x060261DF RID: 156127 RVA: 0x00541890 File Offset: 0x0053FA90
		// (set) Token: 0x060261E0 RID: 156128 RVA: 0x00541898 File Offset: 0x0053FA98
		public bool Disabled { get; set; }

		// Token: 0x1700A936 RID: 43318
		// (get) Token: 0x060261E1 RID: 156129 RVA: 0x005418A1 File Offset: 0x0053FAA1
		// (set) Token: 0x060261E2 RID: 156130 RVA: 0x005418A9 File Offset: 0x0053FAA9
		public IPosAT TeleportPos { get; set; }

		// Token: 0x1700A937 RID: 43319
		// (get) Token: 0x060261E3 RID: 156131 RVA: 0x005418B2 File Offset: 0x0053FAB2
		// (set) Token: 0x060261E4 RID: 156132 RVA: 0x005418BA File Offset: 0x0053FABA
		public TTriggerShapeUnion TriggerShape { get; set; }

		// Token: 0x1700A938 RID: 43320
		// (get) Token: 0x060261E5 RID: 156133 RVA: 0x005418C3 File Offset: 0x0053FAC3
		// (set) Token: 0x060261E6 RID: 156134 RVA: 0x005418CB File Offset: 0x0053FACB
		public EReviveType ReviveId { get; set; }

		// Token: 0x1700A939 RID: 43321
		// (get) Token: 0x060261E7 RID: 156135 RVA: 0x005418D4 File Offset: 0x0053FAD4
		// (set) Token: 0x060261E8 RID: 156136 RVA: 0x005418DC File Offset: 0x0053FADC
		public IGravityFlipTeleportConfigT GravityConfig { get; set; }

		// Token: 0x1700A93A RID: 43322
		// (get) Token: 0x060261E9 RID: 156137 RVA: 0x005418E5 File Offset: 0x0053FAE5
		// (set) Token: 0x060261EA RID: 156138 RVA: 0x005418ED File Offset: 0x0053FAED
		public byte NullMask { get; set; }

		// Token: 0x060261EB RID: 156139 RVA: 0x005418F6 File Offset: 0x0053FAF6
		public IResurrectionComponentT()
		{
			this.Disabled = false;
			this.TeleportPos = null;
			this.TriggerShape = null;
			this.ReviveId = EReviveType.None;
			this.GravityConfig = null;
			this.NullMask = 0;
		}
	}
}
