using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023F2 RID: 9202
	public class SendNpcMail : ActionParams
	{
		// Token: 0x0600C856 RID: 51286 RVA: 0x001CA208 File Offset: 0x001C8408
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

		// Token: 0x0600C857 RID: 51287 RVA: 0x001CA240 File Offset: 0x001C8440
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

		// Token: 0x0600C858 RID: 51288 RVA: 0x001CA253 File Offset: 0x001C8453
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

		// Token: 0x0600C859 RID: 51289 RVA: 0x001CA266 File Offset: 0x001C8466
		public SendNpcMail_SetValue ToSetValue()
		{
			return new SendNpcMail_SetValue
			{
				MailId = this.MailId
			};
		}

		// Token: 0x17003C58 RID: 15448
		// (get) Token: 0x0600C85A RID: 51290 RVA: 0x001CA279 File Offset: 0x001C8479
		// (set) Token: 0x0600C85B RID: 51291 RVA: 0x001CA2A4 File Offset: 0x001C84A4
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

		// Token: 0x040076E5 RID: 30437
		[Nullable(2)]
		protected new SendNpcMail FbInstance;

		// Token: 0x040076E6 RID: 30438
		[Nullable(2)]
		protected SendNpcMail_SetValue PocoInterface;
	}
}
