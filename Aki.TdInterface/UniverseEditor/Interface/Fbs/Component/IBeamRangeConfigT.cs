using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F0E RID: 20238
	public class IBeamRangeConfigT
	{
		// Token: 0x170091B0 RID: 37296
		// (get) Token: 0x0601FFCC RID: 131020 RVA: 0x004738D5 File Offset: 0x00471AD5
		// (set) Token: 0x0601FFCD RID: 131021 RVA: 0x004738DD File Offset: 0x00471ADD
		public float Radius { get; set; }

		// Token: 0x170091B1 RID: 37297
		// (get) Token: 0x0601FFCE RID: 131022 RVA: 0x004738E6 File Offset: 0x00471AE6
		// (set) Token: 0x0601FFCF RID: 131023 RVA: 0x004738EE File Offset: 0x00471AEE
		public float Length { get; set; }

		// Token: 0x170091B2 RID: 37298
		// (get) Token: 0x0601FFD0 RID: 131024 RVA: 0x004738F7 File Offset: 0x00471AF7
		// (set) Token: 0x0601FFD1 RID: 131025 RVA: 0x004738FF File Offset: 0x00471AFF
		public IVectorInfoT PosOffset { get; set; }

		// Token: 0x0601FFD2 RID: 131026 RVA: 0x00473908 File Offset: 0x00471B08
		public IBeamRangeConfigT()
		{
			this.Radius = 0f;
			this.Length = 0f;
			this.PosOffset = null;
		}
	}
}
