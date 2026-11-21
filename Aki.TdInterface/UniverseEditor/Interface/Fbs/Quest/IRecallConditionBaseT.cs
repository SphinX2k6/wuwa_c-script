using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044B5 RID: 17589
	public class IRecallConditionBaseT
	{
		// Token: 0x17007A72 RID: 31346
		// (get) Token: 0x06019664 RID: 104036 RVA: 0x003A00B0 File Offset: 0x0039E2B0
		// (set) Token: 0x06019665 RID: 104037 RVA: 0x003A00B8 File Offset: 0x0039E2B8
		public ERecallConditionType Type { get; set; }

		// Token: 0x17007A73 RID: 31347
		// (get) Token: 0x06019666 RID: 104038 RVA: 0x003A00C1 File Offset: 0x0039E2C1
		// (set) Token: 0x06019667 RID: 104039 RVA: 0x003A00C9 File Offset: 0x0039E2C9
		public ERecallOperation Operation { get; set; }

		// Token: 0x06019668 RID: 104040 RVA: 0x003A00D2 File Offset: 0x0039E2D2
		public IRecallConditionBaseT()
		{
			this.Type = ERecallConditionType.ByEntityType;
			this.Operation = ERecallOperation.Include;
		}
	}
}
