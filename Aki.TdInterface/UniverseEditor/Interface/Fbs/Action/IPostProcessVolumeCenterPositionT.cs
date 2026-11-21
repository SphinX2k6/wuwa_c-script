using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074FF RID: 29951
	public class IPostProcessVolumeCenterPositionT
	{
		// Token: 0x1700DC75 RID: 56437
		// (get) Token: 0x06034866 RID: 215142 RVA: 0x007120CF File Offset: 0x007102CF
		// (set) Token: 0x06034867 RID: 215143 RVA: 0x007120D7 File Offset: 0x007102D7
		public EMpcEffectParamType Type { get; set; }

		// Token: 0x1700DC76 RID: 56438
		// (get) Token: 0x06034868 RID: 215144 RVA: 0x007120E0 File Offset: 0x007102E0
		// (set) Token: 0x06034869 RID: 215145 RVA: 0x007120E8 File Offset: 0x007102E8
		public IVectorInfoT Position { get; set; }

		// Token: 0x0603486A RID: 215146 RVA: 0x007120F1 File Offset: 0x007102F1
		public IPostProcessVolumeCenterPositionT()
		{
			this.Type = EMpcEffectParamType.PostProcessVolumeCenterPosition;
			this.Position = null;
		}
	}
}
