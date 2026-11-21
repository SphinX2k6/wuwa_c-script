using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C29 RID: 11305
	[NullableContext(2)]
	[Nullable(0)]
	public class IDisableBattleSkillOptions
	{
		// Token: 0x0600F8C9 RID: 63689 RVA: 0x002428C6 File Offset: 0x00240AC6
		[NullableContext(0)]
		public static IDisableBattleSkillOptions Create(IDisableBattleSkillOptions? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableBattleSkillOptions
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D25 RID: 19749
		// (get) Token: 0x0600F8CA RID: 63690 RVA: 0x002428E8 File Offset: 0x00240AE8
		public virtual bool? IsDisablePhantomSkill
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsDisablePhantomSkill);
			}
		}

		// Token: 0x17004D26 RID: 19750
		// (get) Token: 0x0600F8CB RID: 63691 RVA: 0x00242920 File Offset: 0x00240B20
		public virtual bool? IsDisableCharacterSkill
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsDisableCharacterSkill);
			}
		}

		// Token: 0x17004D27 RID: 19751
		// (get) Token: 0x0600F8CC RID: 63692 RVA: 0x00242956 File Offset: 0x00240B56
		public virtual IDisableCharacterSectionalSkillOption IsDisableCharacterSectionalSkill
		{
			get
			{
				if (this._IsDisableCharacterSectionalSkillInited)
				{
					return this._IsDisableCharacterSectionalSkillCache;
				}
				this._IsDisableCharacterSectionalSkillInited = true;
				this._IsDisableCharacterSectionalSkillCache = IDisableCharacterSectionalSkillOption.Create(this.Instance.IsDisableCharacterSectionalSkill);
				return this._IsDisableCharacterSectionalSkillCache;
			}
		}

		// Token: 0x0400880D RID: 34829
		private IDisableBattleSkillOptions Instance;

		// Token: 0x0400880E RID: 34830
		private IDisableCharacterSectionalSkillOption _IsDisableCharacterSectionalSkillCache;

		// Token: 0x0400880F RID: 34831
		private bool _IsDisableCharacterSectionalSkillInited;
	}
}
