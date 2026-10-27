using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A5A RID: 27226
	public class ILookAtBubbleEntityConfigT
	{
		// Token: 0x1700C9FA RID: 51706
		// (get) Token: 0x0602FAD4 RID: 195284 RVA: 0x0067D231 File Offset: 0x0067B431
		// (set) Token: 0x0602FAD5 RID: 195285 RVA: 0x0067D239 File Offset: 0x0067B439
		public int BubbleEntity { get; set; }

		// Token: 0x1700C9FB RID: 51707
		// (get) Token: 0x0602FAD6 RID: 195286 RVA: 0x0067D242 File Offset: 0x0067B442
		// (set) Token: 0x0602FAD7 RID: 195287 RVA: 0x0067D24A File Offset: 0x0067B44A
		public List<int> RangeEntities { get; set; }

		// Token: 0x1700C9FC RID: 51708
		// (get) Token: 0x0602FAD8 RID: 195288 RVA: 0x0067D253 File Offset: 0x0067B453
		// (set) Token: 0x0602FAD9 RID: 195289 RVA: 0x0067D25B File Offset: 0x0067B45B
		public IEntityLookAtPerformT EntityLookAtPerform { get; set; }

		// Token: 0x0602FADA RID: 195290 RVA: 0x0067D264 File Offset: 0x0067B464
		public ILookAtBubbleEntityConfigT()
		{
			this.BubbleEntity = 0;
			this.RangeEntities = null;
			this.EntityLookAtPerform = null;
		}
	}
}
