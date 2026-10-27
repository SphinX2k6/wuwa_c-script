using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BD4 RID: 27604
	public class INpcLookAtTypeBaseT
	{
		// Token: 0x1700CD22 RID: 52514
		// (get) Token: 0x060307EE RID: 198638 RVA: 0x00695A96 File Offset: 0x00693C96
		// (set) Token: 0x060307EF RID: 198639 RVA: 0x00695A9E File Offset: 0x00693C9E
		public ECommonTargetType Type { get; set; }

		// Token: 0x060307F0 RID: 198640 RVA: 0x00695AA7 File Offset: 0x00693CA7
		public INpcLookAtTypeBaseT()
		{
			this.Type = ECommonTargetType.Player;
		}
	}
}
