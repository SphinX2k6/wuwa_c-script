using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056E6 RID: 22246
	public class IEntityGroupFailureConditionT
	{
		// Token: 0x1700A062 RID: 41058
		// (get) Token: 0x06023B2B RID: 146219 RVA: 0x004E880A File Offset: 0x004E6A0A
		// (set) Token: 0x06023B2C RID: 146220 RVA: 0x004E8812 File Offset: 0x004E6A12
		public EEntityGroupFailureCondition Type { get; set; }

		// Token: 0x06023B2D RID: 146221 RVA: 0x004E881B File Offset: 0x004E6A1B
		public IEntityGroupFailureConditionT()
		{
			this.Type = EEntityGroupFailureCondition.SequentialState;
		}
	}
}
