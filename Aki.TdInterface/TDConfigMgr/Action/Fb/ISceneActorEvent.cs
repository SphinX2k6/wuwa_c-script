using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002ADA RID: 10970
	public class ISceneActorEvent
	{
		// Token: 0x0600F08B RID: 61579 RVA: 0x0022ECD6 File Offset: 0x0022CED6
		[NullableContext(1)]
		public static ISceneActorEvent Create(ISceneActorEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneActorEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C99 RID: 19609
		// (get) Token: 0x0600F08C RID: 61580 RVA: 0x0022ECF5 File Offset: 0x0022CEF5
		public virtual ESceneActorEventType Type
		{
			get
			{
				return (ESceneActorEventType)this.Instance.Type;
			}
		}

		// Token: 0x04008454 RID: 33876
		private ISceneActorEvent Instance;
	}
}
