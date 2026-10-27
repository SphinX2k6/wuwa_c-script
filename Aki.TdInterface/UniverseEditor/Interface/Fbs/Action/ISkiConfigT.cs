using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200711F RID: 28959
	public class ISkiConfigT
	{
		// Token: 0x1700D748 RID: 55112
		// (get) Token: 0x0603358A RID: 210314 RVA: 0x006EBD67 File Offset: 0x006E9F67
		// (set) Token: 0x0603358B RID: 210315 RVA: 0x006EBD6F File Offset: 0x006E9F6F
		public ESportStateType Type { get; set; }

		// Token: 0x1700D749 RID: 55113
		// (get) Token: 0x0603358C RID: 210316 RVA: 0x006EBD78 File Offset: 0x006E9F78
		// (set) Token: 0x0603358D RID: 210317 RVA: 0x006EBD80 File Offset: 0x006E9F80
		public TSkiConfigUnion Config { get; set; }

		// Token: 0x0603358E RID: 210318 RVA: 0x006EBD89 File Offset: 0x006E9F89
		public ISkiConfigT()
		{
			this.Type = ESportStateType.Slide;
			this.Config = null;
		}
	}
}
