using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056FB RID: 22267
	public class IEntityMatchConfigT
	{
		// Token: 0x1700A08A RID: 41098
		// (get) Token: 0x06023BF5 RID: 146421 RVA: 0x004EA046 File Offset: 0x004E8246
		// (set) Token: 0x06023BF6 RID: 146422 RVA: 0x004EA04E File Offset: 0x004E824E
		public EEntityMatchType Type { get; set; }

		// Token: 0x06023BF7 RID: 146423 RVA: 0x004EA057 File Offset: 0x004E8257
		public IEntityMatchConfigT()
		{
			this.Type = EEntityMatchType.Player;
		}
	}
}
