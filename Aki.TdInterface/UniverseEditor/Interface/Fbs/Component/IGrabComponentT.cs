using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052FB RID: 21243
	public class IGrabComponentT
	{
		// Token: 0x17009BFD RID: 39933
		// (get) Token: 0x06022B28 RID: 142120 RVA: 0x004CF079 File Offset: 0x004CD279
		// (set) Token: 0x06022B29 RID: 142121 RVA: 0x004CF081 File Offset: 0x004CD281
		public bool Disabled { get; set; }

		// Token: 0x17009BFE RID: 39934
		// (get) Token: 0x06022B2A RID: 142122 RVA: 0x004CF08A File Offset: 0x004CD28A
		// (set) Token: 0x06022B2B RID: 142123 RVA: 0x004CF092 File Offset: 0x004CD292
		public IVectorInfoT GrabPos { get; set; }

		// Token: 0x17009BFF RID: 39935
		// (get) Token: 0x06022B2C RID: 142124 RVA: 0x004CF09B File Offset: 0x004CD29B
		// (set) Token: 0x06022B2D RID: 142125 RVA: 0x004CF0A3 File Offset: 0x004CD2A3
		public int ThrowPow { get; set; }

		// Token: 0x17009C00 RID: 39936
		// (get) Token: 0x06022B2E RID: 142126 RVA: 0x004CF0AC File Offset: 0x004CD2AC
		// (set) Token: 0x06022B2F RID: 142127 RVA: 0x004CF0B4 File Offset: 0x004CD2B4
		public int ThrowHight { get; set; }

		// Token: 0x17009C01 RID: 39937
		// (get) Token: 0x06022B30 RID: 142128 RVA: 0x004CF0BD File Offset: 0x004CD2BD
		// (set) Token: 0x06022B31 RID: 142129 RVA: 0x004CF0C5 File Offset: 0x004CD2C5
		public byte NullMask { get; set; }

		// Token: 0x06022B32 RID: 142130 RVA: 0x004CF0CE File Offset: 0x004CD2CE
		public IGrabComponentT()
		{
			this.Disabled = false;
			this.GrabPos = null;
			this.ThrowPow = 0;
			this.ThrowHight = 0;
			this.NullMask = 0;
		}
	}
}
