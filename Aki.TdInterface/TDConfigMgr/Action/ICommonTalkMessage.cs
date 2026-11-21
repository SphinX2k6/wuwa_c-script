using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A93 RID: 6803
	public class ICommonTalkMessage
	{
		// Token: 0x06009083 RID: 36995 RVA: 0x00153D6C File Offset: 0x00151F6C
		private ICommonTalkMessage_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonTalkMessage 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonTalkMessage_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonTalkMessage_SetValue());
			}
			return result;
		}

		// Token: 0x06009084 RID: 36996 RVA: 0x00153DA4 File Offset: 0x00151FA4
		public static ICommonTalkMessage Create([Nullable(2)] ICommonTalkMessage instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTalkMessage
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009085 RID: 36997 RVA: 0x00153DB7 File Offset: 0x00151FB7
		public static ICommonTalkMessage CreateFromSetValue([Nullable(2)] ICommonTalkMessage_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonTalkMessage
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009086 RID: 36998 RVA: 0x00153DCA File Offset: 0x00151FCA
		public ICommonTalkMessage_SetValue ToSetValue()
		{
			return new ICommonTalkMessage_SetValue
			{
				Text = this.Text,
				TalkerId = this.TalkerId,
				TextShowDelay = this.TextShowDelay,
				TextShowDuration = this.TextShowDuration
			};
		}

		// Token: 0x17002E71 RID: 11889
		// (get) Token: 0x06009087 RID: 36999 RVA: 0x00153E01 File Offset: 0x00152001
		// (set) Token: 0x06009088 RID: 37000 RVA: 0x00153E2C File Offset: 0x0015202C
		public virtual string Text
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Text;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Text;
			}
			set
			{
				this.GetOrCreatePoco().Text = value;
			}
		}

		// Token: 0x17002E72 RID: 11890
		// (get) Token: 0x06009089 RID: 37001 RVA: 0x00153E3C File Offset: 0x0015203C
		// (set) Token: 0x0600908A RID: 37002 RVA: 0x00153E76 File Offset: 0x00152076
		public virtual int? TalkerId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TalkerId;
				}
				ICommonTalkMessage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TalkerId;
			}
			set
			{
				this.GetOrCreatePoco().TalkerId = value;
			}
		}

		// Token: 0x17002E73 RID: 11891
		// (get) Token: 0x0600908B RID: 37003 RVA: 0x00153E84 File Offset: 0x00152084
		// (set) Token: 0x0600908C RID: 37004 RVA: 0x00153EBE File Offset: 0x001520BE
		public virtual float? TextShowDelay
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TextShowDelay;
				}
				ICommonTalkMessage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TextShowDelay;
			}
			set
			{
				this.GetOrCreatePoco().TextShowDelay = value;
			}
		}

		// Token: 0x17002E74 RID: 11892
		// (get) Token: 0x0600908D RID: 37005 RVA: 0x00153ECC File Offset: 0x001520CC
		// (set) Token: 0x0600908E RID: 37006 RVA: 0x00153F06 File Offset: 0x00152106
		public virtual float? TextShowDuration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TextShowDuration;
				}
				ICommonTalkMessage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TextShowDuration;
			}
			set
			{
				this.GetOrCreatePoco().TextShowDuration = value;
			}
		}

		// Token: 0x04005A62 RID: 23138
		[Nullable(2)]
		protected ICommonTalkMessage FbInstance;

		// Token: 0x04005A63 RID: 23139
		[Nullable(2)]
		protected ICommonTalkMessage_SetValue PocoInterface;
	}
}
