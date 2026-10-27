using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200482A RID: 18474
	public class IBuffDurationBaseT
	{
		// Token: 0x1700849C RID: 33948
		// (get) Token: 0x0601C8EF RID: 116975 RVA: 0x00409EEA File Offset: 0x004080EA
		// (set) Token: 0x0601C8F0 RID: 116976 RVA: 0x00409EF2 File Offset: 0x004080F2
		public EBuffDurationType Type { get; set; }

		// Token: 0x0601C8F1 RID: 116977 RVA: 0x00409EFB File Offset: 0x004080FB
		public IBuffDurationBaseT()
		{
			this.Type = EBuffDurationType.Instant;
		}
	}
}
