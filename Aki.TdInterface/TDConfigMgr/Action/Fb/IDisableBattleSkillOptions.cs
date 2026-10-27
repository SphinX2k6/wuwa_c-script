using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002947 RID: 10567
	[NullableContext(2)]
	[Nullable(0)]
	public class IDisableBattleSkillOptions
	{
		// Token: 0x0600EA5E RID: 59998 RVA: 0x002252E6 File Offset: 0x002234E6
		[NullableContext(1)]
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

		// Token: 0x17004992 RID: 18834
		// (get) Token: 0x0600EA5F RID: 59999 RVA: 0x00225308 File Offset: 0x00223508
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

		// Token: 0x17004993 RID: 18835
		// (get) Token: 0x0600EA60 RID: 60000 RVA: 0x00225340 File Offset: 0x00223540
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

		// Token: 0x17004994 RID: 18836
		// (get) Token: 0x0600EA61 RID: 60001 RVA: 0x00225376 File Offset: 0x00223576
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

		// Token: 0x04008131 RID: 33073
		private IDisableBattleSkillOptions Instance;

		// Token: 0x04008132 RID: 33074
		private IDisableCharacterSectionalSkillOption _IsDisableCharacterSectionalSkillCache;

		// Token: 0x04008133 RID: 33075
		private bool _IsDisableCharacterSectionalSkillInited;
	}
}
