using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023F4 RID: 9204
	public class SendSceneActorEvent : ActionParams
	{
		// Token: 0x0600C85E RID: 51294 RVA: 0x001CA2C4 File Offset: 0x001C84C4
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

		// Token: 0x0600C85F RID: 51295 RVA: 0x001CA2FC File Offset: 0x001C84FC
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

		// Token: 0x0600C860 RID: 51296 RVA: 0x001CA30F File Offset: 0x001C850F
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

		// Token: 0x0600C861 RID: 51297 RVA: 0x001CA322 File Offset: 0x001C8522
		public SendSceneActorEvent_SetValue ToSetValue()
		{
			return new SendSceneActorEvent_SetValue
			{
				ActorEvent = this.ActorEvent
			};
		}

		// Token: 0x17003C59 RID: 15449
		// (get) Token: 0x0600C862 RID: 51298 RVA: 0x001CA335 File Offset: 0x001C8535
		// (set) Token: 0x0600C863 RID: 51299 RVA: 0x001CA35C File Offset: 0x001C855C
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

		// Token: 0x040076E8 RID: 30440
		[Nullable(2)]
		protected new SendSceneActorEvent FbInstance;

		// Token: 0x040076E9 RID: 30441
		[Nullable(2)]
		protected SendSceneActorEvent_SetValue PocoInterface;
	}
}
