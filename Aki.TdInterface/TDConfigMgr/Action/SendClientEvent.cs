using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002187 RID: 8583
	[NullableContext(1)]
	[Nullable(0)]
	public class SendClientEvent : ActionParams
	{
		// Token: 0x0600BC9C RID: 48284 RVA: 0x001B2C14 File Offset: 0x001B0E14
		private SendClientEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SendClientEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SendClientEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SendClientEvent_SetValue());
			}
			return result;
		}

		// Token: 0x0600BC9D RID: 48285 RVA: 0x001B2C4C File Offset: 0x001B0E4C
		public static SendClientEvent Create([Nullable(2)] SendClientEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SendClientEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BC9E RID: 48286 RVA: 0x001B2C5F File Offset: 0x001B0E5F
		public static SendClientEvent CreateFromSetValue([Nullable(2)] SendClientEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SendClientEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BC9F RID: 48287 RVA: 0x001B2C72 File Offset: 0x001B0E72
		public SendClientEvent_SetValue ToSetValue()
		{
			return new SendClientEvent_SetValue
			{
				EventName = this.EventName,
				Target = this.Target
			};
		}

		// Token: 0x17003964 RID: 14692
		// (get) Token: 0x0600BCA0 RID: 48288 RVA: 0x001B2C91 File Offset: 0x001B0E91
		// (set) Token: 0x0600BCA1 RID: 48289 RVA: 0x001B2CBC File Offset: 0x001B0EBC
		public virtual string EventName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EventName;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.EventName;
			}
			set
			{
				this.GetOrCreatePoco().EventName = value;
			}
		}

		// Token: 0x17003965 RID: 14693
		// (get) Token: 0x0600BCA2 RID: 48290 RVA: 0x001B2CCA File Offset: 0x001B0ECA
		// (set) Token: 0x0600BCA3 RID: 48291 RVA: 0x001B2CF1 File Offset: 0x001B0EF1
		public virtual IClientEventTarget Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				SendClientEvent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Target;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
			}
		}

		// Token: 0x0400709F RID: 28831
		[Nullable(2)]
		protected new SendClientEvent FbInstance;

		// Token: 0x040070A0 RID: 28832
		[Nullable(2)]
		protected SendClientEvent_SetValue PocoInterface;
	}
}
