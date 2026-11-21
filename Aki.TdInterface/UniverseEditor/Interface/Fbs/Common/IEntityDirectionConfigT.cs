using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063E7 RID: 25575
	public class IEntityDirectionConfigT
	{
		// Token: 0x1700BCFB RID: 48379
		// (get) Token: 0x0602B73A RID: 177978 RVA: 0x005EB9A7 File Offset: 0x005E9BA7
		// (set) Token: 0x0602B73B RID: 177979 RVA: 0x005EB9AF File Offset: 0x005E9BAF
		public int LevelId { get; set; }

		// Token: 0x1700BCFC RID: 48380
		// (get) Token: 0x0602B73C RID: 177980 RVA: 0x005EB9B8 File Offset: 0x005E9BB8
		// (set) Token: 0x0602B73D RID: 177981 RVA: 0x005EB9C0 File Offset: 0x005E9BC0
		public List<IEntityDirectionT> EntityDirectionConfig { get; set; }

		// Token: 0x0602B73E RID: 177982 RVA: 0x005EB9C9 File Offset: 0x005E9BC9
		public IEntityDirectionConfigT()
		{
			this.LevelId = 0;
			this.EntityDirectionConfig = null;
		}
	}
}
