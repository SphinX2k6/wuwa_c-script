using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060FE RID: 24830
	public class ITriggerUe5ComponentT
	{
		// Token: 0x1700B8DC RID: 47324
		// (get) Token: 0x0602A16C RID: 172396 RVA: 0x005BED49 File Offset: 0x005BCF49
		// (set) Token: 0x0602A16D RID: 172397 RVA: 0x005BED51 File Offset: 0x005BCF51
		public bool Disabled { get; set; }

		// Token: 0x1700B8DD RID: 47325
		// (get) Token: 0x0602A16E RID: 172398 RVA: 0x005BED5A File Offset: 0x005BCF5A
		// (set) Token: 0x0602A16F RID: 172399 RVA: 0x005BED62 File Offset: 0x005BCF62
		public int MaxTriggerTimes { get; set; }

		// Token: 0x1700B8DE RID: 47326
		// (get) Token: 0x0602A170 RID: 172400 RVA: 0x005BED6B File Offset: 0x005BCF6B
		// (set) Token: 0x0602A171 RID: 172401 RVA: 0x005BED73 File Offset: 0x005BCF73
		public bool IsNotLoad { get; set; }

		// Token: 0x1700B8DF RID: 47327
		// (get) Token: 0x0602A172 RID: 172402 RVA: 0x005BED7C File Offset: 0x005BCF7C
		// (set) Token: 0x0602A173 RID: 172403 RVA: 0x005BED84 File Offset: 0x005BCF84
		public ITriggerActionsT TriggerActions { get; set; }

		// Token: 0x1700B8E0 RID: 47328
		// (get) Token: 0x0602A174 RID: 172404 RVA: 0x005BED8D File Offset: 0x005BCF8D
		// (set) Token: 0x0602A175 RID: 172405 RVA: 0x005BED95 File Offset: 0x005BCF95
		public byte NullMask { get; set; }

		// Token: 0x0602A176 RID: 172406 RVA: 0x005BED9E File Offset: 0x005BCF9E
		public ITriggerUe5ComponentT()
		{
			this.Disabled = false;
			this.MaxTriggerTimes = 0;
			this.IsNotLoad = false;
			this.TriggerActions = null;
			this.NullMask = 0;
		}
	}
}
