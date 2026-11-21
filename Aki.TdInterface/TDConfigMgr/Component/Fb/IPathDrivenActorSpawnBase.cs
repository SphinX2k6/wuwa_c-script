using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F18 RID: 3864
	public class IPathDrivenActorSpawnBase
	{
		// Token: 0x060056E4 RID: 22244 RVA: 0x000D51DA File Offset: 0x000D33DA
		public static IPathDrivenActorSpawnBase Create(IPathDrivenActorSpawnBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPathDrivenActorSpawnBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001CAF RID: 7343
		// (get) Token: 0x060056E5 RID: 22245 RVA: 0x000D51F9 File Offset: 0x000D33F9
		public virtual EPathDrivenActorSpawnType Type
		{
			get
			{
				return (EPathDrivenActorSpawnType)this.Instance.Type;
			}
		}

		// Token: 0x040031DB RID: 12763
		private IPathDrivenActorSpawnBase Instance;
	}
}
