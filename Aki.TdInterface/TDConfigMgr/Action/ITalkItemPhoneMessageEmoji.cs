using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002187 RID: 8583
	public class ITalkItemPhoneMessageEmoji : ITalkItemPhoneMessageBase
	{
		// Token: 0x0600B928 RID: 47400 RVA: 0x001A78E4 File Offset: 0x001A5AE4
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

		// Token: 0x0600B929 RID: 47401 RVA: 0x001A791C File Offset: 0x001A5B1C
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

		// Token: 0x0600B92A RID: 47402 RVA: 0x001A792F File Offset: 0x001A5B2F
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

		// Token: 0x0600B92B RID: 47403 RVA: 0x001A7942 File Offset: 0x001A5B42
		public new ITalkItemPhoneMessageEmoji_SetValue ToSetValue()
		{
			return new ITalkItemPhoneMessageEmoji_SetValue
			{
				Type = this.Type,
				EmojiId = this.EmojiId
			};
		}

		// Token: 0x17003859 RID: 14425
		// (get) Token: 0x0600B92C RID: 47404 RVA: 0x001A7961 File Offset: 0x001A5B61
		// (set) Token: 0x0600B92D RID: 47405 RVA: 0x001A798C File Offset: 0x001A5B8C
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

		// Token: 0x1700385A RID: 14426
		// (get) Token: 0x0600B92E RID: 47406 RVA: 0x001A799A File Offset: 0x001A5B9A
		// (set) Token: 0x0600B92F RID: 47407 RVA: 0x001A79C5 File Offset: 0x001A5BC5
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

		// Token: 0x04006EBD RID: 28349
		[Nullable(2)]
		protected new ITalkItemPhoneMessageEmoji FbInstance;

		// Token: 0x04006EBE RID: 28350
		[Nullable(2)]
		protected new ITalkItemPhoneMessageEmoji_SetValue PocoInterface;
	}
}
