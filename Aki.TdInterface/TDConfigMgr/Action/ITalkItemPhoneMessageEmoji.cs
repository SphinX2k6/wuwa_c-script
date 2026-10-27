using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F4E RID: 8014
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkItemPhoneMessageEmoji : ITalkItemPhoneMessageBase
	{
		// Token: 0x0600AE56 RID: 44630 RVA: 0x001918EC File Offset: 0x0018FAEC
		private ITalkItemPhoneMessageEmoji_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkItemPhoneMessageEmoji 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkItemPhoneMessageEmoji_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemPhoneMessageEmoji_SetValue());
			}
			return result;
		}

		// Token: 0x0600AE57 RID: 44631 RVA: 0x00191924 File Offset: 0x0018FB24
		public static ITalkItemPhoneMessageEmoji Create([Nullable(2)] ITalkItemPhoneMessageEmoji instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemPhoneMessageEmoji
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AE58 RID: 44632 RVA: 0x00191937 File Offset: 0x0018FB37
		public static ITalkItemPhoneMessageEmoji CreateFromSetValue([Nullable(2)] ITalkItemPhoneMessageEmoji_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkItemPhoneMessageEmoji
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AE59 RID: 44633 RVA: 0x0019194A File Offset: 0x0018FB4A
		public new ITalkItemPhoneMessageEmoji_SetValue ToSetValue()
		{
			return new ITalkItemPhoneMessageEmoji_SetValue
			{
				Type = this.Type,
				EmojiId = this.EmojiId
			};
		}

		// Token: 0x1700358E RID: 13710
		// (get) Token: 0x0600AE5A RID: 44634 RVA: 0x00191969 File Offset: 0x0018FB69
		// (set) Token: 0x0600AE5B RID: 44635 RVA: 0x00191994 File Offset: 0x0018FB94
		public override EPhoneMessageType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPhoneMessageType.Voice;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700358F RID: 13711
		// (get) Token: 0x0600AE5C RID: 44636 RVA: 0x001919A2 File Offset: 0x0018FBA2
		// (set) Token: 0x0600AE5D RID: 44637 RVA: 0x001919CD File Offset: 0x0018FBCD
		public virtual int EmojiId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EmojiId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EmojiId;
			}
			set
			{
				this.GetOrCreatePoco().EmojiId = value;
			}
		}

		// Token: 0x040068CE RID: 26830
		[Nullable(2)]
		protected new ITalkItemPhoneMessageEmoji FbInstance;

		// Token: 0x040068CF RID: 26831
		[Nullable(2)]
		protected new ITalkItemPhoneMessageEmoji_SetValue PocoInterface;
	}
}
