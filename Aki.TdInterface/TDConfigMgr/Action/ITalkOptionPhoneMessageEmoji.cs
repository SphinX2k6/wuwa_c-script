using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021AF RID: 8623
	public class ITalkOptionPhoneMessageEmoji : ITalkOptionParamType
	{
		// Token: 0x0600BC08 RID: 48136 RVA: 0x001B39B8 File Offset: 0x001B1BB8
		private ITalkOptionPhoneMessageEmoji_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkOptionPhoneMessageEmoji 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkOptionPhoneMessageEmoji_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkOptionPhoneMessageEmoji_SetValue());
			}
			return result;
		}

		// Token: 0x0600BC09 RID: 48137 RVA: 0x001B39F0 File Offset: 0x001B1BF0
		public static ITalkOptionPhoneMessageEmoji Create([Nullable(2)] ITalkOptionPhoneMessageEmoji instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionPhoneMessageEmoji
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BC0A RID: 48138 RVA: 0x001B3A03 File Offset: 0x001B1C03
		public static ITalkOptionPhoneMessageEmoji CreateFromSetValue([Nullable(2)] ITalkOptionPhoneMessageEmoji_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkOptionPhoneMessageEmoji
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BC0B RID: 48139 RVA: 0x001B3A16 File Offset: 0x001B1C16
		public new ITalkOptionPhoneMessageEmoji_SetValue ToSetValue()
		{
			return new ITalkOptionPhoneMessageEmoji_SetValue
			{
				Type = this.Type,
				EmojiId = this.EmojiId
			};
		}

		// Token: 0x1700398D RID: 14733
		// (get) Token: 0x0600BC0C RID: 48140 RVA: 0x001B3A35 File Offset: 0x001B1C35
		// (set) Token: 0x0600BC0D RID: 48141 RVA: 0x001B3A60 File Offset: 0x001B1C60
		public override ETalkOptionParamType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkOptionParamType.QteSucceed;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700398E RID: 14734
		// (get) Token: 0x0600BC0E RID: 48142 RVA: 0x001B3A70 File Offset: 0x001B1C70
		// (set) Token: 0x0600BC0F RID: 48143 RVA: 0x001B3AAA File Offset: 0x001B1CAA
		public virtual int? EmojiId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EmojiId;
				}
				ITalkOptionPhoneMessageEmoji_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EmojiId;
			}
			set
			{
				this.GetOrCreatePoco().EmojiId = value;
			}
		}

		// Token: 0x0400711A RID: 28954
		[Nullable(2)]
		protected new ITalkOptionPhoneMessageEmoji FbInstance;

		// Token: 0x0400711B RID: 28955
		[Nullable(2)]
		protected new ITalkOptionPhoneMessageEmoji_SetValue PocoInterface;
	}
}
