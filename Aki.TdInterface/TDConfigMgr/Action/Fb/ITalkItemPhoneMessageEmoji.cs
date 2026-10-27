using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002555 RID: 9557
	public class ITalkItemPhoneMessageEmoji : ITalkItemPhoneMessageBase
	{
		// Token: 0x0600D5C7 RID: 54727 RVA: 0x001FC142 File Offset: 0x001FA342
		[NullableContext(1)]
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

		// Token: 0x17003CDF RID: 15583
		// (get) Token: 0x0600D5C8 RID: 54728 RVA: 0x001FC161 File Offset: 0x001FA361
		public override EPhoneMessageType Type
		{
			get
			{
				return (EPhoneMessageType)this.Instance.Type;
			}
		}

		// Token: 0x17003CE0 RID: 15584
		// (get) Token: 0x0600D5C9 RID: 54729 RVA: 0x001FC16E File Offset: 0x001FA36E
		public virtual int EmojiId
		{
			get
			{
				return this.Instance.EmojiId;
			}
		}

		// Token: 0x040075C3 RID: 30147
		private ITalkItemPhoneMessageEmoji Instance;
	}
}
