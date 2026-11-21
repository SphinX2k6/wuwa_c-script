using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001531 RID: 5425
	public class ICheckTrapDefenseEventBase
	{
		// Token: 0x06007AB1 RID: 31409 RVA: 0x001247D2 File Offset: 0x001229D2
		public static ICheckTrapDefenseEventBase Create(ICheckTrapDefenseEventBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckTrapDefenseEventBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170027F1 RID: 10225
		// (get) Token: 0x06007AB2 RID: 31410 RVA: 0x001247F1 File Offset: 0x001229F1
		public virtual ECheckTrapDefenseEvent Type
		{
			get
			{
				return (ECheckTrapDefenseEvent)this.Instance.Type;
			}
		}

		// Token: 0x040046AF RID: 18095
		private ICheckTrapDefenseEventBase Instance;
	}
}
