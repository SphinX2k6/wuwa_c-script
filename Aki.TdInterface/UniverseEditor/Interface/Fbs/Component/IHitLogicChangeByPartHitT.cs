using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005390 RID: 21392
	public class IHitLogicChangeByPartHitT
	{
		// Token: 0x17009D36 RID: 40246
		// (get) Token: 0x06023090 RID: 143504 RVA: 0x004DA033 File Offset: 0x004D8233
		// (set) Token: 0x06023091 RID: 143505 RVA: 0x004DA03B File Offset: 0x004D823B
		public EHitLogicType Type { get; set; }

		// Token: 0x17009D37 RID: 40247
		// (get) Token: 0x06023092 RID: 143506 RVA: 0x004DA044 File Offset: 0x004D8244
		// (set) Token: 0x06023093 RID: 143507 RVA: 0x004DA04C File Offset: 0x004D824C
		public List<IPartHitConfigT> PartHitConfig { get; set; }

		// Token: 0x06023094 RID: 143508 RVA: 0x004DA055 File Offset: 0x004D8255
		public IHitLogicChangeByPartHitT()
		{
			this.Type = EHitLogicType.ChangeNextState;
			this.PartHitConfig = null;
		}
	}
}
