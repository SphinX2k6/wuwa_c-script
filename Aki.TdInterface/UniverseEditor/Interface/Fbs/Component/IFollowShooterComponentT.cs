using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200529B RID: 21147
	public class IFollowShooterComponentT
	{
		// Token: 0x17009B15 RID: 39701
		// (get) Token: 0x06022794 RID: 141204 RVA: 0x004C7A37 File Offset: 0x004C5C37
		// (set) Token: 0x06022795 RID: 141205 RVA: 0x004C7A3F File Offset: 0x004C5C3F
		public bool Disabled { get; set; }

		// Token: 0x17009B16 RID: 39702
		// (get) Token: 0x06022796 RID: 141206 RVA: 0x004C7A48 File Offset: 0x004C5C48
		// (set) Token: 0x06022797 RID: 141207 RVA: 0x004C7A50 File Offset: 0x004C5C50
		public string Config { get; set; }

		// Token: 0x17009B17 RID: 39703
		// (get) Token: 0x06022798 RID: 141208 RVA: 0x004C7A59 File Offset: 0x004C5C59
		// (set) Token: 0x06022799 RID: 141209 RVA: 0x004C7A61 File Offset: 0x004C5C61
		public IFollowShooterJellyFishConfigT TypeConfig { get; set; }

		// Token: 0x17009B18 RID: 39704
		// (get) Token: 0x0602279A RID: 141210 RVA: 0x004C7A6A File Offset: 0x004C5C6A
		// (set) Token: 0x0602279B RID: 141211 RVA: 0x004C7A72 File Offset: 0x004C5C72
		public List<IEntityCategoryT> LockableCategories { get; set; }

		// Token: 0x17009B19 RID: 39705
		// (get) Token: 0x0602279C RID: 141212 RVA: 0x004C7A7B File Offset: 0x004C5C7B
		// (set) Token: 0x0602279D RID: 141213 RVA: 0x004C7A83 File Offset: 0x004C5C83
		public byte NullMask { get; set; }

		// Token: 0x0602279E RID: 141214 RVA: 0x004C7A8C File Offset: 0x004C5C8C
		public IFollowShooterComponentT()
		{
			this.Disabled = false;
			this.Config = null;
			this.TypeConfig = null;
			this.LockableCategories = null;
			this.NullMask = 0;
		}
	}
}
