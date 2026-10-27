using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049E0 RID: 18912
	public class ICheckElementalBoxStateT
	{
		// Token: 0x170088C7 RID: 35015
		// (get) Token: 0x0601D8B4 RID: 121012 RVA: 0x00428D27 File Offset: 0x00426F27
		// (set) Token: 0x0601D8B5 RID: 121013 RVA: 0x00428D2F File Offset: 0x00426F2F
		public ECondition Type { get; set; }

		// Token: 0x170088C8 RID: 35016
		// (get) Token: 0x0601D8B6 RID: 121014 RVA: 0x00428D38 File Offset: 0x00426F38
		// (set) Token: 0x0601D8B7 RID: 121015 RVA: 0x00428D40 File Offset: 0x00426F40
		public TElementalBoxStateTargetUnion Target { get; set; }

		// Token: 0x0601D8B8 RID: 121016 RVA: 0x00428D49 File Offset: 0x00426F49
		public ICheckElementalBoxStateT()
		{
			this.Type = ECondition.CompareVar;
			this.Target = null;
		}
	}
}
