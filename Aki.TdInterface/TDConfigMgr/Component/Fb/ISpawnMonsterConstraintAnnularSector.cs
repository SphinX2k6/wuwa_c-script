using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C50 RID: 3152
	public class ISpawnMonsterConstraintAnnularSector : ISpwanMonsterMode
	{
		// Token: 0x06004825 RID: 18469 RVA: 0x000B69FC File Offset: 0x000B4BFC
		public static ISpawnMonsterConstraintAnnularSector Create(ISpawnMonsterConstraintAnnularSector? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpawnMonsterConstraintAnnularSector
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001380 RID: 4992
		// (get) Token: 0x06004826 RID: 18470 RVA: 0x000B6A1B File Offset: 0x000B4C1B
		public override ESpawnMonsterConstraint Type
		{
			get
			{
				return (ESpawnMonsterConstraint)this.Instance.Type;
			}
		}

		// Token: 0x17001381 RID: 4993
		// (get) Token: 0x06004827 RID: 18471 RVA: 0x000B6A28 File Offset: 0x000B4C28
		public virtual float InnerRadius
		{
			get
			{
				return this.Instance.InnerRadius;
			}
		}

		// Token: 0x17001382 RID: 4994
		// (get) Token: 0x06004828 RID: 18472 RVA: 0x000B6A35 File Offset: 0x000B4C35
		public virtual float OuterRadius
		{
			get
			{
				return this.Instance.OuterRadius;
			}
		}

		// Token: 0x17001383 RID: 4995
		// (get) Token: 0x06004829 RID: 18473 RVA: 0x000B6A42 File Offset: 0x000B4C42
		public virtual float Angle
		{
			get
			{
				return this.Instance.Angle;
			}
		}

		// Token: 0x04002883 RID: 10371
		private ISpawnMonsterConstraintAnnularSector Instance;
	}
}
