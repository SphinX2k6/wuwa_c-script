using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BCB RID: 23499
	public class IWuWaGoMovableGridStatePosT
	{
		// Token: 0x1700B18F RID: 45455
		// (get) Token: 0x0602841F RID: 164895 RVA: 0x00587FD7 File Offset: 0x005861D7
		// (set) Token: 0x06028420 RID: 164896 RVA: 0x00587FDF File Offset: 0x005861DF
		public string EntityState { get; set; }

		// Token: 0x1700B190 RID: 45456
		// (get) Token: 0x06028421 RID: 164897 RVA: 0x00587FE8 File Offset: 0x005861E8
		// (set) Token: 0x06028422 RID: 164898 RVA: 0x00587FF0 File Offset: 0x005861F0
		public IVectorInfoT GridPos { get; set; }

		// Token: 0x06028423 RID: 164899 RVA: 0x00587FF9 File Offset: 0x005861F9
		public IWuWaGoMovableGridStatePosT()
		{
			this.EntityState = null;
			this.GridPos = null;
		}
	}
}
