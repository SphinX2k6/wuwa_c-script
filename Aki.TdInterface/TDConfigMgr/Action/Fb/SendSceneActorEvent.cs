using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002ADE RID: 10974
	[NullableContext(1)]
	[Nullable(0)]
	public class SendSceneActorEvent : ActionParams
	{
		// Token: 0x0600F099 RID: 61593 RVA: 0x0022EE0E File Offset: 0x0022D00E
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

		// Token: 0x17004C9F RID: 19615
		// (get) Token: 0x0600F09A RID: 61594 RVA: 0x0022EE2D File Offset: 0x0022D02D
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

		// Token: 0x0400845C RID: 33884
		private ISendSceneActorEvent Instance;

		// Token: 0x0400845D RID: 33885
		private ISceneActorEvent _ActorEventCache;

		// Token: 0x0400845E RID: 33886
		private bool _ActorEventInited;
	}
}
