using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DCE RID: 11726
	public class ISceneActorEvent
	{
		// Token: 0x0600FF41 RID: 65345 RVA: 0x0024C9E2 File Offset: 0x0024ABE2
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

		// Token: 0x17005053 RID: 20563
		// (get) Token: 0x0600FF42 RID: 65346 RVA: 0x0024CA01 File Offset: 0x0024AC01
		public virtual ESceneActorEventType Type
		{
			get
			{
				return (ESceneActorEventType)this.Instance.Type;
			}
		}

		// Token: 0x04008B58 RID: 35672
		private ISceneActorEvent Instance;
	}
}
