using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071A8 RID: 29096
	public class IMechExecuteT
	{
		// Token: 0x1700D521 RID: 54561
		// (get) Token: 0x060329C6 RID: 207302 RVA: 0x006D6CB0 File Offset: 0x006D4EB0
		// (set) Token: 0x060329C7 RID: 207303 RVA: 0x006D6CB8 File Offset: 0x006D4EB8
		public EExecClientBattleActionType Type { get; set; }

		// Token: 0x1700D522 RID: 54562
		// (get) Token: 0x060329C8 RID: 207304 RVA: 0x006D6CC1 File Offset: 0x006D4EC1
		// (set) Token: 0x060329C9 RID: 207305 RVA: 0x006D6CC9 File Offset: 0x006D4EC9
		public int EntityId { get; set; }

		// Token: 0x060329CA RID: 207306 RVA: 0x006D6CD2 File Offset: 0x006D4ED2
		public IMechExecuteT()
		{
			this.Type = EExecClientBattleActionType.SendTagEventToControlCharacter;
			this.EntityId = 0;
		}
	}
}
