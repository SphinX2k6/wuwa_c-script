using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005440 RID: 21568
	public class IBeamRangeConfigT
	{
		// Token: 0x17009932 RID: 39218
		// (get) Token: 0x06021D3C RID: 138556 RVA: 0x004A9C69 File Offset: 0x004A7E69
		// (set) Token: 0x06021D3D RID: 138557 RVA: 0x004A9C71 File Offset: 0x004A7E71
		public float Radius { get; set; }

		// Token: 0x17009933 RID: 39219
		// (get) Token: 0x06021D3E RID: 138558 RVA: 0x004A9C7A File Offset: 0x004A7E7A
		// (set) Token: 0x06021D3F RID: 138559 RVA: 0x004A9C82 File Offset: 0x004A7E82
		public float Length { get; set; }

		// Token: 0x17009934 RID: 39220
		// (get) Token: 0x06021D40 RID: 138560 RVA: 0x004A9C8B File Offset: 0x004A7E8B
		// (set) Token: 0x06021D41 RID: 138561 RVA: 0x004A9C93 File Offset: 0x004A7E93
		public IVectorInfoT PosOffset { get; set; }

		// Token: 0x06021D42 RID: 138562 RVA: 0x004A9C9C File Offset: 0x004A7E9C
		public IBeamRangeConfigT()
		{
			this.Radius = 0f;
			this.Length = 0f;
			this.PosOffset = null;
		}
	}
}
