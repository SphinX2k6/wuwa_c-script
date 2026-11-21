using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027FE RID: 10238
	public class ITalkItemPhoneMessageEmoji : ITalkItemPhoneMessageBase
	{
		// Token: 0x0600E331 RID: 58161 RVA: 0x00217D3E File Offset: 0x00215F3E
		public static ITalkItemPhoneMessageEmoji Create(ITalkItemPhoneMessageEmoji? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemPhoneMessageEmoji
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003FE3 RID: 16355
		// (get) Token: 0x0600E332 RID: 58162 RVA: 0x00217D5D File Offset: 0x00215F5D
		public override EPhoneMessageType Type
		{
			get
			{
				return (EPhoneMessageType)this.Instance.Type;
			}
		}

		// Token: 0x17003FE4 RID: 16356
		// (get) Token: 0x0600E333 RID: 58163 RVA: 0x00217D6A File Offset: 0x00215F6A
		public virtual int EmojiId
		{
			get
			{
				return this.Instance.EmojiId;
			}
		}

		// Token: 0x04007C20 RID: 31776
		private ITalkItemPhoneMessageEmoji Instance;
	}
}
