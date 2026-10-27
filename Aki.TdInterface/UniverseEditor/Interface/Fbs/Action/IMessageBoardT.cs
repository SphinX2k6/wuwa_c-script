using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AA1 RID: 27297
	public class IMessageBoardT
	{
		// Token: 0x1700CA98 RID: 51864
		// (get) Token: 0x0602FD5E RID: 195934 RVA: 0x00682013 File Offset: 0x00680213
		// (set) Token: 0x0602FD5F RID: 195935 RVA: 0x0068201B File Offset: 0x0068021B
		public EPhoneBoardType Type { get; set; }

		// Token: 0x1700CA99 RID: 51865
		// (get) Token: 0x0602FD60 RID: 195936 RVA: 0x00682024 File Offset: 0x00680224
		// (set) Token: 0x0602FD61 RID: 195937 RVA: 0x0068202C File Offset: 0x0068022C
		public IPhoneMessageBoardConfigT MessageBoardConfig { get; set; }

		// Token: 0x0602FD62 RID: 195938 RVA: 0x00682035 File Offset: 0x00680235
		public IMessageBoardT()
		{
			this.Type = EPhoneBoardType.MessageBoard;
			this.MessageBoardConfig = null;
		}
	}
}
