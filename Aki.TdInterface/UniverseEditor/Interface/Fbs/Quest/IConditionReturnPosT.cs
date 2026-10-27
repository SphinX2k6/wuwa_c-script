using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DB0 RID: 15792
	public class IConditionReturnPosT
	{
		// Token: 0x17006CB4 RID: 27828
		// (get) Token: 0x06015F86 RID: 89990 RVA: 0x0032C33F File Offset: 0x0032A53F
		// (set) Token: 0x06015F87 RID: 89991 RVA: 0x0032C347 File Offset: 0x0032A547
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17006CB5 RID: 27829
		// (get) Token: 0x06015F88 RID: 89992 RVA: 0x0032C350 File Offset: 0x0032A550
		// (set) Token: 0x06015F89 RID: 89993 RVA: 0x0032C358 File Offset: 0x0032A558
		public TFastReturnPosUnion Pos { get; set; }

		// Token: 0x06015F8A RID: 89994 RVA: 0x0032C361 File Offset: 0x0032A561
		public IConditionReturnPosT()
		{
			this.Condition = null;
			this.Pos = null;
		}
	}
}
