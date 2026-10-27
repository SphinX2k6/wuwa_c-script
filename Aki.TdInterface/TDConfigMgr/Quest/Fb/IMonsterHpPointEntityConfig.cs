using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200134A RID: 4938
	public class IMonsterHpPointEntityConfig
	{
		// Token: 0x06007128 RID: 28968 RVA: 0x00110DB2 File Offset: 0x0010EFB2
		[NullableContext(1)]
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

		// Token: 0x17002467 RID: 9319
		// (get) Token: 0x06007129 RID: 28969 RVA: 0x00110DD1 File Offset: 0x0010EFD1
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17002468 RID: 9320
		// (get) Token: 0x0600712A RID: 28970 RVA: 0x00110DDE File Offset: 0x0010EFDE
		public virtual int PointOfEveryOnePercentHp
		{
			get
			{
				return this.Instance.PointOfEveryOnePercentHp;
			}
		}

		// Token: 0x04004156 RID: 16726
		private IMonsterHpPointEntityConfig Instance;
	}
}
