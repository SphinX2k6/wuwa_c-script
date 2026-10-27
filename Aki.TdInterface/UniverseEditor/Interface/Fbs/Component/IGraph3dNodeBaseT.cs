using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005319 RID: 21273
	public class IGraph3dNodeBaseT
	{
		// Token: 0x17009C34 RID: 39988
		// (get) Token: 0x06022C12 RID: 142354 RVA: 0x004D0A27 File Offset: 0x004CEC27
		// (set) Token: 0x06022C13 RID: 142355 RVA: 0x004D0A2F File Offset: 0x004CEC2F
		public int Id { get; set; }

		// Token: 0x17009C35 RID: 39989
		// (get) Token: 0x06022C14 RID: 142356 RVA: 0x004D0A38 File Offset: 0x004CEC38
		// (set) Token: 0x06022C15 RID: 142357 RVA: 0x004D0A40 File Offset: 0x004CEC40
		public IVectorInfoT Position { get; set; }

		// Token: 0x06022C16 RID: 142358 RVA: 0x004D0A49 File Offset: 0x004CEC49
		public IGraph3dNodeBaseT()
		{
			this.Id = 0;
			this.Position = null;
		}
	}
}
