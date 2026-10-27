using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002189 RID: 8585
	[NullableContext(1)]
	[Nullable(0)]
	public class SendNpcMail : ActionParams
	{
		// Token: 0x0600BCA6 RID: 48294 RVA: 0x001B2D10 File Offset: 0x001B0F10
		private SendNpcMail_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SendNpcMail 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SendNpcMail_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SendNpcMail_SetValue());
			}
			return result;
		}

		// Token: 0x0600BCA7 RID: 48295 RVA: 0x001B2D48 File Offset: 0x001B0F48
		public static SendNpcMail Create([Nullable(2)] SendNpcMail instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SendNpcMail
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BCA8 RID: 48296 RVA: 0x001B2D5B File Offset: 0x001B0F5B
		public static SendNpcMail CreateFromSetValue([Nullable(2)] SendNpcMail_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SendNpcMail
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BCA9 RID: 48297 RVA: 0x001B2D6E File Offset: 0x001B0F6E
		public SendNpcMail_SetValue ToSetValue()
		{
			return new SendNpcMail_SetValue
			{
				MailId = this.MailId
			};
		}

		// Token: 0x17003966 RID: 14694
		// (get) Token: 0x0600BCAA RID: 48298 RVA: 0x001B2D81 File Offset: 0x001B0F81
		// (set) Token: 0x0600BCAB RID: 48299 RVA: 0x001B2DAC File Offset: 0x001B0FAC
		public virtual int MailId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MailId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MailId;
			}
			set
			{
				this.GetOrCreatePoco().MailId = value;
			}
		}

		// Token: 0x040070A3 RID: 28835
		[Nullable(2)]
		protected new SendNpcMail FbInstance;

		// Token: 0x040070A4 RID: 28836
		[Nullable(2)]
		protected SendNpcMail_SetValue PocoInterface;
	}
}
