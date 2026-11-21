using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058A2 RID: 22690
	public class IGraph3dNodeNormalT
	{
		// Token: 0x1700A471 RID: 42097
		// (get) Token: 0x06024CDC RID: 150748 RVA: 0x0050DB87 File Offset: 0x0050BD87
		// (set) Token: 0x06024CDD RID: 150749 RVA: 0x0050DB8F File Offset: 0x0050BD8F
		public int Id { get; set; }

		// Token: 0x1700A472 RID: 42098
		// (get) Token: 0x06024CDE RID: 150750 RVA: 0x0050DB98 File Offset: 0x0050BD98
		// (set) Token: 0x06024CDF RID: 150751 RVA: 0x0050DBA0 File Offset: 0x0050BDA0
		public IVectorInfoT Position { get; set; }

		// Token: 0x06024CE0 RID: 150752 RVA: 0x0050DBA9 File Offset: 0x0050BDA9
		public IGraph3dNodeNormalT()
		{
			this.Id = 0;
			this.Position = null;
		}
	}
}
