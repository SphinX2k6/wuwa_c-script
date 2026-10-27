using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x0200556F RID: 21871
	[NullableContext(1)]
	public interface IWorldMapNavigateCountryData
	{
		// Token: 0x1700861B RID: 34331
		// (get) Token: 0x06037C2F RID: 228399
		int CountryId { get; }

		// Token: 0x1700861C RID: 34332
		// (get) Token: 0x06037C30 RID: 228400
		// (set) Token: 0x06037C31 RID: 228401
		IWorldMapNavigateCountry NavigateCountry { get; set; }
	}
}
