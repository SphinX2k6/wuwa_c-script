using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B31 RID: 6961
	[JsonConverter(typeof(IDisableCharacterSectionalSkillOptionConverter))]
	public class IDisableCharacterSectionalSkillOption
	{
		// Token: 0x060093B7 RID: 37815 RVA: 0x001593EC File Offset: 0x001575EC
		private IDisableCharacterSectionalSkillOption_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDisableCharacterSectionalSkillOption 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDisableCharacterSectionalSkillOption_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDisableCharacterSectionalSkillOption_SetValue());
			}
			return result;
		}

		// Token: 0x060093B8 RID: 37816 RVA: 0x00159424 File Offset: 0x00157624
		public static IDisableCharacterSectionalSkillOption Create([Nullable(2)] IDisableCharacterSectionalSkillOption instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableCharacterSectionalSkillOption
			{
				FbInstance = instance
			};
		}

		// Token: 0x060093B9 RID: 37817 RVA: 0x00159437 File Offset: 0x00157637
		public static IDisableCharacterSectionalSkillOption CreateFromSetValue([Nullable(2)] IDisableCharacterSectionalSkillOption_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDisableCharacterSectionalSkillOption
			{
				PocoInterface = value
			};
		}

		// Token: 0x060093BA RID: 37818 RVA: 0x0015944C File Offset: 0x0015764C
		public IDisableCharacterSectionalSkillOption_SetValue ToSetValue()
		{
			return new IDisableCharacterSectionalSkillOption_SetValue
			{
				DisableJump = this.DisableJump,
				DisableShowClimb = this.DisableShowClimb,
				DisableAttack = this.DisableAttack,
				DisableDodge = this.DisableDodge,
				DisableSkill1 = this.DisableSkill1,
				DisableUltimateSkill = this.DisableUltimateSkill,
				DisableExploreInput = this.DisableExploreInput,
				DisableSwitchRole1 = this.DisableSwitchRole1,
				DisableSwitchRole2 = this.DisableSwitchRole2,
				DisableSwitchRole3 = this.DisableSwitchRole3,
				DisableLock = this.DisableLock,
				DisableAim = this.DisableAim
			};
		}

		// Token: 0x17002F1E RID: 12062
		// (get) Token: 0x060093BB RID: 37819 RVA: 0x001594F0 File Offset: 0x001576F0
		// (set) Token: 0x060093BC RID: 37820 RVA: 0x0015952A File Offset: 0x0015772A
		public virtual bool? DisableJump
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableJump;
				}
				IDisableCharacterSectionalSkillOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisableJump;
			}
			set
			{
				this.GetOrCreatePoco().DisableJump = value;
			}
		}

		// Token: 0x17002F1F RID: 12063
		// (get) Token: 0x060093BD RID: 37821 RVA: 0x00159538 File Offset: 0x00157738
		// (set) Token: 0x060093BE RID: 37822 RVA: 0x00159572 File Offset: 0x00157772
		public virtual bool? DisableShowClimb
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableShowClimb;
				}
				IDisableCharacterSectionalSkillOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisableShowClimb;
			}
			set
			{
				this.GetOrCreatePoco().DisableShowClimb = value;
			}
		}

		// Token: 0x17002F20 RID: 12064
		// (get) Token: 0x060093BF RID: 37823 RVA: 0x00159580 File Offset: 0x00157780
		// (set) Token: 0x060093C0 RID: 37824 RVA: 0x001595BA File Offset: 0x001577BA
		public virtual bool? DisableAttack
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableAttack;
				}
				IDisableCharacterSectionalSkillOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisableAttack;
			}
			set
			{
				this.GetOrCreatePoco().DisableAttack = value;
			}
		}

		// Token: 0x17002F21 RID: 12065
		// (get) Token: 0x060093C1 RID: 37825 RVA: 0x001595C8 File Offset: 0x001577C8
		// (set) Token: 0x060093C2 RID: 37826 RVA: 0x00159602 File Offset: 0x00157802
		public virtual bool? DisableDodge
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableDodge;
				}
				IDisableCharacterSectionalSkillOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisableDodge;
			}
			set
			{
				this.GetOrCreatePoco().DisableDodge = value;
			}
		}

		// Token: 0x17002F22 RID: 12066
		// (get) Token: 0x060093C3 RID: 37827 RVA: 0x00159610 File Offset: 0x00157810
		// (set) Token: 0x060093C4 RID: 37828 RVA: 0x0015964A File Offset: 0x0015784A
		public virtual bool? DisableSkill1
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableSkill1;
				}
				IDisableCharacterSectionalSkillOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisableSkill1;
			}
			set
			{
				this.GetOrCreatePoco().DisableSkill1 = value;
			}
		}

		// Token: 0x17002F23 RID: 12067
		// (get) Token: 0x060093C5 RID: 37829 RVA: 0x00159658 File Offset: 0x00157858
		// (set) Token: 0x060093C6 RID: 37830 RVA: 0x00159692 File Offset: 0x00157892
		public virtual bool? DisableUltimateSkill
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableUltimateSkill;
				}
				IDisableCharacterSectionalSkillOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisableUltimateSkill;
			}
			set
			{
				this.GetOrCreatePoco().DisableUltimateSkill = value;
			}
		}

		// Token: 0x17002F24 RID: 12068
		// (get) Token: 0x060093C7 RID: 37831 RVA: 0x001596A0 File Offset: 0x001578A0
		// (set) Token: 0x060093C8 RID: 37832 RVA: 0x001596DA File Offset: 0x001578DA
		public virtual bool? DisableExploreInput
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableExploreInput;
				}
				IDisableCharacterSectionalSkillOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisableExploreInput;
			}
			set
			{
				this.GetOrCreatePoco().DisableExploreInput = value;
			}
		}

		// Token: 0x17002F25 RID: 12069
		// (get) Token: 0x060093C9 RID: 37833 RVA: 0x001596E8 File Offset: 0x001578E8
		// (set) Token: 0x060093CA RID: 37834 RVA: 0x00159722 File Offset: 0x00157922
		public virtual bool? DisableSwitchRole1
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableSwitchRole1;
				}
				IDisableCharacterSectionalSkillOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisableSwitchRole1;
			}
			set
			{
				this.GetOrCreatePoco().DisableSwitchRole1 = value;
			}
		}

		// Token: 0x17002F26 RID: 12070
		// (get) Token: 0x060093CB RID: 37835 RVA: 0x00159730 File Offset: 0x00157930
		// (set) Token: 0x060093CC RID: 37836 RVA: 0x0015976A File Offset: 0x0015796A
		public virtual bool? DisableSwitchRole2
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableSwitchRole2;
				}
				IDisableCharacterSectionalSkillOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisableSwitchRole2;
			}
			set
			{
				this.GetOrCreatePoco().DisableSwitchRole2 = value;
			}
		}

		// Token: 0x17002F27 RID: 12071
		// (get) Token: 0x060093CD RID: 37837 RVA: 0x00159778 File Offset: 0x00157978
		// (set) Token: 0x060093CE RID: 37838 RVA: 0x001597B2 File Offset: 0x001579B2
		public virtual bool? DisableSwitchRole3
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableSwitchRole3;
				}
				IDisableCharacterSectionalSkillOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisableSwitchRole3;
			}
			set
			{
				this.GetOrCreatePoco().DisableSwitchRole3 = value;
			}
		}

		// Token: 0x17002F28 RID: 12072
		// (get) Token: 0x060093CF RID: 37839 RVA: 0x001597C0 File Offset: 0x001579C0
		// (set) Token: 0x060093D0 RID: 37840 RVA: 0x001597FA File Offset: 0x001579FA
		public virtual bool? DisableLock
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableLock;
				}
				IDisableCharacterSectionalSkillOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisableLock;
			}
			set
			{
				this.GetOrCreatePoco().DisableLock = value;
			}
		}

		// Token: 0x17002F29 RID: 12073
		// (get) Token: 0x060093D1 RID: 37841 RVA: 0x00159808 File Offset: 0x00157A08
		// (set) Token: 0x060093D2 RID: 37842 RVA: 0x00159842 File Offset: 0x00157A42
		public virtual bool? DisableAim
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableAim;
				}
				IDisableCharacterSectionalSkillOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisableAim;
			}
			set
			{
				this.GetOrCreatePoco().DisableAim = value;
			}
		}

		// Token: 0x04005BC3 RID: 23491
		[Nullable(2)]
		protected IDisableCharacterSectionalSkillOption FbInstance;

		// Token: 0x04005BC4 RID: 23492
		[Nullable(2)]
		protected IDisableCharacterSectionalSkillOption_SetValue PocoInterface;
	}
}
