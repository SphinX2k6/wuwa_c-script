using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007320 RID: 29472
	public class INpcGroupSequenceStaticEntityBindingT
	{
		// Token: 0x1700D806 RID: 55302
		// (get) Token: 0x0603364D RID: 210509 RVA: 0x006EDE37 File Offset: 0x006EC037
		// (set) Token: 0x0603364E RID: 210510 RVA: 0x006EDE3F File Offset: 0x006EC03F
		public ENpcGroupSequenceBindingType Type { get; set; }

		// Token: 0x1700D807 RID: 55303
		// (get) Token: 0x0603364F RID: 210511 RVA: 0x006EDE48 File Offset: 0x006EC048
		// (set) Token: 0x06033650 RID: 210512 RVA: 0x006EDE50 File Offset: 0x006EC050
		public List<int> Actors { get; set; }

		// Token: 0x06033651 RID: 210513 RVA: 0x006EDE59 File Offset: 0x006EC059
		public INpcGroupSequenceStaticEntityBindingT()
		{
			this.Type = ENpcGroupSequenceBindingType.StaticEntity;
			this.Actors = null;
		}
	}
}
