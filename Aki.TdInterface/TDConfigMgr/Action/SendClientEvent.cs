using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023F0 RID: 9200
	public class SendClientEvent : ActionParams
	{
		// Token: 0x0600C84C RID: 51276 RVA: 0x001CA10C File Offset: 0x001C830C
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

		// Token: 0x0600C84D RID: 51277 RVA: 0x001CA144 File Offset: 0x001C8344
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

		// Token: 0x0600C84E RID: 51278 RVA: 0x001CA157 File Offset: 0x001C8357
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

		// Token: 0x0600C84F RID: 51279 RVA: 0x001CA16A File Offset: 0x001C836A
		public SendClientEvent_SetValue ToSetValue()
		{
			return new SendClientEvent_SetValue
			{
				EventName = this.EventName,
				Target = this.Target
			};
		}

		// Token: 0x17003C56 RID: 15446
		// (get) Token: 0x0600C850 RID: 51280 RVA: 0x001CA189 File Offset: 0x001C8389
		// (set) Token: 0x0600C851 RID: 51281 RVA: 0x001CA1B4 File Offset: 0x001C83B4
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

		// Token: 0x17003C57 RID: 15447
		// (get) Token: 0x0600C852 RID: 51282 RVA: 0x001CA1C2 File Offset: 0x001C83C2
		// (set) Token: 0x0600C853 RID: 51283 RVA: 0x001CA1E9 File Offset: 0x001C83E9
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

		// Token: 0x040076E1 RID: 30433
		[Nullable(2)]
		protected new SendClientEvent FbInstance;

		// Token: 0x040076E2 RID: 30434
		[Nullable(2)]
		protected SendClientEvent_SetValue PocoInterface;
	}
}
