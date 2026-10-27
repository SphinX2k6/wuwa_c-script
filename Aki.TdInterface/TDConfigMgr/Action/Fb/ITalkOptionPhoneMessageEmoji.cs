using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002517 RID: 9495
	public class ITalkOptionPhoneMessageEmoji : ITalkOptionParamType
	{
		// Token: 0x0600D3C0 RID: 54208 RVA: 0x001F5EB2 File Offset: 0x001F40B2
		[NullableContext(1)]
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

		// Token: 0x17003B54 RID: 15188
		// (get) Token: 0x0600D3C1 RID: 54209 RVA: 0x001F5ED1 File Offset: 0x001F40D1
		public override ETalkOptionParamType Type
		{
			get
			{
				return (ETalkOptionParamType)this.Instance.Type;
			}
		}

		// Token: 0x17003B55 RID: 15189
		// (get) Token: 0x0600D3C2 RID: 54210 RVA: 0x001F5EE0 File Offset: 0x001F40E0
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

		// Token: 0x04007409 RID: 29705
		private ITalkOptionPhoneMessageEmoji Instance;
	}
}
