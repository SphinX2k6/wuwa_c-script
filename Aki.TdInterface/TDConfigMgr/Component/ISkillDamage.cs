using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000771 RID: 1905
	public class ISkillDamage
	{
		// Token: 0x0600289A RID: 10394 RVA: 0x0006BEB0 File Offset: 0x0006A0B0
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

		// Token: 0x0600289B RID: 10395 RVA: 0x0006BEE8 File Offset: 0x0006A0E8
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

		// Token: 0x0600289C RID: 10396 RVA: 0x0006BEFB File Offset: 0x0006A0FB
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

		// Token: 0x0600289D RID: 10397 RVA: 0x0006BF10 File Offset: 0x0006A110
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

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x0600289E RID: 10398 RVA: 0x0006BF9A File Offset: 0x0006A19A
		// (set) Token: 0x0600289F RID: 10399 RVA: 0x0006BFC5 File Offset: 0x0006A1C5
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

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x060028A0 RID: 10400 RVA: 0x0006BFD4 File Offset: 0x0006A1D4
		// (set) Token: 0x060028A1 RID: 10401 RVA: 0x0006C00E File Offset: 0x0006A20E
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

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x060028A2 RID: 10402 RVA: 0x0006C01C File Offset: 0x0006A21C
		// (set) Token: 0x060028A3 RID: 10403 RVA: 0x0006C056 File Offset: 0x0006A256
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

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x060028A4 RID: 10404 RVA: 0x0006C064 File Offset: 0x0006A264
		// (set) Token: 0x060028A5 RID: 10405 RVA: 0x0006C09E File Offset: 0x0006A29E
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

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x060028A6 RID: 10406 RVA: 0x0006C0AC File Offset: 0x0006A2AC
		// (set) Token: 0x060028A7 RID: 10407 RVA: 0x0006C0E6 File Offset: 0x0006A2E6
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

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x060028A8 RID: 10408 RVA: 0x0006C0F4 File Offset: 0x0006A2F4
		// (set) Token: 0x060028A9 RID: 10409 RVA: 0x0006C12E File Offset: 0x0006A32E
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

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x060028AA RID: 10410 RVA: 0x0006C13C File Offset: 0x0006A33C
		// (set) Token: 0x060028AB RID: 10411 RVA: 0x0006C176 File Offset: 0x0006A376
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

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x060028AC RID: 10412 RVA: 0x0006C184 File Offset: 0x0006A384
		// (set) Token: 0x060028AD RID: 10413 RVA: 0x0006C1BE File Offset: 0x0006A3BE
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

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x060028AE RID: 10414 RVA: 0x0006C1CC File Offset: 0x0006A3CC
		// (set) Token: 0x060028AF RID: 10415 RVA: 0x0006C206 File Offset: 0x0006A406
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

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x060028B0 RID: 10416 RVA: 0x0006C214 File Offset: 0x0006A414
		// (set) Token: 0x060028B1 RID: 10417 RVA: 0x0006C24E File Offset: 0x0006A44E
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

		// Token: 0x04001B95 RID: 7061
		[Nullable(2)]
		protected ISkillDamage FbInstance;

		// Token: 0x04001B96 RID: 7062
		[Nullable(2)]
		protected ISkillDamage_SetValue PocoInterface;
	}
}
