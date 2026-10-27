using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200634D RID: 25421
	public class ICharacterLookAtPositionDataT
	{
		// Token: 0x1700BDAB RID: 48555
		// (get) Token: 0x0602BF90 RID: 180112 RVA: 0x0060AFDB File Offset: 0x006091DB
		// (set) Token: 0x0602BF91 RID: 180113 RVA: 0x0060AFE3 File Offset: 0x006091E3
		public ECharacterLookAt Type { get; set; }

		// Token: 0x1700BDAC RID: 48556
		// (get) Token: 0x0602BF92 RID: 180114 RVA: 0x0060AFEC File Offset: 0x006091EC
		// (set) Token: 0x0602BF93 RID: 180115 RVA: 0x0060AFF4 File Offset: 0x006091F4
		public IVectorInfoT Pos { get; set; }

		// Token: 0x0602BF94 RID: 180116 RVA: 0x0060AFFD File Offset: 0x006091FD
		public ICharacterLookAtPositionDataT()
		{
			this.Type = ECharacterLookAt.Empty;
			this.Pos = null;
		}
	}
}
