using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F94 RID: 24468
	public class ISplineTypeT
	{
		// Token: 0x1700B536 RID: 46390
		// (get) Token: 0x06029262 RID: 168546 RVA: 0x0059E70E File Offset: 0x0059C90E
		// (set) Token: 0x06029263 RID: 168547 RVA: 0x0059E716 File Offset: 0x0059C916
		public ESplineType Type { get; set; }

		// Token: 0x06029264 RID: 168548 RVA: 0x0059E71F File Offset: 0x0059C91F
		public ISplineTypeT()
		{
			this.Type = ESplineType.Common;
		}
	}
}
