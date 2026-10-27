using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F74 RID: 8052
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkOptionPhoneMessageEmoji : ITalkOptionParamType
	{
		// Token: 0x0600B12E RID: 45358 RVA: 0x0019DA64 File Offset: 0x0019BC64
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

		// Token: 0x0600B12F RID: 45359 RVA: 0x0019DA9C File Offset: 0x0019BC9C
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

		// Token: 0x0600B130 RID: 45360 RVA: 0x0019DAAF File Offset: 0x0019BCAF
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

		// Token: 0x0600B131 RID: 45361 RVA: 0x0019DAC2 File Offset: 0x0019BCC2
		public new ITalkOptionPhoneMessageEmoji_SetValue ToSetValue()
		{
			return new ITalkOptionPhoneMessageEmoji_SetValue
			{
				Type = this.Type,
				EmojiId = this.EmojiId
			};
		}

		// Token: 0x170036C1 RID: 14017
		// (get) Token: 0x0600B132 RID: 45362 RVA: 0x0019DAE1 File Offset: 0x0019BCE1
		// (set) Token: 0x0600B133 RID: 45363 RVA: 0x0019DB0C File Offset: 0x0019BD0C
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

		// Token: 0x170036C2 RID: 14018
		// (get) Token: 0x0600B134 RID: 45364 RVA: 0x0019DB1C File Offset: 0x0019BD1C
		// (set) Token: 0x0600B135 RID: 45365 RVA: 0x0019DB56 File Offset: 0x0019BD56
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

		// Token: 0x04006B32 RID: 27442
		[Nullable(2)]
		protected new ITalkOptionPhoneMessageEmoji FbInstance;

		// Token: 0x04006B33 RID: 27443
		[Nullable(2)]
		protected new ITalkOptionPhoneMessageEmoji_SetValue PocoInterface;
	}
}
