using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005830 RID: 22576
	public class IFoxJumpInteractPointRelationTypeT
	{
		// Token: 0x1700A372 RID: 41842
		// (get) Token: 0x060248C7 RID: 149703 RVA: 0x005058A8 File Offset: 0x00503AA8
		// (set) Token: 0x060248C8 RID: 149704 RVA: 0x005058B0 File Offset: 0x00503AB0
		public EFoxJumpInteractPointRelationType Type { get; set; }

		// Token: 0x1700A373 RID: 41843
		// (get) Token: 0x060248C9 RID: 149705 RVA: 0x005058B9 File Offset: 0x00503AB9
		// (set) Token: 0x060248CA RID: 149706 RVA: 0x005058C1 File Offset: 0x00503AC1
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700A374 RID: 41844
		// (get) Token: 0x060248CB RID: 149707 RVA: 0x005058CA File Offset: 0x00503ACA
		// (set) Token: 0x060248CC RID: 149708 RVA: 0x005058D2 File Offset: 0x00503AD2
		public IVectorInfoT RaycastDestOffset { get; set; }

		// Token: 0x060248CD RID: 149709 RVA: 0x005058DB File Offset: 0x00503ADB
		public IFoxJumpInteractPointRelationTypeT()
		{
			this.Type = EFoxJumpInteractPointRelationType.ThisEntity;
			this.Offset = null;
			this.RaycastDestOffset = null;
		}
	}
}
