using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D84 RID: 28036
	public class IPostProcessVolumeCenterPositionT
	{
		// Token: 0x1700D12D RID: 53549
		// (get) Token: 0x0603186A RID: 202858 RVA: 0x006B69E7 File Offset: 0x006B4BE7
		// (set) Token: 0x0603186B RID: 202859 RVA: 0x006B69EF File Offset: 0x006B4BEF
		public EMpcEffectParamType Type { get; set; }

		// Token: 0x1700D12E RID: 53550
		// (get) Token: 0x0603186C RID: 202860 RVA: 0x006B69F8 File Offset: 0x006B4BF8
		// (set) Token: 0x0603186D RID: 202861 RVA: 0x006B6A00 File Offset: 0x006B4C00
		public IVectorInfoT Position { get; set; }

		// Token: 0x0603186E RID: 202862 RVA: 0x006B6A09 File Offset: 0x006B4C09
		public IPostProcessVolumeCenterPositionT()
		{
			this.Type = EMpcEffectParamType.PostProcessVolumeCenterPosition;
			this.Position = null;
		}
	}
}
