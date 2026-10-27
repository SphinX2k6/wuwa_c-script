using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002185 RID: 8581
	[NullableContext(1)]
	[Nullable(0)]
	public class SendAiEvent : ActionParams
	{
		// Token: 0x0600BC92 RID: 48274 RVA: 0x001B2B00 File Offset: 0x001B0D00
		private SendAiEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SendAiEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SendAiEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SendAiEvent_SetValue());
			}
			return result;
		}

		// Token: 0x0600BC93 RID: 48275 RVA: 0x001B2B38 File Offset: 0x001B0D38
		public static SendAiEvent Create([Nullable(2)] SendAiEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SendAiEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BC94 RID: 48276 RVA: 0x001B2B4B File Offset: 0x001B0D4B
		public static SendAiEvent CreateFromSetValue([Nullable(2)] SendAiEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SendAiEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BC95 RID: 48277 RVA: 0x001B2B5E File Offset: 0x001B0D5E
		public SendAiEvent_SetValue ToSetValue()
		{
			return new SendAiEvent_SetValue
			{
				EntityId = this.EntityId,
				EventType = this.EventType
			};
		}

		// Token: 0x17003962 RID: 14690
		// (get) Token: 0x0600BC96 RID: 48278 RVA: 0x001B2B80 File Offset: 0x001B0D80
		// (set) Token: 0x0600BC97 RID: 48279 RVA: 0x001B2BBA File Offset: 0x001B0DBA
		public virtual int? EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				SendAiEvent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x17003963 RID: 14691
		// (get) Token: 0x0600BC98 RID: 48280 RVA: 0x001B2BC8 File Offset: 0x001B0DC8
		// (set) Token: 0x0600BC99 RID: 48281 RVA: 0x001B2BF3 File Offset: 0x001B0DF3
		public virtual EAiEventType EventType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EventType;
				}
				if (this.PocoInterface == null)
				{
					return EAiEventType.CatAndDogPlayFlow;
				}
				return this.PocoInterface.EventType;
			}
			set
			{
				this.GetOrCreatePoco().EventType = value;
			}
		}

		// Token: 0x0400709B RID: 28827
		[Nullable(2)]
		protected new SendAiEvent FbInstance;

		// Token: 0x0400709C RID: 28828
		[Nullable(2)]
		protected SendAiEvent_SetValue PocoInterface;
	}
}
