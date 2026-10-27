using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003CF6 RID: 15606
	public class IAddTimeConfigT
	{
		// Token: 0x17006AFF RID: 27391
		// (get) Token: 0x06015805 RID: 88069 RVA: 0x0031B27E File Offset: 0x0031947E
		// (set) Token: 0x06015806 RID: 88070 RVA: 0x0031B286 File Offset: 0x00319486
		public IKillMonsterT MonsterConfig { get; set; }

		// Token: 0x17006B00 RID: 27392
		// (get) Token: 0x06015807 RID: 88071 RVA: 0x0031B28F File Offset: 0x0031948F
		// (set) Token: 0x06015808 RID: 88072 RVA: 0x0031B297 File Offset: 0x00319497
		public List<IAddTimeStateConditionT> StateConfig { get; set; }

		// Token: 0x17006B01 RID: 27393
		// (get) Token: 0x06015809 RID: 88073 RVA: 0x0031B2A0 File Offset: 0x003194A0
		// (set) Token: 0x0601580A RID: 88074 RVA: 0x0031B2A8 File Offset: 0x003194A8
		public byte NullMask { get; set; }

		// Token: 0x0601580B RID: 88075 RVA: 0x0031B2B1 File Offset: 0x003194B1
		public IAddTimeConfigT()
		{
			this.MonsterConfig = null;
			this.StateConfig = null;
			this.NullMask = 0;
		}
	}
}
