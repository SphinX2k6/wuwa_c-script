using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019A6 RID: 6566
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(IDisableBattleSkillOptionsConverter))]
	public class IDisableBattleSkillOptions
	{
		// Token: 0x06008C7F RID: 35967 RVA: 0x0014997C File Offset: 0x00147B7C
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

		// Token: 0x06008C80 RID: 35968 RVA: 0x001499B4 File Offset: 0x00147BB4
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

		// Token: 0x06008C81 RID: 35969 RVA: 0x001499C7 File Offset: 0x00147BC7
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

		// Token: 0x06008C82 RID: 35970 RVA: 0x001499DA File Offset: 0x00147BDA
		public IDisableBattleSkillOptions_SetValue ToSetValue()
		{
			return new IDisableBattleSkillOptions_SetValue
			{
				IsDisablePhantomSkill = this.IsDisablePhantomSkill,
				IsDisableCharacterSkill = this.IsDisableCharacterSkill,
				IsDisableCharacterSectionalSkill = this.IsDisableCharacterSectionalSkill
			};
		}

		// Token: 0x17002D1B RID: 11547
		// (get) Token: 0x06008C83 RID: 35971 RVA: 0x00149A08 File Offset: 0x00147C08
		// (set) Token: 0x06008C84 RID: 35972 RVA: 0x00149A42 File Offset: 0x00147C42
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

		// Token: 0x17002D1C RID: 11548
		// (get) Token: 0x06008C85 RID: 35973 RVA: 0x00149A50 File Offset: 0x00147C50
		// (set) Token: 0x06008C86 RID: 35974 RVA: 0x00149A8A File Offset: 0x00147C8A
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

		// Token: 0x17002D1D RID: 11549
		// (get) Token: 0x06008C87 RID: 35975 RVA: 0x00149A98 File Offset: 0x00147C98
		// (set) Token: 0x06008C88 RID: 35976 RVA: 0x00149AF9 File Offset: 0x00147CF9
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

		// Token: 0x04005770 RID: 22384
		[Nullable(2)]
		protected IDisableBattleSkillOptions FbInstance;

		// Token: 0x04005771 RID: 22385
		[Nullable(2)]
		protected IDisableBattleSkillOptions_SetValue PocoInterface;

		// Token: 0x04005772 RID: 22386
		private IDisableCharacterSectionalSkillOption _IsDisableCharacterSectionalSkillCache;

		// Token: 0x04005773 RID: 22387
		private bool _IsDisableCharacterSectionalSkillInited;
	}
}
