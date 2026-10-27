using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FF3 RID: 16371
	public class IQuestMonsterHealthScoreT
	{
		// Token: 0x170072EF RID: 29423
		// (get) Token: 0x0601796D RID: 96621 RVA: 0x003671C2 File Offset: 0x003653C2
		// (set) Token: 0x0601796E RID: 96622 RVA: 0x003671CA File Offset: 0x003653CA
		public EStatisticsEventType Type { get; set; }

		// Token: 0x170072F0 RID: 29424
		// (get) Token: 0x0601796F RID: 96623 RVA: 0x003671D3 File Offset: 0x003653D3
		// (set) Token: 0x06017970 RID: 96624 RVA: 0x003671DB File Offset: 0x003653DB
		public TVarRefUnion Var { get; set; }

		// Token: 0x170072F1 RID: 29425
		// (get) Token: 0x06017971 RID: 96625 RVA: 0x003671E4 File Offset: 0x003653E4
		// (set) Token: 0x06017972 RID: 96626 RVA: 0x003671EC File Offset: 0x003653EC
		public List<IMonsterHpPointTypeConfigT> TypeConfigs { get; set; }

		// Token: 0x170072F2 RID: 29426
		// (get) Token: 0x06017973 RID: 96627 RVA: 0x003671F5 File Offset: 0x003653F5
		// (set) Token: 0x06017974 RID: 96628 RVA: 0x003671FD File Offset: 0x003653FD
		public List<IMonsterHpPointEntityConfigT> EntityConfigs { get; set; }

		// Token: 0x170072F3 RID: 29427
		// (get) Token: 0x06017975 RID: 96629 RVA: 0x00367206 File Offset: 0x00365406
		// (set) Token: 0x06017976 RID: 96630 RVA: 0x0036720E File Offset: 0x0036540E
		public bool IsStatisticsRecoveredHp { get; set; }

		// Token: 0x170072F4 RID: 29428
		// (get) Token: 0x06017977 RID: 96631 RVA: 0x00367217 File Offset: 0x00365417
		// (set) Token: 0x06017978 RID: 96632 RVA: 0x0036721F File Offset: 0x0036541F
		public byte NullMask { get; set; }

		// Token: 0x06017979 RID: 96633 RVA: 0x00367228 File Offset: 0x00365428
		public IQuestMonsterHealthScoreT()
		{
			this.Type = EStatisticsEventType.Collect;
			this.Var = null;
			this.TypeConfigs = null;
			this.EntityConfigs = null;
			this.IsStatisticsRecoveredHp = false;
			this.NullMask = 0;
		}
	}
}
