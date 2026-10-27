using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200218B RID: 8587
	[NullableContext(1)]
	[Nullable(0)]
	public class SendSceneActorEvent : ActionParams
	{
		// Token: 0x0600BCAE RID: 48302 RVA: 0x001B2DCC File Offset: 0x001B0FCC
		private SendSceneActorEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SendSceneActorEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SendSceneActorEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SendSceneActorEvent_SetValue());
			}
			return result;
		}

		// Token: 0x0600BCAF RID: 48303 RVA: 0x001B2E04 File Offset: 0x001B1004
		public static SendSceneActorEvent Create([Nullable(2)] SendSceneActorEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SendSceneActorEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BCB0 RID: 48304 RVA: 0x001B2E17 File Offset: 0x001B1017
		public static SendSceneActorEvent CreateFromSetValue([Nullable(2)] SendSceneActorEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SendSceneActorEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BCB1 RID: 48305 RVA: 0x001B2E2A File Offset: 0x001B102A
		public SendSceneActorEvent_SetValue ToSetValue()
		{
			return new SendSceneActorEvent_SetValue
			{
				ActorEvent = this.ActorEvent
			};
		}

		// Token: 0x17003967 RID: 14695
		// (get) Token: 0x0600BCB2 RID: 48306 RVA: 0x001B2E3D File Offset: 0x001B103D
		// (set) Token: 0x0600BCB3 RID: 48307 RVA: 0x001B2E64 File Offset: 0x001B1064
		public virtual ISceneActorEvent ActorEvent
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ActorEvent;
				}
				SendSceneActorEvent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ActorEvent;
			}
			set
			{
				this.GetOrCreatePoco().ActorEvent = value;
			}
		}

		// Token: 0x040070A6 RID: 28838
		[Nullable(2)]
		protected new SendSceneActorEvent FbInstance;

		// Token: 0x040070A7 RID: 28839
		[Nullable(2)]
		protected SendSceneActorEvent_SetValue PocoInterface;
	}
}
