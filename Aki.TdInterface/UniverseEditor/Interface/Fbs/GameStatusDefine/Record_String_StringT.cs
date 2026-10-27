using System;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x0200471C RID: 18204
	public class Record_String_StringT
	{
		// Token: 0x1700826E RID: 33390
		// (get) Token: 0x0601BF3F RID: 114495 RVA: 0x003F6402 File Offset: 0x003F4602
		// (set) Token: 0x0601BF40 RID: 114496 RVA: 0x003F640A File Offset: 0x003F460A
		public string Key { get; set; }

		// Token: 0x1700826F RID: 33391
		// (get) Token: 0x0601BF41 RID: 114497 RVA: 0x003F6413 File Offset: 0x003F4613
		// (set) Token: 0x0601BF42 RID: 114498 RVA: 0x003F641B File Offset: 0x003F461B
		public string Value { get; set; }

		// Token: 0x0601BF43 RID: 114499 RVA: 0x003F6424 File Offset: 0x003F4624
		public Record_String_StringT()
		{
			this.Key = null;
			this.Value = null;
		}
	}
}
