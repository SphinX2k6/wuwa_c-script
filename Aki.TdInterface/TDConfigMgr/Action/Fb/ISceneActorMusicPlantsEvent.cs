using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002ADB RID: 10971
	public class ISceneActorMusicPlantsEvent : ISceneActorEvent
	{
		// Token: 0x0600F08E RID: 61582 RVA: 0x0022ED0A File Offset: 0x0022CF0A
		[NullableContext(1)]
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

		// Token: 0x17004C9A RID: 19610
		// (get) Token: 0x0600F08F RID: 61583 RVA: 0x0022ED29 File Offset: 0x0022CF29
		public override ESceneActorEventType Type
		{
			get
			{
				return (ESceneActorEventType)this.Instance.Type;
			}
		}

		// Token: 0x04008455 RID: 33877
		private ISceneActorMusicPlantsEvent Instance;
	}
}
