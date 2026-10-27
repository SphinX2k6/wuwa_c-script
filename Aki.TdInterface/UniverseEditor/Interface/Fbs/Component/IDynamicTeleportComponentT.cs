using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005103 RID: 20739
	public class IDynamicTeleportComponentT
	{
		// Token: 0x1700971C RID: 38684
		// (get) Token: 0x0602169A RID: 136858 RVA: 0x004A3CF7 File Offset: 0x004A1EF7
		// (set) Token: 0x0602169B RID: 136859 RVA: 0x004A3CFF File Offset: 0x004A1EFF
		public bool Disabled { get; set; }

		// Token: 0x1700971D RID: 38685
		// (get) Token: 0x0602169C RID: 136860 RVA: 0x004A3D08 File Offset: 0x004A1F08
		// (set) Token: 0x0602169D RID: 136861 RVA: 0x004A3D10 File Offset: 0x004A1F10
		public IPosAT Offset { get; set; }

		// Token: 0x1700971E RID: 38686
		// (get) Token: 0x0602169E RID: 136862 RVA: 0x004A3D19 File Offset: 0x004A1F19
		// (set) Token: 0x0602169F RID: 136863 RVA: 0x004A3D21 File Offset: 0x004A1F21
		public int PhantomSkillId { get; set; }

		// Token: 0x1700971F RID: 38687
		// (get) Token: 0x060216A0 RID: 136864 RVA: 0x004A3D2A File Offset: 0x004A1F2A
		// (set) Token: 0x060216A1 RID: 136865 RVA: 0x004A3D32 File Offset: 0x004A1F32
		public byte NullMask { get; set; }

		// Token: 0x060216A2 RID: 136866 RVA: 0x004A3D3B File Offset: 0x004A1F3B
		public IDynamicTeleportComponentT()
		{
			this.Disabled = false;
			this.Offset = null;
			this.PhantomSkillId = 0;
			this.NullMask = 0;
		}
	}
}
