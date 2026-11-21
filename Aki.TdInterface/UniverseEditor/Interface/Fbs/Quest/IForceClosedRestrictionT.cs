using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042AB RID: 17067
	public class IForceClosedRestrictionT
	{
		// Token: 0x170074BF RID: 29887
		// (get) Token: 0x06017E78 RID: 97912 RVA: 0x00369FE7 File Offset: 0x003681E7
		// (set) Token: 0x06017E79 RID: 97913 RVA: 0x00369FEF File Offset: 0x003681EF
		public IVectorInfoT RangeCenter { get; set; }

		// Token: 0x170074C0 RID: 29888
		// (get) Token: 0x06017E7A RID: 97914 RVA: 0x00369FF8 File Offset: 0x003681F8
		// (set) Token: 0x06017E7B RID: 97915 RVA: 0x0036A000 File Offset: 0x00368200
		public int RangeRadius { get; set; }

		// Token: 0x170074C1 RID: 29889
		// (get) Token: 0x06017E7C RID: 97916 RVA: 0x0036A009 File Offset: 0x00368209
		// (set) Token: 0x06017E7D RID: 97917 RVA: 0x0036A011 File Offset: 0x00368211
		public List<int> RangeEntities { get; set; }

		// Token: 0x170074C2 RID: 29890
		// (get) Token: 0x06017E7E RID: 97918 RVA: 0x0036A01A File Offset: 0x0036821A
		// (set) Token: 0x06017E7F RID: 97919 RVA: 0x0036A022 File Offset: 0x00368222
		public Aki.UniverseEditor.Interface.Fbs.Action.IPosAT FailedReturnPos { get; set; }

		// Token: 0x170074C3 RID: 29891
		// (get) Token: 0x06017E80 RID: 97920 RVA: 0x0036A02B File Offset: 0x0036822B
		// (set) Token: 0x06017E81 RID: 97921 RVA: 0x0036A033 File Offset: 0x00368233
		public int FailedReturnPosEntityId { get; set; }

		// Token: 0x170074C4 RID: 29892
		// (get) Token: 0x06017E82 RID: 97922 RVA: 0x0036A03C File Offset: 0x0036823C
		// (set) Token: 0x06017E83 RID: 97923 RVA: 0x0036A044 File Offset: 0x00368244
		public List<int> AllowDungeonList { get; set; }

		// Token: 0x170074C5 RID: 29893
		// (get) Token: 0x06017E84 RID: 97924 RVA: 0x0036A04D File Offset: 0x0036824D
		// (set) Token: 0x06017E85 RID: 97925 RVA: 0x0036A055 File Offset: 0x00368255
		public bool OnlyFailOnceOutsideDungeon { get; set; }

		// Token: 0x170074C6 RID: 29894
		// (get) Token: 0x06017E86 RID: 97926 RVA: 0x0036A05E File Offset: 0x0036825E
		// (set) Token: 0x06017E87 RID: 97927 RVA: 0x0036A066 File Offset: 0x00368266
		public byte NullMask { get; set; }

		// Token: 0x06017E88 RID: 97928 RVA: 0x0036A06F File Offset: 0x0036826F
		public IForceClosedRestrictionT()
		{
			this.RangeCenter = null;
			this.RangeRadius = 0;
			this.RangeEntities = null;
			this.FailedReturnPos = null;
			this.FailedReturnPosEntityId = 0;
			this.AllowDungeonList = null;
			this.OnlyFailOnceOutsideDungeon = false;
			this.NullMask = 0;
		}
	}
}
