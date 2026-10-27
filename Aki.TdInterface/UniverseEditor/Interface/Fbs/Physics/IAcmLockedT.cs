using System;

namespace Aki.UniverseEditor.Interface.Fbs.Physics
{
	// Token: 0x02004343 RID: 17219
	public class IAcmLockedT
	{
		// Token: 0x17007994 RID: 31124
		// (get) Token: 0x0601987D RID: 104573 RVA: 0x003A7CAE File Offset: 0x003A5EAE
		// (set) Token: 0x0601987E RID: 104574 RVA: 0x003A7CB6 File Offset: 0x003A5EB6
		public EAngularConstraintMotion Type { get; set; }

		// Token: 0x0601987F RID: 104575 RVA: 0x003A7CBF File Offset: 0x003A5EBF
		public IAcmLockedT()
		{
			this.Type = EAngularConstraintMotion.ACM_Free;
		}
	}
}
