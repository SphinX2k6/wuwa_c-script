using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071C6 RID: 29126
	public class IMessageBoardT
	{
		// Token: 0x1700D548 RID: 54600
		// (get) Token: 0x06032A9A RID: 207514 RVA: 0x006D82D3 File Offset: 0x006D64D3
		// (set) Token: 0x06032A9B RID: 207515 RVA: 0x006D82DB File Offset: 0x006D64DB
		public EPhoneBoardType Type { get; set; }

		// Token: 0x1700D549 RID: 54601
		// (get) Token: 0x06032A9C RID: 207516 RVA: 0x006D82E4 File Offset: 0x006D64E4
		// (set) Token: 0x06032A9D RID: 207517 RVA: 0x006D82EC File Offset: 0x006D64EC
		public IPhoneMessageBoardConfigT MessageBoardConfig { get; set; }

		// Token: 0x06032A9E RID: 207518 RVA: 0x006D82F5 File Offset: 0x006D64F5
		public IMessageBoardT()
		{
			this.Type = EPhoneBoardType.MessageBoard;
			this.MessageBoardConfig = null;
		}
	}
}
