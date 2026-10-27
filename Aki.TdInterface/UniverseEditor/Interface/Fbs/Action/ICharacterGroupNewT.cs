using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006338 RID: 25400
	public class ICharacterGroupNewT
	{
		// Token: 0x1700BD91 RID: 48529
		// (get) Token: 0x0602BEFD RID: 179965 RVA: 0x0060A06C File Offset: 0x0060826C
		// (set) Token: 0x0602BEFE RID: 179966 RVA: 0x0060A074 File Offset: 0x00608274
		public int CharacterId { get; set; }

		// Token: 0x1700BD92 RID: 48530
		// (get) Token: 0x0602BEFF RID: 179967 RVA: 0x0060A07D File Offset: 0x0060827D
		// (set) Token: 0x0602BF00 RID: 179968 RVA: 0x0060A085 File Offset: 0x00608285
		public bool IsAiCharacter { get; set; }

		// Token: 0x0602BF01 RID: 179969 RVA: 0x0060A08E File Offset: 0x0060828E
		public ICharacterGroupNewT()
		{
			this.CharacterId = 0;
			this.IsAiCharacter = false;
		}
	}
}
