using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C5F RID: 19551
	public class TCsvEffectConfigDataT
	{
		// Token: 0x17008AB1 RID: 35505
		// (get) Token: 0x0601DFF6 RID: 122870 RVA: 0x00434987 File Offset: 0x00432B87
		// (set) Token: 0x0601DFF7 RID: 122871 RVA: 0x0043498F File Offset: 0x00432B8F
		public int Id { get; set; }

		// Token: 0x17008AB2 RID: 35506
		// (get) Token: 0x0601DFF8 RID: 122872 RVA: 0x00434998 File Offset: 0x00432B98
		// (set) Token: 0x0601DFF9 RID: 122873 RVA: 0x004349A0 File Offset: 0x00432BA0
		public IEffectConfigBase_UnionUnion Data { get; set; }

		// Token: 0x0601DFFA RID: 122874 RVA: 0x004349A9 File Offset: 0x00432BA9
		public TCsvEffectConfigDataT()
		{
			this.Id = 0;
			this.Data = null;
		}
	}
}
