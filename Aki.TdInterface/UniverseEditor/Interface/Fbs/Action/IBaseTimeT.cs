using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061E9 RID: 25065
	public class IBaseTimeT
	{
		// Token: 0x1700BADE RID: 47838
		// (get) Token: 0x0602B345 RID: 176965 RVA: 0x005F43B0 File Offset: 0x005F25B0
		// (set) Token: 0x0602B346 RID: 176966 RVA: 0x005F43B8 File Offset: 0x005F25B8
		public int Hour { get; set; }

		// Token: 0x1700BADF RID: 47839
		// (get) Token: 0x0602B347 RID: 176967 RVA: 0x005F43C1 File Offset: 0x005F25C1
		// (set) Token: 0x0602B348 RID: 176968 RVA: 0x005F43C9 File Offset: 0x005F25C9
		public int Minute { get; set; }

		// Token: 0x0602B349 RID: 176969 RVA: 0x005F43D2 File Offset: 0x005F25D2
		public IBaseTimeT()
		{
			this.Hour = 0;
			this.Minute = 0;
		}
	}
}
