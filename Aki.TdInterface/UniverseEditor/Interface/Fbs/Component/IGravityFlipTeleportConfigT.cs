using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058AE RID: 22702
	public class IGravityFlipTeleportConfigT
	{
		// Token: 0x1700A48B RID: 42123
		// (get) Token: 0x06024D58 RID: 150872 RVA: 0x0050ECC3 File Offset: 0x0050CEC3
		// (set) Token: 0x06024D59 RID: 150873 RVA: 0x0050ECCB File Offset: 0x0050CECB
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x1700A48C RID: 42124
		// (get) Token: 0x06024D5A RID: 150874 RVA: 0x0050ECD4 File Offset: 0x0050CED4
		// (set) Token: 0x06024D5B RID: 150875 RVA: 0x0050ECDC File Offset: 0x0050CEDC
		public IVectorInfoT SafeLocation { get; set; }

		// Token: 0x06024D5C RID: 150876 RVA: 0x0050ECE5 File Offset: 0x0050CEE5
		public IGravityFlipTeleportConfigT()
		{
			this.GravityDirection = null;
			this.SafeLocation = null;
		}
	}
}
