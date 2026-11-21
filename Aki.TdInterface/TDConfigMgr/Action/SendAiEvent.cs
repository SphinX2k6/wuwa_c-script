using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023EC RID: 9196
	public class SendAiEvent : ActionParams
	{
		// Token: 0x0600C83A RID: 51258 RVA: 0x001C9F3C File Offset: 0x001C813C
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

		// Token: 0x0600C83B RID: 51259 RVA: 0x001C9F74 File Offset: 0x001C8174
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

		// Token: 0x0600C83C RID: 51260 RVA: 0x001C9F87 File Offset: 0x001C8187
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

		// Token: 0x0600C83D RID: 51261 RVA: 0x001C9F9A File Offset: 0x001C819A
		public SendAiEvent_SetValue ToSetValue()
		{
			return new SendAiEvent_SetValue
			{
				EntityId = this.EntityId,
				EventType = this.EventType
			};
		}

		// Token: 0x17003C53 RID: 15443
		// (get) Token: 0x0600C83E RID: 51262 RVA: 0x001C9FBC File Offset: 0x001C81BC
		// (set) Token: 0x0600C83F RID: 51263 RVA: 0x001C9FF6 File Offset: 0x001C81F6
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

		// Token: 0x17003C54 RID: 15444
		// (get) Token: 0x0600C840 RID: 51264 RVA: 0x001CA004 File Offset: 0x001C8204
		// (set) Token: 0x0600C841 RID: 51265 RVA: 0x001CA02F File Offset: 0x001C822F
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

		// Token: 0x040076DA RID: 30426
		[Nullable(2)]
		protected new SendAiEvent FbInstance;

		// Token: 0x040076DB RID: 30427
		[Nullable(2)]
		protected SendAiEvent_SetValue PocoInterface;
	}
}
