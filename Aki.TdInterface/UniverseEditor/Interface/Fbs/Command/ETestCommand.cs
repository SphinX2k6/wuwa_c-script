using System;

namespace Aki.UniverseEditor.Interface.Fbs.Command
{
	// Token: 0x02006526 RID: 25894
	public enum ETestCommand : byte
	{
		// Token: 0x04010747 RID: 67399
		ResponsePreTest,
		// Token: 0x04010748 RID: 67400
		ResponsePostTest,
		// Token: 0x04010749 RID: 67401
		ResponseSpawnEntity,
		// Token: 0x0401074A RID: 67402
		ResponseDeleteEntity,
		// Token: 0x0401074B RID: 67403
		ResponseEnterFunctionalTestMode,
		// Token: 0x0401074C RID: 67404
		ResponseExitFunctionalTestMode
	}
}
