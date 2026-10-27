using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007440 RID: 29760
	public class ITransitionPopupArtTextTypeBaseT
	{
		// Token: 0x1700E1F5 RID: 57845
		// (get) Token: 0x06036110 RID: 221456 RVA: 0x0075A81E File Offset: 0x00758A1E
		// (set) Token: 0x06036111 RID: 221457 RVA: 0x0075A826 File Offset: 0x00758A26
		public ETransitionPopupArtTextType Type { get; set; }

		// Token: 0x06036112 RID: 221458 RVA: 0x0075A82F File Offset: 0x00758A2F
		public ITransitionPopupArtTextTypeBaseT()
		{
			this.Type = ETransitionPopupArtTextType.YuanCheng;
		}
	}
}
