using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043DD RID: 17373
	public class IPhotoTargetT
	{
		// Token: 0x170077AC RID: 30636
		// (get) Token: 0x06018AC7 RID: 101063 RVA: 0x00384A25 File Offset: 0x00382C25
		// (set) Token: 0x06018AC8 RID: 101064 RVA: 0x00384A2D File Offset: 0x00382C2D
		public int EntityId { get; set; }

		// Token: 0x170077AD RID: 30637
		// (get) Token: 0x06018AC9 RID: 101065 RVA: 0x00384A36 File Offset: 0x00382C36
		// (set) Token: 0x06018ACA RID: 101066 RVA: 0x00384A3E File Offset: 0x00382C3E
		public string TidDescription { get; set; }

		// Token: 0x170077AE RID: 30638
		// (get) Token: 0x06018ACB RID: 101067 RVA: 0x00384A47 File Offset: 0x00382C47
		// (set) Token: 0x06018ACC RID: 101068 RVA: 0x00384A4F File Offset: 0x00382C4F
		public bool IsOptionalTarget { get; set; }

		// Token: 0x170077AF RID: 30639
		// (get) Token: 0x06018ACD RID: 101069 RVA: 0x00384A58 File Offset: 0x00382C58
		// (set) Token: 0x06018ACE RID: 101070 RVA: 0x00384A60 File Offset: 0x00382C60
		public ISetVarT SetVar { get; set; }

		// Token: 0x170077B0 RID: 30640
		// (get) Token: 0x06018ACF RID: 101071 RVA: 0x00384A69 File Offset: 0x00382C69
		// (set) Token: 0x06018AD0 RID: 101072 RVA: 0x00384A71 File Offset: 0x00382C71
		public byte NullMask { get; set; }

		// Token: 0x06018AD1 RID: 101073 RVA: 0x00384A7A File Offset: 0x00382C7A
		public IPhotoTargetT()
		{
			this.EntityId = 0;
			this.TidDescription = null;
			this.IsOptionalTarget = false;
			this.SetVar = null;
			this.NullMask = 0;
		}
	}
}
