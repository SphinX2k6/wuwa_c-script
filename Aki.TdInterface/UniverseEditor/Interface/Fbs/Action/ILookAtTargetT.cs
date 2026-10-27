using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A60 RID: 27232
	public class ILookAtTargetT
	{
		// Token: 0x1700CA07 RID: 51719
		// (get) Token: 0x0602FB0C RID: 195340 RVA: 0x0067D8A7 File Offset: 0x0067BAA7
		// (set) Token: 0x0602FB0D RID: 195341 RVA: 0x0067D8AF File Offset: 0x0067BAAF
		public EDefaultLookAtType Type { get; set; }

		// Token: 0x1700CA08 RID: 51720
		// (get) Token: 0x0602FB0E RID: 195342 RVA: 0x0067D8B8 File Offset: 0x0067BAB8
		// (set) Token: 0x0602FB0F RID: 195343 RVA: 0x0067D8C0 File Offset: 0x0067BAC0
		public List<INpcLookAtConfigT> LookAtConfigs { get; set; }

		// Token: 0x0602FB10 RID: 195344 RVA: 0x0067D8C9 File Offset: 0x0067BAC9
		public ILookAtTargetT()
		{
			this.Type = EDefaultLookAtType.LookAtBubbleEntity;
			this.LookAtConfigs = null;
		}
	}
}
