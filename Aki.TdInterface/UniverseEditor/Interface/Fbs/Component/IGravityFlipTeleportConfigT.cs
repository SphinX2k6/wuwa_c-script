using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005328 RID: 21288
	public class IGravityFlipTeleportConfigT
	{
		// Token: 0x17009C53 RID: 40019
		// (get) Token: 0x06022CA4 RID: 142500 RVA: 0x004D1DEF File Offset: 0x004CFFEF
		// (set) Token: 0x06022CA5 RID: 142501 RVA: 0x004D1DF7 File Offset: 0x004CFFF7
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x17009C54 RID: 40020
		// (get) Token: 0x06022CA6 RID: 142502 RVA: 0x004D1E00 File Offset: 0x004D0000
		// (set) Token: 0x06022CA7 RID: 142503 RVA: 0x004D1E08 File Offset: 0x004D0008
		public IVectorInfoT SafeLocation { get; set; }

		// Token: 0x06022CA8 RID: 142504 RVA: 0x004D1E11 File Offset: 0x004D0011
		public IGravityFlipTeleportConfigT()
		{
			this.GravityDirection = null;
			this.SafeLocation = null;
		}
	}
}
