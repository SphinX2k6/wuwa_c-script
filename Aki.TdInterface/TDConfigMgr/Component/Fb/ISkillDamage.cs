using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B69 RID: 2921
	public class ISkillDamage
	{
		// Token: 0x0600433B RID: 17211 RVA: 0x000AB622 File Offset: 0x000A9822
		[NullableContext(1)]
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

		// Token: 0x17001226 RID: 4646
		// (get) Token: 0x0600433C RID: 17212 RVA: 0x000AB641 File Offset: 0x000A9841
		public virtual int DefaultValue
		{
			get
			{
				return this.Instance.DefaultValue;
			}
		}

		// Token: 0x17001227 RID: 4647
		// (get) Token: 0x0600433D RID: 17213 RVA: 0x000AB650 File Offset: 0x000A9850
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

		// Token: 0x17001228 RID: 4648
		// (get) Token: 0x0600433E RID: 17214 RVA: 0x000AB688 File Offset: 0x000A9888
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

		// Token: 0x17001229 RID: 4649
		// (get) Token: 0x0600433F RID: 17215 RVA: 0x000AB6C0 File Offset: 0x000A98C0
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

		// Token: 0x1700122A RID: 4650
		// (get) Token: 0x06004340 RID: 17216 RVA: 0x000AB6F8 File Offset: 0x000A98F8
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

		// Token: 0x1700122B RID: 4651
		// (get) Token: 0x06004341 RID: 17217 RVA: 0x000AB730 File Offset: 0x000A9930
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

		// Token: 0x1700122C RID: 4652
		// (get) Token: 0x06004342 RID: 17218 RVA: 0x000AB768 File Offset: 0x000A9968
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

		// Token: 0x1700122D RID: 4653
		// (get) Token: 0x06004343 RID: 17219 RVA: 0x000AB7A0 File Offset: 0x000A99A0
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

		// Token: 0x1700122E RID: 4654
		// (get) Token: 0x06004344 RID: 17220 RVA: 0x000AB7D8 File Offset: 0x000A99D8
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

		// Token: 0x1700122F RID: 4655
		// (get) Token: 0x06004345 RID: 17221 RVA: 0x000AB814 File Offset: 0x000A9A14
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

		// Token: 0x040025F6 RID: 9718
		private ISkillDamage Instance;
	}
}
