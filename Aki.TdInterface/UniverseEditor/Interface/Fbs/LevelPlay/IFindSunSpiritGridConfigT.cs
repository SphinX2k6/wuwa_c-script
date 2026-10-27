using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044B9 RID: 17593
	public class IFindSunSpiritGridConfigT
	{
		// Token: 0x17007C27 RID: 31783
		// (get) Token: 0x0601A48E RID: 107662 RVA: 0x003C11EB File Offset: 0x003BF3EB
		// (set) Token: 0x0601A48F RID: 107663 RVA: 0x003C11F3 File Offset: 0x003BF3F3
		public List<TFindSunSpiritGridUnion> Grids { get; set; }

		// Token: 0x17007C28 RID: 31784
		// (get) Token: 0x0601A490 RID: 107664 RVA: 0x003C11FC File Offset: 0x003BF3FC
		// (set) Token: 0x0601A491 RID: 107665 RVA: 0x003C1204 File Offset: 0x003BF404
		public IVector2T BoardSize { get; set; }

		// Token: 0x0601A492 RID: 107666 RVA: 0x003C120D File Offset: 0x003BF40D
		public IFindSunSpiritGridConfigT()
		{
			this.Grids = null;
			this.BoardSize = null;
		}
	}
}
