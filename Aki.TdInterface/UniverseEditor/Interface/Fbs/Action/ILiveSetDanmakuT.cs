using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007128 RID: 28968
	public class ILiveSetDanmakuT
	{
		// Token: 0x1700D41F RID: 54303
		// (get) Token: 0x0603252F RID: 206127 RVA: 0x006CDDCD File Offset: 0x006CBFCD
		// (set) Token: 0x06032530 RID: 206128 RVA: 0x006CDDD5 File Offset: 0x006CBFD5
		public TLiveDanmakuOperationUnion Operation { get; set; }

		// Token: 0x06032531 RID: 206129 RVA: 0x006CDDDE File Offset: 0x006CBFDE
		public ILiveSetDanmakuT()
		{
			this.Operation = null;
		}
	}
}
