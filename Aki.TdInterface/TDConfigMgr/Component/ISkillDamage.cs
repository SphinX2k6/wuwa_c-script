using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006D0 RID: 1744
	[NullableContext(1)]
	[Nullable(0)]
	public class ISkillDamage
	{
		// Token: 0x0600257A RID: 9594 RVA: 0x00064E40 File Offset: 0x00063040
		private ISkillDamage_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISkillDamage 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISkillDamage_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISkillDamage_SetValue());
			}
			return result;
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x00064E78 File Offset: 0x00063078
		public static ISkillDamage Create([Nullable(2)] ISkillDamage instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISkillDamage
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600257C RID: 9596 RVA: 0x00064E8B File Offset: 0x0006308B
		public static ISkillDamage CreateFromSetValue([Nullable(2)] ISkillDamage_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISkillDamage
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600257D RID: 9597 RVA: 0x00064EA0 File Offset: 0x000630A0
		public ISkillDamage_SetValue ToSetValue()
		{
			return new ISkillDamage_SetValue
			{
				DefaultValue = this.DefaultValue,
				NormalAttack = this.NormalAttack,
				AccumulatorAttack = this.AccumulatorAttack,
				SuperSkill = this.SuperSkill,
				QteAttack = this.QteAttack,
				NormalSkill = this.NormalSkill,
				FightVersion = this.FightVersion,
				ExploreVersion = this.ExploreVersion,
				GearOrEnvironment = this.GearOrEnvironment,
				DamageOverTime = this.DamageOverTime
			};
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x0600257E RID: 9598 RVA: 0x00064F2A File Offset: 0x0006312A
		// (set) Token: 0x0600257F RID: 9599 RVA: 0x00064F55 File Offset: 0x00063155
		public virtual int DefaultValue
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DefaultValue;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.DefaultValue;
			}
			set
			{
				this.GetOrCreatePoco().DefaultValue = value;
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06002580 RID: 9600 RVA: 0x00064F64 File Offset: 0x00063164
		// (set) Token: 0x06002581 RID: 9601 RVA: 0x00064F9E File Offset: 0x0006319E
		public virtual int? NormalAttack
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.NormalAttack;
				}
				ISkillDamage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.NormalAttack;
			}
			set
			{
				this.GetOrCreatePoco().NormalAttack = value;
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06002582 RID: 9602 RVA: 0x00064FAC File Offset: 0x000631AC
		// (set) Token: 0x06002583 RID: 9603 RVA: 0x00064FE6 File Offset: 0x000631E6
		public virtual int? AccumulatorAttack
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AccumulatorAttack;
				}
				ISkillDamage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AccumulatorAttack;
			}
			set
			{
				this.GetOrCreatePoco().AccumulatorAttack = value;
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06002584 RID: 9604 RVA: 0x00064FF4 File Offset: 0x000631F4
		// (set) Token: 0x06002585 RID: 9605 RVA: 0x0006502E File Offset: 0x0006322E
		public virtual int? SuperSkill
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SuperSkill;
				}
				ISkillDamage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SuperSkill;
			}
			set
			{
				this.GetOrCreatePoco().SuperSkill = value;
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06002586 RID: 9606 RVA: 0x0006503C File Offset: 0x0006323C
		// (set) Token: 0x06002587 RID: 9607 RVA: 0x00065076 File Offset: 0x00063276
		public virtual int? QteAttack
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.QteAttack;
				}
				ISkillDamage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.QteAttack;
			}
			set
			{
				this.GetOrCreatePoco().QteAttack = value;
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06002588 RID: 9608 RVA: 0x00065084 File Offset: 0x00063284
		// (set) Token: 0x06002589 RID: 9609 RVA: 0x000650BE File Offset: 0x000632BE
		public virtual int? NormalSkill
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.NormalSkill;
				}
				ISkillDamage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.NormalSkill;
			}
			set
			{
				this.GetOrCreatePoco().NormalSkill = value;
			}
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x0600258A RID: 9610 RVA: 0x000650CC File Offset: 0x000632CC
		// (set) Token: 0x0600258B RID: 9611 RVA: 0x00065106 File Offset: 0x00063306
		public virtual int? FightVersion
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FightVersion;
				}
				ISkillDamage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FightVersion;
			}
			set
			{
				this.GetOrCreatePoco().FightVersion = value;
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x0600258C RID: 9612 RVA: 0x00065114 File Offset: 0x00063314
		// (set) Token: 0x0600258D RID: 9613 RVA: 0x0006514E File Offset: 0x0006334E
		public virtual int? ExploreVersion
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ExploreVersion;
				}
				ISkillDamage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ExploreVersion;
			}
			set
			{
				this.GetOrCreatePoco().ExploreVersion = value;
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x0600258E RID: 9614 RVA: 0x0006515C File Offset: 0x0006335C
		// (set) Token: 0x0600258F RID: 9615 RVA: 0x00065196 File Offset: 0x00063396
		public virtual int? GearOrEnvironment
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GearOrEnvironment;
				}
				ISkillDamage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.GearOrEnvironment;
			}
			set
			{
				this.GetOrCreatePoco().GearOrEnvironment = value;
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06002590 RID: 9616 RVA: 0x000651A4 File Offset: 0x000633A4
		// (set) Token: 0x06002591 RID: 9617 RVA: 0x000651DE File Offset: 0x000633DE
		public virtual int? DamageOverTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DamageOverTime;
				}
				ISkillDamage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DamageOverTime;
			}
			set
			{
				this.GetOrCreatePoco().DamageOverTime = value;
			}
		}

		// Token: 0x04001996 RID: 6550
		[Nullable(2)]
		protected ISkillDamage FbInstance;

		// Token: 0x04001997 RID: 6551
		[Nullable(2)]
		protected ISkillDamage_SetValue PocoInterface;
	}
}
