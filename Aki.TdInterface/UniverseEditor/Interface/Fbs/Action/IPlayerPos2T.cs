using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D0C RID: 27916
	public class IPlayerPos2T
	{
		// Token: 0x1700CFE2 RID: 53218
		// (get) Token: 0x060313A6 RID: 201638 RVA: 0x006AD79F File Offset: 0x006AB99F
		// (set) Token: 0x060313A7 RID: 201639 RVA: 0x006AD7A7 File Offset: 0x006AB9A7
		public EPos2 Type { get; set; }

		// Token: 0x1700CFE3 RID: 53219
		// (get) Token: 0x060313A8 RID: 201640 RVA: 0x006AD7B0 File Offset: 0x006AB9B0
		// (set) Token: 0x060313A9 RID: 201641 RVA: 0x006AD7B8 File Offset: 0x006AB9B8
		public IVectorInfoT Offset { get; set; }

		// Token: 0x060313AA RID: 201642 RVA: 0x006AD7C1 File Offset: 0x006AB9C1
		public IPlayerPos2T()
		{
			this.Type = EPos2.Player;
			this.Offset = null;
		}
	}
}
