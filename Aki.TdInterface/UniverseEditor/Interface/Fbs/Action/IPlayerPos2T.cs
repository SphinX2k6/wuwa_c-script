using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007487 RID: 29831
	public class IPlayerPos2T
	{
		// Token: 0x1700DB26 RID: 56102
		// (get) Token: 0x0603439A RID: 213914 RVA: 0x00708CCF File Offset: 0x00706ECF
		// (set) Token: 0x0603439B RID: 213915 RVA: 0x00708CD7 File Offset: 0x00706ED7
		public EPos2 Type { get; set; }

		// Token: 0x1700DB27 RID: 56103
		// (get) Token: 0x0603439C RID: 213916 RVA: 0x00708CE0 File Offset: 0x00706EE0
		// (set) Token: 0x0603439D RID: 213917 RVA: 0x00708CE8 File Offset: 0x00706EE8
		public IVectorInfoT Offset { get; set; }

		// Token: 0x0603439E RID: 213918 RVA: 0x00708CF1 File Offset: 0x00706EF1
		public IPlayerPos2T()
		{
			this.Type = EPos2.Player;
			this.Offset = null;
		}
	}
}
