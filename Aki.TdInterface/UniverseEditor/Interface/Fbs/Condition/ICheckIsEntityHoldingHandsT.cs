using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F4B RID: 20299
	public class ICheckIsEntityHoldingHandsT
	{
		// Token: 0x17009111 RID: 37137
		// (get) Token: 0x0601F949 RID: 129353 RVA: 0x00464B10 File Offset: 0x00462D10
		// (set) Token: 0x0601F94A RID: 129354 RVA: 0x00464B18 File Offset: 0x00462D18
		public ECheckHoldingHandsCharacter Type { get; set; }

		// Token: 0x17009112 RID: 37138
		// (get) Token: 0x0601F94B RID: 129355 RVA: 0x00464B21 File Offset: 0x00462D21
		// (set) Token: 0x0601F94C RID: 129356 RVA: 0x00464B29 File Offset: 0x00462D29
		public int EntityId { get; set; }

		// Token: 0x0601F94D RID: 129357 RVA: 0x00464B32 File Offset: 0x00462D32
		public ICheckIsEntityHoldingHandsT()
		{
			this.Type = ECheckHoldingHandsCharacter.Player;
			this.EntityId = 0;
		}
	}
}
