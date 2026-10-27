using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200531C RID: 21276
	public class IGraph3dNodeNormalT
	{
		// Token: 0x17009C39 RID: 39993
		// (get) Token: 0x06022C28 RID: 142376 RVA: 0x004D0CB3 File Offset: 0x004CEEB3
		// (set) Token: 0x06022C29 RID: 142377 RVA: 0x004D0CBB File Offset: 0x004CEEBB
		public int Id { get; set; }

		// Token: 0x17009C3A RID: 39994
		// (get) Token: 0x06022C2A RID: 142378 RVA: 0x004D0CC4 File Offset: 0x004CEEC4
		// (set) Token: 0x06022C2B RID: 142379 RVA: 0x004D0CCC File Offset: 0x004CEECC
		public IVectorInfoT Position { get; set; }

		// Token: 0x06022C2C RID: 142380 RVA: 0x004D0CD5 File Offset: 0x004CEED5
		public IGraph3dNodeNormalT()
		{
			this.Id = 0;
			this.Position = null;
		}
	}
}
