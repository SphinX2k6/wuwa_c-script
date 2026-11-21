using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001495 RID: 5269
	public class IMonsterPointEntityConfig
	{
		// Token: 0x060077AB RID: 30635 RVA: 0x0011EEAB File Offset: 0x0011D0AB
		public static IMonsterPointEntityConfig Create(IMonsterPointEntityConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterPointEntityConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002623 RID: 9763
		// (get) Token: 0x060077AC RID: 30636 RVA: 0x0011EECA File Offset: 0x0011D0CA
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17002624 RID: 9764
		// (get) Token: 0x060077AD RID: 30637 RVA: 0x0011EED7 File Offset: 0x0011D0D7
		public virtual int Point
		{
			get
			{
				return this.Instance.Point;
			}
		}

		// Token: 0x040044BF RID: 17599
		private IMonsterPointEntityConfig Instance;
	}
}
