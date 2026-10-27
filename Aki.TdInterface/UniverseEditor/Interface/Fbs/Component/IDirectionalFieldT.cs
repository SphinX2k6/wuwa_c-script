using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200508B RID: 20619
	public class IDirectionalFieldT
	{
		// Token: 0x170095BC RID: 38332
		// (get) Token: 0x06021177 RID: 135543 RVA: 0x0049938B File Offset: 0x0049758B
		// (set) Token: 0x06021178 RID: 135544 RVA: 0x00499393 File Offset: 0x00497593
		public EConveyorBeltFieldType Type { get; set; }

		// Token: 0x170095BD RID: 38333
		// (get) Token: 0x06021179 RID: 135545 RVA: 0x0049939C File Offset: 0x0049759C
		// (set) Token: 0x0602117A RID: 135546 RVA: 0x004993A4 File Offset: 0x004975A4
		public IVectorInfoT Direction { get; set; }

		// Token: 0x0602117B RID: 135547 RVA: 0x004993AD File Offset: 0x004975AD
		public IDirectionalFieldT()
		{
			this.Type = EConveyorBeltFieldType.DirectionalField;
			this.Direction = null;
		}
	}
}
