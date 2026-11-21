using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027BD RID: 10173
	public class ITalkOptionPhoneMessageEmoji : ITalkOptionParamType
	{
		// Token: 0x0600E11C RID: 57628 RVA: 0x002118AA File Offset: 0x0020FAAA
		public static ITalkOptionPhoneMessageEmoji Create(ITalkOptionPhoneMessageEmoji? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionPhoneMessageEmoji
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E50 RID: 15952
		// (get) Token: 0x0600E11D RID: 57629 RVA: 0x002118C9 File Offset: 0x0020FAC9
		public override ETalkOptionParamType Type
		{
			get
			{
				return (ETalkOptionParamType)this.Instance.Type;
			}
		}

		// Token: 0x17003E51 RID: 15953
		// (get) Token: 0x0600E11E RID: 57630 RVA: 0x002118D8 File Offset: 0x0020FAD8
		public virtual int? EmojiId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.EmojiId);
			}
		}

		// Token: 0x04007A5B RID: 31323
		private ITalkOptionPhoneMessageEmoji Instance;
	}
}
