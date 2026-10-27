using System;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02004CA9 RID: 19625
	public class RoleDevPropsConfig : IRoleDevPropsConfig
	{
		// Token: 0x17007D10 RID: 32016
		// (get) Token: 0x06032B58 RID: 207704 RVA: 0x00BD4F9E File Offset: 0x00BD319E
		// (set) Token: 0x06032B59 RID: 207705 RVA: 0x00BD4FA6 File Offset: 0x00BD31A6
		public int Id { get; set; }

		// Token: 0x17007D11 RID: 32017
		// (get) Token: 0x06032B5A RID: 207706 RVA: 0x00BD4FAF File Offset: 0x00BD31AF
		// (set) Token: 0x06032B5B RID: 207707 RVA: 0x00BD4FB7 File Offset: 0x00BD31B7
		public long ProspectBeginTime { get; set; }

		// Token: 0x17007D12 RID: 32018
		// (get) Token: 0x06032B5C RID: 207708 RVA: 0x00BD4FC0 File Offset: 0x00BD31C0
		// (set) Token: 0x06032B5D RID: 207709 RVA: 0x00BD4FC8 File Offset: 0x00BD31C8
		public long ProspectEndTime { get; set; }
	}
}
