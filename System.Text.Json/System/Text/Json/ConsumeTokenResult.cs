using System;

namespace System.Text.Json
{
	// Token: 0x02000031 RID: 49
	internal enum ConsumeTokenResult : byte
	{
		// Token: 0x0400008F RID: 143
		Success,
		// Token: 0x04000090 RID: 144
		NotEnoughDataRollBackState,
		// Token: 0x04000091 RID: 145
		IncompleteNoRollBackNecessary
	}
}
