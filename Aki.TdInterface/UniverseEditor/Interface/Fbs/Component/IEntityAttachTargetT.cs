using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056B9 RID: 22201
	public class IEntityAttachTargetT
	{
		// Token: 0x17009FC8 RID: 40904
		// (get) Token: 0x06023910 RID: 145680 RVA: 0x004E410B File Offset: 0x004E230B
		// (set) Token: 0x06023911 RID: 145681 RVA: 0x004E4113 File Offset: 0x004E2313
		public EAttachType Type { get; set; }

		// Token: 0x17009FC9 RID: 40905
		// (get) Token: 0x06023912 RID: 145682 RVA: 0x004E411C File Offset: 0x004E231C
		// (set) Token: 0x06023913 RID: 145683 RVA: 0x004E4124 File Offset: 0x004E2324
		public int EntityId { get; set; }

		// Token: 0x17009FCA RID: 40906
		// (get) Token: 0x06023914 RID: 145684 RVA: 0x004E412D File Offset: 0x004E232D
		// (set) Token: 0x06023915 RID: 145685 RVA: 0x004E4135 File Offset: 0x004E2335
		public string AttachPoint { get; set; }

		// Token: 0x17009FCB RID: 40907
		// (get) Token: 0x06023916 RID: 145686 RVA: 0x004E413E File Offset: 0x004E233E
		// (set) Token: 0x06023917 RID: 145687 RVA: 0x004E4146 File Offset: 0x004E2346
		public IVectorInfoT PosOffset { get; set; }

		// Token: 0x06023918 RID: 145688 RVA: 0x004E414F File Offset: 0x004E234F
		public IEntityAttachTargetT()
		{
			this.Type = EAttachType.Actor;
			this.EntityId = 0;
			this.AttachPoint = null;
			this.PosOffset = null;
		}
	}
}
