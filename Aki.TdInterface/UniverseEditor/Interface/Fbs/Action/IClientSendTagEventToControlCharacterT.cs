using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A63 RID: 27235
	public class IClientSendTagEventToControlCharacterT
	{
		// Token: 0x1700C819 RID: 51225
		// (get) Token: 0x0602EBB3 RID: 191411 RVA: 0x0065E9D3 File Offset: 0x0065CBD3
		// (set) Token: 0x0602EBB4 RID: 191412 RVA: 0x0065E9DB File Offset: 0x0065CBDB
		public EExecClientBattleActionType Type { get; set; }

		// Token: 0x1700C81A RID: 51226
		// (get) Token: 0x0602EBB5 RID: 191413 RVA: 0x0065E9E4 File Offset: 0x0065CBE4
		// (set) Token: 0x0602EBB6 RID: 191414 RVA: 0x0065E9EC File Offset: 0x0065CBEC
		public List<string> EventTags { get; set; }

		// Token: 0x0602EBB7 RID: 191415 RVA: 0x0065E9F5 File Offset: 0x0065CBF5
		public IClientSendTagEventToControlCharacterT()
		{
			this.Type = EExecClientBattleActionType.SendTagEventToControlCharacter;
			this.EventTags = null;
		}
	}
}
