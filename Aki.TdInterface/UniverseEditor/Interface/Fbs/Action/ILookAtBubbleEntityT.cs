using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A57 RID: 27223
	public class ILookAtBubbleEntityT
	{
		// Token: 0x1700C9F4 RID: 51700
		// (get) Token: 0x0602FAB4 RID: 195252 RVA: 0x0067CE1B File Offset: 0x0067B01B
		// (set) Token: 0x0602FAB5 RID: 195253 RVA: 0x0067CE23 File Offset: 0x0067B023
		public EDefaultLookAtType Type { get; set; }

		// Token: 0x1700C9F5 RID: 51701
		// (get) Token: 0x0602FAB6 RID: 195254 RVA: 0x0067CE2C File Offset: 0x0067B02C
		// (set) Token: 0x0602FAB7 RID: 195255 RVA: 0x0067CE34 File Offset: 0x0067B034
		public List<ILookAtBubbleEntityConfigT> BubbleEntityConfig { get; set; }

		// Token: 0x0602FAB8 RID: 195256 RVA: 0x0067CE3D File Offset: 0x0067B03D
		public ILookAtBubbleEntityT()
		{
			this.Type = EDefaultLookAtType.LookAtBubbleEntity;
			this.BubbleEntityConfig = null;
		}
	}
}
