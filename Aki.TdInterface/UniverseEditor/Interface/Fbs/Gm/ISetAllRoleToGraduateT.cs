using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AF3 RID: 19187
	public class ISetAllRoleToGraduateT
	{
		// Token: 0x17008676 RID: 34422
		// (get) Token: 0x0601CE86 RID: 118406 RVA: 0x0041165E File Offset: 0x0040F85E
		// (set) Token: 0x0601CE87 RID: 118407 RVA: 0x00411666 File Offset: 0x0040F866
		public EGmCommand Type { get; set; }

		// Token: 0x0601CE88 RID: 118408 RVA: 0x0041166F File Offset: 0x0040F86F
		public ISetAllRoleToGraduateT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
