using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DD2 RID: 11730
	public class SendSceneActorEvent : ActionParams
	{
		// Token: 0x0600FF4F RID: 65359 RVA: 0x0024CB1A File Offset: 0x0024AD1A
		public static SendSceneActorEvent Create(ISendSceneActorEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SendSceneActorEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005059 RID: 20569
		// (get) Token: 0x0600FF50 RID: 65360 RVA: 0x0024CB39 File Offset: 0x0024AD39
		public virtual ISceneActorEvent ActorEvent
		{
			get
			{
				if (this._ActorEventInited)
				{
					return this._ActorEventCache;
				}
				this._ActorEventInited = true;
				this._ActorEventCache = ActionReadHelper.ReadSendSceneActorEvent_ActorEvent(this.Instance);
				return this._ActorEventCache;
			}
		}

		// Token: 0x04008B60 RID: 35680
		private ISendSceneActorEvent Instance;

		// Token: 0x04008B61 RID: 35681
		private ISceneActorEvent _ActorEventCache;

		// Token: 0x04008B62 RID: 35682
		private bool _ActorEventInited;
	}
}
