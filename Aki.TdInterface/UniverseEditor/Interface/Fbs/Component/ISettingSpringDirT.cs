using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F13 RID: 24339
	public class ISettingSpringDirT
	{
		// Token: 0x1700B407 RID: 46087
		// (get) Token: 0x06028DA8 RID: 167336 RVA: 0x0059538D File Offset: 0x0059358D
		// (set) Token: 0x06028DA9 RID: 167337 RVA: 0x00595395 File Offset: 0x00593595
		public bool IsSettingDir { get; set; }

		// Token: 0x1700B408 RID: 46088
		// (get) Token: 0x06028DAA RID: 167338 RVA: 0x0059539E File Offset: 0x0059359E
		// (set) Token: 0x06028DAB RID: 167339 RVA: 0x005953A6 File Offset: 0x005935A6
		public bool IsRotator { get; set; }

		// Token: 0x1700B409 RID: 46089
		// (get) Token: 0x06028DAC RID: 167340 RVA: 0x005953AF File Offset: 0x005935AF
		// (set) Token: 0x06028DAD RID: 167341 RVA: 0x005953B7 File Offset: 0x005935B7
		public IVectorInfoT SpringDir { get; set; }

		// Token: 0x06028DAE RID: 167342 RVA: 0x005953C0 File Offset: 0x005935C0
		public ISettingSpringDirT()
		{
			this.IsSettingDir = false;
			this.IsRotator = false;
			this.SpringDir = null;
		}
	}
}
