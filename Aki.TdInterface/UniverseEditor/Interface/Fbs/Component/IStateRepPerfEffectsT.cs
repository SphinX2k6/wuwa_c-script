using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059B4 RID: 22964
	public class IStateRepPerfEffectsT
	{
		// Token: 0x1700AC53 RID: 44115
		// (get) Token: 0x06026E84 RID: 159364 RVA: 0x0055A6CF File Offset: 0x005588CF
		// (set) Token: 0x06026E85 RID: 159365 RVA: 0x0055A6D7 File Offset: 0x005588D7
		public EStateRepPerfType Type { get; set; }

		// Token: 0x1700AC54 RID: 44116
		// (get) Token: 0x06026E86 RID: 159366 RVA: 0x0055A6E0 File Offset: 0x005588E0
		// (set) Token: 0x06026E87 RID: 159367 RVA: 0x0055A6E8 File Offset: 0x005588E8
		public List<int> GamePlayCues { get; set; }

		// Token: 0x06026E88 RID: 159368 RVA: 0x0055A6F1 File Offset: 0x005588F1
		public IStateRepPerfEffectsT()
		{
			this.Type = EStateRepPerfType.SkillId;
			this.GamePlayCues = null;
		}
	}
}
