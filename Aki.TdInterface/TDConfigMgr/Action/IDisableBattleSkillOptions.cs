using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B2D RID: 6957
	[JsonConverter(typeof(IDisableBattleSkillOptionsConverter))]
	public class IDisableBattleSkillOptions
	{
		// Token: 0x060093A3 RID: 37795 RVA: 0x0015918C File Offset: 0x0015738C
		private IDisableBattleSkillOptions_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDisableBattleSkillOptions 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDisableBattleSkillOptions_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDisableBattleSkillOptions_SetValue());
			}
			return result;
		}

		// Token: 0x060093A4 RID: 37796 RVA: 0x001591C4 File Offset: 0x001573C4
		public static IDisableBattleSkillOptions Create([Nullable(2)] IDisableBattleSkillOptions instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableBattleSkillOptions
			{
				FbInstance = instance
			};
		}

		// Token: 0x060093A5 RID: 37797 RVA: 0x001591D7 File Offset: 0x001573D7
		public static IDisableBattleSkillOptions CreateFromSetValue([Nullable(2)] IDisableBattleSkillOptions_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDisableBattleSkillOptions
			{
				PocoInterface = value
			};
		}

		// Token: 0x060093A6 RID: 37798 RVA: 0x001591EA File Offset: 0x001573EA
		public IDisableBattleSkillOptions_SetValue ToSetValue()
		{
			return new IDisableBattleSkillOptions_SetValue
			{
				IsDisablePhantomSkill = this.IsDisablePhantomSkill,
				IsDisableCharacterSkill = this.IsDisableCharacterSkill,
				IsDisableCharacterSectionalSkill = this.IsDisableCharacterSectionalSkill
			};
		}

		// Token: 0x17002F1A RID: 12058
		// (get) Token: 0x060093A7 RID: 37799 RVA: 0x00159218 File Offset: 0x00157418
		// (set) Token: 0x060093A8 RID: 37800 RVA: 0x00159252 File Offset: 0x00157452
		public virtual bool? IsDisablePhantomSkill
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsDisablePhantomSkill;
				}
				IDisableBattleSkillOptions_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsDisablePhantomSkill;
			}
			set
			{
				this.GetOrCreatePoco().IsDisablePhantomSkill = value;
			}
		}

		// Token: 0x17002F1B RID: 12059
		// (get) Token: 0x060093A9 RID: 37801 RVA: 0x00159260 File Offset: 0x00157460
		// (set) Token: 0x060093AA RID: 37802 RVA: 0x0015929A File Offset: 0x0015749A
		public virtual bool? IsDisableCharacterSkill
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsDisableCharacterSkill;
				}
				IDisableBattleSkillOptions_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsDisableCharacterSkill;
			}
			set
			{
				this.GetOrCreatePoco().IsDisableCharacterSkill = value;
			}
		}

		// Token: 0x17002F1C RID: 12060
		// (get) Token: 0x060093AB RID: 37803 RVA: 0x001592A8 File Offset: 0x001574A8
		// (set) Token: 0x060093AC RID: 37804 RVA: 0x00159309 File Offset: 0x00157509
		[Nullable(2)]
		public virtual IDisableCharacterSectionalSkillOption IsDisableCharacterSectionalSkill
		{
			[NullableContext(2)]
			get
			{
				if (this._IsDisableCharacterSectionalSkillInited)
				{
					return this._IsDisableCharacterSectionalSkillCache;
				}
				this._IsDisableCharacterSectionalSkillInited = true;
				if (this.FbInstance != null)
				{
					this._IsDisableCharacterSectionalSkillCache = IDisableCharacterSectionalSkillOption.Create(this.FbInstance.IsDisableCharacterSectionalSkill);
				}
				else
				{
					IDisableBattleSkillOptions_SetValue pocoInterface = this.PocoInterface;
					this._IsDisableCharacterSectionalSkillCache = ((pocoInterface != null) ? pocoInterface.IsDisableCharacterSectionalSkill : null);
				}
				return this._IsDisableCharacterSectionalSkillCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().IsDisableCharacterSectionalSkill = value;
				this._IsDisableCharacterSectionalSkillInited = false;
			}
		}

		// Token: 0x04005BB9 RID: 23481
		[Nullable(2)]
		protected IDisableBattleSkillOptions FbInstance;

		// Token: 0x04005BBA RID: 23482
		[Nullable(2)]
		protected IDisableBattleSkillOptions_SetValue PocoInterface;

		// Token: 0x04005BBB RID: 23483
		private IDisableCharacterSectionalSkillOption _IsDisableCharacterSectionalSkillCache;

		// Token: 0x04005BBC RID: 23484
		private bool _IsDisableCharacterSectionalSkillInited;
	}
}
