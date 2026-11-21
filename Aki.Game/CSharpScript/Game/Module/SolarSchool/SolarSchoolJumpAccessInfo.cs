using System;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059D4 RID: 22996
	public readonly struct SolarSchoolJumpAccessInfo
	{
		// Token: 0x06038A99 RID: 232089 RVA: 0x00FDB870 File Offset: 0x00FD9A70
		public SolarSchoolJumpAccessInfo(ESolarSchoolJumpAccess access, int param)
		{
			this.Access = access;
			this.Param = param;
		}

		// Token: 0x0401DD62 RID: 122210
		public readonly ESolarSchoolJumpAccess Access;

		// Token: 0x0401DD63 RID: 122211
		public readonly int Param;
	}
}
