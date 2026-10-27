using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059D5 RID: 22997
	public class IStreamingSourceConfigT
	{
		// Token: 0x1700ACCB RID: 44235
		// (get) Token: 0x0602703E RID: 159806 RVA: 0x0055E6C6 File Offset: 0x0055C8C6
		// (set) Token: 0x0602703F RID: 159807 RVA: 0x0055E6CE File Offset: 0x0055C8CE
		public int StreamingSourceTargetEntityId { get; set; }

		// Token: 0x1700ACCC RID: 44236
		// (get) Token: 0x06027040 RID: 159808 RVA: 0x0055E6D7 File Offset: 0x0055C8D7
		// (set) Token: 0x06027041 RID: 159809 RVA: 0x0055E6DF File Offset: 0x0055C8DF
		public bool IsNoRenderStreaming { get; set; }

		// Token: 0x1700ACCD RID: 44237
		// (get) Token: 0x06027042 RID: 159810 RVA: 0x0055E6E8 File Offset: 0x0055C8E8
		// (set) Token: 0x06027043 RID: 159811 RVA: 0x0055E6F0 File Offset: 0x0055C8F0
		public byte NullMask { get; set; }

		// Token: 0x06027044 RID: 159812 RVA: 0x0055E6F9 File Offset: 0x0055C8F9
		public IStreamingSourceConfigT()
		{
			this.StreamingSourceTargetEntityId = 0;
			this.IsNoRenderStreaming = false;
			this.NullMask = 0;
		}
	}
}
