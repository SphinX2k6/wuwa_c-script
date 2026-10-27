using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200154D RID: 5453
	public enum AdventreTaskSate
	{
		// Token: 0x0400A585 RID: 42373
		[OriginalName("UnFinish")]
		UnFinish,
		// Token: 0x0400A586 RID: 42374
		[OriginalName("Finish")]
		Finish,
		// Token: 0x0400A587 RID: 42375
		[OriginalName("Received")]
		Received
	}
}
