using System;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02003C59 RID: 15449
	public interface IRoleDevPropsConfig
	{
		// Token: 0x170050B7 RID: 20663
		// (get) Token: 0x06027906 RID: 162054
		// (set) Token: 0x06027907 RID: 162055
		int Id { get; set; }

		// Token: 0x170050B8 RID: 20664
		// (get) Token: 0x06027908 RID: 162056
		// (set) Token: 0x06027909 RID: 162057
		long ProspectBeginTime { get; set; }

		// Token: 0x170050B9 RID: 20665
		// (get) Token: 0x0602790A RID: 162058
		// (set) Token: 0x0602790B RID: 162059
		long ProspectEndTime { get; set; }
	}
}
