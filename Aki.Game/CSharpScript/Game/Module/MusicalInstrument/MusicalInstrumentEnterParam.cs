using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.MusicalInstrument
{
	// Token: 0x02005372 RID: 21362
	public class MusicalInstrumentEnterParam
	{
		// Token: 0x17008352 RID: 33618
		// (get) Token: 0x06036944 RID: 223556 RVA: 0x00CECAD5 File Offset: 0x00CEACD5
		// (set) Token: 0x06036945 RID: 223557 RVA: 0x00CECADD File Offset: 0x00CEACDD
		public EInstrumentType Type { get; set; }

		// Token: 0x17008353 RID: 33619
		// (get) Token: 0x06036946 RID: 223558 RVA: 0x00CECAE6 File Offset: 0x00CEACE6
		// (set) Token: 0x06036947 RID: 223559 RVA: 0x00CECAEE File Offset: 0x00CEACEE
		public int? QteId { get; set; }
	}
}
