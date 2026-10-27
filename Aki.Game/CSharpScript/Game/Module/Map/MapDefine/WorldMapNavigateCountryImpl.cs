using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x0200556E RID: 21870
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapNavigateCountryImpl : IWorldMapNavigateCountry
	{
		// Token: 0x17008619 RID: 34329
		// (get) Token: 0x06037C2A RID: 228394 RVA: 0x00D38FD2 File Offset: 0x00D371D2
		// (set) Token: 0x06037C2B RID: 228395 RVA: 0x00D38FDA File Offset: 0x00D371DA
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, IWorldMapNavigateState> StateMap { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x1700861A RID: 34330
		// (get) Token: 0x06037C2C RID: 228396 RVA: 0x00D38FE3 File Offset: 0x00D371E3
		// (set) Token: 0x06037C2D RID: 228397 RVA: 0x00D38FEB File Offset: 0x00D371EB
		public List<IWorldMapNavigate> AreaNavigateList { get; set; } = new List<IWorldMapNavigate>();
	}
}
