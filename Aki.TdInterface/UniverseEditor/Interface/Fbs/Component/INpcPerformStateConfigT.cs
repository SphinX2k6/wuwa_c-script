using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200563F RID: 22079
	public class INpcPerformStateConfigT
	{
		// Token: 0x1700A392 RID: 41874
		// (get) Token: 0x06024B41 RID: 150337 RVA: 0x00510E79 File Offset: 0x0050F079
		// (set) Token: 0x06024B42 RID: 150338 RVA: 0x00510E81 File Offset: 0x0050F081
		public string State { get; set; }

		// Token: 0x1700A393 RID: 41875
		// (get) Token: 0x06024B43 RID: 150339 RVA: 0x00510E8A File Offset: 0x0050F08A
		// (set) Token: 0x06024B44 RID: 150340 RVA: 0x00510E92 File Offset: 0x0050F092
		public string MaterialDa { get; set; }

		// Token: 0x1700A394 RID: 41876
		// (get) Token: 0x06024B45 RID: 150341 RVA: 0x00510E9B File Offset: 0x0050F09B
		// (set) Token: 0x06024B46 RID: 150342 RVA: 0x00510EA3 File Offset: 0x0050F0A3
		public List<int> BuffEffectIds { get; set; }

		// Token: 0x1700A395 RID: 41877
		// (get) Token: 0x06024B47 RID: 150343 RVA: 0x00510EAC File Offset: 0x0050F0AC
		// (set) Token: 0x06024B48 RID: 150344 RVA: 0x00510EB4 File Offset: 0x0050F0B4
		public byte NullMask { get; set; }

		// Token: 0x06024B49 RID: 150345 RVA: 0x00510EBD File Offset: 0x0050F0BD
		public INpcPerformStateConfigT()
		{
			this.State = null;
			this.MaterialDa = null;
			this.BuffEffectIds = null;
			this.NullMask = 0;
		}
	}
}
