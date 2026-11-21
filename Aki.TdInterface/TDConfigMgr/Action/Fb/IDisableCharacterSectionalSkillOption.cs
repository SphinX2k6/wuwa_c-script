using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C28 RID: 11304
	public class IDisableCharacterSectionalSkillOption
	{
		// Token: 0x0600F8BB RID: 63675 RVA: 0x002425EA File Offset: 0x002407EA
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

		// Token: 0x17004D19 RID: 19737
		// (get) Token: 0x0600F8BC RID: 63676 RVA: 0x0024260C File Offset: 0x0024080C
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

		// Token: 0x17004D1A RID: 19738
		// (get) Token: 0x0600F8BD RID: 63677 RVA: 0x00242644 File Offset: 0x00240844
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

		// Token: 0x17004D1B RID: 19739
		// (get) Token: 0x0600F8BE RID: 63678 RVA: 0x0024267C File Offset: 0x0024087C
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

		// Token: 0x17004D1C RID: 19740
		// (get) Token: 0x0600F8BF RID: 63679 RVA: 0x002426B4 File Offset: 0x002408B4
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

		// Token: 0x17004D1D RID: 19741
		// (get) Token: 0x0600F8C0 RID: 63680 RVA: 0x002426EC File Offset: 0x002408EC
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

		// Token: 0x17004D1E RID: 19742
		// (get) Token: 0x0600F8C1 RID: 63681 RVA: 0x00242724 File Offset: 0x00240924
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

		// Token: 0x17004D1F RID: 19743
		// (get) Token: 0x0600F8C2 RID: 63682 RVA: 0x0024275C File Offset: 0x0024095C
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

		// Token: 0x17004D20 RID: 19744
		// (get) Token: 0x0600F8C3 RID: 63683 RVA: 0x00242794 File Offset: 0x00240994
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

		// Token: 0x17004D21 RID: 19745
		// (get) Token: 0x0600F8C4 RID: 63684 RVA: 0x002427D0 File Offset: 0x002409D0
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

		// Token: 0x17004D22 RID: 19746
		// (get) Token: 0x0600F8C5 RID: 63685 RVA: 0x0024280C File Offset: 0x00240A0C
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

		// Token: 0x17004D23 RID: 19747
		// (get) Token: 0x0600F8C6 RID: 63686 RVA: 0x00242848 File Offset: 0x00240A48
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

		// Token: 0x17004D24 RID: 19748
		// (get) Token: 0x0600F8C7 RID: 63687 RVA: 0x00242884 File Offset: 0x00240A84
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

		// Token: 0x0400880C RID: 34828
		private IDisableCharacterSectionalSkillOption Instance;
	}
}
