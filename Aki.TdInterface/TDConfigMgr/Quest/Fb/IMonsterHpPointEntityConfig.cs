using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200149A RID: 5274
	public class IMonsterHpPointEntityConfig
	{
		// Token: 0x060077C8 RID: 30664 RVA: 0x0011F31E File Offset: 0x0011D51E
		public static IMonsterHpPointEntityConfig Create(IMonsterHpPointEntityConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterHpPointEntityConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002636 RID: 9782
		// (get) Token: 0x060077C9 RID: 30665 RVA: 0x0011F33D File Offset: 0x0011D53D
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17002637 RID: 9783
		// (get) Token: 0x060077CA RID: 30666 RVA: 0x0011F34A File Offset: 0x0011D54A
		public virtual int PointOfEveryOnePercentHp
		{
			get
			{
				return this.Instance.PointOfEveryOnePercentHp;
			}
		}

		// Token: 0x040044D2 RID: 17618
		private IMonsterHpPointEntityConfig Instance;
	}
}
