using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004DFB RID: 19963
	public enum ENodeStatusType : byte
	{
		// Token: 0x0400DB9B RID: 56219
		NotActive,
		// Token: 0x0400DB9C RID: 56220
		BeforeActivate,
		// Token: 0x0400DB9D RID: 56221
		Activated,
		// Token: 0x0400DB9E RID: 56222
		Completing,
		// Token: 0x0400DB9F RID: 56223
		CompletedSuccess,
		// Token: 0x0400DBA0 RID: 56224
		CompletedFailed,
		// Token: 0x0400DBA1 RID: 56225
		Suspend,
		// Token: 0x0400DBA2 RID: 56226
		Destroy
	}
}
