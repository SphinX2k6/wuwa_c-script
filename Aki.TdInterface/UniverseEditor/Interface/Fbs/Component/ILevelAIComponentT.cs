using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A4E RID: 23118
	public class ILevelAIComponentT
	{
		// Token: 0x1700A82A RID: 43050
		// (get) Token: 0x06025D08 RID: 154888 RVA: 0x0052F0CB File Offset: 0x0052D2CB
		// (set) Token: 0x06025D09 RID: 154889 RVA: 0x0052F0D3 File Offset: 0x0052D2D3
		public bool Disabled { get; set; }

		// Token: 0x1700A82B RID: 43051
		// (get) Token: 0x06025D0A RID: 154890 RVA: 0x0052F0DC File Offset: 0x0052D2DC
		// (set) Token: 0x06025D0B RID: 154891 RVA: 0x0052F0E4 File Offset: 0x0052D2E4
		public List<ILevelAIStateT> States { get; set; }

		// Token: 0x1700A82C RID: 43052
		// (get) Token: 0x06025D0C RID: 154892 RVA: 0x0052F0ED File Offset: 0x0052D2ED
		// (set) Token: 0x06025D0D RID: 154893 RVA: 0x0052F0F5 File Offset: 0x0052D2F5
		public string BtTreeAsset { get; set; }

		// Token: 0x1700A82D RID: 43053
		// (get) Token: 0x06025D0E RID: 154894 RVA: 0x0052F0FE File Offset: 0x0052D2FE
		// (set) Token: 0x06025D0F RID: 154895 RVA: 0x0052F106 File Offset: 0x0052D306
		public ICommonBtOverrideT CommonBtOverride { get; set; }

		// Token: 0x1700A82E RID: 43054
		// (get) Token: 0x06025D10 RID: 154896 RVA: 0x0052F10F File Offset: 0x0052D30F
		// (set) Token: 0x06025D11 RID: 154897 RVA: 0x0052F117 File Offset: 0x0052D317
		public byte NullMask { get; set; }

		// Token: 0x06025D12 RID: 154898 RVA: 0x0052F120 File Offset: 0x0052D320
		public ILevelAIComponentT()
		{
			this.Disabled = false;
			this.States = null;
			this.BtTreeAsset = null;
			this.CommonBtOverride = null;
			this.NullMask = 0;
		}
	}
}
