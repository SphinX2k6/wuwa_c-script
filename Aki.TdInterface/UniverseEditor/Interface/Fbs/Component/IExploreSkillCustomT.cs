using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005743 RID: 22339
	public class IExploreSkillCustomT
	{
		// Token: 0x1700A154 RID: 41300
		// (get) Token: 0x06023F34 RID: 147252 RVA: 0x004F113D File Offset: 0x004EF33D
		// (set) Token: 0x06023F35 RID: 147253 RVA: 0x004F1145 File Offset: 0x004EF345
		public EExploreSkillInteractType Type { get; set; }

		// Token: 0x1700A155 RID: 41301
		// (get) Token: 0x06023F36 RID: 147254 RVA: 0x004F114E File Offset: 0x004EF34E
		// (set) Token: 0x06023F37 RID: 147255 RVA: 0x004F1156 File Offset: 0x004EF356
		public int LockConfigId { get; set; }

		// Token: 0x1700A156 RID: 41302
		// (get) Token: 0x06023F38 RID: 147256 RVA: 0x004F115F File Offset: 0x004EF35F
		// (set) Token: 0x06023F39 RID: 147257 RVA: 0x004F1167 File Offset: 0x004EF367
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700A157 RID: 41303
		// (get) Token: 0x06023F3A RID: 147258 RVA: 0x004F1170 File Offset: 0x004EF370
		// (set) Token: 0x06023F3B RID: 147259 RVA: 0x004F1178 File Offset: 0x004EF378
		public IVectorInfoT InteractOffset { get; set; }

		// Token: 0x06023F3C RID: 147260 RVA: 0x004F1181 File Offset: 0x004EF381
		public IExploreSkillCustomT()
		{
			this.Type = EExploreSkillInteractType.PullGiant;
			this.LockConfigId = 0;
			this.Actions = null;
			this.InteractOffset = null;
		}
	}
}
