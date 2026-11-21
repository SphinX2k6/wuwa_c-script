using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DBD RID: 3517
	public class IPasserbyNpcSpawnBase
	{
		// Token: 0x06004FE7 RID: 20455 RVA: 0x000C6AD1 File Offset: 0x000C4CD1
		public static IPasserbyNpcSpawnBase Create(IPasserbyNpcSpawnBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcSpawnBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001868 RID: 6248
		// (get) Token: 0x06004FE8 RID: 20456 RVA: 0x000C6AF0 File Offset: 0x000C4CF0
		public virtual EPasserbyNpcSpawnType Type
		{
			get
			{
				return (EPasserbyNpcSpawnType)this.Instance.Type;
			}
		}

		// Token: 0x17001869 RID: 6249
		// (get) Token: 0x06004FE9 RID: 20457 RVA: 0x000C6AFD File Offset: 0x000C4CFD
		public virtual int MaxSpawnCount
		{
			get
			{
				return this.Instance.MaxSpawnCount;
			}
		}

		// Token: 0x1700186A RID: 6250
		// (get) Token: 0x06004FEA RID: 20458 RVA: 0x000C6B0C File Offset: 0x000C4D0C
		public virtual int? MinDistance
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.MinDistance);
			}
		}

		// Token: 0x04002D8A RID: 11658
		private IPasserbyNpcSpawnBase Instance;
	}
}
