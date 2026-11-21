using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DD0 RID: 11728
	public class ISceneActorMusicLightsEvent : ISceneActorEvent
	{
		// Token: 0x0600FF47 RID: 65351 RVA: 0x0024CA4A File Offset: 0x0024AC4A
		public static ISceneActorMusicLightsEvent Create(ISceneActorMusicLightsEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneActorMusicLightsEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005055 RID: 20565
		// (get) Token: 0x0600FF48 RID: 65352 RVA: 0x0024CA69 File Offset: 0x0024AC69
		public override ESceneActorEventType Type
		{
			get
			{
				return (ESceneActorEventType)this.Instance.Type;
			}
		}

		// Token: 0x04008B5A RID: 35674
		private ISceneActorMusicLightsEvent Instance;
	}
}
