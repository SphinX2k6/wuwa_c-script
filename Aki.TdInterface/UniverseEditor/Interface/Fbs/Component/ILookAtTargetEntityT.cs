using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005516 RID: 21782
	public class ILookAtTargetEntityT
	{
		// Token: 0x1700A0CF RID: 41167
		// (get) Token: 0x06023FA5 RID: 147365 RVA: 0x004F8F8C File Offset: 0x004F718C
		// (set) Token: 0x06023FA6 RID: 147366 RVA: 0x004F8F94 File Offset: 0x004F7194
		public ELookAtTargetType Type { get; set; }

		// Token: 0x1700A0D0 RID: 41168
		// (get) Token: 0x06023FA7 RID: 147367 RVA: 0x004F8F9D File Offset: 0x004F719D
		// (set) Token: 0x06023FA8 RID: 147368 RVA: 0x004F8FA5 File Offset: 0x004F71A5
		public int EntityId { get; set; }

		// Token: 0x06023FA9 RID: 147369 RVA: 0x004F8FAE File Offset: 0x004F71AE
		public ILookAtTargetEntityT()
		{
			this.Type = ELookAtTargetType.Entity;
			this.EntityId = 0;
		}
	}
}
