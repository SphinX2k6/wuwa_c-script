using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C37 RID: 3127
	public class ISkillDamage
	{
		// Token: 0x06004794 RID: 18324 RVA: 0x000B56E6 File Offset: 0x000B38E6
		public static ISkillDamage Create(ISkillDamage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISkillDamage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001321 RID: 4897
		// (get) Token: 0x06004795 RID: 18325 RVA: 0x000B5705 File Offset: 0x000B3905
		public virtual int DefaultValue
		{
			get
			{
				return this.Instance.DefaultValue;
			}
		}

		// Token: 0x17001322 RID: 4898
		// (get) Token: 0x06004796 RID: 18326 RVA: 0x000B5714 File Offset: 0x000B3914
		public virtual int? NormalAttack
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.NormalAttack);
			}
		}

		// Token: 0x17001323 RID: 4899
		// (get) Token: 0x06004797 RID: 18327 RVA: 0x000B574C File Offset: 0x000B394C
		public virtual int? AccumulatorAttack
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.AccumulatorAttack);
			}
		}

		// Token: 0x17001324 RID: 4900
		// (get) Token: 0x06004798 RID: 18328 RVA: 0x000B5784 File Offset: 0x000B3984
		public virtual int? SuperSkill
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new int?(this.Instance.SuperSkill);
			}
		}

		// Token: 0x17001325 RID: 4901
		// (get) Token: 0x06004799 RID: 18329 RVA: 0x000B57BC File Offset: 0x000B39BC
		public virtual int? QteAttack
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new int?(this.Instance.QteAttack);
			}
		}

		// Token: 0x17001326 RID: 4902
		// (get) Token: 0x0600479A RID: 18330 RVA: 0x000B57F4 File Offset: 0x000B39F4
		public virtual int? NormalSkill
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new int?(this.Instance.NormalSkill);
			}
		}

		// Token: 0x17001327 RID: 4903
		// (get) Token: 0x0600479B RID: 18331 RVA: 0x000B582C File Offset: 0x000B3A2C
		public virtual int? FightVersion
		{
			get
			{
				if ((this.Instance.NullMask & 32) == 0)
				{
					return null;
				}
				return new int?(this.Instance.FightVersion);
			}
		}

		// Token: 0x17001328 RID: 4904
		// (get) Token: 0x0600479C RID: 18332 RVA: 0x000B5864 File Offset: 0x000B3A64
		public virtual int? ExploreVersion
		{
			get
			{
				if ((this.Instance.NullMask & 64) == 0)
				{
					return null;
				}
				return new int?(this.Instance.ExploreVersion);
			}
		}

		// Token: 0x17001329 RID: 4905
		// (get) Token: 0x0600479D RID: 18333 RVA: 0x000B589C File Offset: 0x000B3A9C
		public virtual int? GearOrEnvironment
		{
			get
			{
				if ((this.Instance.NullMask & 128) == 0)
				{
					return null;
				}
				return new int?(this.Instance.GearOrEnvironment);
			}
		}

		// Token: 0x1700132A RID: 4906
		// (get) Token: 0x0600479E RID: 18334 RVA: 0x000B58D8 File Offset: 0x000B3AD8
		public virtual int? DamageOverTime
		{
			get
			{
				if ((this.Instance.NullMask & 256) == 0)
				{
					return null;
				}
				return new int?(this.Instance.DamageOverTime);
			}
		}

		// Token: 0x0400283E RID: 10302
		private ISkillDamage Instance;
	}
}
