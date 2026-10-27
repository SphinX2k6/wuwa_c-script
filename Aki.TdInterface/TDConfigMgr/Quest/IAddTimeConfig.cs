using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000EBA RID: 3770
	[NullableContext(1)]
	[Nullable(0)]
	public class IAddTimeConfig
	{
		// Token: 0x06005322 RID: 21282 RVA: 0x000CCB2C File Offset: 0x000CAD2C
		private IAddTimeConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAddTimeConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAddTimeConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAddTimeConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06005323 RID: 21283 RVA: 0x000CCB64 File Offset: 0x000CAD64
		public static IAddTimeConfig Create([Nullable(2)] IAddTimeConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAddTimeConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005324 RID: 21284 RVA: 0x000CCB77 File Offset: 0x000CAD77
		public static IAddTimeConfig CreateFromSetValue([Nullable(2)] IAddTimeConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAddTimeConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005325 RID: 21285 RVA: 0x000CCB8A File Offset: 0x000CAD8A
		public IAddTimeConfig_SetValue ToSetValue()
		{
			return new IAddTimeConfig_SetValue
			{
				MonsterConfig = this.MonsterConfig,
				StateConfig = this.StateConfig
			};
		}

		// Token: 0x17001BF9 RID: 7161
		// (get) Token: 0x06005326 RID: 21286 RVA: 0x000CCBAC File Offset: 0x000CADAC
		// (set) Token: 0x06005327 RID: 21287 RVA: 0x000CCC0D File Offset: 0x000CAE0D
		[Nullable(2)]
		public virtual IKillMonster MonsterConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._MonsterConfigInited)
				{
					return this._MonsterConfigCache;
				}
				this._MonsterConfigInited = true;
				if (this.FbInstance != null)
				{
					this._MonsterConfigCache = IKillMonster.Create(this.FbInstance.MonsterConfig);
				}
				else
				{
					IAddTimeConfig_SetValue pocoInterface = this.PocoInterface;
					this._MonsterConfigCache = ((pocoInterface != null) ? pocoInterface.MonsterConfig : null);
				}
				return this._MonsterConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().MonsterConfig = value;
				this._MonsterConfigInited = false;
			}
		}

		// Token: 0x17001BFA RID: 7162
		// (get) Token: 0x06005328 RID: 21288 RVA: 0x000CCC24 File Offset: 0x000CAE24
		// (set) Token: 0x06005329 RID: 21289 RVA: 0x000CCCB7 File Offset: 0x000CAEB7
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IAddTimeStateCondition> StateConfig
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._StateConfigInited)
				{
					return this._StateConfigCache;
				}
				this._StateConfigInited = true;
				if (this.FbInstance != null)
				{
					List<IAddTimeStateCondition> stateConfig = this.FbInstance.StateConfig;
					if (stateConfig != null)
					{
						this._StateConfigCache = new List<IAddTimeStateCondition>(stateConfig.Count);
						for (int i = 0; i < stateConfig.Count; i++)
						{
							this._StateConfigCache.Add(IAddTimeStateCondition.Create(stateConfig[i]));
						}
					}
				}
				else
				{
					IAddTimeConfig_SetValue pocoInterface = this.PocoInterface;
					this._StateConfigCache = ((pocoInterface != null) ? pocoInterface.StateConfig : null);
				}
				return this._StateConfigCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().StateConfig = value;
				this._StateConfigInited = false;
			}
		}

		// Token: 0x04003265 RID: 12901
		[Nullable(2)]
		protected IAddTimeConfig FbInstance;

		// Token: 0x04003266 RID: 12902
		[Nullable(2)]
		protected IAddTimeConfig_SetValue PocoInterface;

		// Token: 0x04003267 RID: 12903
		private IKillMonster _MonsterConfigCache;

		// Token: 0x04003268 RID: 12904
		private bool _MonsterConfigInited;

		// Token: 0x04003269 RID: 12905
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IAddTimeStateCondition> _StateConfigCache;

		// Token: 0x0400326A RID: 12906
		private bool _StateConfigInited;
	}
}
