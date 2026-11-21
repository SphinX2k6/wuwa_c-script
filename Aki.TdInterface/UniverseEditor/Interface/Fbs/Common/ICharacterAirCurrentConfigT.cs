using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063A8 RID: 25512
	public class ICharacterAirCurrentConfigT
	{
		// Token: 0x1700BC8A RID: 48266
		// (get) Token: 0x0602B528 RID: 177448 RVA: 0x005E7AA4 File Offset: 0x005E5CA4
		// (set) Token: 0x0602B529 RID: 177449 RVA: 0x005E7AAC File Offset: 0x005E5CAC
		public long BulletId { get; set; }

		// Token: 0x1700BC8B RID: 48267
		// (get) Token: 0x0602B52A RID: 177450 RVA: 0x005E7AB5 File Offset: 0x005E5CB5
		// (set) Token: 0x0602B52B RID: 177451 RVA: 0x005E7ABD File Offset: 0x005E5CBD
		public IVectorInfoT Range { get; set; }

		// Token: 0x1700BC8C RID: 48268
		// (get) Token: 0x0602B52C RID: 177452 RVA: 0x005E7AC6 File Offset: 0x005E5CC6
		// (set) Token: 0x0602B52D RID: 177453 RVA: 0x005E7ACE File Offset: 0x005E5CCE
		public IVectorInfoT Offset { get; set; }

		// Token: 0x0602B52E RID: 177454 RVA: 0x005E7AD7 File Offset: 0x005E5CD7
		public ICharacterAirCurrentConfigT()
		{
			this.BulletId = 0L;
			this.Range = null;
			this.Offset = null;
		}
	}
}
