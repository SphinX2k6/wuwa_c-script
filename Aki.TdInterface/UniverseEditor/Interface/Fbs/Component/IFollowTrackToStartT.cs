using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052B9 RID: 21177
	public class IFollowTrackToStartT
	{
		// Token: 0x17009B49 RID: 39753
		// (get) Token: 0x06022877 RID: 141431 RVA: 0x004C9216 File Offset: 0x004C7416
		// (set) Token: 0x06022878 RID: 141432 RVA: 0x004C921E File Offset: 0x004C741E
		public EFollowTrackEndType Type { get; set; }

		// Token: 0x06022879 RID: 141433 RVA: 0x004C9227 File Offset: 0x004C7427
		public IFollowTrackToStartT()
		{
			this.Type = EFollowTrackEndType.ToStart;
		}
	}
}
