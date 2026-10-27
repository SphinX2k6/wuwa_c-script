using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044EC RID: 17644
	public class ILevelPlayActiveT
	{
		// Token: 0x17007D05 RID: 32005
		// (get) Token: 0x0601A79D RID: 108445 RVA: 0x003C854B File Offset: 0x003C674B
		// (set) Token: 0x0601A79E RID: 108446 RVA: 0x003C8553 File Offset: 0x003C6753
		public ELevelPlayActiveType ActiveType { get; set; }

		// Token: 0x17007D06 RID: 32006
		// (get) Token: 0x0601A79F RID: 108447 RVA: 0x003C855C File Offset: 0x003C675C
		// (set) Token: 0x0601A7A0 RID: 108448 RVA: 0x003C8564 File Offset: 0x003C6764
		public IConditionGroupT ActiveCondition { get; set; }

		// Token: 0x0601A7A1 RID: 108449 RVA: 0x003C856D File Offset: 0x003C676D
		public ILevelPlayActiveT()
		{
			this.ActiveType = ELevelPlayActiveType.Default;
			this.ActiveCondition = null;
		}
	}
}
