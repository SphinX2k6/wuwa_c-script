using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005827 RID: 22567
	public class IForwardFrontReboundT
	{
		// Token: 0x1700A356 RID: 41814
		// (get) Token: 0x0602484F RID: 149583 RVA: 0x00504557 File Offset: 0x00502757
		// (set) Token: 0x06024850 RID: 149584 RVA: 0x0050455F File Offset: 0x0050275F
		public EReboundOptionType Type { get; set; }

		// Token: 0x1700A357 RID: 41815
		// (get) Token: 0x06024851 RID: 149585 RVA: 0x00504568 File Offset: 0x00502768
		// (set) Token: 0x06024852 RID: 149586 RVA: 0x00504570 File Offset: 0x00502770
		public IVectorInfoT ReboundPoint { get; set; }

		// Token: 0x06024853 RID: 149587 RVA: 0x00504579 File Offset: 0x00502779
		public IForwardFrontReboundT()
		{
			this.Type = EReboundOptionType.ForwardFront;
			this.ReboundPoint = null;
		}
	}
}
