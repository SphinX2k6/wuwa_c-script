using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019AA RID: 6570
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(IDisableCharacterSectionalSkillOptionConverter))]
	public class IDisableCharacterSectionalSkillOption
	{
		// Token: 0x06008C93 RID: 35987 RVA: 0x00149BDC File Offset: 0x00147DDC
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

		// Token: 0x06008C94 RID: 35988 RVA: 0x00149C14 File Offset: 0x00147E14
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

		// Token: 0x06008C95 RID: 35989 RVA: 0x00149C27 File Offset: 0x00147E27
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

		// Token: 0x06008C96 RID: 35990 RVA: 0x00149C3C File Offset: 0x00147E3C
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

		// Token: 0x17002D1F RID: 11551
		// (get) Token: 0x06008C97 RID: 35991 RVA: 0x00149CE0 File Offset: 0x00147EE0
		// (set) Token: 0x06008C98 RID: 35992 RVA: 0x00149D1A File Offset: 0x00147F1A
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

		// Token: 0x17002D20 RID: 11552
		// (get) Token: 0x06008C99 RID: 35993 RVA: 0x00149D28 File Offset: 0x00147F28
		// (set) Token: 0x06008C9A RID: 35994 RVA: 0x00149D62 File Offset: 0x00147F62
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

		// Token: 0x17002D21 RID: 11553
		// (get) Token: 0x06008C9B RID: 35995 RVA: 0x00149D70 File Offset: 0x00147F70
		// (set) Token: 0x06008C9C RID: 35996 RVA: 0x00149DAA File Offset: 0x00147FAA
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

		// Token: 0x17002D22 RID: 11554
		// (get) Token: 0x06008C9D RID: 35997 RVA: 0x00149DB8 File Offset: 0x00147FB8
		// (set) Token: 0x06008C9E RID: 35998 RVA: 0x00149DF2 File Offset: 0x00147FF2
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

		// Token: 0x17002D23 RID: 11555
		// (get) Token: 0x06008C9F RID: 35999 RVA: 0x00149E00 File Offset: 0x00148000
		// (set) Token: 0x06008CA0 RID: 36000 RVA: 0x00149E3A File Offset: 0x0014803A
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

		// Token: 0x17002D24 RID: 11556
		// (get) Token: 0x06008CA1 RID: 36001 RVA: 0x00149E48 File Offset: 0x00148048
		// (set) Token: 0x06008CA2 RID: 36002 RVA: 0x00149E82 File Offset: 0x00148082
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

		// Token: 0x17002D25 RID: 11557
		// (get) Token: 0x06008CA3 RID: 36003 RVA: 0x00149E90 File Offset: 0x00148090
		// (set) Token: 0x06008CA4 RID: 36004 RVA: 0x00149ECA File Offset: 0x001480CA
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

		// Token: 0x17002D26 RID: 11558
		// (get) Token: 0x06008CA5 RID: 36005 RVA: 0x00149ED8 File Offset: 0x001480D8
		// (set) Token: 0x06008CA6 RID: 36006 RVA: 0x00149F12 File Offset: 0x00148112
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

		// Token: 0x17002D27 RID: 11559
		// (get) Token: 0x06008CA7 RID: 36007 RVA: 0x00149F20 File Offset: 0x00148120
		// (set) Token: 0x06008CA8 RID: 36008 RVA: 0x00149F5A File Offset: 0x0014815A
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

		// Token: 0x17002D28 RID: 11560
		// (get) Token: 0x06008CA9 RID: 36009 RVA: 0x00149F68 File Offset: 0x00148168
		// (set) Token: 0x06008CAA RID: 36010 RVA: 0x00149FA2 File Offset: 0x001481A2
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

		// Token: 0x17002D29 RID: 11561
		// (get) Token: 0x06008CAB RID: 36011 RVA: 0x00149FB0 File Offset: 0x001481B0
		// (set) Token: 0x06008CAC RID: 36012 RVA: 0x00149FEA File Offset: 0x001481EA
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

		// Token: 0x17002D2A RID: 11562
		// (get) Token: 0x06008CAD RID: 36013 RVA: 0x00149FF8 File Offset: 0x001481F8
		// (set) Token: 0x06008CAE RID: 36014 RVA: 0x0014A032 File Offset: 0x00148232
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

		// Token: 0x0400577A RID: 22394
		[Nullable(2)]
		protected IDisableCharacterSectionalSkillOption FbInstance;

		// Token: 0x0400577B RID: 22395
		[Nullable(2)]
		protected IDisableCharacterSectionalSkillOption_SetValue PocoInterface;
	}
}
