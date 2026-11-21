using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057C7 RID: 22471
	public class IFireElementalMatchT
	{
		// Token: 0x1700A270 RID: 41584
		// (get) Token: 0x06024475 RID: 148597 RVA: 0x004FC406 File Offset: 0x004FA606
		// (set) Token: 0x06024476 RID: 148598 RVA: 0x004FC40E File Offset: 0x004FA60E
		public EElementalType Type { get; set; }

		// Token: 0x06024477 RID: 148599 RVA: 0x004FC417 File Offset: 0x004FA617
		public IFireElementalMatchT()
		{
			this.Type = EElementalType.Fire;
		}
	}
}
