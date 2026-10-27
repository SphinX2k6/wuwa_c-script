using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002946 RID: 10566
	public class IDisableCharacterSectionalSkillOption
	{
		// Token: 0x0600EA50 RID: 59984 RVA: 0x0022500A File Offset: 0x0022320A
		[NullableContext(1)]
		public static IDisableCharacterSectionalSkillOption Create(IDisableCharacterSectionalSkillOption? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableCharacterSectionalSkillOption
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004986 RID: 18822
		// (get) Token: 0x0600EA51 RID: 59985 RVA: 0x0022502C File Offset: 0x0022322C
		public virtual bool? DisableJump
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DisableJump);
			}
		}

		// Token: 0x17004987 RID: 18823
		// (get) Token: 0x0600EA52 RID: 59986 RVA: 0x00225064 File Offset: 0x00223264
		public virtual bool? DisableShowClimb
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DisableShowClimb);
			}
		}

		// Token: 0x17004988 RID: 18824
		// (get) Token: 0x0600EA53 RID: 59987 RVA: 0x0022509C File Offset: 0x0022329C
		public virtual bool? DisableAttack
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DisableAttack);
			}
		}

		// Token: 0x17004989 RID: 18825
		// (get) Token: 0x0600EA54 RID: 59988 RVA: 0x002250D4 File Offset: 0x002232D4
		public virtual bool? DisableDodge
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DisableDodge);
			}
		}

		// Token: 0x1700498A RID: 18826
		// (get) Token: 0x0600EA55 RID: 59989 RVA: 0x0022510C File Offset: 0x0022330C
		public virtual bool? DisableSkill1
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DisableSkill1);
			}
		}

		// Token: 0x1700498B RID: 18827
		// (get) Token: 0x0600EA56 RID: 59990 RVA: 0x00225144 File Offset: 0x00223344
		public virtual bool? DisableUltimateSkill
		{
			get
			{
				if ((this.Instance.NullMask & 32) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DisableUltimateSkill);
			}
		}

		// Token: 0x1700498C RID: 18828
		// (get) Token: 0x0600EA57 RID: 59991 RVA: 0x0022517C File Offset: 0x0022337C
		public virtual bool? DisableExploreInput
		{
			get
			{
				if ((this.Instance.NullMask & 64) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DisableExploreInput);
			}
		}

		// Token: 0x1700498D RID: 18829
		// (get) Token: 0x0600EA58 RID: 59992 RVA: 0x002251B4 File Offset: 0x002233B4
		public virtual bool? DisableSwitchRole1
		{
			get
			{
				if ((this.Instance.NullMask & 128) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DisableSwitchRole1);
			}
		}

		// Token: 0x1700498E RID: 18830
		// (get) Token: 0x0600EA59 RID: 59993 RVA: 0x002251F0 File Offset: 0x002233F0
		public virtual bool? DisableSwitchRole2
		{
			get
			{
				if ((this.Instance.NullMask & 256) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DisableSwitchRole2);
			}
		}

		// Token: 0x1700498F RID: 18831
		// (get) Token: 0x0600EA5A RID: 59994 RVA: 0x0022522C File Offset: 0x0022342C
		public virtual bool? DisableSwitchRole3
		{
			get
			{
				if ((this.Instance.NullMask & 512) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DisableSwitchRole3);
			}
		}

		// Token: 0x17004990 RID: 18832
		// (get) Token: 0x0600EA5B RID: 59995 RVA: 0x00225268 File Offset: 0x00223468
		public virtual bool? DisableLock
		{
			get
			{
				if ((this.Instance.NullMask & 1024) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DisableLock);
			}
		}

		// Token: 0x17004991 RID: 18833
		// (get) Token: 0x0600EA5C RID: 59996 RVA: 0x002252A4 File Offset: 0x002234A4
		public virtual bool? DisableAim
		{
			get
			{
				if ((this.Instance.NullMask & 2048) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DisableAim);
			}
		}

		// Token: 0x04008130 RID: 33072
		private IDisableCharacterSectionalSkillOption Instance;
	}
}
