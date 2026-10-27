using System;

namespace Aki.Protocol
{
	// Token: 0x02000002 RID: 2
	public interface IProto_NormalItem
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1
		int Id { get; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000002 RID: 2
		int Count { get; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000003 RID: 3
		long ExpireTime { get; }
	}
}
