using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007179 RID: 29049
	public class ILookAtBubbleEntityT
	{
		// Token: 0x1700D49F RID: 54431
		// (get) Token: 0x060327DA RID: 206810 RVA: 0x006D2EDB File Offset: 0x006D10DB
		// (set) Token: 0x060327DB RID: 206811 RVA: 0x006D2EE3 File Offset: 0x006D10E3
		public EDefaultLookAtType Type { get; set; }

		// Token: 0x1700D4A0 RID: 54432
		// (get) Token: 0x060327DC RID: 206812 RVA: 0x006D2EEC File Offset: 0x006D10EC
		// (set) Token: 0x060327DD RID: 206813 RVA: 0x006D2EF4 File Offset: 0x006D10F4
		public List<ILookAtBubbleEntityConfigT> BubbleEntityConfig { get; set; }

		// Token: 0x060327DE RID: 206814 RVA: 0x006D2EFD File Offset: 0x006D10FD
		public ILookAtBubbleEntityT()
		{
			this.Type = EDefaultLookAtType.LookAtBubbleEntity;
			this.BubbleEntityConfig = null;
		}
	}
}
