using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02004541 RID: 17729
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapNavigateCountryImpl : IWorldMapNavigateCountry
	{
		// Token: 0x170059C2 RID: 22978
		// (get) Token: 0x0602CB04 RID: 183044 RVA: 0x00C86AA6 File Offset: 0x00C84CA6
		// (set) Token: 0x0602CB05 RID: 183045 RVA: 0x00C86AAE File Offset: 0x00C84CAE
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

		// Token: 0x170059C3 RID: 22979
		// (get) Token: 0x0602CB06 RID: 183046 RVA: 0x00C86AB7 File Offset: 0x00C84CB7
		// (set) Token: 0x0602CB07 RID: 183047 RVA: 0x00C86ABF File Offset: 0x00C84CBF
		public List<IWorldMapNavigate> AreaNavigateList { get; set; } = new List<IWorldMapNavigate>();
	}
}
