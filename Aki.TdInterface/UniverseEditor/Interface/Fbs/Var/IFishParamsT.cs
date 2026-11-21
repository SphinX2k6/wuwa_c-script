using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E90 RID: 16016
	public class IFishParamsT
	{
		// Token: 0x17006C48 RID: 27720
		// (get) Token: 0x06015A02 RID: 88578 RVA: 0x0031DBFF File Offset: 0x0031BDFF
		// (set) Token: 0x06015A03 RID: 88579 RVA: 0x0031DC07 File Offset: 0x0031BE07
		public EParamsPreset Type { get; set; }

		// Token: 0x17006C49 RID: 27721
		// (get) Token: 0x06015A04 RID: 88580 RVA: 0x0031DC10 File Offset: 0x0031BE10
		// (set) Token: 0x06015A05 RID: 88581 RVA: 0x0031DC18 File Offset: 0x0031BE18
		public TFishStateUnion State { get; set; }

		// Token: 0x06015A06 RID: 88582 RVA: 0x0031DC21 File Offset: 0x0031BE21
		public IFishParamsT()
		{
			this.Type = EParamsPreset.Decal;
			this.State = null;
		}
	}
}
