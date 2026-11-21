using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078F4 RID: 30964
	public class ISkillBlackboardVectorT
	{
		// Token: 0x1700E337 RID: 58167
		// (get) Token: 0x06036871 RID: 223345 RVA: 0x0074CC63 File Offset: 0x0074AE63
		// (set) Token: 0x06036872 RID: 223346 RVA: 0x0074CC6B File Offset: 0x0074AE6B
		public string Key { get; set; }

		// Token: 0x1700E338 RID: 58168
		// (get) Token: 0x06036873 RID: 223347 RVA: 0x0074CC74 File Offset: 0x0074AE74
		// (set) Token: 0x06036874 RID: 223348 RVA: 0x0074CC7C File Offset: 0x0074AE7C
		public IVectorInfoT Value { get; set; }

		// Token: 0x06036875 RID: 223349 RVA: 0x0074CC85 File Offset: 0x0074AE85
		public ISkillBlackboardVectorT()
		{
			this.Key = null;
			this.Value = null;
		}
	}
}
