using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F32 RID: 16178
	public class IWoodenBoxProliferatePositionListT
	{
		// Token: 0x17006D97 RID: 28055
		// (get) Token: 0x06015FFD RID: 90109 RVA: 0x00329393 File Offset: 0x00327593
		// (set) Token: 0x06015FFE RID: 90110 RVA: 0x0032939B File Offset: 0x0032759B
		public EWoodenBoxProliferateSpawnType Type { get; set; }

		// Token: 0x17006D98 RID: 28056
		// (get) Token: 0x06015FFF RID: 90111 RVA: 0x003293A4 File Offset: 0x003275A4
		// (set) Token: 0x06016000 RID: 90112 RVA: 0x003293AC File Offset: 0x003275AC
		public List<IVectorInfoT> Positions { get; set; }

		// Token: 0x06016001 RID: 90113 RVA: 0x003293B5 File Offset: 0x003275B5
		public IWoodenBoxProliferatePositionListT()
		{
			this.Type = EWoodenBoxProliferateSpawnType.RandomInRange;
			this.Positions = null;
		}
	}
}
