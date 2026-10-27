using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063E3 RID: 25571
	public class IClientSendTagEventToControlCharacterT
	{
		// Token: 0x1700BE7F RID: 48767
		// (get) Token: 0x0602C3DD RID: 181213 RVA: 0x00612B47 File Offset: 0x00610D47
		// (set) Token: 0x0602C3DE RID: 181214 RVA: 0x00612B4F File Offset: 0x00610D4F
		public EExecClientBattleActionType Type { get; set; }

		// Token: 0x1700BE80 RID: 48768
		// (get) Token: 0x0602C3DF RID: 181215 RVA: 0x00612B58 File Offset: 0x00610D58
		// (set) Token: 0x0602C3E0 RID: 181216 RVA: 0x00612B60 File Offset: 0x00610D60
		public List<string> EventTags { get; set; }

		// Token: 0x0602C3E1 RID: 181217 RVA: 0x00612B69 File Offset: 0x00610D69
		public IClientSendTagEventToControlCharacterT()
		{
			this.Type = EExecClientBattleActionType.SendTagEventToControlCharacter;
			this.EventTags = null;
		}
	}
}
