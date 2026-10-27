using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005070 RID: 20592
	public class IDamageTextOptimizationConfigT
	{
		// Token: 0x17009564 RID: 38244
		// (get) Token: 0x06021019 RID: 135193 RVA: 0x00495F82 File Offset: 0x00494182
		// (set) Token: 0x0602101A RID: 135194 RVA: 0x00495F8A File Offset: 0x0049418A
		public EPerformanceOptimizationType Type { get; set; }

		// Token: 0x17009565 RID: 38245
		// (get) Token: 0x0602101B RID: 135195 RVA: 0x00495F93 File Offset: 0x00494193
		// (set) Token: 0x0602101C RID: 135196 RVA: 0x00495F9B File Offset: 0x0049419B
		public bool UseRange { get; set; }

		// Token: 0x17009566 RID: 38246
		// (get) Token: 0x0602101D RID: 135197 RVA: 0x00495FA4 File Offset: 0x004941A4
		// (set) Token: 0x0602101E RID: 135198 RVA: 0x00495FAC File Offset: 0x004941AC
		public byte NullMask { get; set; }

		// Token: 0x0602101F RID: 135199 RVA: 0x00495FB5 File Offset: 0x004941B5
		public IDamageTextOptimizationConfigT()
		{
			this.Type = EPerformanceOptimizationType.PlaneMovementOptimization;
			this.UseRange = false;
			this.NullMask = 0;
		}
	}
}
