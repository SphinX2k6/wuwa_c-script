using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DCF RID: 11727
	public class ISceneActorMusicPlantsEvent : ISceneActorEvent
	{
		// Token: 0x0600FF44 RID: 65348 RVA: 0x0024CA16 File Offset: 0x0024AC16
		public static ISceneActorMusicPlantsEvent Create(ISceneActorMusicPlantsEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneActorMusicPlantsEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005054 RID: 20564
		// (get) Token: 0x0600FF45 RID: 65349 RVA: 0x0024CA35 File Offset: 0x0024AC35
		public override ESceneActorEventType Type
		{
			get
			{
				return (ESceneActorEventType)this.Instance.Type;
			}
		}

		// Token: 0x04008B59 RID: 35673
		private ISceneActorMusicPlantsEvent Instance;
	}
}
