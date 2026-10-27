using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200662B RID: 26155
	public class IEffectEntityPos2T
	{
		// Token: 0x1700C251 RID: 49745
		// (get) Token: 0x0602D6B9 RID: 186041 RVA: 0x00638F8B File Offset: 0x0063718B
		// (set) Token: 0x0602D6BA RID: 186042 RVA: 0x00638F93 File Offset: 0x00637193
		public EPos2 Type { get; set; }

		// Token: 0x1700C252 RID: 49746
		// (get) Token: 0x0602D6BB RID: 186043 RVA: 0x00638F9C File Offset: 0x0063719C
		// (set) Token: 0x0602D6BC RID: 186044 RVA: 0x00638FA4 File Offset: 0x006371A4
		public int EntityId { get; set; }

		// Token: 0x1700C253 RID: 49747
		// (get) Token: 0x0602D6BD RID: 186045 RVA: 0x00638FAD File Offset: 0x006371AD
		// (set) Token: 0x0602D6BE RID: 186046 RVA: 0x00638FB5 File Offset: 0x006371B5
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700C254 RID: 49748
		// (get) Token: 0x0602D6BF RID: 186047 RVA: 0x00638FBE File Offset: 0x006371BE
		// (set) Token: 0x0602D6C0 RID: 186048 RVA: 0x00638FC6 File Offset: 0x006371C6
		public string AttachSocket { get; set; }

		// Token: 0x0602D6C1 RID: 186049 RVA: 0x00638FCF File Offset: 0x006371CF
		public IEffectEntityPos2T()
		{
			this.Type = EPos2.Player;
			this.EntityId = 0;
			this.Offset = null;
			this.AttachSocket = null;
		}
	}
}
