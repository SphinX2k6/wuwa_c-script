using System;

namespace Aki.UniverseEditor.Interface.Fbs.SyncBlock
{
	// Token: 0x02003B82 RID: 15234
	public class ISyncBlockT
	{
		// Token: 0x17006877 RID: 26743
		// (get) Token: 0x06014DF1 RID: 85489 RVA: 0x0030793A File Offset: 0x00305B3A
		// (set) Token: 0x06014DF2 RID: 85490 RVA: 0x00307942 File Offset: 0x00305B42
		public string Path { get; set; }

		// Token: 0x17006878 RID: 26744
		// (get) Token: 0x06014DF3 RID: 85491 RVA: 0x0030794B File Offset: 0x00305B4B
		// (set) Token: 0x06014DF4 RID: 85492 RVA: 0x00307953 File Offset: 0x00305B53
		public string Data { get; set; }

		// Token: 0x06014DF5 RID: 85493 RVA: 0x0030795C File Offset: 0x00305B5C
		public ISyncBlockT()
		{
			this.Path = null;
			this.Data = null;
		}
	}
}
